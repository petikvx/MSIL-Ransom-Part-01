using System;
using System.Collections.Generic;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;
using InstagramApiSharp.Helpers;

namespace InstagramApiSharp.Converters;

internal class InstaStoryQuestionInfoConverter : IObjectConverter<InstaStoryQuestionInfo, InstaStoryQuestionInfoResponse>
{
	public InstaStoryQuestionInfoResponse SourceObject { get; set; }

	public InstaStoryQuestionInfo Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaStoryQuestionInfo instaStoryQuestionInfo = new InstaStoryQuestionInfo
		{
			BackgroundColor = SourceObject.BackgroundColor,
			LatestQuestionResponseTime = (SourceObject.LatestQuestionResponseTime ?? DateTime.UtcNow.ToUnixTime()).FromUnixTimeSeconds(),
			MaxId = SourceObject.MaxId,
			MoreAvailable = SourceObject.MoreAvailable.GetValueOrDefault(),
			Question = SourceObject.Question,
			QuestionId = SourceObject.QuestionId,
			QuestionResponseCount = SourceObject.QuestionResponseCount.GetValueOrDefault(),
			QuestionType = SourceObject.QuestionType,
			TextColor = SourceObject.TextColor
		};
		List<InstaStoryQuestionResponderResponse> responders = SourceObject.Responders;
		if (responders != null && responders.Count > 0)
		{
			foreach (InstaStoryQuestionResponderResponse responder in SourceObject.Responders)
			{
				instaStoryQuestionInfo.Responders.Add(ConvertersFabric.Instance.GetStoryQuestionResponderConverter(responder).Convert());
			}
			return instaStoryQuestionInfo;
		}
		return instaStoryQuestionInfo;
	}
}
