using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaSectionMediaExploreItemInfoResponse
{
	[JsonProperty("num_columns")]
	public int NumBolumns { get; set; }

	[JsonProperty("total_num_columns")]
	public int TotalNumBolumns { get; set; }

	[JsonProperty("aspect_ratio")]
	public float AspectRatio { get; set; }

	[JsonProperty("autoplay")]
	public bool Autoplay { get; set; }
}
