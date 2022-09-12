using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.Android.DeviceInfo;

internal class ApiRequestChallengeMessage : ApiRequestMessage
{
	[JsonProperty("_csrftoken")]
	public string CsrtToken { get; set; }
}
