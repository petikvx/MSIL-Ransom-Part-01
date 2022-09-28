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

	public void method_1(byte[] byte_0, int int_0, int int_1)
	{
		/*Error: Unexpected end of block*/;
	}

	public void method_2(int int_0)
	{
		//Discarded unreachable code: IL_0019, IL_0020
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Incompatible stack heights: 0 vs 2
		//IL_001b: Invalid comparison between Unknown and I4
		while (true)
		{
			ulong num = (ulong)/*Error near IL_0002: Stack underflow*/;
			_ = /*Error near IL_0003: Stack underflow*/* num;
			_ = 7;
			/*Error near IL_0007: stloc 2 (out-of-bounds)*/;
			_ = 6L;
		}
	}

	public extern void method_3(int int_0);

	public extern void method_4(uint uint_0);

	public unsafe void method_5(short short_0)
	{
		//Discarded unreachable code: IL_0011, IL_0019, IL_0024
		//IL_0014: Invalid comparison between Unknown and I4
		//IL_0014: Incompatible stack heights: 0 vs 1
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got I8
		do
		{
			_ = *(uint*)(nint)/*Error near IL_0004: Stack underflow*/;
			/*Error near IL_0004: stloc 0 (out-of-bounds)*/;
		}
		while (/*Error near IL_000a: Stack underflow*/ < /*Error near IL_000a: Stack underflow*/);
		*(_003F*)(nint)/*Error near IL_000b: Stack underflow*/ = /*Error near IL_000b: Stack underflow*/;
		_ = (nint)/*Error near IL_000c: Stack underflow*/;
		/*Error near IL_000c: Invalid metadata token*/;
	}

	public extern void method_6(ushort ushort_0);

	public extern void method_7(ulong ulong_0);

	public extern void method_8(byte byte_0);

	public extern void method_9(bool bool_0);

	public extern void method_10(double double_0);

	public extern void method_11(long long_0);

	public extern void method_12(float float_0);

	public extern void method_13(decimal decimal_0);

	public extern void method_14(string string_0);

	static extern MemoryStream smethod_0();

	static extern long smethod_1(Stream stream_1);

	static extern void smethod_2(Stream stream_1);

	static extern void smethod_3(Stream stream_1);

	static extern void smethod_4(Stream stream_1, byte[] byte_0, int int_0, int int_1);

	static extern byte[] smethod_5(int int_0);

	static extern byte[] smethod_6(uint uint_0);

	static extern byte[] smethod_7(short short_0);

	static extern byte[] smethod_8(ushort ushort_0);

	static extern byte[] smethod_9(ulong ulong_0);

	static void smethod_10(Stream stream_1, byte byte_0)
	{
		//Discarded unreachable code: IL_000d, IL_001e, IL_0023
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		sbyte num;
		do
		{
			num = checked((sbyte)(/*Error near IL_0001: Stack underflow*/ | /*Error near IL_0001: Stack underflow*/));
		}
		while ((int)/*Error near IL_0007: Stack underflow*/ >= (int)num);
		checked
		{
			_ = (ulong)/*Error near IL_0008: Stack underflow*/;
			/*Error near IL_0008: Invalid metadata token*/;
		}
	}

	static extern byte[] smethod_11(double double_0);

	static extern byte[] smethod_12(long long_0);

	static extern byte[] smethod_13(float float_0);

	static extern BinaryWriter smethod_14(Stream stream_1);

	static void smethod_15(BinaryWriter binaryWriter_0, decimal decimal_0)
	{
		//Discarded unreachable code: IL_0006, IL_000b, IL_000c, IL_0015, IL_001b, IL_0022
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		/*Error: ldloc 2 (out-of-bounds)*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern Encoding smethod_16();

	static byte[] smethod_17(Encoding encoding_0, string string_0)
	{
		//Discarded unreachable code: IL_0006, IL_001b, IL_0020
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Incompatible stack heights: 0 vs 1
		checked
		{
			_ = (int)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid metadata token*/;
		}
	}

	static extern NullReferenceException smethod_18(string string_0);
}
