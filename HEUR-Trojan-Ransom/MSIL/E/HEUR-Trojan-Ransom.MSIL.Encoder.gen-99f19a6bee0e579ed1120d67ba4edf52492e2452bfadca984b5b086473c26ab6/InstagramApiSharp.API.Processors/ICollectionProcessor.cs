using System.Threading.Tasks;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Models;

namespace InstagramApiSharp.API.Processors;

public interface ICollectionProcessor
{
	Task<IResult<InstaCollectionItem>> AddItemsToCollectionAsync(long collectionId, params string[] mediaIds);

	Task<IResult<InstaCollectionItem>> CreateCollectionAsync(string collectionName);

	Task<IResult<bool>> DeleteCollectionAsync(long collectionId);

	Task<IResult<InstaCollectionItem>> EditCollectionAsync(long collectionId, string name, string photoCoverMediaId = null);

	Task<IResult<InstaCollectionItem>> GetSingleCollectionAsync(long collectionId, PaginationParameters paginationParameters);

	Task<IResult<InstaCollections>> GetCollectionsAsync(PaginationParameters paginationParameters);
}
