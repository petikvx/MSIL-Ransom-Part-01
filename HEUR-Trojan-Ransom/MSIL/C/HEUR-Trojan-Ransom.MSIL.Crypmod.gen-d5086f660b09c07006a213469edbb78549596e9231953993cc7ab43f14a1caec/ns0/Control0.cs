using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace ns0;

internal sealed class Control0 : TabControl
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 36)]
	private struct Struct0
	{
	}

	private static readonly object object_0;

	private static readonly object object_1 = new char[18];

	private static readonly object object_2;

	internal static byte byte_0/* Not supported: data(00) */;

	internal static byte[] smethod_0(byte[] byte_1, Aes aes_0)
	{
		using MemoryStream memoryStream = new MemoryStream();
		Exception0.smethod_0(byte_1, aes_0, memoryStream);
		return memoryStream.ToArray();
	}

	static Control0()
	{
		char[] array = new char[8];
		array[4] = '✱';
		array[6] = '〔';
		array[5] = 'ྋ';
		array[1] = 'ᛒ';
		array[3] = '㿗';
		array[2] = 'ॳ';
		array[0] = '\u1f17';
		array[7] = 'ᆽ';
		object_2 = new string[2];
		object_0 = array;
	}
}
