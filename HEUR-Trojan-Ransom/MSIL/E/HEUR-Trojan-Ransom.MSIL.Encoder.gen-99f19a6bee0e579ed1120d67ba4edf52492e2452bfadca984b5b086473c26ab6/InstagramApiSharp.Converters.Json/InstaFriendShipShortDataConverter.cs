using System;
using System.Collections.Generic;
using System.Linq;
using InstagramApiSharp.Classes.ResponseWrappers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InstagramApiSharp.Converters.Json;

internal class InstaFriendShipShortDataConverter : JsonConverter
{
	public override bool CanConvert(Type objectType)
	{
		return objectType == typeof(InstaFriendshipShortStatusListResponse);
	}

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		JToken? jToken = JToken.Load(reader)["friendship_statuses"];
		InstaFriendshipShortStatusListResponse instaFriendshipShortStatusListResponse = new InstaFriendshipShortStatusListResponse();
		InstaExtraResponse instaExtraResponse = jToken!.ToObject<InstaExtraResponse>();
		if (instaExtraResponse != null && instaExtraResponse.Extras != null && instaExtraResponse.Extras.Any())
		{
			foreach (KeyValuePair<string, JToken> extra in instaExtraResponse.Extras)
			{
				try
				{
					InstaFriendshipShortStatusResponse instaFriendshipShortStatusResponse = extra.Value.ToObject<InstaFriendshipShortStatusResponse>();
					instaFriendshipShortStatusResponse.Pk = long.Parse(extra.Key);
					instaFriendshipShortStatusListResponse.Add(instaFriendshipShortStatusResponse);
				}
				catch
				{
				}
			}
			return instaFriendshipShortStatusListResponse;
		}
		return instaFriendshipShortStatusListResponse;
	}

	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
		serializer.Serialize(writer, value);
	}
}
