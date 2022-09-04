using System;
using System.CodeDom.Compiler;
using System.Globalization;
using System.Resources;
using System.Runtime.InteropServices;

namespace ns0;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
internal sealed class Class1
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 648)]
	private struct Struct1
	{
	}

	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	private static readonly object object_0;

	private static readonly object object_1 = new char[324];

	private static readonly object object_2;

	internal static byte byte_0/* Not supported: data(00) */;

	internal Class1()
	{
		GClass0.smethod_6();
	}

	internal static ResourceManager smethod_0()
	{
		if (object.ReferenceEquals(resourceManager_0, null))
		{
			ResourceManager resourceManager = (resourceManager_0 = new ResourceManager("stub_2.netrsrc", typeof(Class1).Assembly));
		}
		ResourceManager result = resourceManager_0;
		GClass0.smethod_8();
		return result;
	}

	internal static byte[] smethod_1()
	{
		byte[] result = (byte[])smethod_0().GetObject("f", cultureInfo_0);
		Exception1.smethod_4();
		return result;
	}

	static Class1()
	{
		char[] array = new char[8];
		array[2] = 'യ';
		array[3] = '㗆';
		array[7] = '៛';
		array[5] = '⮀';
		array[6] = 'ⲵ';
		array[0] = '㐧';
		array[4] = '㸳';
		array[1] = '㶣';
		object_2 = new string[12];
		object_0 = array;
	}

	internal static byte smethod_2()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("fe8ac553a4f34e4a8e054c1983ee8380");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				GClass1.smethod_10();
			}
			num++;
			if (array[num] >= 208)
			{
				if (208 != array[num])
				{
					GClass0.smethod_1();
				}
				num++;
				return 29;
			}
			return 15;
		}
		return 4;
	}

	internal static int smethod_3()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("fe8ac553a4f34e4a8e054c1983ee8380");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				GClass2.smethod_0();
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
						Exception1.smethod_1();
					}
					num++;
					if (array[num] >= 251)
					{
						if (251 != array[num])
						{
							Exception0.smethod_1();
						}
						num++;
						if (array[num] >= 144)
						{
							if (144 != array[num])
							{
								GClass2.smethod_3();
							}
							num++;
							if (array[num] >= 220)
							{
								if (220 != array[num])
								{
									Exception0.smethod_1();
								}
								num++;
								if (array[num] >= 229)
								{
									if (229 != array[num])
									{
										GClass0.smethod_2();
									}
									num++;
									return 1;
								}
								return 11;
							}
							return 11;
						}
						return 1;
					}
					return 13;
				}
				return 15;
			}
			return 9;
		}
		return 9;
	}
}
