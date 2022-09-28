using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

public class GClass17 : IDisposable
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Stream stream_0;

	public extern Stream Stream_0
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern int Int32_0 { get; }

	public extern GClass17();

	public extern GClass17(Stream stream_1);

	public extern void Dispose();

	public extern void method_0(byte[] byte_0);

	public extern void method_1(byte[] byte_0, int int_0, int int_1);

	public extern void method_2(int int_0);

	public unsafe void method_3(int int_0)
	{
		//IL_0005: Invalid comparison between Unknown and I4
		do
		{
			*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		}
		while ((int)/*Error near IL_000a: Stack underflow*/ <= 1);
		switch (/*Error near IL_000f: Stack underflow*/)
		{
		default:
			;
			break;
		}
		/*Error: Unexpected end of block*/;
	}

	public extern void method_4(uint uint_0);

	public extern void method_5(short short_0);

	public extern void method_6(ushort ushort_0);

	public extern void method_7(ulong ulong_0);

	public extern void method_8(byte byte_0);

	public extern void method_9(bool bool_0);

	public extern void method_10(double double_0);

	public unsafe void method_11(long long_0)
	{
		//Discarded unreachable code: IL_0008, IL_0010, IL_0018, IL_001e, IL_0024
		//IL_0002: Expected O, but got I
		//IL_0013: Invalid comparison between Unknown and I4
		nint num = checked((nint)/*Error near IL_0001: Stack underflow*/);
		*(object*)(nint)/*Error near IL_0002: Stack underflow*/ = num;
		/*Error near IL_0003: Invalid metadata token*/;
	}

	public extern void method_12(float float_0);

	public extern void method_13(decimal decimal_0);

	public void method_14(string string_0)
	{
		/*Error: Unexpected end of block*/;
	}

	static extern MemoryStream smethod_0();

	static extern long smethod_1(Stream stream_1);

	static extern void smethod_2(Stream stream_1);

	static extern void smethod_3(Stream stream_1);

	static extern void smethod_4(Stream stream_1, byte[] byte_0, int int_0, int int_1);

	static extern byte[] smethod_5(int int_0);

	static extern byte[] smethod_6(uint uint_0);

	static byte[] smethod_7(short short_0)
	{
		//Discarded unreachable code: IL_0007
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected I, but got Unknown
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (short)/*Error: Stack underflow*/;
			/*Error near IL_0006: Unknown opcode: 0xFD*/;
		}
	}

	static extern byte[] smethod_8(ushort ushort_0);

	static extern byte[] smethod_9(ulong ulong_0);

	static extern void smethod_10(Stream stream_1, byte byte_0);

	static extern byte[] smethod_11(double double_0);

	static byte[] smethod_12(long long_0)
	{
		//Discarded unreachable code: IL_000e
		//IL_0004: Invalid comparison between Unknown and I8
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		long num;
		do
		{
			num = checked((long)((object[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/]);
		}
		while ((long)/*Error near IL_0009: Stack underflow*/ < num);
		/*Error near IL_0009: Invalid metadata token*/;
	}

	static extern byte[] smethod_13(float float_0);

	static extern BinaryWriter smethod_14(Stream stream_1);

	static extern void smethod_15(BinaryWriter binaryWriter_0, decimal decimal_0);

	static extern Encoding smethod_16();

	static byte[] smethod_17(Encoding encoding_0, string string_0)
	{
		//Discarded unreachable code: IL_0006, IL_000b, IL_0016, IL_001d, IL_0023
		_ = -746779255;
		/*Error near IL_0005: Unknown opcode: 0xFA*/;
	}

	static NullReferenceException smethod_18(string string_0)
	{
		//Discarded unreachable code: IL_0013, IL_0024
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between O and Unknown
		//IL_0014: Expected native int or pointer, but got F4
		//IL_0019: Expected I, but got O
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Invalid comparison between Unknown and I4
		while (true)
		{
			if ((int)/*Error near IL_0005: Stack underflow*/ == 0)
			{
				_003F val = checked(/*Error near IL_0007: Stack underflow*/ + /*Error near IL_0007: Stack underflow*/);
				if (((object[])/*Error near IL_0008: Stack underflow*/)[val] <= /*Error near IL_0008: ldloc 1 (out-of-bounds)*/)
				{
					break;
				}
			}
		}
		/*Error near IL_000e: Invalid metadata token*/;
	}
}
