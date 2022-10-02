using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Policy;
using System.Text;

namespace ns0;

internal sealed class Class10
{
	internal sealed class Class11
	{
		internal sealed class Class12
		{
			internal static void smethod_0<T, U>(T gparam_0, U gparam_1, char char_0, char char_1) where T : AppDomain where U : ResolveEventHandler
			{
				int[] int_ = Class0.int_0;
				char[] char_2 = Class1.char_1;
				int num = 3;
				int num2 = default(int);
				int num3 = default(int);
				while (true)
				{
					switch (num)
					{
					case 8:
					case 9:
						num = char_2[193] - 16730;
						break;
					case 7:
						gparam_0.ResourceResolve += gparam_1;
						num = 6;
						break;
					case 6:
						num2++;
						goto case 5;
					case 5:
						num3 = 137;
						goto case 1;
					case 1:
					{
						int num4 = 368;
						num = ((3312 > num4 - num3 * 9) ? 10 : 4);
						break;
					}
					case 4:
						num = 0;
						break;
					default:
						num2 = 0;
						num = int_[107] - int_[107];
						break;
					case 2:
						gparam_0.AssemblyResolve += gparam_1;
						goto case 6;
					case 0:
						num = (((char_1 ^ char_0) - 66) ^ num2) switch
						{
							0 => 7, 
							1 => 2, 
							_ => 8, 
						};
						break;
					case 10:
						return;
					}
				}
			}

			internal static int smethod_1<T>(T gparam_0, short short_0, short short_1) where T : BinaryReader
			{
				char[] char_ = Class1.char_1;
				int[] int_ = Class0.int_0;
				int num3 = default(int);
				int result = default(int);
				while (true)
				{
					int num = 0;
					int num2 = char_[99] - 50367;
					while (true)
					{
						switch (num2)
						{
						case 5:
						case 10:
							num2 = 6;
							continue;
						case 0:
						case 1:
						case 9:
							num++;
							num3 = short_0 * short_0;
							num3 = short_0 + num3;
							num2 = 4;
							continue;
						default:
							num2 = 2;
							continue;
						case 7:
							result = 7;
							num2 = int_[28] - 2685;
							continue;
						case 6:
							num2 = (((short_1 ^ short_0) - 44) ^ num) switch
							{
								0 => int_[281] - 16746, 
								_ => 7, 
							};
							continue;
						case 4:
							num2 = ((num3 % 2 != 0) ? (int_[70] - 12775) : 11);
							continue;
						case 3:
							result = gparam_0.ReadInt32();
							num2 = 1;
							continue;
						case 2:
							break;
						case 11:
							return result;
						}
						break;
					}
				}
			}

			internal static Assembly smethod_2(int int_0, char char_0)
			{
				int[] int_ = Class0.int_0;
				char[] char_ = Class1.char_1;
				ICustomAttributeProvider customAttributeProvider = default(ICustomAttributeProvider);
				int num3 = default(int);
				while (true)
				{
					int num = 0;
					int num2 = int_[105] - 29992;
					while (true)
					{
						switch (num2)
						{
						default:
						{
							int num4 = int_[337];
							Class0.int_0[221] = (Class0.int_0[221] * int_0) & 0x36;
							num2 = num4 - 1762;
							continue;
						}
						case 10:
							customAttributeProvider = Assembly.GetExecutingAssembly();
							num2 = char_[48] - 24013;
							continue;
						case 9:
							num2 = 5;
							continue;
						case 8:
							num2 = (((int_0 ^ char_0) - 2) ^ num) switch
							{
								0 => 10, 
								_ => int_[103] - 47436, 
							};
							continue;
						case 5:
							num++;
							num3 = char_0 * char_0;
							num3 = char_0 + num3;
							num2 = int_[355] - 49483;
							continue;
						case 3:
							customAttributeProvider = null;
							goto case 9;
						case 1:
							num2 = ((num3 % 2 != 0) ? 8 : 7);
							continue;
						case 0:
							num2 = 8;
							continue;
						case 4:
							break;
						case 7:
							return (Assembly)customAttributeProvider;
						}
						break;
					}
				}
			}

