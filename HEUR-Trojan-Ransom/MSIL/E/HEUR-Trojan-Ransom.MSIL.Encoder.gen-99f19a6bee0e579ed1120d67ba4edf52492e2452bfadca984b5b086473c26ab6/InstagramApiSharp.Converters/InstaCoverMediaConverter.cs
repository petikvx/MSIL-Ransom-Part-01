using System.Collections.Generic;
using System.Linq;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaCoverMediaConverter : IObjectConverter<InstaCoverMedia, InstaCoverMediaResponse>
{
	public InstaCoverMediaResponse SourceObject { get; set; }

	public InstaCoverMedia Convert()
	{
		List<InstaImage> list = new List<InstaImage>();
		if (SourceObject.ImageVersions != null)
		{
			list.AddRange(from converter in SourceObject.ImageVersions.Candidates.Select(ConvertersFabric.Instance.GetImageConverter)
				select converter.Convert());
		}
		return new InstaCoverMedia
		{
			Id = SourceObject.Id,
			ImageVersions = list,
			MediaType = SourceObject.MediaType,
			OriginalHeight = SourceObject.OriginalHeight,
			OriginalWidth = SourceObject.OriginalWidth
		};
	}
}
