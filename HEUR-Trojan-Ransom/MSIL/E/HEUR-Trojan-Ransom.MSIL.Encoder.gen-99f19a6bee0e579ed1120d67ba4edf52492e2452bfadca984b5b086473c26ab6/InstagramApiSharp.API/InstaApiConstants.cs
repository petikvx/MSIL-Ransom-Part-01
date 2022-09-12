using System;
using Newtonsoft.Json.Linq;

namespace InstagramApiSharp.API;

internal static class InstaApiConstants
{
	public const string ACCEPT_ENCODING = "gzip, deflate, sdch";

	public const string API = "/api";

	public const string API_SUFFIX = "/api/v1";

	public const string API_SUFFIX_V2 = "/api/v2";

	public const string API_VERSION = "/v1";

	public const string API_VERSION_V2 = "/v2";

	public const string BASE_INSTAGRAM_API_URL = "https://i.instagram.com/api/v1/";

	public const string COMMENT_BREADCRUMB_KEY = "iN4$aGr0m";

	public const string CSRFTOKEN = "csrftoken";

	public const string HEADER_ACCEPT_ENCODING = "gzip, deflate, sdch";

	public const string HEADER_ACCEPT_LANGUAGE = "Accept-Language";

	public const string HEADER_COUNT = "count";

	public const string HEADER_EXCLUDE_LIST = "exclude_list";

	public const string HEADER_IG_APP_ID = "X-IG-App-ID";

	public const string HEADER_IG_CAPABILITIES = "X-IG-Capabilities";

	public const string HEADER_IG_CONNECTION_TYPE = "X-IG-Connection-Type";

	public const string HEADER_IG_SIGNATURE = "signed_body";

	public const string HEADER_IG_SIGNATURE_KEY_VERSION = "ig_sig_key_version";

	public const string HEADER_MAX_ID = "max_id";

	public const string HEADER_PHONE_ID = "phone_id";

	public const string HEADER_QUERY = "q";

	public const string HEADER_RANK_TOKEN = "rank_token";

	public const string HEADER_TIMEZONE = "timezone_offset";

	public const string HEADER_USER_AGENT = "User-Agent";

	public const string HEADER_X_INSTAGRAM_AJAX = "X-Instagram-AJAX";

	public const string HEADER_X_REQUESTED_WITH = "X-Requested-With";

	public const string HEADER_XCSRF_TOKEN = "X-CSRFToken";

	public const string HEADER_XGOOGLE_AD_IDE = "X-Google-AD-ID";

	public const string HEADER_XML_HTTP_REQUEST = "XMLHttpRequest";

	public const string IG_APP_ID = "567067343352427";

	public const string IG_CONNECTION_TYPE = "WIFI";

	public const string IG_SIGNATURE_KEY_VERSION = "4";

	public const string INSTAGRAM_URL = "https://i.instagram.com";

	public const string P_SUFFIX = "p/";

	public const string SUPPORTED_CAPABALITIES_HEADER = "supported_capabilities_new";

	public static string TIMEZONE = "Asia/Tehran";

	public static int TIMEZONE_OFFSET = 16200;

	public const string USER_AGENT = "Instagram {6} Android ({7}/{8}; {0}; {1}; {2}; {3}; {4}; {5}; en_US; {9})";

	public const string USER_AGENT_DEFAULT = "Instagram 44.0.0.9.93 Android (24/7.0; 640dpi; 1440x2560; samsung; SM-G935F; hero2lte; samsungexynos8890; en_US; 107092322)";

	public static readonly JArray SupportedCapabalities = new JArray
	{
		new JObject
		{
			{ "name", "SUPPORTED_SDK_VERSIONS" },
			{ "value", "13.0,14.0,15.0,16.0,17.0,18.0,19.0,20.0,21.0,22.0,23.0,24.0,25.0,26.0,27.0,28.0,29.0,30.0,31.0,32.0,33.0,34.0,35.0,36.0,37.0,38.0,39.0,40.0,41.0,42.0,43.0,44.0,45.0,46.0,47.0,48.0,49.0,50.0,51.0,52.0,53.0" }
		},
		new JObject
		{
			{ "name", "FACE_TRACKER_VERSION" },
			{ "value", "12" }
		},
		new JObject
		{
			{ "name", "segmentation" },
			{ "value", "segmentation_enabled" }
		},
		new JObject
		{
			{ "name", "COMPRESSION" },
			{ "value", "ETC2_COMPRESSION" }
		},
		new JObject
		{
			{ "name", "WORLD_TRACKER" },
			{ "value", "WORLD_TRACKER_ENABLED" }
		}
	};

	public static string ACCEPT_LANGUAGE = "en-US";

	public const string FACEBOOK_LOGIN_URI = "https://m.facebook.com/v2.3/dialog/oauth?access_token=&client_id=124024574287414&e2e={0}&scope=email&default_audience=friends&redirect_uri=fbconnect://success&display=touch&response_type=token,signed_request&return_scopes=true";

	public const string FACEBOOK_TOKEN = "https://graph.facebook.com/me?access_token={0}&fields=id,is_employee,name";

