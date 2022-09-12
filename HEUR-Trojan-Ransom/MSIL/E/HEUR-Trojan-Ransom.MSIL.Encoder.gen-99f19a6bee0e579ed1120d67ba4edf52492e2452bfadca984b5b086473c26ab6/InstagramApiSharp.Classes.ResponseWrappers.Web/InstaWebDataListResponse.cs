using System.Collections.Generic;
using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers.Web;

public class InstaWebDataListResponse
{
	[JsonProperty("link")]
	public object Link { get; set; }

	[JsonProperty("data")]
	public List<InstaWebDataItemResponse> Data { get; set; } = new List<InstaWebDataItemResponse>();


	[JsonProperty("cursor")]
	public string Cursor { get; set; }
}
