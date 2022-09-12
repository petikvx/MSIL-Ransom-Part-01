using System.Collections.Generic;
using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers.Web;

public class InstaWebEntryDataResponse
{
	[JsonProperty("SettingsPages")]
	public List<InstaWebSettingsPageResponse> SettingsPages { get; set; } = new List<InstaWebSettingsPageResponse>();

}
