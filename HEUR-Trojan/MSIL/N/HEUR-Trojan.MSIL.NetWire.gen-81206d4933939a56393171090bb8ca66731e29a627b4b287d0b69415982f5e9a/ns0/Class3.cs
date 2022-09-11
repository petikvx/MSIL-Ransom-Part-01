using System.Runtime.InteropServices;

namespace ns0;

internal sealed class Class3
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 328)]
	private struct Struct0
	{
	}

	private static readonly object object_0;

	private static readonly object object_1 = new char[164];

	private static readonly object object_2;

	internal static byte byte_0/* Not supported: data(00) */;

	static Class3()
	{
		char[] array = new char[8];
		array[7] = '㕌';
		array[0] = '㯠';
		array[5] = '\u0cfb';
		array[1] = '⁚';
		array[2] = '⌅';
		array[4] = '\u09c8';
		array[3] = '〞';
		array[6] = '㕂';
		object_2 = new string[12];
		object_0 = array;
	}
}
