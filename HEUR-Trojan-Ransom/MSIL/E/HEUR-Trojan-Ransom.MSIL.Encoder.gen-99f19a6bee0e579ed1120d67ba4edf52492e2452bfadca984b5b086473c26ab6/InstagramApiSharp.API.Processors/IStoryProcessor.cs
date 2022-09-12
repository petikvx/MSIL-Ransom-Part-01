using System;
using System.Threading.Tasks;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Enums;

namespace InstagramApiSharp.API.Processors;

public interface IStoryProcessor
{
	Task<IResult<bool>> AnswerToStoryQuestionAsync(string storyId, long questionId, string responseText);

	Task<IResult<InstaHighlightFeed>> CreateHighlightFeedAsync(string mediaId, string title, float cropWidth, float cropHeight);

	Task<IResult<bool>> DeleteHighlightFeedAsync(string highlightId, string mediaId);

	Task<IResult<bool>> DeleteStoryAsync(string storyMediaId, InstaSharingType sharingType = InstaSharingType.Video);

	Task<IResult<bool>> FollowCountdownStoryAsync(long countdownId);

	Task<IResult<InstaUserShortList>> GetBlockedUsersFromStoriesAsync();

	Task<IResult<InstaStoryCountdownList>> GetCountdownsStoriesAsync();

	Task<IResult<InstaHighlightFeeds>> GetHighlightFeedsAsync(long userId);

	Task<IResult<InstaHighlightShortList>> GetHighlightsArchiveAsync();

	Task<IResult<InstaHighlightSingleFeed>> GetHighlightsArchiveMediasAsync(string highlightId);

	Task<IResult<InstaHighlightSingleFeed>> GetHighlightMediasAsync(string highlightId);

	Task<IResult<InstaStoryFeed>> GetStoryFeedAsync();

	Task<IResult<InstaReelStoryMediaViewers>> GetStoryMediaViewersAsync(string storyMediaId, PaginationParameters paginationParameters);

	Task<IResult<InstaStoryPollVotersList>> GetStoryPollVotersAsync(string storyMediaId, string pollId, PaginationParameters paginationParameters);

	Task<IResult<InstaStory>> GetUserStoryAsync(long userId);

	Task<IResult<InstaReelFeed>> GetUserStoryFeedAsync(long userId);

	Task<IResult<bool>> MarkStoryAsSeenAsync(string storyMediaId, long takenAtUnix);

	Task<IResult<bool>> MarkHighlightAsSeenAsync(string mediaId, string highlightId, long takenAtUnix);

	Task<IResult<InstaStoryMedia>> ShareMediaAsStoryAsync(InstaImage image, InstaMediaStoryUpload mediaStoryUpload);

	Task<IResult<InstaStoryMedia>> ShareMediaAsStoryAsync(Action<InstaUploaderProgress> progress, InstaImage image, InstaMediaStoryUpload mediaStoryUpload);

	Task<IResult<InstaSharing>> ShareStoryAsync(string reelId, string storyMediaId, string threadId, string text, InstaSharingType sharingType = InstaSharingType.Video);

	Task<IResult<bool>> ReplyToStoryAsync(string storyMediaId, long userId, string text);

	Task<IResult<bool>> UnFollowCountdownStoryAsync(long countdownId);

	Task<IResult<InstaStoryMedia>> UploadStoryPhotoAsync(InstaImage image, string caption, InstaStoryUploadOptions uploadOptions = null);

	Task<IResult<InstaStoryMedia>> UploadStoryPhotoAsync(Action<InstaUploaderProgress> progress, InstaImage image, string caption, InstaStoryUploadOptions uploadOptions = null);

	Task<IResult<InstaStoryMedia>> UploadStoryPhotoWithUrlAsync(InstaImage image, string caption, Uri uri, InstaStoryUploadOptions uploadOptions = null);

	Task<IResult<InstaStoryMedia>> UploadStoryPhotoWithUrlAsync(Action<InstaUploaderProgress> progress, InstaImage image, string caption, Uri uri, InstaStoryUploadOptions uploadOptions = null);

	Task<IResult<InstaStoryMedia>> UploadStoryVideoAsync(InstaVideoUpload video, string caption, InstaStoryUploadOptions uploadOptions = null);

	Task<IResult<InstaStoryMedia>> UploadStoryVideoAsync(Action<InstaUploaderProgress> progress, InstaVideoUpload video, string caption, InstaStoryUploadOptions uploadOptions = null);

	Task<IResult<bool>> UploadStoryVideoAsync(InstaVideoUpload video, InstaStoryType storyType = InstaStoryType.SelfStory, InstaStoryUploadOptions uploadOptions = null, params string[] threadIds);

	Task<IResult<bool>> UploadStoryVideoAsync(Action<InstaUploaderProgress> progress, InstaVideoUpload video, InstaStoryType storyType = InstaStoryType.SelfStory, InstaStoryUploadOptions uploadOptions = null, params string[] threadIds);

	Task<IResult<InstaStoryMedia>> UploadStoryVideoWithUrlAsync(InstaVideoUpload video, string caption, Uri uri, InstaStoryUploadOptions uploadOptions = null);

	Task<IResult<InstaStoryMedia>> UploadStoryVideoWithUrlAsync(Action<InstaUploaderProgress> progress, InstaVideoUpload video, string caption, Uri uri, InstaStoryUploadOptions uploadOptions = null);

	Task<IResult<bool>> UploadStoryVideoWithUrlAsync(InstaVideoUpload video, Uri uri, InstaStoryType storyType = InstaStoryType.SelfStory, InstaStoryUploadOptions uploadOptions = null, params string[] threadIds);

	Task<IResult<bool>> UploadStoryVideoWithUrlAsync(Action<InstaUploaderProgress> progress, InstaVideoUpload video, Uri uri, InstaStoryType storyType = InstaStoryType.SelfStory, InstaStoryUploadOptions uploadOptions = null, params string[] threadIds);

	Task<IResult<InstaStoryItem>> VoteStoryPollAsync(string storyMediaId, string pollId, InstaStoryPollVoteType pollVote);

	Task<IResult<InstaStoryItem>> VoteStorySliderAsync(string storyMediaId, string pollId, double sliderVote = 0.5);
}
