using System;
using System.Threading.Tasks;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Enums;

namespace InstagramApiSharp.API.Processors;

public interface IMessagingProcessor
{
	Task<IResult<InstaDirectInboxThread>> AddUserToGroupThreadAsync(string threadId, params long[] userIds);

	Task<IResult<bool>> ApproveDirectPendingRequestAsync(params string[] threadIds);

	Task<IResult<bool>> DeclineAllDirectPendingRequestsAsync();

	Task<IResult<bool>> DeclineDirectPendingRequestsAsync(params string[] threadIds);

	Task<IResult<bool>> DeleteDirectThreadAsync(string threadId);

	Task<IResult<bool>> DeleteSelfMessageAsync(string threadId, string itemId);

	Task<IResult<InstaDirectInboxContainer>> GetDirectInboxAsync(PaginationParameters paginationParameters);

	Task<IResult<InstaDirectInboxThread>> GetDirectInboxThreadAsync(string threadId, PaginationParameters paginationParameters);

	Task<IResult<InstaDirectInboxContainer>> GetPendingDirectAsync(PaginationParameters paginationParameters);

	Task<IResult<InstaRecipients>> GetRankedRecipientsAsync();

	Task<IResult<InstaRecipients>> GetRankedRecipientsByUsernameAsync(string username);

	Task<IResult<InstaRecipients>> GetRecentRecipientsAsync();

	Task<IResult<InstaUserPresenceList>> GetUsersPresenceAsync();

	Task<IResult<bool>> LeaveGroupThreadAsync(string threadId);

	Task<IResult<bool>> LikeThreadMessageAsync(string threadId, string itemId);

	Task<IResult<bool>> MarkDirectThreadAsSeenAsync(string threadId, string itemId);

	Task<IResult<bool>> MuteDirectThreadAsync(string threadId);

	Task<IResult<bool>> SendDirectDisappearingPhotoAsync(InstaImage image, InstaViewMode viewMode = InstaViewMode.Replayable, params string[] threadIds);

	Task<IResult<bool>> SendDirectDisappearingPhotoAsync(Action<InstaUploaderProgress> progress, InstaImage image, InstaViewMode viewMode = InstaViewMode.Replayable, params string[] threadIds);

	Task<IResult<bool>> SendDirectDisappearingVideoAsync(InstaVideoUpload video, InstaViewMode viewMode = InstaViewMode.Replayable, params string[] threadIds);

	Task<IResult<bool>> SendDirectDisappearingVideoAsync(Action<InstaUploaderProgress> progress, InstaVideoUpload video, InstaViewMode viewMode = InstaViewMode.Replayable, params string[] threadIds);

	Task<IResult<bool>> SendDirectHashtagAsync(string text, string hashtag, params string[] threadIds);

	Task<IResult<bool>> SendDirectHashtagAsync(string text, string hashtag, string[] threadIds, string[] recipients);

	Task<IResult<bool>> SendDirectHashtagToRecipientsAsync(string text, string hashtag, params string[] recipients);

	Task<IResult<bool>> SendDirectLinkAsync(string text, string link, params string[] threadIds);

	Task<IResult<bool>> SendDirectLinkAsync(string text, string link, string[] threadIds, string[] recipients);

	Task<IResult<bool>> SendDirectLinkToRecipientsAsync(string text, string link, params string[] recipients);

	Task<IResult<bool>> SendDirectLocationAsync(string externalId, params string[] threadIds);

	Task<IResult<bool>> SendDirectPhotoAsync(InstaImage image, string threadId);

	Task<IResult<bool>> SendDirectPhotoAsync(Action<InstaUploaderProgress> progress, InstaImage image, string threadId);

	Task<IResult<bool>> SendDirectPhotoToRecipientsAsync(InstaImage image, params string[] recipients);

	Task<IResult<bool>> SendDirectPhotoToRecipientsAsync(Action<InstaUploaderProgress> progress, InstaImage image, params string[] recipients);

	Task<IResult<bool>> SendDirectProfileAsync(long userIdToSend, params string[] threadIds);

	Task<IResult<bool>> SendDirectProfileToRecipientsAsync(long userIdToSend, string recipients);

	Task<IResult<InstaDirectInboxThreadList>> SendDirectTextAsync(string recipients, string threadIds, string text);

	Task<IResult<bool>> SendDirectVideoAsync(InstaVideoUpload video, string threadId);

	Task<IResult<bool>> SendDirectVideoAsync(Action<InstaUploaderProgress> progress, InstaVideoUpload video, string threadId);

	Task<IResult<bool>> SendDirectVideoToRecipientsAsync(InstaVideoUpload video, params string[] recipients);

	Task<IResult<bool>> SendDirectVideoToRecipientsAsync(Action<InstaUploaderProgress> progress, InstaVideoUpload video, params string[] recipients);

	Task<IResult<bool>> ShareMediaToThreadAsync(string mediaId, InstaMediaType mediaType, string text, params string[] threadIds);

	Task<IResult<bool>> ShareMediaToUserAsync(string mediaId, InstaMediaType mediaType, string text, params long[] userIds);

	[Obsolete("ShareUserAsync is deprecated. Use SendDirectProfileAsync instead.")]
	Task<IResult<InstaSharing>> ShareUserAsync(string userIdToSend, string threadId);

	Task<IResult<bool>> UnLikeThreadMessageAsync(string threadId, string itemId);

	Task<IResult<bool>> UnMuteDirectThreadAsync(string threadId);

	Task<IResult<bool>> UpdateDirectThreadTitleAsync(string threadId, string title);

	Task<IResult<bool>> SendDirectLikeAsync(string threadId);
}
