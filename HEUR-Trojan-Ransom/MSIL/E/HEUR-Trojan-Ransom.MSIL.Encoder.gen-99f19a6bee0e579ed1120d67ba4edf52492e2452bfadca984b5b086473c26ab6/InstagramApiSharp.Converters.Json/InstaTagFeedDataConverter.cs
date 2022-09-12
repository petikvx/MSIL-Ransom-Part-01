using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using InstagramApiSharp.Classes.ResponseWrappers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InstagramApiSharp.Converters.Json;

internal class InstaTagFeedDataConverter : JsonConverter
{
	public override bool CanConvert(Type objectType)
	{
		return objectType == typeof(InstaTagFeedResponse);
	}

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		JToken jToken = JToken.Load(reader);
		InstaTagFeedResponse instaTagFeedResponse = jToken.ToObject<InstaTagFeedResponse>();
		instaTagFeedResponse.Medias.Clear();
		instaTagFeedResponse.RankedItems.Clear();
		instaTagFeedResponse.Stories.Clear();
		JToken jToken2 = jToken.SelectToken("story");
		JToken jToken3 = jToken.SelectToken("ranked_items");
		JToken jToken4 = jToken.SelectToken("items");
		JToken jToken5 = jToken.SelectToken("story.items");
		if (jToken4 != null)
		{
			instaTagFeedResponse.Medias.AddRange(smethod_0(jToken4));
		}
		if (jToken3 != null)
		{
			instaTagFeedResponse.RankedItems.AddRange(smethod_0(jToken3));
		}
		if (jToken5 == null)
		{
			return instaTagFeedResponse;
		}
		foreach (JToken item2 in (IEnumerable<JToken>)jToken5)
		{
			InstaStoryResponse item = item2.ToObject<InstaStoryResponse>();
			if (jToken2 != null)
			{
				instaTagFeedResponse.Stories.Add(item);
			}
		}
		return instaTagFeedResponse;
	}

	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
		serializer.Serialize(writer, value);
	}

	[CompilerGenerated]
	internal static List<InstaMediaItemResponse> smethod_0(JToken token)
	{
		return (from item in token
			select item?.ToObject<InstaMediaItemResponse>() into media
			where !string.IsNullOrEmpty(media?.Pk)
			select media).ToList();
	}
}
