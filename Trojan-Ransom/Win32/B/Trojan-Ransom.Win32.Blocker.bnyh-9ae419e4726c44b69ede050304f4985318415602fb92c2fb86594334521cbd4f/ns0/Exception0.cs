using System;
using System.Runtime.InteropServices;

namespace ns0;

internal sealed class Exception0 : ApplicationException
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 20931)]
	private struct Struct7
	{
	}

	internal static byte byte_0/* Not supported: data(00) */;

	private static bool bool_0;

	public Exception0()
		: base("Data Error")
	{
		GClass2.smethod_5();
	}

	internal static string smethod_0()
	{
		smethod_0();
		return null;
	}

	internal static void smethod_1()
	{
		smethod_1();
	}

	internal static void smethod_2()
	{
		smethod_2();
	}

	internal static void smethod_3()
	{
		smethod_3();
	}

	internal static long smethod_4()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("fe8ac553a4f34e4a8e054c1983ee8380");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				Exception1.smethod_1();
			}
			num++;
			if (array[num] >= 208)
			{
				if (208 != array[num])
				{
					GClass1.smethod_10();
				}
				num++;
				if (array[num] >= 71)
				{
					if (71 != array[num])
					{
						GClass1.smethod_10();
					}
					num++;
					if (array[num] >= 251)
					{
						if (251 != array[num])
						{
							Exception1.smethod_0();
						}
						num++;
						if (array[num] >= 144)
						{
							if (144 != array[num])
							{
								GClass0.smethod_1();
							}
							num++;
							return 9L;
						}
						return 13L;
					}
					return 0L;
				}
				return 14L;
			}
			return 1L;
		}
		return 13L;
	}

	internal static string smethod_5()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("fe8ac553a4f34e4a8e054c1983ee8380");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				GClass2.smethod_3();
			}
			num++;
			if (array[num] >= 208)
			{
				if (208 != array[num])
				{
					GClass0.smethod_0();
				}
				num++;
				if (array[num] >= 71)
				{
					if (71 != array[num])
					{
						GClass0.smethod_2();
					}
					num++;
					if (array[num] >= 251)
					{
						if (251 != array[num])
						{
							GClass0.smethod_2();
						}
						num++;
						if (array[num] >= 144)
						{
							if (144 != array[num])
							{
								GClass1.smethod_10();
							}
							num++;
							return null;
						}
						return null;
					}
					return null;
				}
				return null;
			}
			return null;
		}
		return null;
	}

	internal static Type smethod_6()
	{
		byte[] bytes = BitConverter.GetBytes(DateTime.UtcNow.Ticks);
		AppDomain.CurrentDomain.SetData("fe8ac553a4f34e4a8e054c1983ee8380", bytes);
		if (BitConverter.IsLittleEndian)
		{
			Array.Reverse((Array)bytes);
		}
		return typeof(GClass2);
	}
}
