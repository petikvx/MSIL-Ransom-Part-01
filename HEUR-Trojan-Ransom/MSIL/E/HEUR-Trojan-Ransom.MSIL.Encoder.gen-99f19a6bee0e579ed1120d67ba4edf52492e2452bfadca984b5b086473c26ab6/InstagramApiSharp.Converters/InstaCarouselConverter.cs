using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaCarouselConverter : IObjectConverter<InstaCarousel, InstaCarouselResponse>
{
	public InstaCarouselResponse SourceObject { get; set; }

	public InstaCarousel Convert()
	{
		InstaCarousel instaCarousel = new InstaCarousel();
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		foreach (InstaCarouselItemResponse item in SourceObject)
		{
			IObjectConverter<InstaCarouselItem, InstaCarouselItemResponse> carouselItemConverter = ConvertersFabric.Instance.GetCarouselItemConverter(item);
			instaCarousel.Add(carouselItemConverter.Convert());
		}
		return instaCarousel;
	}
}
