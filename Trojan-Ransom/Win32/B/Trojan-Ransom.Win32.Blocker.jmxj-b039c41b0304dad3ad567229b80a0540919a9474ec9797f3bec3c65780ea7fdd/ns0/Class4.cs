using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;

namespace ns0;

internal sealed class Class4
{
	internal sealed class Class5
	{
		internal sealed class Class6
		{
			[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 142)]
			private struct Struct3
			{
			}

			private static readonly Array array_0;

			private static readonly object object_0;

			private static readonly object object_1;

			internal static Struct3 struct3_0/* Not supported: data(EC 4B E9 4B EC 4B C3 53 A9 45 52 70 2A 79 A8 69 CE 57 C6 57 CF 57 CE 56 C1 73 45 4D AC 4F A5 59 2F 6C 27 65 EA 75 30 D6 37 D6 32 D6 D9 E4 37 F4 28 D7 2B F2 86 CC 4E CE 63 D8 C4 5D CD 5D C7 5D 6C 47 B9 45 AB 53 3A 66 2B 6F DF 7F DE 5C C3 79 55 47 CD 3D C8 3D C9 3D 70 27 AF 25 A2 33 2F 06 0F 0F 82 3E 87 3E 87 3E 0E 24 FA 26 C8 30 7D 05 4D 0C D0 3E D5 3E D6 3E 78 24 9A 26 A8 30 15 05 11 0C E8 D6 EB D6 EF D6 8F D8 08 ED 01 E4) */;

			static Class6()
			{
				int[] int_ = Class0.int_0;
				byte[] byte_ = Class1.byte_0;
				int num = 6;
				Array array = default(Array);
				while (true)
				{
					switch (num)
					{
					case 7:
						(array as char[])[3] = '⑮';
						num = int_[203] - 54174;
						continue;
					case 5:
						(array as char[])[7] = '㮍';
						goto case 7;
					case 4:
						((char[])array)[6] = '㊀';
						num = int_[242] - 1700;
						continue;
					case 3:
						(array as char[])[0] = '\u0e00';
						goto case 4;
					case 0:
						(array as char[])[2] = '\u1adc';
						((char[])array)[4] = 'Ź';
						num = (int)byte_[64] / 3;
						continue;
					case 2:
						(array as char[])[1] = '\u181b';
						object_1 = new string[8];
						array_0 = (char[])array;
						return;
					case 1:
						return;
					}
					object_0 = new char[71]
					{
						'䯬', '䯩', '䯬', '參', '䖩', '灒', '礪', '榨', '城', '埆',
						'埏', '囎', '珁', '䵅', '侬', '妥', '氯', '攧', '痪', '혰',
						'혷', '혲', '\ue4d9', '\uf437', '휨', '\uf22b', '첆', '칎', '\ud863', '巄',
						'巍', '巇', '䝬', '䖹', '厫', '昺', '漫', '翟', '峞', '秃',
						'䝕', '㷍', '㷈', '㷉', '❰', '▯', '㎢', 'د', '༏', '㺂',
						'㺇', '㺇', '␎', '⛺', 'ト', 'ս', '\u0c4d', '㻐', '㻕', '㻖',
						'⑸', '⚚', 'エ', 'ԕ', '\u0c11', '훨', '훫', '훯', '\ud88f', '\ued08',
						'\ue401'
					};
					array = new char[8];
					(array as char[])[5] = '≩';
					num = 3;
				}
			}

