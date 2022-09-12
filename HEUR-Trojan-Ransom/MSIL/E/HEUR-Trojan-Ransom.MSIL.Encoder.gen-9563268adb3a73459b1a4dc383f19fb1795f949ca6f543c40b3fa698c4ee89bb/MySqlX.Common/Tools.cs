using System;
using System.Collections.Generic;
using System.Reflection;
using MySql.Data;

namespace MySqlX.Common;

internal static class Tools
{
	public static Dictionary<string, object> GetDictionaryFromAnonymous(object anonymousObject)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		if (!anonymousObject.GetType().IsConstructedGenericType)
		{
			throw new FormatException(ResourcesX.InvalidConnectionData);
		}
		PropertyInfo[] properties = anonymousObject.GetType().GetProperties();
		foreach (PropertyInfo propertyInfo in properties)
		{
			object value = propertyInfo.GetValue(anonymousObject, null);
			dictionary.Add(propertyInfo.Name, value);
		}
		return dictionary;
	}

	internal static int CompareGuids(string guid1, string guid2)
	{
		return string.Compare(guid1.Replace("-", ""), guid2.Replace("-", ""));
	}

	internal static int CompareGuids(Guid guid1, Guid guid2)
	{
		return CompareGuids(guid1.ToString(), guid2.ToString());
	}
}
