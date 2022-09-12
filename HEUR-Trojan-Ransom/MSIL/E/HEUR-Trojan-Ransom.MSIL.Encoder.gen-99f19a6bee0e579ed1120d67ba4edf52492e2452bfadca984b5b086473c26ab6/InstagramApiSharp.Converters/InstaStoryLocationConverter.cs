using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaStoryLocationConverter : IObjectConverter<InstaStoryLocation, InstaStoryLocationResponse>
{
	public InstaStoryLocationResponse SourceObject { get; set; }

	public InstaStoryLocation Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		return new InstaStoryLocation
		{
			Height = SourceObject.Height,
			IsHidden = SourceObject.IsHidden,
			IsPinned = SourceObject.IsPinned,
			Rotation = SourceObject.Rotation,
			Width = SourceObject.Width,
			X = SourceObject.X,
			Y = SourceObject.Y,
			Z = SourceObject.Z,
			Location = ConvertersFabric.Instance.GetPlaceShortConverter(SourceObject.Location).Convert()
		};
	}
}