			internal static string smethod_0(Class6 class6_0, int int_0, int int_1)
			{
				int[] int_2 = Class0.int_0;
				byte[] byte_ = Class1.byte_0;
				int num8 = default(int);
				object obj6 = default(object);
				int num7 = default(int);
				object obj3 = default(object);
				int num6 = default(int);
				int num4 = default(int);
				object obj5 = default(object);
				object obj4 = default(object);
				char c = default(char);
				int num5 = default(int);
				while (true)
				{
					int num = int_1 ^ 0x7845B375 ^ int_0;
					object obj = object_0;
					char[] obj2 = (char[])obj;
					int num2 = obj2[num];
					num2 = obj2[num + 2] ^ num2;
					int num3 = byte_[28] - 28;
					while (true)
					{
						switch (num3)
						{
						case 15:
							num8 = ((char[])obj6).Length;
							num7 = 1;
							num3 = 12;
							continue;
						case 13:
						case 14:
							num3 = (((obj3 = ((string[])object_1)[num2]) == null) ? (int_2[47] - 63845) : 5);
							continue;
						case 12:
							num3 = ((num7 > num6) ? 1 : 10);
							continue;
						case 11:
						{
							char[] obj7 = (char[])obj;
							char[] obj8 = (char[])array_0;
							num4 = num;
							obj6 = obj8;
							obj5 = obj7;
							num3 = int_2[191] - int_2[191];
							continue;
						}
						case 10:
							(obj4 as StringBuilder).Append((char)(c ^ (obj5 as char[])[num4 + num6 - num7] ^ ((char[])obj6)[(num7 + num4 + 17) % num8]));
							num3 = 4;
							continue;
						default:
							num3 = int_2[31] - 30998;
							continue;
						case 2:
						case 8:
							num3 = (((num5 & 0x20) == 0) ? 15 : 3);
							continue;
						case 4:
						case 7:
							num7++;
							num3 = 12;
							continue;
						case 6:
							num4 += 3;
							num6 = (num5 & 0x1F) | ((num5 & 0xFFC0) >> 1);
							num3 = int_2[41] - 771;
							continue;
						case 3:
							num6 = (num6 << 15) | (((char[])obj5)[num4++] ^ c);
							num3 = 15;
							continue;
						case 1:
							obj3 = ((StringBuilder)obj4).ToString();
							((string[])object_1)[num2] = (string)obj3;
							num3 = 17;
							continue;
						case 0:
							obj4 = new StringBuilder();
							c = (obj5 as char[])[num4];
							num5 = (obj5 as char[])[num4 + 1] ^ c;
							num3 = byte_[43];
							continue;
						case 16:
							break;
						case 5:
							return obj3 as string;
						case 17:
							return obj3 as string;
						}
						break;
					}
				}
			}

			internal static Assembly smethod_1(short short_0, char char_0)
			{
				int[] int_ = Class0.int_0;
				byte[] byte_ = Class1.byte_0;
				object obj = default(object);
				while (true)
				{
					int num = 0;
					int num2 = int_[284] - 31165;
					while (true)
					{
						switch (num2)
						{
						case 2:
						case 12:
							obj = Assembly.GetExecutingAssembly();
							num2 = (int)byte_[62] / 6;
							continue;
						case 11:
							num2 = byte_[43];
							continue;
						case 10:
						{
							int num3 = 415;
							int num4 = 545;
							num2 = ((2180 > num4 - num3 * 4) ? (byte_[18] - 140) : 7);
							continue;
						}
						case 9:
							num++;
							goto case 10;
						case 7:
							num2 = int_[245] - 29734;
							continue;
						case 6:
							num2 = (((short_0 ^ char_0) - 15) ^ num) switch
							{
								0 => int_[270] - 28748, 
								1 => byte_[12] - byte_[12], 
								_ => int_[14] - 29573, 
							};
							continue;
						default:
							num2 = 1;
							continue;
						case 3:
							obj = null;
							num2 = int_[245] - 29731;
							continue;
						case 0:
							obj = Assembly.GetExecutingAssembly();
							num2 = int_[353] - 11336;
							continue;
						case 1:
							break;
						case 8:
							return obj as Assembly;
						}
						break;
					}
				}
			}

			internal static AppDomain smethod_2(char char_0, short short_0)
			{
				int[] int_ = Class0.int_0;
				byte[] byte_ = Class1.byte_0;
				_AppDomain val = default(_AppDomain);
				while (true)
				{
					int num = 0;
					int num2 = byte_[122] - 125;
					while (true)
					{
						switch (num2)
						{
						case 11:
							val = (_AppDomain)(object)AppDomain.CurrentDomain;
							num2 = 6;
							continue;
						case 7:
						case 8:
							num2 = (((short_0 ^ char_0) - 125) ^ num) switch
							{
								0 => int_[426] - 29111, 
								1 => (int)byte_[64] / 5, 
								_ => 2, 
							};
							continue;
						case 6:
						{
							num++;
							int num3 = 1602;
							int num4 = 83;
							num2 = ((801 < num3 / 2 - num4) ? (int_[238] - 54578) : 5);
							continue;
						}
						case 4:
							num2 = byte_[9];
							continue;
						case 1:
						case 3:
							val = (_AppDomain)(object)AppDomain.CurrentDomain;
							num2 = 6;
							continue;
						case 2:
							val = null;
							num2 = byte_[43];
							continue;
						default:
							num2 = int_[176] - 31581;
							continue;
						case 10:
							break;
						case 5:
						case 9:
							return (AppDomain)(object)val;
						}
						break;
					}
				}
			}

