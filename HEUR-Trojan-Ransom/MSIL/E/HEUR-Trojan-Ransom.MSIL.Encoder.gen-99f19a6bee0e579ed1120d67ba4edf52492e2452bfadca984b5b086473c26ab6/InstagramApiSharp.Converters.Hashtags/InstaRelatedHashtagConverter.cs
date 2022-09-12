using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters.Hashtags;

internal class InstaRelatedHashtagConverter : IObjectConverter<InstaRelatedHashtag, InstaRelatedHashtagResponse>
{
	public InstaRelatedHashtagResponse SourceObject { get; set; }

	public InstaRelatedHashtag Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		return new InstaRelatedHashtag
		{
			Id = SourceObject.Id,
			Name = SourceObject.Name,
			Type = SourceObject.Type
		};
	}
}
