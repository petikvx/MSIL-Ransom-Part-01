using System;
using System.Linq;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaDiscoverTopSearchesConverter : IObjectConverter<InstaDiscoverTopSearches, InstaDiscoverTopSearchesResponse>
{
	public InstaDiscoverTopSearchesResponse SourceObject { get; set; }

	public InstaDiscoverTopSearches Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaDiscoverTopSearches instaDiscoverTopSearches = new InstaDiscoverTopSearches();
		if (SourceObject.TopResults != null && SourceObject.TopResults.Any())
		{
			foreach (InstaDiscoverSearchesResponse topResult in SourceObject.TopResults)
			{
				try
				{
					instaDiscoverTopSearches.TopResults.Add(ConvertersFabric.Instance.GetDiscoverSearchesConverter(topResult).Convert());
				}
				catch
				{
				}
			}
			return instaDiscoverTopSearches;
		}
		return instaDiscoverTopSearches;
	}
}
