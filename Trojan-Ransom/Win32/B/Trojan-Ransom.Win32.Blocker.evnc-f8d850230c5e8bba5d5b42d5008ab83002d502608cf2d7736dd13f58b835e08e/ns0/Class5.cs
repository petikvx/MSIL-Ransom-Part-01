using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Text;

namespace ns0;

internal sealed class Class5
{
	internal sealed class Class6
	{
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 42)]
		private struct Struct3
		{
		}

		internal sealed class Class7
		{
			[SecuritySafeCritical]
			internal static void smethod_0<T>(T gparam_0, char char_0, int int_0) where T : string
			{
				int num = 0;
				int num2;
				do
				{
					switch (((int_0 ^ char_0) - 83) ^ num)
					{
					case 0:
						Class1.smethod_0((string)gparam_0, 'Ό', '\u038b');
						break;
					}
					num++;
					num2 = char_0 * char_0;
					num2 = char_0 + num2;
				}
				while (num2 % 2 != 0);
			}
		}

		private static readonly Array array_0;

		private static readonly Array array_1;

		private static readonly object object_0;

		internal static byte byte_0/* Not supported: data(00) */;

		[SecuritySafeCritical]
		internal static Assembly smethod_0(byte[] byte_1, int int_0, char char_0)
		{
			int num = 0;
			Assembly result = (((int_0 ^ char_0) - 55) ^ 0) switch
			{
				0 => Class1.smethod_2(byte_1, 'ŋ', 374), 
				_ => null, 
			};
			num++;
			return result;
		}

		static Class6()
		{
			array_1 = new char[21];
			char[] array = new char[8];
			array[4] = '㱽';
			array[3] = '㔻';
			array[2] = 'Ӊ';
			array[1] = '⬢';
			array[6] = '\u0cfc';
			array[7] = 'ᆺ';
			array[0] = '᠉';
			array[5] = 'ۉ';
			object_0 = new string[1];
			array_0 = array;
		}
	}

	internal sealed class Class8
	{
		internal sealed class Class9
		{
			[SecuritySafeCritical]
			internal static StringBuilder smethod_0<T>(T gparam_0, char char_0, int int_0, short short_0) where T : StringBuilder
			{
				int num = 0;
				StringBuilder result;
				do
				{
					result = (((int_0 ^ short_0) - 4) ^ num) switch
					{
						0 => Class11.smethod_2((StringBuilder)gparam_0, char_0, '\u0091', 181), 
						_ => null, 
					};
					num++;
				}
				while ((short_0 * short_0 + short_0) % 2 != 0);
				return result;
			}

			[SecuritySafeCritical]
			internal static void smethod_1<T>(T gparam_0, char char_0, int int_0) where T : Array
			{
				int num = 0;
				int num2;
				do
				{
					switch (((int_0 ^ char_0) - 97) ^ num)
					{
					case 0:
						Class11.smethod_3((Array)gparam_0, 372, (short)340);
						break;
					}
					num++;
					num2 = char_0 * char_0;
					num2 = char_0 + num2;
				}
				while (num2 % 2 != 0);
			}

			[SecuritySafeCritical]
			internal static string smethod_2<T>(T gparam_0, char char_0, char char_1)
			{
				int num = 0;
				string result = (((char_1 ^ char_0) - 23) ^ 0) switch
				{
					0 => (string)(IComparable<string>)gparam_0.ToString(), 
					_ => null, 
				};
				num++;
				return result;
			}
		}

		[SecuritySafeCritical]
		internal static void smethod_0<T>(T gparam_0, int int_0, int int_1) where T : Array
		{
			int num = 0;
			switch (((int_0 ^ int_1) - 51) ^ 0)
			{
			case 0:
				Class1.smethod_3((Array)gparam_0, 272, 'Ė');
				break;
			}
			num++;
		}

		[SecuritySafeCritical]
		internal static void smethod_1<T>(T gparam_0, short short_0, int int_0) where T : string
		{
			int num = 0;
			switch (((short_0 ^ int_0) - 67) ^ 0)
			{
			case 0:
				Class11.smethod_4((string)gparam_0, (short)515, 523);
				break;
			}
			num++;
		}

		[SecuritySafeCritical]
		internal static Assembly smethod_2(byte[] byte_0, int int_0, short short_0)
		{
			int num = 0;
			Assembly result = (((short_0 ^ int_0) - 64) ^ 0) switch
			{
				0 => (Assembly)(ISerializable)smethod_3(byte_0, 974, 967), 
				_ => null, 
			};
			num++;
			return result;
		}

		[SecuritySafeCritical]
		internal static Assembly smethod_3(byte[] byte_0, int int_0, short short_0)
		{
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected O, but got Unknown
			int num = 0;
			Assembly result = (((int_0 ^ short_0) - 9) ^ 0) switch
			{
				0 => (Assembly)(_Assembly)Assembly.Load(byte_0), 
				_ => null, 
			};
			num++;
			return result;
		}
	}

	internal sealed class Class10
	{
		[SecuritySafeCritical]
		internal static MethodInfo smethod_0<T>(T gparam_0, short short_0, int int_0) where T : Assembly
		{
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			int num = 0;
			MethodInfo result = (((short_0 ^ int_0) - 89) ^ 0) switch
			{
				0 => (MethodInfo)(_MethodInfo)gparam_0.EntryPoint, 
				_ => null, 
			};
			num++;
			return result;
		}
	}

	internal sealed class Class11
	{
		[SecuritySafeCritical]
		internal static object smethod_0<T, U>(U gparam_0, T gparam_1, object[] object_0, int int_0, int int_1) where U : MethodBase
		{
			int num = 0;
			object result = (((int_1 ^ int_0) - 52) ^ 0) switch
			{
				0 => gparam_0.Invoke(gparam_1, object_0), 
				_ => null, 
			};
			num++;
			return result;
		}

		[SecuritySafeCritical]
		internal static byte smethod_1<T>(T gparam_0, int int_0, char char_0) where T : string
		{
			int num = 0;
			byte result;
			int num2;
			do
			{
				result = (((int_0 ^ char_0) - 14) ^ num) switch
				{
					0 => byte.Parse(gparam_0), 
					_ => 26, 
				};
				num++;
				num2 = char_0 * char_0;
				num2 = char_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		[SecuritySafeCritical]
		internal static StringBuilder smethod_2<T>(T gparam_0, char char_0, char char_1, int int_0) where T : StringBuilder
		{
			int num = 0;
			StringBuilder result = (((int_0 ^ char_1) - 36) ^ 0) switch
			{
				0 => (StringBuilder)(ISerializable)gparam_0.Append(char_0), 
				_ => null, 
			};
			num++;
			return result;
		}

		[SecuritySafeCritical]
		internal static void smethod_3<T>(T gparam_0, int int_0, short short_0) where T : Array
		{
			int num = 0;
			switch (((int_0 ^ short_0) - 32) ^ 0)
			{
			case 0:
				Array.Reverse(gparam_0);
				break;
			}
			num++;
		}

		[SecuritySafeCritical]
		internal static void smethod_4<T>(T gparam_0, short short_0, int int_0) where T : string
		{
			int num = 0;
			int num2;
			do
			{
				switch (((int_0 ^ short_0) - 8) ^ num)
				{
				case 0:
					Console.Title = gparam_0;
					break;
				}
				num++;
				num2 = short_0 * short_0;
				num2 = short_0 + num2;
			}
			while (num2 % 2 != 0);
		}
	}

	[SecuritySafeCritical]
	internal static byte smethod_0<T>(T gparam_0, char char_0, int int_0) where T : string
	{
		int num = 0;
		byte result = (((char_0 ^ int_0) - 50) ^ 0) switch
		{
			0 => Class1.smethod_4((string)gparam_0, 'm', 'o'), 
			_ => 10, 
		};
		num++;
		return result;
	}

	[SecuritySafeCritical]
	internal static string smethod_1<T>(T gparam_0, int int_0, int int_1)
	{
		int num = 0;
		string result = (((int_0 ^ int_1) - 5) ^ 0) switch
		{
			0 => (string)(IConvertible)Class8.Class9.smethod_2((object)gparam_0, 'Ύ', 'Ι'), 
			_ => null, 
		};
		num++;
		return result;
	}
}
