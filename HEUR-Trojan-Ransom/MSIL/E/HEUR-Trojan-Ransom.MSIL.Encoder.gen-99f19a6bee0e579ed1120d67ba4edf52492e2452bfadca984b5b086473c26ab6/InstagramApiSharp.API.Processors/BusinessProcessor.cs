using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Android.DeviceInfo;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.Models.Business;
using InstagramApiSharp.Classes.ResponseWrappers;
using InstagramApiSharp.Classes.ResponseWrappers.Business;
using InstagramApiSharp.Converters;
using InstagramApiSharp.Converters.Json;
using InstagramApiSharp.Enums;
using InstagramApiSharp.Helpers;
using InstagramApiSharp.Logger;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InstagramApiSharp.API.Processors;

internal class BusinessProcessor : IBusinessProcessor
{
	private readonly AndroidDevice _deviceInfo;

	private readonly HttpHelper _httpHelper;

	private readonly IHttpRequestProcessor _httpRequestProcessor;

	private readonly InstaApi _instaApi;

	private readonly IInstaLogger _logger;

	private readonly UserSessionData _user;

	private readonly UserAuthValidate _userAuthValidate;

	public BusinessProcessor(AndroidDevice deviceInfo, UserSessionData user, IHttpRequestProcessor httpRequestProcessor, IInstaLogger logger, UserAuthValidate userAuthValidate, InstaApi instaApi, HttpHelper httpHelper)
	{
		_deviceInfo = deviceInfo;
		_user = user;
		_httpRequestProcessor = httpRequestProcessor;
		_logger = logger;
		_userAuthValidate = userAuthValidate;
		_instaApi = instaApi;
		_httpHelper = httpHelper;
	}

