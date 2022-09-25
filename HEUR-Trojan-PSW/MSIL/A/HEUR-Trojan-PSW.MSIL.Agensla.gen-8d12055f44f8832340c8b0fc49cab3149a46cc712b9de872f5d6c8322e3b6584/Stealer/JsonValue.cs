using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;

namespace Stealer;

public abstract class JsonValue : IEnumerable
{
	public virtual int Count
	{
		get
		{
			throw new InvalidOperationException();
		}
	}

	public abstract JsonType JsonType { get; }

	public virtual JsonValue this[int index]
	{
		get
		{
			throw new InvalidOperationException();
		}
		set
		{
			throw new InvalidOperationException();
		}
	}

	public virtual JsonValue this[string key]
	{
		get
		{
			throw new InvalidOperationException();
		}
		set
		{
			throw new InvalidOperationException();
		}
	}

	public static JsonValue Load(Stream stream)
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		return Load(new StreamReader(stream, detectEncodingFromByteOrderMarks: true));
	}

	public static JsonValue Load(TextReader textReader)
	{
		if (textReader == null)
		{
			throw new ArgumentNullException("textReader");
		}
		return ToJsonValue(new JavaScriptReader(textReader).Read());
	}

	private static IEnumerable<KeyValuePair<string, JsonValue>> ToJsonPairEnumerable(IEnumerable<KeyValuePair<string, object>> kvpc)
	{
		foreach (KeyValuePair<string, object> item in kvpc)
		{
			yield return new KeyValuePair<string, JsonValue>(item.Key, ToJsonValue(item.Value));
		}
	}

	private static IEnumerable<JsonValue> ToJsonValueEnumerable(IEnumerable arr)
	{
		foreach (object item in arr)
		{
			yield return ToJsonValue(item);
		}
	}

	public static JsonValue ToJsonValue<T>(T ret)
	{
		if (ret == null)
		{
			return null;
		}
		T val;
		if ((val = ret) is bool)
		{
			return new JsonPrimitive((bool)(object)val);
		}
		if ((val = ret) is byte)
		{
			return new JsonPrimitive((byte)(object)val);
		}
		if ((val = ret) is char)
		{
			return new JsonPrimitive((char)(object)val);
		}
		if ((val = ret) is decimal)
		{
			return new JsonPrimitive((decimal)(object)val);
		}
		if ((val = ret) is double)
		{
			return new JsonPrimitive((double)(object)val);
		}
		if ((val = ret) is float)
		{
			return new JsonPrimitive((float)(object)val);
		}
		if ((val = ret) is int)
		{
			return new JsonPrimitive((int)(object)val);
		}
		if ((val = ret) is long)
		{
			return new JsonPrimitive((long)(object)val);
		}
		if ((val = ret) is sbyte)
		{
			return new JsonPrimitive((sbyte)(object)val);
		}
		if ((val = ret) is short)
		{
			return new JsonPrimitive((short)(object)val);
		}
		if ((object)ret is string value)
		{
			return new JsonPrimitive(value);
		}
		if ((val = ret) is uint)
		{
			return new JsonPrimitive((uint)(object)val);
		}
		if ((val = ret) is ulong)
		{
			return new JsonPrimitive((ulong)(object)val);
		}
		if ((val = ret) is ushort)
		{
			return new JsonPrimitive((ushort)(object)val);
		}
		if ((val = ret) is DateTime)
		{
			return new JsonPrimitive((DateTime)(object)val);
		}
		if ((val = ret) is DateTimeOffset)
		{
			return new JsonPrimitive((DateTimeOffset)(object)val);
		}
		if ((val = ret) is Guid)
		{
			return new JsonPrimitive((Guid)(object)val);
		}
		if ((val = ret) is TimeSpan)
		{
			return new JsonPrimitive((TimeSpan)(object)val);
		}
		if ((object)ret is Uri value2)
		{
			return new JsonPrimitive(value2);
		}
		if ((object)ret is IEnumerable<KeyValuePair<string, object>> kvpc)
		{
			return new JsonObject(ToJsonPairEnumerable(kvpc));
		}
		if ((object)ret is IEnumerable arr)
		{
			return new JsonArray(ToJsonValueEnumerable(arr));
		}
		if (!(ret is IEnumerable))
		{
			PropertyInfo[] properties = ret.GetType().GetProperties();
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			PropertyInfo[] array = properties;
			foreach (PropertyInfo propertyInfo in array)
			{
				dictionary.Add(propertyInfo.Name, propertyInfo.GetValue(ret, null).IsNull("null"));
			}
			if (dictionary.Count > 0)
			{
				return new JsonObject(ToJsonPairEnumerable(dictionary));
			}
		}
		throw new NotSupportedException($"Unexpected parser return type: {ret.GetType()}");
	}

	public static JsonValue Parse(string jsonString)
	{
		if (jsonString == null)
		{
			throw new ArgumentNullException("jsonString");
		}
		return Load(new StringReader(jsonString));
	}

	public virtual bool ContainsKey(string key)
	{
		throw new InvalidOperationException();
	}

	public virtual void Save(Stream stream, bool parsing)
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		Save(new StreamWriter(stream), parsing);
	}

	public virtual void Save(TextWriter textWriter, bool parsing)
	{
		if (textWriter == null)
		{
			throw new ArgumentNullException("textWriter");
		}
		Savepublic(textWriter, parsing);
	}

	private void Savepublic(TextWriter w, bool saving)
	{
		switch (JsonType)
		{
		case JsonType.String:
			if (saving)
			{
				w.Write('"');
			}
			w.Write(EscapeString(((JsonPrimitive)this).GetFormattedString()));
			if (saving)
			{
				w.Write('"');
			}
			break;
		default:
			w.Write(((JsonPrimitive)this).GetFormattedString());
			break;
		case JsonType.Object:
		{
			w.Write('{');
			bool flag = false;
			foreach (KeyValuePair<string, JsonValue> item in (JsonObject)this)
			{
				if (flag)
				{
					w.Write(", ");
				}
				w.Write('"');
				w.Write(EscapeString(item.Key));
				w.Write("\": ");
				if (item.Value == null)
				{
					w.Write("null");
				}
				else
				{
					item.Value.Savepublic(w, saving);
				}
				flag = true;
			}
			w.Write('}');
			break;
		}
		case JsonType.Array:
		{
			w.Write('[');
			bool flag2 = false;
			foreach (JsonValue item2 in (IEnumerable<JsonValue>)(JsonArray)this)
			{
				if (flag2)
				{
					w.Write(", ");
				}
				if (item2 != null)
				{
					item2.Savepublic(w, saving);
				}
				else
				{
					w.Write("null");
				}
				flag2 = true;
			}
			w.Write(']');
			break;
		}
		case JsonType.Boolean:
			w.Write(this ? "true" : "false");
			break;
		}
	}

	public string ToString(bool saving = true)
	{
		StringWriter stringWriter = new StringWriter();
		Save(stringWriter, saving);
		return stringWriter.ToString();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		throw new InvalidOperationException();
	}

	private bool NeedEscape(string src, int i)
	{
		char c = src[i];
		if (c >= ' ' && c != '"' && c != '\\' && (c < '\ud800' || c > '\udbff' || (i != src.Length - 1 && src[i + 1] >= '\udc00' && src[i + 1] <= '\udfff')) && (c < '\udc00' || c > '\udfff' || (i != 0 && src[i - 1] >= '\ud800' && src[i - 1] <= '\udbff')) && c != '\u2028' && c != '\u2029')
		{
			if (c == '/' && i > 0)
			{
				return src[i - 1] == '<';
			}
			return false;
		}
		return true;
	}

	public string EscapeString(string src)
	{
		if (src == null)
		{
			return null;
		}
		int num = 0;
		while (true)
		{
			if (num < src.Length)
			{
				if (NeedEscape(src, num))
				{
					break;
				}
				num++;
				continue;
			}
			return src;
		}
		StringBuilder stringBuilder = new StringBuilder();
		if (num > 0)
		{
			stringBuilder.Append(src, 0, num);
		}
		return DoEscapeString(stringBuilder, src, num);
	}

	private string DoEscapeString(StringBuilder sb, string src, int cur)
	{
		int num = cur;
		for (int i = cur; i < src.Length; i++)
		{
			if (NeedEscape(src, i))
			{
				sb.Append(src, num, i - num);
				switch (src[i])
				{
				case '"':
					sb.Append("\\\"");
					break;
				case '\b':
					sb.Append("\\b");
					break;
				case '\t':
					sb.Append("\\t");
					break;
				case '\n':
					sb.Append("\\n");
					break;
				case '\f':
					sb.Append("\\f");
					break;
				case '\r':
					sb.Append("\\r");
					break;
				default:
					sb.Append("\\u");
					sb.Append(((int)src[i]).ToString("x04"));
					break;
				case '\\':
					sb.Append("\\\\");
					break;
				case '/':
					sb.Append("\\/");
					break;
				}
				num = i + 1;
			}
		}
		sb.Append(src, num, src.Length - num);
		return sb.ToString();
	}

	public static implicit operator JsonValue(bool value)
	{
		return new JsonPrimitive(value);
	}

	public static implicit operator JsonValue(byte value)
	{
		return new JsonPrimitive(value);
	}

	public static implicit operator JsonValue(char value)
	{
		return new JsonPrimitive(value);
	}

	public static implicit operator JsonValue(decimal value)
	{
		return new JsonPrimitive(value);
	}

	public static implicit operator JsonValue(double value)
	{
		return new JsonPrimitive(value);
	}

	public static implicit operator JsonValue(float value)
	{
		return new JsonPrimitive(value);
	}

	public static implicit operator JsonValue(int value)
	{
		return new JsonPrimitive(value);
	}

	public static implicit operator JsonValue(long value)
	{
		return new JsonPrimitive(value);
	}

	public static implicit operator JsonValue(sbyte value)
	{
		return new JsonPrimitive(value);
	}

	public static implicit operator JsonValue(short value)
	{
		return new JsonPrimitive(value);
	}

	public static implicit operator JsonValue(string value)
	{
		return new JsonPrimitive(value);
	}

	public static implicit operator JsonValue(uint value)
	{
		return new JsonPrimitive(value);
	}

	public static implicit operator JsonValue(ulong value)
	{
		return new JsonPrimitive(value);
	}

	public static implicit operator JsonValue(ushort value)
	{
		return new JsonPrimitive(value);
	}

	public static implicit operator JsonValue(DateTime value)
	{
		return new JsonPrimitive(value);
	}

	public static implicit operator JsonValue(DateTimeOffset value)
	{
		return new JsonPrimitive(value);
	}

	public static implicit operator JsonValue(Guid value)
	{
		return new JsonPrimitive(value);
	}

	public static implicit operator JsonValue(TimeSpan value)
	{
		return new JsonPrimitive(value);
	}

	public static implicit operator JsonValue(Uri value)
	{
		return new JsonPrimitive(value);
	}

	public static implicit operator bool(JsonValue value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		return Convert.ToBoolean(((JsonPrimitive)value).Value, NumberFormatInfo.InvariantInfo);
	}

	public static implicit operator byte(JsonValue value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		return Convert.ToByte(((JsonPrimitive)value).Value, NumberFormatInfo.InvariantInfo);
	}

	public static implicit operator char(JsonValue value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		return Convert.ToChar(((JsonPrimitive)value).Value, NumberFormatInfo.InvariantInfo);
	}

	public static implicit operator decimal(JsonValue value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		return Convert.ToDecimal(((JsonPrimitive)value).Value, NumberFormatInfo.InvariantInfo);
	}

	public static implicit operator double(JsonValue value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		return Convert.ToDouble(((JsonPrimitive)value).Value, NumberFormatInfo.InvariantInfo);
	}

	public static implicit operator float(JsonValue value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		return Convert.ToSingle(((JsonPrimitive)value).Value, NumberFormatInfo.InvariantInfo);
	}

	public static implicit operator int(JsonValue value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		return Convert.ToInt32(((JsonPrimitive)value).Value, NumberFormatInfo.InvariantInfo);
	}

	public static implicit operator long(JsonValue value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		return Convert.ToInt64(((JsonPrimitive)value).Value, NumberFormatInfo.InvariantInfo);
	}

	public static implicit operator sbyte(JsonValue value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		return Convert.ToSByte(((JsonPrimitive)value).Value, NumberFormatInfo.InvariantInfo);
	}

	public static implicit operator short(JsonValue value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		return Convert.ToInt16(((JsonPrimitive)value).Value, NumberFormatInfo.InvariantInfo);
	}

	public static implicit operator string(JsonValue value)
	{
		return value?.ToString();
	}

	public static implicit operator uint(JsonValue value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		return Convert.ToUInt32(((JsonPrimitive)value).Value, NumberFormatInfo.InvariantInfo);
	}

	public static implicit operator ulong(JsonValue value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		return Convert.ToUInt64(((JsonPrimitive)value).Value, NumberFormatInfo.InvariantInfo);
	}

	public static implicit operator ushort(JsonValue value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		return Convert.ToUInt16(((JsonPrimitive)value).Value, NumberFormatInfo.InvariantInfo);
	}

	public static implicit operator DateTime(JsonValue value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		return (DateTime)((JsonPrimitive)value).Value;
	}

	public static implicit operator DateTimeOffset(JsonValue value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		return (DateTimeOffset)((JsonPrimitive)value).Value;
	}

	public static implicit operator TimeSpan(JsonValue value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		return (TimeSpan)((JsonPrimitive)value).Value;
	}

	public static implicit operator Guid(JsonValue value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		return (Guid)((JsonPrimitive)value).Value;
	}

	public static implicit operator Uri(JsonValue value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		return (Uri)((JsonPrimitive)value).Value;
	}
}
