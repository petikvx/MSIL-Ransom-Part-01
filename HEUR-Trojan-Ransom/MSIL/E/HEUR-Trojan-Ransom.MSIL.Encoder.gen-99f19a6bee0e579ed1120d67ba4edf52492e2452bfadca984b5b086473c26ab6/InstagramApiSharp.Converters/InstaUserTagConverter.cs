using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaUserTagConverter : IObjectConverter<InstaUserTag, InstaUserTagResponse>
{
	public InstaUserTagResponse SourceObject { get; set; }

	public InstaUserTag Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaUserTag instaUserTag = new InstaUserTag();
		double[] position = SourceObject.Position;
		if (position != null && position.Length == 2)
		{
			instaUserTag.Position = new InstaPosition(SourceObject.Position[0], SourceObject.Position[1]);
		}
		instaUserTag.TimeInVideo = SourceObject.TimeInVideo;
		if (SourceObject.User != null)
		{
			instaUserTag.User = ConvertersFabric.Instance.GetUserShortConverter(SourceObject.User).Convert();
		}
		return instaUserTag;
	}
}
