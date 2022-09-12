using System;
using System.Linq;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaTVSearchConverter : IObjectConverter<InstaTVSearch, InstaTVSearchResponse>
{
	public InstaTVSearchResponse SourceObject { get; set; }

	public InstaTVSearch Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("SourceObject");
		}
		InstaTVSearch instaTVSearch = new InstaTVSearch
		{
			NumResults = SourceObject.NumResults.GetValueOrDefault(),
			Status = SourceObject.Status,
			RankToken = SourceObject.RankToken
		};
		if (SourceObject.Results != null && SourceObject.Results.Any())
		{
			foreach (InstaTVSearchResultResponse result in SourceObject.Results)
			{
				try
				{
					instaTVSearch.Results.Add(ConvertersFabric.Instance.GetTVSearchResultConverter(result).Convert());
				}
				catch
				{
				}
			}
			return instaTVSearch;
		}
		return instaTVSearch;
	}
}
