using System.Collections.Generic;
using System.Linq;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaCollectionsConverter : IObjectConverter<InstaCollections, InstaCollectionsResponse>
{
	public InstaCollectionsResponse SourceObject { get; set; }

	public InstaCollections Convert()
	{
		List<InstaCollectionItem> list = new List<InstaCollectionItem>();
		list.AddRange(from converter in SourceObject.Items.Select(ConvertersFabric.Instance.GetCollectionConverter)
			select converter.Convert());
		return new InstaCollections
		{
			Items = list,
			MoreCollectionsAvailable = SourceObject.MoreAvailable,
			NextMaxId = SourceObject.NextMaxId
		};
	}
}