	public const string FACEBOOK_TOKEN_PICTURE = "https://graph.facebook.com/me?access_token={0}&fields=picture";

	public const string FACEBOOK_USER_AGENT = "Mozilla/5.0 (Linux; Android {0}; {1} Build/{2}; wv) AppleWebKit/537.36 (KHTML, like Gecko) Version/4.0 Chrome/69.0.3497.100 Mobile Safari/537.36";

	public const string FACEBOOK_USER_AGENT_DEFAULT = "Mozilla/5.0 (Linux; Android 7.0; PRA-LA1 Build/HONORPRA-LA1; wv) AppleWebKit/537.36 (KHTML, like Gecko) Version/4.0 Chrome/69.0.3497.100 Mobile Safari/537.36";

	public const string WEB_USER_AGENT = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/70.0.3538.102 Safari/537.36 OPR/57.0.3098.116";

	public const string ERROR_OCCURRED = "Oops, an error occurred";

	public static readonly Uri BaseInstagramUri = new Uri("https://i.instagram.com/api/v1/");

	public const string ACCOUNTS_2FA_LOGIN = "/api/v1/accounts/two_factor_login/";

	public const string ACCOUNTS_2FA_LOGIN_AGAIN = "/api/v1/accounts/send_two_factor_login_sms/";

	public const string ACCOUNTS_CHANGE_PROFILE_PICTURE = "/api/v1/accounts/change_profile_picture/";

	public const string ACCOUNTS_CHECK_PHONE_NUMBER = "/api/v1/accounts/check_phone_number/";

	public const string ACCOUNTS_CONTACT_POINT_PREFILL = "/api/v1/accounts/contact_point_prefill/";

	public const string ACCOUNTS_CREATE = "/api/v1/accounts/create/";

	public const string ACCOUNTS_CREATE_VALIDATED = "/api/v1/accounts/create_validated/";

	public const string ACCOUNTS_DISABLE_SMS_TWO_FACTOR = "/api/v1/accounts/disable_sms_two_factor/";

	public const string ACCOUNTS_EDIT_PROFILE = "/api/v1/accounts/edit_profile/";

	public const string ACCOUNTS_ENABLE_SMS_TWO_FACTOR = "/api/v1/accounts/enable_sms_two_factor/";

	public const string ACCOUNTS_GET_COMMENT_FILTER = "/api/v1/accounts/get_comment_filter/";

	public const string ACCOUNTS_LOGIN = "/api/v1/accounts/login/";

	public const string ACCOUNTS_LOGOUT = "/api/v1/accounts/logout/";

	public const string ACCOUNTS_READ_MSISDN_HEADER = "/api/v1/accounts/read_msisdn_header/";

	public const string ACCOUNTS_REGEN_BACKUP_CODES = "/api/v1/accounts/regen_backup_codes/";

	public const string ACCOUNTS_REMOVE_PROFILE_PICTURE = "/api/v1/accounts/remove_profile_picture/";

	public const string ACCOUNTS_REQUEST_PROFILE_EDIT = "/api/v1/accounts/current_user/?edit=true";

	public const string ACCOUNTS_SECURITY_INFO = "/api/v1/accounts/account_security_info/";

	public const string ACCOUNTS_SEND_CONFIRM_EMAIL = "/api/v1/accounts/send_confirm_email/";

	public const string ACCOUNTS_SEND_RECOVERY_EMAIL = "/api/v1/accounts/send_recovery_flow_email/";

	public const string ACCOUNTS_SEND_SIGNUP_SMS_CODE = "/api/v1/accounts/send_signup_sms_code/";

	public const string ACCOUNTS_SEND_SMS_CODE = "/api/v1/accounts/send_sms_code/";

	public const string ACCOUNTS_SEND_TWO_FACTOR_ENABLE_SMS = "/api/v1/accounts/send_two_factor_enable_sms/";

	public const string ACCOUNTS_SET_BIOGRAPHY = "/api/v1/accounts/set_biography/";

	public const string ACCOUNTS_SET_PHONE_AND_NAME = "/api/v1/accounts/set_phone_and_name/";

	public const string ACCOUNTS_SET_PRESENCE_DISABLED = "/api/v1/accounts/set_presence_disabled/";

	public const string ACCOUNTS_UPDATE_BUSINESS_INFO = "/api/v1/accounts/update_business_info/";

	public const string ACCOUNTS_USERNAME_SUGGESTIONS = "/api/v1/accounts/username_suggestions/";

	public const string ACCOUNTS_VALIDATE_SIGNUP_SMS_CODE = "/api/v1/accounts/validate_signup_sms_code/";

	public const string ACCOUNTS_VERIFY_SMS_CODE = "/api/v1/accounts/verify_sms_code/";

	public const string CHANGE_PASSWORD = "/api/v1/accounts/change_password/";

	public const string CURRENTUSER = "/api/v1/accounts/current_user?edit=true";

	public const string SET_ACCOUNT_PRIVATE = "/api/v1/accounts/set_private/";

