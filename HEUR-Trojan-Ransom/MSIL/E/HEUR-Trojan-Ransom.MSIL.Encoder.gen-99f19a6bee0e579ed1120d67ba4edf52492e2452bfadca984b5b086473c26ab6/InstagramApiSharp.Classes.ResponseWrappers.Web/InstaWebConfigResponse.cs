using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers.Web;

public class InstaWebConfigResponse
{
	[JsonProperty("viewer")]
	public InstaUserShortResponse Viewer { get; set; }
}
