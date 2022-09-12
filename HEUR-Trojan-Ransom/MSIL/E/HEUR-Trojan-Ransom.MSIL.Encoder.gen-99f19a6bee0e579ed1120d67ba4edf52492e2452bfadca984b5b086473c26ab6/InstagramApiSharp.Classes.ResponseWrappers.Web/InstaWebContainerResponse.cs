using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers.Web;

public class InstaWebContainerResponse
{
	[JsonProperty("country_code")]
	public string CountryCode { get; set; }

	[JsonProperty("language_code")]
	public string LanguageCode { get; set; }

	[JsonProperty("locale")]
	public string Locale { get; set; }

	[JsonProperty("config")]
	public InstaWebConfigResponse Config { get; set; }

	[JsonProperty("entry_data")]
	public InstaWebEntryDataResponse Entry { get; set; }
}
