using System;
using System.Linq;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaDiscoverRecentSearchesConverter : IObjectConverter<InstaDiscoverRecentSearches, InstaDiscoverRecentSearchesResponse>
{
	public InstaDiscoverRecentSearchesResponse SourceObject { get; set; }

	public InstaDiscoverRecentSearches Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaDiscoverRecentSearches instaDiscoverRecentSearches = new InstaDiscoverRecentSearches();
		if (SourceObject.Recent != null && SourceObject.Recent.Any())
		{
			foreach (InstaDiscoverSearchesResponse item in SourceObject.Recent)
			{
				try
				{
					instaDiscoverRecentSearches.Recent.Add(ConvertersFabric.Instance.GetDiscoverSearchesConverter(item).Convert());
				}
				catch
				{
				}
			}
			return instaDiscoverRecentSearches;
		}
		return instaDiscoverRecentSearches;
	}
}
