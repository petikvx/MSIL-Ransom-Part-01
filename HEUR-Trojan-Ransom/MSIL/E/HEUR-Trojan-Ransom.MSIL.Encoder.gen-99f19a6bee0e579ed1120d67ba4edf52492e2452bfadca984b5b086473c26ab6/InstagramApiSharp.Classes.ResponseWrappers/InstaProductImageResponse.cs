using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaProductImageResponse
{
	[JsonProperty("image_versions2")]
	public InstaImageCandidatesResponse Images { get; set; }
}
