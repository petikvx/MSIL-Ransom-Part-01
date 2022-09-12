using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Android.DeviceInfo;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers.Web;
using InstagramApiSharp.Converters;
using InstagramApiSharp.Enums;
using InstagramApiSharp.Helpers;
using InstagramApiSharp.Logger;
using Newtonsoft.Json;

namespace InstagramApiSharp.API.Processors;

internal class WebProcessor : IWebProcessor
{
	private readonly AndroidDevice _deviceInfo;

	private readonly HttpHelper _httpHelper;

	private readonly IHttpRequestProcessor _httpRequestProcessor;

	private readonly InstaApi _instaApi;

	private readonly IInstaLogger _logger;

	private readonly UserSessionData _user;

	private readonly UserAuthValidate _userAuthValidate;

	public WebProcessor(AndroidDevice deviceInfo, UserSessionData user, IHttpRequestProcessor httpRequestProcessor, IInstaLogger logger, UserAuthValidate userAuthValidate, InstaApi instaApi, HttpHelper httpHelper)
	{
		_deviceInfo = deviceInfo;
		_user = user;
		_httpRequestProcessor = httpRequestProcessor;
		_logger = logger;
		_userAuthValidate = userAuthValidate;
		_instaApi = instaApi;
		_httpHelper = httpHelper;
	}

