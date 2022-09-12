using System.Collections.Generic;
using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaProductTagsContainerResponse
{
	[JsonProperty("in")]
	public List<InstaProductContainerResponse> In { get; set; }
}
