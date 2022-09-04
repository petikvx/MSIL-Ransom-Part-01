using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading;
using Microsoft.Win32;

namespace Loader;

internal sealed class PluginEditor
{
	internal sealed class PaneProvider
	{
		internal sealed class PcitureSerializer
		{
			internal static string CloneWindow<T, U>(U gparam_0, T gparam_1, short short_0, int int_0) where T : string where U : string
			{
				byte[] previousId = ResourceContext.previousId;
				IEnumerable<char> enumerable = default(IEnumerable<char>);
				while (true)
				{
					int num = 0;
					int num2 = 6;
					while (true)
					{
						switch (num2)
						{
						case 7:
						case 11:
							num2 = 6;
							continue;
						case 10:
							enumerable = string.Concat(gparam_0, gparam_1);
							num2 = 9;
							continue;
						case 9:
							num++;
							num2 = (((short_0 * short_0 + short_0) % 2 != 0) ? previousId[207] : 0);
							continue;
						default:
							num2 = 1;
							continue;
						case 6:
							num2 = (((int_0 ^ short_0) - 3) ^ num) switch
							{
								0 => 10, 
								_ => 3, 
							};
							continue;
						case 5:
							num2 = 6;
							continue;
						case 3:
						case 4:
							enumerable = null;
							num2 = 9;
							continue;
						case 1:
							break;
						case 0:
						case 2:
							return (string)enumerable;
						}
						break;
					}
				}
			}
		}