	public const string SET_ACCOUNT_PUBLIC = "/api/v1/accounts/set_public/";

	public const string ACCOUNTS_CONVERT_TO_PERSONAL = "/api/v1/accounts/convert_to_personal/";

	public const string ACCOUNTS_CREATE_BUSINESS_INFO = "/api/v1/accounts/create_business_info/";

	public const string ACCOUNTS_GET_PRESENCE = "/api/v1/accounts/get_presence_disabled/";

	public const string ACCOUNTS_GET_BLOCKED_COMMENTERS = "/api/v1/accounts/get_blocked_commenters/";

	public const string ACCOUNTS_SET_BLOCKED_COMMENTERS = "/api/v1/accounts/set_blocked_commenters/";

	public const string BUSINESS_INSTANT_EXPERIENCE = "/api/v1/business/instant_experience/get_ix_partners_bundle/?signed_body={0}&ig_sig_key_version={1}";

	public const string BUSINESS_SET_CATEGORY = "/api/v1/business/account/set_business_category/";

	public const string BUSINESS_VALIDATE_URL = "/api/v1/business/instant_experience/ix_validate_url/";

	public const string BUSINESS_BRANDED_GET_SETTINGS = "/api/v1/business/branded_content/get_whitelist_settings/";

	public const string BUSINESS_BRANDED_USER_SEARCH = "/api/v1/users/search/?q={0}&count={1}&branded_content_creator_only=true";

	public const string BUSINESS_BRANDED_UPDATE_SETTINGS = "/api/v1/business/branded_content/update_whitelist_settings/";

	public const string BUSINESS_CONVERT_TO_BUSINESS_ACCOUNT = "/api/v1/business_conversion/get_business_convert_social_context/";

	public const string COLLECTION_CREATE_MODULE = "/api/v1collection_create";

	public const string CREATE_COLLECTION = "/api/v1/collections/create/";

	public const string DELETE_COLLECTION = "/api/v1/collections/{0}/delete/";

	public const string EDIT_COLLECTION = "/api/v1/collections/{0}/edit/";

	public const string FEED_SAVED_ADD_TO_COLLECTION_MODULE = "feed_saved_add_to_collection";

	public const string GET_LIST_COLLECTIONS = "/api/v1/collections/list/";

	public const string CONSENT_NEW_USER_FLOW = "/api/v1/consent/new_user_flow/";

	public const string CONSENT_NEW_USER_FLOW_BEGINS = "/api/v1/consent/new_user_flow_begins/";

	public const string DIRECT_BROADCAST_CONFIGURE_VIDEO = "/api/v1/direct_v2/threads/broadcast/configure_video/";

	public const string DIRECT_BROADCAST_LINK = "/api/v1/direct_v2/threads/broadcast/link/";

	public const string DIRECT_BROADCAST_THREAD_LIKE = "/api/v1/direct_v2/threads/broadcast/like/";

	public const string DIRECT_BROADCAST_LOCATION = "/api/v1/direct_v2/threads/broadcast/location/";

	public const string DIRECT_BROADCAST_MEDIA_SHARE = "/api/v1/direct_v2/threads/broadcast/media_share/?media_type={0}";

	public const string DIRECT_BROADCAST_PROFILE = "/api/v1/direct_v2/threads/broadcast/profile/";

	public const string DIRECT_BROADCAST_REACTION = "/api/v1/direct_v2/threads/broadcast/reaction/";

	public const string DIRECT_BROADCAST_REEL_SHARE = "/api/v1/direct_v2/threads/broadcast/reel_share/";

	public const string DIRECT_BROADCAST_UPLOAD_PHOTO = "/api/v1/direct_v2/threads/broadcast/upload_photo/";

	public const string DIRECT_BROADCAST_HASHTAG = "/api/v1/direct_v2/threads/broadcast/hashtag/";

	public const string DIRECT_BROADCAST_LIVE_VIEWER_INVITE = "/api/v1/direct_v2/threads/broadcast/live_viewer_invite/";

	public const string DIRECT_CREATE_GROUP = "/api/v1/direct_v2/create_group_thread/";

	public const string DIRECT_PRESENCE = "/api/v1/direct_v2/get_presence/";

	public const string DIRECT_SHARE = "/api/v1/direct_share/inbox/";

	public const string DIRECT_STAR = "/api/v1/direct_v2/threads/{0}/label/";

	public const string DIRECT_THREAD_HIDE = "/api/v1/direct_v2/threads/{0}/hide/";

	public const string DIRECT_THREAD_ADD_USER = "/api/v1/direct_v2/threads/{0}/add_user/";

	public const string DIRECT_THREAD_ITEM_SEEN = "/api/v1/direct_v2/visual_threads/{0}/item_seen/";

	public const string DIRECT_THREAD_SEEN = "/api/v1/direct_v2/threads/{0}/items/{1}/seen/";

	public const string DIRECT_THREAD_LEAVE = "/api/v1/direct_v2/threads/{0}/leave/";

	public const string DIRECT_THREAD_MUTE = "/api/v1/direct_v2/threads/{0}/mute/";

