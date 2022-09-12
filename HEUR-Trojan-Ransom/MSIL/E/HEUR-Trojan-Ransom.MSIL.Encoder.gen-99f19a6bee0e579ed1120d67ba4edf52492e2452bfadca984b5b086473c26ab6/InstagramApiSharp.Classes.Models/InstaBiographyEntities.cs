using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.Models;

public class InstaBiographyEntities
{
	[JsonProperty("nux_type")]
	public string NuxType { get; set; }

	[JsonProperty("raw_text")]
	public string Text { get; set; }

	[JsonProperty("Entities")]
	public InstaBiograpyEntity[] Entities { get; set; }
}