			internal static MethodInfo[] smethod_3<T>(T gparam_0, short short_0, short short_1) where T : Type
			{
				int[] int_ = Class0.int_0;
				byte[] byte_ = Class1.byte_0;
				object obj = default(object);
				while (true)
				{
					int num = 0;
					int num2 = int_[141] - 22198;
					while (true)
					{
						switch (num2)
						{
						case 10:
							num2 = int_[429] - 62321;
							continue;
						case 9:
							num2 = int_[439] - 13765;
							continue;
						case 8:
							num++;
							goto case 2;
						case 2:
						{
							int num3 = 3604;
							int num4 = 802;
							num2 = ((901 < num3 / 4 - num4) ? 3 : (byte_[109] - byte_[93]));
							continue;
						}
						case 3:
						case 7:
							num2 = (((short_0 ^ short_1) - 62) ^ num) switch
							{
								0 => int_[367] - 42100, 
								_ => 1, 
							};
							continue;
						case 4:
							obj = gparam_0.GetMethods();
							num2 = int_[79] - 52320;
							continue;
						case 1:
							obj = null;
							goto case 10;
						default:
							num2 = 6;
							continue;
						case 6:
							break;
						case 5:
							return (MethodInfo[])obj;
						}
						break;
					}
				}
			}

			internal static void smethod_4<T, U, V>(T gparam_0, V gparam_1, U gparam_2, short short_0, char char_0) where T : AppDomain where V : string
			{
				int[] int_ = Class0.int_0;
				int num = 6;
				int num2 = default(int);
				while (true)
				{
					switch (num)
					{
					case 9:
						num = 7;
						break;
					case 8:
					{
						int num3 = char_0 * char_0 + char_0;
						Class1.byte_0[31] = (byte)((Class1.byte_0[31] + short_0) & 0xC0);
						num = ((num3 % 2 == 0) ? 1 : (int_[103] - 40720));
						break;
					}
					case 2:
					case 7:
						num = (((short_0 ^ char_0) - 85) ^ num2) switch
						{
							0 => int_[260] - 14638, 
							_ => 0, 
						};
						break;
					default:
						num2 = 0;
						num = 7;
						break;
					case 5:
						num2++;
						goto case 8;
					case 4:
						gparam_0.SetData(gparam_1, gparam_2);
						goto case 5;
					case 0:
						num = 5;
						break;
					case 1:
						return;
					}
				}
			}

			internal static int smethod_5<T>(T gparam_0, byte[] byte_0, int int_0, int int_1, short short_0, short short_1) where T : Stream
			{
				int[] int_2 = Class0.int_0;
				int num3 = default(int);
				int result = default(int);
				while (true)
				{
					int num = 0;
					int num2 = 11;
					while (true)
					{
						switch (num2)
						{
						case 11:
							num2 = (((short_1 ^ short_0) - 103) ^ num) switch
							{
								0 => int_2[99] - int_2[99], 
								_ => 7, 
							};
							continue;
						case 10:
							num2 = ((num3 % 2 != 0) ? (int_2[264] - 16563) : 3);
							continue;
						default:
							num2 = 6;
							continue;
						case 7:
							result = 13;
							num2 = 4;
							continue;
						case 5:
							num2 = 11;
							continue;
						case 4:
							num++;
							num3 = short_1 * short_1;
							goto case 1;
						case 1:
						case 2:
						{
							int num4 = num3;
							Class0.int_0[411] = (Class0.int_0[411] | short_0) & 0x39;
							num3 = short_1 + num4;
							num2 = 10;
							continue;
						}
						case 0:
							result = gparam_0.Read(byte_0, int_0, int_1);
							num2 = 4;
							continue;
						case 6:
						case 8:
							break;
						case 3:
							return result;
						}
						break;
					}
				}
			}

