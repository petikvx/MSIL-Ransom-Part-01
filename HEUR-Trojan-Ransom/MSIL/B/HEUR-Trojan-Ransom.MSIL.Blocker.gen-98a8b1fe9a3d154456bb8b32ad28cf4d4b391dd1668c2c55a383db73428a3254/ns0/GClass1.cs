using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace ns0;

public class GClass1
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 20)]
	private struct Struct0
	{
	}

	private static readonly Array array_0;

	private static readonly object object_0 = new char[10];

	private static readonly Array array_1;

	internal static byte byte_0/* Not supported: data(00) */;

	internal static byte[] smethod_0(byte[] byte_1)
	{
		byte[] byte_2 = new byte[16]
		{
			90, 64, 155, 37, 76, 167, 103, 94, 7, 33,
			211, 115, 130, 67, 70, 123
		};
		using RijndaelManaged rijndaelManaged_ = new RijndaelManaged();
		GClass2.smethod_2(rijndaelManaged_, byte_2);
		return Class4.Class5.smethod_0(byte_1, rijndaelManaged_, byte_2);
	}

	static GClass1()
	{
		char[] array = new char[8];
		array[0] = 'ڱ';
		array[5] = 'ᒿ';
		array[6] = '㽪';
		array[2] = 'ὑ';
		array[7] = '㻣';
		array[3] = '㮆';
		array[4] = '㗗';
		array[1] = '㩂';
		array_1 = new string[2];
		array_0 = array;
	}
}
