using System;
using InstagramApiSharp.Classes.ResponseWrappers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InstagramApiSharp.Converters.Json;

internal class InstaFriendShipDataConverter : JsonConverter
{
	public override bool CanConvert(Type objectType)
	{
		return objectType == typeof(InstaFriendshipStatusResponse);
	}

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		JToken jToken = JToken.Load(reader);
		JToken jToken2 = jToken["friendship_status"];
		if (jToken2 != null)
		{
			return jToken2.ToObject<InstaFriendshipStatusResponse>();
		}
		return jToken.ToObject<InstaFriendshipStatusResponse>();
	}

	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
		serializer.Serialize(writer, value);
	}
}