			internal static string[] smethod_3<T>(T gparam_0, char char_0, int int_0) where T : Assembly
			{
				int[] int_ = Class0.int_0;
				char[] char_ = Class1.char_1;
				object obj = default(object);
				while (true)
				{
					int num = 0;
					int num2 = int_[365] - 50098;
					while (true)
					{
						switch (num2)
						{
						case 10:
							num2 = (((char_0 ^ int_0) - 47) ^ num) switch
							{
								0 => 2, 
								_ => 4, 
							};
							continue;
						case 6:
						case 9:
						{
							num++;
							int num3 = 2676;
							int num4 = 620;
							num2 = ((669 < num3 / 4 - num4) ? 10 : 8);
							continue;
						}
						default:
							num2 = 7;
							continue;
						case 0:
						case 4:
							obj = null;
							num2 = int_[320] - 17433;
							continue;
						case 3:
							num2 = char_[266] - 36896;
							continue;
						case 2:
							obj = gparam_0.GetManifestResourceNames();
							num2 = int_[44] - 12402;
							continue;
						case 7:
							break;
						case 8:
							return (string[])obj;
						}
						break;
					}
				}
			}

			internal static string smethod_4<T>(T gparam_0, char char_0, short short_0)
			{
				int[] int_ = Class0.int_0;
				char[] char_ = Class1.char_1;
				IComparable comparable = default(IComparable);
				while (true)
				{
					int num = 0;
					int num2 = 2;
					while (true)
					{
						switch (num2)
						{
						case 9:
							num++;
							goto case 3;
						case 3:
						{
							int num3 = 414;
							int num4 = 73;
							num2 = ((207 < num3 / 2 - num4) ? (char_[322] - 33785) : 0);
							continue;
						}
						case 1:
						case 8:
							comparable = gparam_0.ToString();
							num2 = 9;
							continue;
						case 7:
							comparable = null;
							num2 = char_[284] - 49266;
							continue;
						default:
							num2 = int_[69] - 12061;
							continue;
						case 5:
							num2 = 2;
							continue;
						case 2:
						case 4:
							num2 = (((char_0 ^ short_0) - 127) ^ num) switch
							{
								0 => 1, 
								_ => int_[224] - 9394, 
							};
							continue;
						case 10:
							break;
						case 0:
							return (string)comparable;
						}
						break;
					}
				}
			}

			internal static Encoding smethod_5(short short_0, short short_1)
			{
				char[] char_ = Class1.char_1;
				int[] int_ = Class0.int_0;
				int num3 = default(int);
				object obj = default(object);
				while (true)
				{
					int num = 0;
					int num2 = 2;
					while (true)
					{
						switch (num2)
						{
						case 11:
							num2 = 2;
							continue;
						case 10:
							num++;
							num3 = short_0 * short_0;
							num3 = short_0 + num3;
							num2 = 0;
							continue;
						case 4:
						case 9:
							obj = null;
							num2 = int_[2] - 36228;
							continue;
						case 5:
						case 8:
							obj = Encoding.Default;
							num2 = 10;
							continue;
						default:
							num2 = 1;
							continue;
						case 2:
							num2 = (((short_0 ^ short_1) - 46) ^ num) switch
							{
								0 => char_[382] - 4421, 
								_ => char_[400] - 51782, 
							};
							continue;
						case 0:
							num2 = ((num3 % 2 != 0) ? 2 : (char_[56] - 6548));
							continue;
						case 1:
							break;
						case 3:
						case 6:
							return obj as Encoding;
						}
						break;
					}
				}
			}

