using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters.Users;

internal class InstaSuggestionsConverter : IObjectConverter<InstaSuggestions, InstaSuggestionUserContainerResponse>
{
	public InstaSuggestionUserContainerResponse SourceObject { get; set; }

	public InstaSuggestions Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaSuggestions instaSuggestions = new InstaSuggestions
		{
			MoreAvailable = SourceObject.MoreAvailable,
			NextMaxId = (SourceObject.MaxId ?? string.Empty)
		};
		try
		{
			if (SourceObject.SuggestedUsers != null && SourceObject.SuggestedUsers?.Suggestions != null)
			{
				InstaSuggestionResponse suggestedUsers = SourceObject.SuggestedUsers;
				if (suggestedUsers != null && suggestedUsers.Suggestions?.Count > 0)
				{
					instaSuggestions.SuggestedUsers = ConvertersFabric.Instance.GetSuggestionItemListConverter(SourceObject.SuggestedUsers.Suggestions).Convert();
				}
			}
			if (SourceObject.NewSuggestedUsers != null)
			{
				if (SourceObject.NewSuggestedUsers?.Suggestions != null)
				{
					InstaSuggestionResponse newSuggestedUsers = SourceObject.NewSuggestedUsers;
					if (newSuggestedUsers != null && newSuggestedUsers.Suggestions?.Count > 0)
					{
						instaSuggestions.NewSuggestedUsers = ConvertersFabric.Instance.GetSuggestionItemListConverter(SourceObject.NewSuggestedUsers.Suggestions).Convert();
						return instaSuggestions;
					}
					return instaSuggestions;
				}
				return instaSuggestions;
			}
			return instaSuggestions;
		}
		catch
		{
			return instaSuggestions;
		}
	}
}
