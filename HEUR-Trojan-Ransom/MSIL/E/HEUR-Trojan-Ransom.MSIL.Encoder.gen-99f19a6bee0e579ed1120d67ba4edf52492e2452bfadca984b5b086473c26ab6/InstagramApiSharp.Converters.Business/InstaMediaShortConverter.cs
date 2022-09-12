using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.Models.Business;
using InstagramApiSharp.Classes.ResponseWrappers.Business;

namespace InstagramApiSharp.Converters.Business;

internal class InstaMediaShortConverter : IObjectConverter<InstaMediaShort, InstaMediaShortResponse>
{
	public InstaMediaShortResponse SourceObject { get; set; }

	public InstaMediaShort Convert()
	{
		InstaMediaShort instaMediaShort = new InstaMediaShort
		{
			Id = SourceObject.Id,
			MediaIdentifier = SourceObject.MediaIdentifier
		};
		if (!string.IsNullOrEmpty(SourceObject.InstagramMediaType))
		{
			try
			{
				instaMediaShort.MediaType = (InstaMediaType)Enum.Parse(typeof(InstaMediaType), SourceObject.InstagramMediaType, ignoreCase: true);
			}
			catch
			{
			}
		}
		if (SourceObject.Image != null && SourceObject.Image.Uri != null)
		{
			instaMediaShort.Image = SourceObject.Image.Uri;
		}
		if (SourceObject.InlineInsightsNode != null)
		{
			try
			{
				instaMediaShort.InsightsState = SourceObject.InlineInsightsNode.State;
				instaMediaShort.MetricsImpressionsOrganicValue = SourceObject.InlineInsightsNode.Metrics.Impressions.Organic.Value.GetValueOrDefault();
				return instaMediaShort;
			}
			catch
			{
				return instaMediaShort;
			}
		}
		return instaMediaShort;
	}
}
