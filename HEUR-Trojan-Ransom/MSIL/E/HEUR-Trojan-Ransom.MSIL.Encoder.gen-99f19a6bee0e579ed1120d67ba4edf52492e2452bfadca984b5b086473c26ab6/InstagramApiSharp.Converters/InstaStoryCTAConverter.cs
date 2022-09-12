using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaStoryCTAConverter : IObjectConverter<InstaStoryCTA, InstaStoryCTAResponse>
{
	public InstaStoryCTAResponse SourceObject { get; set; }

	public InstaStoryCTA Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		return new InstaStoryCTA
		{
			AndroidClass = SourceObject.AndroidClass,
			CallToActionTitle = SourceObject.CallToActionTitle,
			DeeplinkUri = SourceObject.DeeplinkUri,
			IgUserId = SourceObject.IgUserId,
			LeadGenFormId = SourceObject.LeadGenFormId,
			LinkType = SourceObject.LinkType,
			Package = SourceObject.Package,
			RedirectUri = SourceObject.RedirectUri,
			WebUri = SourceObject.WebUri
		};
	}
}
