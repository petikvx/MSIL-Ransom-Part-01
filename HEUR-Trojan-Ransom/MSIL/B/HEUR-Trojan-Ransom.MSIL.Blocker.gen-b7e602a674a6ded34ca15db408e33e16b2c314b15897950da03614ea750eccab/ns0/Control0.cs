using System;
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

	private static readonly Array array_0;

	private static readonly object object_0 = new char[18];

	private static readonly object object_1;

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
		array[7] = '⩌';
		array[0] = '⩦';
		array[1] = '\u1ba1';
		array[6] = '㔣';
		array[4] = '㑸';
		array[5] = '⥗';
		array[2] = '㗽';
		array[3] = '⤧';
		object_1 = new string[2];
		array_0 = array;
	}
}
