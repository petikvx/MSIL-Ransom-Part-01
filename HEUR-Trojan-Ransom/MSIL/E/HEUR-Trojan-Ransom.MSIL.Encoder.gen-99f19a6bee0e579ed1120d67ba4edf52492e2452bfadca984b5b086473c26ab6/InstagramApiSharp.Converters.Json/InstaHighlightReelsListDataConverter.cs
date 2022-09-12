using System;
using InstagramApiSharp.Classes.ResponseWrappers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InstagramApiSharp.Converters.Json;

internal class InstaHighlightReelsListDataConverter : JsonConverter
{
	public override bool CanConvert(Type objectType)
	{
		return objectType == typeof(InstaHighlightReelResponse);
	}

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		JToken jToken = JToken.Load(reader);
		InstaHighlightReelResponse instaHighlightReelResponse = jToken.ToObject<InstaHighlightReelResponse>();
		instaHighlightReelResponse.Reel = jToken["reels"]?.First?.First?.ToObject<InstaHighlightSingleFeedResponse>();
		return instaHighlightReelResponse;
	}

	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
		serializer.Serialize(writer, value);
	}
}
