using System;
using System.Collections.Generic;
using InstagramApiSharp.Classes.ResponseWrappers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InstagramApiSharp.Converters.Json;

internal class InstaRecentActivityConverter : JsonConverter
{
	public override bool CanConvert(Type objectType)
	{
		return objectType == typeof(InstaRecentActivityResponse);
	}

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		JToken jToken = JToken.Load(reader);
		InstaRecentActivityResponse instaRecentActivityResponse = new InstaRecentActivityResponse();
		if (jToken.SelectToken("stories") != null)
		{
			instaRecentActivityResponse = jToken.ToObject<InstaRecentActivityResponse>();
			instaRecentActivityResponse.IsOwnActivity = false;
		}
		else
		{
			if (jToken.SelectToken("new_stories") != null)
			{
				List<InstaRecentActivityFeedResponse> list = jToken.SelectToken("new_stories")?.ToObject<List<InstaRecentActivityFeedResponse>>();
				instaRecentActivityResponse.Stories.AddRange(list ?? throw new InvalidOperationException());
			}
			if (jToken.SelectToken("old_stories") != null)
			{
				List<InstaRecentActivityFeedResponse> list2 = jToken.SelectToken("old_stories")?.ToObject<List<InstaRecentActivityFeedResponse>>();
				instaRecentActivityResponse.Stories.AddRange(list2 ?? throw new InvalidOperationException());
			}
			instaRecentActivityResponse.IsOwnActivity = true;
		}
		return instaRecentActivityResponse;
	}

	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
		serializer.Serialize(writer, value);
	}
}
