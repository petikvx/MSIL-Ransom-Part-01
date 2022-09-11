using System;
using System.IO;
using System.Security.Cryptography;

namespace ns3;

internal sealed class Class5
{
	private int s;

	private uint E;

	internal uint[] a;

	public bool S => E == 1;

	public Class5()
	{
		E = 1u;
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
		return (E & 1) != 0;
	}

	public bool method_1()
	{
		bool result = (E & 1) != 0;
		E >>= 1;
		if (E == 1)
		{
			method_2();
		}
		return result;
	}

	private void method_2()
	{
		if (s > 0)
		{
			uint[] array = a;
			E = array[--s];
		}
	}

	public void method_3(bool bool_0)
	{
		if ((E & -2147483648L) != 0L)
		{
			method_4();
		}
		E = (uint)((E << 1) | (int)(bool_0 ? 1u : 0u));
	}

	private void method_4()
	{
		if (a == null)
		{
			uint[] array = (a = new uint[16]);
		}
		a[s++] = E;
		E = 1u;
		int num = a.Length;
		if (s >= num)
		{
			uint[] destinationArray = new uint[2 * num];
			Array.Copy(a, destinationArray, num);
			uint[] array2 = (a = destinationArray);
		}
	}
}