			internal static Color smethod_6<T>(T gparam_0, int int_0, int int_1, int int_2, int int_3) where T : Bitmap
			{
				byte[] byte_ = Class1.byte_0;
				int[] int_4 = Class0.int_0;
				Color result = default(Color);
				while (true)
				{
					int num = 0;
					int num2 = 6;
					while (true)
					{
						switch (num2)
						{
						case 10:
						case 11:
							result = ((Bitmap)gparam_0).GetPixel(int_0, int_1);
							num2 = int_4[386] - 20960;
							continue;
						case 0:
						case 9:
							num2 = int_4[125] - 5879;
							continue;
						case 2:
						case 8:
							result = default(Color);
							num2 = 7;
							continue;
						case 7:
						{
							num++;
							int num3 = 529;
							num2 = (((num3 * num3 + num3) % 2 == 0) ? 4 : (int_4[71] - 29622));
							continue;
						}
						case 6:
							num2 = (((int_3 ^ int_2) - 68) ^ num) switch
							{
								0 => 10, 
								_ => byte_[38] - byte_[124], 
							};
							continue;
						case 5:
							num2 = 6;
							continue;
						default:
							num2 = 3;
							continue;
						case 3:
							break;
						case 4:
							return result;
						}
						break;
					}
				}
			}
		}

		internal static string smethod_0<T, U>(U gparam_0, T gparam_1, short short_0, char char_0) where T : string where U : string
		{
			byte[] byte_ = Class1.byte_0;
			int[] int_ = Class0.int_0;
			ICloneable cloneable = default(ICloneable);
			while (true)
			{
				int num = 0;
				int num2 = int_[160] - 42075;
				while (true)
				{
					switch (num2)
					{
					case 1:
					case 10:
						cloneable = string.Concat(gparam_0, gparam_1);
						num2 = 8;
						continue;
					case 9:
					{
						int num3 = 430;
						int num4 = 20;
						num2 = ((215 < num3 / 2 - num4) ? 6 : 7);
						continue;
					}
					case 8:
						num++;
						goto case 9;
					case 6:
						num2 = (((short_0 ^ char_0) - 38) ^ num) switch
						{
							0 => (int)byte_[43] / 6, 
							_ => 0, 
						};
						continue;
					case 5:
						num2 = 6;
						continue;
					default:
						num2 = byte_[90] - byte_[9];
						continue;
					case 0:
						cloneable = null;
						num2 = 8;
						continue;
					case 4:
						break;
					case 2:
					case 7:
						return (string)cloneable;
					}
					break;
				}
			}
		}

		internal static object smethod_1<T, U>(U gparam_0, T gparam_1, object[] object_0, int int_0, char char_0) where U : MethodBase
		{
			byte[] byte_ = Class1.byte_0;
			int[] int_ = Class0.int_0;
			object result = default(object);
			while (true)
			{
				int num = 0;
				int num2 = 11;
				while (true)
				{
					switch (num2)
					{
					case 11:
						num2 = (((int_0 ^ char_0) - 75) ^ num) switch
						{
							0 => int_[275] - 4247, 
							_ => byte_[21] - 103, 
						};
						continue;
					default:
						num2 = 8;
						continue;
					case 9:
						result = null;
						num2 = int_[113] - 16080;
						continue;
					case 1:
					case 3:
					case 7:
						result = gparam_0.Invoke(gparam_1, object_0);
						num2 = 5;
						continue;
					case 2:
					case 6:
						num2 = byte_[90];
						continue;
					case 5:
					{
						num++;
						int num3 = char_0 * char_0;
						Class0.int_0[327] = (Class0.int_0[327] + int_0) & 0x2E;
						num2 = (((num3 + char_0) % 2 == 0) ? (byte_[28] - 42) : 4);
						continue;
					}
					case 4:
						num2 = byte_[90];
						continue;
					case 8:
						break;
					case 0:
						return result;
					}
					break;
				}
			}
		}

