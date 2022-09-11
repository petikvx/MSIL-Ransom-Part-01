using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace ns3;

internal sealed class Class5
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 48)]
	private struct Struct0
	{
	}

	private int d;

	private uint M;

	private static readonly Array b;

	private static readonly object F = new char[24];

	private static readonly object a;

	internal static byte E/* Not supported: data(00) */;

	internal uint[] I;

	public bool U => M == 1;

	public Class5()
	{
		M = 1u;
	}

	internal static void smethod_0(byte[] byte_0, ICryptoTransform icryptoTransform_0, MemoryStream memoryStream_0)
	{
		using CryptoStream cryptoStream = new CryptoStream(memoryStream_0, icryptoTransform_0, CryptoStreamMode.Write);
		for (int i = 0; i < byte_0.Length; i++)
		{
			cryptoStream.WriteByte(byte_0[i]);
		}
	}

	public bool method_0()
	{
		return (M & 1) != 0;
	}

	public bool method_1()
	{
		bool result = (M & 1) != 0;
		M >>= 1;
		if (M == 1)
		{
			method_2();
		}
		return result;
	}

	private void method_2()
	{
		if (d > 0)
		{
			uint[] i = I;
			M = i[--d];
		}
	}

	public void method_3(bool bool_0)
	{
		if ((M & -2147483648L) != 0L)
		{
			method_4();
		}
		M = (uint)((M << 1) | (int)(bool_0 ? 1u : 0u));
	}

	private void method_4()
	{
		if (I == null)
		{
			uint[] array = (I = new uint[16]);
		}
		I[d++] = M;
		M = 1u;
		int num = I.Length;
		if (d >= num)
		{
			uint[] array2 = new uint[2 * num];
			Array.Copy(I, array2, num);
			uint[] array3 = (I = array2);
		}
	}

	static Class5()
	{
		char[] array = new char[8];
		array[4] = 'ቔ';
		array[2] = 'ࣂ';
		array[1] = '㆖';
		array[6] = '↴';
		array[3] = '⏲';
		array[5] = 'ᅣ';
		array[7] = '㏅';
		array[0] = '㿂';
		a = new string[2];
		b = array;
	}
}