			internal static string smethod_6<T>(T gparam_0, int int_0, short short_0) where T : string
			{
				char[] char_ = Class1.char_1;
				int[] int_ = Class0.int_0;
				IEnumerable<char> enumerable = default(IEnumerable<char>);
				while (true)
				{
					int num = 0;
					int num2 = 11;
					while (true)
					{
						switch (num2)
						{
						case 11:
							num2 = (((short_0 ^ int_0) - 99) ^ num) switch
							{
								0 => 9, 
								_ => 5, 
							};
							continue;
						case 10:
							num2 = 11;
							continue;
						case 8:
						case 9:
							enumerable = gparam_0.ToLowerInvariant();
							num2 = 3;
							continue;
						case 6:
							num2 = char_[162] - 47647;
							continue;
						case 5:
							enumerable = null;
							goto case 6;
						case 4:
							num2 = 11;
							continue;
						case 3:
						{
							num++;
							int num3 = 66;
							int num4 = 834;
							num2 = ((1668 > num4 - num3 * 2) ? 2 : (int_[389] - 65021));
							continue;
						}
						default:
							num2 = 7;
							continue;
						case 7:
							break;
						case 2:
							return (string)enumerable;
						}
						break;
					}
				}
			}
		}

		internal static void smethod_0<T>(T gparam_0, byte[] byte_0, int int_0, int int_1, short short_0, short short_1) where T : Stream
		{
			int[] int_2 = Class0.int_0;
			char[] char_ = Class1.char_1;
			int num = 2;
			int num2 = default(int);
			int num3 = default(int);
			while (true)
			{
				switch (num)
				{
				case 9:
					num = ((num3 % 2 != 0) ? 7 : 3);
					break;
				case 8:
					num = char_[423] - 27278;
					break;
				case 7:
					num = (((short_1 ^ short_0) - 108) ^ num2) switch
					{
						0 => 5, 
						_ => int_2[320] - 17438, 
					};
					break;
				case 6:
					num2++;
					num3 = short_1 * short_1;
					num3 = short_1 + num3;
					goto case 8;
				case 5:
					gparam_0.Write(byte_0, int_0, int_1);
					goto case 6;
				default:
					num2 = 0;
					num = 7;
					break;
				case 0:
				case 1:
					num = 6;
					break;
				case 3:
				case 4:
					return;
				}
			}
		}

		internal static byte[] smethod_1<T>(T gparam_0, char char_0, char char_1) where T : MemoryStream
		{
			char[] char_2 = Class1.char_1;
			Array array = default(Array);
			int num3 = default(int);
			int num4 = default(int);
			while (true)
			{
				int num = 0;
				int num2 = 8;
				while (true)
				{
					switch (num2)
					{
					default:
						num2 = 9;
						continue;
					case 8:
						num2 = (((char_1 ^ char_0) - 58) ^ num) switch
						{
							0 => 7, 
							_ => 3, 
						};
						continue;
					case 7:
						array = gparam_0.ToArray();
						num2 = 1;
						continue;
					case 6:
						num2 = 8;
						continue;
					case 3:
						array = null;
						num2 = char_2[206] - 53785;
						continue;
					case 2:
						num2 = ((923 < num3 / 4 - num4) ? 8 : 5);
						continue;
					case 1:
						num++;
						num3 = 3692;
						num4 = 283;
						goto case 2;
					case 9:
						break;
					case 5:
						return (byte[])array;
					}
					break;
				}
			}
		}

		internal static object smethod_2<T, U>(T gparam_0, U gparam_1, char char_0, char char_1) where T : AppDomain where U : string
		{
			char[] char_2 = Class1.char_1;
			object result = default(object);
			while (true)
			{
				int num = 0;
				int num2 = 9;
				while (true)
				{
					switch (num2)
					{
					case 9:
						Class0.int_0[50] = (Class0.int_0[50] + Class0.int_0[337]) & 0x3D;
						num2 = (((char_1 ^ char_0) - 43) ^ num) switch
						{
							0 => char_2[266] - 36903, 
							_ => 5, 
						};
						continue;
					default:
						num2 = 8;
						continue;
					case 2:
					case 6:
						num2 = char_2[404] - 40068;
						continue;
					case 0:
					case 5:
						result = null;
						num2 = 1;
						continue;
					case 3:
					case 4:
						result = gparam_0.GetData(gparam_1);
						num2 = char_2[146] - 58723;
						continue;
					case 1:
					{
						num++;
						int num3 = 2356;
						int num4 = 99;
						num2 = ((589 < num3 / 4 - num4) ? 9 : 10);
						continue;
					}
					case 8:
						break;
					case 10:
						return result;
					}
					break;
				}
			}
		}

