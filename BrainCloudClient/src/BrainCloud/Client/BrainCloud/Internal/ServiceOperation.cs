﻿//----------------------------------------------------
// brainCloud client source code
// Copyright 2016 bitHeads, inc.
//----------------------------------------------------

using System;

namespace BrainCloud.Internal
{
    /**
     * List of all available service operations. The values are mapped to server keys which represent that operation.
     */
    internal class ServiceOperation
    {
        public static readonly ServiceOperation Authenticate = new ServiceOperation("AUTHENTICATE");
        public static readonly ServiceOperation Attach = new ServiceOperation("ATTACH");
        public static readonly ServiceOperation Merge = new ServiceOperation("MERGE");
        public static readonly ServiceOperation Detach = new ServiceOperation("DETACH");
        public static readonly ServiceOperation ResetEmailPassword = new ServiceOperation("RESET_EMAIL_PASSWORD");
        public static readonly ServiceOperation SwitchToChildProfile = new ServiceOperation("SWITCH_TO_CHILD_PROFILE");
        public static readonly ServiceOperation SwitchToParentProfile = new ServiceOperation("SWITCH_TO_PARENT_PROFILE");

        public static readonly ServiceOperation Create = new ServiceOperation("CREATE");
        public static readonly ServiceOperation CreateWithIndexedId = new ServiceOperation("CREATE_WITH_INDEXED_ID");
        public static readonly ServiceOperation Reset = new ServiceOperation("RESET");
        public static readonly ServiceOperation Read = new ServiceOperation("READ");
        public static readonly ServiceOperation ReadSingleton = new ServiceOperation("READ_SINGLETON");
        public static readonly ServiceOperation ReadByType = new ServiceOperation("READ_BY_TYPE");
        public static readonly ServiceOperation Verify = new ServiceOperation("VERIFY");
        public static readonly ServiceOperation ReadShared = new ServiceOperation("READ_SHARED");
        public static readonly ServiceOperation ReadSharedEntity = new ServiceOperation("READ_SHARED_ENTITY");

        // push notification
        public static readonly ServiceOperation DeregisterAll = new ServiceOperation("DEREGISTER_ALL");
        public static readonly ServiceOperation Deregister = new ServiceOperation("DEREGISTER");
        public static readonly ServiceOperation Register = new ServiceOperation("REGISTER");
        public static readonly ServiceOperation SendSimple = new ServiceOperation("SEND_SIMPLE");
        public static readonly ServiceOperation SendRich = new ServiceOperation("SEND_RICH");

        public static readonly ServiceOperation FullReset = new ServiceOperation("FULL_PLAYER_RESET");
        public static readonly ServiceOperation DataReset = new ServiceOperation("GAME_DATA_RESET");

