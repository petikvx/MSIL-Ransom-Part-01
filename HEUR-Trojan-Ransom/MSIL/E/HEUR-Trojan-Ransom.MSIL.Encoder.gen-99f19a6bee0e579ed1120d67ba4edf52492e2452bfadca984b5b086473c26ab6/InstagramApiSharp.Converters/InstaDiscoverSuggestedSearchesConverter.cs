using System;
using System.Linq;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaDiscoverSuggestedSearchesConverter : IObjectConverter<InstaDiscoverSuggestedSearches, InstaDiscoverSuggestedSearchesResponse>
{
	public InstaDiscoverSuggestedSearchesResponse SourceObject { get; set; }

	public InstaDiscoverSuggestedSearches Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaDiscoverSuggestedSearches instaDiscoverSuggestedSearches = new InstaDiscoverSuggestedSearches
		{
			RankToken = SourceObject.RankToken
		};
		if (SourceObject.Suggested != null && SourceObject.Suggested.Any())
		{
			foreach (InstaDiscoverSearchesResponse item in SourceObject.Suggested)
			{
				try
				{
					instaDiscoverSuggestedSearches.Suggested.Add(ConvertersFabric.Instance.GetDiscoverSearchesConverter(item).Convert());
				}
				catch
				{
				}
			}
			return instaDiscoverSuggestedSearches;
		}
		return instaDiscoverSuggestedSearches;
	}
}
