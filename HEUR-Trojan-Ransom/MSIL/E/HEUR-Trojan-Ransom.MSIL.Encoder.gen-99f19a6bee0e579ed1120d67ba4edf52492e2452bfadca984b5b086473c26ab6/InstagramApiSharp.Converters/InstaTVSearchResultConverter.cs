using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaTVSearchResultConverter : IObjectConverter<InstaTVSearchResult, InstaTVSearchResultResponse>
{
	public InstaTVSearchResultResponse SourceObject { get; set; }

	public InstaTVSearchResult Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("SourceObject");
		}
		InstaTVSearchResult instaTVSearchResult = new InstaTVSearchResult
		{
			Type = SourceObject.Type
		};
		if (SourceObject.Channel != null)
		{
			try
			{
				instaTVSearchResult.Channel = ConvertersFabric.Instance.GetTVChannelConverter(SourceObject.Channel).Convert();
			}
			catch
			{
			}
		}
		if (SourceObject.User != null)
		{
			try
			{
				instaTVSearchResult.User = ConvertersFabric.Instance.GetUserShortFriendshipConverter(SourceObject.User).Convert();
				return instaTVSearchResult;
			}
			catch
			{
				return instaTVSearchResult;
			}
		}
		return instaTVSearchResult;
	}
}
