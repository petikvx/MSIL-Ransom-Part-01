using System.Threading.Tasks;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Models;

namespace InstagramApiSharp.API.Processors;

public interface IShoppingProcessor
{
	Task<IResult<InstaMediaList>> GetUserShoppableMediaAsync(string username, PaginationParameters paginationParameters);

	Task<IResult<InstaMediaList>> GetUserShoppableMediaByIdAsync(long userId, PaginationParameters paginationParameters);

	Task<IResult<InstaProductInfo>> GetProductInfoAsync(long productId, string mediaPk, int deviceWidth = 720);
}
