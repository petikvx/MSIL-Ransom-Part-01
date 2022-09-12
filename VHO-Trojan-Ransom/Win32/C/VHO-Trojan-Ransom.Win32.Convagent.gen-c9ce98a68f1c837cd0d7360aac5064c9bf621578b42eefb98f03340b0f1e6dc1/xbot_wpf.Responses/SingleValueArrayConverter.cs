using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace xbot_wpf.Responses;

public class SingleValueArrayConverter<T> : JsonConverter
{
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
		throw new NotImplementedException();
	}

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Invalid comparison between Unknown and I4
		object result = new List<T>();
		if ((int)reader.get_TokenType() == 2)
		{
			result = serializer.Deserialize(reader, objectType);
		}
		return result;
	}

	public override bool CanConvert(Type objectType)
	{
		return false;
	}

	public SingleValueArrayConverter()
	{
		Class24.nhQmSIPz7n4eU();
		((JsonConverter)this)._002Ector();
	}
}