	public const string DIRECT_THREAD_UNMUTE = "/api/v1/direct_v2/threads/{0}/unmute/";

	public const string DIRECT_THREAD_UPDATE_TITLE = "/api/v1/direct_v2/threads/{0}/update_title/";

	public const string DIRECT_UNSTAR = "/api/v1/direct_v2/threads/{0}/unlabel/";

	public const string GET_DIRECT_INBOX = "/api/v1/direct_v2/inbox/";

	public const string GET_DIRECT_PENDING_INBOX = "/api/v1/direct_v2/pending_inbox/";

	public const string GET_DIRECT_SHARE_USER = "/api/v1/direct_v2/threads/broadcast/profile/";

	public const string GET_DIRECT_TEXT_BROADCAST = "/api/v1/direct_v2/threads/broadcast/text/";

	public const string GET_DIRECT_THREAD = "/api/v1/direct_v2/threads/{0}";

	public const string GET_DIRECT_THREAD_APPROVE = "/api/v1/direct_v2/threads/{0}/approve/";

	public const string GET_DIRECT_THREAD_APPROVE_MULTIPLE = "/api/v1/direct_v2/threads/approve_multiple/";

	public const string GET_DIRECT_THREAD_DECLINE = "/api/v1/direct_v2/threads/{0}/decline/";

	public const string GET_DIRECT_THREAD_DECLINE_MULTIPLE = "/api/v1/direct_v2/threads/decline_multiple/";

	public const string GET_DIRECT_THREAD_DECLINEALL = "/api/v1/direct_v2/threads/decline_all/";

	public const string GET_PARTICIPANTS_RECIPIENT_USER = "/api/v1/direct_v2/threads/get_by_participants/?recipient_users=[{0}]";

	public const string GET_RANK_RECIPIENTS_BY_USERNAME = "/api/v1/direct_v2/ranked_recipients/?mode=raven&show_threads=true&query={0}&use_unified_inbox=true";

	public const string GET_RANKED_RECIPIENTS = "/api/v1/direct_v2/ranked_recipients";

	public const string GET_RECENT_RECIPIENTS = "/api/v1/direct_share/recent_recipients/";

	public const string STORY_SHARE = "/api/v1/direct_v2/threads/broadcast/story_share/?media_type={0}";

	public const string DIRECT_THREAD_DELETE_MESSAGE = "/api/v1/direct_v2/threads/{0}/items/{1}/delete/";

	public const string DISCOVER_AYML = "/api/v1/discover/ayml/";

	public const string DISCOVER_CHAINING = "/api/v1/discover/chaining/?target_id={0}";

	public const string DISCOVER_EXPLORE = "/api/v1/discover/explore/";

	public const string DISCOVER_TOPICAL_EXPLORE = "/api/v1/discover/topical_explore/";

	public const string DISCOVER_FETCH_SUGGESTION_DETAILS = "/api/v1/discover/fetch_suggestion_details/?target_id={0}&chained_ids={1}";

	public const string DISCOVER_TOP_LIVE = "/api/v1/discover/top_live/";

	public const string DISCOVER_TOP_LIVE_STATUS = "/api/v1/discover/top_live_status/";

	public const string FBSEARCH_CLEAR_SEARCH_HISTORY = "/api/v1/fbsearch/clear_search_history";

	public const string FBSEARCH_GET_HIDDEN_SEARCH_ENTITIES = "/api/v1/fbsearch/get_hidden_search_entities/";

	public const string FBSEARCH_HIDE_SEARCH_ENTITIES = "/api/v1/fbsearch/hide_search_entities/";

	public const string FBSEARCH_PLACES = "/api/v1/fbsearch/places/";

	public const string FBSEARCH_PROFILE_SEARCH = "/api/v1/fbsearch/profile_link_search/?q={0}&count={1}";

	public const string FBSEARCH_RECENT_SEARCHES = "/api/v1/fbsearch/recent_searches/";

	public const string FBSEARCH_SUGGESTED_SEARCHS = "/api/v1/fbsearch/suggested_searches/?type={0}";

	public const string FBSEARCH_TOPSEARCH = "/api/v1/fbsearch/topsearch/";

	public const string FBSEARCH_TOPSEARCH_FALT = "/api/v1/fbsearch/topsearch_flat/";

	public const string FBSEARCH_TOPSEARCH_FALT_PARAMETER = "/api/v1/fbsearch/topsearch_flat/?rank_token={0}&timezone_offset={1}&query={2}&context={3}";

	public const string FB_ENTRYPOINT_INFO = "/api/v1/fb/fb_entrypoint_info/";

	public const string FB_FACEBOOK_SIGNUP = "/api/v1/fb/facebook_signup/";

	public const string FB_GET_INVITE_SUGGESTIONS = "/api/v1/fb/get_invite_suggestions/";

	public const string FEED_ONLY_ME_FEED = "/api/v1/feed/only_me_feed/";

	public const string FEED_POPULAR = "/v1/feed/popular/?people_teaser_supported=1&rank_token={0}&ranked_content=true";

