using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaPersistentSectionResponse
{
	[JsonProperty("layout_type")]
	public string LayoutType { get; set; }

	[JsonProperty("layout_content")]
	public InstaPersistentSectionLayoutContentResponse LayoutContent { get; set; }
}
