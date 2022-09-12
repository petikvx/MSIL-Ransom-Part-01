using System;
using System.Threading.Tasks;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Models;

namespace InstagramApiSharp.API.Processors;

public interface IMediaProcessor
{
	Task<IResult<bool>> ArchiveMediaAsync(string mediaId);

	Task<IResult<bool>> DeleteMediaAsync(string mediaId, InstaMediaType mediaType);

	Task<IResult<InstaMedia>> EditMediaAsync(string mediaId, string caption, InstaLocationShort location = null, InstaUserTagUpload[] userTags = null);

	Task<IResult<InstaMediaList>> GetArchivedMediaAsync(PaginationParameters paginationParameters);

	Task<IResult<InstaMediaIdList>> GetBlockedMediasAsync();

	Task<IResult<InstaMediaList>> GetMediaByIdsAsync(params string[] mediaIds);

	Task<IResult<InstaMedia>> GetMediaByIdAsync(string mediaId);

	Task<IResult<string>> GetMediaIdFromUrlAsync(Uri uri);

	Task<IResult<InstaLikersList>> GetMediaLikersAsync(string mediaId);

	Task<IResult<Uri>> GetShareLinkFromMediaIdAsync(string mediaId);

	Task<IResult<bool>> LikeMediaAsync(string mediaId);

	Task<IResult<bool>> ReportMediaAsync(string mediaId);

	Task<IResult<bool>> SaveMediaAsync(string mediaId);

	Task<IResult<bool>> UnArchiveMediaAsync(string mediaId);

	Task<IResult<bool>> UnLikeMediaAsync(string mediaId);

	Task<IResult<bool>> UnSaveMediaAsync(string mediaId);

	Task<IResult<InstaMedia>> UploadAlbumAsync(InstaImageUpload[] images, InstaVideoUpload[] videos, string caption, InstaLocationShort location = null);

	Task<IResult<InstaMedia>> UploadAlbumAsync(Action<InstaUploaderProgress> progress, InstaImageUpload[] images, InstaVideoUpload[] videos, string caption, InstaLocationShort location = null);

	Task<IResult<InstaMedia>> UploadAlbumAsync(InstaAlbumUpload[] album, string caption, InstaLocationShort location = null);

	Task<IResult<InstaMedia>> UploadAlbumAsync(Action<InstaUploaderProgress> progress, InstaAlbumUpload[] album, string caption, InstaLocationShort location = null);

	Task<IResult<InstaMedia>> UploadPhotoAsync(InstaImageUpload image, string caption, InstaLocationShort location = null);

	Task<IResult<InstaMedia>> UploadPhotoAsync(Action<InstaUploaderProgress> progress, InstaImageUpload image, string caption, InstaLocationShort location = null);

	Task<IResult<InstaMedia>> UploadVideoAsync(InstaVideoUpload video, string caption, InstaLocationShort location = null);

	Task<IResult<InstaMedia>> UploadVideoAsync(Action<InstaUploaderProgress> progress, InstaVideoUpload video, string caption, InstaLocationShort location = null);
}
