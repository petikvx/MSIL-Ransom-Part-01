using System.Collections.Generic;
using System.Threading.Tasks;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.Models.Hashtags;

namespace InstagramApiSharp.API.Processors;

public interface IHashtagProcessor
{
	Task<IResult<bool>> FollowHashtagAsync(string tagname);

	Task<IResult<InstaHashtagSearch>> GetFollowingHashtagsInfoAsync(long userId);

	Task<IResult<InstaHashtag>> GetHashtagInfoAsync(string tagname);

	Task<IResult<InstaHashtagStory>> GetHashtagStoriesAsync(string tagname);

	Task<IResult<InstaSectionMedia>> GetRecentHashtagMediaListAsync(string tagname, PaginationParameters paginationParameters);

	Task<IResult<InstaHashtagSearch>> GetSuggestedHashtagsAsync();

	Task<IResult<InstaSectionMedia>> GetTopHashtagMediaListAsync(string tagname, PaginationParameters paginationParameters);

	Task<IResult<InstaHashtagSearch>> SearchHashtagAsync(string query, IEnumerable<long> excludeList = null, string rankToken = null);

	Task<IResult<bool>> UnFollowHashtagAsync(string tagname);
}
