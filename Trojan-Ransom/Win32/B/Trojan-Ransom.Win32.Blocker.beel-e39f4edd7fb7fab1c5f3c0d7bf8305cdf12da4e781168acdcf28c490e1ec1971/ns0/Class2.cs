using System;
using System.Runtime.InteropServices;

namespace ns0;

internal sealed class Class2
{
	internal sealed class Class3
	{
		private static bool bool_0;

		internal static byte smethod_0()
		{
			smethod_0();
			return 14;
		}

		internal static object smethod_1()
		{
			smethod_1();
			return null;
		}

		internal static byte smethod_2()
		{
			smethod_2();
			return 18;
		}

		internal static string smethod_3()
		{
			smethod_3();
			return null;
		}

		internal static object smethod_4()
		{
			int num = 0;
			byte[] array = (byte[])AppDomain.CurrentDomain.GetData("9793c71ec19140cc92de39c64c02cdc5");
			if (array[0] >= 8)
			{
				if (8 != array[num])
				{
					Class2.smethod_1();
				}
				num++;
				if (array[num] >= 208)
				{
					if (208 != array[num])
					{
						Class4.Class5.smethod_1();
					}
					num++;
					return null;
				}
				return null;
			}
			return null;
		}

		internal static int smethod_5()
		{
			int num = 0;
			byte[] array = (byte[])AppDomain.CurrentDomain.GetData("9793c71ec19140cc92de39c64c02cdc5");
			if (array[0] >= 8)
			{
				if (8 != array[num])
				{
					smethod_0();
				}
				num++;
				return 13;
			}
			return 11;
		}

		internal static void smethod_6()
		{
			int num = 0;
			byte[] array = (byte[])AppDomain.CurrentDomain.GetData("9793c71ec19140cc92de39c64c02cdc5");
			if (array[0] < 8)
			{
				return;
			}
			if (8 != array[num])
			{
				Class4.Class5.smethod_0();
			}
			num++;
			if (array[num] < 208)
			{
				return;
			}
			if (208 != array[num])
			{
				Class4.Class5.smethod_1();
			}
			num++;
			if (array[num] < 29)
			{
				return;
			}
			if (29 != array[num])
			{
				Class4.Class6.smethod_0();
			}
			num++;
			if (array[num] >= 203)
			{
				if (203 != array[num])
				{
					Class4.Class5.smethod_0();
				}
				num++;
			}
		}

		internal static object smethod_7()
		{
			int num = 0;
			byte[] array = (byte[])AppDomain.CurrentDomain.GetData("9793c71ec19140cc92de39c64c02cdc5");
			if (array[0] >= 8)
			{
				if (8 != array[num])
				{
					smethod_3();
				}
				num++;
				if (array[num] >= 208)
				{
					if (208 != array[num])
					{
						Class4.smethod_2();
					}
					num++;
					if (array[num] >= 29)
					{
						if (29 != array[num])
						{
							smethod_2();
						}
						num++;
						if (array[num] >= 203)
						{
							if (203 != array[num])
							{
								smethod_1();
							}
							num++;
							if (array[num] >= 140)
							{
								if (140 != array[num])
								{
									Class4.smethod_2();
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

		internal static byte smethod_8()
		{
			byte[] bytes = BitConverter.GetBytes(DateTime.UtcNow.Ticks);
			AppDomain.CurrentDomain.SetData("9793c71ec19140cc92de39c64c02cdc5", bytes);
			if (BitConverter.IsLittleEndian)
			{
				Array.Reverse((Array)bytes);
			}
			return 12;
		}
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 71746)]
	private struct Struct2
	{
	}

	internal static byte byte_0/* Not supported: data(00) */;

	internal static int smethod_0()
	{
		smethod_0();
		return 4;
	}

	internal static void smethod_1()
	{
		AppDomain.CurrentDomain.SetData("9793c71ec19140cc92de39c64c02cdc5", null);
	}

	internal static long smethod_2()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("9793c71ec19140cc92de39c64c02cdc5");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				Class3.smethod_2();
			}
			num++;
			if (array[num] >= 208)
			{
				if (208 != array[num])
				{
					Class4.Class5.smethod_2();
				}
				num++;
				if (array[num] >= 29)
				{
					if (29 != array[num])
					{
						Class4.Class6.smethod_2();
					}
					num++;
					if (array[num] >= 203)
					{
						if (203 != array[num])
						{
							Class3.smethod_2();
						}
						num++;
						return 3L;
					}
					return 13L;
				}
				return 7L;
			}
			return 4L;
		}
		return 1L;
	}

	internal static int smethod_3()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("9793c71ec19140cc92de39c64c02cdc5");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				Class4.Class5.smethod_2();
			}
			num++;
			if (array[num] >= 208)
			{
				if (208 != array[num])
				{
					Class4.Class6.smethod_2();
				}
				num++;
				if (array[num] >= 29)
				{
					if (29 != array[num])
					{
						Class3.smethod_1();
					}
					num++;
					if (array[num] >= 203)
					{
						if (203 != array[num])
						{
							Class3.smethod_1();
						}
						num++;
						if (array[num] >= 140)
						{
							if (140 != array[num])
							{
								Class3.smethod_3();
							}
							num++;
							if (array[num] >= 172)
							{
								if (172 != array[num])
								{
									smethod_1();
								}
								num++;
								return 0;
							}
							return 7;
						}
						return 9;
					}
					return 2;
				}
				return 15;
			}
			return 7;
		}
		return 11;
	}

