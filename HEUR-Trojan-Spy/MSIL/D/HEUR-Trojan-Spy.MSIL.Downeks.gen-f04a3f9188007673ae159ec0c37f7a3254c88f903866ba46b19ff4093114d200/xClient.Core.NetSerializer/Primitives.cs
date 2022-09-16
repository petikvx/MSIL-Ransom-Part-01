using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using dg3ypDAonQcOidMs0w;

namespace xClient.Core.NetSerializer;

public static class Primitives
{
	private sealed class StringHelper
	{
		private object m_encoder;

		private object m_decoder;

		private object m_byteBuffer;

		private object m_charBuffer;

		private static object MPQwPrtDkCGALVVOcoJ;

		public UTF8Encoding Encoding
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Encoder Encoder => null;

		public Decoder Decoder => null;

		public byte[] ByteBuffer => null;

		public char[] CharBuffer => null;

		static StringHelper()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			N5bSOyCUSBd0JHZWLed();
		}

		internal static void TSia2xCbJbwGssTtNQG()
		{
		}

		internal static void Cr7Kr0C40BHxqbY5MVV()
		{
		}

		internal static bool KHnMxQtdQnGJaE7Cjkg()
		{
			return true;
		}

		internal static StringHelper PxlCfgtzcarANEAP0Mr()
		{
			return null;
		}

		internal static object En2ArtCngDS7uqgBcvP(object object_0)
		{
			return null;
		}

		internal static void N5bSOyCUSBd0JHZWLed()
		{
		}
	}

	[ThreadStatic]
	private static StringHelper s_stringHelper;

	private static readonly byte[] s_emptyByteArray;

	private static Primitives s6e1VKtO74bDYXLobtH;

	public static MethodInfo GetWritePrimitive(Type type)
	{
		return null;
	}

	public static MethodInfo GetReaderPrimitive(Type type)
	{
		return null;
	}

	private static uint EncodeZigZag32(int n)
	{
		return 0u;
	}

	private static ulong EncodeZigZag64(long n)
	{
		return 0uL;
	}

	private static int DecodeZigZag32(uint n)
	{
		return 0;
	}

	private static long DecodeZigZag64(ulong n)
	{
		return 0L;
	}

	private static uint ReadVarint32(object stream)
	{
		return 0u;
	}

	private static void WriteVarint32(object stream, uint value)
	{
	}

	private static ulong ReadVarint64(object stream)
	{
		return 0uL;
	}

	private static void WriteVarint64(object stream, ulong value)
	{
	}

	public static void WritePrimitive(Stream stream, bool value)
	{
	}

	public static void ReadPrimitive(Stream stream, out bool value)
	{
	}

	public static void WritePrimitive(Stream stream, byte value)
	{
	}

	public static void ReadPrimitive(Stream stream, out byte value)
	{
	}

	public static void WritePrimitive(Stream stream, sbyte value)
	{
	}

	public static void ReadPrimitive(Stream stream, out sbyte value)
	{
	}

	public static void WritePrimitive(Stream stream, char value)
	{
	}

	public static void ReadPrimitive(Stream stream, out char value)
	{
	}

	public static void WritePrimitive(Stream stream, ushort value)
	{
	}

	public static void ReadPrimitive(Stream stream, out ushort value)
	{
	}

	public static void WritePrimitive(Stream stream, short value)
	{
	}

	public static void ReadPrimitive(Stream stream, out short value)
	{
	}

	public static void WritePrimitive(Stream stream, uint value)
	{
	}

	public static void ReadPrimitive(Stream stream, out uint value)
	{
	}

	public static void WritePrimitive(Stream stream, int value)
	{
	}

	public static void ReadPrimitive(Stream stream, out int value)
	{
	}

	public static void WritePrimitive(Stream stream, ulong value)
	{
	}

	public static void ReadPrimitive(Stream stream, out ulong value)
	{
	}

	public static void WritePrimitive(Stream stream, long value)
	{
	}

	public static void ReadPrimitive(Stream stream, out long value)
	{
	}

	public static void WritePrimitive(Stream stream, float value)
	{
	}

	public static void ReadPrimitive(Stream stream, out float value)
	{
	}

	public static void WritePrimitive(Stream stream, double value)
	{
	}

	public static void ReadPrimitive(Stream stream, out double value)
	{
	}

	public static void WritePrimitive(Stream stream, DateTime value)
	{
	}

	public static void ReadPrimitive(Stream stream, out DateTime value)
	{
	}

	public static void WritePrimitive(Stream stream, string value)
	{
	}

	public static void ReadPrimitive(Stream stream, out string value)
	{
	}

	public static void WritePrimitive(Stream stream, byte[] value)
	{
	}

	public static void ReadPrimitive(Stream stream, out byte[] value)
	{
	}

	static Primitives()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		FAN44VtZOcEIrgNoMBg();
		Ee8FFutlxsrAlQHHph4();
		HMMUvRt9baQ3mg0nXBT();
		s_emptyByteArray = new byte[0];
	}

	internal static RuntimeTypeHandle ANPC0mtkIKxX2pIEip4(int token)
	{
		return (RuntimeTypeHandle)(object)null;
	}

	internal static Type Dio0YMts4lKw5H23BYp(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return null;
	}

	internal static object xtqvjRtuII9ubiOdtU8(int int_0)
	{
		return null;
	}

	internal static bool pVeLrDtYXxMFMmpotkA()
	{
		return true;
	}

	internal static Primitives hxGi4Bt6XHlk8B91eA6()
	{
		return null;
	}

	internal static int YHNFWNtAwqAL4JrOW7t(object object_0)
	{
		return 0;
	}

	internal static void kEL52FtQ5kr8YxmCY2p(object object_0, byte byte_0)
	{
	}

	internal static void JwpB8ltT5YxTx8vk6oi(object object_0, uint value)
	{
	}

	internal static uint VO6uRxtigHhCWfMYWyL(object object_0)
	{
		return 0u;
	}

	internal static int VOQOvHt8mTxi1uSmoRY(uint n)
	{
		return 0;
	}

	internal static void KtbKJntrhHKWekqxYYQ(object object_0, ulong value)
	{
	}

	internal static ulong E4Llfmthr8V18raJ9KB(object object_0)
	{
		return 0uL;
	}

	internal static long TSunUytR2WYBEB1TKNG(ulong n)
	{
		return 0L;
	}

	internal static int LB95VGtpKJthIJAaRQl(object object_0)
	{
		return 0;
	}

	internal static void IRktWotcrgdR1QOPvoT(object object_0, uint value)
	{
	}

	internal static object JvTmFZtBldlkLF0gGcS(object object_0)
	{
		return null;
	}

	internal static object wVyg1ctfkpVF370TCcD(object object_0)
	{
		return null;
	}

	internal static int kcJ3q9tGM0R4ABGkrVU()
	{
		return 0;
	}

	internal static void RdnVKht54DaPXIP66Xb(object object_0, object object_1, int int_0, int int_1)
	{
	}

	internal static object j52XqbtJqDktN8ZFDp9(object object_0)
	{
		return null;
	}

	internal static int rFpXY6tWrdtq2fcC4jM(int int_0, int int_1)
	{
		return 0;
	}

	internal static int oyf2c1tHAaEirHWoJ8k(object object_0, object object_1, int int_0, int int_1)
	{
		return 0;
	}

	internal static void FAN44VtZOcEIrgNoMBg()
	{
	}

	internal static void Ee8FFutlxsrAlQHHph4()
	{
	}

	internal static void HMMUvRt9baQ3mg0nXBT()
	{
	}
}
