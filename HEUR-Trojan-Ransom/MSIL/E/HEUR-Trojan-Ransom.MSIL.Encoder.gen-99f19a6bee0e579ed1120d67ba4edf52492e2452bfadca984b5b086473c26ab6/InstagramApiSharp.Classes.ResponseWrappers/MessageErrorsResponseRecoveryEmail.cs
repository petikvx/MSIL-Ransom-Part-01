using InstagramApiSharp.Classes.ResponseWrappers.BaseResponse;
using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class MessageErrorsResponseRecoveryEmail : BaseStatusResponse
{
	[JsonProperty("message")]
	public string Message { get; set; }
}
