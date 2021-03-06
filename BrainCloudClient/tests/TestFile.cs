using NUnit.Core;
using NUnit.Framework;
using BrainCloud;
using System.Collections.Generic;
using JsonFx.Json;
using System.IO;
using System.Threading;
using System;

namespace BrainCloudTests
{
    [TestFixture]
    public class TestFile : TestFixtureBase
    {
        private const string _cloudPath = "";

        private int _returnCount = 0;
        private int _successCount = 0;
        private int _failCount = 0;

        [TearDown]
        public void Cleanup()
        {
            BrainCloudClient.Instance.DeregisterFileUploadCallbacks();
            DeleteAllFiles();
            _returnCount = 0;
            _successCount = 0;
            _failCount = 0;
        }

        [Test]
        public void TestListUserFiles()
        {
            TestResult tr = new TestResult();

            BrainCloudClient.Instance.FileService.ListUserFiles(tr.ApiSuccess, tr.ApiError);

            tr.Run();
        }

        [Test]
        public void TestSimpleUpload()
        {
            TestResult tr = new TestResult();
            BrainCloudClient.Instance.RegisterFileUploadCallbacks(FileCallbackSuccess, FileCallbackFail);

            FileInfo info = new FileInfo(CreateFile(4024));

            BrainCloudClient.Instance.FileService.UploadFile(
                _cloudPath,
                info.Name,
                true,
                true,
                info.FullName,
                tr.ApiSuccess, tr.ApiError);

            tr.Run();

            BrainCloudClient.Instance.RegisterFileUploadCallbacks(FileCallbackSuccess, FileCallbackFail);

            WaitForReturn(new[] { GetUploadId(tr.m_response) });

            Assert.IsFalse(_failCount > 0);
        }

        [Test]
        public void TestUploadSimpleFileAndCancel()
        {
            DeleteAllFiles();

            TestResult tr = new TestResult();
            BrainCloudClient.Instance.RegisterFileUploadCallbacks(FileCallbackSuccess, FileCallbackFail);

            FileInfo info = new FileInfo(CreateFile(12 * 1024));

            BrainCloudClient.Instance.FileService.UploadFile(
                _cloudPath,
                "testFileCANCEL.dat",
                true,
                true,
                info.FullName,
                tr.ApiSuccess, tr.ApiError);

            tr.Run();

            BrainCloudClient.Instance.RegisterFileUploadCallbacks(FileCallbackSuccess, FileCallbackFail);

            WaitForReturn(new[] { GetUploadId(tr.m_response) }, 500);

            Thread.Sleep(5000);

            BrainCloudClient.Instance.FileService.ListUserFiles(tr.ApiSuccess, tr.ApiError);
            tr.Run();

            var fileList = ((object[])((Dictionary<string, object>)tr.m_response["data"])["fileList"]);

            Console.WriteLine("\nDid fail = " + (_failCount > 0));
            Console.WriteLine("File list length  = " + fileList.Length + "\n");

            Assert.IsFalse(_failCount <= 0 || fileList.Length > 0);
        }

        [Test]
        public void TestDeleteUserFile()
        {
            TestResult tr = new TestResult();
            BrainCloudClient.Instance.RegisterFileUploadCallbacks(FileCallbackSuccess, FileCallbackFail);

            FileInfo info = new FileInfo(CreateFile(4024));

            BrainCloudClient.Instance.FileService.UploadFile(
                _cloudPath,
                info.Name,
                true,
                true,
                info.FullName,
                tr.ApiSuccess, tr.ApiError);

            tr.Run();

            WaitForReturn(new[] { GetUploadId(tr.m_response) });

            Assert.IsFalse(_failCount > 0);

            BrainCloudClient.Instance.FileService.DeleteUserFile(
                GetCloudPath(tr.m_response),
                info.Name,
                tr.ApiSuccess, tr.ApiError);

            tr.Run();
        }


        [Test]
        public void TestGetCdnUrl()
        {
            TestResult tr = new TestResult();
            BrainCloudClient.Instance.RegisterFileUploadCallbacks(FileCallbackSuccess, FileCallbackFail);

            FileInfo info = new FileInfo(CreateFile(1024));

            BrainCloudClient.Instance.FileService.UploadFile(
                _cloudPath,
                info.Name,
                true,
                true,
                info.FullName,
                tr.ApiSuccess, tr.ApiError);

            tr.Run();

            WaitForReturn(new[] { GetUploadId(tr.m_response) });

            Assert.IsFalse(_failCount > 0);

            BrainCloudClient.Instance.FileService.GetCDNUrl(
                GetCloudPath(tr.m_response),
                info.Name,
                tr.ApiSuccess, tr.ApiError);

            tr.Run();
        }

