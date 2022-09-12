using System.Threading.Tasks;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Models;

namespace InstagramApiSharp.API.Processors;

public interface IWebProcessor
{
	Task<IResult<InstaWebAccountInfo>> GetAccountInfoAsync();

	Task<IResult<InstaWebTextData>> GetFollowRequestsAsync(PaginationParameters paginationParameters);

	Task<IResult<InstaWebData>> GetFormerBiographyLinksAsync(PaginationParameters paginationParameters);

	Task<IResult<InstaWebData>> GetFormerBiographyTextsAsync(PaginationParameters paginationParameters);

	Task<IResult<InstaWebData>> GetFormerEmailsAsync(PaginationParameters paginationParameters);

	Task<IResult<InstaWebData>> GetFormerFullNamesAsync(PaginationParameters paginationParameters);

	Task<IResult<InstaWebData>> GetFormerPhoneNumbersAsync(PaginationParameters paginationParameters);

	Task<IResult<InstaWebData>> GetFormerUsernamesAsync(PaginationParameters paginationParameters);
}
