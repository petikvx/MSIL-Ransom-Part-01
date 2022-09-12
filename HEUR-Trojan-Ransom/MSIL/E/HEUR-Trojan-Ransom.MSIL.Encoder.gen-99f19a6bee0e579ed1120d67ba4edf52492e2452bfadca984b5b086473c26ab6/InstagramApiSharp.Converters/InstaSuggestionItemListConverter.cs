using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaSuggestionItemListConverter : IObjectConverter<InstaSuggestionItemList, InstaSuggestionItemListResponse>
{
	public InstaSuggestionItemListResponse SourceObject { get; set; }

	public InstaSuggestionItemList Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaSuggestionItemList instaSuggestionItemList = new InstaSuggestionItemList();
		if (SourceObject != null)
		{
			InstaSuggestionItemListResponse sourceObject = SourceObject;
			if (sourceObject != null && sourceObject.Count > 0)
			{
				foreach (InstaSuggestionItemResponse item2 in SourceObject)
				{
					try
					{
						InstaSuggestionItem item = ConvertersFabric.Instance.GetSuggestionItemConverter(item2).Convert();
						instaSuggestionItemList.Add(item);
					}
					catch
					{
					}
				}
				return instaSuggestionItemList;
			}
		}
		return instaSuggestionItemList;
	}
}
