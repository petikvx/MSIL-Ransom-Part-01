using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Globalization;
using System.Resources;
using System.Runtime.InteropServices;
using KaMaL;
using KaMaL.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

[StandardModule]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
[HideModuleName]
internal sealed class Class5
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 426)]
	private struct Struct1
	{
	}

	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	private static readonly object object_0;

	private static readonly object object_1;

	private static readonly object object_2;

	internal static byte byte_0/* Not supported: data(00) */;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager_0
	{
		get
		{
			if (object.ReferenceEquals(resourceManager_0, null))
			{
				ResourceManager resourceManager = (resourceManager_0 = new ResourceManager("ns0.Class5", typeof(Class5).Assembly));
			}
			ResourceManager result = resourceManager_0;
			MyComputer.smethod_4();
			return result;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo CultureInfo_0
	{
		get
		{
			CultureInfo result = cultureInfo_0;
			MyComputer.smethod_4();
			return result;
		}
		set
		{
			cultureInfo_0 = value;
			MyComputer.smethod_5();
		}
	}

	static Class5()
	{
		object_1 = new char[213];
		char[] array = new char[8];
		array[7] = '⢯';
		array[3] = '㿠';
		array[0] = '㵢';
		array[5] = '㳏';
		array[2] = '㘾';
		array[4] = '\u18ff';
		array[1] = '⥡';
		array[6] = 'ẏ';
		object_2 = new string[15];
		object_0 = array;
	}

	internal static string smethod_0()
	{
		smethod_0();
		return null;
	}

	internal static string smethod_1()
	{
		AppDomain.CurrentDomain.SetData("26c9161908c44e4b8f012fc2fab2550f", null);
		return null;
	}

	internal static string smethod_2()
	{
		AppDomain.CurrentDomain.SetData("26c9161908c44e4b8f012fc2fab2550f", null);
		return null;
	}

	internal static byte smethod_3()
	{
		AppDomain.CurrentDomain.SetData("26c9161908c44e4b8f012fc2fab2550f", null);
		return 5;
	}

	internal static byte smethod_4()
	{
		AppDomain.CurrentDomain.SetData("26c9161908c44e4b8f012fc2fab2550f", null);
		return 7;
	}

	internal static Type smethod_5()
	{
		smethod_5();
		return typeof(jDxmSbcafQKRuIHXbd.BnOkjMsLwBaBMGYVrOmeamDSnbkIDgiP);
	}

	internal static string smethod_6()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("26c9161908c44e4b8f012fc2fab2550f");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				Class3.smethod_0();
			}
			num++;
			if (array[num] >= 207)
			{
				if (207 != array[num])
				{
					Class3.smethod_2();
				}
				num++;
				if (array[num] >= 4)
				{
					if (4 != array[num])
					{
						smethod_0();
					}
					num++;
					if (array[num] >= 14)
					{
						if (14 != array[num])
						{
							Class3.smethod_2();
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

	internal static int smethod_7()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("26c9161908c44e4b8f012fc2fab2550f");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				Class3.Class4.smethod_1();
			}
			num++;
			if (array[num] >= 207)
			{
				if (207 != array[num])
				{
					Class3.smethod_1();
				}
				num++;
				if (array[num] >= 4)
				{
					if (4 != array[num])
					{
						Class3.smethod_0();
					}
					num++;
					if (array[num] >= 14)
					{
						if (14 != array[num])
						{
							Class3.Class4.smethod_1();
						}
						num++;
						if (array[num] >= 157)
						{
							if (157 != array[num])
							{
								Class3.smethod_1();
							}
							num++;
							return 9;
						}
						return 0;
					}
					return 11;
				}
				return 1;
			}
			return 10;
		}
		return 2;
	}

	internal static void smethod_8()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("26c9161908c44e4b8f012fc2fab2550f");
		if (array[0] < 8)
		{
			return;
		}
		if (8 != array[num])
		{
			Class3.smethod_2();
		}
		num++;
		if (array[num] < 207)
		{
			return;
		}
		if (207 != array[num])
		{
			MyComputer.smethod_0();
		}
		num++;
		if (array[num] < 4)
		{
			return;
		}
		if (4 != array[num])
		{
			Class6.smethod_1();
		}
		num++;
		if (array[num] >= 14)
		{
			if (14 != array[num])
			{
				Class6.smethod_2();
			}
			num++;
		}
	}

	internal static int smethod_9()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("26c9161908c44e4b8f012fc2fab2550f");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				smethod_1();
			}
			num++;
			return 6;
		}
		return 8;
	}

	internal static void smethod_10()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("26c9161908c44e4b8f012fc2fab2550f");
		if (array[0] < 8)
		{
			return;
		}
		if (8 != array[num])
		{
			Class6.smethod_2();
		}
		num++;
		if (array[num] < 207)
		{
			return;
		}
		if (207 != array[num])
		{
			Class3.Class4.smethod_1();
		}
		num++;
		if (array[num] < 4)
		{
			return;
		}
		if (4 != array[num])
		{
			Class3.Class4.smethod_1();
		}
		num++;
		if (array[num] < 14)
		{
			return;
		}
		if (14 != array[num])
		{
			Class6.smethod_0();
		}
		num++;
		if (array[num] >= 157)
		{
			if (157 != array[num])
			{
				Class6.smethod_0();
			}
			num++;
		}
	}

	internal static object smethod_11()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("26c9161908c44e4b8f012fc2fab2550f");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				Class3.Class4.smethod_0();
			}
			num++;
			if (array[num] >= 207)
			{
				if (207 != array[num])
				{
					Class3.Class4.smethod_0();
				}
				num++;
				if (array[num] >= 4)
				{
					if (4 != array[num])
					{
						Class6.smethod_2();
					}
					num++;
					if (array[num] >= 14)
					{
						if (14 != array[num])
						{
							Class3.smethod_1();
						}
						num++;
						if (array[num] >= 157)
						{
							if (157 != array[num])
							{
								MyComputer.smethod_1();
							}
							num++;
							if (array[num] >= 0)
							{
								if (0 != array[num])
								{
									smethod_1();
								}
								num++;
								if (array[num] >= 198)
								{
									if (198 != array[num])
									{
										smethod_2();
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
			return null;
		}
		return null;
	}

	internal static string smethod_12()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("26c9161908c44e4b8f012fc2fab2550f");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				Class3.Class4.smethod_0();
			}
			num++;
			if (array[num] >= 207)
			{
				if (207 != array[num])
				{
					Class6.smethod_0();
				}
				num++;
				if (array[num] >= 4)
				{
					if (4 != array[num])
					{
						smethod_0();
					}
					num++;
					if (array[num] >= 14)
					{
						if (14 != array[num])
						{
							smethod_0();
						}
						num++;
						if (array[num] >= 157)
						{
							if (157 != array[num])
							{
								Class3.Class4.smethod_1();
							}
							num++;
							if (array[num] >= 0)
							{
								if (0 != array[num])
								{
									Class6.smethod_0();
								}
								num++;
								if (array[num] >= 198)
								{
									if (198 != array[num])
									{
										smethod_3();
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
			return null;
		}
		return null;
	}
}
