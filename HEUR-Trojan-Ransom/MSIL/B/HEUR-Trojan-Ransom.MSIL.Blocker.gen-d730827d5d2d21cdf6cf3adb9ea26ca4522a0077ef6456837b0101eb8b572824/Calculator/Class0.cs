using System;
using System.ComponentModel;
using System.Data;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Calculator;

internal class Class0
{
	public static double smethod_0(string string_0)
	{
		MethodInfo[] methodsGroup = typeof(Math).GetMethods();
		string[] value = null;
		string expression = Regex.Replace(string_0, "(?<func>" + string.Join("|", value) + ")\\((?<arg>.*?)\\)", delegate(Match match)
		{
			string value2 = match.Groups["func"].Value;
			MethodInfo methodInfo = null;
			MethodInfo[] array = methodsGroup;
			foreach (MethodInfo methodInfo2 in array)
			{
				if (value2 == methodInfo2.Name)
				{
					methodInfo = methodInfo2;
				}
			}
			if ((object)methodInfo == null)
			{
				return "0";
			}
			object[] array2 = new object[0];
			if (match.Groups["arg"].Value.Contains(","))
			{
				object[] array3 = match.Groups["arg"].Value.Split(new char[1] { ',' });
				array2 = array3;
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = smethod_1(array2[j], methodInfo.GetParameters()[j].ParameterType);
				}
			}
			else
			{
				array2 = new object[1] { smethod_1(match.Groups["arg"].Value, methodInfo.GetParameters()[0].ParameterType) };
			}
			return methodInfo.Invoke(null, array2)!.ToString();
		}).ToString();
		object obj = new DataTable().Compute(expression, null);
		return double.Parse(obj.ToString());
	}

	private static object smethod_1(object object_0, Type type_0)
	{
		try
		{
			TypeConverter converter = TypeDescriptor.GetConverter(type_0);
			if (converter.ConvertFrom(object_0) == null)
			{
				return object_0;
			}
			return converter.ConvertFrom(object_0);
		}
		catch
		{
			return object_0;
		}
	}
}