	public const string FEED_PROMOTABLE_MEDIA = "/api/v1/feed/promotable_media/";

	public const string FEED_REEL_MEDIA = "/api/v1/feed/reels_media/";

	public const string FEED_SAVED = "/api/v1/feed/saved/";

	public const string GET_COLLECTION = "/api/v1/feed/collection/{0}/";

	public const string GET_STORY_TRAY = "/api/v1/feed/reels_tray/";

	public const string GET_TAG_FEED = "/api/v1/feed/tag/{0}";

	public const string GET_USER_STORY = "/api/v1/feed/user/{0}/reel_media/";

	public const string GET_USER_TAGS = "/api/v1/usertags/{0}/feed/";

	public const string LIKE_FEED = "/api/v1/feed/liked/";

	public const string TIMELINEFEED = "/api/v1/feed/timeline";

	public const string USER_REEL_FEED = "/api/v1/feed/user/{0}/reel_media/";

	public const string USEREFEED = "/api/v1/feed/user/";

	public const string FRIENDSHIPS_APPROVE = "/api/v1/friendships/approve/{0}/";

	public const string FRIENDSHIPS_AUTOCOMPLETE_USER_LIST = "/api/v1/friendships/autocomplete_user_list/";

	public const string FRIENDSHIPS_BLOCK_USER = "/api/v1/friendships/block/{0}/";

	public const string FRIENDSHIPS_FOLLOW_USER = "/api/v1/friendships/create/{0}/";

	public const string FRIENDSHIPS_IGNORE = "/api/v1/friendships/ignore/{0}/";

	public const string FRIENDSHIPS_PENDING_REQUESTS = "/api/v1/friendships/pending/?rank_mutual=0&rank_token={0}";

	public const string FRIENDSHIPS_REMOVE_FOLLOWER = "/api/v1/friendships/remove_follower/{0}/";

	public const string FRIENDSHIPS_SET_REEL_BLOCK_STATUS = "/api/v1/friendships/set_reel_block_status/";

	public const string FRIENDSHIPS_SHOW_MANY = "/api/v1/friendships/show_many/";

	public const string FRIENDSHIPS_UNBLOCK_USER = "/api/v1/friendships/unblock/{0}/";

	public const string FRIENDSHIPS_FAVORITE = "/api/v1/friendships/favorite/{0}/";

	public const string FRIENDSHIPS_UNFAVORITE = "/api/v1/friendships/unfavorite/{0}/";

	public const string FRIENDSHIPS_FAVORITE_FOR_STORIES = "/api/v1/friendships/favorite_for_stories/{0}/";

	public const string FRIENDSHIPS_UNFAVORITE_FOR_STORIES = "/api/v1/friendships/unfavorite_for_stories/{0}/";

	public const string FRIENDSHIPS_UNFOLLOW_USER = "/api/v1/friendships/destroy/{0}/";

	public const string FRIENDSHIPS_USER_FOLLOWERS = "/api/v1/friendships/{0}/followers/?rank_token={1}";

	public const string FRIENDSHIPS_USER_FOLLOWERS_MUTUALFIRST = "/api/v1/friendships/{0}/followers/?rank_token={1}&rank_mutual={2}";

	public const string FRIENDSHIPS_USER_FOLLOWING = "/api/v1/friendships/{0}/following/?rank_token={1}";

	public const string FRIENDSHIPSTATUS = "/api/v1/friendships/show/";

	public const string FRIENDSHIPS_MARK_USER_OVERAGE = "/api/v1/friendships/mark_user_overage/{0}/feed/";

	public const string FRIENDSHIPS_MUTE_POST_STORY = "/api/v1/friendships/mute_posts_or_story_from_follow/";

	public const string FRIENDSHIPS_UNMUTE_POST_STORY = "/api/v1/friendships/unmute_posts_or_story_from_follow/";

	public const string FRIENDSHIPS_BLOCK_FRIEND_REEL = "/api/v1/friendships/block_friend_reel/{0}/";

	public const string FRIENDSHIPS_UNBLOCK_FRIEND_REEL = "/api/v1/friendships/unblock_friend_reel/{0}/";

	public const string FRIENDSHIPS_MUTE_FRIEND_REEL = "/api/v1/friendships/mute_friend_reel/{0}/";

	public const string FRIENDSHIPS_UNMUTE_FRIEND_REEL = "/api/v1/friendships/unmute_friend_reel/{0}/";

	public const string FRIENDSHIPS_BLOCKED_REEL = "/api/v1/friendships/blocked_reels/";

	public const string FRIENDSHIPS_BESTIES = "/api/v1/friendships/besties/";

	public const string FRIENDSHIPS_BESTIES_SUGGESTIONS = "/api/v1/friendships/bestie_suggestions/";

	public const string FRIENDSHIPS_SET_BESTIES = "/api/v1/friendships/set_besties/";

	public const string GRAPH_QL = "/api/v1/ads/graphql/";

	public const string GRAPH_QL_STATISTICS = "/api/v1/ads/graphql/?locale={0}&vc_policy=insights_policy&surface={1}";

