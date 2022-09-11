using System;
using System.IO;
using System.Security.Cryptography;

namespace ns3;

internal sealed class Class5
{
	private uint[] y;

	private uint p;

	internal int N;

	public bool c => p == 1;

	public Class5()
	{
		p = 1u;
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
		return (p & 1) != 0;
	}

	public bool method_1()
	{
		bool result = (p & 1) != 0;
		p >>= 1;
		if (p == 1)
		{
			method_2();
		}
		return result;
	}

	private void method_2()
	{
		if (N > 0)
		{
			uint[] array = y;
			int num = N - 1;
			int num2 = (N = num);
			p = array[num];
		}
	}

	public void method_3(bool bool_0)
	{
		if ((p & -2147483648L) != 0L)
		{
			method_4();
		}
		p = (uint)((p << 1) | (int)(bool_0 ? 1u : 0u));
	}

	private void method_4()
	{
		if (y == null)
		{
			y = new uint[16];
		}
		uint[] array = y;
		int n = N;
		int num = (N = n + 1);
		array[n] = p;
		p = 1u;
		int num2 = y.Length;
		if (N >= num2)
		{
			uint[] destinationArray = new uint[2 * num2];
			Array.Copy(y, destinationArray, num2);
			y = destinationArray;
		}
	}
}
