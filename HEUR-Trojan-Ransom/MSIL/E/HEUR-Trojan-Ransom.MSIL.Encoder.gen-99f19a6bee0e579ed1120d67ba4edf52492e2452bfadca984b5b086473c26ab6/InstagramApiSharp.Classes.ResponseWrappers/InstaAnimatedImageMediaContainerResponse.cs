using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaAnimatedImageMediaContainerResponse
{
	[JsonProperty("fixed_height")]
	public InstaAnimatedImageMediaResponse Media { get; set; }
}