		internal static StringBuilder smethod_3<T>(T gparam_0, char char_0, int int_0, short short_0) where T : StringBuilder
		{
			char[] char_ = Class1.char_1;
			int[] int_ = Class0.int_0;
			ISerializable serializable = default(ISerializable);
			while (true)
			{
				int num = 0;
				int num2 = 8;
				while (true)
				{
					switch (num2)
					{
					default:
						num2 = char_[49] - 284;
						continue;
					case 9:
						serializable = null;
						num2 = char_[6] - 62449;
						continue;
					case 8:
						num2 = (((int_0 ^ short_0) - 86) ^ num) switch
						{
							0 => int_[382] - 31305, 
							_ => char_[159] - 58534, 
						};
						continue;
					case 0:
					case 7:
						num2 = 8;
						continue;
					case 5:
					case 6:
						serializable = gparam_0.Append(char_0);
						num2 = char_[266] - 36902;
						continue;
					case 4:
					{
						num++;
						int num3 = 776;
						int num4 = 187;
						num2 = ((388 < num3 / 2 - num4) ? (char_[398] - 50445) : 2);
						continue;
					}
					case 1:
						break;
					case 2:
						return serializable as StringBuilder;
					}
					break;
				}
			}
		}

		internal static int smethod_4<T>(T gparam_0, byte[] byte_0, int int_0, int int_1, int int_2, short short_0) where T : Stream
		{
			char[] char_ = Class1.char_1;
			int[] int_3 = Class0.int_0;
			int num3 = default(int);
			int result = default(int);
			while (true)
			{
				int num = 0;
				int num2 = 1;
				while (true)
				{
					switch (num2)
					{
					case 11:
						num2 = char_[23] - 43769;
						continue;
					case 5:
					case 10:
						num2 = ((num3 % 2 != 0) ? 1 : 7);
						continue;
					case 9:
						num2 = 10;
						continue;
					case 8:
						num3 = short_0 + num3;
						goto case 9;
					case 6:
						result = int_1;
						num2 = 3;
						continue;
					default:
						num2 = char_[52] - 19395;
						continue;
					case 3:
						num++;
						num3 = short_0 * short_0;
						goto case 8;
					case 2:
						result = gparam_0.Read(byte_0, int_0, int_1);
						num2 = int_3[48] - 59507;
						continue;
					case 1:
						num2 = (((int_2 ^ short_0) - 12) ^ num) switch
						{
							0 => char_[37] - 11851, 
							_ => 6, 
						};
						continue;
					case 0:
						break;
					case 7:
						return result;
					}
					break;
				}
			}
		}

		internal static string smethod_5<T, U>(T gparam_0, U gparam_1, int int_0, int int_1) where T : string where U : string
		{
			int[] int_2 = Class0.int_0;
			object obj = default(object);
			while (true)
			{
				int num = 0;
				int num2 = int_2[26] - 22967;
				while (true)
				{
					switch (num2)
					{
					case 10:
					{
						int num3 = 3736;
						int num4 = 368;
						num2 = ((934 < num3 / 4 - num4) ? (int_2[280] - 40967) : 7);
						continue;
					}
					case 8:
					case 9:
						obj = string.Concat(gparam_0, gparam_1);
						num2 = 0;
						continue;
					case 0:
					case 6:
						num++;
						goto case 10;
					case 5:
						obj = null;
						num2 = 0;
						continue;
					case 4:
						num2 = (((int_1 ^ int_0) - 91) ^ num) switch
						{
							0 => int_2[5] - 34981, 
							_ => int_2[349] - 58812, 
						};
						continue;
					default:
						num2 = 2;
						continue;
					case 1:
						num2 = int_2[126] - 49960;
						continue;
					case 2:
						break;
					case 7:
						return obj as string;
					}
					break;
				}
			}
		}

