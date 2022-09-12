using System;
using InstagramApiSharp.API.Versions;
using InstagramApiSharp.Helpers;
using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.Android.DeviceInfo;

public class ApiRequestMessage
{
	private static readonly Random Rnd = new Random();

	[JsonProperty("phone_id")]
	public string PhoneId { get; set; }

	[JsonProperty("username")]
	public string Username { get; set; }

	[JsonProperty("adid")]
	public string AdId { get; set; }

	[JsonProperty("guid")]
	public Guid Guid { get; set; }

	[JsonProperty("device_id")]
	public string DeviceId { get; set; }

	[JsonProperty("_uuid")]
	public string Uuid => Guid.ToString();

	[JsonProperty("google_tokens")]
	public string GoogleTokens { get; set; } = "[]";


	[JsonProperty("password")]
	public string Password { get; set; }

	[JsonProperty("login_attempt_count")]
	public string LoginAttemptCount { get; set; } = "1";


	public static ApiRequestMessage CurrentDevice { get; private set; }

	internal string GetMessageString()
	{
		return JsonConvert.SerializeObject(this);
	}

	internal string GetChallengeMessageString(string csrfToken)
	{
		return JsonConvert.SerializeObject(new ApiRequestChallengeMessage
		{
			CsrtToken = csrfToken,
			DeviceId = DeviceId,
			Guid = Guid,
			LoginAttemptCount = "1",
			Password = Password,
			PhoneId = PhoneId,
			Username = Username,
			AdId = AdId
		});
	}

	internal string GetMessageStringForChallengeVerificationCodeSend(int Choice = 1)
	{
		return JsonConvert.SerializeObject(new
		{
			choice = Choice.ToString(),
			_csrftoken = "ReplaceCSRF",
			Guid = Guid,
			DeviceId = DeviceId
		});
	}

	internal string GetChallengeVerificationCodeSend(string verify)
	{
		return JsonConvert.SerializeObject(new
		{
			security_code = verify,
			_csrftoken = "ReplaceCSRF",
			Guid = Guid,
			DeviceId = DeviceId
		});
	}

	internal string GenerateSignature(InstaApiVersion apiVersion, string signatureKey, out string deviceid)
	{
		if (string.IsNullOrEmpty(signatureKey))
		{
			signatureKey = apiVersion.SignatureKey;
		}
		string result = CryptoHelper.CalculateHash(signatureKey, JsonConvert.SerializeObject(this));
		deviceid = DeviceId;
		return result;
	}

	internal string GenerateChallengeSignature(InstaApiVersion apiVersion, string signatureKey, string csrfToken, out string deviceid)
	{
		if (string.IsNullOrEmpty(signatureKey))
		{
			signatureKey = apiVersion.SignatureKey;
		}
		ApiRequestChallengeMessage value = new ApiRequestChallengeMessage
		{
			CsrtToken = csrfToken,
			DeviceId = DeviceId,
			Guid = Guid,
			LoginAttemptCount = "1",
			Password = Password,
			PhoneId = PhoneId,
			Username = Username,
			AdId = AdId
		};
		string result = CryptoHelper.CalculateHash(signatureKey, JsonConvert.SerializeObject(value));
		deviceid = DeviceId;
		return result;
	}

	internal bool IsEmpty()
	{
		if (string.IsNullOrEmpty(PhoneId))
		{
			return true;
		}
		if (string.IsNullOrEmpty(DeviceId))
		{
			return true;
		}
		if (Guid.Empty == Guid)
		{
			return true;
		}
		return false;
	}

	internal static string GenerateDeviceId()
	{
		return GenerateDeviceIdFromGuid(Guid.NewGuid());
	}

	internal static string GenerateUploadId()
	{
		return ((long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds).ToString();
	}

	internal static string GenerateRandomUploadId()
	{
		return DateTime.UtcNow.ToUnixTimeMiliSeconds().ToString();
	}

	public static ApiRequestMessage FromDevice(AndroidDevice device)
	{
		return new ApiRequestMessage
		{
			PhoneId = device.PhoneGuid.ToString(),
			Guid = device.DeviceGuid,
			DeviceId = device.DeviceId
		};
	}

	public static string GenerateDeviceIdFromGuid(Guid guid)
	{
		string text = CryptoHelper.CalculateMd5(guid.ToString());
		return "android-" + text.Substring(0, 16);
	}
}
