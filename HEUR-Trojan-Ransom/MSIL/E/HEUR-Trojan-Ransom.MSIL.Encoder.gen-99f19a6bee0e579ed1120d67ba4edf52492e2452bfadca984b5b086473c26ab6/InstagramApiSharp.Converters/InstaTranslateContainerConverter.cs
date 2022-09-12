using System;
using System.Linq;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaTranslateContainerConverter : IObjectConverter<InstaTranslateList, InstaTranslateContainerResponse>
{
	public InstaTranslateContainerResponse SourceObject { get; set; }

	public InstaTranslateList Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("SourceObject");
		}
		InstaTranslateList instaTranslateList = new InstaTranslateList();
		if (SourceObject.Translations != null && SourceObject.Translations.Any())
		{
			foreach (InstaTranslateResponse translation in SourceObject.Translations)
			{
				instaTranslateList.Add(ConvertersFabric.Instance.GetSingleTranslateConverter(translation).Convert());
			}
			return instaTranslateList;
		}
		return instaTranslateList;
	}
}
