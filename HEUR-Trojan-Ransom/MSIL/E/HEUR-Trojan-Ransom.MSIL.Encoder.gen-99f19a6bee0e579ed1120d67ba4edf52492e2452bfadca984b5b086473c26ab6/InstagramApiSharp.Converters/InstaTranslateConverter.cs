using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaTranslateConverter : IObjectConverter<InstaTranslate, InstaTranslateResponse>
{
	public InstaTranslateResponse SourceObject { get; set; }

	public InstaTranslate Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("SourceObject");
		}
		return new InstaTranslate
		{
			Id = SourceObject.Id,
			Translation = SourceObject.Translation
		};
	}
}
