using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using ns0;

namespace D;

internal sealed class g
{
	public static void smethod_0()
	{
		B.smethod_2();
	}

	internal static byte[] smethod_1(string string_0)
	{
		byte[] array = new byte[string_0.Length * 2];
		Buffer.BlockCopy(string_0.ToCharArray(), 0, array, 0, array.Length);
		return array;
	}

	public static PropertyInfo smethod_2(BindingFlags bindingFlags_0, PropertyInfo[] propertyInfo_0, Type type_0, Type[] type_1, ParameterModifier[] parameterModifier_0)
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

	public static bool smethod_3(ResolveEventArgs resolveEventArgs_0)
	{
		return GClass0.assembly_0.FullName != resolveEventArgs_0.Name;
	}

	internal static w smethod_4<w>(CallSite callSite_0)
	{
		CallSite<Func<CallSite, w>> callSite = (CallSite<Func<CallSite, w>>)callSite_0;
		Func<CallSite, w> func = callSite.Target;
		callSite_0 = callSite;
		Func<CallSite, w>[] array = new Func<CallSite, w>[0];
		Func<CallSite, w> func2;
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

	public static byte[] smethod_5(byte[] byte_0, byte[] byte_1)
	{
		for (int i = 0; i < byte_0.Length; i++)
		{
			byte_0[i] ^= byte_1[i % byte_1.Length];
		}
		return byte_0;
	}

	static object smethod_6()
	{
		while ((int)/*Error near IL_0002: Stack underflow*/ != 0)
		{
		}
		try
		{
			try
			{
			}
			finally
			{
				goto end_IL_0002;
			}
			end_IL_0002:;
		}
		catch
		{
		}
		return (object)/*Error near IL_000d: Stack underflow*/;
	}

	static object smethod_7(object object_0)
	{
		if ((int)/*Error near IL_0002: Stack underflow*/ == 0)
		{
			try
			{
			}
			catch
			{
			}
		}
		return (object)/*Error near IL_0008: Stack underflow*/;
	}

	static object smethod_8(object object_0, object object_1, object object_2)
	{
		try
		{
		}
		catch
		{
		}
		if ((int)/*Error near IL_0007: Stack underflow*/ != 0)
		{
		}
		return (object)/*Error near IL_0008: Stack underflow*/;
	}
}
