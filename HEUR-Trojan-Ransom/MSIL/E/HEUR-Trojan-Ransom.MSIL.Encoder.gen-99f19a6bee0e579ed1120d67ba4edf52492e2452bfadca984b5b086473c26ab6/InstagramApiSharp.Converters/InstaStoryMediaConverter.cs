using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaStoryMediaConverter : IObjectConverter<InstaStoryMedia, InstaStoryMediaResponse>
{
	public InstaStoryMediaResponse SourceObject { get; set; }

	public InstaStoryMedia Convert()
	{
		return new InstaStoryMedia
		{
			Media = ConvertersFabric.Instance.GetStoryItemConverter(SourceObject.Media).Convert()
		};
	}
}
