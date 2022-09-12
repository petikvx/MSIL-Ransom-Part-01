using System;
using System.Linq;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaMediaListConverter : IObjectConverter<InstaMediaList, InstaMediaListResponse>
{
	public InstaMediaListResponse SourceObject { get; set; }

	public InstaMediaList Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaMediaList instaMediaList = new InstaMediaList();
		instaMediaList.AddRange(from converter in SourceObject.Medias.Select(ConvertersFabric.Instance.GetSingleMediaConverter)
			select converter.Convert());
		instaMediaList.PageSize = SourceObject.ResultsCount;
		return instaMediaList;
	}
}
