using System;
using System.Collections.Generic;
using InstagramApiSharp.Classes.ResponseWrappers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InstagramApiSharp.Converters.Json;

internal class InstaExploreFeedDataConverter : JsonConverter
{
	public override bool CanConvert(Type objectType)
	{
		return objectType == typeof(InstaExploreFeedResponse);
	}

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		JToken jToken = JToken.Load(reader);
		JToken jToken2 = jToken["items"];
		InstaExploreFeedResponse instaExploreFeedResponse = jToken.ToObject<InstaExploreFeedResponse>();
		foreach (JToken item2 in (IEnumerable<JToken>)jToken2)
		{
			JToken jToken3 = item2["stories"];
			JToken jToken4 = item2["channel"];
			JToken jToken5 = item2["media"];
			if (jToken3 != null)
			{
				InstaStoryTrayResponse storyTray = jToken3.ToObject<InstaStoryTrayResponse>();
				instaExploreFeedResponse.Items.StoryTray = storyTray;
			}
			else if (jToken4 != null)
			{
				InstaChannelResponse channel = jToken4.ToObject<InstaChannelResponse>();
				instaExploreFeedResponse.Items.Channel = channel;
			}
			else if (jToken5 != null)
			{
				InstaMediaItemResponse item = jToken5.ToObject<InstaMediaItemResponse>();
				instaExploreFeedResponse.Items.Medias.Add(item);
			}
		}
		return instaExploreFeedResponse;
	}

	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
		serializer.Serialize(writer, value);
	}
}
