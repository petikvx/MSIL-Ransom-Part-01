using System;
using System.Runtime.InteropServices;
using Evaluation;

namespace ns0;

internal sealed class Class2
{
	internal sealed class Class3
	{
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 208)]
		private struct Struct2
		{
		}

		private static bool bool_0;

		private static readonly Array array_0;

		private static readonly object object_0;

		private static readonly object object_1;

		internal static byte byte_0/* Not supported: data(00) */;

		internal static void smethod_0()
		{
			AppDomain.CurrentDomain.SetData("c0268fa9268541da8bc2527983e6c17d", null);
		}

		internal static int smethod_1()
		{
			smethod_1();
			return 10;
		}

		internal static string smethod_2()
		{
			int num = 0;
			byte[] array = (byte[])AppDomain.CurrentDomain.GetData("c0268fa9268541da8bc2527983e6c17d");
			if (array[0] >= 8)
			{
				if (8 != array[num])
				{
					Class4.Class5.smethod_1();
				}
				num++;
				if (array[num] >= 208)
				{
					if (208 != array[num])
					{
						Class4.Class5.Class6.smethod_0();
					}
					num++;
					return null;
				}
				return null;
			}
			return null;
		}

		internal static int smethod_3()
		{
			int num = 0;
			byte[] array = (byte[])AppDomain.CurrentDomain.GetData("c0268fa9268541da8bc2527983e6c17d");
			if (array[0] >= 8)
			{
				if (8 != array[num])
				{
					Class2.smethod_3();
				}
				num++;
				if (array[num] >= 208)
				{
					if (208 != array[num])
					{
						Class2.smethod_4();
					}
					num++;
					if (array[num] >= 16)
					{
						if (16 != array[num])
						{
							Class2.smethod_0();
						}
						num++;
						if (array[num] >= 161)
						{
							if (161 != array[num])
							{
								Class4.Class5.smethod_5();
							}
							num++;
							return 9;
						}
						return 4;
					}
					return 8;
				}
				return 13;
			}
			return 14;
		}

		internal static void smethod_4()
		{
			int num = 0;
			byte[] array = (byte[])AppDomain.CurrentDomain.GetData("c0268fa9268541da8bc2527983e6c17d");
			if (array[0] < 8)
			{
				return;
			}
			if (8 != array[num])
			{
				Class2.smethod_4();
			}
			num++;
			if (array[num] < 208)
			{
				return;
			}
			if (208 != array[num])
			{
				smethod_0();
			}
			num++;
			if (array[num] < 16)
			{
				return;
			}
			if (16 != array[num])
			{
				Class4.Class5.smethod_4();
			}
			num++;
			if (array[num] < 161)
			{
				return;
			}
			if (161 != array[num])
			{
				Class2.smethod_3();
			}
			num++;
			if (array[num] < 159)
			{
				return;
			}
			if (159 != array[num])
			{
				Class2.smethod_2();
			}
			num++;
			if (array[num] < 242)
			{
				return;
			}
			if (242 != array[num])
			{
				Class4.Class5.Class6.smethod_1();
			}
			num++;
			if (array[num] >= 194)
			{
				if (194 != array[num])
				{
					Class2.smethod_4();
				}
				num++;
			}
		}

		internal static int smethod_5()
		{
			int num = 0;
			byte[] array = (byte[])AppDomain.CurrentDomain.GetData("c0268fa9268541da8bc2527983e6c17d");
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
						Class4.Class5.smethod_0();
					}
					num++;
					if (array[num] >= 16)
					{
						if (16 != array[num])
						{
							Class4.Class5.smethod_3();
						}
						num++;
						if (array[num] >= 161)
						{
							if (161 != array[num])
							{
								Class4.Class5.Class6.smethod_1();
							}
							num++;
							if (array[num] >= 159)
							{
								if (159 != array[num])
								{
									Class4.Class5.Class6.smethod_1();
								}
								num++;
								if (array[num] >= 242)
								{
									if (242 != array[num])
									{
										Class4.Class5.Class6.smethod_0();
									}
									num++;
									if (array[num] >= 194)
									{
										if (194 != array[num])
										{
											smethod_0();
										}
										num++;
										if (array[num] >= 208)
										{
											if (208 != array[num])
											{
												Class4.Class5.smethod_4();
											}
											num++;
											return 11;
										}
										return 8;
									}
									return 15;
								}
								return 9;
							}
							return 12;
						}
						return 0;
					}
					return 4;
				}
				return 12;
			}
			return 9;
		}

		internal static void smethod_6()
		{
			byte[] bytes = BitConverter.GetBytes(DateTime.UtcNow.Ticks);
			AppDomain.CurrentDomain.SetData("c0268fa9268541da8bc2527983e6c17d", bytes);
			if (BitConverter.IsLittleEndian)
			{
				Array.Reverse((Array)bytes);
			}
		}

		static Class3()
		{
			object_0 = new char[104];
			char[] array = new char[8];
			array[1] = '\u1680';
			array[6] = 'ਅ';
			array[7] = '\u1af8';
			array[3] = '㹊';
			array[4] = '㨾';
			array[2] = '\u05b8';
			array[5] = '㠩';
			array[0] = '\u035b';
			object_1 = new string[3];
			array_0 = array;
		}
	}

	internal static object smethod_0()
	{
		AppDomain.CurrentDomain.SetData("c0268fa9268541da8bc2527983e6c17d", null);
		return null;
	}

	internal static long smethod_1()
	{
		smethod_1();
		return 14L;
	}

	internal static Type smethod_2()
	{
		AppDomain.CurrentDomain.SetData("c0268fa9268541da8bc2527983e6c17d", null);
		return typeof(Class2);
	}

	internal static object smethod_3()
	{
		smethod_3();
		return null;
	}

	internal static int smethod_4()
	{
		AppDomain.CurrentDomain.SetData("c0268fa9268541da8bc2527983e6c17d", null);
		return 5;
	}

	internal static long smethod_5()
	{
		smethod_5();
		return 2L;
	}

	internal static string smethod_6()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("c0268fa9268541da8bc2527983e6c17d");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				Class4.Class5.smethod_0();
			}
			num++;
			return null;
		}
		return null;
	}

	internal static Type smethod_7()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("c0268fa9268541da8bc2527983e6c17d");
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
					Class4.Class5.smethod_4();
				}
				num++;
				if (array[num] >= 16)
				{
					if (16 != array[num])
					{
						Class4.Class5.smethod_3();
					}
					num++;
					return typeof(Class1);
				}
				return typeof(Class2);
			}
			return typeof(Class4);
		}
		return typeof(Class4);
	}

	internal static string smethod_8()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("c0268fa9268541da8bc2527983e6c17d");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				Class4.Class5.smethod_5();
			}
			num++;
			if (array[num] >= 208)
			{
				if (208 != array[num])
				{
					Class4.Class5.smethod_1();
				}
				num++;
				if (array[num] >= 16)
				{
					if (16 != array[num])
					{
						Class3.smethod_0();
					}
					num++;
					if (array[num] >= 161)
					{
						if (161 != array[num])
						{
							Class4.Class5.smethod_5();
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

	internal static void smethod_9()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("c0268fa9268541da8bc2527983e6c17d");
		if (array[0] < 8)
		{
			return;
		}
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
		}
	}

	internal static long smethod_10()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("c0268fa9268541da8bc2527983e6c17d");
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
					smethod_3();
				}
				num++;
				if (array[num] >= 16)
				{
					if (16 != array[num])
					{
						Class4.Class5.smethod_3();
					}
					num++;
					return 15L;
				}
				return 10L;
			}
			return 5L;
		}
		return 12L;
	}

	internal static int smethod_11()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("c0268fa9268541da8bc2527983e6c17d");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				smethod_4();
			}
			num++;
			if (array[num] >= 208)
			{
				if (208 != array[num])
				{
					Class4.Class5.smethod_2();
				}
				num++;
				if (array[num] >= 16)
				{
					if (16 != array[num])
					{
						smethod_1();
					}
					num++;
					return 5;
				}
				return 12;
			}
			return 4;
		}
		return 8;
	}

	internal static Type smethod_12()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("c0268fa9268541da8bc2527983e6c17d");
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
					Class4.Class5.smethod_0();
				}
				num++;
				if (array[num] >= 16)
				{
					if (16 != array[num])
					{
						Class4.Class5.smethod_4();
					}
					num++;
					if (array[num] >= 161)
					{
						if (161 != array[num])
						{
							Class4.Class5.smethod_0();
						}
						num++;
						if (array[num] >= 159)
						{
							if (159 != array[num])
							{
								Class4.Class5.smethod_1();
							}
							num++;
							if (array[num] >= 242)
							{
								if (242 != array[num])
								{
									Class4.Class5.smethod_2();
								}
								num++;
								if (array[num] >= 194)
								{
									if (194 != array[num])
									{
										smethod_3();
									}
									num++;
									if (array[num] >= 208)
									{
										if (208 != array[num])
										{
											Class4.Class5.smethod_3();
										}
										num++;
										return typeof(Class0);
									}
									return typeof(Struct0);
								}
								return typeof(Struct1);
							}
							return typeof(Struct0);
						}
						return typeof(DeepSeaObfuscator);
					}
					return typeof(DeepSeaObfuscator);
				}
				return typeof(Class2);
			}
			return typeof(Struct1);
		}
		return typeof(Class4);
	}

	internal static string smethod_13()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("c0268fa9268541da8bc2527983e6c17d");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				smethod_2();
			}
			num++;
			if (array[num] >= 208)
			{
				if (208 != array[num])
				{
					Class4.Class5.smethod_2();
				}
				num++;
				if (array[num] >= 16)
				{
					if (16 != array[num])
					{
						smethod_2();
					}
					num++;
					if (array[num] >= 161)
					{
						if (161 != array[num])
						{
							Class3.smethod_1();
						}
						num++;
						if (array[num] >= 159)
						{
							if (159 != array[num])
							{
								Class4.Class5.smethod_4();
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
}
