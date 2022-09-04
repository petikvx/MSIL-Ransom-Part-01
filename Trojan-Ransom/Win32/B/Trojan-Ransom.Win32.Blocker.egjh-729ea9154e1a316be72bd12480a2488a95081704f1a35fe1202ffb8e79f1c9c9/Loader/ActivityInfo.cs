using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;

namespace Loader;

internal sealed class ActivityInfo
{
	private static bool previousId;

	static ActivityInfo()
	{
		CloneWindow();
	}

	internal static void CloneWindow()
	{
		byte[] array = ResourceContext.previousId;
		int[] array2 = DeviceSerializer.previousId;
		int num = 1;
		int num7 = default(int);
		int[] array3 = default(int[]);
		int num3 = default(int);
		int num6 = default(int);
		while (true)
		{
			switch (num)
			{
			case 3:
			case 6:
				if (!previousId)
				{
					num = array2[273] - 53894;
					break;
				}
				return;
			case 2:
				num7 = 2;
				num = array2[63] - 37761;
				break;
			default:
				array3 = ResourceContext.previousId;
				num7 = 4;
				num = 0;
				break;
			case 0:
				num = num7 switch
				{
					0 => (int)array[142] / 6, 
					1 => array2[268] - 58685, 
					2 => 4, 
					3 => 4, 
					4 => 3, 
					_ => 3, 
				};
				break;
			case 4:
			case 5:
			case 7:
			{
				Type gparam_;
				PluginEditor.PaneProvider.CloneWindow<object>((object)(gparam_ = (Type)(IReflect)typeof(ActivityInfo)), 458, 486);
				try
				{
					int num2 = 1;
					while (true)
					{
						int num4;
						switch (num2)
						{
						case 10:
							previousId = true;
							goto case 0;
						case 0:
							PluginEditor.CloneWindow<ResolveEventHandler, AppDomain>(ActionTree.CloneWindow((short)165, 165), AspectSettings.DatabaseService.CloneWindow, 'Q', 58);
							goto case 3;
						case 3:
							num3 = array3[172] - 49003;
							num2 = array2[283] - 21121;
							continue;
						case 8:
							num2 = num3 switch
							{
								0 => 4, 
								1 => 4, 
								2 => array[289] - 153, 
								3 => 3, 
								4 => array2[237] - 26935, 
								5 => 6, 
								_ => array[279] - 117, 
							};
							continue;
						case 7:
							num4 = array3[131] - 38354;
							goto IL_01a3;
						case 5:
							num4 = array3[377] - 64501;
							goto IL_01a3;
						case 2:
						case 4:
							num2 = (previousId ? (array2[221] - 31663) : 7);
							continue;
						default:
							num3 = 0;
							num2 = array[52] - 146;
							continue;
						case 6:
						case 9:
							break;
							IL_01a3:
							num3 = num4;
							num2 = array[373] - 38;
							continue;
						}
						break;
					}
				}
				finally
				{
					PluginEditor.PaneProvider.CloneWindow<object>((object)gparam_, 692, 665);
				}
				int num5 = 5;
				while (true)
				{
					switch (num5)
					{
					case 1:
					case 3:
					case 7:
						num6 = 3;
						num5 = array2[3] - 10368;
						break;
					default:
						num6 = 4;
						num5 = array[120] - array[72];
						break;
					case 4:
						num5 = num6 switch
						{
							0 => array[39], 
							1 => 2, 
							2 => array[417] - 64, 
							3 => 6, 
							4 => array[336] - 144, 
							5 => 2, 
							_ => array[363] - 51, 
						};
						break;
					case 2:
						num6 = 3;
						num5 = array2[256] - 5250;
						break;
					case 0:
					case 6:
						return;
					}
				}
			}
			}
		}
	}