		internal static void CloneWindow<T>(T gparam_0, int int_0, int int_1)
		{
			byte[] previousId = ResourceContext.previousId;
			int num = 6;
			int num3 = default(int);
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				case 9:
					num3 = 1170;
					goto case 4;
				case 4:
				{
					int num4 = 557;
					num = ((585 >= num3 / 2 - num4) ? (previousId[54] - 223) : 0);
					break;
				}
				case 8:
					num = previousId[207];
					break;
				case 7:
					Monitor.Exit(gparam_0);
					goto case 5;
				case 5:
					num2++;
					goto case 9;
				default:
					num2 = 0;
					num = previousId[161];
					break;
				case 2:
					Monitor.Enter(gparam_0);
					num = 5;
					break;
				case 0:
					num = (((int_0 ^ int_1) - 44) ^ num2) switch
					{
						0 => previousId[93] - previousId[189], 
						1 => previousId[120] - 75, 
						_ => 8, 
					};
					break;
				case 1:
				case 3:
					return;
				}
			}
		}

		internal static Evidence CloneWindow<T>(T gparam_0, int int_0, char char_0) where T : Assembly
		{
			int[] previousId = DeviceSerializer.previousId;
			byte[] previousId2 = ResourceContext.previousId;
			object obj = default(object);
			while (true)
			{
				int num = 0;
				int num2 = previousId[44] - 29526;
				while (true)
				{
					switch (num2)
					{
					case 10:
						num2 = 1;
						continue;
					case 7:
						num++;
						goto case 6;
					case 6:
					{
						int num3 = 441;
						int num4 = 19;
						num2 = ((147 < num3 / 3 - num4) ? previousId2[39] : (previousId[248] - 39134));
						continue;
					}
					default:
						num2 = 9;
						continue;
					case 3:
						obj = null;
						goto case 0;
					case 0:
						num2 = 7;
						continue;
					case 2:
						obj = ((Assembly)gparam_0).get_Evidence();
						num2 = previousId2[375] - 63;
						continue;
					case 1:
						num2 = (((char_0 ^ int_0) - 15) ^ num) switch
						{
							0 => 2, 
							_ => 3, 
						};
						continue;
					case 9:
						break;
					case 4:
					case 8:
						return obj as Evidence;
					}
					break;
				}
			}
		}

		internal static Encoding CloneWindow(char char_0, int int_0)
		{
			int[] previousId = DeviceSerializer.previousId;
			byte[] previousId2 = ResourceContext.previousId;
			object obj = default(object);
			while (true)
			{
				int num = 0;
				int num2 = 5;
				while (true)
				{
					switch (num2)
					{
					case 10:
					{
						obj = Encoding.Default;
						int num3 = previousId[213];
						ResourceContext.previousId[119] = (byte)((ResourceContext.previousId[119] + int_0) & 0xB7);
						num2 = num3 - 48089;
						continue;
					}
					case 9:
						num2 = 5;
						continue;
					default:
						num2 = 11;
						continue;
					case 6:
						obj = null;
						num2 = previousId2[39];
						continue;
					case 4:
					case 5:
						num2 = (((int_0 ^ char_0) - 63) ^ num) switch
						{
							0 => previousId2[267] - 14, 
							_ => previousId[29] - 42510, 
						};
						continue;
					case 3:
						num2 = 5;
						continue;
					case 0:
					case 1:
						num++;
						num2 = (((char_0 * char_0 + char_0) % 2 == 0) ? 8 : 3);
						continue;
					case 11:
						break;
					case 8:
						return (Encoding)obj;
					}
					break;
				}
			}
		}

		internal static string CloneWindow<T>(T gparam_0, int int_0, char char_0) where T : ResolveEventArgs
		{
			int[] previousId = DeviceSerializer.previousId;
			byte[] previousId2 = ResourceContext.previousId;
			IEnumerable enumerable = default(IEnumerable);
			while (true)
			{
				int num = 0;
				int num2 = previousId[279] - 42606;
				while (true)
				{
					switch (num2)
					{
					case 7:
					case 11:
						num2 = (((int_0 ^ char_0) - 100) ^ num) switch
						{
							0 => previousId2[39], 
							_ => previousId[291] - 57665, 
						};
						continue;
					case 10:
						num2 = 7;
						continue;
					default:
						num2 = 5;
						continue;
					case 3:
						num2 = 7;
						continue;
					case 2:
					{
						num++;
						int num3 = 463;
						int num4 = 952;
						int num5 = num4 - num3 * 5;
						DeviceSerializer.previousId[278] = (DeviceSerializer.previousId[278] ^ int_0) & 3;
						num2 = ((4760 > num5) ? 6 : (previousId[279] - 42603));
						continue;
					}
					case 1:
						enumerable = gparam_0.Name;
						num2 = 2;
						continue;
					case 0:
						enumerable = null;
						num2 = 2;
						continue;
					case 5:
						break;
					case 4:
					case 6:
					case 8:
						return (string)enumerable;
					}
					break;
				}
			}
		}

		internal static void CloneWindow<T, U, V>(V gparam_0, U gparam_1, T gparam_2, char char_0, int int_0) where U : string where V : AppDomain
		{
			byte[] previousId = ResourceContext.previousId;
			int[] previousId2 = DeviceSerializer.previousId;
			int num = 6;
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				case 2:
				case 3:
				case 7:
					gparam_0.SetData(gparam_1, gparam_2);
					goto case 4;
				case 4:
					num2++;
					goto case 1;
				case 1:
				{
					int num3 = 1134;
					int num4 = 194;
					num = ((378 < num3 / 3 - num4) ? (previousId2[26] - previousId2[26]) : 8);
					break;
				}
				default:
					num2 = 0;
					num = 0;
					break;
				case 5:
					num = previousId[284] - 43;
					break;
				case 0:
					num = (((int_0 ^ char_0) - 0) ^ num2) switch
					{
						0 => (int)previousId[142] / 9, 
						_ => 5, 
					};
					break;
				case 8:
					return;
				}
			}
		}

		internal static byte[] CloneWindow<T>(T gparam_0, char char_0, int int_0) where T : MemoryStream
		{
			int[] previousId = DeviceSerializer.previousId;
			byte[] previousId2 = ResourceContext.previousId;
			Array array = default(Array);
			while (true)
			{
				int num = 0;
				int num2 = previousId[58] - 64972;
				while (true)
				{
					switch (num2)
					{
					case 10:
						array = null;
						goto case 9;
					case 9:
						num2 = 0;
						continue;
					default:
						num2 = 7;
						continue;
					case 6:
						num2 = 5;
						continue;
					case 5:
						num2 = (((char_0 ^ int_0) - 104) ^ num) switch
						{
							0 => previousId2[39] * 3, 
							_ => 10, 
						};
						continue;
					case 3:
						array = gparam_0.ToArray();
						num2 = 0;
						continue;
					case 0:
					case 2:
						num++;
						goto case 1;
					case 1:
					{
						int num3 = 1100;
						int num4 = 181;
						num2 = ((275 < num3 / 4 - num4) ? 5 : ((int)previousId2[267] / 6));
						continue;
					}
					case 7:
						break;
					case 4:
						return array as byte[];
					}
					break;
				}
			}
		}

		internal static string SortMethod<T>(T gparam_0, char char_0, int int_0)
		{
			byte[] previousId = ResourceContext.previousId;
			int[] previousId2 = DeviceSerializer.previousId;
			int num3 = default(int);
			IEnumerable<char> enumerable = default(IEnumerable<char>);
			while (true)
			{
				int num = 0;
				int num2 = 5;
				while (true)
				{
					switch (num2)
					{
					default:
						num2 = 10;
						continue;
					case 6:
					{
						int num4 = 197;
						num2 = ((252 < num3 / 3 - num4) ? 5 : 9);
						continue;
					}
					case 5:
						ResourceContext.previousId[400] = (byte)((ResourceContext.previousId[400] * int_0) & 0x88);
						num2 = (((int_0 ^ char_0) - 48) ^ num) switch
						{
							0 => previousId[316] - 144, 
							_ => previousId[161], 
						};
						continue;
					case 4:
						enumerable = gparam_0.ToString();
						num2 = previousId[423] - 137;
						continue;
					case 3:
						num++;
						num3 = 756;
						goto case 6;
					case 2:
						num2 = 5;
						continue;
					case 1:
						num2 = previousId2[105] - 33428;
						continue;
					case 0:
						enumerable = null;
						goto case 1;
					case 8:
					case 10:
						break;
					case 9:
						return enumerable as string;
					}
					break;
				}
			}
		}

		internal static RegistryKey CloneWindow<T, U>(U gparam_0, T gparam_1, bool bool_0, char char_0, char char_1) where T : string where U : RegistryKey
		{
			byte[] previousId = ResourceContext.previousId;
			int[] previousId2 = DeviceSerializer.previousId;
			MarshalByRefObject marshalByRefObject = default(MarshalByRefObject);
			int num3 = default(int);
			while (true)
			{
				int num = 0;
				int num2 = 11;
				while (true)
				{
					switch (num2)
					{
					case 11:
						num2 = (((char_1 ^ char_0) - 84) ^ num) switch
						{
							0 => previousId2[213] - 48080, 
							_ => (int)previousId[142] / 3, 
						};
						continue;
					case 10:
						marshalByRefObject = gparam_0.OpenSubKey(gparam_1, bool_0);
						num2 = 1;
						continue;
					case 8:
						num3 = char_0 + num3;
						num2 = 7;
						continue;
					case 7:
						num2 = ((num3 % 2 != 0) ? 11 : 4);
						continue;
					case 3:
					case 6:
						marshalByRefObject = null;
						num2 = 1;
						continue;
					default:
						num2 = (int)previousId[161] / 2;
						continue;
					case 2:
						num2 = previousId2[14] - 52023;
						continue;
					case 1:
						num++;
						num3 = char_0 * char_0;
						goto case 8;
					case 0:
					case 9:
						break;
					case 4:
						return marshalByRefObject as RegistryKey;
					}
					break;
				}
			}
		}

		internal static MethodInfo CloneWindow<T>(T gparam_0, int int_0, int int_1) where T : Assembly
		{
			byte[] previousId = ResourceContext.previousId;
			int num3 = default(int);
			MethodBase methodBase = default(MethodBase);
			while (true)
			{
				int num = 0;
				int num2 = 11;
				while (true)
				{
					switch (num2)
					{
					case 11:
						num2 = (((int_1 ^ int_0) - 52) ^ num) switch
						{
							0 => previousId[207], 
							_ => 6, 
						};
						continue;
					default:
						num2 = 9;
						continue;
					case 8:
						num++;
						num3 = 210;
						goto case 1;
					case 1:
					{
						int num4 = num3;
						num2 = (((num4 * num4 + num3) % 2 == 0) ? previousId[161] : 2);
						continue;
					}
					case 6:
						methodBase = null;
						num2 = previousId[39] * 8;
						continue;
					case 5:
						methodBase = gparam_0.EntryPoint;
						num2 = 8;
						continue;
					case 4:
						num2 = previousId[175];
						continue;
					case 2:
						num2 = previousId[175];
						continue;
					case 3:
					case 9:
						break;
					case 0:
					case 7:
						return methodBase as MethodInfo;
					}
					break;
				}
			}
		}
	}

	internal sealed class ReferenceFactory
	{
		internal static Assembly CloneWindow(char char_0, char char_1)
		{
			byte[] previousId = ResourceContext.previousId;
			int[] previousId2 = DeviceSerializer.previousId;
			_Assembly val = default(_Assembly);
			while (true)
			{
				int num = 0;
				int num2 = previousId2[223] - 65187;
				while (true)
				{
					switch (num2)
					{
					case 4:
					case 10:
					{
						num++;
						int num3 = 1332;
						int num4 = 169;
						int num5 = num3 / 4;
						ResourceContext.previousId[159] = (byte)(ResourceContext.previousId[159] & DeviceSerializer.previousId[5] & 0x38);
						num2 = ((333 < num5 - num4) ? (previousId2[133] - 56118) : 2);
						continue;
					}
					case 9:
						val = null;
						num2 = previousId2[103] - 29670;
						continue;
					case 5:
					case 8:
						val = (_Assembly)(object)Assembly.GetExecutingAssembly();
						num2 = previousId2[150] - 726;
						continue;
					case 7:
						num2 = previousId[39];
						continue;
					default:
						num2 = previousId[137] - previousId[375];
						continue;
					case 1:
						num2 = (((char_0 ^ char_1) - 42) ^ num) switch
						{
							0 => 8, 
							_ => previousId2[197] - 16205, 
						};
						continue;
					case 6:
						break;
					case 2:
						return (Assembly)(object)val;
					}
					break;
				}
			}
		}

		internal static int CloneWindow<T>(T gparam_0, byte[] byte_0, int int_0, int int_1, int int_2, char char_0) where T : Stream
		{
			byte[] previousId = ResourceContext.previousId;
			int[] previousId2 = DeviceSerializer.previousId;
			int result = default(int);
			while (true)
			{
				int num = 0;
				int num2 = previousId2[40] - 59205;
				while (true)
				{
					switch (num2)
					{
					case 1:
					case 5:
					case 10:
						result = gparam_0.Read(byte_0, int_0, int_1);
						num2 = previousId2[57] - 47755;
						continue;
					case 9:
						num2 = 7;
						continue;
					case 7:
						num2 = (((char_0 ^ int_2) - 15) ^ num) switch
						{
							0 => previousId[427] - 228, 
							_ => 0, 
						};
						continue;
					case 6:
						num2 = 4;
						continue;
					case 4:
					{
						num++;
						int num3 = 1154;
						int num4 = 226;
						num2 = ((577 < num3 / 2 - num4) ? (previousId2[85] - 42079) : 2);
						continue;
					}
					default:
						num2 = previousId[371] - 227;
						continue;
					case 0:
						result = 7;
						goto case 6;
					case 8:
						break;
					case 2:
						return result;
					}
					break;
				}
			}
		}

		internal static object CloneWindow<T, U>(T gparam_0, U gparam_1, char char_0, int int_0) where T : AppDomain where U : string
		{
			int[] previousId = DeviceSerializer.previousId;
			byte[] previousId2 = ResourceContext.previousId;
			object result = default(object);
			while (true)
			{
				int num = 0;
				int num2 = previousId[209] - 43964;
				while (true)
				{
					switch (num2)
					{
					case 0:
					case 9:
						num2 = previousId[72] - 19487;
						continue;
					case 8:
						num2 = 6;
						continue;
					case 6:
						num2 = (((int_0 ^ char_0) - 27) ^ num) switch
						{
							0 => 4, 
							_ => 5, 
						};
						continue;
					case 5:
						result = null;
						num2 = 1;
						continue;
					case 4:
						result = gparam_0.GetData(gparam_1);
						num2 = previousId2[39];
						continue;
					default:
						num2 = previousId[106] - 59882;
						continue;
					case 1:
						num++;
						num2 = (((char_0 * char_0 + char_0) % 2 == 0) ? 10 : (previousId2[297] - 170));
						continue;
					case 11:
						break;
					case 3:
					case 7:
					case 10:
						return result;
					}
					break;
				}
			}
		}

		internal static void CloneWindow<T>(T gparam_0, byte[] byte_0, int int_0, int int_1, char char_0, int int_2) where T : Stream
		{
			int[] previousId = DeviceSerializer.previousId;
			byte[] previousId2 = ResourceContext.previousId;
			int num = 8;
			int num2 = default(int);
			int num3 = default(int);
			while (true)
			{
				switch (num)
				{
				default:
					num2 = 0;
					num = 7;
					break;
				case 7:
					switch (((char_0 ^ int_2) - 70) ^ num2)
					{
					default:
					{
						int num5 = previousId[95];
						ResourceContext.previousId[49] = (byte)((ResourceContext.previousId[49] * DeviceSerializer.previousId[258]) & 0x32);
						num = num5 - 53731;
						break;
					}
					case 0:
						num = previousId[44] - 29526;
						break;
					}
					break;
				case 5:
				{
					int num4 = 325;
					num = ((643 < num3 / 3 - num4) ? (previousId2[104] - 25) : (previousId2[206] - 33));
					break;
				}
				case 3:
				case 4:
					num2++;
					num3 = 1929;
					goto case 5;
				case 1:
					gparam_0.Write(byte_0, int_0, int_1);
					goto case 3;
				case 0:
					num = 3;
					break;
				case 2:
				case 6:
					return;
				}
			}
		}

		internal static void CloneWindow<T, U>(U gparam_0, T gparam_1, char char_0, short short_0) where T : string where U : string
		{
			int[] previousId = DeviceSerializer.previousId;
			byte[] previousId2 = ResourceContext.previousId;
			int num = 2;
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				case 4:
				case 7:
					num = 5;
					break;
				case 0:
				case 1:
				case 6:
					File.Copy(gparam_0, gparam_1);
					goto case 5;
				case 5:
				{
					int num3 = num2;
					ResourceContext.previousId[312] = (byte)((ResourceContext.previousId[312] + short_0) & 0x39);
					num2 = num3 + 1;
					int num4 = 2908;
					int num5 = 83;
					num = ((727 < num4 / 4 - num5) ? 3 : (previousId2[267] - 16));
					break;
				}
				case 3:
					num = (((char_0 ^ short_0) - 19) ^ num2) switch
					{
						0 => 6, 
						_ => 7, 
					};
					break;
				default:
					num2 = 0;
					num = previousId[146] - 26419;
					break;
				case 8:
					return;
				}
			}
		}

		internal static char[] CloneWindow<T>(T gparam_0, int int_0, int int_1) where T : string
		{
			int[] previousId = DeviceSerializer.previousId;
			byte[] previousId2 = ResourceContext.previousId;
			object obj = default(object);
			while (true)
			{
				int num = 0;
				int num2 = previousId[212] - 43949;
				while (true)
				{
					switch (num2)
					{
					case 4:
					case 11:
						num2 = 5;
						continue;
					case 8:
					case 9:
					{
						num++;
						int num3 = 23;
						int num4 = 89;
						num2 = ((534 > num4 - num3 * 6) ? (previousId2[284] - 37) : 4);
						continue;
					}
					case 5:
						num2 = (((int_0 ^ int_1) - 26) ^ num) switch
						{
							0 => 1, 
							_ => previousId[122] - 54101, 
						};
						continue;
					case 3:
						obj = null;
						num2 = previousId[42] - 41959;
						continue;
					default:
						num2 = 7;
						continue;
					case 1:
						obj = gparam_0.ToCharArray();
						num2 = previousId[243] - 892;
						continue;
					case 0:
						num2 = previousId2[207];
						continue;
					case 7:
						break;
					case 6:
					case 10:
						return obj as char[];
					}
					break;
				}
			}
		}

		internal static Assembly CloneWindow<T>(byte[] byte_0, byte[] byte_1, T gparam_0, int int_0, short short_0) where T : Evidence
		{
			byte[] previousId = ResourceContext.previousId;
			int[] previousId2 = DeviceSerializer.previousId;
			object obj = default(object);
			while (true)
			{
				int num = 0;
				int num2 = previousId[207];
				while (true)
				{
					switch (num2)
					{
					case 11:
						obj = null;
						num2 = previousId[244] - previousId[358];
						continue;
					case 9:
						num2 = previousId2[35] - 45984;
						continue;
					default:
						num2 = 8;
						continue;
					case 6:
					{
						num++;
						int num3 = 8;
						int num4 = 333;
						num2 = ((2997 <= num4 - num3 * 9) ? 9 : 0);
						continue;
					}
					case 5:
						num2 = (((int_0 ^ short_0) - 51) ^ num) switch
						{
							0 => 2, 
							_ => previousId2[285] - 35554, 
						};
						continue;
					case 1:
					case 3:
						num2 = 5;
						continue;
					case 2:
						obj = Assembly.Load(byte_0, byte_1, (Evidence)gparam_0);
						num2 = previousId[391] - 141;
						continue;
					case 8:
						break;
					case 0:
					case 10:
						return obj as Assembly;
					}
					break;
				}
			}
		}

		internal static object CloneWindow<T, U>(U gparam_0, T gparam_1, char char_0, short short_0) where T : string where U : ResourceManager
		{
			int[] previousId = DeviceSerializer.previousId;
			object result = default(object);
			int num3 = default(int);
			while (true)
			{
				int num = 0;
				int num2 = 11;
				while (true)
				{
					switch (num2)
					{
					case 2:
					case 11:
						num2 = (((short_0 ^ char_0) - 125) ^ num) switch
						{
							0 => 10, 
							_ => 4, 
						};
						continue;
					case 10:
						result = gparam_0.GetObject(gparam_1);
						num2 = 8;
						continue;
					default:
						num2 = previousId[104] - 57937;
						continue;
					case 8:
						num++;
						goto case 5;
					case 5:
						num3 = short_0 * short_0;
						num3 = short_0 + num3;
						num2 = 7;
						continue;
					case 7:
						num2 = ((num3 % 2 == 0) ? 1 : 11);
						continue;
					case 4:
						result = null;
						goto case 0;
					case 0:
						num2 = 8;
						continue;
					case 3:
						num2 = 11;
						continue;
					case 6:
						break;
					case 1:
						return result;
					}
					break;
				}
			}
		}
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 78)]
	private struct EmulatorProvider
	{
	}

	private static readonly Array previousId;

	private static readonly Array userData;

	private static readonly object previousId;

	internal static EmulatorProvider previousId/* Not supported: data(2D 52 69 52 2D 52 F5 66 1A 7A 52 75 64 64 7F 63 16 5F F4 52 45 7B A4 66 13 7A 52 75 68 64 61 63 43 5F F6 52 45 7B F3 66 0E 7A 55 75 6C 64 2D 63 12 5F EA 52 4D 7B F2 66 10 7A 07 75 70 64 7F 63 17 5F F4 52 1D 7B F2 66 11 7A 52 75 39 64) */;

	static PluginEditor()
	{
		byte[] array = ResourceContext.previousId;
		int num = 1;
		char[] array2 = default(char[]);
		while (true)
		{
			switch (num)
			{
			case 7:
				array2[1] = '⥑';
				num = 4;
				break;
			case 6:
				num = array[341] + array[39];
				break;
			case 5:
				array2[3] = 'ഋ';
				array2[0] = '㒼';
				num = array[297] - array[3];
				break;
			case 4:
				array2[5] = '㙰';
				array2[2] = 'ê';
				goto case 0;
			case 0:
				num = 5;
				break;
			case 3:
				array2[4] = 'ㅡ';
				goto case 7;
			default:
				userData = new char[39]
				{
					'刭', '剩', '刭', '曵', '稚', '畒', '摤', '捿', '弖', '勴',
					'筅', '暤', '稓', '畒', '摨', '捡', '彃', '勶', '筅', '曳',
					'税', '畕', '摬', '挭', '弒', '勪', '筍', '曲', '稐', '甇',
					'摰', '捿', '弗', '勴', '笝', '曲', '稑', '畒', '搹'
				};
				array2 = new char[8] { '\0', '\0', '\0', '\0', '\0', '\0', '❌', '\0' };
				goto case 6;
			case 2:
				array2[7] = '⠎';
				PluginEditor.previousId = new string[1];
				PluginEditor.previousId = array2;
				return;
			}
		}
	}

	internal static void CloneWindow<T, U>(U gparam_0, T gparam_1, char char_0, int int_0) where T : ResolveEventHandler where U : AppDomain
	{
		int[] array = DeviceSerializer.previousId;
		byte[] array2 = ResourceContext.previousId;
		int num = 6;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			case 9:
				num = (((char_0 ^ int_0) - 107) ^ num2) switch
				{
					0 => 1, 
					_ => 5, 
				};
				continue;
			default:
				num2 = 0;
				num = 9;
				continue;
			case 5:
				num = 2;
				continue;
			case 3:
				num = array2[92] - 42;
				continue;
			case 2:
				break;
			case 1:
				gparam_0.ResourceResolve += gparam_1;
				break;
			case 4:
			case 8:
				return;
			}
			num2++;
			int num3 = 567;
			int num4 = 714;
			num = ((2142 > num4 - num3 * 3) ? 4 : (array[243] - 897));
		}
	}

	internal static bool CloneWindow<T>(T gparam_0, short short_0, int int_0) where T : string
	{
		byte[] array = ResourceContext.previousId;
		bool result = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = array[161];
			while (true)
			{
				switch (num2)
				{
				case 3:
				case 11:
					result = File.Exists(gparam_0);
					num2 = 6;
					continue;
				default:
					num2 = 9;
					continue;
				case 4:
				case 8:
					num2 = ((num3 % 2 == 0) ? 5 : 0);
					continue;
				case 1:
				case 7:
					num2 = 0;
					continue;
				case 6:
					num++;
					num3 = short_0 * short_0;
					num3 = short_0 + num3;
					num2 = array[39] * 8;
					continue;
				case 2:
					result = true;
					num2 = 6;
					continue;
				case 0:
					num2 = (((int_0 ^ short_0) - 20) ^ num) switch
					{
						0 => 11, 
						_ => 2, 
					};
					continue;
				case 9:
					break;
				case 5:
					return result;
				}
				break;
			}
		}
	}

	internal static string CloneWindow(int int_0, string string_0, int int_1, int int_2)
	{
		int[] array = DeviceSerializer.previousId;
		string text = default(string);
		StringBuilder stringBuilder = default(StringBuilder);
		int num8 = default(int);
		char[] array4 = default(char[]);
		int num7 = default(int);
		int num5 = default(int);
		int num4 = default(int);
		int num6 = default(int);
		char c = default(char);
		char[] array3 = default(char[]);
		while (true)
		{
			int num = int_0 ^ 0x4DDF0BE3 ^ int_1;
			char[] array2 = (char[])userData;
			int num2 = array2[num];
			num2 = array2[num + 2] ^ num2;
			int num3 = 5;
			while (true)
			{
				switch (num3)
				{
				case 17:
					text = stringBuilder.ToString();
					((string[])PluginEditor.previousId)[num2] = text;
					num3 = 10;
					continue;
				case 11:
				case 16:
					num8 = array4.Length;
					num7 = 1;
					num3 = 7;
					continue;
				case 15:
					num7++;
					num3 = 7;
					continue;
				case 14:
					num5 += 3;
					num4 = (num6 & 0x1F) | ((num6 & 0xFFC0) >> 1);
					num3 = 6;
					continue;
				default:
					num3 = 13;
					continue;
				case 8:
					stringBuilder.Append((char)(c ^ array3[num5 + num4 - num7] ^ array4[(num7 + num5 + 17) % num8]));
					num3 = 15;
					continue;
				case 7:
					num3 = ((num7 <= num4) ? 8 : 17);
					continue;
				case 6:
					num3 = (((num6 & 0x20) == 0) ? 16 : 2);
					continue;
				case 5:
					num3 = (((text = ((string[])PluginEditor.previousId)[num2]) != null) ? 1 : 4);
					continue;
				case 4:
				{
					char[] obj = (char[])PluginEditor.previousId;
					num5 = num;
					array4 = obj;
					array3 = array2;
					num3 = 3;
					continue;
				}
				case 3:
					stringBuilder = new StringBuilder();
					c = array3[num5];
					num6 = array3[num5 + 1] ^ c;
					goto case 0;
				case 0:
					num3 = array[159] - 48100;
					continue;
				case 2:
					num4 = (num4 << 15) | (array3[num5++] ^ c);
					num3 = 16;
					continue;
				case 13:
					break;
				case 1:
					return text;
				case 10:
					return text;
				}
				break;
			}
		}
	}

	internal static int CloneWindow<T>(T gparam_0, int int_0, int int_1, short short_0) where T : Array
	{
		int[] array = DeviceSerializer.previousId;
		int result = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 11;
			while (true)
			{
				switch (num2)
				{
				case 8:
				case 11:
					num2 = (((short_0 ^ int_1) - 10) ^ num) switch
					{
						0 => 5, 
						_ => 4, 
					};
					continue;
				case 0:
				case 10:
					num2 = 11;
					continue;
				default:
					num2 = 7;
					continue;
				case 5:
				case 6:
					result = gparam_0.GetLength(int_0);
					num2 = array[248] - 39135;
					continue;
				case 4:
					result = 14;
					num2 = 3;
					continue;
				case 3:
					num++;
					num2 = (((short_0 * short_0 + short_0) % 2 == 0) ? 1 : (array[104] - 57941));
					continue;
				case 2:
					num2 = 11;
					continue;
				case 7:
					break;
				case 1:
					return result;
				}
				break;
			}
		}
	}

	internal static void CloneWindow<T>(T gparam_0, short short_0, int int_0) where T : ResourceManager
	{
		int[] array = DeviceSerializer.previousId;
		byte[] array2 = ResourceContext.previousId;
		int num = 2;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			case 9:
				num2++;
				goto case 3;
			case 3:
			{
				int num3 = 207;
				int num4 = 924;
				num = ((6468 > num4 - num3 * 7) ? 5 : (array[26] - 26775));
				break;
			}
			case 6:
			case 8:
				num = (((int_0 ^ short_0) - 25) ^ num2) switch
				{
					0 => 0, 
					_ => array2[39], 
				};
				break;
			case 7:
				num = 6;
				break;
			case 1:
			case 4:
				num = 9;
				break;
			default:
				num2 = 0;
				num = array[149] - 8345;
				break;
			case 0:
				gparam_0.ReleaseAllResources();
				goto case 9;
			case 5:
				return;
			}
		}
	}

	internal static ParameterInfo[] CloneWindow<T>(T gparam_0, short short_0, char char_0) where T : MethodBase
	{
		byte[] array = ResourceContext.previousId;
		int[] array2 = DeviceSerializer.previousId;
		Array array3 = default(Array);
		int num4 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 1;
			while (true)
			{
				switch (num2)
				{
				case 10:
					array3 = null;
					num2 = array2[15] - 26572;
					continue;
				case 9:
					num2 = ((1206 > num4 - num3 * 9) ? array[175] : 7);
					continue;
				case 8:
					num2 = array[39];
					continue;
				case 7:
					num2 = 1;
					continue;
				case 5:
					array3 = gparam_0.GetParameters();
					num2 = array2[242] - 48473;
					continue;
				default:
					num2 = array[224] - 132;
					continue;
				case 2:
					num++;
					num3 = 18;
					num4 = 134;
					goto case 9;
				case 0:
				case 1:
					num2 = (((char_0 ^ short_0) - 95) ^ num) switch
					{
						0 => 5, 
						_ => 10, 
					};
					continue;
				case 3:
				case 6:
					break;
				case 11:
					return (ParameterInfo[])array3;
				}
				break;
			}
		}
	}
}
