using System;
using Newtonsoft.Json;

namespace xbot_wpf.Responses;

public class ClassOrBoleanConverter : JsonConverter
{
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
		throw new NotImplementedException();
	}

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		if ((int)reader.get_TokenType() == 1)
		{
			return serializer.Deserialize(reader, objectType);
		}
		return null;
	}

	public override bool CanConvert(Type objectType)
	{
		return false;
	}

	public ClassOrBoleanConverter()
	{
		Class24.nhQmSIPz7n4eU();
		((JsonConverter)this)._002Ector();
	}
}
