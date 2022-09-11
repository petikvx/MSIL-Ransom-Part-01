using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns10;
using ns12;
using ns19;

namespace ns20;

internal sealed class Class43
{
	internal Dictionary<string, object> dictionary_0 = new Dictionary<string, object>();

	[NonSerialized]
	internal static GetString getString_0;

	public object this[string string_0] => method_1(string_0);

	public object Id
	{
		get
		{
			return dictionary_0[getString_0(107408342)];
		}
		internal set
		{
			method_2(getString_0(107408342), value);
		}
	}

	public bool HasId => dictionary_0.ContainsKey(getString_0(107408342));

	public Class43(object object_0 = null)
	{
		if (object_0 != null)
		{
			if (object_0 is string)
			{
				dictionary_0 = Class82.smethod_0(object_0 as string);
			}
			else if (object_0 is Dictionary<string, object>)
			{
				dictionary_0 = Class82.smethod_0(method_4(object_0 as Dictionary<string, object>, 2));
			}
			else if (object_0 is Class43)
			{
				dictionary_0 = Class82.smethod_0(method_4((object_0 as Class43).dictionary_0, 2));
			}
			else
			{
				dictionary_0 = method_7(object_0);
			}
		}
	}

	internal void method_0()
	{
		if (HasId)
		{
			return;
		}
		char c = '-';
		string[] array = Guid.NewGuid().ToString().Split(new char[1] { '-' });
		string text = string.Empty;
		for (int num = array.Length - 1; num >= 0; num--)
		{
			text += array[num];
			if (num != 0)
			{
				text += c;
			}
		}
		method_2(getString_0(107408342), text.Replace(c.ToString(), string.Empty));
	}

	private object method_1(string string_0)
	{
		string[] array = string_0.Split(new char[1] { '.' });
		Dictionary<string, object> dictionary = dictionary_0;
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
						result = ((!dictionary[key].GetType().GetTypeInfo().IsGenericType) ? dictionary[key] : (dictionary = method_7(dictionary[key])));
					}
					num++;
					continue;
				}
				throw new InvalidOperationException(string.Format(Class122.PathNotFound, string_0));
			}
			return result;
		}
		return null;
	}

	public void method_2(string string_0, object object_0)
	{
		if (object_0 is IList ienumerable_)
		{
			dictionary_0[string_0] = method_3(ienumerable_);
		}
		else if (object_0 is Class43)
		{
			dictionary_0[string_0] = (object_0 as Class43).dictionary_0;
		}
		else if (object_0 is Dictionary<string, object>)
		{
			dictionary_0[string_0] = object_0;
		}
		else if (object_0 != null && object_0.GetType().Namespace != getString_0(107408657))
		{
			dictionary_0[string_0] = method_7(object_0);
		}
		else
		{
			dictionary_0[string_0] = object_0;
		}
	}

	private Dictionary<string, object>[] method_3(IEnumerable ienumerable_0)
	{
		List<Dictionary<string, object>> list = new List<Dictionary<string, object>>();
		foreach (object item in ienumerable_0)
		{
			list.Add(method_7(item));
		}
		return list.ToArray();
	}

	string object.ToString()
	{
		return method_4(dictionary_0, 2);
	}

	private string method_4(Dictionary<string, object> dictionary_1, int int_0)
	{
		StringBuilder stringBuilder = new StringBuilder(getString_0(107408648));
		string value = getString_0(107397467);
		foreach (string key in dictionary_1.Keys)
		{
			stringBuilder.Append(value);
			stringBuilder.AppendLine();
			stringBuilder.Append(' ', int_0);
			stringBuilder.AppendFormat(getString_0(107408611), key, method_5(dictionary_1[key], int_0) ?? getString_0(107408626));
			value = getString_0(107408617);
		}
		stringBuilder.AppendLine();
		stringBuilder.Append(' ', int_0 - 2);
		stringBuilder.Append(getString_0(107408580));
		return stringBuilder.ToString();
	}

	private string method_5(object object_0, int int_0)
	{
		if (object_0 == null)
		{
			return null;
		}
		if (object_0.GetType().IsArray)
		{
			StringBuilder stringBuilder = new StringBuilder(getString_0(107409218));
			string value = string.Empty;
			foreach (object item in (Array)object_0)
			{
				stringBuilder.Append(value);
				stringBuilder.AppendLine();
				stringBuilder.Append(' ', int_0 + 2);
				stringBuilder.Append(method_5(item, int_0 + 2));
				value = getString_0(107408617);
			}
			stringBuilder.AppendLine();
			stringBuilder.Append(' ', int_0);
			stringBuilder.Append(getString_0(107409213));
			return stringBuilder.ToString();
		}
		if (object_0 is Dictionary<string, object>)
		{
			return method_4(object_0 as Dictionary<string, object>, int_0 + 2);
		}
		if (object_0 is Class45)
		{
			return ((Class45)object_0).string_0;
		}
		string text = getString_0(107397467);
		if (object_0 is string || object_0 is DateTime)
		{
			text = getString_0(107408351);
		}
		return text + ((object_0 is bool) ? object_0.ToString()!.ToLowerInvariant() : object_0.ToString()) + text;
	}

	private bool method_6<T, U>(Dictionary<T, U> dictionary_1, Dictionary<T, U> dictionary_2)
	{
		_ = EqualityComparer<U>.Default;
		if (dictionary_1.Count != dictionary_2.Count)
		{
			return false;
		}
		foreach (T key in dictionary_1.Keys)
		{
			if (dictionary_2.ContainsKey(key))
			{
				object obj = dictionary_1[key];
				object obj2 = dictionary_2[key];
				if (obj is Dictionary<T, U>[] && obj2 is Dictionary<T, U>[])
				{
					Dictionary<T, U>[] array = (Dictionary<T, U>[])obj;
					Dictionary<T, U>[] array2 = (Dictionary<T, U>[])obj2;
					if (array.Length != array2.Length)
					{
						return false;
					}
					for (int i = 0; i < array.Length; i++)
					{
						if (!method_6(array[i], array2[i]))
						{
							return false;
						}
					}
				}
				else
				{
					if (obj is Dictionary<T, U> && obj2 is Dictionary<T, U>)
					{
						return method_6((Dictionary<T, U>)obj, (Dictionary<T, U>)obj2);
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

	bool object.Equals(object obj)
	{
		if (!(obj is Class43))
		{
			throw new InvalidOperationException(getString_0(107408575));
		}
		Class43 @class = obj as Class43;
		return method_6(dictionary_0, @class.dictionary_0);
	}

	int object.GetHashCode()
	{
		return base.GetHashCode();
	}

	private Dictionary<string, object> method_7(object object_0)
	{
		Type type = object_0.GetType();
		bool num = type.Name.Contains(getString_0(107408514));
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		PropertyInfo[] array = (num ? type.GetProperties() : type.GetProperties(BindingFlags.Public));
		foreach (PropertyInfo propertyInfo in array)
		{
			dictionary.Add(propertyInfo.Name, propertyInfo.GetValue(object_0, null));
		}
		return dictionary;
	}

	static Class43()
	{
		Strings.CreateGetStringDelegate(typeof(Class43));
	}
}
