using System;
using System.Collections.Generic;
using InstagramApiSharp.Classes.ResponseWrappers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InstagramApiSharp.Converters.Json;

internal class InstaMediaListDataConverter : JsonConverter
{
	public override bool CanConvert(Type objectType)
	{
		return objectType == typeof(InstaMediaListResponse);
	}

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		JToken jToken = JToken.Load(reader);
		InstaMediaListResponse instaMediaListResponse = jToken.ToObject<InstaMediaListResponse>();
		instaMediaListResponse.Medias.Clear();
		instaMediaListResponse.Stories.Clear();
		JToken jToken2 = jToken.SelectToken("items");
		JToken jToken3 = jToken.SelectToken("items[0].stories.tray");
		foreach (JToken item in (IEnumerable<JToken>)jToken2)
		{
			JToken jToken4 = item?.SelectToken("media");
			InstaMediaItemResponse instaMediaItemResponse = ((jToken4 != null) ? jToken4.ToObject<InstaMediaItemResponse>() : item?.ToObject<InstaMediaItemResponse>());
			if (!string.IsNullOrEmpty(instaMediaItemResponse?.Pk))
			{
				instaMediaListResponse.Medias.Add(instaMediaItemResponse);
			}
		}
		if (jToken3 == null)
		{
			return instaMediaListResponse;
		}
		foreach (JToken item2 in (IEnumerable<JToken>)jToken3)
		{
			InstaStoryResponse instaStoryResponse = item2.ToObject<InstaStoryResponse>();
			if (instaStoryResponse != null)
			{
				instaMediaListResponse.Stories.Add(instaStoryResponse);
			}
		}
		return instaMediaListResponse;
	}

	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
		serializer.Serialize(writer, value);
	}
}
