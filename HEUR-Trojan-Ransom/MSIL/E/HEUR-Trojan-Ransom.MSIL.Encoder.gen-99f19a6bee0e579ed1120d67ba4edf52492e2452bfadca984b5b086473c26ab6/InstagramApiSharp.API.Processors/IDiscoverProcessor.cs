using System.Threading.Tasks;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Enums;

namespace InstagramApiSharp.API.Processors;

public interface IDiscoverProcessor
{
	Task<IResult<bool>> ClearRecentSearchsAsync();

	Task<IResult<InstaUserChainingList>> GetChainingUsersAsync();

	Task<IResult<InstaDiscoverRecentSearches>> GetRecentSearchesAsync();

	Task<IResult<InstaDiscoverTopSearches>> GetTopSearchesAsync(string querry = "", InstaDiscoverSearchType searchType = InstaDiscoverSearchType.Users, int timezone_offset = 12600);

	Task<IResult<InstaDiscoverSuggestedSearches>> GetSuggestedSearchesAsync(InstaDiscoverSearchType searchType = InstaDiscoverSearchType.Users);

	Task<IResult<InstaDiscoverSearchResult>> SearchPeopleAsync(string query, int count = 50);

	Task<IResult<InstaContactUserList>> SyncContactsAsync(params InstaContact[] instaContacts);

	Task<IResult<InstaContactUserList>> SyncContactsAsync(InstaContactList instaContacts);
}