	public async Task<IResult<InstaWebAccountInfo>> GetAccountInfoAsync()
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri accountsDataUri = WebUriCreator.GetAccountsDataUri();
			HttpRequestMessage webRequest = _httpHelper.GetWebRequest(HttpMethod.Get, accountsDataUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(webRequest);
			string html = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.Fail<InstaWebAccountInfo>($"Error! Status code: {response.StatusCode}", null);
			}
			string json = html.GetJson();
			if (json.IsEmpty())
			{
				return Result.Fail<InstaWebAccountInfo>("Json response isn't available.", null);
			}
			InstaWebContainerResponse instaWebContainerResponse = JsonConvert.DeserializeObject<InstaWebContainerResponse>(json);
			if (instaWebContainerResponse.Entry?.SettingsPages != null)
			{
				InstaWebSettingsPageResponse instaWebSettingsPageResponse = instaWebContainerResponse.Entry.SettingsPages.FirstOrDefault();
				if (instaWebSettingsPageResponse != null)
				{
					return Result.Success(ConvertersFabric.Instance.GetWebAccountInfoConverter(instaWebSettingsPageResponse).Convert());
				}
			}
			return Result.Fail<InstaWebAccountInfo>("Date joined isn't available.", null);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaWebAccountInfo>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaWebAccountInfo>(exception2, null);
		}
	}

	public async Task<IResult<InstaWebTextData>> GetFollowRequestsAsync(PaginationParameters paginationParameters)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		InstaWebTextData textDataList = new InstaWebTextData();
		try
		{
			if (paginationParameters == null)
			{
				paginationParameters = PaginationParameters.MaxPagesToLoad(1);
			}
			IResult<InstaWebSettingsPageResponse> result = await GetRequest(smethod_1(paginationParameters?.NextMaxId));
			if (!result.Succeeded)
			{
				if (result.Value != null)
				{
					return Result.Fail(result.Info, smethod_0(result.Value));
				}
				return Result.Fail(result.Info, textDataList);
			}
			InstaWebSettingsPageResponse response = result.Value;
			paginationParameters.NextMaxId = response.Data.Cursor;
			while (!string.IsNullOrEmpty(paginationParameters.NextMaxId) && paginationParameters.PagesLoaded < paginationParameters.MaximumPagesToLoad)
			{
				IResult<InstaWebSettingsPageResponse> result2 = await GetRequest(smethod_1(paginationParameters?.NextMaxId));
				if (result2.Succeeded)
				{
					InstaWebSettingsPageResponse value = result2.Value;
					if (value.Data != null)
					{
						response.Data.Data.AddRange(value.Data.Data);
					}
					string text3 = (response.Data.Cursor = (paginationParameters.NextMaxId = value.Data?.Cursor));
					paginationParameters.PagesLoaded++;
					continue;
				}
				return Result.Fail(result2.Info, smethod_0(response));
			}
			return Result.Success(smethod_0(response));
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail(exception, textDataList, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail(exception2, textDataList);
		}
	}

	public async Task<IResult<InstaWebData>> GetFormerBiographyLinksAsync(PaginationParameters paginationParameters)
	{
		return await GetFormerAsync(InstaWebType.FormerLinksInBio, paginationParameters);
	}

	public async Task<IResult<InstaWebData>> GetFormerBiographyTextsAsync(PaginationParameters paginationParameters)
	{
		return await GetFormerAsync(InstaWebType.FormerBioTexts, paginationParameters);
	}

	public async Task<IResult<InstaWebData>> GetFormerEmailsAsync(PaginationParameters paginationParameters)
	{
		return await GetFormerAsync(InstaWebType.FormerEmails, paginationParameters);
	}

	public async Task<IResult<InstaWebData>> GetFormerFullNamesAsync(PaginationParameters paginationParameters)
	{
		return await GetFormerAsync(InstaWebType.FormerFullNames, paginationParameters);
	}

	public async Task<IResult<InstaWebData>> GetFormerPhoneNumbersAsync(PaginationParameters paginationParameters)
	{
		return await GetFormerAsync(InstaWebType.FormerPhones, paginationParameters);
	}

	public async Task<IResult<InstaWebData>> GetFormerUsernamesAsync(PaginationParameters paginationParameters)
	{
		return await GetFormerAsync(InstaWebType.FormerUsernames, paginationParameters);
	}

	private async Task<IResult<InstaWebData>> GetFormerAsync(InstaWebType type, PaginationParameters paginationParameters)
	{
		_003C_003Ec__DisplayClass16_0 _003C_003Ec__DisplayClass16_0_ = default(_003C_003Ec__DisplayClass16_0);
		_003C_003Ec__DisplayClass16_0_.type = type;
		UserAuthValidator.Validate(_userAuthValidate);
		InstaWebData webData = new InstaWebData();
		try
		{
			if (paginationParameters == null)
			{
				paginationParameters = PaginationParameters.MaxPagesToLoad(1);
			}
			IResult<InstaWebSettingsPageResponse> result = await GetRequest(smethod_3(paginationParameters?.NextMaxId, ref _003C_003Ec__DisplayClass16_0_));
			if (!result.Succeeded)
			{
				if (result.Value != null)
				{
					return Result.Fail(result.Info, smethod_2(result.Value));
				}
				return Result.Fail(result.Info, webData);
			}
			InstaWebSettingsPageResponse response = result.Value;
			paginationParameters.NextMaxId = response.Data.Cursor;
			while (!string.IsNullOrEmpty(paginationParameters.NextMaxId) && paginationParameters.PagesLoaded < paginationParameters.MaximumPagesToLoad)
			{
				IResult<InstaWebSettingsPageResponse> result2 = await GetRequest(smethod_3(paginationParameters?.NextMaxId, ref _003C_003Ec__DisplayClass16_0_));
				if (result2.Succeeded)
				{
					InstaWebSettingsPageResponse value = result2.Value;
					if (value.Data != null)
					{
						response.Data.Data.AddRange(value.Data.Data);
					}
					string text3 = (response.Data.Cursor = (paginationParameters.NextMaxId = value.Data?.Cursor));
					paginationParameters.PagesLoaded++;
					continue;
				}
				return Result.Fail(result2.Info, smethod_2(response));
			}
			return Result.Success(smethod_2(response));
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail(exception, webData, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail(exception2, webData);
		}
	}

	private async Task<IResult<InstaWebSettingsPageResponse>> GetRequest(Uri instaUri)
	{
		try
		{
			HttpRequestMessage webRequest = _httpHelper.GetWebRequest(HttpMethod.Get, instaUri, _deviceInfo);
			webRequest.Headers.Add("upgrade-insecure-requests", "1");
			webRequest.Headers.Add("accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8");
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(webRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.Fail<InstaWebSettingsPageResponse>($"Error! Status code: {response.StatusCode}", null);
			}
			if (instaUri.ToString().ToLower().Contains("a=1&cursor="))
			{
				return Result.Success(JsonConvert.DeserializeObject<InstaWebSettingsPageResponse>(text));
			}
			string json = text.GetJson();
			if (json.IsEmpty())
			{
				return Result.Fail<InstaWebSettingsPageResponse>("Json response isn't available.", null);
			}
			InstaWebContainerResponse instaWebContainerResponse = JsonConvert.DeserializeObject<InstaWebContainerResponse>(json);
			if (instaWebContainerResponse.Entry?.SettingsPages != null)
			{
				InstaWebSettingsPageResponse instaWebSettingsPageResponse = instaWebContainerResponse.Entry.SettingsPages.FirstOrDefault();
				if (instaWebSettingsPageResponse != null)
				{
					return Result.Success(instaWebSettingsPageResponse);
				}
			}
			return Result.Fail<InstaWebSettingsPageResponse>("Data isn't available.", null);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaWebSettingsPageResponse>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaWebSettingsPageResponse>(exception2, null);
		}
	}

	[CompilerGenerated]
	internal static InstaWebTextData smethod_0(InstaWebSettingsPageResponse settingsPageResponse)
	{
		return ConvertersFabric.Instance.GetWebTextDataListConverter(settingsPageResponse).Convert();
	}

	[CompilerGenerated]
	internal static Uri smethod_1(string cursor)
	{
		return WebUriCreator.GetCurrentFollowRequestsUri(cursor);
	}

	[CompilerGenerated]
	internal static InstaWebData smethod_2(InstaWebSettingsPageResponse settingsPageResponse)
	{
		return ConvertersFabric.Instance.GetWebDataConverter(settingsPageResponse).Convert();
	}

	[CompilerGenerated]
	internal static Uri smethod_3(string cursor, ref _003C_003Ec__DisplayClass16_0 _003C_003Ec__DisplayClass16_0_0)
	{
		return _003C_003Ec__DisplayClass16_0_0.type switch
		{
			InstaWebType.FormerUsernames => WebUriCreator.GetFormerUsernamesUri(cursor), 
			InstaWebType.FormerEmails => WebUriCreator.GetFormerEmailsUri(cursor), 
			InstaWebType.FormerPhones => WebUriCreator.GetFormerPhoneNumbersUri(cursor), 
			InstaWebType.FormerFullNames => WebUriCreator.GetFormerFullNamesUri(cursor), 
			InstaWebType.FormerLinksInBio => WebUriCreator.GetFormerBiographyLinksUri(cursor), 
			InstaWebType.FormerBioTexts => WebUriCreator.GetFormerBiographyTextsUri(cursor), 
			_ => WebUriCreator.GetFormerBiographyLinksUri(cursor), 
		};
	}
}
