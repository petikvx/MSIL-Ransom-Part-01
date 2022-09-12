using System.Linq;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaCollectionConverter : IObjectConverter<InstaCollectionItem, InstaCollectionItemResponse>
{
	public InstaCollectionItemResponse SourceObject { get; set; }

	public InstaCollectionItem Convert()
	{
		InstaMediaList instaMediaList = new InstaMediaList();
		if (SourceObject.Media != null)
		{
			instaMediaList.AddRange(from converter in SourceObject.Media.Medias.Select(ConvertersFabric.Instance.GetSingleMediaConverter)
				select converter.Convert());
		}
		return new InstaCollectionItem
		{
			CollectionId = SourceObject.CollectionId,
			CollectionName = SourceObject.CollectionName,
			HasRelatedMedia = SourceObject.HasRelatedMedia,
			Media = instaMediaList,
			CoverMedia = ((SourceObject.CoverMedia != null) ? ConvertersFabric.Instance.GetCoverMediaConverter(SourceObject.CoverMedia).Convert() : null),
			NextMaxId = SourceObject.NextMaxId
		};
	}
}
