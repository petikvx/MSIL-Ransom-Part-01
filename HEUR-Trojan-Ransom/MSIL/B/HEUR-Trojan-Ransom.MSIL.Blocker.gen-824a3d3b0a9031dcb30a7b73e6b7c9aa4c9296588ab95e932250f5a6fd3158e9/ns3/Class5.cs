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

	private static readonly object r;

	private static readonly object G = new char[24];

	private static readonly Array K;

	internal static byte C/* Not supported: data(00) */;

	internal uint[] f;

	internal int u;

	internal uint o;

	public bool f => o == 1;

	public Class5()
	{
		o = 1u;
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
		return (o & 1) != 0;
	}

	public bool method_1()
	{
		bool result = (o & 1) != 0;
		o >>= 1;
		if (o == 1)
		{
			method_2();
		}
		return result;
	}

	private void method_2()
	{
		if (u > 0)
		{
			uint[] array = this.f;
			int num = u - 1;
			int num2 = (u = num);
			uint num3 = (o = array[num]);
		}
	}

	public void method_3(bool bool_0)
	{
		if ((o & -2147483648L) != 0L)
		{
			method_4();
		}
		uint num = (o = (uint)((o << 1) | (int)(bool_0 ? 1u : 0u)));
	}

	private void method_4()
	{
		if (this.f == null)
		{
			uint[] array = (this.f = new uint[16]);
		}
		uint[] array2 = this.f;
		int num = u;
		int num2 = (u = num + 1);
		array2[num] = o;
		o = 1u;
		int num3 = this.f.Length;
		if (u >= num3)
		{
			uint[] destinationArray = new uint[2 * num3];
			Array.Copy(this.f, destinationArray, num3);
			uint[] array3 = (this.f = destinationArray);
		}
	}

	static Class5()
	{
		char[] array = new char[8];
		array[7] = '㻓';
		array[1] = '㗐';
		array[3] = '⅍';
		array[6] = '\u1b4e';
		array[2] = 'ᢱ';
		array[4] = '\u0b79';
		array[0] = '㞝';
		array[5] = 'ᾘ';
		K = new string[2];
		r = array;
	}
}
