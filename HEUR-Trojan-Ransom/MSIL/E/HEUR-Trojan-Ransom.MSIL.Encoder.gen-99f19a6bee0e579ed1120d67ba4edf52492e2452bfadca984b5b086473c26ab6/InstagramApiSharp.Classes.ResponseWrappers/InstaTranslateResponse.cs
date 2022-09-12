using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaTranslateResponse
{
	[JsonProperty("id")]
	public long Id { get; set; }

	[JsonProperty("translation")]
	public string Translation { get; set; }
}
