using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace xbot_wpf.Responses;

public class MicrosecondEpochConverter : DateTimeConverterBase
{
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
		throw new NotImplementedException();
	}

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		if (reader.get_Value() == null)
		{
			return null;
		}
		long num = long.Parse((string)reader.get_Value());
		return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(num);
	}

	public MicrosecondEpochConverter()
	{
		Class24.nhQmSIPz7n4eU();
		((DateTimeConverterBase)this)._002Ector();
	}
}
