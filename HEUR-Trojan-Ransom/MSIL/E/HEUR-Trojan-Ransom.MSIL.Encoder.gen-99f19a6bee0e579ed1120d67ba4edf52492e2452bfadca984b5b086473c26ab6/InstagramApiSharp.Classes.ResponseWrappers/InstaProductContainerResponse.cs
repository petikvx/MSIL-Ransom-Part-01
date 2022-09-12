using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaProductContainerResponse
{
	[JsonProperty("product")]
	public InstaProductResponse Product { get; set; }

	[JsonProperty("position")]
	public double[] Position { get; set; }
}
