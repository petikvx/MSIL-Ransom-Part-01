using System;
using System.IO;
using System.Threading.Tasks;

namespace ns0;

internal static class Class4
{
	internal enum Enum2
	{
		const_0,
		const_1
	}

	internal interface Interface0 : IDisposable
	{
		float Single_0 { get; }

		float Single_1 { get; }

		Task imethod_0(Enum2 enum2_0, float float_0, Stream stream_0);
	}

	internal interface Interface1
	{
		Task<Interface0> imethod_0(Stream stream_0, float? nullable_0, float? nullable_1);

		Task<Interface0> imethod_1(string string_0, float? nullable_0, float? nullable_1);

		Interface0 imethod_2(float float_0, float float_1);
	}

	private static Interface1 interface1_0;

	public static Interface1 Interface1_0
	{
		get
		{
			return interface1_0 ?? throw new Exception("");
		}
		set
		{
			interface1_0 = value;
		}
	}

	public static byte[] smethod_0(byte[] byte_0, byte[] byte_1)
	{
		Class3.smethod_0(byte_0, byte_1);
		return byte_0;
	}
}