	public async Task<IResult<InstaBusinessUser>> AddOrChangeBusinessButtonAsync(InstaBusinessPartner businessPartner, Uri uri)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			if (businessPartner == null)
			{
				return Result.Fail<InstaBusinessUser>("Business partner cannot be null");
			}
			if (uri == null)
			{
				return Result.Fail<InstaBusinessUser>("Uri related to business partner cannot be null");
			}
			IResult<bool> result = await ValidateUrlAsync(businessPartner, uri);
			if (!result.Succeeded)
			{
				return Result.Fail<InstaBusinessUser>(result.Info.Message);
			}
			Uri updateBusinessInfoUri = UriCreator.GetUpdateBusinessInfoUri();
			JObject data = new JObject
			{
				{
					"ix_url",
					uri.ToString()
				},
				{ "ix_app_id", businessPartner.AppId },
				{ "is_call_to_action_enabled", "1" },
				{ "_csrftoken", _user.CsrfToken },
				{
					"_uid",
					_user.LoggedInUser.Pk.ToString()
				},
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				}
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, updateBusinessInfoUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaBusinessUser>(response, text);
			}
			InstaBusinessUserContainerResponse response2 = JsonConvert.DeserializeObject<InstaBusinessUserContainerResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetBusinessUserConverter(response2).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaBusinessUser>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaBusinessUser>(exception2);
		}
	}

	public async Task<IResult<InstaBrandedContent>> AddUserToBrandedWhiteListAsync(params long[] userIdsToAdd)
	{
		if (userIdsToAdd == null || (userIdsToAdd != null && !userIdsToAdd.Any()))
		{
			return Result.Fail<InstaBrandedContent>("At least one user id is require.");
		}
		return await UpdateBrandedContent(null, userIdsToAdd);
	}

	public async Task<IResult<InstaBrandedContent>> DisbaleBrandedContentApprovalAsync()
	{
		return await UpdateBrandedContent(0);
	}

	public async Task<IResult<InstaBrandedContent>> EnableBrandedContentApprovalAsync()
	{
		return await UpdateBrandedContent(1);
	}

	public async Task<IResult<InstaBusinessUser>> ChangeBusinessCategoryAsync(string subCategoryId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			if (string.IsNullOrEmpty(subCategoryId))
			{
				return Result.Fail<InstaBusinessUser>("Sub category id cannot be null or empty");
			}
			Uri setBusinessCategoryUri = UriCreator.GetSetBusinessCategoryUri();
			JObject data = new JObject
			{
				{ "_csrftoken", _user.CsrfToken },
				{
					"_uid",
					_user.LoggedInUser.Pk.ToString()
				},
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{ "category_id", subCategoryId }
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, setBusinessCategoryUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaBusinessUser>(response, text);
			}
			InstaBusinessUserContainerResponse response2 = JsonConvert.DeserializeObject<InstaBusinessUserContainerResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetBusinessUserConverter(response2).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaBusinessUser>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaBusinessUser>(exception2);
		}
	}

	public async Task<IResult<InstaAccountDetails>> GetAccountDetailsAsync(long userId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri accountDetailsUri = UriCreator.GetAccountDetailsUri(userId);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, accountDetailsUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaAccountDetails>(response, "Can't find account details for this user pk", text);
			}
			InstaAccountDetailsResponse response2 = JsonConvert.DeserializeObject<InstaAccountDetailsResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetAccountDetailsConverter(response2).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaAccountDetails>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaAccountDetails>(exception2);
		}
	}

	public async Task<IResult<InstaUserInfo>> GetBusinessAccountInformationAsync()
	{
		return await _instaApi.UserProcessor.GetUserInfoByIdAsync(_user.LoggedInUser.Pk);
	}

	public async Task<IResult<InstaBusinessPartnersList>> GetBusinessPartnersButtonsAsync()
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			JObject data = new JObject();
			Uri businessInstantExperienceUri = UriCreator.GetBusinessInstantExperienceUri(_httpHelper.GetSignature(data));
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, businessInstantExperienceUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaBusinessPartnersList>(response, text);
			}
			InstaBusinessPartnerContainer instaBusinessPartnerContainer = JsonConvert.DeserializeObject<InstaBusinessPartnerContainer>(text);
			InstaBusinessPartnersList instaBusinessPartnersList = new InstaBusinessPartnersList();
			InstaBusinessPartner[] partners = instaBusinessPartnerContainer.Partners;
			foreach (InstaBusinessPartner item in partners)
			{
				instaBusinessPartnersList.Add(item);
			}
			return Result.Success(instaBusinessPartnersList);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaBusinessPartnersList>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaBusinessPartnersList>(exception2);
		}
	}

	public async Task<IResult<InstaBusinessCategoryList>> GetCategoriesAsync()
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri businessGraphQLUri = UriCreator.GetBusinessGraphQLUri();
			JObject jObject = new JObject { { "0", "-1" } };
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary.Add("query_id", "425892567746558");
			dictionary.Add("locale", InstaApiConstants.ACCEPT_LANGUAGE.Replace("-", "_"));
			dictionary.Add("vc_policy", "ads_viewer_context_policy");
			dictionary.Add("signed_body", _httpHelper._apiVersion.SignatureKey + ".");
			dictionary.Add("ig_sig_key_version", "4");
			dictionary.Add("strip_nulls", "true");
			dictionary.Add("strip_defaults", "true");
			dictionary.Add("query_params", jObject.ToString(Formatting.None));
			Dictionary<string, string> data = dictionary;
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, businessGraphQLUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaBusinessCategoryList>(response, text);
			}
			return Result.Success(JsonConvert.DeserializeObject<InstaBusinessCategoryList>(text, new JsonConverter[1]
			{
				new InstaBusinessCategoryDataConverter()
			}));
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaBusinessCategoryList>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaBusinessCategoryList>(exception2);
		}
	}

	public async Task<IResult<InstaFullMediaInsights>> GetFullMediaInsightsAsync(string mediaId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri graphStatisticsUri = UriCreator.GetGraphStatisticsUri(InstaApiConstants.ACCEPT_LANGUAGE, InstaInsightSurfaceType.Post);
			JObject value = new JObject
			{
				{ "access_token", "" },
				{ "id", mediaId }
			};
			JObject jObject = new JObject { { "query_params", value } };
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary.Add("access_token", "undefined");
			dictionary.Add("fb_api_caller_class", "RelayModern");
			dictionary.Add("variables", jObject.ToString(Formatting.None));
			dictionary.Add("doc_id", "1527362987318283");
			Dictionary<string, string> data = dictionary;
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, graphStatisticsUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaFullMediaInsights>(response, text);
			}
			InstaFullMediaInsightsRootResponse instaFullMediaInsightsRootResponse = JsonConvert.DeserializeObject<InstaFullMediaInsightsRootResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetFullMediaInsightsConverter(instaFullMediaInsightsRootResponse.Data.Media).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaFullMediaInsights>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaFullMediaInsights>(exception2);
		}
	}

	public async Task<IResult<InstaMediaInsights>> GetMediaInsightsAsync(string mediaPk)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri mediaSingleInsightsUri = UriCreator.GetMediaSingleInsightsUri(mediaPk);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, mediaSingleInsightsUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaMediaInsights>(response, text);
			}
			return Result.Success(JsonConvert.DeserializeObject<InstaMediaInsightsContainer>(text).MediaOrganicInsights);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaMediaInsights>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaMediaInsights>(exception2);
		}
	}

	public async Task<IResult<InstaMediaList>> GetPromotableMediaFeedsAsync()
	{
		InstaMediaList mediaList = new InstaMediaList();
		try
		{
			Uri promotableMediaFeedsUri = UriCreator.GetPromotableMediaFeedsUri();
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, promotableMediaFeedsUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaMediaList>(response, text);
			}
			InstaMediaListResponse instaMediaListResponse = JsonConvert.DeserializeObject<InstaMediaListResponse>(text, new JsonConverter[1]
			{
				new InstaMediaListDataConverter()
			});
			mediaList = ConvertersFabric.Instance.GetMediaListConverter(instaMediaListResponse).Convert();
			mediaList.PageSize = instaMediaListResponse.ResultsCount;
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

	public async Task<IResult<InstaStatistics>> GetStatisticsAsync()
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri graphStatisticsUri = UriCreator.GetGraphStatisticsUri(InstaApiConstants.ACCEPT_LANGUAGE);
			JObject value = new JObject
			{
				{ "access_token", "" },
				{
					"id",
					_user.LoggedInUser.Pk.ToString()
				}
			};
			JObject jObject = new JObject
			{
				{ "query_params", value },
				{
					"timezone",
					InstaApiConstants.TIMEZONE
				},
				{ "activityTab", true },
				{ "audienceTab", true },
				{ "contentTab", true }
			};
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary.Add("access_token", "undefined");
			dictionary.Add("fb_api_caller_class", "RelayModern");
			dictionary.Add("variables", jObject.ToString(Formatting.None));
			dictionary.Add("doc_id", "1926322010754880");
			Dictionary<string, string> data = dictionary;
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, graphStatisticsUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaStatistics>(response, text);
			}
			InstaStatisticsRootResponse response2 = JsonConvert.DeserializeObject<InstaStatisticsRootResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetStatisticsConverter(response2).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaStatistics>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaStatistics>(exception2);
		}
	}

	public async Task<IResult<bool>> StarDirectThreadAsync(string threadId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri starThreadUri = UriCreator.GetStarThreadUri(threadId);
			Dictionary<string, string> data = new Dictionary<string, string>
			{
				{ "thread_label", "1" },
				{ "_csrftoken", _user.CsrfToken },
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				}
			};
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, starThreadUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<bool>(response, text);
			}
			return (JsonConvert.DeserializeObject<InstaDefault>(text).Status.ToLower() == "ok") ? Result.Success(resValue: true) : Result.UnExpectedResponse<bool>(response, text);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail(exception, resValue: false, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<bool>(exception2);
		}
	}

	public async Task<IResult<bool>> UnStarDirectThreadAsync(string threadId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri unStarThreadUri = UriCreator.GetUnStarThreadUri(threadId);
			Dictionary<string, string> data = new Dictionary<string, string>
			{
				{ "_csrftoken", _user.CsrfToken },
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				}
			};
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, unStarThreadUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<bool>(response, text);
			}
			return (JsonConvert.DeserializeObject<InstaDefault>(text).Status.ToLower() == "ok") ? Result.Success(resValue: true) : Result.UnExpectedResponse<bool>(response, text);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail(exception, resValue: false, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<bool>(exception2);
		}
	}

	public async Task<IResult<InstaBusinessCategoryList>> GetSubCategoriesAsync(string categoryId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			if (string.IsNullOrEmpty(categoryId))
			{
				return Result.Fail<InstaBusinessCategoryList>("Category id cannot be null or empty");
			}
			Uri businessGraphQLUri = UriCreator.GetBusinessGraphQLUri();
			JObject jObject = new JObject { { "0", categoryId } };
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary.Add("query_id", "425892567746558");
			dictionary.Add("locale", InstaApiConstants.ACCEPT_LANGUAGE.Replace("-", "_"));
			dictionary.Add("vc_policy", "ads_viewer_context_policy");
			dictionary.Add("signed_body", _httpHelper._apiVersion.SignatureKey + ".");
			dictionary.Add("ig_sig_key_version", "4");
			dictionary.Add("strip_nulls", "true");
			dictionary.Add("strip_defaults", "true");
			dictionary.Add("query_params", jObject.ToString(Formatting.None));
			Dictionary<string, string> data = dictionary;
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, businessGraphQLUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaBusinessCategoryList>(response, text);
			}
			return Result.Success(JsonConvert.DeserializeObject<InstaBusinessCategoryList>(text, new JsonConverter[1]
			{
				new InstaBusinessCategoryDataConverter()
			}));
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaBusinessCategoryList>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaBusinessCategoryList>(exception2);
		}
	}

	public async Task<IResult<InstaBusinessSuggestedCategoryList>> GetSuggestedCategoriesAsync()
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri businessGraphQLUri = UriCreator.GetBusinessGraphQLUri();
			JObject value = new JObject
			{
				{
					"page_name",
					_user.UserName.ToLower()
				},
				{ "num_result", "5" }
			};
			JObject jObject = new JObject { { "0", value } };
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary.Add("query_id", "706774002864790");
			dictionary.Add("locale", InstaApiConstants.ACCEPT_LANGUAGE.Replace("-", "_"));
			dictionary.Add("vc_policy", "ads_viewer_context_policy");
			dictionary.Add("signed_body", _httpHelper._apiVersion.SignatureKey + ".");
			dictionary.Add("ig_sig_key_version", "4");
			dictionary.Add("strip_nulls", "true");
			dictionary.Add("strip_defaults", "true");
			dictionary.Add("query_params", jObject.ToString(Formatting.None));
			Dictionary<string, string> data = dictionary;
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, businessGraphQLUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaBusinessSuggestedCategoryList>(response, text);
			}
			return Result.Success(JsonConvert.DeserializeObject<InstaBusinessSuggestedCategoryList>(text, new JsonConverter[1]
			{
				new InstaBusinessSuggestedCategoryDataConverter()
			}));
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaBusinessSuggestedCategoryList>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaBusinessSuggestedCategoryList>(exception2);
		}
	}

	public async Task<IResult<InstaBrandedContent>> GetBrandedContentApprovalAsync()
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri businessBrandedSettingsUri = UriCreator.GetBusinessBrandedSettingsUri();
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, businessBrandedSettingsUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaBrandedContent>(response, text);
			}
			InstaBrandedContentResponse response2 = JsonConvert.DeserializeObject<InstaBrandedContentResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetBrandedContentConverter(response2).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaBrandedContent>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaBrandedContent>(exception2);
		}
	}

	public async Task<IResult<InstaBusinessUser>> RemoveBusinessButtonAsync()
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri updateBusinessInfoUri = UriCreator.GetUpdateBusinessInfoUri();
			JObject data = new JObject
			{
				{ "is_call_to_action_enabled", "0" },
				{ "_csrftoken", _user.CsrfToken },
				{
					"_uid",
					_user.LoggedInUser.Pk.ToString()
				},
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				}
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, updateBusinessInfoUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaBusinessUser>(response, text);
			}
			InstaBusinessUserContainerResponse response2 = JsonConvert.DeserializeObject<InstaBusinessUserContainerResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetBusinessUserConverter(response2).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaBusinessUser>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaBusinessUser>(exception2);
		}
	}

	public async Task<IResult<InstaBusinessUser>> RemoveBusinessLocationAsync()
	{
		return await UpdateBusinessInfoAsync(null, null, null, null, null);
	}

	public async Task<IResult<InstaBrandedContent>> RemoveUserFromBrandedWhiteListAsync(params long[] userIdsToRemove)
	{
		if (userIdsToRemove == null || (userIdsToRemove != null && !userIdsToRemove.Any()))
		{
			return Result.Fail<InstaBrandedContent>("At least one user id is require.");
		}
		return await UpdateBrandedContent(null, null, userIdsToRemove);
	}

	public async Task<IResult<InstaBusinessCityLocationList>> SearchCityLocationAsync(string cityOrTown)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			if (string.IsNullOrEmpty(cityOrTown))
			{
				return Result.Fail<InstaBusinessCityLocationList>("CityOrTown cannot be null or empty");
			}
			Uri businessGraphQLUri = UriCreator.GetBusinessGraphQLUri();
			JObject jObject = new JObject { { "0", cityOrTown } };
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary.Add("query_id", "1860980127555904");
			dictionary.Add("locale", InstaApiConstants.ACCEPT_LANGUAGE.Replace("-", "_"));
			dictionary.Add("vc_policy", "ads_viewer_context_policy");
			dictionary.Add("signed_body", _httpHelper._apiVersion.SignatureKey + ".");
			dictionary.Add("ig_sig_key_version", "4");
			dictionary.Add("strip_nulls", "true");
			dictionary.Add("strip_defaults", "true");
			dictionary.Add("query_params", jObject.ToString(Formatting.None));
			Dictionary<string, string> data = dictionary;
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, businessGraphQLUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaBusinessCityLocationList>(response, text);
			}
			return Result.Success(JsonConvert.DeserializeObject<InstaBusinessCityLocationList>(text, new JsonConverter[1]
			{
				new InstaBusinessCityLocationDataConverter()
			}));
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaBusinessCityLocationList>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaBusinessCityLocationList>(exception2);
		}
	}

	public async Task<IResult<InstaDiscoverSearchResult>> SearchBrandedUsersAsync(string query, int count = 85)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			if (count < 10)
			{
				count = 10;
			}
			Uri businessBrandedSearchUserUri = UriCreator.GetBusinessBrandedSearchUserUri(query, count);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, businessBrandedSearchUserUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaDiscoverSearchResult>(response, text);
			}
			InstaDiscoverSearchResultResponse response2 = JsonConvert.DeserializeObject<InstaDiscoverSearchResultResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetDiscoverSearchResultConverter(response2).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaDiscoverSearchResult>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaDiscoverSearchResult>(exception2);
		}
	}

	public async Task<IResult<InstaBusinessUser>> UpdateBusinessInfoAsync(string phoneNumberWithCountryCode, InstaBusinessCityLocation cityLocation, string streetAddress, string zipCode, InstaBusinessContactType? businessContactType)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			IResult<InstaUserInfo> result = await GetBusinessAccountInformationAsync();
			if (!result.Succeeded)
			{
				return Result.Fail<InstaBusinessUser>("Cannot get current business information");
			}
			InstaUserInfo value = result.Value;
			if (!value.IsBusiness)
			{
				return Result.Fail<InstaBusinessUser>("'" + value.Username + "' is not a business account");
			}
			Uri updateBusinessInfoUri = UriCreator.GetUpdateBusinessInfoUri();
			if (phoneNumberWithCountryCode == null)
			{
				phoneNumberWithCountryCode = value.PublicPhoneCountryCode + value.PublicPhoneNumber;
			}
			if (!businessContactType.HasValue)
			{
				businessContactType = value.BusinessContactMethod;
			}
			JObject jObject = new JObject
			{
				{ "public_phone_number", phoneNumberWithCountryCode },
				{
					"business_contact_method",
					businessContactType.ToString()!.ToUpper()
				}
			};
			string text = "0";
			if (cityLocation != null)
			{
				text = cityLocation.Id;
			}
			JObject jObject2 = new JObject
			{
				{
					"address_street",
					streetAddress ?? string.Empty
				},
				{ "city_id", text },
				{
					"zip",
					zipCode ?? string.Empty
				}
			};
			JObject jObject3 = new JObject();
			jObject3.Add("page_id", value.PageId.Value.ToString());
			jObject3.Add("_csrftoken", _user.CsrfToken);
			jObject3.Add("public_phone_contact", jObject.ToString(Formatting.None));
			jObject3.Add("_uid", _user.LoggedInUser.Pk.ToString());
			jObject3.Add("_uuid", _deviceInfo.DeviceGuid.ToString());
			jObject3.Add("public_email", value.PublicEmail ?? string.Empty);
			jObject3.Add("business_address", jObject2.ToString(Formatting.None));
			JObject data = jObject3;
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, updateBusinessInfoUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text2 = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaBusinessUser>(response, text2);
			}
			InstaBusinessUserContainerResponse response2 = JsonConvert.DeserializeObject<InstaBusinessUserContainerResponse>(text2);
			return Result.Success(ConvertersFabric.Instance.GetBusinessUserConverter(response2).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaBusinessUser>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaBusinessUser>(exception2);
		}
	}

	public async Task<IResult<bool>> ValidateUrlAsync(InstaBusinessPartner desirePartner, Uri uri)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			if (desirePartner?.AppId == null)
			{
				return Result.Fail<bool>("Desire partner cannot be null");
			}
			if (uri == null)
			{
				return Result.Fail<bool>("Uri cannot be null");
			}
			Uri businessValidateUrlUri = UriCreator.GetBusinessValidateUrlUri();
			JObject data = new JObject
			{
				{ "app_id", desirePartner.AppId },
				{ "_csrftoken", _user.CsrfToken },
				{
					"url",
					uri.ToString()
				},
				{
					"_uid",
					_user.LoggedInUser.Pk.ToString()
				},
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				}
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, businessValidateUrlUri, _deviceInfo, data);
			InstaBusinessValidateUrl instaBusinessValidateUrl = JsonConvert.DeserializeObject<InstaBusinessValidateUrl>(await (await _httpRequestProcessor.SendAsync(signedRequest)).Content.ReadAsStringAsync());
			return instaBusinessValidateUrl.IsValid ? Result.Success(resValue: true) : Result.Fail<bool>(instaBusinessValidateUrl.ErrorMessage);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail(exception, resValue: false, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<bool>(exception2);
		}
	}

	private async Task<IResult<InstaBrandedContent>> UpdateBrandedContent(int? approval = null, long[] usersToAdd = null, long[] usersToRemove = null)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri businessBrandedUpdateSettingsUri = UriCreator.GetBusinessBrandedUpdateSettingsUri();
			JObject jObject = new JObject
			{
				{
					"require_approval",
					(approval ?? 1).ToString()
				},
				{ "_csrftoken", _user.CsrfToken },
				{
					"_uid",
					_user.LoggedInUser.Pk.ToString()
				},
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				}
			};
			JArray jArray = new JArray();
			JArray jArray2 = new JArray();
			if (usersToAdd != null && usersToAdd.Any())
			{
				long[] array = usersToAdd;
				foreach (long num in array)
				{
					jArray.Add($"{num}");
				}
			}
			if (usersToRemove != null && usersToRemove.Any())
			{
				long[] array = usersToRemove;
				foreach (long num2 in array)
				{
					jArray2.Add($"{num2}");
				}
			}
			jObject.Add("added_user_ids", jArray);
			jObject.Add("removed_user_ids", jArray2);
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, businessBrandedUpdateSettingsUri, _deviceInfo, jObject);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaBrandedContent>(response, text);
			}
			InstaBrandedContentResponse response2 = JsonConvert.DeserializeObject<InstaBrandedContentResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetBrandedContentConverter(response2).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaBrandedContent>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaBrandedContent>(exception2);
		}
	}
}
