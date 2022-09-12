using System;
using System.Linq;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaHashtagSearchConverter : IObjectConverter<InstaHashtagSearch, InstaHashtagSearchResponse>
{
	public InstaHashtagSearchResponse SourceObject { get; set; }

	public InstaHashtagSearch Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaHashtagSearch instaHashtagSearch = new InstaHashtagSearch();
		instaHashtagSearch.MoreAvailable = SourceObject.MoreAvailable.GetValueOrDefault(false);
		instaHashtagSearch.RankToken = SourceObject.RankToken;
		instaHashtagSearch.AddRange(SourceObject.Tags.Select((InstaHashtagResponse tag) => ConvertersFabric.Instance.GetHashTagConverter(tag).Convert()));
		return instaHashtagSearch;
	}
}
