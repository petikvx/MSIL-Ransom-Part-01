using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaDirectHashtagConverter : IObjectConverter<InstaDirectHashtag, InstaDirectHashtagResponse>
{
	public InstaDirectHashtagResponse SourceObject { get; set; }

	public InstaDirectHashtag Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaDirectHashtag instaDirectHashtag = new InstaDirectHashtag
		{
			Name = SourceObject.Name,
			MediaCount = SourceObject.MediaCount
		};
		if (SourceObject.Media != null)
		{
			instaDirectHashtag.Media = ConvertersFabric.Instance.GetSingleMediaConverter(SourceObject.Media).Convert();
		}
		return instaDirectHashtag;
	}
}