	internal static byte smethod_4()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("9793c71ec19140cc92de39c64c02cdc5");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				Class4.Class6.smethod_1();
			}
			num++;
			if (array[num] >= 208)
			{
				if (208 != array[num])
				{
					smethod_0();
				}
				num++;
				if (array[num] >= 29)
				{
					if (29 != array[num])
					{
						Class4.Class6.smethod_1();
					}
					num++;
					if (array[num] >= 203)
					{
						if (203 != array[num])
						{
							Class3.smethod_2();
						}
						num++;
						if (array[num] >= 140)
						{
							if (140 != array[num])
							{
								Class4.smethod_0();
							}
							num++;
							if (array[num] >= 172)
							{
								if (172 != array[num])
								{
									Class4.Class5.smethod_2();
								}
								num++;
								if (array[num] >= 77)
								{
									if (77 != array[num])
									{
										Class4.smethod_2();
									}
									num++;
									return 9;
								}
								return 15;
							}
							return 31;
						}
						return 6;
					}
					return 26;
				}
				return 25;
			}
			return 7;
		}
		return 0;
	}

	internal static long smethod_5()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("9793c71ec19140cc92de39c64c02cdc5");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				Class3.smethod_0();
			}
			num++;
			if (array[num] >= 208)
			{
				if (208 != array[num])
				{
					smethod_1();
				}
				num++;
				if (array[num] >= 29)
				{
					if (29 != array[num])
					{
						Class4.Class6.smethod_2();
					}
					num++;
					if (array[num] >= 203)
					{
						if (203 != array[num])
						{
							Class4.Class5.smethod_1();
						}
						num++;
						if (array[num] >= 140)
						{
							if (140 != array[num])
							{
								Class4.Class5.smethod_2();
							}
							num++;
							if (array[num] >= 172)
							{
								if (172 != array[num])
								{
									smethod_0();
								}
								num++;
								return 3L;
							}
							return 14L;
						}
						return 10L;
					}
					return 7L;
				}
				return 6L;
			}
			return 5L;
		}
		return 1L;
	}

	internal static byte smethod_6()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("9793c71ec19140cc92de39c64c02cdc5");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				Class4.Class5.smethod_2();
			}
			num++;
			if (array[num] >= 208)
			{
				if (208 != array[num])
				{
					Class4.smethod_0();
				}
				num++;
				if (array[num] >= 29)
				{
					if (29 != array[num])
					{
						Class4.Class6.smethod_2();
					}
					num++;
					if (array[num] >= 203)
					{
						if (203 != array[num])
						{
							Class3.smethod_0();
						}
						num++;
						if (array[num] >= 140)
						{
							if (140 != array[num])
							{
								Class3.smethod_2();
							}
							num++;
							if (array[num] >= 172)
							{
								if (172 != array[num])
								{
									Class4.Class5.smethod_2();
								}
								num++;
								if (array[num] >= 77)
								{
									if (77 != array[num])
									{
										Class4.Class5.smethod_0();
									}
									num++;
									return 29;
								}
								return 18;
							}
							return 12;
						}
						return 27;
					}
					return 20;
				}
				return 8;
			}
			return 15;
		}
		return 21;
	}

	internal static long smethod_7()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("9793c71ec19140cc92de39c64c02cdc5");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				Class3.smethod_1();
			}
			num++;
			if (array[num] >= 208)
			{
				if (208 != array[num])
				{
					Class4.smethod_2();
				}
				num++;
				if (array[num] >= 29)
				{
					if (29 != array[num])
					{
						Class4.smethod_0();
					}
					num++;
					if (array[num] >= 203)
					{
						if (203 != array[num])
						{
							Class3.smethod_0();
						}
						num++;
						return 9L;
					}
					return 7L;
				}
				return 3L;
			}
			return 2L;
		}
		return 14L;
	}
}
