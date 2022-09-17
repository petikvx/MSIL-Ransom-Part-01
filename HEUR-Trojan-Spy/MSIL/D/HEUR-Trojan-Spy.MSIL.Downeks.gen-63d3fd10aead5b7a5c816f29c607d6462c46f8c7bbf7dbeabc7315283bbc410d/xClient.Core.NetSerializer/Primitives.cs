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

		private static object bIWtyxmaCCN8WMvgaPe;

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
			QaEYeKmZCYfTEuLnSq1();
		}

		internal static void XMwdeLmEQ3nrSrl7fwd()
		{
		}

		internal static void pfamNimBkeBrNhWkPwl()
		{
		}

		internal static bool gUhiJWm4rArFHq3Y5O7()
		{
			return true;
		}

		internal static StringHelper pHTBammbxsO3WZinJDb()
		{
			return null;
		}

		internal static object jy7quWmTEP2U3VJ4UUW(object object_0)
		{
			return null;
		}

		internal static void QaEYeKmZCYfTEuLnSq1()
		{
		}
	}

	[ThreadStatic]
	private static StringHelper s_stringHelper;

	private static readonly byte[] s_emptyByteArray;

	internal static Primitives E3L16RUKIxsDwXbo4yi;

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
		vD1rpMmVcxb9FwbuPLc();
		cOg0IWm2klGF7kfDhTn();
		WWMIJCmx7pICstdtk2p();
		s_emptyByteArray = new byte[0];
	}

	internal static RuntimeTypeHandle HOwQLgU0MMTioh7HbKX(int token)
	{
		return (RuntimeTypeHandle)(object)null;
	}

	internal static Type db69FOUPOMOq7gEy21w(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return null;
	}

	internal static object CfkIZSURu4lVRcwgIfR(int int_0)
	{
		return null;
	}

	internal static bool GNR3BqUhm81F4beY65u()
	{
		return true;
	}

	internal static Primitives THFIHAUCqgpFUerx3a0()
	{
		return null;
	}

	internal static int MCRpNMU1OSUDkmDNbdf(object object_0)
	{
		return 0;
	}

	internal static void fjSCA2UtyPYLkTCocp2(object object_0, byte byte_0)
	{
	}

	internal static void w9pFDXUHL0qpeHRQ5cQ(object object_0, uint value)
	{
	}

	internal static uint zmBoPKUIsLja5CRWqhj(object object_0)
	{
		return 0u;
	}

	internal static int qcAsp7UyHxYd2EC2AHV(uint n)
	{
		return 0;
	}

	internal static uint nsr8kRUpKTVvofO4WeH(int n)
	{
		return 0u;
	}

	internal static void btlukZU9wHaLcVpoqbJ(object object_0, ulong value)
	{
	}

	internal static ulong P5nA8uUQdbcigYrX4vE(object object_0)
	{
		return 0uL;
	}

	internal static ulong FcMYr1UzrsAHuAR0wvH(long n)
	{
		return 0uL;
	}

	internal static long bMMnUFmlMbVOGDtWXvy(ulong n)
	{
		return 0L;
	}

	internal static void PJuuahmqD9NFlXhKqWg(object object_0, long value)
	{
	}

	internal static DateTime MRbhobm5xY2O1WMw7C9(long long_0)
	{
		return (DateTime)(object)null;
	}

	internal static void r1v6U0mAXPuWbgLUTTc(object object_0, uint value)
	{
	}

	internal static int Us05KcmM2VrdipRq4W4(object object_0)
	{
		return 0;
	}

	internal static object PVmYBAmXCqMZlJHEIaV(object object_0)
	{
		return null;
	}

	internal static object U9E4YYmiF7srfsFMAnK(object object_0)
	{
		return null;
	}

	internal static int zdQBXZmkVUiBvWysYiO()
	{
		return 0;
	}

	internal static int doM1XvmSwA3UDvsAZDg(object object_0, object object_1, int int_0, bool bool_0)
	{
		return 0;
	}

	internal static void OrLaTMmLKTPN2M6Oduk(object object_0, object object_1, int int_0, int int_1)
	{
	}

	internal static object RNK7WBmeGYICjisVcoZ(object object_0)
	{
		return null;
	}

	internal static object UVLYPomO80OJExm0YUN(object object_0)
	{
		return null;
	}

	internal static int CxMJQEmWI1xJOMfG0Nk(object object_0, object object_1, int int_0, int int_1)
	{
		return 0;
	}

	internal static void vD1rpMmVcxb9FwbuPLc()
	{
	}

	internal static void cOg0IWm2klGF7kfDhTn()
	{
	}

	internal static void WWMIJCmx7pICstdtk2p()
	{
	}
}
