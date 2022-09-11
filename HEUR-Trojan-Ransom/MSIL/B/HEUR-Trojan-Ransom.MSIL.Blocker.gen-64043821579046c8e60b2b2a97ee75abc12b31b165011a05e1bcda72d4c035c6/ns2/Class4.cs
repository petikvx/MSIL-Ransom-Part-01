using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using ns3;

namespace ns2;

internal abstract class Class4
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 48)]
	private struct Struct0
	{
	}

	private static readonly Array P;

	private static readonly Array q = new char[24];

	private static readonly Array O;

	internal static byte b/* Not supported: data(00) */;

	internal static bool smethod_0(Type type_0, char char_0)
	{
		return type_0.Name.Contains(char_0.ToString());
	}

	internal static byte[] smethod_1(byte[] byte_0, ICryptoTransform icryptoTransform_0)
	{
		using MemoryStream memoryStream = new MemoryStream();
		Class5.smethod_0(byte_0, icryptoTransform_0, memoryStream);
		return memoryStream.ToArray();
	}

	static Class4()
	{
		char[] array = new char[8];
		array[2] = '\u1df3';
		array[7] = '☟';
		array[0] = 'ງ';
		array[5] = '\u242c';
		array[3] = '⡵';
		array[1] = 'љ';
		array[6] = '㳺';
		array[4] = '㑘';
		O = new string[2];
		P = array;
	}
}