	public const string INSIGHTS_MEDIA = "/api/v1/insights/account_organic_insights/?show_promotions_in_landing_page=true&first={0}";

	public const string INSIGHTS_MEDIA_SINGLE = "/api/v1/insights/media_organic_insights/{0}?{1}={2}";

	public const string HIGHLIGHT_CREATE_REEL = "/api/v1/highlights/create_reel/";

	public const string HIGHLIGHT_DELETE_REEL = "/api/v1/highlights/{0}/delete_reel/";

	public const string HIGHLIGHT_EDIT_REEL = "/api/v1/highlights/{0}/edit_reel/";

	public const string HIGHLIGHT_TRAY = "/api/v1/highlights/{0}/highlights_tray/";

	public const string IGTV_CHANNEL = "/api/v1/igtv/channel/";

	public const string IGTV_SEARCH = "/api/v1/igtv/search/?query={0}";

	public const string IGTV_SUGGESTED_SEARCHES = "/api/v1/igtv/suggested_searches/";

	public const string IGTV_TV_GUIDE = "/api/v1/igtv/tv_guide/";

	public const string MEDIA_CONFIGURE_TO_IGTV = "/api/v1/media/configure_to_igtv/";

	public const string LANGUAGE_TRANSLATE = "/api/v1/language/translate/?id={0}&type=3";

	public const string LANGUAGE_TRANSLATE_COMMENT = "/api/v1/language/bulk_translate/?comment_ids={0}";

	public const string LIVE_ADD_TO_POST_LIVE = "/api/v1/live/{0}/add_to_post_live/";

	public const string LIVE_COMMENT = "/api/v1/live/{0}/comment/";

	public const string LIVE_CREATE = "/api/v1/live/create/";

	public const string LIVE_DELETE_POST_LIVE = "/api/v1/live/{0}/delete_post_live/";

	public const string LIVE_END = "/api/v1/live/{0}/end_broadcast/";

	public const string LIVE_GET_COMMENT = "/api/v1/live/{0}/get_comment/";

	public const string LIVE_GET_COMMENT_LASTCOMMENTTS = "/api/v1/live/{0}/get_comment/?last_comment_ts={1}";

	public const string LIVE_GET_FINAL_VIEWER_LIST = "/api/v1/live/{0}/get_final_viewer_list/";

	public const string LIVE_GET_JOIN_REQUESTS = "/api/v1/live/{0}/get_join_requests/";

	public const string LIVE_GET_LIKE_COUNT = "/api/v1/live/{0}/get_like_count/";

	public const string LIVE_GET_LIVE_PRESENCE = "/api/v1/live/get_live_presence/?presence_type=30min";

	public const string LIVE_GET_POST_LIVE_COMMENT = "/api/v1/live/{0}/get_post_live_comments/?starting_offset={1}&encoding_tag={2}";

	public const string LIVE_GET_POST_LIVE_VIEWERS_LIST = "/api/v1/live/{0}/get_post_live_viewers_list/";

	public const string LIVE_GET_SUGGESTED_BROADCASTS = "/api/v1/live/get_suggested_broadcasts/";

	public const string LIVE_GET_VIEWER_LIST = "/api/v1/live/{0}/get_viewer_list/";

	public const string LIVE_HEARTBEAT_AND_GET_VIEWER_COUNT = "/api/v1/live/{0}/heartbeat_and_get_viewer_count/";

	public const string LIVE_INFO = "/api/v1/live/{0}/info/";

	public const string LIVE_LIKE = "/api/v1/live/{0}/like/";

	public const string LIVE_MUTE_COMMENTS = "/api/v1/live/{0}/mute_comment/";

	public const string LIVE_PIN_COMMENT = "/api/v1/live/{0}/pin_comment/";

	public const string LIVE_POST_LIVE_LIKES = "/api/v1/live/{0}/get_post_live_likes/?starting_offset={1}&encoding_tag={2}";

	public const string LIVE_START = "/api/v1/live/{0}/start/";

	public const string LIVE_UNMUTE_COMMENTS = "/api/v1/live/{0}/unmute_comment/";

	public const string LIVE_UNPIN_COMMENT = "/api/v1/live/{0}/unpin_comment/";

	public const string LOCATION_FEED = "/api/v1/feed/location/{0}/";

	public const string LOCATION_SECTION = "/api/v1/locations/{0}/sections/";

	public const string LOCATION_SEARCH = "/api/v1/location_search/";

	public const string LOCATIONS_INFO = "/api/v1/locations/{0}/info/";

	public const string LOCATIONS_RELEATED = "/api/v1/locations/{0}/related/";

	public const string ALLOW_MEDIA_COMMENTS = "/api/v1/media/{0}/enable_comments/";

	public const string DELETE_COMMENT = "/api/v1/media/{0}/comment/{1}/delete/";

	public const string DELETE_MEDIA = "/api/v1/media/{0}/delete/?media_type={1}";

	public const string DELETE_MULTIPLE_COMMENT = "/api/v1/media/{0}/comment/bulk_delete/";

