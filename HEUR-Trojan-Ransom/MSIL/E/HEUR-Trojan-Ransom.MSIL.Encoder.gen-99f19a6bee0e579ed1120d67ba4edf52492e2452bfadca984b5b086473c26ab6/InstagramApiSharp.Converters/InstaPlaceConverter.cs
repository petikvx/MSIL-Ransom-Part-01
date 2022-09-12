using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaPlaceConverter : IObjectConverter<InstaPlace, InstaPlaceResponse>
{
	public InstaPlaceResponse SourceObject { get; set; }

	public InstaPlace Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		return new InstaPlace
		{
			Location = ConvertersFabric.Instance.GetPlaceShortConverter(SourceObject.Location).Convert(),
			Title = SourceObject.Title,
			Subtitle = SourceObject.Subtitle
		};
	}
}
