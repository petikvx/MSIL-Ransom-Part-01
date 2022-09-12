using System;
using System.Collections.Generic;
using InstagramApiSharp.Classes.ResponseWrappers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InstagramApiSharp.Converters.Json;

internal class InstaUserPresenceContainerDataConverter : JsonConverter
{
	public override bool CanConvert(Type objectType)
	{
		return objectType == typeof(InstaUserPresenceContainerResponse);
	}

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		JToken jToken = JToken.Load(reader);
		InstaUserPresenceContainerResponse instaUserPresenceContainerResponse = jToken.ToObject<InstaUserPresenceContainerResponse>();
		InstaExtraResponse instaExtraResponse = (jToken?.SelectToken("user_presence"))!.ToObject<InstaExtraResponse>();
		try
		{
			foreach (KeyValuePair<string, JToken> extra in instaExtraResponse.Extras)
			{
				try
				{
					InstaUserPresenceResponse instaUserPresenceResponse = extra.Value.ToObject<InstaUserPresenceResponse>();
					instaUserPresenceResponse.Pk = long.Parse(extra.Key);
					instaUserPresenceContainerResponse.Items.Add(instaUserPresenceResponse);
				}
				catch
				{
				}
			}
			return instaUserPresenceContainerResponse;
		}
		catch
		{
			return instaUserPresenceContainerResponse;
		}
	}

	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
		serializer.Serialize(writer, value);
	}
}
