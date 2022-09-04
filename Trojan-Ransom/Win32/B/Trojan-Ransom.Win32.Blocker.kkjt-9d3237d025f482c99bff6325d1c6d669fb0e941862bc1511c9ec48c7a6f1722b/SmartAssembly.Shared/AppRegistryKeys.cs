using System;
using System.IO;
using System.IO.Packaging;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Forms;
using Microsoft.Win32;
using SmartAssembly.License;
using ns0;

namespace SmartAssembly.Shared;

public sealed class AppRegistryKeys
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1688)]
	private struct Struct2
	{
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static Struct2 struct2_0/* Not supported: data(00 00 12 00 00 00 72 08 4D 3B 0D 27 4E 01 2D 1D F1 3D 23 0A 1D 28 7D 08 70 3B 0E 27 5E 01 7A 1D D7 3D 30 0A 0C 28 44 08 7E 3B 01 00 1E 00 00 00 71 3B 04 27 5C 01 2E 1D E7 3D 30 0A 0A 28 44 08 7E 3B 3C 27 55 01 2D 1D A6 3D 65 0A 4B 28 13 08 6C 3B 04 27 5E 01 3F 1D CC 3D 03 0A 1D 28 45 08 02 3B 2C 27 5B 01 2E 1D F5 3D 0D 0A 02 00 04 00 00 00 3B 27 5B 01 2E 1D F8 3D 03 00 01 00 00 00 1A 01 04 00 09 00 00 00 6C 1D BE 3D 69 0A 56 28 11 08 0C 3B 5A 27 08 01 6B 1D 05 00 0D 00 00 00 C3 3D 3C 0A 19 28 53 08 56 3B 2A 27 49 01 29 1D F5 3D 3C 0A 1A 28 4D 08 5B 3B 06 00 20 00 00 00 02 0A 15 28 40 08 50 3B 1F 27 7B 01 29 1D E3 3D 34 0A 15 28 43 08 4E 3B 12 27 14 01 16 1D F9 3D 32 0A 1D 28 4F 08 51 3B 0E 27 14 01 08 1D F5 3D 22 0A 17 28 54 08 50 3B 08 27 5F 01 29 1D BE 3D 07 00 04 00 00 00 56 28 51 08 4C 3B 0C 27 08 00 02 00 00 00 6E 08 69 3B 09 00 12 00 00 00 67 3B 05 27 5B 01 38 1D FC 3D 34 0A 2E 28 48 08 51 3B 1E 27 5B 01 36 1D C3 3D 25 0A 01 28 4D 08 47 3B 18 27 0A 00 13 00 00 00 59 27 0A 01 6B 1D A4 3D 7C 0A 49 28 10 08 0F 3B 5A 27 0E 01 0E 1D A0 3D 61 0A 42 28 12 08 15 3B 51 27 0F 01 6C 1D 0B 00 F2 00 00 00 6E 01 32 1D F9 3D 22 0A 58 28 42 08 4D 3B 1B 27 43 01 7A 1D FF 3D 37 0A 58 28 06 08 59 3B 5B 27 47 01 7D 1D B0 3D 39 0A 19 28 52 08 02 3B 0E 27 42 01 2A 1D F9 3D 23 0A 1D 28 45 08 02 3B 0A 27 54 01 3E 1D B0 3D 26 0A 11 28 4D 08 4E 3B 4B 27 54 01 35 1D B0 3D 3D 0A 17 28 4F 08 45 3B 0E 27 48 01 7A 1D E2 3D 24 0A 16 28 0F 08 02 3B 61 27 6E 01 32 1D F9 3D 22 0A 58 28 48 08 51 3B 4B 27 58 01 3F 1D F3 3D 30 0A 0D 28 52 08 47 3B 4B 27 53 01 2E 1D B0 3D 26 0A 19 28 52 08 02 3B 08 27 48 01 3F 1D F1 3D 25 0A 1D 28 45 08 02 3B 1E 27 49 01 33 1D FE 3D 36 0A 58 28 40 08 02 3B 1D 27 5F 01 28 1D E3 3D 38 0A 17 28 4F 08 02 3B 04 27 5C 01 7A 1D C2 3D 34 0A 1C 28 01 08 65 3B 0A 27 4E 01 3F 1D B7 3D 22 0A 58 28 72 08 4F 3B 0A 27 48 01 2E 1D D1 3D 22 0A 0B 28 44 08 4F 3B 09 27 56 01 23 1D B0 3D 26 0A 10 28 48 08 41 3B 03 27 1A 01 33 1D E3 3D 71 0A 17 28 4F 08 4E 3B 12 27 1A 01 36 1D F9 3D 32 0A 1D 28 4F 08 51 3B 0E 27 5E 01 7A 1D F6 3D 3E 0A 0A 28 01 08 56 3B 0E 27 49 01 2E 1D F9 3D 3F 0A 1F 28 01 08 51 3B 04 27 5C 01 2E 1D E7 3D 30 0A 0A 28 44 08 0C 3B 4B 27 30 01 50 1D C9 3D 3E 0A 0D 28 01 08 51 3B 03 27 55 01 2F 1D FC 3D 35 0A 58 28 53 08 47 3B 1B 27 55 01 28 1D E4 3D 71 0A 0C 28 49 08 4B 3B 18 27 1A 01 2A 1D E2 3D 3E 0A 1A 28 4D 08 47 3B 06 27 1A 01 2E 1D FF 3D 71 0A 0C 28 49 08 47 3B 4B 27 4C 01 3F 1D FE 3D 35 0A 17 28 53 08 02 3B 1C 27 52 01 35 1D B0 3D 22 0A 0D 28 51 08 52 3B 07 27 53 01 3F 1D F4 3D 71 0A 5F 28 5A 08 12 3B 16 27 1D 01 74 1D 0C 00 01 00 00 00 1E 1D 0D 00 13 00 00 00 C0 3D 23 0A 17 28 46 08 50 3B 0A 27 57 01 7A 1D F8 3D 30 0A 0B 28 01 08 47 3B 13 27 4A 01 33 1D E2 3D 34 0A 1C 28 0E 00 05 00 00 00 34 0A 0A 28 53 08 4D 3B 19 27 0F 00 E5 00 00 00 2C 28 49 08 4B 3B 18 27 1A 01 3B 1D E0 3D 21 0A 14 28 48 08 41 3B 0A 27 4E 01 33 1D FF 3D 3F 0A 58 28 49 08 43 3B 18 27 1A 01 38 1D F5 3D 34 0A 16 28 01 08 40 3B 1E 27 53 01 36 1D E4 3D 71 0A 0F 28 48 08 56 3B 03 27 1A 01 3B 1D FE 3D 71 0A 1D 28 57 08 43 3B 07 27 4F 01 3B 1D E4 3D 38 0A 17 28 4F 08 02 3B 1D 27 5F 01 28 1D E3 3D 38 0A 17 28 4F 08 02 3B 04 27 5C 01 7A 1D C3 3D 3C 0A 19 28 53 08 56 3B 2A 27 49 01 29 1D F5 3D 3C 0A 1A 28 4D 08 5B 3B 47 27 1A 01 3B 1D FE 3D 35 0A 58 28 55 08 4A 3B 0E 27 48 01 3F 1D F6 3D 3E 0A 0A 28 44 08 02 3B 08 27 5B 01 34 1D FE 3D 3E 0A 0C 28 01 08 40 3B 0E 27 1A 01 3E 1D F9 3D 22 0A 0C 28 53 08 4B 3B 09 27 4F 01 2E 1D F5 3D 35 0A 56 28 01 08 7B 3B 04 27 4F 01 7A 1D F3 3D 30 0A 16 28 01 08 4B 3B 05 27 49 01 2E 1D F1 3D 3D 0A 14 28 01 08 71 3B 06 27 5B 01 28 1D E4 3D 10 0A 0B 28 52 08 47 3B 06 27 58 01 36 1D E9 3D 71 0A 17 28 4F 08 02 3B 1F 27 52 01 33 1D E3 3D 71 0A 1B 28 4E 08 4F 3B 1B 27 4F 01 2E 1D F5 3D 23 0A 58 28 55 08 4D 3B 4B 27 58 01 3F 1D B0 3D 30 0A 1A 28 4D 08 47 3B 4B 27 4E 01 35 1D B0 3D 23 0A 0D 28 4F 08 02 3B 1F 27 52 01 33 1D E3 3D 71 0A 19 28 51 08 52 3B 07 27 53 01 39 1D F1 3D 25 0A 11 28 4E 08 4C 3B 45 27 30 01 50 1D C4 3D 39 0A 11 28 52 08 02 3B 0A 27 4A 01 2A 1D FC 3D 38 0A 1B 28 40 08 56 3B 02 27 55 01 34 1D B0 3D 26 0A 11 28 4D 08 4E 3B 4B 27 54 01 35 1D E7 3D 71 0A 09 28 54 08 4B 3B 1F 27 14 01 10 00 20 00 00 00 72 08 4F 3B 0A 27 48 01 2E 1D D1 3D 22 0A 0B 28 44 08 4F 3B 09 27 56 01 23 1D B0 3D 14 0A 0E 28 40 08 4E 3B 1E 27 5B 01 2E 1D F9 3D 3E 0A 16 28 01 08 74 3B 0E 27 48 01 29 1D F9 3D 3E 0A 16 28 11 00 0F 00 00 00 41 3B 53 27 03 01 6C 1D A4 3D 65 0A 4D 28 40 08 41 3B 0F 27 0A 01 38 1D A5 3D 68 0A 4C 28 12 00 19 00 00 00 46 CF 2C E9 43 F5 8A D5 45 E2 65 C0 79 E0 2E D3 7C CF 62 E9 4E F5 87 D5 48 E2 64 C0 79 E0 3B D3 60 CF 31 E9 47 F5 85 D5 4B E2 6C C0 20 E0 60 D3 33 CF 13 00 05 00 00 00 0C E8 23 F4 BD D4 6F E3 5F C1 14 00 06 00 00 00 44 FF 90 DF 4E E8 2C CA 68 EA 76 D9 15 00 0A 00 00 00 04 DE 88 E9 A2 CB F8 EB FC D8 BC C4 AF E2 84 FE 53 DE 8F E9 16 00 14 00 00 00 A1 EF F4 CD 93 ED 9C DE C6 C2 91 E4 C4 F8 3C D8 FD EF C2 CD 93 ED 9F DE D8 C2 9C E4 A8 F8 79 D8 A0 EF CB CD 90 ED 96 DE 17 00 0D 00 00 00 B0 DC F7 FC EB CF FC D3 BC F5 DE E9 1C C9 D3 FE FB DC E8 FC A0 CF F4 D3 B8 F5) */;

	public static string SubkeyApplication => smethod_1(smethod_0(512389428, 3), AppNameFinder.AppName, 972, 961);

	public static string WowSubkeyApplication => smethod_1(smethod_0(512389412, 6), AppNameFinder.AppName, 820, 825);

	public static object GetRegistryEntry(string valueName, object defaultValue)
	{
		using RegistryKey registryKey = AppPathFinder.smethod_0(Registry.LocalMachine, SubkeyApplication, 882, 866);
		if (registryKey == null)
		{
			return defaultValue;
		}
		return SmartAssembly.License.License.smethod_2(registryKey, valueName, defaultValue, 190, 250);
	}

	private AppRegistryKeys()
	{
	}

	[SecuritySafeCritical]
	static AppRegistryKeys()
	{
		AppPathFinder.smethod_3();
		char[] array_ = new char[844];
		Class4.Class5.Class6.Class7.smethod_3(array_, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 236, 139);
		char_1 = array_;
		char[] array = new char[8];
		array[5] = '㶐';
		array[4] = 'ᵚ';
		array[2] = '❫';
		array[1] = '㬢';
		array[0] = '\u0821';
		array[7] = '⡸';
		array[6] = '\u0a51';
		array[3] = 'ĺ';
		string_0 = new string[24];
		char_0 = array;
	}

	internal static string smethod_0(int int_0, int int_1)
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
	internal static string smethod_1(string string_1, string string_2, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 13:
				return Class4.smethod_6(string_1, string_2, 487, 462);
			}
		}
	}

	[SecuritySafeCritical]
	internal static string smethod_2(object object_0, object object_1, object object_2, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 33:
				return Class4.Class5.smethod_1(object_0, object_1, object_2, 752, 650);
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_3(Control control_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 37:
				Class4.smethod_7(control_0, string_1, 744, 706);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static AssemblyName smethod_4(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 11:
				return Class4.Class5.Class6.smethod_1(assembly_0, 469, 508);
			}
		}
	}

	[SecuritySafeCritical]
	internal static Stream smethod_5(PackagePart packagePart_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 34:
				return Class4.Class5.Class6.Class7.smethod_4(packagePart_0, 873, 893);
			}
		}
	}

	[SecuritySafeCritical]
	internal static AppDomain smethod_6(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 45:
				return Class4.smethod_8(407, 505);
			}
		}
	}

	[SecuritySafeCritical]
	internal static int smethod_7(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		while (true)
		{
			switch (int_3 ^ int_2)
			{
			case 123:
				return Class4.Class5.Class6.Class7.smethod_5(stream_0, byte_0, int_0, int_1, 236, 181);
			}
		}
	}
}
