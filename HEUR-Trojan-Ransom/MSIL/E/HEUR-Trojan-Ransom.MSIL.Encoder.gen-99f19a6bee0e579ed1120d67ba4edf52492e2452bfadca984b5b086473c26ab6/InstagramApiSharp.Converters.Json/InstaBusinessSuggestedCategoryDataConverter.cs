using System;
using System.Linq;
using InstagramApiSharp.Classes.Models.Business;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InstagramApiSharp.Converters.Json;

internal class InstaBusinessSuggestedCategoryDataConverter : JsonConverter
{
	public override bool CanConvert(Type objectType)
	{
		return objectType == typeof(InstaBusinessSuggestedCategoryList);
	}

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		return JToken.Load(reader).ToObject<InstaBusinessCategoryContainer>().Extras.FirstOrDefault()!.Value["categories"]!.ToObject<InstaBusinessSuggestedCategoryList>();
	}

	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
		serializer.Serialize(writer, value);
	}
}
