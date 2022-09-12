using System;
using System.Collections.Generic;
using InstagramApiSharp.Classes.ResponseWrappers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InstagramApiSharp.Converters.Json;

internal class InstaFeedResponseDataConverter : JsonConverter
{
	public override bool CanConvert(Type objectType)
	{
		return objectType == typeof(InstaFeedResponse);
	}

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		JToken jToken = JToken.Load(reader);
		InstaFeedResponse instaFeedResponse = jToken.ToObject<InstaFeedResponse>();
		JToken jToken2 = jToken["feed_items"];
		if (jToken2 != null)
		{
			foreach (JToken item3 in (IEnumerable<JToken>)jToken2)
			{
				if (item3["media_or_ad"] != null)
				{
					JToken jToken3 = item3["media_or_ad"];
					if (jToken3 == null)
					{
						continue;
					}
					InstaMediaItemResponse item = jToken3.ToObject<InstaMediaItemResponse>();
					instaFeedResponse.Items.Add(item);
				}
				if (item3["suggested_users"] != null)
				{
					JToken jToken4 = item3["suggested_users"]?["suggestions"];
					if (jToken4 != null)
					{
						foreach (JToken item4 in (IEnumerable<JToken>)jToken4)
						{
							if (item4 != null)
							{
								InstaSuggestionItemResponse item2 = item4.ToObject<InstaSuggestionItemResponse>();
								instaFeedResponse.SuggestedUsers.Add(item2);
							}
						}
					}
				}
			}
			return instaFeedResponse;
		}
		jToken2 = jToken["items"];
		instaFeedResponse.Items = jToken2.ToObject<List<InstaMediaItemResponse>>();
		return instaFeedResponse;
	}

	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
		serializer.Serialize(writer, value);
	}
}
