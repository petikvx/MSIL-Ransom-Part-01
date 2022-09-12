using System.Threading.Tasks;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Models;

namespace InstagramApiSharp.API.Processors;

public interface ILiveProcessor
{
	Task<IResult<InstaBroadcastAddToPostLive>> AddToPostLiveAsync(string broadcastId);

	Task<IResult<InstaComment>> CommentAsync(string broadcastId, string commentText);

	Task<IResult<InstaBroadcastCreate>> CreateAsync(int previewWidth = 720, int previewHeight = 1184, string broadcastMessage = "");

	Task<IResult<bool>> DeletePostLiveAsync(string broadcastId);

	Task<IResult<InstaBroadcastCommentEnableDisable>> DisableCommentsAsync(string broadcastId);

	Task<IResult<InstaBroadcastCommentEnableDisable>> EnableCommentsAsync(string broadcastId);

	Task<IResult<bool>> EndAsync(string broadcastId, bool endAfterCopyrightWarning = false);

	Task<IResult<InstaBroadcastCommentList>> GetCommentsAsync(string broadcastId, string lastCommentTs = "", int commentsRequested = 4);

	Task<IResult<InstaDiscoverTopLive>> GetDiscoverTopLiveAsync(PaginationParameters paginationParameters);

	Task<IResult<InstaUserShortList>> GetFinalViewerListAsync(string broadcastId);

	Task<IResult<InstaBroadcastLiveHeartBeatViewerCount>> GetHeartBeatAndViewerCountAsync(string broadcastId);

	Task<IResult<InstaBroadcastInfo>> GetInfoAsync(string broadcastId);

	Task<IResult<InstaUserShortList>> GetJoinRequestsAsync(string broadcastId);

	Task<IResult<InstaBroadcastLike>> GetLikeCountAsync(string broadcastId, int likeTs = 0);

	Task<IResult<InstaUserShortList>> GetPostLiveViewerListAsync(string broadcastId, int? maxId = null);

	Task<IResult<InstaBroadcastList>> GetSuggestedBroadcastsAsync();

	Task<IResult<InstaBroadcastTopLiveStatusList>> GetTopLiveStatusAsync(params string[] broadcastIds);

	Task<IResult<InstaUserShortList>> GetViewerListAsync(string broadcastId);

	Task<IResult<InstaBroadcastLike>> LikeAsync(string broadcastId, int likeCount = 1);

	Task<IResult<InstaBroadcastPinUnpin>> PinCommentAsync(string broadcastId, string commentId);

	Task<IResult<InstaBroadcastStart>> StartAsync(string broadcastId, bool sendNotifications);

	Task<IResult<bool>> ShareLiveToDirectThreadAsync(string text, string broadcastId, params string[] threadIds);

	Task<IResult<bool>> ShareLiveToDirectThreadAsync(string text, string broadcastId, string[] threadIds, string[] recipients);

	Task<IResult<bool>> ShareLiveToDirectRecipientAsync(string text, string broadcastId, params string[] recipients);

	Task<IResult<InstaBroadcastPinUnpin>> UnPinCommentAsync(string broadcastId, string commentId);
}
