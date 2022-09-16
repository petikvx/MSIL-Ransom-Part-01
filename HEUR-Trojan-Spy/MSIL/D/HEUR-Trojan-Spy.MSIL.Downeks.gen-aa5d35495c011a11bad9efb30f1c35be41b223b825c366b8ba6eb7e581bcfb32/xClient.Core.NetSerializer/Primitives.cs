using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace xClient.Core.NetSerializer;

public static class Primitives
{
	private sealed class StringHelper
	{
		private object m_encoder;

		private object m_decoder;

		private object m_byteBuffer;

		private object m_charBuffer;

		internal static object zC13ONfxFxDGgZcYJq4;

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

		internal static void h7dH8LfvXfU9DwwxMxf()
		{
		}

		internal static void ElsdrOfPaan6gT6mAo3()
		{
		}

		internal static bool soQODofcgRcJxAmxYen()
		{
			return true;
		}

		internal static StringHelper lYEZsmfHWvmXyrLOHgk()
		{
			return null;
		}

		internal static object Gm96C1f1xNrDXhpn7gU(object object_0)
		{
			return null;
		}
	}

	[ThreadStatic]
	private static StringHelper s_stringHelper;

	private static readonly byte[] s_emptyByteArray;

	internal static Primitives zdadh9ouUU3wdxnwbaJ;

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
		fX9KgZozjsnb1DnVIrU();
		xQPbwfftLSIK39CBSSc();
		hHEYokUTtehNq5ji0d.VK2rIWXzS3sMN();
		s_emptyByteArray = new byte[0];
	}

	internal static object jDKd35omOeJFT6PmmtR(int int_0)
	{
		return null;
	}

	internal static Type Gd6hZWoJ5fddME5MhpW(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return null;
	}

	internal static bool MRadwNoW1IcwgoEfHfK()
	{
		return true;
	}

	internal static Primitives hsl1C9o6XCCrXa1DmIx()
	{
		return null;
	}

	internal static RuntimeTypeHandle rS8KshoqtTULXfHjb1I(int token)
	{
		return (RuntimeTypeHandle)(object)null;
	}

	internal static int V4sXcDoNSpO7yY87IV7(object object_0)
	{
		return 0;
	}

	internal static void upbC6SoZ0ptyK8FLsow(object object_0, byte byte_0)
	{
	}

	internal static void dlf2hbo3b5oVnKm0njK(object object_0, uint value)
	{
	}

	internal static uint JPUt0norZV4WuSMJDpA(object object_0)
	{
		return 0u;
	}

	internal static uint da65vRoeNTJiYE4y26M(int n)
	{
		return 0u;
	}

	internal static void JinaLDoOOpB3YaqZsNG(object object_0, ulong value)
	{
	}

	internal static ulong MoX2bro0dbBK2YEwByA(object object_0)
	{
		return 0uL;
	}

	internal static ulong DE0CKaodqa0q8s8UF4p(long n)
	{
		return 0uL;
	}

	internal static long gMNVARoEVbtZFoqv87J(ulong n)
	{
		return 0L;
	}

	internal static void edL6TcohUIWsR8rTdcF(object object_0, long value)
	{
	}

	internal static void UpsRbkoMoY8D8N055ts(object object_0, uint value)
	{
	}

	internal static int BODM3WoCC1BwQ2DZHS9(object object_0)
	{
		return 0;
	}

	internal static object bU6WiZoQcSl3u5RLIyg(object object_0)
	{
		return null;
	}

	internal static int JWdL6SoAUZmOuAqJ7PM()
	{
		return 0;
	}

	internal static object Xc6IPVoyWYqehMeEqU5(object object_0)
	{
		return null;
	}

	internal static object xgXacXoD2cfcLbAiXO1(object object_0)
	{
		return null;
	}

	internal static int HqlAGTo8qw6US3AQjXP(int int_0, int int_1)
	{
		return 0;
	}

	internal static int vtevxjo9PaKYl94FQLO(object object_0, object object_1, int int_0, int int_1)
	{
		return 0;
	}

	internal static void Yjj7XQoXBlpKGviQrZl(object object_0, object object_1, int int_0, int int_1)
	{
	}

	internal static void fX9KgZozjsnb1DnVIrU()
	{
	}

	internal static void xQPbwfftLSIK39CBSSc()
	{
	}
}
