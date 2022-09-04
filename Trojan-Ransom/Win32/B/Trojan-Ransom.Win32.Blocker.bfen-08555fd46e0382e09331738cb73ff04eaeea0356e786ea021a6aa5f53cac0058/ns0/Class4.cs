using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Policy;

namespace ns0;

internal sealed class Class4
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 100)]
	private struct Struct2
	{
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static Struct2 struct2_0/* Not supported: data(00 00 19 00 00 00 60 04 73 3A D3 1A A0 17 55 12 57 31 14 14 76 1A 5A 04 3D 3A DE 1A AD 17 58 12 56 31 14 14 63 1A 46 04 6E 3A D7 1A AF 17 5B 12 5E 31 4D 14 38 1A 15 04 01 00 05 00 00 00 7C 3A 9C 1A B8 17 50 12 42 31 02 00 0B 00 00 00 9D 1A 91 17 5C 12 40 31 42 14 67 1A 47 04 33 3A D7 1A BA 17 5C 12) */;

	private static bool bool_0;

	[SecuritySafeCritical]
	static Class4()
	{
		smethod_3();
		char_1 = new char[50]
		{
			'\0', '\u0019', '\0', 'Ѡ', '㩳', '\u1ad3', 'ហ', 'ቕ', 'ㅗ', 'ᐔ',
			'\u1a76', 'њ', '㨽', '\u1ade', 'ឭ', 'ቘ', 'ㅖ', 'ᐔ', '\u1a63', 'ц',
			'㩮', '\u1ad7', 'ឯ', 'ቛ', 'ㅞ', 'ᑍ', 'ᨸ', 'Е', '\u0001', '\u0005',
			'\0', '㩼', '\u1a9c', '\u17b8', 'ቐ', 'ㅂ', '\u0002', '\v', '\0', '\u1a9d',
			'ទ', 'ቜ', 'ㅀ', 'ᑂ', '\u1a67', 'ч', '㨳', '\u1ad7', '\u17ba', 'ቜ'
		};
		char[] array = new char[8];
		array[1] = '㨝';
		array[6] = 'ᐴ';
		array[7] = 'ᨂ';
		array[5] = 'ㄲ';
		array[3] = '\u17c2';
		array[2] = '\u1ab2';
		array[4] = 'ሹ';
		array[0] = 'е';
		string_0 = new string[3];
		char_0 = array;
	}

	internal static string smethod_0(int int_0, int int_1)
	{
		int num = int_0 ^ 0x111F1200 ^ int_1;
		char[] array = char_1;
		int num2 = array[num];
		string result;
		if ((result = string_0[num2]) != null)
		{
			return result;
		}
		int num3 = array[num + 1];
		num3 = (int)((uint)array[num + 2] << 16) + num3;
		char[] array2 = new char[num3];
		char[] array3 = char_0;
		int num4 = array3.Length;
		num += 3;
		for (int num5 = 0; num5 < num3; num5 = 1 + num5)
		{
			array2[num5] = (char)(array[num + num5] ^ array3[(num5 + num2) % num4]);
		}
		result = new string(array2);
		string_0[num2] = result;
		return result;
	}

	[SecuritySafeCritical]
	internal static int smethod_1(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		while (true)
		{
			switch (int_3 ^ int_2)
			{
			case 71:
				return stream_0.Read(byte_0, int_0, int_1);
			}
		}
	}

	[SecuritySafeCritical]
	internal static object smethod_2(MethodBase methodBase_0, object object_0, object[] object_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 18:
				return methodBase_0.Invoke(object_0, object_1);
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_3()
	{
		if (bool_0)
		{
			return;
		}
		lock (typeof(Class4))
		{
			if (!bool_0)
			{
				bool_0 = true;
				AppDomain.CurrentDomain.ResourceResolve += Class0.Class3.smethod_1;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Assembly smethod_4(ResolveEventArgs resolveEventArgs_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 13:
				return resolveEventArgs_0.RequestingAssembly;
			}
		}
	}

	[SecuritySafeCritical]
	internal static object smethod_5(AppDomain appDomain_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 72:
				return appDomain_0.GetData(string_1);
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_6(AppDomain appDomain_0, string string_1, object object_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 46:
				appDomain_0.SetData(string_1, object_0);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static object smethod_7(MethodBase methodBase_0, object object_0, object[] object_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 39:
				return methodBase_0.Invoke(object_0, object_1);
			}
		}
	}

	[SecuritySafeCritical]
	internal static Assembly smethod_8(byte[] byte_0, byte[] byte_1, Evidence evidence_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 58:
				return Assembly.Load(byte_0, byte_1, evidence_0);
			}
		}
	}
}
