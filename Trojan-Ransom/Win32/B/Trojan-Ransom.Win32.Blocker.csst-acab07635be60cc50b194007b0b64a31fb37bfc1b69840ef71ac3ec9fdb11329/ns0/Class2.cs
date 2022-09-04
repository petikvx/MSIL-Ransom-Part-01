using System.Runtime.InteropServices;
using System.Security;

namespace ns0;

internal sealed class Class2
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 187594)]
	private struct Struct0
	{
	}

	internal sealed class Class3
	{
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 86)]
	private struct Struct1
	{
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static byte byte_0/* Not supported: data(00) */;

	private static readonly char[] char_2;

	private static readonly char[] char_3;

	private static readonly string[] string_1;

	internal static byte byte_1/* Not supported: data(00) */;

	internal static string smethod_0(string string_2, int int_0)
	{
		int num = 1967372890 + int_0;
		char[] array = string_2.ToCharArray();
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
		char_3 = new char[43];
		char[] array = new char[8];
		array[6] = '\u0c3e';
		array[2] = '\u1bf4';
		array[5] = 'Ṣ';
		array[1] = 'ⴸ';
		array[4] = '㨄';
		array[3] = '\u0d97';
		array[0] = 'ᙦ';
		array[7] = '㴰';
		string_1 = new string[1];
		char_2 = array;
		char_1 = new char[93797];
		char[] array2 = new char[8];
		array2[3] = '␔';
		array2[1] = '㑹';
		array2[4] = 'ⰳ';
		array2[7] = '㓈';
		array2[2] = '㪚';
		array2[0] = '♳';
		array2[5] = 'Ꮳ';
		array2[6] = 'ྋ';
		string_0 = new string[387];
		char_0 = array2;
	}
}
