using System;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Text;
using SmartAssembly.SmartExceptionsCore;

namespace ns0;

internal sealed class Class5
{
	internal sealed class Class6
	{
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 190)]
		private struct Struct4
		{
		}

		private static readonly Array array_0;

		private static readonly object object_0;

		private static readonly Array array_1;

		internal static Struct4 struct4_0/* Not supported: data(EA 64 E9 64 EA 64 A3 7D 88 42 22 48 E8 FF F9 FF E9 FF 1D CC 02 D4 9E C3 C9 F6 B7 E6 DD D9 3B D3 28 EB 3D CC 66 D4 B3 C3 C9 F6 E6 E6 D6 D9 11 D3 67 EB 00 CC 82 E0 87 E0 80 E0 04 D3 78 CB A0 DC 9D E9 95 F9 BF 1A E5 1A BC 1A 87 13 E1 03 D2 3C 35 36 31 0E 6F 29 67 31 F4 26 A0 13 C1 03 FE 3C 34 36 75 0E 57 29 57 31 E9 26 80 13 C4 03 E0 3C 30 36 29 0E 43 29 4C 31 DA 26 B3 13 DD 03 E9 3C 37 36 16 0E 41 29 77 31 E8 26 90 13 C1 03 F7 3C 44 36 01 0E 46 29 67 31 FB 26 B2 13 B3 03 D2 3C 41 36 1F 0E 5B 29 79 31 E0 26 B1 13 D5 03 DD 3C 33 36 0A 0E 5A 29 46 31 E1 26 A3 13 D4 03) */;

		internal static string smethod_0(int int_0, long long_0, int int_1)
		{
			byte[] byte_ = default(byte[]);
			int[] int_2 = default(int[]);
			int num = default(int);
			object obj = default(object);
			int num2 = default(int);
			int num3 = default(int);
			object obj3 = default(object);
			int num4 = default(int);
			object obj6 = default(object);
			Array array = default(Array);
			ISerializable serializable = default(ISerializable);
			char c = default(char);
			int num5 = default(int);
			int num6 = default(int);
			int num7 = default(int);
			int num8 = default(int);
			try
			{
				byte_ = Class0.byte_0;
				int_2 = Class1.int_0;
				num = int_0 ^ 0x51CDD132 ^ int_1;
				obj = object_0;
				char[] obj2 = (char[])obj;
				num2 = obj2[num];
				num2 = obj2[num + 2] ^ num2;
				num3 = 4;
				if ((obj3 = ((string[])array_1)[num2]) != null)
				{
					num3 = 13;
					return (string)obj3;
				}
				num3 = 17;
				char[] obj4 = (char[])obj;
				char[] obj5 = (char[])array_0;
				num4 = num;
				obj6 = obj5;
				array = obj4;
				num3 = 7;
				serializable = new StringBuilder();
				c = (array as char[])[num4];
				num5 = ((char[])array)[num4 + 1] ^ c;
				num3 = 15;
				num4 += 3;
				num6 = (num5 & 0x1F) | ((num5 & 0xFFC0) >> 1);
				num3 = 5;
				if (((uint)num5 & 0x20u) != 0)
				{
					num3 = 2;
					num6 = (num6 << 15) | (((char[])array)[num4++] ^ c);
					num3 = 9;
				}
				else
				{
					num3 = 9;
				}
				num7 = (obj6 as char[]).Length;
				num8 = 1;
				num3 = 16;
				while (num8 <= num6)
				{
					num3 = 0;
					((StringBuilder)serializable).Append((char)(c ^ (array as char[])[num4 + num6 - num8] ^ ((char[])obj6)[(num8 + num4 + 17) % num7]));
					num3 = 14;
					num8++;
					num3 = 16;
				}
				num3 = 3;
				obj3 = (serializable as StringBuilder).ToString();
				((string[])array_1)[num2] = (string)obj3;
				num3 = 8;
				return obj3 as string;
			}
			catch (Exception exception_)
			{
				int num9 = default(int);
				StackFrameHelper.CreateExceptionN(exception_, new object[20]
				{
					num, num2, obj, obj3, serializable, c, num5, num6, num7, num8,
					array, obj6, num4, num9, num3, byte_, int_2, int_0, long_0, int_1
				});
				throw;
			}
		}

		internal static AppDomain smethod_1(short short_0, char char_0)
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			byte[] byte_ = default(byte[]);
			int[] int_ = default(int[]);
			int num = default(int);
			int num2 = default(int);
			IEvidenceFactory val = default(IEvidenceFactory);
			int num3 = default(int);
			try
			{
				byte_ = Class0.byte_0;
				int_ = Class1.int_0;
				num = 0;
				num2 = 1;
				while (true)
				{
					switch (((short_0 ^ char_0) - 35) ^ num)
					{
					case 0:
						num2 = 0;
						val = (IEvidenceFactory)AppDomain.CurrentDomain;
						num2 = 11;
						break;
					default:
						num2 = 4;
						val = null;
						num2 = 11;
						break;
					}
					num++;
					num3 = char_0 * char_0;
					num3 = char_0 + num3;
					num2 = 3;
					if (num3 % 2 == 0)
					{
						break;
					}
					num2 = 1;
				}
				num2 = 6;
				return val as AppDomain;
			}
			catch (Exception exception_)
			{
				int num4 = default(int);
				StackFrameHelper.CreateException9(exception_, num, val, num3, num4, num2, byte_, int_, short_0, char_0);
				throw;
			}
		}

		internal static void smethod_2<T>(T gparam_0, char char_0, int int_0) where T : ResourceManager
		{
			int[] int_ = default(int[]);
			byte[] byte_ = default(byte[]);
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			int num4 = default(int);
			try
			{
				int_ = Class1.int_0;
				byte_ = Class0.byte_0;
				num = 0;
				num2 = 0;
				num = 7;
				switch (((int_0 ^ char_0) - 0) ^ 0)
				{
				default:
					num = 6;
					num = 2;
					break;
				case 0:
					num = 8;
					gparam_0.ReleaseAllResources();
					break;
				}
				num2++;
				num3 = 2067;
				num4 = 23;
				num = 3;
			}
			catch (Exception exception_)
			{
				int num5 = default(int);
				int num6 = default(int);
				int num7 = default(int);
				StackFrameHelper.CreateExceptionN(exception_, new object[12]
				{
					num2, num3, num4, num5, num, int_, byte_, num6, num7, gparam_0,
					char_0, int_0
				});
				throw;
			}
		}

		internal static void smethod_3<T>(T gparam_0, byte[] byte_0, int int_0, int int_1, char char_0, int int_2) where T : Stream
		{
			byte[] byte_ = default(byte[]);
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			int num4 = default(int);
			try
			{
				byte_ = Class0.byte_0;
				num = 0;
				num2 = 0;
				num = 1;
				switch (((int_2 ^ char_0) - 0) ^ 0)
				{
				default:
					num = 4;
					break;
				case 0:
					num = 8;
					gparam_0.Write(byte_0, int_0, int_1);
					break;
				}
				num2++;
				num3 = 2067;
				num4 = 23;
				num = 7;
			}
			catch (Exception exception_)
			{
				int num5 = default(int);
				int num6 = default(int);
				int num7 = default(int);
				StackFrameHelper.CreateExceptionN(exception_, new object[14]
				{
					num2, num3, num4, num5, num, byte_, num6, num7, gparam_0, byte_0,
					int_0, int_1, char_0, int_2
				});
				throw;
			}
		}

		internal static Assembly smethod_4(byte[] byte_0, int int_0, char char_0)
		{
			int[] int_ = default(int[]);
			byte[] byte_ = default(byte[]);
			int num = default(int);
			int num2 = default(int);
			object obj = default(object);
			try
			{
				int_ = Class1.int_0;
				byte_ = Class0.byte_0;
				num = 0;
				num2 = 6;
				while (true)
				{
					switch (((int_0 ^ char_0) - 55) ^ num)
					{
					case 0:
						num2 = 0;
						obj = Assembly.Load(byte_0);
						num2 = 4;
						break;
					default:
						num2 = 1;
						obj = null;
						num2 = 4;
						break;
					}
					num++;
					if ((char_0 * char_0 + char_0) % 2 == 0)
					{
						break;
					}
					num2 = 8;
					num2 = 6;
				}
				num2 = 2;
				return obj as Assembly;
			}
			catch (Exception exception_)
			{
				int num3 = default(int);
				StackFrameHelper.CreateException9(exception_, num, obj, num3, num2, int_, byte_, byte_0, int_0, char_0);
				throw;
			}
		}

		internal static int smethod_5<T>(T gparam_0, byte[] byte_0, int int_0, int int_1, int int_2, char char_0) where T : Stream
		{
			byte[] byte_ = default(byte[]);
			int[] int_3 = default(int[]);
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			int num4 = default(int);
			try
			{
				byte_ = Class0.byte_0;
				int_3 = Class1.int_0;
				num = 0;
				num2 = 5;
				while (true)
				{
					switch (((int_2 ^ char_0) - 55) ^ num)
					{
					case 0:
						num2 = 10;
						num3 = gparam_0.Read(byte_0, int_0, int_1);
						num2 = 9;
						break;
					default:
						num2 = 4;
						num3 = 8;
						num2 = 9;
						break;
					}
					num++;
					num4 = char_0 * char_0;
					num4 = char_0 + num4;
					num2 = 2;
					if (num4 % 2 == 0)
					{
						break;
					}
					num2 = 5;
				}
				num2 = 7;
				return num3;
			}
			catch (Exception exception_)
			{
				int num5 = default(int);
				StackFrameHelper.CreateExceptionN(exception_, new object[13]
				{
					num, num3, num4, num5, num2, byte_, int_3, gparam_0, byte_0, int_0,
					int_1, int_2, char_0
				});
				throw;
			}
		}

		internal static byte[] smethod_6<T>(T gparam_0, char char_0, short short_0) where T : MemoryStream
		{
			int[] int_ = default(int[]);
			byte[] byte_ = default(byte[]);
			int num = default(int);
			int num2 = default(int);
			Array array = default(Array);
			int num3 = default(int);
			try
			{
				int_ = Class1.int_0;
				byte_ = Class0.byte_0;
				num = 0;
				num2 = 2;
				while (true)
				{
					switch (((char_0 ^ short_0) - 92) ^ num)
					{
					case 0:
						num2 = 1;
						array = gparam_0.ToArray();
						num2 = 8;
						break;
					default:
						num2 = 3;
						array = null;
						num2 = 8;
						break;
					}
					num++;
					num3 = short_0 * short_0;
					num3 = short_0 + num3;
					num2 = 6;
					if (num3 % 2 == 0)
					{
						break;
					}
					num2 = 2;
				}
				num2 = 4;
				return array as byte[];
			}
			catch (Exception exception_)
			{
				int num4 = default(int);
				StackFrameHelper.CreateException10(exception_, num, array, num3, num4, num2, int_, byte_, gparam_0, char_0, short_0);
				throw;
			}
		}

		internal static string[] smethod_7<T>(T gparam_0, short short_0, char char_0) where T : Assembly
		{
			int[] int_ = default(int[]);
			byte[] byte_ = default(byte[]);
			int num = default(int);
			int num2 = default(int);
			Array array = default(Array);
			try
			{
				int_ = Class1.int_0;
				byte_ = Class0.byte_0;
				num = 0;
				num2 = 8;
				while (true)
				{
					switch (((short_0 ^ char_0) - 61) ^ num)
					{
					case 0:
						num2 = 7;
						array = gparam_0.GetManifestResourceNames();
						num2 = 10;
						break;
					default:
						num2 = 5;
						array = null;
						num2 = 10;
						break;
					}
					num++;
					if ((short_0 * short_0 + short_0) % 2 == 0)
					{
						break;
					}
					num2 = 0;
					num2 = 8;
				}
				num2 = 4;
				return array as string[];
			}
			catch (Exception exception_)
			{
				int num3 = default(int);
				StackFrameHelper.CreateException9(exception_, num, array, num3, num2, int_, byte_, gparam_0, short_0, char_0);
				throw;
			}
		}

		static Class6()
		{
			byte[] byte_ = default(byte[]);
			int num = default(int);
			Array array = default(Array);
			try
			{
				byte_ = Class0.byte_0;
				num = 4;
				object_0 = new char[95]
				{
					'擪', '擩', '擪', '綣', '䊈', '䠢', '￨', '\ufff9', '￩', '찝',
					'퐂', '쎞', '\uf6c9', '\ue6b7', '\ud9dd', '팻', '\ueb28', '창', '푦', '쎳',
					'\uf6c9', '\ue6e6', '\ud9d6', '팑', '\ueb67', '찀', '\ue082', '\ue087', '\ue080', '팄',
					'쭸', '\udca0', '\ue99d', '秊', '\u1abf', '\u1ae5', '\u1abc', 'ᎇ', 'ϡ', '㳒',
					'㘵', '\u0e31', '⥯', 'ㅧ', '⛴', 'Ꭰ', 'ρ', '㳾', '㘴', '\u0e75',
					'⥗', 'ㅗ', '⛩', 'ᎀ', 'τ', '㳠', '㘰', 'ษ', '⥃', 'ㅌ',
					'⛚', 'Ꮃ', 'ϝ', '㳩', '㘷', 'ถ', '⥁', 'ㅷ', '⛨', '᎐',
					'ρ', '㳷', '㙄', 'ก', '⥆', 'ㅧ', '⛻', 'Ꮂ', 'γ', '㳒',
					'㙁', 'ฟ', '⥛', 'ㅹ', '⛠', 'Ꮁ', 'ϕ', '㳝', '㘳', 'ช',
					'⥚', 'ㅆ', '⛡', 'Ꭳ', 'ϔ'
				};
				array = new char[8];
				(array as char[])[0] = 'ख़';
				num = 2;
				(array as char[])[3] = '㎲';
				(array as char[])[5] = 'Ⲻ';
				num = 7;
				((char[])array)[1] = '㰑';
				((char[])array)[7] = '\u193a';
				num = 1;
				((char[])array)[6] = '☇';
				((char[])array)[2] = '⮿';
				num = 6;
				(array as char[])[4] = 'ᓹ';
				array_1 = new string[4];
				array_0 = array as char[];
			}
			catch (Exception exception_)
			{
				int num2 = default(int);
				StackFrameHelper.CreateException4(exception_, array, num2, num, byte_);
				throw;
			}
		}
	}

	internal static void smethod_0<T, U, V>(U gparam_0, T gparam_1, V gparam_2, short short_0, char char_0) where T : string where U : AppDomain
	{
		int[] int_ = default(int[]);
		byte[] byte_ = default(byte[]);
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		try
		{
			int_ = Class1.int_0;
			byte_ = Class0.byte_0;
			num = 5;
			num2 = 0;
			num = 2;
			while (true)
			{
				switch (((char_0 ^ short_0) - 26) ^ num2)
				{
				case 0:
					num = 6;
					gparam_0.SetData(gparam_1, gparam_2);
					break;
				default:
					num = 3;
					num = 0;
					break;
				}
				num2++;
				num3 = char_0 * char_0;
				num3 = char_0 + num3;
				num = 1;
				if (num3 % 2 == 0)
				{
					break;
				}
				num = 2;
			}
			num = 7;
		}
		catch (Exception exception_)
		{
			int num4 = default(int);
			int num5 = default(int);
			int num6 = default(int);
			StackFrameHelper.CreateExceptionN(exception_, new object[13]
			{
				num2, num3, num4, num, int_, byte_, num5, num6, gparam_0, gparam_1,
				gparam_2, short_0, char_0
			});
			throw;
		}
	}
}
