using System;
using System.Reflection;
using System.Windows;
using ns3;
using ns4;

namespace ns11;

public class GClass0 : Window
{
	internal static void smethod_0(byte[] byte_0, int int_0)
	{
		while (int_0-- > 0)
		{
			byte_0[int_0] = 0;
		}
		Class2.smethod_0();
	}

	public void method_0()
	{
	}

	internal static int smethod_1(Type[] type_0, TypeInfo[] typeInfo_0)
	{
		int i;
		for (i = 0; i < type_0.Length; i++)
		{
			Class3.smethod_0(type_0, i, typeInfo_0);
		}
		return i;
	}
}
