using System;
using System.Linq;
using InstagramApiSharp.Classes.Models.Business;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InstagramApiSharp.Converters.Json;

internal class InstaBusinessCityLocationDataConverter : JsonConverter
{
	public override bool CanConvert(Type objectType)
	{
		return objectType == typeof(InstaBusinessCityLocationList);
	}

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		return JToken.Load(reader).ToObject<InstaBusinessCityLocationContainer>().Extras.FirstOrDefault()!.Value["search_results"]!["nodes"]!.ToObject<InstaBusinessCityLocationList>();
	}

	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
		serializer.Serialize(writer, value);
	}
}
