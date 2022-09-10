using System.Runtime.InteropServices;
using System.Security;

namespace ns0;

internal sealed class Class2
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1043)]
	private struct Struct1
	{
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 513032)]
	private struct Struct2
	{
	}

	internal static byte byte_0/* Not supported: data(00) */;

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static byte byte_1/* Not supported: data(00) */;

	internal static string smethod_0(string string_1, int int_0)
	{
		int num = 1864330169 + int_0;
		char[] array = string_1.ToCharArray();
		for (int i = 0; i < array.Length; i++)
		{
			int num2 = i;
			char c = array[i];
			array[num2] = (char)((((c & 0xFF) ^ num++) << 8) | (byte)(((int)c >> 8) ^ num++));
		}
		return string.Intern(new string(array));
	}

	[SecuritySafeCritical]
	static Class2()
	{
		char_1 = new char[256516];
		char[] array = new char[8];
		array[0] = 'ᯐ';
		array[3] = 'ᨢ';
		array[4] = '\u1a1a';
		array[6] = '㛨';
		array[2] = '\u20df';
		array[1] = 'ⴍ';
		array[5] = 'ᴴ';
		array[7] = '㐿';
		string_0 = new string[1278];
		char_0 = array;
	}
}