	internal static Assembly CloneWindow(short short_0, short short_1)
	{
		int[] array = DeviceSerializer.previousId;
		byte[] array2 = ResourceContext.previousId;
		int num7 = default(int);
		int num2 = default(int);
		object obj2 = default(object);
		int num4 = default(int);
		while (true)
		{
			object obj = DeviceSerializer.previousId;
			int num = 21;
			while (true)
			{
				int num5;
				int num3;
				switch (num)
				{
				case 21:
					num7 = 0;
					num2 = 11;
					num = 16;
					continue;
				case 6:
				case 20:
					num7++;
					num = 4;
					continue;
				case 19:
					num = (((short_1 ^ short_0) - 21) ^ num7) switch
					{
						0 => array[192] - 49882, 
						1 => 3, 
						_ => array2[39], 
					};
					continue;
				case 18:
					obj2 = PluginEditor.ReferenceFactory.CloneWindow('ϑ', 'ϻ');
					num2 = 2;
					num = array[130] - 12756;
					continue;
				case 14:
				case 17:
					obj2 = PluginEditor.ReferenceFactory.CloneWindow('ĝ', 'ķ');
					num = 0;
					continue;
				case 16:
					num = num2 switch
					{
						0 => array[299] - 27546, 
						1 => 22, 
						2 => array2[196] - 195, 
						3 => array[290] - 50284, 
						4 => array[137] - 53863, 
						5 => 4, 
						6 => 14, 
						7 => 2, 
						8 => array[303] - 29956, 
						9 => array[285] - 35544, 
						10 => array2[267] - 6, 
						11 => array[271] - 14412, 
						_ => 2, 
					};
					continue;
				case 13:
				{
					int num6 = 396;
					num = ((824 < num4 / 2 - num6) ? (array[130] - 12762) : 9);
					continue;
				}
				case 7:
				case 12:
					obj2 = null;
					num2 = ((byte[])obj)[324] - (obj as byte[])[179];
					num = 16;
					continue;
				case 11:
					num2 = 11;
					num = 16;
					continue;
				case 10:
					num5 = ((byte[])obj)[608] - 146;
					goto IL_020a;
				case 9:
					num5 = 1;
					goto IL_020a;
				default:
					num = 15;
					continue;
				case 5:
					num3 = (int)(obj as byte[])[486] / 8;
					goto IL_0227;
				case 4:
					num4 = 1648;
					num = array[282] - 5199;
					continue;
				case 3:
					num3 = 10;
					goto IL_0227;
				case 2:
					num2 = (int)(obj as byte[])[401] / 4;
					num = 16;
					continue;
				case 1:
					num3 = (obj as byte[])[275] - (obj as byte[])[275];
					goto IL_0227;
				case 0:
					num2 = 2;
					num = 16;
					continue;
				case 15:
					break;
				case 22:
					{
						return (Assembly)((obj2 is _Assembly) ? obj2 : null);
					}
					IL_0227:
					num2 = num3;
					num = 16;
					continue;
					IL_020a:
					num2 = num5;
					num = 16;
					continue;
				}
				break;
			}
		}
	}

	internal static int CloneWindow<T>(T gparam_0, byte[] byte_0, int int_0, int int_1, short short_0, short short_1) where T : Stream
	{
		byte[] array = ResourceContext.previousId;
		int[] array2 = DeviceSerializer.previousId;
		int num4 = default(int);
		int num2 = default(int);
		int result = default(int);
		int num3 = default(int);
		while (true)
		{
			object obj = ResourceContext.previousId;
			Array array3 = DeviceSerializer.previousId;
			int num = array[259] - 113;
			while (true)
			{
				int num6;
				int num5;
				switch (num)
				{
				case 8:
				case 21:
					num4++;
					num2 = short_1 * short_1;
					num = array[144] - 97;
					continue;
				case 19:
					result = 15;
					num3 = (obj as int[])[60] - 30458;
					num = array2[223] - 65171;
					continue;
				case 18:
					num3 = 10;
					num = 17;
					continue;
				case 17:
					num = num3 switch
					{
						0 => 8, 
						1 => array[153] - 115, 
						2 => array[199] - array[288], 
						3 => array[126] - 214, 
						4 => 19, 
						5 => array2[284] - 9160, 
						6 => 19, 
						7 => array[329] - 216, 
						8 => 0, 
						9 => array2[75] - 19032, 
						10 => 9, 
						11 => 15, 
						_ => 18, 
					};
					continue;
				case 16:
					num3 = 2;
					num = 17;
					continue;
				case 15:
					result = PluginEditor.ReferenceFactory.CloneWindow((Stream)gparam_0, byte_0, int_0, int_1, 377, 'Ŷ');
					num = 11;
					continue;
				case 14:
					num6 = 6;
					goto IL_0167;
				case 13:
					num5 = 3;
					goto IL_0172;
				case 12:
					num = (((short_1 ^ short_0) - 34) ^ num4) switch
					{
						0 => array2[238] - 3175, 
						_ => array2[251] - 13489, 
					};
					continue;
				case 11:
					num3 = 0;
					num = 17;
					continue;
				case 10:
					num2 = short_1 + num2;
					num = 2;
					continue;
				case 9:
					num4 = 0;
					num3 = 2;
					num = 17;
					continue;
				case 7:
					num = array2[8] - 14725;
					continue;
				case 6:
					num6 = ((int[])obj)[166] - 38721;
					goto IL_0167;
				default:
					num = array[39];
					continue;
				case 3:
					num5 = ((byte[])array3)[129] - (array3 as byte[])[115];
					goto IL_0172;
				case 2:
					num3 = 8;
					goto case 7;
				case 0:
					num = ((num2 % 2 != 0) ? 3 : (array[225] - 203));
					continue;
				case 1:
				case 20:
					break;
				case 4:
					{
						return result;
					}
					IL_0172:
					num3 = num5;
					num = 17;
					continue;
					IL_0167:
					num3 = num6;
					num = 17;
					continue;
				}
				break;
			}
		}
	}

