using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using InstagramApiSharp.API;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Enums;
using Newtonsoft.Json;

namespace InstagramApiSharp.Helpers;

internal class UriCreator
{
	private static readonly Uri BaseInstagramUri = new Uri("https://i.instagram.com");

	public static Uri GetAcceptFriendshipUri(long userId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/friendships/approve/{userId}/", out var result))
		{
			throw new Exception("Cant create URI for accept friendship");
		}
		return result;
	}

	public static Uri GetAccount2FALoginAgainUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/accounts/send_two_factor_login_sms/", out var result))
		{
			throw new Exception("Cant create URI for Account 2FA Login Again");
		}
		return result;
	}

	public static Uri GetAccountGetCommentFilterUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/accounts/get_comment_filter/", out var result))
		{
			throw new Exception("Cant create URI for accounts get comment filter");
		}
		return result;
	}

	public static Uri GetAccountRecoverPhoneUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/users/lookup_phone/", out var result))
		{
			throw new Exception("Cant create URI for Account Recovery phone");
		}
		return result;
	}

	public static Uri GetAccountRecoveryEmailUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/accounts/send_recovery_flow_email/", out var result))
		{
			throw new Exception("Cant create URI for Account Recovery Email");
		}
		return result;
	}

	public static Uri GetAccountSecurityInfoUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/accounts/account_security_info/", out var result))
		{
			throw new Exception("Cant create URI for accounts security info");
		}
		return result;
	}

	public static Uri GetAccountSendConfirmEmailUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/accounts/send_confirm_email/", out var result))
		{
			throw new Exception("Cant create URI for accounts send confirm email");
		}
		return result;
	}

	public static Uri GetAccountSendSmsCodeUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/accounts/send_sms_code/", out var result))
		{
			throw new Exception("Cant create URI for accounts send sms code");
		}
		return result;
	}

	public static Uri GetAccountSetPresenseDisabledUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/accounts/set_presence_disabled/", out var result))
		{
			throw new Exception("Cant create URI for accounts set presence disabled");
		}
		return result;
	}

	public static Uri GetAccountVerifySmsCodeUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/accounts/verify_sms_code/", out var result))
		{
			throw new Exception("Cant create URI for accounts verify sms code");
		}
		return result;
	}

	public static Uri GetAllowMediaCommetsUri(string mediaId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/media/{mediaId}/enable_comments/", out var result))
		{
			throw new Exception("Cant create URI to allow comments on media");
		}
		return result;
	}

	public static Uri GetApprovePendingDirectRequestUri(string threadId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/direct_v2/threads/{threadId}/approve/", out var result))
		{
			throw new Exception("Cant create URI for approve inbox thread");
		}
		return result;
	}

	public static Uri GetApprovePendingMultipleDirectRequestUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/direct_v2/threads/approve_multiple/", out var result))
		{
			throw new Exception("Cant create URI for approve multiple inbox threads");
		}
		return result;
	}

	public static Uri GetBlockUserUri(long userId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/friendships/block/{userId}/", out var result))
		{
			throw new Exception("Cant create URI for getting media likers");
		}
		return result;
	}

	public static Uri GetBroadcastAddToPostLiveUri(string broadcastId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/live/{broadcastId}/add_to_post_live/", out var result))
		{
			throw new Exception("Cant create URI for broadcast add to post live");
		}
		return result;
	}

	public static Uri GetBroadcastCommentUri(string broadcastId, string lastcommentts = "")
	{
		if (lastcommentts == "")
		{
			if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/live/{broadcastId}/get_comment/", out var result))
			{
				throw new Exception("Cant create URI for broadcast get comments");
			}
			return result;
		}
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/live/{broadcastId}/get_comment/?last_comment_ts={lastcommentts}", out var result2))
		{
			throw new Exception("Cant create URI for broadcast get comments");
		}
		return result2;
	}

	public static Uri GetBroadcastCreateUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/live/create/", out var result))
		{
			throw new Exception("Cant create URI for broadcast create");
		}
		return result;
	}

	public static Uri GetBroadcastDeletePostLiveUri(string broadcastId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/live/{broadcastId}/delete_post_live/", out var result))
		{
			throw new Exception("Cant create URI for broadcast delete post live");
		}
		return result;
	}

	public static Uri GetBroadcastDisableCommenstUri(string broadcastId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/live/{broadcastId}/mute_comment/", out var result))
		{
			throw new Exception("Cant create URI for broadcast disable comments");
		}
		return result;
	}

	public static Uri GetBroadcastEnableCommenstUri(string broadcastId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/live/{broadcastId}/unmute_comment/", out var result))
		{
			throw new Exception("Cant create URI for broadcast enable comments");
		}
		return result;
	}

	public static Uri GetBroadcastEndUri(string broadcastId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/live/{broadcastId}/end_broadcast/", out var result))
		{
			throw new Exception("Cant create URI for broadcast end");
		}
		return result;
	}

	public static Uri GetBroadcastInfoUri(string broadcastId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/live/{broadcastId}/info/", out var result))
		{
			throw new Exception("Cant create URI for get broadcast info");
		}
		return result;
	}

	public static Uri GetBroadcastJoinRequestsUri(string broadcastId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/live/{broadcastId}/get_join_requests/", out var result))
		{
			throw new Exception("Cant create URI for broadcast join requests");
		}
		return result;
	}

	public static Uri GetBroadcastPinCommentUri(string broadcastId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/live/{broadcastId}/pin_comment/", out var result))
		{
			throw new Exception("Cant create URI for broadcast pin comment");
		}
		return result;
	}

	public static Uri GetBroadcastPostCommentUri(string broadcastId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/live/{broadcastId}/comment/", out var result))
		{
			throw new Exception("Cant create URI for broadcast comments");
		}
		return result;
	}

	public static Uri GetBroadcastPostLiveCommentUri(string broadcastId, int startingOffset, string encodingTag)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/live/{broadcastId}/get_post_live_comments/?starting_offset={startingOffset}&encoding_tag={encodingTag}", out var result))
		{
			throw new Exception("Cant create URI for broadcast post live comment");
		}
		return result;
	}

	public static Uri GetBroadcastPostLiveLikesUri(string broadcastId, int startingOffset, string encodingTag)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/live/{broadcastId}/get_post_live_likes/?starting_offset={startingOffset}&encoding_tag={encodingTag}", out var result))
		{
			throw new Exception("Cant create URI for broadcast post live likes");
		}
		return result;
	}

	public static Uri GetDirectThreadBroadcastLikeUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/direct_v2/threads/broadcast/like/", out var result))
		{
			throw new Exception("Cant create URI for broadcast post live likes");
		}
		return result;
	}

	public static Uri GetBroadcastStartUri(string broadcastId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/live/{broadcastId}/start/", out var result))
		{
			throw new Exception("Cant create URI for broadcast start");
		}
		return result;
	}

	public static Uri GetBroadcastUnPinCommentUri(string broadcastId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/live/{broadcastId}/unpin_comment/", out var result))
		{
			throw new Exception("Cant create URI for broadcast unpin comments");
		}
		return result;
	}

	public static Uri GetBroadcastViewerListUri(string broadcastId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/live/{broadcastId}/get_viewer_list/", out var result))
		{
			throw new Exception("Cant create URI for get broadcast viewer list");
		}
		return result;
	}

	public static Uri GetBusinessGraphQLUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/ads/graphql/", out var result))
		{
			throw new Exception("Cant create URI for business graph ql");
		}
		return result;
	}

	public static Uri GetBusinessInstantExperienceUri(string data)
	{
		if (!Uri.TryCreate(BaseInstagramUri, string.Format("/api/v1/business/instant_experience/get_ix_partners_bundle/?signed_body={0}&ig_sig_key_version={1}", data, "4"), out var result))
		{
			throw new Exception("Cant create URI for business instant experience");
		}
		return result;
	}

	public static Uri GetBusinessValidateUrlUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/business/instant_experience/ix_validate_url/", out var result))
		{
			throw new Exception("Cant create URI for business validate url");
		}
		return result;
	}

	public static Uri GetChallengeRequireFirstUri(string apiPath, string guid, string deviceId)
	{
		if (!apiPath.EndsWith("/"))
		{
			apiPath += "/";
		}
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1" + apiPath + "?guid=" + guid + "&device_id=" + deviceId, out var result))
		{
			throw new Exception("Cant create URI for challenge require url");
		}
		return result;
	}

	public static Uri GetChallengeUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/challenge/", out var result))
		{
			throw new Exception("Cant create URI for challenge url");
		}
		return result;
	}

	public static Uri GetChallengeRequireUri(string apiPath)
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1" + apiPath, out var result))
		{
			throw new Exception("Cant create URI for challenge require url");
		}
		return result;
	}

	public static Uri GetChallengeReplayUri(string apiPath)
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1" + apiPath.Replace("challenge/", "challenge/replay/"), out var result))
		{
			throw new Exception("Cant create URI for challenge require url");
		}
		return result;
	}

	public static Uri GetChangePasswordUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/accounts/change_password/", out var result))
		{
			throw new Exception("Can't create URI for changing password");
		}
		return result;
	}

	public static Uri GetChangeProfilePictureUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/accounts/change_profile_picture/", out var result))
		{
			throw new Exception("Cant create URI for change profile picture");
		}
		return result;
	}

	public static Uri GetCheckEmailUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/users/check_email/", out var result))
		{
			throw new Exception("Cant create URI for check email");
		}
		return result;
	}

	public static Uri GetCheckPhoneNumberUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/accounts/check_phone_number/", out var result))
		{
			throw new Exception("Cant create URI for check phone number");
		}
		return result;
	}

	public static Uri GetCheckUsernameUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/users/check_username/", out var result))
		{
			throw new Exception("Cant create URI for check username");
		}
		return result;
	}

	public static Uri GetClearSearchHistoryUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/fbsearch/clear_search_history", out var result))
		{
			throw new Exception("Cant create URI for clear search history");
		}
		return result;
	}

	public static Uri GetCollectionsUri(string nextMaxId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/collections/list/", out var result))
		{
			throw new Exception("Can't create URI for getting collections");
		}
		if (string.IsNullOrEmpty(nextMaxId))
		{
			return result;
		}
		return new UriBuilder(result)
		{
			Query = "max_id=" + nextMaxId
		}.Uri;
	}

	public static Uri GetCollectionUri(long collectionId, string nextMaxId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/feed/collection/{collectionId}/", out var result))
		{
			throw new Exception("Can't create URI for getting collection");
		}
		if (string.IsNullOrEmpty(nextMaxId))
		{
			return result;
		}
		return new UriBuilder(result)
		{
			Query = "max_id=" + nextMaxId
		}.Uri;
	}

	public static Uri GetConsentNewUserFlowBeginsUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/consent/new_user_flow_begins/", out var result))
		{
			throw new Exception("Cant create URI for request for consent new user flow begins.");
		}
		return result;
	}

	public static Uri GetConsentNewUserFlowUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/consent/new_user_flow/", out var result))
		{
			throw new Exception("Cant create URI for request for consent new user flow.");
		}
		return result;
	}

	public static Uri GetCreateAccountUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/accounts/create/", out var result))
		{
			throw new Exception("Cant create URI for user creation");
		}
		return result;
	}

	public static Uri GetCreateCollectionUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/collections/create/", out var result))
		{
			throw new Exception("Can't create URI for creating collection");
		}
		return result;
	}

	public static Uri GetCreateValidatedUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/accounts/create_validated/", out var result))
		{
			throw new Exception("Cant create URI for accounbts create validated");
		}
		return result;
	}

	public static Uri GetCurrentUserUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/accounts/current_user?edit=true", out var result))
		{
			throw new Exception("Cant create URI for current user info");
		}
		return result;
	}

	public static Uri GetDeclineAllPendingDirectRequestsUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/direct_v2/threads/decline_all/", out var result))
		{
			throw new Exception("Cant create URI for decline all pending direct requests");
		}
		return result;
	}

	public static Uri GetDeclineMultplePendingDirectRequestsUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/direct_v2/threads/decline_multiple/", out var result))
		{
			throw new Exception("Cant create URI for decline all pending direct requests");
		}
		return result;
	}

	public static Uri GetDeclinePendingDirectRequestUri(string threadId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/direct_v2/threads/{threadId}/decline/", out var result))
		{
			throw new Exception("Cant create URI for decline pending direct request");
		}
		return result;
	}

	public static Uri GetDeleteCollectionUri(long collectionId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/collections/{collectionId}/delete/", out var result))
		{
			throw new Exception("Can't create URI for deleting collection");
		}
		return result;
	}

	public static Uri GetDeleteCommentUri(string mediaId, string commentId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/media/{mediaId}/comment/{commentId}/delete/", out var result))
		{
			throw new Exception("Cant create URI for delete comment");
		}
		return result;
	}

	public static Uri GetDeleteMediaUri(string mediaId, InstaMediaType mediaType)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/media/{mediaId}/delete/?media_type={mediaType.ToString().ToUpper()}", out var result))
		{
			throw new Exception("Can't create URI for deleting media");
		}
		return result;
	}

	public static Uri GetDeleteMultipleCommentsUri(string mediaId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/media/{mediaId}/comment/bulk_delete/", out var result))
		{
			throw new Exception("Cant create URI for delete multiple comments");
		}
		return result;
	}

	public static Uri GetDeleteStoryMediaUri(string mediaId, InstaSharingType mediaType)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/media/{mediaId}/delete/?media_type={mediaType.ToString().ToUpper()}", out var result))
		{
			throw new Exception("Can't create URI for deleting media story");
		}
		return result;
	}

	public static Uri GetDenyFriendshipUri(long userId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/friendships/ignore/{userId}/", out var result))
		{
			throw new Exception("Cant create URI for deny friendship");
		}
		return result;
	}

	public static Uri GetDirectConfigVideoUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/direct_v2/threads/broadcast/configure_video/", out var result))
		{
			throw new Exception("Cant create URI for direct config video");
		}
		return result;
	}

	public static Uri GetDirectInboxThreadUri(string threadId, string NextId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/direct_v2/threads/{threadId}", out var result))
		{
			throw new Exception("Cant create URI for get inbox thread by id");
		}
		if (string.IsNullOrEmpty(NextId))
		{
			return new UriBuilder(result)
			{
				Query = "use_unified_inbox=true"
			}.Uri;
		}
		return new UriBuilder(result)
		{
			Query = "use_unified_inbox=true&cursor=" + NextId + "&direction=older"
		}.Uri;
	}

	public static Uri GetDirectInboxUri(string NextId = "")
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/direct_v2/inbox/", out var result))
		{
			throw new Exception("Cant create URI for get inbox");
		}
		if (string.IsNullOrEmpty(NextId))
		{
			return new UriBuilder(result)
			{
				Query = "persistentBadging=true&use_unified_inbox=true"
			}.Uri;
		}
		return new UriBuilder(result)
		{
			Query = "persistentBadging=true&use_unified_inbox=true&cursor=" + NextId + "&direction=older"
		}.Uri;
	}

	public static Uri GetDirectPendingInboxUri(string NextId = "")
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/direct_v2/pending_inbox/", out var result))
		{
			throw new Exception("Cant create URI for get pending inbox");
		}
		if (string.IsNullOrEmpty(NextId))
		{
			return result;
		}
		return new UriBuilder(result)
		{
			Query = "cursor=" + NextId
		}.Uri;
	}

	public static Uri GetDirectPresenceUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/direct_v2/get_presence/", out var result))
		{
			throw new Exception("Cant create URI for direct presence");
		}
		return result;
	}

	public static Uri GetDirectSendMessageUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/direct_v2/threads/broadcast/text/", out var result))
		{
			throw new Exception("Cant create URI for sending message");
		}
		return result;
	}

	public static Uri GetShareLiveToDirectUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/direct_v2/threads/broadcast/live_viewer_invite/", out var result))
		{
			throw new Exception("Cant create URI for share live to direct");
		}
		return result;
	}

	public static Uri GetDirectSendPhotoUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/direct_v2/threads/broadcast/upload_photo/", out var result))
		{
			throw new Exception("Cant create URI for sending photo to direct");
		}
		return result;
	}

	public static Uri GetDirectThreadSeenUri(string threadId, string itemId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/direct_v2/threads/{threadId}/items/{itemId}/seen/", out var result))
		{
			throw new Exception("Cant create URI for seen thread");
		}
		return result;
	}

	public static Uri GetDirectThreadUpdateTitleUri(string threadId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/direct_v2/threads/{threadId}/update_title/", out var result))
		{
			throw new Exception("Cant create URI for update thread title");
		}
		return result;
	}

	public static Uri GetDisableMediaCommetsUri(string mediaId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/media/{mediaId}/disable_comments/", out var result))
		{
			throw new Exception("Cant create URI to disable comments on media");
		}
		return result;
	}

	public static Uri GetDisableSmsTwoFactorUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/accounts/disable_sms_two_factor/", out var result))
		{
			throw new Exception("Cant create URI for disable sms two factor");
		}
		return result;
	}

	public static Uri GetDiscoverChainingUri(long userId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/discover/chaining/?target_id={userId}", out var result))
		{
			throw new Exception("Cant create URI for discover chaining");
		}
		return result;
	}

	public static Uri GetDiscoverPeopleUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/discover/ayml/", out var result))
		{
			throw new Exception("Cant create URI for discover people");
		}
		return result;
	}

	public static Uri GetDiscoverSuggestionDetailsUri(long userId, List<long> chainedIds)
	{
		if (!Uri.TryCreate(BaseInstagramUri, string.Format("/api/v1/discover/fetch_suggestion_details/?target_id={0}&chained_ids={1}", userId, string.Join(",", chainedIds)), out var result))
		{
			throw new Exception("Cant create URI for discover suggestion details");
		}
		return result;
	}

	public static Uri GetDiscoverTopLiveStatusUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/discover/top_live_status/", out var result))
		{
			throw new Exception("Cant create URI for discover top live status");
		}
		return result;
	}

	public static Uri GetDiscoverTopLiveUri(string maxId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/discover/top_live/", out var result))
		{
			throw new Exception("Cant create URI for discover top live");
		}
		return result.AddQueryParameterIfNotEmpty("max_id", maxId);
	}

	public static Uri GetEditCollectionUri(long collectionId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/collections/{collectionId}/edit/", out var result))
		{
			throw new Exception("Can't create URI for editing collection");
		}
		return result;
	}

	public static Uri GetEditMediaUri(string mediaId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/media/{mediaId}/edit_media/", out var result))
		{
			throw new Exception("Can't create URI for editing media");
		}
		return result;
	}

	public static Uri GetEditProfileUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/accounts/edit_profile/", out var result))
		{
			throw new Exception("Cant create URI for edit profile");
		}
		return result;
	}

	public static Uri GetEnableSmsTwoFactorUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/accounts/enable_sms_two_factor/", out var result))
		{
			throw new Exception("Cant create URI for enable sms two factor");
		}
		return result;
	}

	public static Uri GetExploreUri(string maxId = null, string rankToken = null)
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/discover/explore/", out var result))
		{
			throw new Exception("Cant create URI for explore posts");
		}
		string text = $"is_prefetch=false&is_from_promote=true&timezone_offset={InstaApiConstants.TIMEZONE_OFFSET}&supported_capabilities_new={JsonConvert.SerializeObject(InstaApiConstants.SupportedCapabalities)}";
		if (!string.IsNullOrEmpty(maxId))
		{
			text = text + "&max_id=" + maxId + "&session_id=" + rankToken;
		}
		return new UriBuilder(result)
		{
			Query = text
		}.Uri;
	}

	public static Uri GetFacebookSignUpUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/fb/facebook_signup/", out var result))
		{
			throw new Exception("Cant create URI for facebook sign up url");
		}
		return result;
	}

	public static Uri GetFollowHashtagUri(string hashtag)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/tags/follow/{hashtag}/", out var result))
		{
			throw new Exception("Cant create URI for follow hashtag");
		}
		return result;
	}

	public static Uri GetFollowingRecentActivityUri(string maxId = null)
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/news/", out var result))
		{
			throw new Exception("Cant create URI (get following recent activity");
		}
		string text = string.Empty;
		if (!string.IsNullOrEmpty(maxId))
		{
			text = text + "max_id=" + maxId;
		}
		return new UriBuilder(result)
		{
			Query = text
		}.Uri;
	}

	public static Uri GetFollowingTagsInfoUri(long userId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/users/{userId}/following_tags_info/", out var result))
		{
			throw new Exception("Cant create URI for suggested tags");
		}
		return result;
	}

	public static Uri GetFollowUserUri(long userId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/friendships/create/{userId}/", out var result))
		{
			throw new Exception("Cant create URI for getting media likers");
		}
		return result;
	}

	public static Uri GetFriendshipPendingRequestsUri(string rankToken)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/friendships/pending/?rank_mutual=0&rank_token={rankToken}", out var result))
		{
			throw new Exception("Cant create URI for friendship pending requests");
		}
		return result;
	}

	public static Uri GetFriendshipShowManyUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/friendships/show_many/", out var result))
		{
			throw new Exception("Cant create URI for friendship show many");
		}
		return result;
	}

	public static Uri GetFullUserInfoUri(long userId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/users/{userId}/full_detail_info/", out var result))
		{
			throw new Exception("Cant create URI for full user info");
		}
		return result;
	}

	public static Uri GetGraphStatisticsUri(string locale, InstaInsightSurfaceType surfaceType = InstaInsightSurfaceType.Account)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/ads/graphql/?locale={locale}&vc_policy=insights_policy&surface={surfaceType.ToString().ToLower()}", out var result))
		{
			throw new Exception("Cant create URI for graph ql statistics");
		}
		return result;
	}

	public static Uri GetHashtagRankedMediaUri(string hashtag, string rankToken = null, string nextId = null, int? page = null, IEnumerable<long> nextMediaIds = null)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/tags/{hashtag.EncodeUri()}/ranked_sections/", out var result))
		{
			throw new Exception("Cant create URI for hashtag ranked(top) media");
		}
		if (!string.IsNullOrEmpty(rankToken))
		{
			result = result.AddQueryParameter("rank_token", rankToken);
		}
		if (!string.IsNullOrEmpty(nextId))
		{
			result = result.AddQueryParameter("max_id", nextId);
		}
		if (page.HasValue && page > 0)
		{
			result = result.AddQueryParameter("page", page.ToString());
		}
		if (nextMediaIds != null && nextMediaIds.Any())
		{
			string data = "[" + string.Join(",", nextMediaIds) + "]";
			result = result.AddQueryParameter("next_media_ids", data.EncodeUri());
		}
		return result;
	}

	public static Uri GetHashtagRecentMediaUri(string hashtag, string rankToken = null, string nextId = null, int? page = null, IEnumerable<long> nextMediaIds = null)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/tags/{hashtag.EncodeUri()}/recent_sections/", out var result))
		{
			throw new Exception("Cant create URI for hashtag recent media");
		}
		if (!string.IsNullOrEmpty(nextId))
		{
			result = result.AddQueryParameter("max_id", nextId.EncodeUri());
		}
		if (page.HasValue && page > 0)
		{
			result = result.AddQueryParameter("page", page.ToString());
		}
		if (!string.IsNullOrEmpty(rankToken))
		{
			result = ((!rankToken.Contains("_")) ? result.AddQueryParameter("rank_token", rankToken) : result.AddQueryParameter("rank_token", rankToken.Split(new char[1] { '_' })[1]));
		}
		if (nextMediaIds != null && nextMediaIds.Any())
		{
			string data = "[" + string.Join(",", nextMediaIds) + "]";
			result = result.AddQueryParameter("next_media_ids", data.EncodeUri());
		}
		return result;
	}

	public static Uri GetHashtagStoryUri(string hashtag)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/tags/{hashtag}/story/", out var result))
		{
			throw new Exception("Cant create URI for hashtag story");
		}
		return result;
	}

	public static Uri GetHighlightCreateUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/highlights/create_reel/", out var result))
		{
			throw new Exception("Cant create URI for highlight create reel");
		}
		return result;
	}

	public static Uri GetHighlightEditUri(string highlightId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/highlights/{highlightId}/edit_reel/", out var result))
		{
			throw new Exception("Cant create URI for highlight edit reel");
		}
		return result;
	}

	public static Uri GetHighlightFeedsUri(long userId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/highlights/{userId}/highlights_tray/", out var result))
		{
			throw new Exception("Cant create URI for highlight feeds");
		}
		return result;
	}

	public static Uri GetHighlightsArchiveUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/archive/reel/day_shells/?include_cover=0", out var result))
		{
			throw new Exception("Cant create URI for highlights archive");
		}
		return result;
	}

	public static Uri GetIGTVChannelUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/igtv/channel/", out var result))
		{
			throw new Exception("Cant create URI for igtv channel");
		}
		return result;
	}

	public static Uri GetIGTVGuideUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/igtv/tv_guide/", out var result))
		{
			throw new Exception("Cant create URI for igtv tv guide");
		}
		return result;
	}

	public static Uri GetIGTVSearchUri(string query)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/igtv/search/?query={query}", out var result))
		{
			throw new Exception("Cant create URI for igtv search");
		}
		return result;
	}

	public static Uri GetIGTVSuggestedSearchesUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/igtv/suggested_searches/", out var result))
		{
			throw new Exception("Cant create URI for igtv suggested searches");
		}
		return result;
	}

	public static Uri GetLeaveThreadUri(string threadId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/direct_v2/threads/{threadId}/leave/", out var result))
		{
			throw new Exception("Cant create URI for leave group thread");
		}
		return result;
	}

	public static Uri GetLikeCommentUri(string commentId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/media/{commentId}/comment_like/", out var result))
		{
			throw new Exception("Cant create URI for like comment");
		}
		return result;
	}

	public static Uri GetLikeLiveUri(string broadcastId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/live/{broadcastId}/like/", out var result))
		{
			throw new Exception("Cant create URI for like live");
		}
		return result;
	}

	public static Uri GetLikeMediaUri(string mediaId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/media/{mediaId}/like/", out var result))
		{
			throw new Exception("Cant create URI for like media");
		}
		return result;
	}

	public static Uri GetLikeUnlikeDirectMessageUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/direct_v2/threads/broadcast/reaction/", out var result))
		{
			throw new Exception("Cant create URI for like direct message");
		}
		return result;
	}

	public static Uri GetLiveFinalViewerListUri(string broadcastId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/live/{broadcastId}/get_final_viewer_list/", out var result))
		{
			throw new Exception("Cant create URI for get final viewer list");
		}
		return result;
	}

	public static Uri GetLiveHeartbeatAndViewerCountUri(string broadcastId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/live/{broadcastId}/heartbeat_and_get_viewer_count/", out var result))
		{
			throw new Exception("Cant create URI for live heartbeat and get viewer count");
		}
		return result;
	}

	public static Uri GetPushRegisterUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/push/register/", out var result))
		{
			throw new Exception("Cant create URI for live heartbeat and get viewer count");
		}
		return result;
	}

	public static Uri GetLiveLikeCountUri(string broadcastId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/live/{broadcastId}/get_like_count/", out var result))
		{
			throw new Exception("Cant create URI for live like count");
		}
		return result;
	}

	public static Uri GetLiveNotifyToFriendsUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/live/get_live_presence/?presence_type=30min", out var result))
		{
			throw new Exception("Cant create URI for get live presence");
		}
		return result;
	}

	public static Uri GetLoginUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/accounts/login/", out var result))
		{
			throw new Exception("Cant create URI for user login");
		}
		return result;
	}

	public static Uri GetLogoutUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/accounts/logout/", out var result))
		{
			throw new Exception("Cant create URI for user logout");
		}
		return result;
	}

	public static Uri GetMediaAlbumConfigureUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/media/configure_sidecar/", out var result))
		{
			throw new Exception("Cant create URI for configuring media album");
		}
		return result;
	}

	public static Uri GetMediaCommentsMinIdUri(string mediaId, string nextMinId = "")
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/media/{mediaId}/comments/?can_support_threading=true", out var result))
		{
			throw new Exception("Cant create URI for getting media comments");
		}
		if (string.IsNullOrEmpty(nextMinId))
		{
			return new UriBuilder(result)
			{
				Query = "can_support_threading=true"
			}.Uri;
		}
		return new UriBuilder(result)
		{
			Query = "can_support_threading=true&min_id=" + nextMinId
		}.Uri;
	}

	public static Uri GetMediaCommentsUri(string mediaId, string nextMaxId = "")
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/media/{mediaId}/comments/?can_support_threading=true", out var result))
		{
			throw new Exception("Cant create URI for getting media comments");
		}
		if (string.IsNullOrEmpty(nextMaxId))
		{
			return new UriBuilder(result)
			{
				Query = "can_support_threading=true"
			}.Uri;
		}
		return new UriBuilder(result)
		{
			Query = "can_support_threading=true&max_id=" + nextMaxId
		}.Uri;
	}

	public static Uri GetMediaCommetLikersUri(string mediaId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/media/{mediaId}/comment_likers/", out var result))
		{
			throw new Exception("Cant create URI to media comments likers");
		}
		return result;
	}

	public static Uri GetMediaConfigureToIGTVUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/media/configure_to_igtv/", out var result))
		{
			throw new Exception("Cant create URI for media configure igtv");
		}
		return result;
	}

	public static Uri GetMediaConfigureUri(bool video = false)
	{
		if (!Uri.TryCreate(BaseInstagramUri, video ? "/api/v1/media/configure/?video=1" : "/api/v1/media/configure/", out var result))
		{
			throw new Exception("Cant create URI for configuring media");
		}
		return result;
	}

	public static Uri GetMediaUploadFinishUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/media/upload_finish/?video=1", out var result))
		{
			throw new Exception("Cant create URI for media upload finish");
		}
		return result;
	}

	public static Uri GetMediaIdFromUrlUri(Uri uri)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/oembed/?url={uri.AbsoluteUri}", out var result))
		{
			throw new Exception("Can't create URI for getting media id");
		}
		return result;
	}

	public static Uri GetMediaInlineCommentsUri(string mediaId, string targetCommentId, string nextMaxId = "")
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/media/{mediaId}/comments/{targetCommentId}/inline_child_comments/", out var result))
		{
			throw new Exception("Cant create URI for getting media comments replies with max id");
		}
		if (string.IsNullOrEmpty(nextMaxId))
		{
			return result;
		}
		return new UriBuilder(result)
		{
			Query = "max_id=" + nextMaxId
		}.Uri;
	}

	public static Uri GetMediaInlineCommentsWithMinIdUri(string mediaId, string targetCommentId, string nextMinId = "")
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/media/{mediaId}/comments/{targetCommentId}/inline_child_comments/", out var result))
		{
			throw new Exception("Cant create URI for getting media comment replies with min id");
		}
		if (string.IsNullOrEmpty(nextMinId))
		{
			return result;
		}
		return new UriBuilder(result)
		{
			Query = "min_id=" + nextMinId
		}.Uri;
	}

	public static Uri GetMediaInsightsUri(string unixTime)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/insights/account_organic_insights/?show_promotions_in_landing_page=true&first={unixTime}", out var result))
		{
			throw new Exception("Cant create URI for media insights");
		}
		return result;
	}

	public static Uri GetMediaLikersUri(string mediaId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/media/{mediaId}/likers/", out var result))
		{
			throw new Exception("Cant create URI for getting media likers");
		}
		return result;
	}

	public static Uri GetMediaShareUri(InstaMediaType mediaType)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/direct_v2/threads/broadcast/media_share/?media_type={mediaType.ToString().ToLower()}", out var result))
		{
			throw new Exception("Cant create URI for media share");
		}
		return result;
	}

	public static Uri GetMediaSingleInsightsUri(string mediaPk)
	{
		if (!Uri.TryCreate(BaseInstagramUri, string.Format("/api/v1/insights/media_organic_insights/{0}?{1}={2}", mediaPk, "ig_sig_key_version", "4"), out var result))
		{
			throw new Exception("Cant create URI for single media insights");
		}
		return result;
	}

	public static Uri GetMediaUri(string mediaId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/media/{mediaId}/info/", out var result))
		{
			return null;
		}
		return result;
	}

	public static Uri GetMuteDirectThreadUri(string threadId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/direct_v2/threads/{threadId}/mute/", out var result))
		{
			throw new Exception("Cant create URI for mute direct thread");
		}
		return result;
	}

	public static Uri GetOnboardingStepsUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/dynamic_onboarding/get_steps/", out var result))
		{
			throw new Exception("Cant create URI for dynamic onboarding get steps");
		}
		return result;
	}

	public static Uri GetParticipantRecipientUserUri(long userId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/direct_v2/threads/get_by_participants/?recipient_users=[{userId}]", out var result))
		{
			throw new Exception("Cant create URI for get participants recipient user");
		}
		return result;
	}

	public static Uri GetPostCommetUri(string mediaId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/media/{mediaId}/comment/", out var result))
		{
			throw new Exception("Cant create URI for posting comment");
		}
		return result;
	}

	public static Uri GetPostLiveViewersListUri(string broadcastId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/live/{broadcastId}/get_post_live_viewers_list/", out var result))
		{
			throw new Exception("Cant create URI for get post live viewer list");
		}
		return result;
	}

	public static Uri GetProfileSearchUri(string query, int count)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/fbsearch/profile_link_search/?q={query}&count={count}", out var result))
		{
			throw new Exception("Cant create URI for profile search");
		}
		return result;
	}

	public static Uri GetProfileSetPhoneAndNameUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/accounts/set_phone_and_name/", out var result))
		{
			throw new Exception("Cant create URI for sets phone and number");
		}
		return result;
	}

	public static Uri GetPromotableMediaFeedsUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/feed/promotable_media/", out var result))
		{
			throw new Exception("Cant create URI for promotable media feeds");
		}
		return result;
	}

	public static Uri GetRankedRecipientsUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/direct_v2/ranked_recipients", out var result))
		{
			throw new Exception("Cant create URI (get ranked recipients)");
		}
		return result;
	}

	public static Uri GetRankRecipientsByUserUri(string username)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/direct_v2/ranked_recipients/?mode=raven&show_threads=true&query={username}&use_unified_inbox=true", out var result))
		{
			throw new Exception("Cant create URI for get rank recipients by username");
		}
		return result;
	}

	public static Uri GetRecentActivityUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/news/inbox/", out var result))
		{
			throw new Exception("Cant create URI (get recent activity)");
		}
		string query = "activity_module=all";
		return new UriBuilder(result)
		{
			Query = query
		}.Uri;
	}

	public static Uri GetRecentRecipientsUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/direct_share/recent_recipients/", out var result))
		{
			throw new Exception("Cant create URI (get recent recipients)");
		}
		return result;
	}

	public static Uri GetRecentSearchUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/fbsearch/recent_searches/", out var result))
		{
			throw new Exception("Cant create URI for facebook recent searches");
		}
		return result;
	}

	public static Uri GetReelMediaUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/feed/reels_media/", out var result))
		{
			throw new Exception("Cant create URI for reel media");
		}
		return result;
	}

	public static Uri GetRegenerateTwoFactorBackUpCodeUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/accounts/regen_backup_codes/", out var result))
		{
			throw new Exception("Cant create URI for regenerate two factor backup codes");
		}
		return result;
	}

	public static Uri GetRemoveProfilePictureUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/accounts/remove_profile_picture/", out var result))
		{
			throw new Exception("Cant create URI for remove profile picture");
		}
		return result;
	}

	public static Uri GetReportCommetUri(string mediaId, string commentId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/media/{mediaId}/comment/{commentId}/flag/", out var result))
		{
			throw new Exception("Cant create URI for report comment");
		}
		return result;
	}

	public static Uri GetReportMediaUri(string mediaId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/media/{mediaId}/flag_media/", out var result))
		{
			throw new Exception("Cant create URI for report media");
		}
		return result;
	}

	public static Uri GetReportUserUri(long userId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/users/{userId}/flag_user/", out var result))
		{
			throw new Exception("Cant create URI for report user");
		}
		return result;
	}

	public static Uri GetRequestForDownloadDataUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/dyi/request_download_data/", out var result))
		{
			throw new Exception("Cant create URI for request for download data.");
		}
		return result;
	}

	public static Uri GetRequestForEditProfileUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/accounts/current_user/?edit=true", out var result))
		{
			throw new Exception("Cant create URI for request editing profile");
		}
		return result;
	}

	public static Uri GetResetChallengeRequireUri(string apiPath)
	{
		apiPath = apiPath.Replace("/challenge/", "/challenge/reset/");
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1" + apiPath, out var result))
		{
			throw new Exception("Cant create URI for challenge require url");
		}
		return result;
	}

	public static Uri GetSearchTagUri(string tag, int count, IEnumerable<long> excludeList, string rankToken)
	{
		excludeList = excludeList ?? new List<long>();
		string value = "[" + string.Join(",", excludeList) + "]";
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/tags/search/?q={tag}&count={count}", out var result))
		{
			throw new Exception("Cant create search tag URI");
		}
		return result.AddQueryParameter("exclude_list", value).AddQueryParameter("rank_token", rankToken);
	}

	public static Uri GetSearchUserUri(string text, int count = 30)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/users/search/?timezone_offset={TimeZoneInfo.Local.GetUtcOffset(DateTime.UtcNow).TotalSeconds}&q={text}&count={count}", out var result))
		{
			throw new Exception("Cant create URI for search user");
		}
		return result;
	}

	public static Uri GetSeenMediaStoryUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v2/media/seen/?reel=1&live_vod=0", out var result))
		{
			throw new Exception("Cant create URI for seen media story");
		}
		return result;
	}

	public static Uri GetSeenMediaUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/media/seen/", out var result))
		{
			throw new Exception("Cant create URI for seen media");
		}
		return result;
	}

	public static Uri GetSendDirectLinkUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/direct_v2/threads/broadcast/link/", out var result))
		{
			throw new Exception("Cant create URI for send link to direct thread");
		}
		return result;
	}

	public static Uri GetSendDirectLocationUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/direct_v2/threads/broadcast/location/", out var result))
		{
			throw new Exception("Cant create URI for send location to direct thread");
		}
		return result;
	}

	public static Uri GetSendDirectProfileUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/direct_v2/threads/broadcast/profile/", out var result))
		{
			throw new Exception("Cant create URI for send profile to direct thread");
		}
		return result;
	}

	public static Uri GetSendDirectHashtagUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/direct_v2/threads/broadcast/hashtag/", out var result))
		{
			throw new Exception("Cant create URI for send hashtag to direct thread");
		}
		return result;
	}

	public static Uri GetSendTwoFactorEnableSmsUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/accounts/send_two_factor_enable_sms/", out var result))
		{
			throw new Exception("Cant create URI for send two factor enable sms");
		}
		return result;
	}

	public static Uri GetSetBiographyUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/accounts/set_biography/", out var result))
		{
			throw new Exception("Cant create URI for set biography");
		}
		return result;
	}

	public static Uri GetSetBusinessCategoryUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/business/account/set_business_category/", out var result))
		{
			throw new Exception("Cant create URI for set business category");
		}
		return result;
	}

	public static Uri GetSetReelSettingsUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/users/set_reel_settings/", out var result))
		{
			throw new Exception("Cant create URI for set reel settings");
		}
		return result;
	}

	public static Uri GetShareLinkFromMediaId(string mediaId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/media/{mediaId}/permalink/", out var result))
		{
			throw new Exception("Can't create URI for getting share link");
		}
		return result;
	}

	public static Uri GetShareUserUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/direct_v2/threads/broadcast/profile/", out var result))
		{
			throw new Exception("Cant create URI for share user");
		}
		return result;
	}

	public static Uri GetSignUpSMSCodeUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/accounts/send_signup_sms_code/", out var result))
		{
			throw new Exception("Cant create URI for send signup sms code");
		}
		return result;
	}

	public static Uri GetStarThreadUri(string threadId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/direct_v2/threads/{threadId}/label/", out var result))
		{
			throw new Exception("Cant create URI for star thread");
		}
		return result;
	}

	public static Uri GetStoryConfigureUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/media/configure_to_reel/", out var result))
		{
			throw new Exception("Can't create URI for configuring story media");
		}
		return result;
	}

	public static Uri GetStoryFeedUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/feed/reels_tray/", out var result))
		{
			throw new Exception("Can't create URI for getting story tray");
		}
		return result;
	}

	public static Uri GetStoryMediaInfoUploadUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/media/mas_opt_in_info/", out var result))
		{
			throw new Exception("Cant create URI for story media info");
		}
		return result;
	}

	public static Uri GetStorySettingsUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/users/reel_settings/", out var result))
		{
			throw new Exception("Cant create URI for story settings");
		}
		return result;
	}

	public static Uri GetStoryShareUri(string mediaType)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/direct_v2/threads/broadcast/story_share/?media_type={mediaType}", out var result))
		{
			throw new Exception("Cant create URI for story share");
		}
		return result;
	}

	public static Uri GetStoryUploadPhotoUri(string uploadId, int fileHashCode)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"https://i.instagram.com/rupload_igphoto/{uploadId}_0_{fileHashCode}", out var result))
		{
			throw new Exception("Cant create URI for story upload photo");
		}
		return result;
	}

	public static Uri GetStoryUploadVideoUri(string uploadId, int fileHashCode)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"https://i.instagram.com/rupload_igvideo/{uploadId}_0_{fileHashCode}", out var result))
		{
			throw new Exception("Cant create URI for story upload video");
		}
		return result;
	}

	public static Uri GetSuggestedBroadcastsUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/live/get_suggested_broadcasts/", out var result))
		{
			throw new Exception("Cant create URI for get suggested broadcasts");
		}
		return result;
	}

	public static Uri GetSuggestedSearchUri(InstaDiscoverSearchType searchType)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/fbsearch/suggested_searches/?type={searchType.ToString().ToLower()}", out var result))
		{
			throw new Exception("Cant create URI for suggested search");
		}
		return result;
	}

	public static Uri GetTopSearchUri(string rankToken, string querry = "", InstaDiscoverSearchType searchType = InstaDiscoverSearchType.Users, int timezone_offset = 12600)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/fbsearch/topsearch_flat/?rank_token={rankToken}&timezone_offset={timezone_offset}&query={querry}&context={searchType.ToString().ToLower()}", out var result))
		{
			throw new Exception("Cant create URI for suggested search");
		}
		return result;
	}

	public static Uri GetSuggestedTagsUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/tags/suggested/", out var result))
		{
			throw new Exception("Cant create URI for suggested tags");
		}
		return result;
	}

	public static Uri GetSyncContactsUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/address_book/link/?include=extra_display_name,thumbnails", out var result))
		{
			throw new Exception("Cant create URI for sync contacts");
		}
		return result;
	}

	public static Uri GetTagFeedUri(string tag, string maxId = "")
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/feed/tag/{tag}", out var result))
		{
			throw new Exception("Cant create URI for discover tag feed");
		}
		if (string.IsNullOrEmpty(maxId))
		{
			return result;
		}
		return new UriBuilder(result)
		{
			Query = "max_id=" + maxId
		}.Uri;
	}

	public static Uri GetTagInfoUri(string tag)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/tags/{tag}/info/", out var result))
		{
			throw new Exception("Cant create tag info URI");
		}
		return result;
	}

	public static Uri GetTimelineWithMaxIdUri(string nextId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/feed/timeline", out var result))
		{
			throw new Exception("Cant create search URI for timeline");
		}
		return new UriBuilder(result)
		{
			Query = "max_id=" + nextId
		}.Uri;
	}

	public static Uri GetTwoFactorLoginUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/accounts/two_factor_login/", out var result))
		{
			throw new Exception("Cant create URI for user 2FA login");
		}
		return result;
	}

	public static Uri GetUnBlockUserUri(long userId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/friendships/unblock/{userId}/", out var result))
		{
			throw new Exception("Cant create URI for getting media likers");
		}
		return result;
	}

	public static Uri GetUnFollowHashtagUri(string hashtag)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/tags/unfollow/{hashtag}/", out var result))
		{
			throw new Exception("Cant create URI for unfollow hashtag");
		}
		return result;
	}

	public static Uri GetUnFollowUserUri(long userId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/friendships/destroy/{userId}/", out var result))
		{
			throw new Exception("Cant create URI for getting media likers");
		}
		return result;
	}

	public static Uri GetUnLikeCommentUri(string commentId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/media/{commentId}/comment_unlike/", out var result))
		{
			throw new Exception("Cant create URI for unlike comment");
		}
		return result;
	}

	public static Uri GetUnLikeMediaUri(string mediaId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/media/{mediaId}/unlike/", out var result))
		{
			throw new Exception("Cant create URI for unlike media");
		}
		return result;
	}

	public static Uri GetUnMuteDirectThreadUri(string threadId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/direct_v2/threads/{threadId}/unmute/", out var result))
		{
			throw new Exception("Cant create URI for unmute direct thread");
		}
		return result;
	}

	public static Uri GetUnStarThreadUri(string threadId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/direct_v2/threads/{threadId}/unlabel/", out var result))
		{
			throw new Exception("Cant create URI for unstar thread");
		}
		return result;
	}

	public static Uri GetUpdateBusinessInfoUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/accounts/update_business_info/", out var result))
		{
			throw new Exception("Cant create URI for update business info");
		}
		return result;
	}

	public static Uri GetUploadPhotoUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/upload/photo/", out var result))
		{
			throw new Exception("Cant create URI for upload photo");
		}
		return result;
	}

	public static Uri GetUploadVideoUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/upload/video/", out var result))
		{
			throw new Exception("Cant create URI for upload video");
		}
		return result;
	}

	public static Uri GetUriSetAccountPrivate()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/accounts/set_private/", out var result))
		{
			throw new Exception("Cant create URI for set account private");
		}
		return result;
	}

	public static Uri GetUriSetAccountPublic()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/accounts/set_public/", out var result))
		{
			throw new Exception("Cant create URI for set account public");
		}
		return result;
	}

	public static Uri GetUserFeedUri(string maxId = "")
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/feed/timeline", out var result))
		{
			throw new Exception("Cant create timeline feed URI");
		}
		if (string.IsNullOrEmpty(maxId))
		{
			return result;
		}
		return new UriBuilder(result)
		{
			Query = "max_id=" + maxId
		}.Uri;
	}

	public static Uri GetUserFollowersUri(long userPk, string rankToken, string searchQuery, bool mutualsfirst = false, string maxId = "")
	{
		Uri result = null;
		if (!mutualsfirst)
		{
			if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/friendships/{userPk}/followers/?rank_token={rankToken}", out result))
			{
				throw new Exception("Cant create URI for user followers");
			}
		}
		else if (!Uri.TryCreate(BaseInstagramUri, string.Format("/api/v1/friendships/{0}/followers/?rank_token={1}&rank_mutual={2}", userPk, rankToken, "1"), out result))
		{
			throw new Exception("Cant create URI for user followers");
		}
		return result.AddQueryParameterIfNotEmpty("max_id", maxId).AddQueryParameterIfNotEmpty("query", searchQuery);
	}

	public static Uri GetUserFollowingUri(long userPk, string rankToken, string searchQuery, string maxId = "")
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/friendships/{userPk}/following/?rank_token={rankToken}", out var result))
		{
			throw new Exception("Cant create URI for user following");
		}
		return result.AddQueryParameterIfNotEmpty("max_id", maxId).AddQueryParameterIfNotEmpty("query", searchQuery);
	}

	public static Uri GetUserFriendshipUri(long userId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/friendships/show/" + userId + "/", out var result))
		{
			throw new Exception("Can't create URI for getting friendship status");
		}
		return result;
	}

	public static Uri GetUserInfoByIdUri(long pk)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/users/{pk}/info/", out var result))
		{
			throw new Exception("Cant create user info by identifier URI");
		}
		return result;
	}

	public static Uri GetUserInfoByUsernameUri(string username)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/users/{username}/usernameinfo/", out var result))
		{
			throw new Exception("Cant create user info by username URI");
		}
		return result;
	}

	public static Uri GetUserLikeFeedUri(string maxId = null)
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/feed/liked/", out var result))
		{
			throw new Exception("Can't create URI for getting like feed");
		}
		string text = string.Empty;
		if (!string.IsNullOrEmpty(maxId))
		{
			text = text + "max_id=" + maxId;
		}
		return new UriBuilder(result)
		{
			Query = text
		}.Uri;
	}

	public static Uri GetUserMediaListUri(long userPk, string nextId = "")
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/feed/user/" + userPk, out var result))
		{
			throw new Exception("Cant create URI for user media retrieval");
		}
		if (string.IsNullOrEmpty(nextId))
		{
			return result;
		}
		return new UriBuilder(result)
		{
			Query = "max_id=" + nextId
		}.Uri;
	}

	public static Uri GetArchivedMediaFeedsListUri(string nextId = "")
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/feed/only_me_feed/", out var result))
		{
			throw new Exception("Cant create URI for arhcived media feeds");
		}
		if (string.IsNullOrEmpty(nextId))
		{
			return result;
		}
		return new UriBuilder(result)
		{
			Query = "max_id=" + nextId
		}.Uri;
	}

	public static Uri GetUsernameSuggestionsUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/accounts/username_suggestions/", out var result))
		{
			throw new Exception("Cant create URI for username suggestions");
		}
		return result;
	}

	public static Uri GetUserReelFeedUri(long userId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/feed/user/{userId}/reel_media/", out var result))
		{
			throw new Exception("Can't create URI for getting user reel feed");
		}
		return result;
	}

	public static Uri GetUserSearchByLocationUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/fbsearch/topsearch_flat/", out var result))
		{
			throw new Exception("Cant create URI for user search by location");
		}
		return result;
	}

	public static Uri GetUserStoryUri(long userId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/feed/user/{userId}/reel_media/", out var result))
		{
			throw new Exception("Can't create URI for getting user's story");
		}
		return result;
	}

	public static Uri GetUserTagsUri(long userPk, string rankToken, string maxId = null)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/usertags/{userPk}/feed/", out var result))
		{
			throw new Exception("Cant create URI for get user tags");
		}
		string text = "rank_token=" + rankToken + "&ranked_content=true";
		if (!string.IsNullOrEmpty(maxId))
		{
			text = text + "&max_id=" + maxId;
		}
		return new UriBuilder(result)
		{
			Query = text
		}.Uri;
	}

	public static Uri GetUserUri(string username)
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/users/search", out var result))
		{
			throw new Exception("Cant create search user URI");
		}
		return new UriBuilder(result)
		{
			Query = "q=" + username
		}.Uri;
	}

	public static Uri GetValidateReelLinkAddressUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/media/validate_reel_url/", out var result))
		{
			throw new Exception("Cant create URI for request for validate reel url");
		}
		return result;
	}

	public static Uri GetValidateSignUpSMSCodeUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/accounts/validate_signup_sms_code/", out var result))
		{
			throw new Exception("Cant create URI for validate signup sms code");
		}
		return result;
	}

	public static Uri GetVideoStoryConfigureUri(bool isVideo = false)
	{
		if (!Uri.TryCreate(BaseInstagramUri, isVideo ? "/api/v1/media/configure_to_story/?video=1" : "/api/v1/media/configure_to_story/", out var result))
		{
			throw new Exception("Can't create URI for configuring story media");
		}
		return result;
	}

	public static Uri GetAddUserToDirectThreadUri(string threadId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/direct_v2/threads/{threadId}/add_user/", out var result))
		{
			throw new Exception("Cant create URI for add users to direct thread");
		}
		return result;
	}

	public static Uri GetBusinessBrandedSettingsUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/business/branded_content/get_whitelist_settings/", out var result))
		{
			throw new Exception("Cant create URI for business branded settings");
		}
		return result;
	}

	public static Uri GetBusinessBrandedSearchUserUri(string query, int count)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/users/search/?q={query}&count={count}&branded_content_creator_only=true", out var result))
		{
			throw new Exception("Cant create URI for business branded user search");
		}
		return result;
	}

	public static Uri GetBusinessBrandedUpdateSettingsUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/business/branded_content/update_whitelist_settings/", out var result))
		{
			throw new Exception("Cant create URI for business branded update settings");
		}
		return result;
	}

	public static Uri GetMediaNametagConfigureUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/media/configure_to_nametag/", out var result))
		{
			throw new Exception("Cant create URI for media nametag configure");
		}
		return result;
	}

	public static Uri GetUsersNametagLookupUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/users/nametag_lookup/", out var result))
		{
			throw new Exception("Cant create URI for users nametag lookup");
		}
		return result;
	}

	public static Uri GetUsersNametagConfigUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/users/nametag_config/", out var result))
		{
			throw new Exception("Cant create URI for users nametag config");
		}
		return result;
	}

	public static Uri GetRemoveFollowerUri(long userId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/friendships/remove_follower/{userId}/", out var result))
		{
			throw new Exception("Cant create URI for remove follower");
		}
		return result;
	}

	public static Uri GetTranslateBiographyUri(long userId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/language/translate/?id={userId}&type=3", out var result))
		{
			throw new Exception("Cant create URI for translate bio");
		}
		return result;
	}

	public static Uri GetTranslateCommentsUri(string commendIds)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/language/bulk_translate/?comment_ids={commendIds}", out var result))
		{
			throw new Exception("Cant create URI for translate comments");
		}
		return result;
	}

	public static Uri GetSearchPlacesUri(int timezoneOffset, double lat, double lng, string query, string rankToken, List<long> excludeList)
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/fbsearch/places/", out var result))
		{
			throw new Exception("Cant create URI for search places");
		}
		string text = $"timezone_offset={timezoneOffset}&lat={lat.ToString(CultureInfo.InvariantCulture)}&lng={lng.ToString(CultureInfo.InvariantCulture)}";
		if (!string.IsNullOrEmpty(query))
		{
			text = text + "&query=" + query;
		}
		if (!string.IsNullOrEmpty(rankToken))
		{
			text = text + "&rank_token=" + rankToken;
		}
		if (excludeList != null && excludeList.Count > 0)
		{
			text = text + "&exclude_list=[" + string.Join(",", excludeList) + "]";
		}
		return new UriBuilder(result)
		{
			Query = text
		}.Uri;
	}

	public static Uri GetBroadcastReelShareUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/direct_v2/threads/broadcast/reel_share/", out var result))
		{
			throw new Exception("Cant create URI for direct broadcast reel share");
		}
		return result;
	}

	public static Uri GetUserShoppableMediaListUri(long userPk, string nextId = "")
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/feed/user/{userPk}/shoppable_media/", out var result))
		{
			throw new Exception("Cant create URI for user shoppable media");
		}
		if (string.IsNullOrEmpty(nextId))
		{
			return result;
		}
		return new UriBuilder(result)
		{
			Query = "max_id=" + nextId
		}.Uri;
	}

	public static Uri GetProductInfoUri(long productId, string mediaPk, int deviceWidth)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/commerce/products/{productId}/?media_id={mediaPk}&device_width={deviceWidth}", out var result))
		{
			throw new Exception("Cant create URI for product info");
		}
		return result;
	}

	public static Uri GetMarkUserOverageUri(long userId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/friendships/mark_user_overage/{userId}/feed/", out var result))
		{
			throw new Exception("Cant create URI for mark user overage");
		}
		return result;
	}

	public static Uri GetFavoriteUserUri(long userId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/friendships/favorite/{userId}/", out var result))
		{
			throw new Exception("Cant create URI for favorite user");
		}
		return result;
	}

	public static Uri GetUnFavoriteUserUri(long userId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/friendships/unfavorite/{userId}/", out var result))
		{
			throw new Exception("Cant create URI for unfavorite user");
		}
		return result;
	}

	public static Uri GetFavoriteForUserStoriesUri(long userId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/friendships/favorite_for_stories/{userId}/", out var result))
		{
			throw new Exception("Cant create URI for favorite user stories");
		}
		return result;
	}

	public static Uri GetUnFavoriteForUserStoriesUri(long userId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/friendships/unfavorite_for_stories/{userId}/", out var result))
		{
			throw new Exception("Cant create URI for unfavorite user stories");
		}
		return result;
	}

	public static Uri GetMuteUserMediaStoryUri(long userId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/friendships/mute_posts_or_story_from_follow/", out var result))
		{
			throw new Exception("Cant create URI for mute user media or story");
		}
		return result;
	}

	public static Uri GetUnMuteUserMediaStoryUri(long userId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/friendships/unmute_posts_or_story_from_follow/", out var result))
		{
			throw new Exception("Cant create URI for unmute user media or story");
		}
		return result;
	}

	public static Uri GetHideMyStoryFromUserUri(long userId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/friendships/block_friend_reel/{userId}/", out var result))
		{
			throw new Exception("Cant create URI for hide my story from specific user");
		}
		return result;
	}

	public static Uri GetUnHideMyStoryFromUserUri(long userId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/friendships/unblock_friend_reel/{userId}/", out var result))
		{
			throw new Exception("Cant create URI for unhide my story from from specific user");
		}
		return result;
	}

	public static Uri GetMuteFriendStoryUri(long userId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/friendships/mute_friend_reel/{userId}/", out var result))
		{
			throw new Exception("Cant create URI for mute friend story");
		}
		return result;
	}

	public static Uri GetUnMuteFriendStoryUri(long userId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/friendships/unmute_friend_reel/{userId}/", out var result))
		{
			throw new Exception("Cant create URI for unmute friend story");
		}
		return result;
	}

	public static Uri GetBlockedStoriesUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/friendships/blocked_reels/", out var result))
		{
			throw new Exception("Cant create URI for blocked stories");
		}
		return result;
	}

	public static Uri GetVerifyEmailUri(Uri uri)
	{
		string text = uri.ToString();
		if (text.Contains("?"))
		{
			text = text.Substring(0, text.IndexOf("?"));
		}
		text = text.Substring(text.IndexOf("/accounts/"));
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1" + text, out var result))
		{
			throw new Exception("Cant create URI for verify email");
		}
		return result;
	}

	public static Uri GetHideDirectThreadUri(string threadId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/direct_v2/threads/{threadId}/hide/", out var result))
		{
			throw new Exception("Cant create URI for hide direct thread");
		}
		return result;
	}

	public static Uri GetDeleteDirectMessageUri(string threadId, string itemId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, string.Format("/api/v1/direct_v2/threads/{0}/hide/", threadId, itemId), out var result))
		{
			throw new Exception("Cant create URI for delete direct message");
		}
		return result;
	}

	public static Uri GetLocationInfoUri(string externalId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/locations/{externalId}/info/", out var result))
		{
			throw new Exception("Cant create URI for location info");
		}
		return result;
	}

	public static Uri GetStoryMediaViewersUri(string storyMediaId, string nextId = "")
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/media/{storyMediaId}/list_reel_media_viewer/", out var result))
		{
			throw new Exception("Cant create URI for story media viewers");
		}
		if (string.IsNullOrEmpty(nextId))
		{
			return result;
		}
		return new UriBuilder(result)
		{
			Query = "max_id=" + nextId
		}.Uri;
	}

	public static Uri GetBlockedMediaUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/media/blocked/", out var result))
		{
			throw new Exception("Cant create URI for blocked media");
		}
		return result;
	}

	public static Uri GetMediaInfoByMultipleMediaIdsUri(string[] mediaIds, string uuid, string csrfToken)
	{
		if (!Uri.TryCreate(BaseInstagramUri, string.Format("/api/v1/media/infos/?_uuid={0}&_csrftoken={1}&media_ids={2}&ranked_content=true&include_inactive_reel=true", uuid, csrfToken, string.Join(",", mediaIds)), out var result))
		{
			throw new Exception("Cant create URI for media info by multiple media ids");
		}
		return result;
	}

	public static Uri GetBlockedUsersUri(string maxId = "")
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/users/blocked_list/", out var result))
		{
			throw new Exception("Cant create URI for blocked users");
		}
		if (string.IsNullOrEmpty(maxId))
		{
			return result;
		}
		return new UriBuilder(result)
		{
			Query = "max_id=" + maxId
		}.Uri;
	}

	public static Uri GetConvertToPersonalAccountUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/accounts/convert_to_personal/", out var result))
		{
			throw new Exception("Cant create URI for account convert to personal account");
		}
		return result;
	}

	public static Uri GetCreateBusinessInfoUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/accounts/create_business_info/", out var result))
		{
			throw new Exception("Cant create URI for account create business info");
		}
		return result;
	}

	public static Uri GetConvertToBusinessAccountUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/business_conversion/get_business_convert_social_context/", out var result))
		{
			throw new Exception("Cant create URI for convert to business account");
		}
		return result;
	}

	public static Uri GetUsersLookupUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/users/lookup/", out var result))
		{
			throw new Exception("Cant create URI for user lookup");
		}
		return result;
	}

	public static Uri GetArchiveMediaUri(string mediaId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/media/{mediaId}/only_me/", out var result))
		{
			throw new Exception("Cant create URI for archive an post");
		}
		return result;
	}

	public static Uri GetUnArchiveMediaUri(string mediaId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/media/{mediaId}/undo_only_me/", out var result))
		{
			throw new Exception("Cant create URI for unarchive an post");
		}
		return result;
	}

	public static Uri GetPresenceUri(string signedKey)
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/accounts/get_presence_disabled/", out var result))
		{
			throw new Exception("Cant create URI for get presence disabled");
		}
		string text = signedKey + ".{}";
		string query = "signed_body=" + text + "&ig_sig_key_version=4";
		return new UriBuilder(result)
		{
			Query = query
		}.Uri;
	}

	public static Uri GetBlockedCommentersUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/accounts/get_blocked_commenters/", out var result))
		{
			throw new Exception("Cant create URI for blocked commenters");
		}
		return result;
	}

	public static Uri GetSetBlockedCommentersUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/accounts/set_blocked_commenters/", out var result))
		{
			throw new Exception("Cant create URI for set blocked commenters");
		}
		return result;
	}

	public static Uri GetStoryPollVotersUri(string storyMediaId, string pollId, string maxId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/media/{storyMediaId}/{pollId}/story_poll_voters/", out var result))
		{
			throw new Exception("Cant create URI for get story poll voters list");
		}
		if (string.IsNullOrEmpty(maxId))
		{
			return result;
		}
		return new UriBuilder(result)
		{
			Query = "max_id=" + maxId
		}.Uri;
	}

	public static Uri GetStoryPollVoteUri(string storyMediaId, string pollId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/media/{storyMediaId}/{pollId}/story_poll_vote/", out var result))
		{
			throw new Exception("Cant create URI for get story poll vote");
		}
		return result;
	}

	public static Uri GetVoteStorySliderUri(string storyMediaId, string pollId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/media/{storyMediaId}/{pollId}/story_slider_vote/", out var result))
		{
			throw new Exception("Cant create URI for vote story slider");
		}
		return result;
	}

	public static Uri GetSaveMediaUri(string mediaId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/media/{mediaId}/save/", out var result))
		{
			throw new Exception("Cant create URI for save media");
		}
		return result;
	}

	public static Uri GetUnSaveMediaUri(string mediaId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/media/{mediaId}/unsave/", out var result))
		{
			throw new Exception("Cant create URI for unsave media");
		}
		return result;
	}

	public static Uri GetSavedFeedUri(string maxId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/feed/saved/", out var result))
		{
			throw new Exception("Cant create URI for get saved feed");
		}
		if (string.IsNullOrEmpty(maxId))
		{
			return result;
		}
		return new UriBuilder(result)
		{
			Query = "max_id=" + maxId
		}.Uri;
	}

	public static Uri GetBestFriendsUri(string maxId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/friendships/besties/", out var result))
		{
			throw new Exception("Cant create URI for user besties");
		}
		if (string.IsNullOrEmpty(maxId))
		{
			return result;
		}
		return new UriBuilder(result)
		{
			Query = "max_id=" + maxId
		}.Uri;
	}

	public static Uri GetBestiesSuggestionUri(string maxId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/friendships/bestie_suggestions/", out var result))
		{
			throw new Exception("Cant create URI for user besties suggestions");
		}
		if (string.IsNullOrEmpty(maxId))
		{
			return result;
		}
		return new UriBuilder(result)
		{
			Query = "max_id=" + maxId
		}.Uri;
	}

	public static Uri GetSetBestFriendsUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/friendships/set_besties/", out var result))
		{
			throw new Exception("Cant create URI for set best friends");
		}
		return result;
	}

	public static Uri GetLocationFeedUri(string locationId, string maxId = null)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/feed/location/{locationId}/", out var result))
		{
			throw new Exception("Cant create URI for get location feed");
		}
		return result.AddQueryParameterIfNotEmpty("max_id", maxId);
	}

	public static Uri GetLocationSectionUri(string locationId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/locations/{locationId}/sections/", out var result))
		{
			throw new Exception("Cant create URI for get location section");
		}
		return result;
	}

	public static Uri GetLocationSearchUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/location_search/", out var result))
		{
			throw new Exception("Cant create URI for location search");
		}
		return result;
	}

	public static Uri GetAccountDetailsUri(long userId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/users/{userId}/account_details/", out var result))
		{
			throw new Exception("Cant create URI for account details");
		}
		return result;
	}

	public static Uri GetStoryQuestionResponseUri(string storyId, long questionid)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/media/{storyId}/{questionid}/story_question_response/", out var result))
		{
			throw new Exception("Cant create URI for story question answer");
		}
		return result;
	}

	public static Uri GetStoryCountdownMediaUri()
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/media/story_countdowns/", out var result))
		{
			throw new Exception("Cant create URI for story countdown media");
		}
		return result;
	}

	public static Uri GetStoryFollowCountdownUri(long countdownId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/media/{countdownId}/follow_story_countdown/", out var result))
		{
			throw new Exception("Cant create URI for story follow countdown");
		}
		return result;
	}

	public static Uri GetStoryUnFollowCountdownUri(long countdownId)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/media/{countdownId}/unfollow_story_countdown/", out var result))
		{
			throw new Exception("Cant create URI for story unfollow countdown");
		}
		return result;
	}

	public static Uri GetHashtagSectionUri(string hashtag)
	{
		if (!Uri.TryCreate(BaseInstagramUri, $"/api/v1/tags/{hashtag}/sections/", out var result))
		{
			throw new Exception("Cant create URI for hashtag section");
		}
		return result;
	}

	public static Uri GetTopicalExploreUri(string sessionId, string maxId = null, string clusterId = null)
	{
		if (!Uri.TryCreate(BaseInstagramUri, "/api/v1/discover/topical_explore/", out var result))
		{
			throw new Exception("Cant create URI for topical explore");
		}
		result = result.AddQueryParameter("is_prefetch", "false").AddQueryParameter("module", "explore_popular").AddQueryParameter("use_sectional_payload", "true")
			.AddQueryParameter("timezone_offset", InstaApiConstants.TIMEZONE_OFFSET.ToString())
			.AddQueryParameter("session_id", sessionId)
			.AddQueryParameter("include_fixed_destinations", "false");
		if (!(clusterId.ToLower() == "explore_all:0") && !(clusterId.ToLower() == "explore_all%3A0"))
		{
			result = result.AddQueryParameter("cluster_id", clusterId);
			result = result.AddQueryParameter("max_id", maxId);
		}
		else if (!string.IsNullOrEmpty(maxId))
		{
			result = result.AddQueryParameter("max_id", maxId);
			result = result.AddQueryParameter("cluster_id", "explore_all%3A0");
		}
		return result;
	}
}
