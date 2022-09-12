using System;
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

internal class CollectionProcessor : ICollectionProcessor
{
	private readonly AndroidDevice _deviceInfo;

	private readonly HttpHelper _httpHelper;

	private readonly IHttpRequestProcessor _httpRequestProcessor;

	private readonly InstaApi _instaApi;

	private readonly IInstaLogger _logger;

	private readonly UserSessionData _user;

	private readonly UserAuthValidate _userAuthValidate;

	public CollectionProcessor(AndroidDevice deviceInfo, UserSessionData user, IHttpRequestProcessor httpRequestProcessor, IInstaLogger logger, UserAuthValidate userAuthValidate, InstaApi instaApi, HttpHelper httpHelper)
	{
		_deviceInfo = deviceInfo;
		_user = user;
		_httpRequestProcessor = httpRequestProcessor;
		_logger = logger;
		_userAuthValidate = userAuthValidate;
		_instaApi = instaApi;
		_httpHelper = httpHelper;
	}

	public async Task<IResult<InstaCollectionItem>> AddItemsToCollectionAsync(long collectionId, params string[] mediaIds)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			if (mediaIds != null && mediaIds.Length < 1)
			{
				return Result.Fail<InstaCollectionItem>("Provide at least one media id to add to collection");
			}
			Uri editCollectionUri = UriCreator.GetEditCollectionUri(collectionId);
			JObject data = new JObject
			{
				{ "module_name", "feed_saved_add_to_collection" },
				{
					"added_media_ids",
					JsonConvert.SerializeObject(mediaIds)
				},
				{ "radio_type", "wifi-none" },
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{
					"_uid",
					_user.LoggedInUser.Pk
				},
				{ "_csrftoken", _user.CsrfToken }
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Get, editCollectionUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaCollectionItem>(response, text);
			}
			InstaCollectionItemResponse response2 = JsonConvert.DeserializeObject<InstaCollectionItemResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetCollectionConverter(response2).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaCollectionItem>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaCollectionItem>(exception2);
		}
	}

	public async Task<IResult<InstaCollectionItem>> CreateCollectionAsync(string collectionName)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri createCollectionUri = UriCreator.GetCreateCollectionUri();
			JObject data = new JObject
			{
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{
					"_uid",
					_user.LoggedInUser.Pk
				},
				{ "_csrftoken", _user.CsrfToken },
				{ "name", collectionName },
				{ "module_name", "/api/v1collection_create" }
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Get, createCollectionUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			InstaCollectionItemResponse response2 = JsonConvert.DeserializeObject<InstaCollectionItemResponse>(text);
			IObjectConverter<InstaCollectionItem, InstaCollectionItemResponse> collectionConverter = ConvertersFabric.Instance.GetCollectionConverter(response2);
			return (response.StatusCode != HttpStatusCode.OK) ? Result.UnExpectedResponse<InstaCollectionItem>(response, text) : Result.Success(collectionConverter.Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaCollectionItem>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaCollectionItem>(exception2);
		}
	}

	public async Task<IResult<bool>> DeleteCollectionAsync(long collectionId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri deleteCollectionUri = UriCreator.GetDeleteCollectionUri(collectionId);
			JObject data = new JObject
			{
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{
					"_uid",
					_user.LoggedInUser.Pk
				},
				{ "_csrftoken", _user.CsrfToken },
				{ "module_name", "collection_editor" }
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Get, deleteCollectionUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string json = await response.Content.ReadAsStringAsync();
			if (response.StatusCode == HttpStatusCode.OK)
			{
				return Result.Success(resValue: true);
			}
			return Result.UnExpectedResponse<bool>(response, json);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail(exception, resValue: false, ResponseType.NetworkProblem);
		}
		catch (Exception ex)
		{
			_logger?.LogException(ex);
			return Result.Fail(ex.Message, resValue: false);
		}
	}

	public async Task<IResult<InstaCollectionItem>> EditCollectionAsync(long collectionId, string name, string photoCoverMediaId = null)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			IResult<InstaCollectionItemResponse> result = await GetSingleCollection(collectionId, PaginationParameters.MaxPagesToLoad(1));
			if (result.Succeeded && string.IsNullOrEmpty(name))
			{
				name = result.Value.CollectionName;
			}
			Uri editCollectionUri = UriCreator.GetEditCollectionUri(collectionId);
			JObject jObject = new JObject
			{
				{
					"name",
					name ?? string.Empty
				},
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{
					"_uid",
					_user.LoggedInUser.Pk
				},
				{ "_csrftoken", _user.CsrfToken }
			};
			if (!string.IsNullOrEmpty(photoCoverMediaId))
			{
				jObject.Add("cover_media_id", photoCoverMediaId);
			}
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Get, editCollectionUri, _deviceInfo, jObject);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaCollectionItem>(response, text);
			}
			InstaCollectionItemResponse response2 = JsonConvert.DeserializeObject<InstaCollectionItemResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetCollectionConverter(response2).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaCollectionItem>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaCollectionItem>(exception2);
		}
	}

	public async Task<IResult<InstaCollectionItem>> GetSingleCollectionAsync(long collectionId, PaginationParameters paginationParameters)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			if (paginationParameters == null)
			{
				paginationParameters = PaginationParameters.MaxPagesToLoad(1);
			}
			IResult<InstaCollectionItemResponse> result = await GetSingleCollection(collectionId, paginationParameters);
			if (!result.Succeeded)
			{
				return Result.Fail<InstaCollectionItem>(result.Info, null);
			}
			InstaCollectionItemResponse collectionsListResponse = result.Value;
			paginationParameters.NextMaxId = collectionsListResponse.NextMaxId;
			int pagesLoaded = 1;
			while (collectionsListResponse.MoreAvailable && !string.IsNullOrEmpty(collectionsListResponse.NextMaxId) && pagesLoaded < paginationParameters.MaximumPagesToLoad)
			{
				IResult<InstaCollectionItemResponse> result2 = await GetSingleCollection(collectionId, paginationParameters);
				if (!result2.Succeeded)
				{
					return Result.Fail(result2.Info, smethod_0(result2.Value));
				}
				string text2 = (collectionsListResponse.NextMaxId = (paginationParameters.NextMaxId = result2.Value.NextMaxId));
				collectionsListResponse.MoreAvailable = result2.Value.MoreAvailable;
				collectionsListResponse.AutoLoadMoreEnabled = result2.Value.AutoLoadMoreEnabled;
				collectionsListResponse.Status = result2.Value.Status;
				collectionsListResponse.Media.Medias.AddRange(result2.Value.Media.Medias);
				pagesLoaded++;
			}
			return Result.Success(ConvertersFabric.Instance.GetCollectionConverter(collectionsListResponse).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaCollectionItem>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaCollectionItem>(exception2);
		}
	}

	public async Task<IResult<InstaCollections>> GetCollectionsAsync(PaginationParameters paginationParameters)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			if (paginationParameters == null)
			{
				paginationParameters = PaginationParameters.MaxPagesToLoad(1);
			}
			IResult<InstaCollectionsResponse> result = await GetCollections(paginationParameters);
			if (!result.Succeeded)
			{
				return Result.Fail<InstaCollections>(result.Info, null);
			}
			InstaCollectionsResponse collectionsResponse = result.Value;
			paginationParameters.NextMaxId = collectionsResponse.NextMaxId;
			int pagesLoaded = 1;
			while (collectionsResponse.MoreAvailable && !string.IsNullOrEmpty(collectionsResponse.NextMaxId) && pagesLoaded < paginationParameters.MaximumPagesToLoad)
			{
				IResult<InstaCollectionsResponse> result2 = await GetCollections(paginationParameters);
				if (!result2.Succeeded)
				{
					return Result.Fail(result2.Info, smethod_1(result2.Value));
				}
				string text2 = (collectionsResponse.NextMaxId = (paginationParameters.NextMaxId = result2.Value.NextMaxId));
				collectionsResponse.MoreAvailable = result2.Value.MoreAvailable;
				collectionsResponse.AutoLoadMoreEnabled = result2.Value.AutoLoadMoreEnabled;
				collectionsResponse.Status = result2.Value.Status;
				collectionsResponse.Items.AddRange(result2.Value.Items);
				pagesLoaded++;
			}
			return Result.Success(ConvertersFabric.Instance.GetCollectionsConverter(collectionsResponse).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaCollections>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaCollections>(exception2);
		}
	}

	private async Task<IResult<InstaCollectionsResponse>> GetCollections(PaginationParameters paginationParameters)
	{
		try
		{
			Uri collectionsUri = UriCreator.GetCollectionsUri(paginationParameters?.NextMaxId);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, collectionsUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaCollectionsResponse>(response, text);
			}
			return Result.Success(JsonConvert.DeserializeObject<InstaCollectionsResponse>(text));
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaCollectionsResponse>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaCollectionsResponse>(exception2);
		}
	}

	private async Task<IResult<InstaCollectionItemResponse>> GetSingleCollection(long collectionId, PaginationParameters paginationParameters)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri collectionUri = UriCreator.GetCollectionUri(collectionId, paginationParameters?.NextMaxId);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, collectionUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaCollectionItemResponse>(response, text);
			}
			return Result.Success(JsonConvert.DeserializeObject<InstaCollectionItemResponse>(text, new JsonConverter[1]
			{
				new InstaCollectionDataConverter()
			}));
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaCollectionItemResponse>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaCollectionItemResponse>(exception2);
		}
	}

	[CompilerGenerated]
	internal static InstaCollectionItem smethod_0(InstaCollectionItemResponse instaCollectionItemResponse)
	{
		return ConvertersFabric.Instance.GetCollectionConverter(instaCollectionItemResponse).Convert();
	}

	[CompilerGenerated]
	internal static InstaCollections smethod_1(InstaCollectionsResponse instaCollectionsResponse)
	{
		return ConvertersFabric.Instance.GetCollectionsConverter(instaCollectionsResponse).Convert();
	}
}