        public static readonly ServiceOperation Update = new ServiceOperation("UPDATE");
        public static readonly ServiceOperation UpdateShared = new ServiceOperation("UPDATE_SHARED");
        public static readonly ServiceOperation UpdateAcl = new ServiceOperation("UPDATE_ACL");
        public static readonly ServiceOperation UpdateTimeToLive = new ServiceOperation("UPDATE_TIME_TO_LIVE");
        public static readonly ServiceOperation UpdatePartial = new ServiceOperation("UPDATE_PARTIAL");
        public static readonly ServiceOperation UpdateSingleton = new ServiceOperation("UPDATE_SINGLETON");
        public static readonly ServiceOperation Delete = new ServiceOperation("DELETE");
        public static readonly ServiceOperation DeleteSingleton = new ServiceOperation("DELETE_SINGLETON");
        public static readonly ServiceOperation UpdateSummary = new ServiceOperation("UPDATE_SUMMARY");
        public static readonly ServiceOperation UpdateSetMinimum = new ServiceOperation("UPDATE_SET_MINIMUM");
        public static readonly ServiceOperation UpdateIncrementToMaximum = new ServiceOperation("UPDATE_INCREMENT_TO_MAXIMUM");
        public static readonly ServiceOperation GetFriendProfileInfoForExternalId = new ServiceOperation("GET_FRIEND_PROFILE_INFO_FOR_EXTERNAL_ID");
        public static readonly ServiceOperation GetExternalIdForProfileId = new ServiceOperation("GET_EXTERNAL_ID_FOR_PROFILE_ID");
        public static readonly ServiceOperation FindPlayerByUniversalId = new ServiceOperation("FIND_PLAYER_BY_UNIVERSAL_ID");
        public static readonly ServiceOperation ReadFriends = new ServiceOperation("READ_FRIENDS");
        public static readonly ServiceOperation ReadFriendEntity = new ServiceOperation("READ_FRIEND_ENTITY");
        public static readonly ServiceOperation ReadFriendsEntities = new ServiceOperation("READ_FRIENDS_ENTITIES");
        public static readonly ServiceOperation ReadFriendsWithApplication = new ServiceOperation("READ_FRIENDS_WITH_APPLICATION");
        public static readonly ServiceOperation ReadFriendPlayerState = new ServiceOperation("READ_FRIEND_PLAYER_STATE");
        public static readonly ServiceOperation FindPlayerByName = new ServiceOperation("FIND_PLAYER_BY_NAME");
        public static readonly ServiceOperation ListFriends = new ServiceOperation("LIST_FRIENDS");
        public static readonly ServiceOperation AddFriends = new ServiceOperation("ADD_FRIENDS");
        public static readonly ServiceOperation RemoveFriends = new ServiceOperation("REMOVE_FRIENDS");
        public static readonly ServiceOperation GetSocialLeaderboard = new ServiceOperation("GET_SOCIAL_LEADERBOARD");
        public static readonly ServiceOperation GetMultiSocialLeaderboard = new ServiceOperation("GET_MULTI_SOCIAL_LEADERBOARD");
        public static readonly ServiceOperation GetGlobalLeaderboard = new ServiceOperation("GET_GLOBAL_LEADERBOARD");
        public static readonly ServiceOperation GetGlobalLeaderboardPage = new ServiceOperation("GET_GLOBAL_LEADERBOARD_PAGE");
        public static readonly ServiceOperation GetGlobalLeaderboardView = new ServiceOperation("GET_GLOBAL_LEADERBOARD_VIEW");
        public static readonly ServiceOperation GetGlobalLeaderboardVersions = new ServiceOperation("GET_GLOBAL_LEADERBOARD_VERSIONS");
        public static readonly ServiceOperation PostScore = new ServiceOperation("POST_SCORE");
        public static readonly ServiceOperation PostScoreDynamic = new ServiceOperation("POST_SCORE_DYNAMIC");
        public static readonly ServiceOperation GetCompletedTournament = new ServiceOperation("GET_COMPLETED_TOURNAMENT");
        public static readonly ServiceOperation RewardTournament = new ServiceOperation("REWARD_TOURNAMENT");

        public static readonly ServiceOperation ReadFriendsPlayerState = new ServiceOperation("READ_FRIEND_PLAYER_STATE");

        public static readonly ServiceOperation InitThirdParty = new ServiceOperation("initThirdParty");
        public static readonly ServiceOperation PostThirdPartyLeaderboardScore = new ServiceOperation("postThirdPartyLeaderboardScore");
        public static readonly ServiceOperation IncrementThirdPartyLeaderboardScore = new ServiceOperation("incrementThirdPartyLeaderboardScore");
        public static readonly ServiceOperation LaunchAchievementUI = new ServiceOperation("launchAchievementUI");
        public static readonly ServiceOperation PostThirdPartyLeaderboardAchievement = new ServiceOperation("postThirdPartyLeaderboardAchievement");
        public static readonly ServiceOperation IsThirdPartyAchievementComplete = new ServiceOperation("isThirdPartyAchievementComplete");
        public static readonly ServiceOperation ResetThirdPartyAchievements = new ServiceOperation("resetThirdPartyAchievements");
        public static readonly ServiceOperation QueryThirdPartyAchievements = new ServiceOperation("queryThirdPartyAchievements");

        public static readonly ServiceOperation GetInventory = new ServiceOperation("GET_INVENTORY");
        public static readonly ServiceOperation CashInReceipt = new ServiceOperation("OP_CASH_IN_RECEIPT");
        public static readonly ServiceOperation AwardVC = new ServiceOperation("AWARD_VC");
        public static readonly ServiceOperation ConsumePlayerVC = new ServiceOperation("CONSUME_VC");
        public static readonly ServiceOperation GetPlayerVC = new ServiceOperation("GET_PLAYER_VC");
        public static readonly ServiceOperation ResetPlayerVC = new ServiceOperation("RESET_PLAYER_VC");

