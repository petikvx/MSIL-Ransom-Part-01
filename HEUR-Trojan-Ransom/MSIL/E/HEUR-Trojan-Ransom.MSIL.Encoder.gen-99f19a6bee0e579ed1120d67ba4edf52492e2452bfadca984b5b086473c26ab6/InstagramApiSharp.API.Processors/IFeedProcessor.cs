using System.Threading.Tasks;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Models;

namespace InstagramApiSharp.API.Processors;

public interface IFeedProcessor
{
	Task<IResult<InstaExploreFeed>> GetExploreFeedAsync(PaginationParameters paginationParameters);

	Task<IResult<InstaActivityFeed>> GetFollowingRecentActivityFeedAsync(PaginationParameters paginationParameters);

	Task<IResult<InstaMediaList>> GetLikedFeedAsync(PaginationParameters paginationParameters);

	Task<IResult<InstaActivityFeed>> GetRecentActivityFeedAsync(PaginationParameters paginationParameters);

	Task<IResult<InstaMediaList>> GetSavedFeedAsync(PaginationParameters paginationParameters);

	Task<IResult<InstaTagFeed>> GetTagFeedAsync(string tag, PaginationParameters paginationParameters);

	Task<IResult<InstaFeed>> GetUserTimelineFeedAsync(PaginationParameters paginationParameters, string[] seenMediaIds = null, bool refreshRequest = false);

	Task<IResult<InstaTopicalExploreFeed>> GetTopicalExploreFeedAsync(PaginationParameters paginationParameters, string clusterId = null);
}
