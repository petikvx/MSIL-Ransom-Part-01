using System;
using InstagramApiSharp.Classes.ResponseWrappers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InstagramApiSharp.Converters.Json;

internal class InstaMediaDataConverter : JsonConverter
{
	public override bool CanConvert(Type objectType)
	{
		return objectType == typeof(InstaMediaItemResponse);
	}

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		JToken jToken = JToken.Load(reader);
		InstaMediaItemResponse instaMediaItemResponse = jToken.ToObject<InstaMediaItemResponse>();
		if (instaMediaItemResponse != null && instaMediaItemResponse.Pk != null)
		{
			return instaMediaItemResponse;
		}
		return jToken.SelectToken("media")?.ToObject<InstaMediaItemResponse>();
	}

	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
		serializer.Serialize(writer, value);
	}
}