        public static readonly ServiceOperation AwardParentCurrency = new ServiceOperation("AWARD_PARENT_VC");
        public static readonly ServiceOperation ConsumeParentCurrency = new ServiceOperation("CONSUME_PARENT_VC");
        public static readonly ServiceOperation GetParentCurrency = new ServiceOperation("GET_PARENT_VC");
        public static readonly ServiceOperation ResetParentCurrency = new ServiceOperation("RESET_PARENT_VC");

        public static readonly ServiceOperation Send = new ServiceOperation("SEND");
        public static readonly ServiceOperation UpdateEventData = new ServiceOperation("UPDATE_EVENT_DATA");
        public static readonly ServiceOperation DeleteSent = new ServiceOperation("DELETE_SENT");
        public static readonly ServiceOperation DeleteIncoming = new ServiceOperation("DELETE_INCOMING");
        public static readonly ServiceOperation GetEvents = new ServiceOperation("GET_EVENTS");

        public static readonly ServiceOperation UpdateIncrement = new ServiceOperation("UPDATE_INCREMENT");
        public static readonly ServiceOperation ReadNextXpLevel = new ServiceOperation("READ_NEXT_XPLEVEL");
        public static readonly ServiceOperation ReadXpLevels = new ServiceOperation("READ_XP_LEVELS");
        public static readonly ServiceOperation SetXpPoints = new ServiceOperation("SET_XPPOINTS");
        public static readonly ServiceOperation ReadSubset = new ServiceOperation("READ_SUBSET");

        public static readonly ServiceOperation Run = new ServiceOperation("RUN");
        public static readonly ServiceOperation Tweet = new ServiceOperation("TWEET");

        public static readonly ServiceOperation AwardAchievements = new ServiceOperation("AWARD_ACHIEVEMENTS");
        public static readonly ServiceOperation ReadAchievements = new ServiceOperation("READ_ACHIEVEMENTS");
        public static readonly ServiceOperation ReadAchievedAchievements = new ServiceOperation("READ_ACHIEVED_ACHIEVEMENTS");

        public static readonly ServiceOperation SetPlayerRating = new ServiceOperation("SET_PLAYER_RATING");
        public static readonly ServiceOperation ResetPlayerRating = new ServiceOperation("RESET_PLAYER_RATING");
        public static readonly ServiceOperation IncrementPlayerRating = new ServiceOperation("INCREMENT_PLAYER_RATING");
        public static readonly ServiceOperation DecrementPlayerRating = new ServiceOperation("DECREMENT_PLAYER_RATING");
        public static readonly ServiceOperation ShieldOn = new ServiceOperation("SHIELD_ON");
        public static readonly ServiceOperation ShieldOnFor = new ServiceOperation("SHIELD_ON_FOR");
        public static readonly ServiceOperation ShieldOff = new ServiceOperation("SHIELD_OFF");
        public static readonly ServiceOperation GetShieldExpiry = new ServiceOperation("GET_SHIELD_EXPIRY");
        public static readonly ServiceOperation FindPlayers = new ServiceOperation("FIND_PLAYERS");
        public static readonly ServiceOperation FindPlayersUsingFilter = new ServiceOperation("FIND_PLAYERS_USING_FILTER");

        [Obsolete]
        public static readonly ServiceOperation GetOneWayPlayers = new ServiceOperation("GET_ONEWAY_PLAYERS");
        [Obsolete]
        public static readonly ServiceOperation GetOneWayPlayersFilter = new ServiceOperation("GET_ONEWAY_PLAYERS_FILTER");

        public static readonly ServiceOperation SubmitTurn = new ServiceOperation("SUBMIT_TURN");
        public static readonly ServiceOperation UpdateMatchSummary = new ServiceOperation("UPDATE_SUMMARY");
        public static readonly ServiceOperation Abandon = new ServiceOperation("ABANDON");
        public static readonly ServiceOperation Complete = new ServiceOperation("COMPLETE");
        public static readonly ServiceOperation ReadMatch = new ServiceOperation("READ_MATCH");
        public static readonly ServiceOperation ReadMatchHistory = new ServiceOperation("READ_MATCH_HISTORY");
        public static readonly ServiceOperation FindMatches = new ServiceOperation("FIND_MATCHES");
        public static readonly ServiceOperation FindMatchesCompleted = new ServiceOperation("FIND_MATCHES_COMPLETED");
        public static readonly ServiceOperation DeleteMatch = new ServiceOperation("DELETE_MATCH");

