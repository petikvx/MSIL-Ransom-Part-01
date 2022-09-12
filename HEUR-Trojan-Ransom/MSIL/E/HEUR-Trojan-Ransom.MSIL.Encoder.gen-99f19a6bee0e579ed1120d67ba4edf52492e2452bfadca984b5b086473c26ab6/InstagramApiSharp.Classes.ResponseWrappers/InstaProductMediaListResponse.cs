using System.Collections.Generic;
using InstagramApiSharp.Classes.ResponseWrappers.BaseResponse;
using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaProductMediaListResponse : BaseLoadableResponse
{
	[JsonProperty("items")]
	public List<InstaMediaItemResponse> Medias { get; set; } = new List<InstaMediaItemResponse>();

}
