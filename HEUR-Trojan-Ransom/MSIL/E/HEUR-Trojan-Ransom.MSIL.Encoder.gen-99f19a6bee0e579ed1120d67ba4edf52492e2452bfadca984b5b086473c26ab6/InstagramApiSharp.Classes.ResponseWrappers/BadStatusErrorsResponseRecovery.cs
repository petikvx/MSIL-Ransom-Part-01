using InstagramApiSharp.Classes.ResponseWrappers.BaseResponse;
using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class BadStatusErrorsResponseRecovery : BaseStatusResponse
{
	[JsonProperty("errors")]
	public MessageErrorsResponsePhone PhoneNumber { get; set; }
}
