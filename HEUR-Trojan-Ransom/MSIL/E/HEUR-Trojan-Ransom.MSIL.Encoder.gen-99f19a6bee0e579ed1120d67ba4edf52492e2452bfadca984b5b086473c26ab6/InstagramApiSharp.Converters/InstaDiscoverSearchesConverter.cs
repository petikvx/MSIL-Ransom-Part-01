using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;
using InstagramApiSharp.Helpers;

namespace InstagramApiSharp.Converters;

internal class InstaDiscoverSearchesConverter : IObjectConverter<InstaDiscoverSearches, InstaDiscoverSearchesResponse>
{
	public InstaDiscoverSearchesResponse SourceObject { get; set; }

	public InstaDiscoverSearches Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		return new InstaDiscoverSearches
		{
			ClientTime = DateTimeHelper.FromUnixTimeSeconds(SourceObject.ClientTime.GetValueOrDefault()),
			Position = SourceObject.Position,
			User = ConvertersFabric.Instance.GetUserConverter(SourceObject.User).Convert()
		};
	}
}