		internal static Evidence smethod_2<T>(T gparam_0, int int_0, int int_1) where T : Assembly
		{
			int[] int_2 = Class0.int_0;
			byte[] byte_ = Class1.byte_0;
			object obj = default(object);
			int num5 = default(int);
			int num3 = default(int);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				while (true)
				{
					switch (num2)
					{
					case 11:
						num2 = byte_[43];
						continue;
					default:
						num2 = 2;
						continue;
					case 9:
						obj = ((Assembly)gparam_0).get_Evidence();
						num2 = 6;
						continue;
					case 7:
						num5 = num3 + num5;
						num2 = ((num5 % 2 == 0) ? (int_2[463] - 52607) : 0);
						continue;
					case 1:
					case 6:
						num++;
						goto case 5;
					case 5:
					{
						num3 = 617;
						int num4 = num3;
						num5 = num4 * num4;
						num2 = 7;
						continue;
					}
					case 4:
						obj = null;
						goto case 11;
					case 3:
						num2 = 0;
						continue;
					case 0:
						num2 = (((int_1 ^ int_0) - 1) ^ num) switch
						{
							0 => int_2[270] - 28751, 
							_ => int_2[113] - 16081, 
						};
						continue;
					case 2:
						break;
					case 8:
						return (Evidence)obj;
					}
					break;
				}
			}
		}

		internal static string[] smethod_3<T>(T gparam_0, char char_0, char char_1) where T : Assembly
		{
			byte[] byte_ = Class1.byte_0;
			int[] int_ = Class0.int_0;
			int num3 = default(int);
			Array array = default(Array);
			while (true)
			{
				int num = 0;
				int num2 = byte_[70] - 120;
				while (true)
				{
					switch (num2)
					{
					case 10:
						num++;
						num3 = char_0 * char_0;
						num3 = char_0 + num3;
						num2 = 5;
						continue;
					case 0:
					case 8:
						array = null;
						goto case 2;
					case 2:
						num2 = 10;
						continue;
					case 7:
						array = gparam_0.GetManifestResourceNames();
						num2 = int_[132] - 29340;
						continue;
					case 5:
						num2 = ((num3 % 2 != 0) ? (int_[103] - 40728) : (byte_[18] - 139));
						continue;
					default:
						num2 = byte_[43];
						continue;
					case 3:
						num2 = byte_[62] - 53;
						continue;
					case 1:
						num2 = (((char_0 ^ char_1) - 108) ^ num) switch
						{
							0 => 7, 
							_ => int_[159] - 6332, 
						};
						continue;
					case 6:
						break;
					case 9:
					case 11:
						return array as string[];
					}
					break;
				}
			}
		}

		internal static Color smethod_4(int int_0, int int_1, int int_2, int int_3, short short_0, short short_1)
		{
			byte[] byte_ = Class1.byte_0;
			int[] int_4 = Class0.int_0;
			Color result = default(Color);
			Color color = default(Color);
			while (true)
			{
				int num = 0;
				int num2 = 4;
				while (true)
				{
					switch (num2)
					{
					case 6:
					case 10:
					{
						num++;
						int num3 = 1636;
						int num4 = 337;
						num2 = ((409 < num3 / 4 - num4) ? (int_4[380] - 30142) : 9);
						continue;
					}
					case 8:
						result = Color.FromArgb(int_0, int_1, int_2, int_3);
						num2 = 6;
						continue;
					case 5:
						result = color;
						num2 = byte_[43];
						continue;
					case 4:
						num2 = (((short_0 ^ short_1) - 125) ^ num) switch
						{
							0 => 8, 
							_ => 0, 
						};
						continue;
					default:
						num2 = 7;
						continue;
					case 2:
						num2 = 4;
						continue;
					case 0:
						color = default(Color);
						goto case 5;
					case 7:
						break;
					case 1:
					case 9:
						return result;
					}
					break;
				}
			}
		}
	}

	internal static object smethod_0<T, U>(T gparam_0, U gparam_1, char char_0, char char_1) where T : AppDomain where U : string
	{
		byte[] byte_ = Class1.byte_0;
		int[] int_ = Class0.int_0;
		object result = default(object);
		while (true)
		{
			int num = 0;
			int num2 = 0;
			while (true)
			{
				switch (num2)
				{
				case 0:
				case 9:
					Class1.byte_0[33] = (byte)((Class1.byte_0[33] - Class1.byte_0[15]) & 0x84);
					num2 = (((char_0 ^ char_1) - 18) ^ num) switch
					{
						0 => int_[33] - 2492, 
						_ => 3, 
					};
					continue;
				case 8:
				{
					num++;
					int num3 = 2223;
					int num4 = 524;
					num2 = ((741 >= num3 / 3 - num4) ? 10 : 0);
					continue;
				}
				case 7:
					num2 = int_[294] - 44735;
					continue;
				default:
					num2 = byte_[119] - 237;
					continue;
				case 4:
					result = gparam_0.GetData(gparam_1);
					num2 = int_[368] - 2818;
					continue;
				case 3:
					result = null;
					num2 = 8;
					continue;
				case 2:
				case 6:
					break;
				case 1:
				case 10:
					return result;
				}
				break;
			}
		}
	}

	internal static void smethod_1<T>(T gparam_0, byte[] byte_0, int int_0, int int_1, short short_0, short short_1) where T : Stream
	{
		byte[] byte_ = Class1.byte_0;
		int num = 0;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			case 4:
			case 5:
			case 9:
				num = (((short_0 ^ short_1) - 50) ^ num2) switch
				{
					0 => 6, 
					_ => byte_[65] - byte_[21], 
				};
				break;
			case 6:
			case 8:
				gparam_0.Write(byte_0, int_0, int_1);
				goto case 3;
			case 3:
				num2++;
				num = (((short_1 * short_1 + short_1) % 2 == 0) ? 2 : 7);
				break;
			case 7:
				num = 9;
				break;
			case 1:
				num = 3;
				break;
			default:
				num2 = 0;
				num = byte_[3] - 230;
				break;
			case 2:
				return;
			}
		}
	}

	internal static byte[] smethod_2<T>(T gparam_0, char char_0, int int_0) where T : MemoryStream
	{
		int[] int_ = Class0.int_0;
		byte[] byte_ = Class1.byte_0;
		Array array = default(Array);
		while (true)
		{
			int num = 0;
			int num2 = int_[423];
			Class1.byte_0[80] = (byte)(Class1.byte_0[80] & int_0 & 0xCC);
			int num3 = num2 - 29532;
			while (true)
			{
				switch (num3)
				{
				case 8:
				case 9:
					num3 = (((char_0 ^ int_0) - 73) ^ num) switch
					{
						0 => int_[362] - 43377, 
						_ => int_[437] - 9717, 
					};
					continue;
				case 7:
				{
					num++;
					int num4 = 945;
					int num5 = 290;
					num3 = ((315 < num4 / 3 - num5) ? 8 : 2);
					continue;
				}
				case 0:
				case 6:
					array = gparam_0.ToArray();
					num3 = 7;
					continue;
				case 5:
					num3 = 8;
					continue;
				default:
					num3 = 10;
					continue;
				case 1:
					array = null;
					num3 = byte_[9];
					continue;
				case 10:
					break;
				case 2:
					return array as byte[];
				}
				break;
			}
		}
	}

	internal static void smethod_3<T, U>(T gparam_0, int int_0, U gparam_1, int int_1, int int_2, int int_3, short short_0) where T : Array where U : Array
	{
		int[] int_4 = Class0.int_0;
		byte[] byte_ = Class1.byte_0;
		int num = 1;
		int num4 = default(int);
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			case 3:
			case 9:
				num = byte_[23];
				break;
			case 8:
				num = ((4460 > num4 - num3 * 5) ? 5 : 2);
				break;
			case 4:
			case 7:
				num2++;
				num3 = 701;
				num4 = 892;
				goto case 8;
			case 6:
				Buffer.BlockCopy(gparam_0, int_0, gparam_1, int_1, int_2);
				goto case 4;
			case 2:
				num = 0;
				break;
			default:
				num2 = 0;
				num = int_4[342] - 16910;
				break;
			case 0:
				num = (((int_3 ^ short_0) - 4) ^ num2) switch
				{
					0 => 6, 
					_ => byte_[67] - byte_[11], 
				};
				break;
			case 5:
				return;
			}
		}
	}
}
