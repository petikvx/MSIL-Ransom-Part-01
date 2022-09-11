using System.IO;

namespace C3904355907;

public sealed class C2181537457
{
	private C2181537457()
	{
	}

	public static void C3554254475(Stream stream_0, ref byte[] byte_0, ref byte[] byte_1, ref byte[] byte_2)
	{
		using C3865851505 c3865851505 = new C3865851505(stream_0, bool_0: true, byte_1, byte_2);
		c3865851505.Write(byte_0, 0, byte_0.Length);
		c3865851505.Flush();
	}

	public static void C3554254475(Stream stream_0, ref byte[] byte_0, int int_0, byte[] byte_1, byte[] byte_2)
	{
		using C3865851505 c3865851505 = new C3865851505(stream_0, bool_0: true, byte_1, byte_2);
		c3865851505.Write(byte_0, int_0, byte_0.Length - int_0);
		c3865851505.Flush();
	}
}
