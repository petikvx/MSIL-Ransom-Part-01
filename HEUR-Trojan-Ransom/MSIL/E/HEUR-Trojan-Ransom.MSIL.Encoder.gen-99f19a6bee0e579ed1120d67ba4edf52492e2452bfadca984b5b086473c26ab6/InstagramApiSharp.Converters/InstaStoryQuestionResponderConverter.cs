using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;
using InstagramApiSharp.Helpers;

namespace InstagramApiSharp.Converters;

internal class InstaStoryQuestionResponderConverter : IObjectConverter<InstaStoryQuestionResponder, InstaStoryQuestionResponderResponse>
{
	public InstaStoryQuestionResponderResponse SourceObject { get; set; }

	public InstaStoryQuestionResponder Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaStoryQuestionResponder instaStoryQuestionResponder = new InstaStoryQuestionResponder
		{
			HasSharedResponse = SourceObject.HasSharedResponse.GetValueOrDefault(),
			Id = SourceObject.Id,
			ResponseText = SourceObject.Response,
			Time = (SourceObject.Ts ?? DateTime.UtcNow.ToUnixTime()).FromUnixTimeSeconds()
		};
		if (SourceObject.User != null)
		{
			instaStoryQuestionResponder.User = ConvertersFabric.Instance.GetUserShortConverter(SourceObject.User).Convert();
		}
		return instaStoryQuestionResponder;
	}
}
