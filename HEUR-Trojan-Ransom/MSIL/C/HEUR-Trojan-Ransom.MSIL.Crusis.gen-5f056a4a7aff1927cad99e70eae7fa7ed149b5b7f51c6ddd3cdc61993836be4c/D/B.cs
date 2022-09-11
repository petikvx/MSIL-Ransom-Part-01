using System;
using System.Reflection;
using System.Runtime.InteropServices;
using ns0;

namespace D;

internal sealed class B
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 62)]
	private struct y
	{
	}

	private static readonly Array array_0;

	private static readonly Array array_1 = new char[31];

	private static readonly object object_0;

	internal static byte byte_0/* Not supported: data(00) */;

	private long method_0(int int_0, int int_1)
	{
		byte[] array = new byte[0];
		int_1++;
		byte[] array2 = new byte[8];
		int num = int_1 - int_0;
		bool flag = false;
		if (num == 0 || num > 9)
		{
			return 0L;
		}
		switch (num)
		{
		case 1:
			array2[0] = (byte)(array[int_0] & 0x7Fu);
			return BitConverter.ToInt64(array2, 0);
		case 9:
			flag = true;
			break;
		}
		int num2 = 1;
		int num3 = 7;
		int num4 = 0;
		if (flag)
		{
			array2[0] = array[int_1 - 1];
			int_1--;
			num4 = 1;
		}
		for (int i = int_1 - 1; i >= int_0; i += -1)
		{
			if (i - 1 >= int_0)
			{
				array2[num4] = (byte)(((byte)(array[i] >> ((num2 - 1) & 7)) & (255 >> num2)) | (byte)(array[i - 1] << (num3 & 7)));
				num2++;
				num4++;
				num3--;
			}
			else if (!flag)
			{
				array2[num4] = (byte)((byte)(array[i] >> ((num2 - 1) & 7)) & (255 >> num2));
			}
		}
		return BitConverter.ToInt64(array2, 0);
	}

	public static Assembly smethod_0(object object_1, ResolveEventArgs resolveEventArgs_0)
	{
		if (g.smethod_3(resolveEventArgs_0))
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

	internal static void smethod_2()
	{
		GClass0.assembly_0 = GClass0.appDomain_0.Load(g.smethod_5(C.smethod_0(), g.smethod_1("╠♂ÿ▬╣δ=U2v╟¶@D")));
	}

	static B()
	{
		char[] array = new char[8];
		array[6] = '㹔';
		array[2] = '⠆';
		array[3] = '✄';
		array[0] = '㡃';
		array[5] = '㎛';
		array[1] = '㭼';
		array[7] = 'ㄲ';
		array[4] = 'Ⲁ';
		object_0 = new string[4];
		array_0 = array;
	}
}