	internal static Evidence CloneWindow<T>(T gparam_0, short short_0, short short_1) where T : Assembly
	{
		int[] array = DeviceSerializer.previousId;
		byte[] array2 = ResourceContext.previousId;
		int num3 = default(int);
		int num5 = default(int);
		object obj = default(object);
		while (true)
		{
			Array array3 = DeviceSerializer.previousId;
			int num = array[29] - 42507;
			while (true)
			{
				int num2;
				int num4;
				switch (num)
				{
				case 17:
					num3 = 0;
					num = 16;
					continue;
				case 16:
					num = num3 switch
					{
						0 => 9, 
						1 => array2[202], 
						2 => (int)array2[267] / 8, 
						3 => 12, 
						4 => 0, 
						5 => 17, 
						6 => array2[207], 
						7 => 13, 
						8 => 13, 
						9 => array[213] - 48080, 
						10 => 0, 
						_ => 17, 
					};
					continue;
				case 15:
					num2 = 9;
					goto IL_00cb;
				case 2:
				case 11:
					num = 16;
					continue;
				case 14:
					num = array[302] - 8627;
					continue;
				case 13:
				{
					num5++;
					int num6 = 2334;
					int num7 = 162;
					num = ((778 < num6 / 3 - num7) ? (array[19] - 33113) : ((int)array2[104] / 4));
					continue;
				}
				case 12:
					num = (((short_0 ^ short_1) - 6) ^ num5) switch
					{
						0 => 1, 
						_ => array2[20], 
					};
					continue;
				case 10:
					obj = null;
					num3 = 8;
					goto case 14;
				case 9:
					num5 = 0;
					num3 = 3;
					num = array[178] - 34583;
					continue;
				case 8:
					num4 = ((byte[])array3)[539] - 232;
					goto IL_0172;
				case 6:
					num4 = 3;
					goto IL_0172;
				case 5:
					obj = PluginEditor.PaneProvider.CloneWindow<Assembly>((Assembly)gparam_0, 1014, 'Ϲ');
					num3 = 8;
					num = array[124] - 25672;
					continue;
				default:
					num = 7;
					continue;
				case 3:
					num3 = 3;
					num = 16;
					continue;
				case 1:
					num2 = 6;
					goto IL_00cb;
				case 7:
					break;
				case 0:
					{
						return (Evidence)(ICollection)obj;
					}
					IL_0172:
					num3 = num4;
					num = 16;
					continue;
					IL_00cb:
					num3 = num2;
					goto case 2;
				}
				break;
			}
		}
	}