		internal static void smethod_6<T, U, V>(U gparam_0, T gparam_1, V gparam_2, int int_0, int int_1) where T : string where U : AppDomain
		{
			char[] char_ = Class1.char_1;
			int num = 2;
			int num2 = default(int);
			int num5 = default(int);
			int num3 = default(int);
			while (true)
			{
				switch (num)
				{
				case 8:
				case 9:
					num = 4;
					break;
				case 0:
				case 7:
					num = (((int_1 ^ int_0) - 65) ^ num2) switch
					{
						0 => 3, 
						_ => char_[39] - 18950, 
					};
					break;
				case 6:
					num5 = num3 + num5;
					goto case 1;
				case 1:
					num = ((num5 % 2 != 0) ? (char_[316] - 5608) : 5);
					break;
				case 4:
				{
					num2++;
					num3 = 525;
					int num4 = num3;
					num5 = num4 * num4;
					num = char_[387] - 28625;
					break;
				}
				case 3:
					gparam_0.SetData(gparam_1, gparam_2);
					goto case 4;
				default:
					num2 = 0;
					num = char_[109] - 14608;
					break;
				case 5:
					return;
				}
			}
		}

		internal static int smethod_7<T, U, V>(V gparam_0, U gparam_1, T gparam_2, string[] string_0, char char_0, char char_1) where T : Evidence where U : AssemblyName where V : AppDomain
		{
			int[] int_ = Class0.int_0;
			char[] char_2 = Class1.char_1;
			int result = default(int);
			while (true)
			{
				int num = 0;
				int num2 = 9;
				while (true)
				{
					switch (num2)
					{
					default:
						num2 = int_[5] - int_[5];
						continue;
					case 9:
						num2 = (((char_1 ^ char_0) - 127) ^ num) switch
						{
							0 => int_[41] - 45456, 
							_ => 8, 
						};
						continue;
					case 8:
						result = 13;
						num2 = char_2[10] - 48103;
						continue;
					case 3:
					case 5:
					case 7:
						num2 = int_[180] - 49719;
						continue;
					case 4:
						result = ((AppDomain)gparam_0).ExecuteAssemblyByName((AssemblyName)gparam_1, (Evidence)gparam_2, string_0);
						num2 = 1;
						continue;
					case 2:
						num2 = char_2[113] - 37451;
						continue;
					case 1:
						num++;
						num2 = (((char_1 * char_1 + char_1) % 2 == 0) ? 11 : (int_[289] - 13753));
						continue;
					case 0:
					case 6:
						break;
					case 11:
						return result;
					}
					break;
				}
			}
		}

