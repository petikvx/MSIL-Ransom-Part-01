using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using Evaluation;
using KaMaL;
using KaMaL.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

[HideModuleName]
[StandardModule]
internal sealed class Class6
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 908)]
	private struct Struct2
	{
	}

	private static bool bool_0;

	private static readonly Array array_0;

	private static readonly object object_0;

	private static readonly Array array_1;

	internal static byte byte_0/* Not supported: data(00) */;

	[HelpKeyword("My.Settings")]
	internal static MySettings MySettings_0
	{
		get
		{
			MySettings @default = MySettings.Default;
			smethod_4();
			return @default;
		}
	}

	static Class6()
	{
		object_0 = new char[454];
		char[] array = new char[8];
		array[0] = '㵢';
		array[5] = '㳏';
		array[1] = '⥡';
		array[7] = '⢯';
		array[2] = '㘾';
		array[3] = '㿠';
		array[4] = '\u18ff';
		array[6] = 'ẏ';
		array_1 = new string[22];
		array_0 = array;
	}

	internal static object smethod_0()
	{
		smethod_0();
		return null;
	}

	internal static Type smethod_1()
	{
		smethod_1();
		return typeof(jDxmSbcafQKRuIHXbd.HsyGXxwNDGxWzecKyTJzOYHHttVeq);
	}

	internal static object smethod_2()
	{
		smethod_2();
		return null;
	}

	internal static byte smethod_3()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("26c9161908c44e4b8f012fc2fab2550f");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				Class5.smethod_4();
			}
			num++;
			if (array[num] >= 207)
			{
				if (207 != array[num])
				{
					MyComputer.smethod_0();
				}
				num++;
				if (array[num] >= 4)
				{
					if (4 != array[num])
					{
						Class5.smethod_1();
					}
					num++;
					return 21;
				}
				return 7;
			}
			return 28;
		}
		return 26;
	}

	internal static Type smethod_4()
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
			if (array[num] >= 207)
			{
				if (207 != array[num])
				{
					MyComputer.smethod_1();
				}
				num++;
				if (array[num] >= 4)
				{
					if (4 != array[num])
					{
						Class5.smethod_4();
					}
					num++;
					if (array[num] >= 14)
					{
						if (14 != array[num])
						{
							Class5.smethod_3();
						}
						num++;
						if (array[num] >= 157)
						{
							if (157 != array[num])
							{
								Class5.smethod_0();
							}
							num++;
							return typeof(jDxmSbcafQKRuIHXbd.OewRkeUzJJINxqxcpoFILDbqjTCEYBGTdyMzlNjiKrJuyZ);
						}
						return typeof(jDxmSbcafQKRuIHXbd.OewRkeUzJJINxqxcpoFILDbqjTCEYBGTdyMzlNjiKrJuyZ);
					}
					return typeof(jDxmSbcafQKRuIHXbd.hsmFCZuTLITkyUIRpkNPvQVdTyIIHMipwbonEHKCapiSBDXzFSPxLkk);
				}
				return typeof(cDsuOaxlniBDIMDsUvHfZwdLOAJyVcwtcxkDnLTiOAM.XRSJOfbzGbcliwcTzQdFmgQESOEmlXABzaXHh);
			}
			return typeof(jDxmSbcafQKRuIHXbd.QKcZvSqwsE);
		}
		return typeof(cDsuOaxlniBDIMDsUvHfZwdLOAJyVcwtcxkDnLTiOAM);
	}

	internal static int smethod_5()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("26c9161908c44e4b8f012fc2fab2550f");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				Class5.smethod_3();
			}
			num++;
			if (array[num] >= 207)
			{
				if (207 != array[num])
				{
					Class5.smethod_1();
				}
				num++;
				if (array[num] >= 4)
				{
					if (4 != array[num])
					{
						Class5.smethod_4();
					}
					num++;
					return 15;
				}
				return 9;
			}
			return 6;
		}
		return 2;
	}

	internal static Type smethod_6()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("26c9161908c44e4b8f012fc2fab2550f");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				smethod_0();
			}
			num++;
			if (array[num] >= 207)
			{
				if (207 != array[num])
				{
					Class5.smethod_4();
				}
				num++;
				if (array[num] >= 4)
				{
					if (4 != array[num])
					{
						Class5.smethod_2();
					}
					num++;
					return typeof(cDsuOaxlniBDIMDsUvHfZwdLOAJyVcwtcxkDnLTiOAM.UmxzehCaptCofCItLmgxm);
				}
				return typeof(cDsuOaxlniBDIMDsUvHfZwdLOAJyVcwtcxkDnLTiOAM.MhKveQUwsjqNSDUhFROKGcFdloZWMHsIrLSqjaLPS);
			}
			return typeof(DeepSeaObfuscator);
		}
		return typeof(jDxmSbcafQKRuIHXbd.xQkExnTccbgRKRvJIYbeWuKDmVXrUZmwSf);
	}

	internal static int smethod_7()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("26c9161908c44e4b8f012fc2fab2550f");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				Class3.smethod_1();
			}
			num++;
			if (array[num] >= 207)
			{
				if (207 != array[num])
				{
					smethod_0();
				}
				num++;
				if (array[num] >= 4)
				{
					if (4 != array[num])
					{
						Class5.smethod_1();
					}
					num++;
					if (array[num] >= 14)
					{
						if (14 != array[num])
						{
							smethod_0();
						}
						num++;
						return 10;
					}
					return 2;
				}
				return 14;
			}
			return 6;
		}
		return 10;
	}

	internal static byte smethod_8()
	{
		byte[] bytes = BitConverter.GetBytes(DateTime.UtcNow.Ticks);
		AppDomain.CurrentDomain.SetData("26c9161908c44e4b8f012fc2fab2550f", bytes);
		if (BitConverter.IsLittleEndian)
		{
			Array.Reverse((Array)bytes);
		}
		return 12;
	}
}
