using System;
using System.Reflection;
using System.Text;

namespace ns0;

internal class Class23
{
	public static string smethod_0(Type type_0)
	{
		try
		{
			return smethod_1(type_0, bool_0: true);
		}
		catch (Exception exception_)
		{
			Class14.smethod_22(exception_, type_0);
			throw;
		}
	}

	public static string smethod_1(Type type_0, bool bool_0)
	{
		try
		{
			if ((object)type_0.DeclaringType != null)
			{
				return smethod_1(type_0.DeclaringType, bool_0) + (bool_0 ? "+" : ".") + type_0.Name;
			}
			return type_0.Namespace + "." + type_0.Name;
		}
		catch (Exception exception_)
		{
			Class14.smethod_23(exception_, type_0, bool_0);
			throw;
		}
	}

	public static string smethod_2(FieldInfo fieldInfo_0)
	{
		try
		{
			return smethod_1(fieldInfo_0.DeclaringType, bool_0: false) + "." + fieldInfo_0.Name;
		}
		catch (Exception exception_)
		{
			Class14.smethod_22(exception_, fieldInfo_0);
			throw;
		}
	}

	public static string smethod_3(MethodInfo methodInfo_0)
	{
		StringBuilder stringBuilder = default(StringBuilder);
		Type[] genericArguments = default(Type[]);
		int i = default(int);
		ParameterInfo[] parameters = default(ParameterInfo[]);
		int j = default(int);
		string text = default(string);
		try
		{
			stringBuilder = new StringBuilder();
			stringBuilder.Append(smethod_1(methodInfo_0.DeclaringType, bool_0: false));
			stringBuilder.Append(".");
			stringBuilder.Append(methodInfo_0.Name);
			if (methodInfo_0.IsGenericMethod)
			{
				genericArguments = methodInfo_0.GetGenericArguments();
				stringBuilder.Append("[");
				for (i = 0; i < genericArguments.Length; i++)
				{
					if (i > 0)
					{
						stringBuilder.Append(",");
					}
					stringBuilder.Append(genericArguments[i].Name);
				}
				stringBuilder.Append("]");
			}
			stringBuilder.Append("(");
			parameters = methodInfo_0.GetParameters();
			for (j = 0; j < parameters.Length; j++)
			{
				if (j > 0)
				{
					stringBuilder.Append(", ");
				}
				text = "<UnknownType>";
				if ((object)parameters[j].ParameterType != null)
				{
					text = parameters[j].ParameterType.Name;
				}
				stringBuilder.Append(text + " " + parameters[j].Name);
			}
			stringBuilder.Append(")");
			return stringBuilder.ToString();
		}
		catch (Exception exception_)
		{
			Class14.smethod_28(exception_, methodInfo_0, stringBuilder, genericArguments, i, parameters, j, text);
			throw;
		}
	}
}
