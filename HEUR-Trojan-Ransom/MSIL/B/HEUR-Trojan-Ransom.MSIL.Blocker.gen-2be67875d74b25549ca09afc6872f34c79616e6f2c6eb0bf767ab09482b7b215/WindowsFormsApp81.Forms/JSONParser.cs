using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;

namespace WindowsFormsApp81.Forms;

public static class JSONParser
{
	[ThreadStatic]
	private static Stack<List<string>> splitArrayPool;

	[ThreadStatic]
	private static StringBuilder stringBuilder;

	[ThreadStatic]
	private static Dictionary<Type, Dictionary<string, FieldInfo>> fieldInfoCache;

	[ThreadStatic]
	private static Dictionary<Type, Dictionary<string, PropertyInfo>> propertyInfoCache;

	public static T FromJson<T>(this string json)
	{
		if (propertyInfoCache == null)
		{
			propertyInfoCache = new Dictionary<Type, Dictionary<string, PropertyInfo>>();
		}
		if (fieldInfoCache == null)
		{
			fieldInfoCache = new Dictionary<Type, Dictionary<string, FieldInfo>>();
		}
		if (stringBuilder == null)
		{
			stringBuilder = new StringBuilder();
		}
		if (splitArrayPool == null)
		{
			splitArrayPool = new Stack<List<string>>();
		}
		stringBuilder.Length = 0;
		for (int i = 0; i < json.Length; i++)
		{
			char c = json[i];
			if (c == '"')
			{
				i = AppendUntilStringEnd(appendEscapeCharacter: true, i, json);
			}
			else if (!char.IsWhiteSpace(c))
			{
				stringBuilder.Append(c);
			}
		}
		return (T)ParseValue(typeof(T), stringBuilder.ToString());
	}

	private static int AppendUntilStringEnd(bool appendEscapeCharacter, int startIdx, string json)
	{
		stringBuilder.Append(json[startIdx]);
		int num = startIdx + 1;
		while (true)
		{
			if (num < json.Length)
			{
				if (json[num] == '\\')
				{
					if (appendEscapeCharacter)
					{
						stringBuilder.Append(json[num]);
					}
					stringBuilder.Append(json[num + 1]);
					num++;
				}
				else
				{
					if (json[num] == '"')
					{
						break;
					}
					stringBuilder.Append(json[num]);
				}
				num++;
				continue;
			}
			return json.Length - 1;
		}
		stringBuilder.Append(json[num]);
		return num;
	}

	private static List<string> Split(string json)
	{
		List<string> list = ((splitArrayPool.Count > 0) ? splitArrayPool.Pop() : new List<string>());
		list.Clear();
		if (json.Length == 2)
		{
			return list;
		}
		int num = 0;
		stringBuilder.Length = 0;
		for (int i = 1; i < json.Length - 1; i++)
		{
			switch (json[i])
			{
			case ',':
			case ':':
				if (num == 0)
				{
					list.Add(stringBuilder.ToString());
					stringBuilder.Length = 0;
					continue;
				}
				break;
			case '"':
				i = AppendUntilStringEnd(appendEscapeCharacter: true, i, json);
				continue;
			case ']':
			case '}':
				num--;
				break;
			case '[':
			case '{':
				num++;
				break;
			}
			stringBuilder.Append(json[i]);
		}
		list.Add(stringBuilder.ToString());
		return list;
	}

