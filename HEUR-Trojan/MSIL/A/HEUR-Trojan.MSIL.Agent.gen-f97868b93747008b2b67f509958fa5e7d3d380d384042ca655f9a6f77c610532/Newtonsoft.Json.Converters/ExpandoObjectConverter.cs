using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters;

public class ExpandoObjectConverter : JsonConverter
{
	public override bool CanWrite => false;

	public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
	{
	}

	public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
	{
		return ReadValue(reader);
	}

	private object? ReadValue(JsonReader reader)
	{
		if (!reader.MoveToContent())
		{
			throw JsonSerializationException.Create(reader, "Unexpected end when reading ExpandoObject.");
		}
		switch (reader.TokenType)
		{
		default:
			if (JsonTokenUtils.IsPrimitiveToken(reader.TokenType))
			{
				return reader.Value;
			}
			throw JsonSerializationException.Create(reader, "Unexpected token when converting ExpandoObject: {0}".FormatWith(CultureInfo.InvariantCulture, reader.TokenType));
		case JsonToken.StartArray:
			return ReadList(reader);
		case JsonToken.StartObject:
			return ReadObject(reader);
		}
	}

	private object ReadList(JsonReader reader)
	{
		IList<object> list = new List<object>();
		while (reader.Read())
		{
			switch (reader.TokenType)
			{
			case JsonToken.Comment:
				continue;
			case JsonToken.EndArray:
				return list;
			}
			object item = ReadValue(reader);
			list.Add(item);
		}
		throw JsonSerializationException.Create(reader, "Unexpected end when reading ExpandoObject.");
	}

	private object ReadObject(JsonReader reader)
	{
		IDictionary<string, object> dictionary = new ExpandoObject();
		while (reader.Read())
		{
			switch (reader.TokenType)
			{
			case JsonToken.PropertyName:
			{
				string key = reader.Value!.ToString();
				if (!reader.Read())
				{
					throw JsonSerializationException.Create(reader, "Unexpected end when reading ExpandoObject.");
				}
				object obj2 = (dictionary[key] = ReadValue(reader));
				break;
			}
			case JsonToken.EndObject:
				return dictionary;
			}
		}
		throw JsonSerializationException.Create(reader, "Unexpected end when reading ExpandoObject.");
	}

	public override bool CanConvert(Type objectType)
	{
		return objectType == typeof(ExpandoObject);
	}
}