        [Test]
        public void TestDeleteUserFiles()
        {
            TestResult tr = new TestResult();
            BrainCloudClient.Instance.RegisterFileUploadCallbacks(FileCallbackSuccess, FileCallbackFail);

            FileInfo info = new FileInfo(CreateFile(4024));

            BrainCloudClient.Instance.FileService.UploadFile(
                _cloudPath,
                info.Name,
                true,
                true,
                info.FullName,
                tr.ApiSuccess, tr.ApiError);

            tr.Run();

            WaitForReturn(new[] { GetUploadId(tr.m_response) });

            Assert.IsFalse(_failCount > 0);

            BrainCloudClient.Instance.FileService.DeleteUserFiles(
                GetCloudPath(tr.m_response),
                true,
                tr.ApiSuccess, tr.ApiError);

            tr.Run();
        }

        [Test]
        public void TestUploadMultiple()
        {
            TestResult tr = new TestResult();
            BrainCloudClient.Instance.RegisterFileUploadCallbacks(FileCallbackSuccess, FileCallbackFail);

            FileInfo info1 = new FileInfo(CreateFile(4096, "multiUpload1.dat"));
            FileInfo info2 = new FileInfo(CreateFile(4096, "multiUpload2.dat"));

            BrainCloudClient.Instance.FileService.UploadFile(
                _cloudPath,
                info1.Name,
                true,
                true,
                info1.FullName,
                tr.ApiSuccess, tr.ApiError);

            tr.Run();
            string id1 = GetUploadId(tr.m_response);

            BrainCloudClient.Instance.FileService.UploadFile(
                _cloudPath,
                info2.Name,
                true,
                true,
                info2.FullName,
                tr.ApiSuccess, tr.ApiError);

            tr.Run();

            WaitForReturn(new[] { id1, GetUploadId(tr.m_response) });

            Assert.IsFalse(_failCount > 0);
        }

        private void FileCallbackSuccess(string uploadId, string jsonData)
        {
            _returnCount++;
            _successCount++;
        }

        private void FileCallbackFail(string uploadId, int statusCode, int reasonCode, string jsonData)
        {
            _returnCount++;
            _failCount++;
        }

        private void WaitForReturn(string[] uploadIds, int cancelTime = -1)
        {
            int count = 0;
            bool sw = true;

            BrainCloudClient _client = BrainCloudClient.Instance;

            _client.Update();
            while (_returnCount < uploadIds.Length && count < 1000 * 30)
            {

                for (int i = 0; i < uploadIds.Length; i++)
                {
                    double progress = _client.FileService.GetUploadProgress(uploadIds[i]);

                    if (progress > -1 && sw)
                    {
                        string logStr = "File " + (i + 1) + " Progress: " +
                            progress + " | " +
                            _client.FileService.GetUploadBytesTransferred(uploadIds[i]) + "/" +
                            _client.FileService.GetUploadTotalBytesToTransfer(uploadIds[i]);
                        Console.WriteLine(logStr);
                    }

                    if (cancelTime > 0 && progress > 0.05)
                    {
                        _client.FileService.CancelUpload(uploadIds[i]);
                    }
                }

                _client.Update();
                sw = !sw;

                Thread.Sleep(150);
                count += 150;
            }
        }

        private string GetUploadId(Dictionary<string, object> response)
        {
            var fileDetails = ((Dictionary<string, object>)((Dictionary<string, object>)response["data"])["fileDetails"]);
            return (string)(fileDetails["uploadId"]);
        }

        private string GetCloudPath(Dictionary<string, object> response)
        {
            var fileDetails = ((Dictionary<string, object>)((Dictionary<string, object>)response["data"])["fileDetails"]);
            return (string)(fileDetails["cloudPath"]);
        }

        private void DeleteAllFiles()
        {
            TestResult tr = new TestResult();
            BrainCloudClient.Instance.FileService.DeleteUserFiles("", true, tr.ApiSuccess, tr.ApiError);
            tr.Run();
        }

        /// <summary>
        /// Creates a test file filled with garbage
        /// </summary>
        /// <param name="size">Size of the file in KB</param>
        /// <returns>Full path to the file</returns>
        private string CreateFile(int size, string name = "testFile.dat")
        {
            string path = Path.Combine(Path.GetTempPath() + name);

            using (var fileStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                fileStream.SetLength(1024 * size);
            }

            return path;
        }
    }
}