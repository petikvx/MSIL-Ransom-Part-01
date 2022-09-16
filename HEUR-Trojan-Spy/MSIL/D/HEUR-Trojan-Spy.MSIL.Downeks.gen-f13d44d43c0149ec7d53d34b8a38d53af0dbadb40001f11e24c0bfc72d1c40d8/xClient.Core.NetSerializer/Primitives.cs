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

		internal static object xbhyxZEMWimpdtoAWgo;

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
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}

		internal static void jKypBdETmF85iDg9Y1X()
		{
		}

		internal static bool XETtAUEtFPhVtNVbhHT()
		{
			return true;
		}

		internal static StringHelper w9StPxEUYsIQ5e7db0D()
		{
			return null;
		}

		internal static object nIBx4JEPlkYkRfxMbgK(object object_0)
		{
			return null;
		}
	}

	[ThreadStatic]
	private static StringHelper s_stringHelper;

	private static readonly byte[] s_emptyByteArray;

	internal static Primitives tGIQx7EkkAE2sBUw9Nv;

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
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		P3EJj6EHptUP634q9Uo();
		AQBDs0EVVqYm1JrvTYx();
		s_emptyByteArray = new byte[0];
	}

	internal static RuntimeTypeHandle j74xRxEcKpDF7lKTCV4(int token)
	{
		return (RuntimeTypeHandle)(object)null;
	}

	internal static Type L2W7y3EYbm8nQwWVqTB(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return null;
	}

	internal static object gddGuvER9JUkYWUTXD2(int int_0)
	{
		return null;
	}

	internal static bool TBinXHEfGClxI4c2AMM()
	{
		return true;
	}

	internal static Primitives RXTU07ES3twAcmHQGf0()
	{
		return null;
	}

	internal static int n7OiDHEawQUEDyfEuO3(object object_0)
	{
		return 0;
	}

	internal static void tQODt1ExPXjqqXy2Npk(object object_0, byte byte_0)
	{
	}

	internal static void yoFeVXEL7QjZiCF2tQq(object object_0, uint value)
	{
	}

	internal static uint lD6mTVEJBJeYZtNpQ09(object object_0)
	{
		return 0u;
	}

	internal static uint BtyoatEp8I0g43rHUo9(int n)
	{
		return 0u;
	}

	internal static int MAkaaHEmOtB1nwVJYL1(uint n)
	{
		return 0;
	}

	internal static ulong QWUH4IE806OtZpoM4XR(object object_0)
	{
		return 0uL;
	}

	internal static long yPh5NXEr1e6TgnHyshc(ulong n)
	{
		return 0L;
	}

	internal static void gSo5O7EEQASidNW2naG(object object_0, ulong value)
	{
	}

	internal static void MbU1AeEOPPr7pAC1l9V(object object_0, long value)
	{
	}

	internal static void jQn8bmEiAroBC60JV4I(object object_0, uint value)
	{
	}

	internal static int DCt1hRE9kkbI6Tf5VKF(object object_0)
	{
		return 0;
	}

	internal static object VaxcJyE5UfuQFaka57Q(object object_0)
	{
		return null;
	}

	internal static object rfegUEE4AvHfZa3xeas(object object_0)
	{
		return null;
	}

	internal static int Rw9wWEEhrUpPVQIQpXL(object object_0, object object_1, int int_0, bool bool_0)
	{
		return 0;
	}

	internal static object xgTm2KEwI2fE5MJy6oT(object object_0)
	{
		return null;
	}

	internal static object mjKOtPEyrFAauBhRyS0(object object_0)
	{
		return null;
	}

	internal static int EcbITlElujwB3bZE0PR(object object_0, object object_1, int int_0, int int_1)
	{
		return 0;
	}

	internal static void P3EJj6EHptUP634q9Uo()
	{
	}

	internal static void AQBDs0EVVqYm1JrvTYx()
	{
	}
}
