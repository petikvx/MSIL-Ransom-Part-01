using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Android.DeviceInfo;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;
using InstagramApiSharp.Converters;
using InstagramApiSharp.Converters.Json;
using InstagramApiSharp.Helpers;
using InstagramApiSharp.Logger;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InstagramApiSharp.API.Processors;

internal class ShoppingProcessor : IShoppingProcessor
{
	private readonly AndroidDevice _deviceInfo;

	private readonly IHttpRequestProcessor _httpRequestProcessor;

	private readonly IInstaLogger _logger;

	private readonly UserSessionData _user;

	private readonly UserAuthValidate _userAuthValidate;

	private readonly InstaApi _instaApi;

	private readonly HttpHelper _httpHelper;

	public ShoppingProcessor(AndroidDevice deviceInfo, UserSessionData user, IHttpRequestProcessor httpRequestProcessor, IInstaLogger logger, UserAuthValidate userAuthValidate, InstaApi instaApi, HttpHelper httpHelper)
	{
		_deviceInfo = deviceInfo;
		_user = user;
		_httpRequestProcessor = httpRequestProcessor;
		_logger = logger;
		_userAuthValidate = userAuthValidate;
		_instaApi = instaApi;
		_httpHelper = httpHelper;
	}

	public async Task<IResult<InstaMediaList>> GetUserShoppableMediaAsync(string username, PaginationParameters paginationParameters)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		IResult<InstaUser> result = await _instaApi.UserProcessor.GetUserAsync(username);
		if (!result.Succeeded)
		{
			return Result.Fail<InstaMediaList>("Unable to get user to load shoppable media");
		}
		return await GetUserShoppableMedia(result.Value.Pk, paginationParameters);
	}

	public async Task<IResult<InstaMediaList>> GetUserShoppableMediaByIdAsync(long userId, PaginationParameters paginationParameters)
	{
		return await GetUserShoppableMedia(userId, paginationParameters);
	}

	public async Task<IResult<InstaProductInfo>> GetProductInfoAsync(long productId, string mediaPk, int deviceWidth = 720)
	{
		try
		{
			Uri productInfoUri = UriCreator.GetProductInfoUri(productId, mediaPk, deviceWidth);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, productInfoUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaProductInfo>(response, text);
			}
			InstaProductInfoResponse response2 = JsonConvert.DeserializeObject<InstaProductInfoResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetProductInfoConverter(response2).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaProductInfo>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaProductInfo>(exception2);
		}
	}

	public async Task<IResult<InstaProductInfo>> GetCatalogsAsync()
	{
		try
		{
			Uri uri = new Uri("https://i.instagram.com/api/v1/wwwgraphql/ig/query/?locale=" + InstaApiConstants.ACCEPT_LANGUAGE.Replace("-", "_"));
			JObject jObject = new JObject { { "sources", null } };
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary.Add("access_token", "undefined");
			dictionary.Add("fb_api_caller_class", "RelayModern");
			dictionary.Add("variables", jObject.ToString(Formatting.Indented));
			dictionary.Add("doc_id", "1742970149122229");
			Dictionary<string, string> data = dictionary;
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, uri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaProductInfo>(response, text);
			}
			InstaProductInfoResponse response2 = JsonConvert.DeserializeObject<InstaProductInfoResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetProductInfoConverter(response2).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaProductInfo>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaProductInfo>(exception2);
		}
	}

	private async Task<IResult<InstaMediaList>> GetUserShoppableMedia(long userId, PaginationParameters paginationParameters)
	{
		InstaMediaList mediaList = new InstaMediaList();
		try
		{
			if (paginationParameters == null)
			{
				paginationParameters = PaginationParameters.MaxPagesToLoad(1);
			}
			IResult<InstaMediaListResponse> result = await GetShoppableMedia(userId, paginationParameters);
			if (!result.Succeeded)
			{
				if (result.Value != null)
				{
					return Result.Fail(result.Info, smethod_0(result.Value));
				}
				return Result.Fail(result.Info, mediaList);
			}
			InstaMediaListResponse mediaResponse = result.Value;
			mediaList = ConvertersFabric.Instance.GetMediaListConverter(mediaResponse).Convert();
			string text2 = (mediaList.NextMaxId = (paginationParameters.NextMaxId = mediaResponse.NextMaxId));
			paginationParameters.PagesLoaded++;
			while (mediaResponse.MoreAvailable && !string.IsNullOrEmpty(paginationParameters.NextMaxId) && paginationParameters.PagesLoaded < paginationParameters.MaximumPagesToLoad)
			{
				IResult<InstaMediaListResponse> result2 = await GetShoppableMedia(userId, paginationParameters);
				if (!result2.Succeeded)
				{
					return Result.Fail(result2.Info, mediaList);
				}
				text2 = (mediaList.NextMaxId = (paginationParameters.NextMaxId = result2.Value.NextMaxId));
				mediaList.AddRange(smethod_0(result2.Value));
				mediaResponse.MoreAvailable = result2.Value.MoreAvailable;
				mediaResponse.ResultsCount += result2.Value.ResultsCount;
				paginationParameters.PagesLoaded++;
			}
			mediaList.Pages = paginationParameters.PagesLoaded;
			mediaList.PageSize = mediaResponse.ResultsCount;
			return Result.Success(mediaList);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaMediaList>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail(exception2, mediaList);
		}
	}

	private async Task<IResult<InstaMediaListResponse>> GetShoppableMedia(long userId, PaginationParameters paginationParameters)
	{
		try
		{
			Uri userShoppableMediaListUri = UriCreator.GetUserShoppableMediaListUri(userId, paginationParameters.NextMaxId);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, userShoppableMediaListUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaMediaListResponse>(response, text);
			}
			return Result.Success(JsonConvert.DeserializeObject<InstaMediaListResponse>(text, new JsonConverter[1]
			{
				new InstaMediaListDataConverter()
			}));
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaMediaListResponse>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaMediaListResponse>(exception2, null);
		}
	}

	[CompilerGenerated]
	internal static InstaMediaList smethod_0(InstaMediaListResponse mediaListResponse)
	{
		return ConvertersFabric.Instance.GetMediaListConverter(mediaListResponse).Convert();
	}
}