        public static readonly ServiceOperation LastUploadStatus = new ServiceOperation("LAST_UPLOAD_STATUS");

        public static readonly ServiceOperation ReadQuests = new ServiceOperation("READ_QUESTS");
        public static readonly ServiceOperation ReadCompletedQuests = new ServiceOperation("READ_COMPLETED_QUESTS");
        public static readonly ServiceOperation ReadInProgressQuests = new ServiceOperation("READ_IN_PROGRESS_QUESTS");
        public static readonly ServiceOperation ReadNotStartedQuests = new ServiceOperation("READ_NOT_STARTED_QUESTS");
        public static readonly ServiceOperation ReadQuestsWithStatus = new ServiceOperation("READ_QUESTS_WITH_STATUS");
        public static readonly ServiceOperation ReadQuestsWithBasicPercentage = new ServiceOperation("READ_QUESTS_WITH_BASIC_PERCENTAGE");
        public static readonly ServiceOperation ReadQuestsWithComplexPercentage = new ServiceOperation("READ_QUESTS_WITH_COMPLEX_PERCENTAGE");
        public static readonly ServiceOperation ReadQuestsByCategory = new ServiceOperation("READ_QUESTS_BY_CATEGORY");
        public static readonly ServiceOperation ResetMilestones = new ServiceOperation("RESET_MILESTONES");

        public static readonly ServiceOperation ReadForCategory = new ServiceOperation("READ_FOR_CATEGORY");

        public static readonly ServiceOperation ReadMilestones = new ServiceOperation("READ_MILESTONES");
        public static readonly ServiceOperation ReadMilestonesByCategory = new ServiceOperation("READ_MILESTONES_BY_CATEGORY");

        public static readonly ServiceOperation ReadCompletedMilestones = new ServiceOperation("READ_COMPLETED_MILESTONES");
        public static readonly ServiceOperation ReadInProgressMilestones = new ServiceOperation("READ_IN_PROGRESS_MILESTONES");

        public static readonly ServiceOperation Trigger = new ServiceOperation("TRIGGER");
        public static readonly ServiceOperation TriggerMultiple = new ServiceOperation("TRIGGER_MULTIPLE");

        public static readonly ServiceOperation Logout = new ServiceOperation("LOGOUT");

        public static readonly ServiceOperation StartMatch = new ServiceOperation("START_MATCH");
        public static readonly ServiceOperation CancelMatch = new ServiceOperation("CANCEL_MATCH");
        public static readonly ServiceOperation CompleteMatch = new ServiceOperation("COMPLETE_MATCH");
        public static readonly ServiceOperation EnableMatchMaking = new ServiceOperation("ENABLE_FOR_MATCH");
        public static readonly ServiceOperation DisableMatchMaking = new ServiceOperation("DISABLE_FOR_MATCH");
        public static readonly ServiceOperation UpdateName = new ServiceOperation("UPDATE_NAME");

        public static readonly ServiceOperation StartStream = new ServiceOperation("START_STREAM");
        public static readonly ServiceOperation ReadStream = new ServiceOperation("READ_STREAM");
        public static readonly ServiceOperation EndStream = new ServiceOperation("END_STREAM");
        public static readonly ServiceOperation DeleteStream = new ServiceOperation("DELETE_STREAM");
        public static readonly ServiceOperation AddEvent = new ServiceOperation("ADD_EVENT");
        public static readonly ServiceOperation GetStreamSummariesForInitiatingPlayer = new ServiceOperation("GET_STREAM_SUMMARIES_FOR_INITIATING_PLAYER");
        public static readonly ServiceOperation GetStreamSummariesForTargetPlayer = new ServiceOperation("GET_STREAM_SUMMARIES_FOR_TARGET_PLAYER");

        public static readonly ServiceOperation GetUserInfo = new ServiceOperation("GET_USER_INFO");
        public static readonly ServiceOperation InitializeTransaction = new ServiceOperation("INITIALIZE_TRANSACTION");
        public static readonly ServiceOperation FinalizeTransaction = new ServiceOperation("FINALIZE_TRANSACTION");

