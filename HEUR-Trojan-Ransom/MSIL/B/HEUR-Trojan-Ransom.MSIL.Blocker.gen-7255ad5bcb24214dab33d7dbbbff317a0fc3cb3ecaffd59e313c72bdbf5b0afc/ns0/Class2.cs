using System;
using System.Globalization;
using System.Reflection;
using System.Text;
using ns1;

namespace ns0;

internal sealed class Class2
{
	internal static string smethod_0(bool bool_0)
	{
		return null;
	}

	internal static string smethod_1(Type[] type_0, CallingConventions callingConventions_0, bool bool_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		string value = "";
		foreach (Type obj in type_0)
		{
			stringBuilder.Append(value);
			string text = smethod_0(bool_0);
			if (obj.IsByRef && !bool_0)
			{
				stringBuilder.Append(text.TrimEnd(new char[1] { '&' }));
				stringBuilder.Append(" ByRef");
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

	public static void smethod_2()
	{
		Class1.smethod_0();
		GClass0.appDomain_0.AssemblyResolve += Class4.smethod_0();
	}

	public static MethodBase smethod_3(BindingFlags bindingFlags_0, MethodBase[] methodBase_0, Type[] type_0, ParameterModifier[] parameterModifier_0)
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
			int k;
			for (k = 0; k < type_0.Length; k++)
			{
				Type parameterType = parameters[k].ParameterType;
				if (parameterType != type_0[k] && parameterType != typeof(object) && !parameterType.IsPrimitive && !parameterType.IsAssignableFrom(type_0[k]))
				{
					break;
				}
			}
			if (k == type_0.Length)
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
			for (int l = 0; l < type_0.Length; l++)
			{
				array2[l] = l;
			}
			for (int m = 1; m < num; m++)
			{
			}
			return methodBase_0[num2];
		}
		}
	}

	public static void smethod_4(AppDomain appDomain_0)
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

	public static void smethod_5(AppDomain appDomain_0)
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