		internal static byte[] smethod_8<T, U>(U gparam_0, T gparam_1, int int_0, char char_0) where T : string where U : Encoding
		{
			int[] int_ = Class0.int_0;
			char[] char_ = Class1.char_1;
			object obj = default(object);
			while (true)
			{
				int num = 0;
				int num2 = 10;
				while (true)
				{
					switch (num2)
					{
					default:
						num2 = 2;
						continue;
					case 10:
						num2 = (((int_0 ^ char_0) - 72) ^ num) switch
						{
							0 => 5, 
							_ => 1, 
						};
						continue;
					case 9:
						num2 = char_[336] - 26404;
						continue;
					case 5:
					case 8:
						obj = gparam_0.GetBytes(gparam_1);
						num2 = 7;
						continue;
					case 0:
					case 7:
					{
						num++;
						int num4 = 630;
						int num5 = 701;
						num2 = ((4206 > num5 - num4 * 6) ? 6 : 4);
						continue;
					}
					case 4:
						num2 = int_[118] - 12385;
						continue;
					case 1:
					{
						obj = null;
						int num3 = int_[224];
						Class1.char_1[177] = (char)((Class1.char_1[177] | int_0) & 'x');
						num2 = num3 - 9394;
						continue;
					}
					case 2:
						break;
					case 6:
						return (byte[])obj;
					}
					break;
				}
			}
		}
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 78)]
	private struct Struct6
	{
	}

	private static readonly Array array_0;

	private static readonly Array array_1;

	private static readonly object object_0;

	internal static Struct6 struct6_0/* Not supported: data(97 11 D3 11 97 11 01 02 47 24 57 2B F7 0A D1 0C 53 05 81 14 2F 21 04 02 46 24 50 2B A3 0A 98 0C 53 05 82 14 79 21 0A 02 5F 24 57 2B F1 0A 87 0C 50 05 9D 14 2F 21 05 02 16 24 52 2B EA 0A 8C 0C 54 05 D6 14 79 21 54 02 41 24 59 2B A1 0A) */;

	static Class10()
	{
		int[] int_ = Class0.int_0;
		int num = 5;
		char[] array = default(char[]);
		while (true)
		{
			switch (num)
			{
			case 7:
				array[6] = '㫷';
				array[2] = 'ԧ';
				num = 2;
				break;
			default:
				array_1 = new char[39]
				{
					'ᆗ', 'ᇓ', 'ᆗ', 'ȁ', '⑇', '⭗', '\u0af7', '\u0cd1', 'Փ', 'ᒁ',
					'ℯ', 'Ȅ', '⑆', '⭐', 'ણ', 'ಘ', 'Փ', 'ᒂ', 'ⅹ', 'Ȋ',
					'\u245f', '⭗', '૱', 'ಇ', 'Ր', 'ᒝ', 'ℯ', 'ȅ', '␖', '⭒',
					'૪', 'ಌ', 'Ք', 'ᓖ', 'ⅹ', 'ɔ', '⑁', '⭙', 'ડ'
				};
				goto case 3;
			case 3:
				array = new char[8] { 'Ꭵ', '\0', '\0', '\0', '\0', '\0', '\0', '\0' };
				num = int_[238] - 39447;
				break;
			case 2:
			case 4:
				array[3] = 'ᓳ';
				array[4] = 'ᴢ';
				num = 1;
				break;
			case 0:
				array[1] = 'わ';
				array[7] = '㗥';
				num = 7;
				break;
			case 1:
				array[5] = '᭐';
				object_0 = new string[1];
				array_0 = array;
				return;
			}
		}
	}

	internal static Assembly smethod_0<T>(byte[] byte_0, byte[] byte_1, T gparam_0, int int_0, int int_1) where T : Evidence
	{
		int[] int_2 = Class0.int_0;
		char[] char_ = Class1.char_1;
		ICustomAttributeProvider customAttributeProvider = default(ICustomAttributeProvider);
		while (true)
		{
			int num = 0;
			int num2 = 10;
			while (true)
			{
				switch (num2)
				{
				case 10:
					num2 = (((int_0 ^ int_1) - 100) ^ num) switch
					{
						0 => char_[175] - 7649, 
						_ => int_2[371] - 59899, 
					};
					continue;
				case 1:
				case 9:
					customAttributeProvider = null;
					num2 = int_2[322] - 34275;
					continue;
				default:
					num2 = 4;
					continue;
				case 6:
				case 7:
				{
					num++;
					int num3 = 564;
					int num4 = 162;
					num2 = ((188 < num3 / 3 - num4) ? (int_2[27] - 63413) : (char_[331] - 32929));
					continue;
				}
				case 5:
					num2 = 10;
					continue;
				case 3:
					customAttributeProvider = Assembly.Load(byte_0, byte_1, (Evidence)gparam_0);
					num2 = char_[18] - 14792;
					continue;
				case 4:
					break;
				case 0:
					return customAttributeProvider as Assembly;
				}
				break;
			}
		}
	}

	internal static string smethod_1<T>(T gparam_0, short short_0, char char_0) where T : ResolveEventArgs
	{
		int[] int_ = Class0.int_0;
		ICloneable cloneable = default(ICloneable);
		while (true)
		{
			int num = 0;
			int num2 = 6;
			while (true)
			{
				switch (num2)
				{
				case 1:
				case 11:
					cloneable = gparam_0.Name;
					num2 = 9;
					continue;
				case 9:
					num++;
					num2 = (((short_0 * short_0 + short_0) % 2 == 0) ? (int_[337] - 1756) : (int_[269] - 58494));
					continue;
				default:
					num2 = 5;
					continue;
				case 7:
					num2 = 6;
					continue;
				case 6:
					num2 = (((short_0 ^ char_0) - 18) ^ num) switch
					{
						0 => 1, 
						_ => 0, 
					};
					continue;
				case 4:
					num2 = 6;
					continue;
				case 0:
					cloneable = null;
					num2 = 9;
					continue;
				case 3:
				case 5:
					break;
				case 10:
					return (string)cloneable;
				}
				break;
			}
		}
	}

	internal static byte[] smethod_2<T>(T gparam_0, int int_0, char char_0, int int_1) where T : BinaryReader
	{
		char[] char_ = Class1.char_1;
		int[] int_2 = Class0.int_0;
		int num3 = default(int);
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = char_[388] - 41256;
			while (true)
			{
				switch (num2)
				{
				case 10:
				{
					int num5 = 429;
					num2 = ((645 < num3 / 3 - num5) ? (char_[395] - 2471) : (int_2[380] - 7903));
					continue;
				}
				case 9:
					num2 = int_2[305] - 292;
					continue;
				case 8:
				{
					obj = gparam_0.ReadBytes(int_0);
					char num4 = char_[215];
					Class1.char_1[411] = (char)((Class1.char_1[411] * int_0) & 'º');
					num2 = num4 - 41761;
					continue;
				}
				case 6:
					num++;
					num3 = 1935;
					goto case 10;
				case 4:
					obj = null;
					num2 = 6;
					continue;
				case 1:
					num2 = (((int_1 ^ char_0) - 19) ^ num) switch
					{
						0 => 8, 
						_ => 4, 
					};
					continue;
				default:
					num2 = char_[74] - 55280;
					continue;
				case 3:
				case 5:
				case 7:
					break;
				case 2:
					return obj as byte[];
				}
				break;
			}
		}
	}

	internal static string smethod_3(int int_0, long long_0, int int_1)
	{
		char[] char_ = Class1.char_1;
		int[] int_2 = Class0.int_0;
		int num8 = default(int);
		StringBuilder stringBuilder = default(StringBuilder);
		char c = default(char);
		char[] array2 = default(char[]);
		int num5 = default(int);
		int num4 = default(int);
		char[] array3 = default(char[]);
		int num7 = default(int);
		int num6 = default(int);
		string text = default(string);
		while (true)
		{
			int num = int_1 ^ 0xFB8E3D3 ^ int_0;
			char[] array = (char[])array_1;
			int num2 = array[num];
			num2 = array[num + 2] ^ num2;
			int num3 = char_[211] - 59611;
			while (true)
			{
				switch (num3)
				{
				case 16:
					num8++;
					num3 = 3;
					continue;
				case 15:
					stringBuilder.Append((char)(c ^ array2[num5 + num4 - num8] ^ array3[(num8 + num5 + 17) % num7]));
					num3 = 16;
					continue;
				case 14:
					num5 += 3;
					num4 = (num6 & 0x1F) | ((num6 & 0xFFC0) >> 1);
					num3 = 1;
					continue;
				case 13:
					num8 = 1;
					num3 = char_[254] - 39020;
					continue;
				case 12:
					num7 = array3.Length;
					goto case 13;
				case 10:
					stringBuilder = new StringBuilder();
					c = array2[num5];
					num6 = array2[num5 + 1] ^ c;
					num3 = 14;
					continue;
				case 2:
				case 8:
				{
					char[] obj = (char[])array_0;
					num5 = num;
					array3 = obj;
					array2 = array;
					num3 = 10;
					continue;
				}
				case 7:
					text = stringBuilder.ToString();
					((string[])object_0)[num2] = text;
					num3 = 9;
					continue;
				default:
					num3 = 11;
					continue;
				case 4:
					num3 = (((text = ((string[])object_0)[num2]) == null) ? 2 : 17);
					continue;
				case 3:
					num3 = ((num8 <= num4) ? 15 : 7);
					continue;
				case 1:
					num3 = (((num6 & 0x20) == 0) ? 12 : 0);
					continue;
				case 0:
					num4 = (num4 << 15) | (array2[num5++] ^ c);
					num3 = int_2[340] - 24783;
					continue;
				case 5:
				case 11:
					break;
				case 9:
					return text;
				case 17:
					return text;
				}
				break;
			}
		}
	}
}
