using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Text;
using MySql.Data;
using MySqlX.Serialization;

namespace MySqlX.XDevAPI;

public class DbDoc
{
	internal Dictionary<string, object> values = new Dictionary<string, object>();

	public object this[string path] => GetValue(path);

	public object Id
	{
		get
		{
			return values["_id"];
		}
		internal set
		{
			SetValue("_id", value);
		}
	}

	public bool HasId => values.ContainsKey("_id");

	public DbDoc(object val = null)
	{
		if (val == null)
		{
			return;
		}
		try
		{
			if (val is string)
			{
				values = JsonParser.Parse(val as string);
			}
			else if (val is Dictionary<string, object>)
			{
				values = JsonParser.Parse(DictToString(val as Dictionary<string, object>, 2));
			}
			else if (val is DbDoc)
			{
				values = JsonParser.Parse(DictToString((val as DbDoc).values, 2));
			}
			else
			{
				values = ParseObject(val);
			}
		}
		catch (Exception ex)
		{
			throw new Exception(string.Format(ResourcesX.InvalidJsonDocument, ex.Message));
		}
	}

	private object GetValue(string path)
	{
		string[] array = path.Split(new char[1] { '.' });
		Dictionary<string, object> dictionary = values;
		object result = null;
		string[] array2 = array;
		int num = 0;
		while (true)
		{
			if (num < array2.Length)
			{
				string key = array2[num];
				if (dictionary.ContainsKey(key))
				{
					if (dictionary[key] is Dictionary<string, object>)
					{
						result = (dictionary = dictionary[key] as Dictionary<string, object>);
					}
					else
					{
						if (dictionary[key] == null)
						{
							break;
						}
						result = ((!dictionary[key].GetType().GetTypeInfo().IsGenericType) ? dictionary[key] : (dictionary = ParseObject(dictionary[key])));
					}
					num++;
					continue;
				}
				throw new InvalidOperationException(string.Format(ResourcesX.PathNotFound, path));
			}
			return result;
		}
		return null;
	}

	public void SetValue(string key, object val)
	{
		if (val is IList value)
		{
			values[key] = GetArrayValues(value);
		}
		else if (val is DbDoc)
		{
			values[key] = (val as DbDoc).values;
		}
		else if (val is Dictionary<string, object>)
		{
			values[key] = val;
		}
		else if (val != null && val.GetType().Namespace != "System")
		{
			values[key] = ParseObject(val);
		}
		else
		{
			values[key] = val;
		}
	}

	private Dictionary<string, object>[] GetArrayValues(IEnumerable value)
	{
		List<Dictionary<string, object>> list = new List<Dictionary<string, object>>();
		foreach (object item in value)
		{
			list.Add(ParseObject(item));
		}
		return list.ToArray();
	}

	public override string ToString()
	{
		return DictToString(values, 2);
	}

	private string DictToString(Dictionary<string, object> vals, int ident)
	{
		StringBuilder stringBuilder = new StringBuilder("{");
		string value = "";
		foreach (string key in vals.Keys)
		{
			stringBuilder.Append(value);
			stringBuilder.AppendLine();
			stringBuilder.Append(' ', ident);
			stringBuilder.AppendFormat("\"{0}\": {1}", key, GetValue(vals[key], ident) ?? "null");
			value = ", ";
		}
		stringBuilder.AppendLine();
		stringBuilder.Append(' ', ident - 2);
		stringBuilder.Append("}");
		return stringBuilder.ToString();
	}

	private string GetValue(object val, int ident)
	{
		if (val == null)
		{
			return null;
		}
		if (val.GetType().IsArray)
		{
			StringBuilder stringBuilder = new StringBuilder("[");
			string value = string.Empty;
			foreach (object item in (Array)val)
			{
				stringBuilder.Append(value);
				stringBuilder.AppendLine();
				stringBuilder.Append(' ', ident + 2);
				stringBuilder.Append(GetValue(item, ident + 2));
				value = ", ";
			}
			stringBuilder.AppendLine();
			stringBuilder.Append(' ', ident);
			stringBuilder.Append("]");
			return stringBuilder.ToString();
		}
		if (val is Dictionary<string, object>)
		{
			return DictToString(val as Dictionary<string, object>, ident + 2);
		}
		if (val is MySqlExpression)
		{
			return ((MySqlExpression)val).value;
		}
		string text = "";
		if (val is string || val is DateTime)
		{
			text = "\"";
		}
		return text + ((val is bool) ? val.ToString()!.ToLowerInvariant() : ((val is double num) ? num.ToString(CultureInfo.InvariantCulture) : val.ToString())) + text;
	}

	private bool CompareDictionaries<TKey, TValue>(Dictionary<TKey, TValue> dict1, Dictionary<TKey, TValue> dict2)
	{
		_ = EqualityComparer<TValue>.Default;
		if (dict1.Count != dict2.Count)
		{
			return false;
		}
		foreach (TKey key in dict1.Keys)
		{
			if (dict2.ContainsKey(key))
			{
				object obj = dict1[key];
				object obj2 = dict2[key];
				if (obj is Dictionary<TKey, TValue>[] && obj2 is Dictionary<TKey, TValue>[])
				{
					Dictionary<TKey, TValue>[] array = (Dictionary<TKey, TValue>[])obj;
					Dictionary<TKey, TValue>[] array2 = (Dictionary<TKey, TValue>[])obj2;
					if (array.Length != array2.Length)
					{
						return false;
					}
					for (int i = 0; i < array.Length; i++)
					{
						if (!CompareDictionaries(array[i], array2[i]))
						{
							return false;
						}
					}
				}
				else
				{
					if (obj is Dictionary<TKey, TValue> && obj2 is Dictionary<TKey, TValue>)
					{
						return CompareDictionaries((Dictionary<TKey, TValue>)obj, (Dictionary<TKey, TValue>)obj2);
					}
					if (!obj.Equals(obj2))
					{
						return false;
					}
				}
				continue;
			}
			return false;
		}
		return true;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is DbDoc))
		{
			throw new InvalidOperationException("DbDoc can only be compared with another DbDoc");
		}
		DbDoc dbDoc = obj as DbDoc;
		return CompareDictionaries(values, dbDoc.values);
	}

	public override int GetHashCode()
	{
		return base.GetHashCode();
	}

	private Dictionary<string, object> ParseObject(object val)
	{
		Type type = val.GetType();
		bool num = type.Name.Contains("Anonymous");
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		PropertyInfo[] array = (num ? type.GetProperties() : type.GetProperties(BindingFlags.Public));
		foreach (PropertyInfo propertyInfo in array)
		{
			dictionary.Add(propertyInfo.Name, propertyInfo.GetValue(val, null));
		}
		return dictionary;
	}
}
