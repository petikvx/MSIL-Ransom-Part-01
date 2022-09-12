using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaPrimaryCountryInfoResponse
{
	[JsonProperty("is_visible")]
	public bool? IsVisible { get; set; }

	[JsonProperty("has_country")]
	public bool? HasCountry { get; set; }

	[JsonProperty("country_name")]
	public string CountryName { get; set; }
}
