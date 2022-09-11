using System;
using System.IO;
using System.Security.Cryptography;

namespace ns3;

internal sealed class Class5
{
	private uint L;

	internal uint[] j;

	internal int U;

	public bool F => L == 1;

	public Class5()
	{
		L = 1u;
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
		return (L & 1) != 0;
	}

	public bool method_1()
	{
		bool result = (L & 1) != 0;
		L >>= 1;
		if (L == 1)
		{
			method_2();
		}
		return result;
	}

	private void method_2()
	{
		if (U > 0)
		{
			uint[] array = j;
			int num = U - 1;
			int num2 = (U = num);
			L = array[num];
		}
	}

	public void method_3(bool bool_0)
	{
		if ((L & -2147483648L) != 0L)
		{
			method_4();
		}
		L = (uint)((L << 1) | (int)(bool_0 ? 1u : 0u));
	}

	private void method_4()
	{
		if (j == null)
		{
			uint[] array = (j = new uint[16]);
		}
		uint[] array2 = j;
		int u = U;
		int num = (U = u + 1);
		array2[u] = L;
		L = 1u;
		int num2 = j.Length;
		if (U >= num2)
		{
			uint[] destinationArray = new uint[2 * num2];
			Array.Copy(j, destinationArray, num2);
			uint[] array3 = (j = destinationArray);
		}
	}
}
