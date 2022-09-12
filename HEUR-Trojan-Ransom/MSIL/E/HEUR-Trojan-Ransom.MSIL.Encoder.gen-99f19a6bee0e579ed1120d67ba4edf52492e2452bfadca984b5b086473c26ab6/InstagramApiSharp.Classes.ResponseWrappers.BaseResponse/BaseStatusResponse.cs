using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers.BaseResponse;

public class BaseStatusResponse
{
	[JsonProperty("status")]
	public string Status { get; set; }

	public bool IsOk()
	{
		if (!string.IsNullOrEmpty(Status))
		{
			return Status.ToLower() == "ok";
		}
		return false;
	}

	public bool IsFail()
	{
		if (!string.IsNullOrEmpty(Status))
		{
			return Status.ToLower() == "fail";
		}
		return false;
	}
}
