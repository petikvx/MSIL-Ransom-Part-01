using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using InstagramApiSharp.API.Processors;
using InstagramApiSharp.API.Versions;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Android.DeviceInfo;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.SessionHandlers;
using InstagramApiSharp.Enums;
using Newtonsoft.Json.Linq;

namespace InstagramApiSharp.API;

public interface IInstaApi
{
	IHttpRequestProcessor HttpRequestProcessor { get; }

	HttpClient HttpClient { get; }

	bool IsUserAuthenticated { get; }

	ILiveProcessor LiveProcessor { get; }

	IDiscoverProcessor DiscoverProcessor { get; }

	IAccountProcessor AccountProcessor { get; }

	IStoryProcessor StoryProcessor { get; }

	IMediaProcessor MediaProcessor { get; }

	ICommentProcessor CommentProcessor { get; }

	IMessagingProcessor MessagingProcessor { get; }

	IFeedProcessor FeedProcessor { get; }

	ICollectionProcessor CollectionProcessor { get; }

	ILocationProcessor LocationProcessor { get; }

	IHashtagProcessor HashtagProcessor { get; }

	IUserProcessor UserProcessor { get; }

	ITVProcessor TVProcessor { get; }

	IBusinessProcessor BusinessProcessor { get; }

	IShoppingProcessor ShoppingProcessor { get; }

	IWebProcessor WebProcessor { get; }

	ISessionHandler SessionHandler { get; set; }

	Stream GetStateDataAsStream();

	string GetStateDataAsString();

	StateData GetStateDataAsObject();

	Task<string> GetStateDataAsStringAsync();

	Task<Stream> GetStateDataAsStreamAsync();

	void LoadStateDataFromStream(Stream data);

	void LoadStateDataFromString(string data);

	void LoadStateDataFromObject(StateData stateData);

	Task LoadStateDataFromStreamAsync(Stream stream);

	Task LoadStateDataFromStringAsync(string json);

	InstaApiVersion GetApiVersionInfo();

	string GetUserAgent();

	void SetTimeout(TimeSpan timeout);

	void UseHttpClientHandler(HttpClientHandler handler);

	void SetUser(string username, string password);

	void SetUser(UserSessionData user);

	AndroidDevice GetCurrentDevice();

	UserSessionData GetLoggedUser();

	string GetAcceptLanguage();

	string GetTimezone();

	int GetTimezoneOffset();

	void SetRequestDelay(IRequestDelay delay);

	void SetApiVersion(InstaApiVersionType apiVersion);

	void SetDevice(AndroidDevice device);

	bool SetAcceptLanguage(string languageCodeAndCountryCode);

	void SetTimezone(string timezone);

	void SetTimezoneOffset(int timezoneOffset);

	Task<IResult<string>> SendGetRequestAsync(Uri uri);

	Task<IResult<string>> SendSignedPostRequestAsync(Uri uri, Dictionary<string, string> data);

	Task<IResult<string>> SendSignedPostRequestAsync(Uri uri, JObject data);

	Task<IResult<string>> SendPostRequestAsync(Uri uri, Dictionary<string, string> data);

	Task<IResult<InstaLoggedInChallengeDataInfo>> GetLoggedInChallengeDataInfoAsync();

	Task<IResult<bool>> AcceptChallengeAsync();

	Task<IResult<InstaChallengeRequireVerifyMethod>> GetChallengeRequireVerifyMethodAsync();

	Task<IResult<InstaChallengeRequireVerifyMethod>> ResetChallengeRequireVerifyMethodAsync();

	Task<IResult<InstaChallengeRequireSMSVerify>> RequestVerifyCodeToSMSForChallengeRequireAsync(bool replayChallenge = false);

	Task<IResult<InstaChallengeRequireSMSVerify>> SubmitPhoneNumberForChallengeRequireAsync(string phoneNumber, bool replayChallenge = false);

	Task<IResult<InstaChallengeRequireEmailVerify>> RequestVerifyCodeToEmailForChallengeRequireAsync(bool replayChallenge = false);

	Task<IResult<InstaLoginResult>> VerifyCodeForChallengeRequireAsync(string verifyCode);

	Task<IResult<InstaCheckEmailRegistration>> CheckEmailAsync(string email);

	Task<IResult<bool>> CheckPhoneNumberAsync(string phoneNumber);

	Task<IResult<InstaAccountCheck>> CheckUsernameAsync(string username);

	Task<IResult<bool>> SendSignUpSmsCodeAsync(string phoneNumber);

	Task<IResult<InstaPhoneNumberRegistration>> VerifySignUpSmsCodeAsync(string phoneNumber, string verificationCode);

	Task<IResult<InstaRegistrationSuggestionResponse>> GetUsernameSuggestionsAsync(string name);

	Task<IResult<InstaAccountCreation>> ValidateNewAccountWithPhoneNumberAsync(string phoneNumber, string verificationCode, string username, string password, string firstName);

	Task<IResult<InstaAccountCreation>> CreateNewAccountAsync(string username, string password, string email, string firstName = "");

	Task<IResult<InstaLoginResult>> LoginAsync(bool isNewLogin = true);

	Task<IResult<bool>> LoginWithCookiesAsync(string cookies);

	Task<IResult<InstaLoginResult>> LoginWithFacebookAsync(string fbAccessToken, string cookiesContainer);

	Task<IResult<InstaLoginTwoFactorResult>> TwoFactorLoginAsync(string verificationCode);

	Task<IResult<InstaTwoFactorLoginInfo>> GetTwoFactorInfoAsync();

	Task<IResult<InstaUserLookup>> GetRecoveryOptionsAsync(string usernameOrEmailOrPhoneNumber);

	Task<IResult<InstaRecovery>> SendRecoveryByUsernameAsync(string username);

	Task<IResult<InstaRecovery>> SendRecoveryByEmailAsync(string email);

	Task<IResult<InstaRecovery>> SendRecoveryByPhoneAsync(string phone);

	Task<IResult<TwoFactorLoginSMS>> SendTwoFactorLoginSMSAsync();

	Task<IResult<bool>> LogoutAsync();

	Task<IResult<InstaCurrentUser>> GetCurrentUserAsync();
}
