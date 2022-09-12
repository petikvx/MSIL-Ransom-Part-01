using System.Threading.Tasks;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Enums;

namespace InstagramApiSharp.API.Processors;

public interface IUserProcessor
{
	Task<IResult<InstaFriendshipStatus>> AcceptFriendshipRequestAsync(long userId);

	Task<IResult<InstaFriendshipShortStatusList>> AddBestFriendsAsync(params long[] userIds);

	Task<IResult<InstaFriendshipFullStatus>> BlockUserAsync(long userId);

	Task<IResult<InstaFriendshipShortStatusList>> DeleteBestFriendsAsync(params long[] userIds);

	Task<IResult<bool>> FavoriteUserAsync(long userId);

	Task<IResult<bool>> FavoriteUserStoriesAsync(long userId);

	Task<IResult<InstaFriendshipFullStatus>> FollowUserAsync(long userId);

	Task<IResult<InstaUserShortList>> GetBestFriendsAsync(PaginationParameters paginationParameters);

	Task<IResult<InstaUserShortList>> GetBestFriendsSuggestionsAsync(PaginationParameters paginationParameters);

	Task<IResult<InstaBlockedUsers>> GetBlockedUsersAsync(PaginationParameters paginationParameters);

	Task<IResult<InstaCurrentUser>> GetCurrentUserAsync();

	Task<IResult<InstaUserShortList>> GetCurrentUserFollowersAsync(PaginationParameters paginationParameters);

	Task<IResult<InstaActivityFeed>> GetFollowingRecentActivityFeedAsync(PaginationParameters paginationParameters);

	Task<IResult<InstaStoryFriendshipStatus>> GetFriendshipStatusAsync(long userId);

	Task<IResult<InstaFriendshipShortStatusList>> GetFriendshipStatusesAsync(params long[] userIds);

	Task<IResult<InstaFullUserInfo>> GetFullUserInfoAsync(long userId);

	Task<IResult<InstaPendingRequest>> GetPendingFriendRequestsAsync();

	Task<IResult<InstaActivityFeed>> GetRecentActivityFeedAsync(PaginationParameters paginationParameters);

	Task<IResult<InstaSuggestionItemList>> GetSuggestionDetailsAsync(params long[] userIds);

	Task<IResult<InstaSuggestions>> GetSuggestionUsersAsync(PaginationParameters paginationParameters);

	Task<IResult<InstaUser>> GetUserAsync(string username);

	Task<IResult<InstaUser>> GetUserFromNametagAsync(InstaImage nametagImage);

	Task<IResult<InstaUserShortList>> GetUserFollowersAsync(string username, PaginationParameters paginationParameters, string searchQuery = "", bool mutualsfirst = false);

	Task<IResult<InstaUserShortList>> GetUserFollowersByIdAsync(long userId, PaginationParameters paginationParameters, string searchQuery = "", bool mutualsfirst = false);

	Task<IResult<InstaUserShortList>> GetUserFollowingAsync(string username, PaginationParameters paginationParameters, string searchQuery = "");

	Task<IResult<InstaUserShortList>> GetUserFollowingByIdAsync(long userId, PaginationParameters paginationParameters, string searchQuery = "");

	Task<IResult<InstaUserInfo>> GetUserInfoByIdAsync(long pk);

	Task<IResult<InstaUserInfo>> GetUserInfoByUsernameAsync(string username);

	Task<IResult<InstaMediaList>> GetUserMediaAsync(string username, PaginationParameters paginationParameters);

	Task<IResult<InstaMediaList>> GetUserMediaByIdAsync(long userId, PaginationParameters paginationParameters);

	Task<IResult<InstaMediaList>> GetUserShoppableMediaAsync(string username, PaginationParameters paginationParameters);

	Task<IResult<InstaMediaList>> GetUserTagsAsync(string username, PaginationParameters paginationParameters);

	Task<IResult<InstaMediaList>> GetUserTagsAsync(long userId, PaginationParameters paginationParameters);

	Task<IResult<InstaFriendshipFullStatus>> IgnoreFriendshipRequestAsync(long userId);

	Task<IResult<InstaStoryFriendshipStatus>> HideMyStoryFromUserAsync(long userId);

	Task<IResult<bool>> MarkUserAsOverageAsync(long userId);

	Task<IResult<InstaStoryFriendshipStatus>> MuteFriendStoryAsync(long userId);

	Task<IResult<InstaStoryFriendshipStatus>> MuteUserMediaAsync(long userId, InstaMuteOption muteOption);

	Task<IResult<bool>> ReportUserAsync(long userId);

	Task<IResult<InstaFriendshipFullStatus>> UnBlockUserAsync(long userId);

	Task<IResult<bool>> UnFavoriteUserAsync(long userId);

	Task<IResult<bool>> UnFavoriteUserStoriesAsync(long userId);

	Task<IResult<InstaFriendshipFullStatus>> UnFollowUserAsync(long userId);

	Task<IResult<InstaStoryFriendshipStatus>> UnHideMyStoryFromUserAsync(long userId);

	Task<IResult<InstaStoryFriendshipStatus>> UnMuteFriendStoryAsync(long userId);

	Task<IResult<InstaStoryFriendshipStatus>> UnMuteUserMediaAsync(long userId, InstaMuteOption unmuteOption);

	Task<IResult<InstaFriendshipStatus>> RemoveFollowerAsync(long userId);

	Task<IResult<string>> TranslateBiographyAsync(long userId);
}
