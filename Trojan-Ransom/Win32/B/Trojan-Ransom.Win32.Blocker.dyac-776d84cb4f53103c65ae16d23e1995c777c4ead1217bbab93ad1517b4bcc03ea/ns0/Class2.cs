using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace ns0;

internal sealed class Class2
{
	private sealed class Class3
	{
		public static readonly Class3 class3_0;

		internal byte[] byte_0;

		static Class3()
		{
			Class4.smethod_2();
			if (Class0.smethod_1(Class0.Class1.smethod_0(57, '_'), new DateTime(635305917381523437L), 426, 456))
			{
				throw new Exception();
			}
			class3_0 = new Class3();
		}

		private Class3()
		{
			Assembly gparam_ = (Assembly)(ICustomAttributeProvider)Class0.smethod_2('Ȼ', 621);
			Stream stream = Class4.smethod_3(gparam_, smethod_1(), 443, 410);
			if (stream != null)
			{
				byte[] array = (byte_0 = new byte[256]);
				Class12.smethod_0(stream, byte_0, 0, byte_0.Length, 653, 675);
			}
		}

		public string method_0(string string_0, int int_0)
		{
			int num = smethod_2(string_0, '\u009a', 136);
			int num2 = int_0 & 0xFF;
			char[] array = (char[])(IEnumerable)Class0.Class1.smethod_1(string_0, 420, 'ƴ');
			while (--num >= 0)
			{
				array[num] = (char)(array[num] ^ (byte_0[num2] | int_0));
			}
			return Class12.smethod_1(new string(array), 293, 'Ĉ');
		}
	}

	public static string smethod_0(string string_0, int int_0)
	{
		if (Class0.smethod_1(Class0.Class1.smethod_0(279, 'ű'), new DateTime(635305917386132812L), 65, 35))
		{
			throw new Exception();
		}
		return Class12.smethod_1(Class3.class3_0.method_0(string_0, int_0), 858, 'ͷ');
	}

	[SpecialName]
	public static string smethod_1()
	{
		return Class4.smethod_0(Class6.smethod_0(Class10.smethod_0("\ue221\ue220\ue224\ue227\ue276\ue226\ue275\ue221\ue226\ue271\ue272\ue22f\ue223\ue220\ue227\ue221\ue22e\ue22f\ue271\ue22f\ue222\ue227\ue272\ue225\ue224\ue274\ue222\ue22e\ue275\ue226\ue274\ue275", 59031), 61187), 60187);
	}

	static Class2()
	{
		Class4.smethod_2();
	}

	internal static int smethod_2<T>(T gparam_0, char char_0, int int_0) where T : string
	{
		int num = 0;
		int result;
		int num2;
		do
		{
			result = (((int_0 ^ char_0) - 18) ^ num) switch
			{
				0 => Class12.smethod_3((string)gparam_0, 375, 367), 
				_ => 4, 
			};
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static int smethod_3<T>(T gparam_0, int int_0, int int_1, int int_2, char char_0) where T : Random
	{
		int num = 0;
		int result = (((int_2 ^ char_0) - 19) ^ 0) switch
		{
			0 => Class12.Class15.smethod_0((Random)gparam_0, int_0, int_1, 'ǿ', 'ǵ'), 
			_ => int_0, 
		};
		num++;
		return result;
	}

	internal static int smethod_4<T>(T gparam_0, byte[] byte_0, int int_0, int int_1, char char_0, short short_0) where T : Stream
	{
		int num = 0;
		int result = (((short_0 ^ char_0) - 42) ^ 0) switch
		{
			0 => Class12.smethod_0((Stream)gparam_0, byte_0, int_0, int_1, 63, 17), 
			_ => 9, 
		};
		num++;
		return result;
	}
}
