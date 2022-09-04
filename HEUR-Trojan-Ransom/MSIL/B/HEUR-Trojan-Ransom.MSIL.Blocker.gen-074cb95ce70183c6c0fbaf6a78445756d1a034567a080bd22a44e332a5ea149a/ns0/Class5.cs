using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Policy;

namespace ns0;

internal sealed class Class5
{
	private sealed class Class6
	{
		public static readonly Class6 class6_0;

		internal byte[] byte_0;

		static Class6()
		{
			Class7.smethod_2();
			if (smethod_3(BabelAttribute.Class0.Class1.smethod_1('ŗ', 286), new DateTime(635306814206137720L), 863, '\u0326'))
			{
				throw new Exception();
			}
			class6_0 = new Class6();
		}

		private Class6()
		{
			Assembly gparam_ = smethod_2(877, 863);
			Stream stream = smethod_4(gparam_, smethod_1(), 'ȯ', 603);
			if (stream != null)
			{
				byte[] array = (byte_0 = new byte[256]);
				Class9.Class10.smethod_0(stream, byte_0, 0, byte_0.Length, 'S', '\u0016');
			}
		}

		public string method_0(string string_0, int int_0)
		{
			int num = BabelAttribute.Class0.smethod_2(string_0, 9, '\v');
			int num2 = int_0 & 0xFF;
			char[] array = (char[])(IEnumerable)BabelAttribute.smethod_2(string_0, 102, 'f');
			while (--num >= 0)
			{
				array[num] = (char)(array[num] ^ (byte_0[num2] | int_0));
			}
			return Class14.smethod_0(new string(array), 219, 249);
		}
	}

	public static string smethod_0(string string_0, int int_0)
	{
		if (smethod_3(BabelAttribute.Class0.Class1.smethod_1('\u02d4', 669), new DateTime(635306814206407900L), 225, '\u0098'))
		{
			throw new Exception();
		}
		return Class14.smethod_0(Class6.class6_0.method_0(string_0, int_0), 482, 448);
	}

	[SpecialName]
	public static string smethod_1()
	{
		return Class7.smethod_0("\uf6e4\uf6ee\uf6e2\uf6b1\uf6ee\uf6b1\uf6e3\uf6b1\uf6b3\uf6e6\uf6b2\uf6b3\uf6e3\uf6b5\uf6e4\uf6b4\uf6ef\uf6e2\uf6e5\uf6b4\uf6e0\uf6b6\uf6e1\uf6ee\uf6b3\uf6e6\uf6b1\uf6b1\uf6b3\uf6b4\uf6b1\uf6ee", 63043);
	}

	static Class5()
	{
		Class7.smethod_2();
	}

	internal static Assembly smethod_2(short short_0, int int_0)
	{
		int num = 0;
		Assembly result;
		int num2;
		do
		{
			result = (((short_0 ^ int_0) - 49) ^ num) switch
			{
				1 => (Assembly)(ISerializable)Class9.Class10.smethod_4(125, 85), 
				0 => (Assembly)(ISerializable)Class9.Class10.smethod_4(501, 477), 
				_ => null, 
			};
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static bool smethod_3(DateTime dateTime_0, DateTime dateTime_1, int int_0, char char_0)
	{
		int num = 0;
		bool result = (((int_0 ^ char_0) - 121) ^ 0) switch
		{
			0 => Class14.smethod_1(dateTime_0, dateTime_1, 'ɉ', 'ɺ'), 
			_ => false, 
		};
		num++;
		return result;
	}

	internal static Stream smethod_4<T, U>(T gparam_0, U gparam_1, char char_0, int int_0) where T : Assembly where U : string
	{
		int num = 0;
		Stream result;
		int num2;
		do
		{
			result = (((int_0 ^ char_0) - 116) ^ num) switch
			{
				0 => Class14.smethod_2((Assembly)gparam_0, (string)gparam_1, 595, (short)634), 
				_ => null, 
			};
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static int smethod_5<T>(T gparam_0, int int_0, int int_1, char char_0, char char_1) where T : Random
	{
		int num = 0;
		int result;
		int num2;
		do
		{
			result = (((char_1 ^ char_0) - 18) ^ num) switch
			{
				0 => Class14.Class15.smethod_1((Random)gparam_0, int_0, int_1, 'ǂ', 'Ǫ'), 
				_ => 13, 
			};
			num++;
			num2 = char_1 * char_1;
			num2 = char_1 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static object smethod_6<T, U>(T gparam_0, U gparam_1, char char_0, short short_0) where T : ResourceManager where U : string
	{
		int num = 0;
		object result;
		int num2;
		do
		{
			result = (((short_0 ^ char_0) - 44) ^ num) switch
			{
				0 => Class9.Class10.smethod_5((ResourceManager)gparam_0, (string)gparam_1, 244, (short)255), 
				_ => null, 
			};
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static int smethod_7<T>(T gparam_0, int int_0, int int_1, short short_0) where T : Array
	{
		int num = 0;
		int result;
		do
		{
			result = (((int_1 ^ short_0) - 75) ^ num) switch
			{
				0 => Class9.Class10.Class11.smethod_0((Array)gparam_0, int_0, (short)476, (short)400), 
				_ => 7, 
			};
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
		return result;
	}

	internal static byte[] smethod_8<T>(T gparam_0, char char_0, char char_1) where T : MemoryStream
	{
		int num = 0;
		byte[] result;
		int num2;
		do
		{
			result = (((char_1 ^ char_0) - 83) ^ num) switch
			{
				0 => Class14.smethod_3((MemoryStream)gparam_0, 'Ƃ', (short)404), 
				_ => null, 
			};
			num++;
			num2 = char_1 * char_1;
			num2 = char_1 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static Assembly smethod_9<T>(byte[] byte_0, byte[] byte_1, T gparam_0, int int_0, short short_0) where T : Evidence
	{
		int num = 0;
		Assembly result = (((short_0 ^ int_0) - 108) ^ 0) switch
		{
			0 => (Assembly)(ISerializable)Class9.smethod_2(byte_0, byte_1, (Evidence)gparam_0, 213, 145), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static string[] smethod_10<T>(T gparam_0, char char_0, int int_0) where T : Assembly
	{
		int num = 0;
		string[] result = (((int_0 ^ char_0) - 81) ^ 0) switch
		{
			0 => (string[])(Array)Class9.smethod_3((Assembly)gparam_0, 833, 892), 
			_ => null, 
		};
		num++;
		return result;
	}
}
