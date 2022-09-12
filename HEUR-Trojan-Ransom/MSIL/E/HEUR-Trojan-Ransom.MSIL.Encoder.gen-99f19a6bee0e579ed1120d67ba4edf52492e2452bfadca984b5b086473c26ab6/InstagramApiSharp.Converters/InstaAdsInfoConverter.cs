using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaAdsInfoConverter : IObjectConverter<InstaAdsInfo, InstaAdsInfoResponse>
{
	public InstaAdsInfoResponse SourceObject { get; set; }

	public InstaAdsInfo Convert()
	{
		return new InstaAdsInfo
		{
			AdsUrl = SourceObject.AdsUrl,
			HasAds = SourceObject.HasAds.GetValueOrDefault()
		};
	}
}
