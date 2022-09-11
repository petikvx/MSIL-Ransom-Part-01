using System;
using System.Globalization;
using System.Reflection;
using System.Text;
using ns0;

namespace D;

internal sealed class y
{
	internal static string QycbOUDLZvqZmPYvJY7GdkBTtXbVGnxafoYrStnLj4hgKsPsiqGYrz9KLRbOkx8YwZkXc4zJGCQ032YtzUuKLk7erGnlLzRqYxDV33qnbVxktG0K(bool bool_0)
	{
		return null;
	}

	internal static string smethod_0(Type[] type_0, CallingConventions callingConventions_0, bool bool_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		string value = "";
		foreach (Type obj in type_0)
		{
			stringBuilder.Append(value);
			string text = QycbOUDLZvqZmPYvJY7GdkBTtXbVGnxafoYrStnLj4hgKsPsiqGYrz9KLRbOkx8YwZkXc4zJGCQ032YtzUuKLk7erGnlLzRqYxDV33qnbVxktG0K(bool_0);
			if (obj.IsByRef && !bool_0)
			{
				stringBuilder.Append(text.TrimEnd(new char[1] { '&' }));
				stringBuilder.Append("");
			}
			else
			{
				stringBuilder.Append(text);
			}
			value = ", ";
		}
		if ((callingConventions_0 & CallingConventions.VarArgs) == CallingConventions.VarArgs)
		{
			stringBuilder.Append(value);
			stringBuilder.Append("...");
		}
		return stringBuilder.ToString();
	}

	public static void smethod_1()
	{
		g.smethod_0();
		GClass0.appDomain_0.AssemblyResolve += l.smethod_1();
	}

	public static MethodBase smethod_2(BindingFlags bindingFlags_0, MethodBase[] methodBase_0, Type[] type_0, ParameterModifier[] xDDnEGfG66YHFgbXzvpidAPA6UDyAWGyBHUPjJGhmhhcxrDsiWWgRh2Ifz4AYkg8STE9raztFw3QjV8tXTRk3d1yCQYLZivERvYNZ4g8PUHlwpAh)
	{
		Type[] array = new Type[type_0.Length];
		for (int i = 0; i < type_0.Length; i++)
		{
			array[i] = type_0[i].UnderlyingSystemType;
		}
		type_0 = array;
		int num = 0;
		for (int j = 0; j < methodBase_0.Length; j++)
		{
			ParameterInfo[] parameters = methodBase_0[j].GetParameters();
			if (parameters.Length != type_0.Length)
			{
				continue;
			}
			int m;
			for (m = 0; m < type_0.Length; m++)
			{
				Type parameterType = parameters[m].ParameterType;
				if (parameterType != type_0[m] && parameterType != typeof(object) && !parameterType.IsPrimitive && !parameterType.IsAssignableFrom(type_0[m]))
				{
					break;
				}
			}
			if (m == type_0.Length)
			{
				methodBase_0[num++] = methodBase_0[j];
			}
		}
		switch (num)
		{
		case 0:
			return null;
		case 1:
			return methodBase_0[0];
		default:
		{
			int num2 = 0;
			int[] array2 = new int[type_0.Length];
			for (int n = 0; n < type_0.Length; n++)
			{
				array2[n] = n;
			}
			for (int num3 = 1; num3 < num; num3++)
			{
			}
			return methodBase_0[num2];
		}
		}
	}

	public static void smethod_3(AppDomain appDomain_0)
	{
	}

	public object method_0(object object_0, Type type_0, CultureInfo cultureInfo_0)
	{
		if (cultureInfo_0 == null)
		{
			cultureInfo_0 = CultureInfo.CurrentCulture;
		}
		if (type_0.IsByRef)
		{
			type_0 = type_0.GetElementType();
		}
		if (!type_0.IsPrimitive && type_0.IsInstanceOfType(object_0))
		{
			return object_0;
		}
		Type type = object_0.GetType();
		if (type_0.IsEnum && type.IsPrimitive)
		{
			return Enum.Parse(type_0, object_0.ToString());
		}
		if (type == typeof(DBNull))
		{
			if (type_0 == typeof(DBNull))
			{
				return object_0;
			}
			if ((type_0.IsClass && type_0 != typeof(object)) || type_0.IsInterface)
			{
				return null;
			}
		}
		try
		{
		}
		catch (NotSupportedException)
		{
		}
		return null;
	}

	public static void smethod_4(AppDomain appDomain_0)
	{
		try
		{
			string fullName = Assembly.GetCallingAssembly().FullName;
			appDomain_0.CreateInstance(fullName, "");
		}
		catch (Exception ex)
		{
			Console.WriteLine();
			Console.WriteLine(ex.Message);
		}
	}
}
