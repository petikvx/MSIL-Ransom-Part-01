using System;
using System.Collections.Generic;
using System.Linq;
using InstagramApiSharp.Classes.ResponseWrappers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InstagramApiSharp.Converters.Json;

internal class InstaHashtagSearchDataConverter : JsonConverter
{
	public override bool CanConvert(Type objectType)
	{
		return objectType == typeof(InstaHashtagSearchResponse);
	}

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		JToken jToken = JToken.Load(reader);
		JToken jToken2 = jToken["results"];
		InstaHashtagSearchResponse instaHashtagSearchResponse = jToken.ToObject<InstaHashtagSearchResponse>();
		if (jToken2 != null && jToken2.Any())
		{
			foreach (JToken item in (IEnumerable<JToken>)jToken2)
			{
				try
				{
					instaHashtagSearchResponse.Tags.Add(item.ToObject<InstaHashtagResponse>());
				}
				catch
				{
				}
			}
			return instaHashtagSearchResponse;
		}
		return instaHashtagSearchResponse;
	}

	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
		serializer.Serialize(writer, value);
	}
}