	internal static bool CloneWindow<T>(T gparam_0, int int_0, short short_0) where T : string
	{
		byte[] array = ResourceContext.previousId;
		int[] array2 = DeviceSerializer.previousId;
		int num2 = default(int);
		int num4 = default(int);
		bool result = default(bool);
		while (true)
		{
			Array array3 = ResourceContext.previousId;
			Array array4 = DeviceSerializer.previousId;
			int num = 3;
			while (true)
			{
				int num3;
				int num5;
				switch (num)
				{
				case 19:
					num2 = 6;
					num = array[175];
					continue;
				case 18:
					num3 = 8;
					goto IL_0022;
				default:
					num = array[235] - 3;
					continue;
				case 15:
					num = (((int_0 ^ short_0) - 22) ^ num4) switch
					{
						0 => 12, 
						_ => 10, 
					};
					continue;
				case 14:
					num2 = 9;
					num = array2[178] - 34588;
					continue;
				case 13:
				{
					int num6 = 52;
					int num7 = 218;
					num = ((1962 > num7 - num6 * 9) ? 2 : 18);
					continue;
				}
				case 12:
					num5 = 3;
					goto IL_00a9;
				case 6:
					num = array2[173] - 20138;
					continue;
				case 11:
					num = num2 switch
					{
						0 => array[196] - array[160], 
						1 => 14, 
						2 => 17, 
						3 => array[39], 
						4 => 7, 
						5 => 17, 
						6 => 15, 
						7 => array2[304] - 24273, 
						8 => 5, 
						9 => 3, 
						10 => array2[146] - 26408, 
						11 => array2[197] - 16205, 
						_ => array2[69] - 6030, 
					};
					continue;
				case 10:
					num5 = ((int[])array3)[307] - 15645;
					goto IL_00a9;
				case 9:
					num2 = (array3 as int[])[69] - 11561;
					num = 11;
					continue;
				case 7:
					result = true;
					num2 = (array4 as byte[])[34];
					num = array2[243] - 889;
					continue;
				case 0:
				case 5:
					num2 = (array4 as byte[])[409];
					num = array[175];
					continue;
				case 4:
					num4++;
					num = (int)array[164] / 9;
					continue;
				case 3:
					num4 = 0;
					goto case 19;
				case 2:
					num3 = 5;
					goto IL_0022;
				case 1:
					result = PluginEditor.CloneWindow<string>((string)gparam_0, (short)757, 737);
					num2 = (array4 as byte[])[34];
					num = 11;
					continue;
				case 8:
					break;
				case 17:
					{
						return result;
					}
					IL_00a9:
					num2 = num5;
					goto case 6;
					IL_0022:
					num2 = num3;
					num = array2[147] - 12321;
					continue;
				}
				break;
			}
		}
	}

	internal static Encoding CloneWindow(int int_0, int int_1)
	{
		int[] array = DeviceSerializer.previousId;
		byte[] array2 = ResourceContext.previousId;
		int num3 = default(int);
		int num5 = default(int);
		int num4 = default(int);
		int num6 = default(int);
		object obj = default(object);
		while (true)
		{
			Array array3 = ResourceContext.previousId;
			Array array4 = DeviceSerializer.previousId;
			int num = array[95] - 53725;
			while (true)
			{
				int num2;
				int num8;
				switch (num)
				{
				case 19:
					num = 12;
					continue;
				case 18:
					num = 12;
					continue;
				case 16:
					num2 = (array4 as byte[])[409];
					goto IL_002e;
				case 14:
					num = (((int_0 ^ int_1) - 61) ^ num3) switch
					{
						0 => 9, 
						_ => array2[44] - 8, 
					};
					continue;
				case 13:
					num8 = 5;
					goto IL_005f;
				case 12:
					num = num5 switch
					{
						0 => 14, 
						1 => 8, 
						2 => array2[39] * 3, 
						3 => 6, 
						4 => 2, 
						5 => 5, 
						6 => array2[20], 
						7 => array[251] - 13495, 
						8 => 4, 
						9 => 7, 
						10 => array2[279] - array2[164], 
						11 => 1, 
						_ => 8, 
					};
					continue;
				case 3:
				case 11:
					num5 = 0;
					num = 12;
					continue;
				default:
					num = 17;
					continue;
				case 9:
					num8 = 4;
					goto IL_005f;
				case 8:
					num5 = (array3 as int[])[40] - 31437;
					num = 12;
					continue;
				case 7:
				{
					int num7 = num4;
					num6 = num7 * num7;
					num5 = ((byte[])array4)[46];
					goto case 19;
				}
				case 6:
					num3 = 0;
					num5 = (array4 as byte[])[157] - 254;
					num = array2[6] - 118;
					continue;
				case 5:
					obj = null;
					num5 = 11;
					num = 12;
					continue;
				case 4:
					num6 = num4 + num6;
					num = ((num6 % 2 == 0) ? 16 : 0);
					continue;
				case 2:
					obj = PluginEditor.PaneProvider.CloneWindow('\u030e', 817);
					num5 = (array3 as int[])[21] - 59036;
					num = array2[358] - 103;
					continue;
				case 1:
					num3++;
					num4 = 426;
					num = array2[345] - array2[152];
					continue;
				case 0:
					num2 = 0;
					goto IL_002e;
				case 17:
					break;
				case 15:
					{
						return (Encoding)(obj as ICloneable);
					}
					IL_005f:
					num5 = num8;
					goto case 18;
					IL_002e:
					num5 = num2;
					num = 12;
					continue;
				}
				break;
			}
		}
	}
}
