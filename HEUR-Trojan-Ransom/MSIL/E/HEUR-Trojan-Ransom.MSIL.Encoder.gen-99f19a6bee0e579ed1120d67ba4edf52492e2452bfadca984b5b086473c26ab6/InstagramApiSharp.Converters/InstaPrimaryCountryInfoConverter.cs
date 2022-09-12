using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaPrimaryCountryInfoConverter : IObjectConverter<InstaPrimaryCountryInfo, InstaPrimaryCountryInfoResponse>
{
	public InstaPrimaryCountryInfoResponse SourceObject { get; set; }

	public InstaPrimaryCountryInfo Convert()
	{
		return new InstaPrimaryCountryInfo
		{
			CountryName = SourceObject.CountryName,
			HasCountry = SourceObject.HasCountry.GetValueOrDefault(),
			IsVisible = SourceObject.IsVisible.GetValueOrDefault()
		};
	}
}
