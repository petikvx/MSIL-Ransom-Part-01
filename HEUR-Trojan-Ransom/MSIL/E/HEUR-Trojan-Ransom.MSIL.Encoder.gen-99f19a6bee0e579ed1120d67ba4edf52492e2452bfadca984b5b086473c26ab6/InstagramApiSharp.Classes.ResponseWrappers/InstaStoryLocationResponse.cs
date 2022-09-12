using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaStoryLocationResponse
{
	[JsonProperty("rotation")]
	public double Rotation { get; set; }

	[JsonProperty("is_pinned")]
	public double IsPinned { get; set; }

	[JsonProperty("height")]
	public double Height { get; set; }

	[JsonProperty("location")]
	public InstaPlaceShortResponse Location { get; set; }

	[JsonProperty("x")]
	public double X { get; set; }

	[JsonProperty("width")]
	public double Width { get; set; }

	[JsonProperty("y")]
	public double Y { get; set; }

	[JsonProperty("z")]
	public double Z { get; set; }

	[JsonProperty("is_hidden")]
	public double IsHidden { get; set; }
}
