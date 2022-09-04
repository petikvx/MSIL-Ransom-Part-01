using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.License;
using SmartAssembly.Shared;

namespace ns0;

internal sealed class Class3
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 16)]
	private struct Struct0
	{
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static Struct0 struct0_0/* Not supported: data(00 00 05 00 00 00 7F 1B 42 09 86 04 F5 12 C3 30) */;

	public static Bitmap smethod_0(string string_1)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		Stream stream = smethod_1(License.smethod_5(562, 614), Class0.smethod_2(AppRegistryKeys.smethod_0(512389483, 1), string_1, AppRegistryKeys.smethod_0(512389552, 7), 158, 220), 354, 379);
		if (stream != null)
		{
			return new Bitmap(stream);
		}
		return null;
	}

	[SecuritySafeCritical]
	static Class3()
	{
		char[] array_ = new char[8];
		Class4.Class5.Class6.Class7.smethod_3(array_, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 192, 167);
		char_1 = array_;
		char[] array = new char[8];
		array[4] = 'め';
		array[0] = '᭒';
		array[2] = 'ҷ';
		array[3] = 'ዌ';
		array[6] = '㶐';
		array[1] = 'ॷ';
		array[7] = '㞓';
		array[5] = '㚼';
		string_0 = new string[1];
		char_0 = array;
		AppPathFinder.smethod_3();
	}

	[SecuritySafeCritical]
	internal static Stream smethod_1(Assembly assembly_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 25:
				return Class4.Class5.Class6.smethod_6(assembly_0, string_1, 365, 287);
			}
		}
	}

	[SecuritySafeCritical]
	internal static string smethod_2(ResolveEventArgs resolveEventArgs_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 28:
				return Class4.Class5.Class6.Class7.smethod_2(resolveEventArgs_0, 91, 76);
			}
		}
	}

	[SecuritySafeCritical]
	internal static MethodInfo smethod_3(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 10:
				return Class0.smethod_12(assembly_0, 172, 159);
			}
		}
	}

	internal static string smethod_4(int int_0, int int_1)
	{
		int num = int_0 ^ 0x1E8A7137 ^ int_1;
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
	internal static void smethod_5(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 121:
				Class4.Class5.Class6.Class7.smethod_3(array_0, runtimeFieldHandle_0, 627, 532);
				return;
			}
		}
	}
}