	public const string DISABLE_MEDIA_COMMENTS = "/api/v1/media/{0}/disable_comments/";

	public const string EDIT_MEDIA = "/api/v1/media/{0}/edit_media/";

	public const string GET_MEDIA = "/api/v1/media/{0}/info/";

	public const string GET_SHARE_LINK = "/api/v1/media/{0}/permalink/";

	public const string LIKE_COMMENT = "/api/v1/media/{0}/comment_like/";

	public const string LIKE_MEDIA = "/api/v1/media/{0}/like/";

	public const string MAX_MEDIA_ID_POSTFIX = "/media/?max_id=";

	public const string MEDIA = "/media/";

	public const string MEDIA_ALBUM_CONFIGURE = "/api/v1/media/configure_sidecar/";

	public const string MEDIA_COMMENT_LIKERS = "/api/v1/media/{0}/comment_likers/";

	public const string MEDIA_COMMENTS = "/api/v1/media/{0}/comments/?can_support_threading=true";

	public const string MEDIA_CONFIGURE = "/api/v1/media/configure/";

	public const string MEDIA_CONFIGURE_VIDEO = "/api/v1/media/configure/?video=1";

	public const string MEDIA_UPLOAD_FINISH = "/api/v1/media/upload_finish/?video=1";

	public const string MEDIA_INFOS = "/api/v1/media/infos/?_uuid={0}&_csrftoken={1}&media_ids={2}&ranked_content=true&include_inactive_reel=true";

	public const string MEDIA_CONFIGURE_NAMETAG = "/api/v1/media/configure_to_nametag/";

	public const string MEDIA_INLINE_COMMENTS = "/api/v1/media/{0}/comments/{1}/inline_child_comments/";

	public const string MEDIA_LIKERS = "/api/v1/media/{0}/likers/";

	public const string MEDIA_REPORT = "/api/v1/media/{0}/flag_media/";

	public const string MEDIA_REPORT_COMMENT = "/api/v1/media/{0}/comment/{1}/flag/";

	public const string MEDIA_SAVE = "/api/v1/media/{0}/save/";

	public const string MEDIA_UNSAVE = "/api/v1/media/{0}/unsave/";

	public const string MEDIA_VALIDATE_REEL_URL = "/api/v1/media/validate_reel_url/";

	public const string POST_COMMENT = "/api/v1/media/{0}/comment/";

	public const string SEEN_MEDIA = "/api/v1/media/seen/";

	public const string SEEN_MEDIA_STORY = "/api/v2/media/seen/?reel=1&live_vod=0";

	public const string STORY_CONFIGURE = "/api/v1/media/configure_to_reel/";

	public const string STORY_CONFIGURE_VIDEO = "/api/v1/media/configure_to_story/?video=1";

	public const string STORY_CONFIGURE_VIDEO2 = "/api/v1/media/configure_to_story/";

	public const string STORY_MEDIA_INFO_UPLOAD = "/api/v1/media/mas_opt_in_info/";

	public const string UNLIKE_COMMENT = "/api/v1/media/{0}/comment_unlike/";

	public const string UNLIKE_MEDIA = "/api/v1/media/{0}/unlike/";

	public const string MEDIA_STORY_VIEWERS = "/api/v1/media/{0}/list_reel_media_viewer/";

	public const string MEDIA_BLOCKED = "/api/v1/media/blocked/";

	public const string MEDIA_ARCHIVE = "/api/v1/media/{0}/only_me/";

	public const string MEDIA_UNARCHIVE = "/api/v1/media/{0}/undo_only_me/";

	public const string MEDIA_STORY_POLL_VOTERS = "/api/v1/media/{0}/{1}/story_poll_voters/";

	public const string MEDIA_STORY_POLL_VOTE = "/api/v1/media/{0}/{1}/story_poll_vote/";

	public const string MEDIA_STORY_SLIDER_VOTE = "/api/v1/media/{0}/{1}/story_slider_vote/";

	public const string MEDIA_STORY_QUESTION_RESPONSE = "/api/v1/media/{0}/{1}/story_question_response/";

	public const string MEDIA_STORY_COUNTDOWNS = "/api/v1/media/story_countdowns/";

	public const string MEDIA_FOLLOW_COUNTDOWN = "/api/v1/media/{0}/follow_story_countdown/";

	public const string MEDIA_UNFOLLOW_COUNTDOWN = "/api/v1/media/{0}/unfollow_story_countdown/";

	public const string GET_FOLLOWING_RECENT_ACTIVITY = "/api/v1/news/";

	public const string GET_RECENT_ACTIVITY = "/api/v1/news/inbox/";

	public const string NEWS_LOG = "/api/v1/news/log/";

	public const string NOTIFICATION_BADGE = "/api/v1/notifications/badge/";

	public const string PUSH_REGISTER = "/api/v1/push/register/";

	public const string USER_SHOPPABLE_MEDIA = "/api/v1/feed/user/{0}/shoppable_media/";

	public const string COMMERCE_PRODUCT_INFO = "/api/v1/commerce/products/{0}/?media_id={1}&device_width={2}";

