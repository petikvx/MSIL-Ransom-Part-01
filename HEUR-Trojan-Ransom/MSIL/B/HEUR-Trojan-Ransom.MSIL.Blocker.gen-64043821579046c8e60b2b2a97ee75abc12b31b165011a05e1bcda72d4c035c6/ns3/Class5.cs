using System;
using System.IO;
using System.Security.Cryptography;

namespace ns3;

internal sealed class Class5
{
	internal uint[] j;

	internal int W;

	internal uint r;

	public bool b => r == 1;

	public Class5()
	{
		r = 1u;
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
		return (r & 1) != 0;
	}

	public bool method_1()
	{
		bool result = (r & 1) != 0;
		r >>= 1;
		if (r == 1)
		{
			method_2();
		}
		return result;
	}

	private void method_2()
	{
		if (W > 0)
		{
			uint[] array = j;
			int num = W - 1;
			int num2 = (W = num);
			uint num3 = (r = array[num]);
		}
	}

	public void method_3(bool bool_0)
	{
		if ((r & -2147483648L) != 0L)
		{
			method_4();
		}
		uint num = (r = (uint)((r << 1) | (int)(bool_0 ? 1u : 0u)));
	}

	private void method_4()
	{
		if (j == null)
		{
			uint[] array = (j = new uint[16]);
		}
		uint[] array2 = j;
		int w = W;
		int num = (W = w + 1);
		array2[w] = r;
		r = 1u;
		int num2 = j.Length;
		if (W >= num2)
		{
			uint[] destinationArray = new uint[2 * num2];
			Array.Copy(j, destinationArray, num2);
			uint[] array3 = (j = destinationArray);
		}
	}
}