	internal static object ParseValue(Type type, string json)
	{
		if (type == typeof(string))
		{
			if (json.Length <= 2)
			{
				return string.Empty;
			}
			StringBuilder stringBuilder = new StringBuilder(json.Length);
			for (int i = 1; i < json.Length - 1; i++)
			{
				if (json[i] == '\\' && i + 1 < json.Length - 1)
				{
					int num = "\"\\nrtbf/".IndexOf(json[i + 1]);
					if (num >= 0)
					{
						stringBuilder.Append("\"\\\n\r\t\b\f/"[num]);
						i++;
						continue;
					}
					if (json[i + 1] == 'u' && i + 5 < json.Length - 1)
					{
						uint result = 0u;
						if (uint.TryParse(json.Substring(i + 2, 4), NumberStyles.AllowHexSpecifier, null, out result))
						{
							stringBuilder.Append((char)result);
							i += 5;
							continue;
						}
					}
				}
				stringBuilder.Append(json[i]);
			}
			return stringBuilder.ToString();
		}
		if (type.IsPrimitive)
		{
			return Convert.ChangeType(json, type, CultureInfo.InvariantCulture);
		}
		if (type == typeof(decimal))
		{
			decimal.TryParse(json, NumberStyles.Float, CultureInfo.InvariantCulture, out var result2);
			return result2;
		}
		if (type == typeof(DateTime))
		{
			DateTime.TryParse(json.Replace("\"", ""), CultureInfo.InvariantCulture, DateTimeStyles.None, out var result3);
			return result3;
		}
		if (json == "null")
		{
			return null;
		}
		if (type.IsEnum)
		{
			if (json[0] == '"')
			{
				json = json.Substring(1, json.Length - 2);
			}
			try
			{
				return Enum.Parse(type, json, ignoreCase: false);
			}
			catch
			{
				return 0;
			}
		}
		if (type.IsArray)
		{
			Type elementType = type.GetElementType();
			if (json[0] == '[' && json[json.Length - 1] == ']')
			{
				List<string> list = Split(json);
				Array array = Array.CreateInstance(elementType, list.Count);
				for (int j = 0; j < list.Count; j++)
				{
					array.SetValue(ParseValue(elementType, list[j]), j);
				}
				splitArrayPool.Push(list);
				return array;
			}
			return null;
		}
		if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(List<>))
		{
			Type type2 = type.GetGenericArguments()[0];
			if (json[0] == '[' && json[json.Length - 1] == ']')
			{
				List<string> list2 = Split(json);
				IList list3 = (IList)type.GetConstructor(new Type[1] { typeof(int) })!.Invoke(new object[1] { list2.Count });
				for (int k = 0; k < list2.Count; k++)
				{
					list3.Add(ParseValue(type2, list2[k]));
				}
				splitArrayPool.Push(list2);
				return list3;
			}
			return null;
		}
		if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Dictionary<, >))
		{
			Type[] genericArguments = type.GetGenericArguments();
			Type type3 = genericArguments[0];
			Type type4 = genericArguments[1];
			if (type3 != typeof(string))
			{
				return null;
			}
			if (json[0] == '{' && json[json.Length - 1] == '}')
			{
				List<string> list4 = Split(json);
				if (list4.Count % 2 != 0)
				{
					return null;
				}
				IDictionary dictionary = (IDictionary)type.GetConstructor(new Type[1] { typeof(int) })!.Invoke(new object[1] { list4.Count / 2 });
				for (int l = 0; l < list4.Count; l += 2)
				{
					if (list4[l].Length > 2)
					{
						string key = list4[l].Substring(1, list4[l].Length - 2);
						object obj3 = (dictionary[key] = ParseValue(type4, list4[l + 1]));
					}
				}
				return dictionary;
			}
			return null;
		}
		if (type == typeof(object))
		{
			return ParseAnonymousValue(json);
		}
		if (json[0] == '{' && json[json.Length - 1] == '}')
		{
			return ParseObject(type, json);
		}
		return null;
	}

	private static object ParseAnonymousValue(string json)
	{
		if (json.Length == 0)
		{
			return null;
		}
		if (json[0] == '{' && json[json.Length - 1] == '}')
		{
			List<string> list = Split(json);
			if (list.Count % 2 != 0)
			{
				return null;
			}
			Dictionary<string, object> dictionary = new Dictionary<string, object>(list.Count / 2);
			for (int i = 0; i < list.Count; i += 2)
			{
				dictionary[list[i].Substring(1, list[i].Length - 2)] = ParseAnonymousValue(list[i + 1]);
			}
			return dictionary;
		}
		if (json[0] == '[' && json[json.Length - 1] == ']')
		{
			List<string> list2 = Split(json);
			List<object> list3 = new List<object>(list2.Count);
			for (int j = 0; j < list2.Count; j++)
			{
				list3.Add(ParseAnonymousValue(list2[j]));
			}
			return list3;
		}
		if (json[0] == '"' && json[json.Length - 1] == '"')
		{
			return json.Substring(1, json.Length - 2).Replace("\\", string.Empty);
		}
		if (!char.IsDigit(json[0]) && json[0] != '-')
		{
			if (json == "true")
			{
				return true;
			}
			if (json == "false")
			{
				return false;
			}
			return null;
		}
		if (json.Contains("."))
		{
			double.TryParse(json, NumberStyles.Float, CultureInfo.InvariantCulture, out var result);
			return result;
		}
		int.TryParse(json, out var result2);
		return result2;
	}

	private static Dictionary<string, T> CreateMemberNameDictionary<T>(T[] members) where T : MemberInfo
	{
		Dictionary<string, T> dictionary = new Dictionary<string, T>(StringComparer.OrdinalIgnoreCase);
		foreach (T val in members)
		{
			if (val.IsDefined(typeof(IgnoreDataMemberAttribute), inherit: true))
			{
				continue;
			}
			string name = val.Name;
			if (val.IsDefined(typeof(DataMemberAttribute), inherit: true))
			{
				DataMemberAttribute dataMemberAttribute = (DataMemberAttribute)Attribute.GetCustomAttribute(val, typeof(DataMemberAttribute), inherit: true);
				if (!string.IsNullOrEmpty(dataMemberAttribute.Name))
				{
					name = dataMemberAttribute.Name;
				}
			}
			dictionary.Add(name, val);
		}
		return dictionary;
	}

	private static object ParseObject(Type type, string json)
	{
		object uninitializedObject = FormatterServices.GetUninitializedObject(type);
		List<string> list = Split(json);
		if (list.Count % 2 != 0)
		{
			return uninitializedObject;
		}
		if (!fieldInfoCache.TryGetValue(type, out var value))
		{
			value = CreateMemberNameDictionary(type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.FlattenHierarchy));
			fieldInfoCache.Add(type, value);
		}
		if (!propertyInfoCache.TryGetValue(type, out var value2))
		{
			value2 = CreateMemberNameDictionary(type.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.FlattenHierarchy));
			propertyInfoCache.Add(type, value2);
		}
		for (int i = 0; i < list.Count; i += 2)
		{
			if (list[i].Length > 2)
			{
				string key = list[i].Substring(1, list[i].Length - 2);
				string json2 = list[i + 1];
				PropertyInfo value4;
				if (value.TryGetValue(key, out var value3))
				{
					value3.SetValue(uninitializedObject, ParseValue(value3.FieldType, json2));
				}
				else if (value2.TryGetValue(key, out value4))
				{
					value4.SetValue(uninitializedObject, ParseValue(value4.PropertyType, json2), null);
				}
			}
		}
		return uninitializedObject;
	}
}