        public static readonly ServiceOperation StartSteamTransaction = new ServiceOperation("START_STEAM_TRANSACTION");
        public static readonly ServiceOperation FinalizeSteamTransaction = new ServiceOperation("FINALIZE_STEAM_TRANSACTION");
        public static readonly ServiceOperation VerifyMicrosoftReceipt = new ServiceOperation("VERIFY_MICROSOFT_RECEIPT");
        public static readonly ServiceOperation EligiblePromotions = new ServiceOperation("ELIGIBLE_PROMOTIONS");

        public static readonly ServiceOperation GetList = new ServiceOperation("GET_LIST");
        public static readonly ServiceOperation GetListByIndexedId = new ServiceOperation("GET_LIST_BY_INDEXED_ID");
        public static readonly ServiceOperation GetListCount = new ServiceOperation("GET_LIST_COUNT");
        public static readonly ServiceOperation GetPage = new ServiceOperation("GET_PAGE");
        public static readonly ServiceOperation GetPageOffset = new ServiceOperation("GET_PAGE_BY_OFFSET");

        public static readonly ServiceOperation UpdatePictureUrl = new ServiceOperation("UPDATE_PICTURE_URL");
        public static readonly ServiceOperation UpdateContactEmail = new ServiceOperation("UPDATE_CONTACT_EMAIL");

        public static readonly ServiceOperation GetAttributes = new ServiceOperation("GET_ATTRIBUTES");
        public static readonly ServiceOperation UpdateAttributes = new ServiceOperation("UPDATE_ATTRIBUTES");
        public static readonly ServiceOperation RemoveAttributes = new ServiceOperation("REMOVE_ATTRIBUTES");
        public static readonly ServiceOperation GetChildProfiles = new ServiceOperation("GET_CHILD_PROFILES");

        public static readonly ServiceOperation FbConfirmPurchase = new ServiceOperation("FB_CONFIRM_PURCHASE");
        public static readonly ServiceOperation GooglePlayConfirmPurchase = new ServiceOperation("CONFIRM_GOOGLEPLAY_PURCHASE");

        public static readonly ServiceOperation ReadProperties = new ServiceOperation("READ_PROPERTIES");

        public static readonly ServiceOperation GetUpdatedFiles = new ServiceOperation("GET_UPDATED_FILES");
        public static readonly ServiceOperation GetFileList = new ServiceOperation("GET_FILE_LIST");

        public static readonly ServiceOperation ScheduleCloudScript = new ServiceOperation("SCHEDULE_CLOUD_SCRIPT");
        public static readonly ServiceOperation RunParentScript = new ServiceOperation("RUN_PARENT_SCRIPT");

        //RedemptionCode
        public static readonly ServiceOperation GetRedeemedCodes = new ServiceOperation("GET_REDEEMED_CODES");
        public static readonly ServiceOperation RedeemCode = new ServiceOperation("REDEEM_CODE");

        //DataStream
        public static readonly ServiceOperation CustomPageEvent = new ServiceOperation("CUSTOM_PAGE_EVENT");
        public static readonly ServiceOperation CustomScreenEvent = new ServiceOperation("CUSTOM_SCREEN_EVENT");
        public static readonly ServiceOperation CustomTrackEvent = new ServiceOperation("CUSTOM_TRACK_EVENT");

        //Profanity
        public static readonly ServiceOperation ProfanityCheck = new ServiceOperation("PROFANITY_CHECK");
        public static readonly ServiceOperation ProfanityReplaceText = new ServiceOperation("PROFANITY_REPLACE_TEXT");
        public static readonly ServiceOperation ProfanityIdentifyBadWords = new ServiceOperation("PROFANITY_IDENTIFY_BAD_WORDS");

        //file upload
        public static readonly ServiceOperation PrepareUserUpload = new ServiceOperation("PREPARE_USER_UPLOAD");
        public static readonly ServiceOperation ListUserFiles = new ServiceOperation("LIST_USER_FILES");
        public static readonly ServiceOperation DeleteUserFile = new ServiceOperation("DELETE_USER_FILE");
        public static readonly ServiceOperation DeleteUserFiles = new ServiceOperation("DELETE_USER_FILES");


        private ServiceOperation(string value)
        {
            Value = value;
        }

        public string Value
        {
            get;
            private set;
        }

    }
}
