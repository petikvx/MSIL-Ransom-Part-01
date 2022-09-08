using System;
using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class Class6
{
	public delegate void Delegate0(bool invalidate);

	private static int int_0;

	private static bool bool_0;

	public static Class7 class7_0;

	public static int int_1;

	public static int int_2;

	private static List<Delegate0> list_0;

	static Class6()
	{
		Class14.hYiyYvszsKHjE();
		class7_0 = new Class7();
		int_1 = 20;
		int_2 = 50;
		list_0 = new List<Delegate0>();
	}

	private static void smethod_0(IntPtr intptr_0, bool bool_1)
	{
		bool_0 = int_0 >= int_1;
		if (bool_0)
		{
			int_0 = 0;
		}
		checked
		{
			lock (list_0)
			{
				int num = list_0.Count - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 <= num4)
					{
						list_0[num2](bool_0);
						num2++;
						continue;
					}
					break;
				}
			}
			int_0 += int_2;
		}
	}

	private static void smethod_1()
	{
		if (list_0.Count == 0)
		{
			class7_0.method_2();
		}
		else
		{
			class7_0.method_1(0u, checked((uint)int_2), smethod_0);
		}
	}

	public static void smethod_2(object object_0)
	{
		lock (list_0)
		{
			if (!list_0.Contains((Delegate0)object_0))
			{
				list_0.Add((Delegate0)object_0);
				smethod_1();
			}
		}
	}

	public static void smethod_3(object object_0)
	{
		lock (list_0)
		{
			if (list_0.Contains((Delegate0)object_0))
			{
				list_0.Remove((Delegate0)object_0);
				smethod_1();
			}
		}
	}
}