	public const string GET_TAG_INFO = "/api/v1/tags/{0}/info/";

	public const string SEARCH_TAGS = "/api/v1/tags/search/?q={0}&count={1}";

	public const string TAG_FOLLOW = "/api/v1/tags/follow/{0}/";

	public const string TAG_RANKED = "/api/v1/tags/{0}/ranked_sections/";

	public const string TAG_RECENT = "/api/v1/tags/{0}/recent_sections/";

	public const string TAG_SECTION = "/api/v1/tags/{0}/sections/";

	public const string TAG_RELATED = "/api/v1/tags/{0}/related/";

	public const string TAG_STORY = "/api/v1/tags/{0}/story/";

	public const string TAG_SUGGESTED = "/api/v1/tags/suggested/";

	public const string TAG_UNFOLLOW = "/api/v1/tags/unfollow/{0}/";

	public const string ACCOUNTS_LOOKUP_PHONE = "/api/v1/users/lookup_phone/";

	public const string GET_USER_INFO_BY_ID = "/api/v1/users/{0}/info/";

	public const string GET_USER_INFO_BY_USERNAME = "/api/v1/users/{0}/usernameinfo/";

	public const string SEARCH_USERS = "/api/v1/users/search";

	public const string USERS_CHECK_EMAIL = "/api/v1/users/check_email/";

	public const string USERS_CHECK_USERNAME = "/api/v1/users/check_username/";

	public const string USERS_LOOKUP = "/api/v1/users/lookup/";

	public const string USERS_NAMETAG_CONFIG = "/api/v1/users/nametag_config/";

	public const string USERS_REEL_SETTINGS = "/api/v1/users/reel_settings/";

	public const string USERS_REPORT = "/api/v1/users/{0}/flag_user/";

	public const string USERS_SEARCH = "/api/v1/users/search/?timezone_offset={0}&q={1}&count={2}";

	public const string USERS_SET_REEL_SETTINGS = "/api/v1/users/set_reel_settings/";

	public const string USERS_FOLLOWING_TAG_INFO = "/api/v1/users/{0}/following_tags_info/";

	public const string USERS_FULL_DETAIL_INFO = "/api/v1/users/{0}/full_detail_info/";

	public const string USERS_NAMETAG_LOOKUP = "/api/v1/users/nametag_lookup/";

	public const string USERS_BLOCKED_LIST = "/api/v1/users/blocked_list/";

	public const string USERS_ACCOUNT_DETAILS = "/api/v1/users/{0}/account_details/";

	public const string UPLOAD_PHOTO = "https://i.instagram.com/rupload_igphoto/{0}_0_{1}";

	public const string UPLOAD_PHOTO_OLD = "/api/v1/upload/photo/";

	public const string UPLOAD_VIDEO = "https://i.instagram.com/rupload_igvideo/{0}_0_{1}";

	public const string UPLOAD_VIDEO_OLD = "/api/v1/upload/video/";

	public const string ADDRESSBOOK_LINK = "/api/v1/address_book/link/?include=extra_display_name,thumbnails";

	public const string ARCHIVE_REEL_DAY_SHELLS = "/api/v1/archive/reel/day_shells/?include_cover=0";

	public const string DYI_REQUEST_DOWNLOAD_DATA = "/api/v1/dyi/request_download_data/";

	public const string DYI_CHECK_DATA_STATE = "/api/v1/dyi/check_data_state/";

	public const string DYNAMIC_ONBOARDING_GET_STEPS = "/api/v1/dynamic_onboarding/get_steps/";

	public const string GET_MEDIAID = "/api/v1/oembed/?url={0}";

	public const string MEGAPHONE_LOG = "/api/v1/megaphone/log/";

	public const string QE_EXPOSE = "/api/v1/qe/expose/";

	public const string CHALLENGE = "/api/v1/challenge/";

	public static string WEB_ADDRESS = "https://www.instagram.com";

	public static string WEB_ACCOUNTS = "/accounts";

	public static string WEB_ACCOUNT_DATA = WEB_ACCOUNTS + "/access_tool";

	public static string WEB_CURRENT_FOLLOW_REQUESTS = WEB_ACCOUNT_DATA + "/current_follow_requests";

	public static string WEB_FORMER_EMAILS = WEB_ACCOUNT_DATA + "/former_emails";

	public static string WEB_FORMER_PHONES = WEB_ACCOUNT_DATA + "/former_phones";

	public static string WEB_FORMER_USERNAMES = WEB_ACCOUNT_DATA + "/former_usernames";

	public static string WEB_FORMER_FULL_NAMES = WEB_ACCOUNT_DATA + "/former_full_names";

	public static string WEB_FORMER_BIO_TEXTS = WEB_ACCOUNT_DATA + "/former_bio_texts";

	public static string WEB_FORMER_BIO_LINKS = WEB_ACCOUNT_DATA + "/former_links_in_bio";

	public static string WEB_CURSOR = "__a=1&cursor={0}";

	public static readonly Uri InstagramWebUri = new Uri(WEB_ADDRESS);
}
