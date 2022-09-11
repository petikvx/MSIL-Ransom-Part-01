using System;
using System.Reflection;

namespace NAudio.Utils;

public static class FieldDescriptionHelper
{
	public static string Describe(Type t, Guid guid)
	{
		FieldInfo[] fields = t.GetFields(BindingFlags.Static | BindingFlags.Public);
		foreach (FieldInfo fieldInfo in fields)
		{
			if (!fieldInfo.IsPublic || !fieldInfo.IsStatic || (object)fieldInfo.FieldType != typeof(Guid) || !((Guid)fieldInfo.GetValue(null) == guid))
			{
				continue;
			}
			object[] customAttributes = fieldInfo.GetCustomAttributes(inherit: false);
			for (int j = 0; j < customAttributes.Length; j++)
			{
				if (customAttributes[j] is FieldDescriptionAttribute fieldDescriptionAttribute)
				{
					return fieldDescriptionAttribute.Description;
				}
			}
			return fieldInfo.Name;
		}
		return guid.ToString();
	}
}
