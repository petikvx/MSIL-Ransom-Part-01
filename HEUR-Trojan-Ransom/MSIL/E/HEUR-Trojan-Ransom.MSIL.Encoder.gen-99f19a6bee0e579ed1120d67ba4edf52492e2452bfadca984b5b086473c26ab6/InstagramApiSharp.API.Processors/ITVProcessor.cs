using System;
using System.Threading.Tasks;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Enums;

namespace InstagramApiSharp.API.Processors;

public interface ITVProcessor
{
	Task<IResult<InstaTVChannel>> GetChannelByIdAsync(long userId, PaginationParameters paginationParameters);

	Task<IResult<InstaTVChannel>> GetChannelByTypeAsync(InstaTVChannelType channelType, PaginationParameters paginationParameters);

	Task<IResult<InstaTVSearch>> GetSuggestedSearchesAsync();

	Task<IResult<InstaTV>> GetTVGuideAsync();

	Task<IResult<InstaTVSearch>> SearchAsync(string query);

	Task<IResult<InstaMedia>> UploadVideoAsync(InstaVideoUpload video, string title, string caption);

	Task<IResult<InstaMedia>> UploadVideoAsync(Action<InstaUploaderProgress> progress, InstaVideoUpload video, string title, string caption);
}
