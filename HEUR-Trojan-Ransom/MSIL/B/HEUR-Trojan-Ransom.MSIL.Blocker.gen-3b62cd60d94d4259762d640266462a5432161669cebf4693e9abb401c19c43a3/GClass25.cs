using System;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;

public class GClass25 : GClass24
{
	[CompilerGenerated]
	private sealed class Class11
	{
		public GClass25 gclass25_0;

		public string string_0;

		public int int_0;

		public extern Class11();

		internal extern void method_0();
	}

	private readonly ManualResetEvent manualResetEvent_0;

	private readonly GClass30<byte[]> gclass30_0;

	private volatile bool bool_1;

	public TcpClient tcpClient_0;

	private Thread thread_0;

	private Thread thread_1;

	public extern bool Boolean_0 { get; }

	public extern bool Boolean_1 { get; }

	private unsafe void method_1(string string_0, int int_3)
	{
		//Discarded unreachable code: IL_0010, IL_001e
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected I8, but got Unknown
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			((int[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (int)/*Error near IL_0001: Stack underflow*/;
			int num = checked((int)/*Error near IL_0005: Stack underflow*/);
			_003F val = /*Error near IL_0006: Stack underflow*/% num;
			((long[])/*Error near IL_0007: Stack underflow*/)[/*Error near IL_0007: Stack underflow*/] = (long)val;
			*(_003F*)(nint)/*Error near IL_0008: Stack underflow*/ = /*Error near IL_0008: Stack underflow*/;
			_ = /*Error near IL_0009: Stack underflow*/- /*Error near IL_0009: Stack underflow*/;
			/*Error near IL_0009: stloc 0 (out-of-bounds)*/;
		}
	}

	public extern void method_2(string string_0, int int_3);

	public extern void method_3();

	public extern bool method_4(byte[] byte_0);

	public extern GClass25();

	[CompilerGenerated]
	private extern void method_5();

	static extern Socket smethod_13(TcpClient tcpClient_1);

	static extern bool smethod_14(Socket socket_0);

	static extern void smethod_15(TcpClient tcpClient_1, string string_0, int int_3);

	unsafe static Thread smethod_16(ThreadStart threadStart_0)
	{
		//Discarded unreachable code: IL_0019, IL_001f, IL_002b, IL_0031, IL_0047
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected I, but got Unknown
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected I4, but got Unknown
		//IL_0026: Invalid comparison between Unknown and I4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Incompatible stack heights: 0 vs 1
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		do
		{
			((double[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = (double)/*Error near IL_0002: Stack underflow*/;
			*(_003F*)(nint)/*Error near IL_0003: Stack underflow*/ = /*Error near IL_0003: Stack underflow*/;
			byte num = ((byte[])/*Error near IL_0004: Stack underflow*/)[/*Error near IL_0004: Stack underflow*/];
			*(short*)(nint)/*Error near IL_0005: Stack underflow*/ = num;
			int num2 = checked((int)/*Error near IL_0006: Stack underflow*/);
			_003F val = /*Error near IL_0007: Stack underflow*/+ num2;
			((IntPtr[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = (IntPtr)val;
		}
		while (/*Error near IL_0009: Stack underflow*/ % /*Error near IL_0009: Stack underflow*/>= /*Error near IL_0009: ldarg 3 (out-of-bounds)*/|| /*Error near IL_0014: Stack underflow*/>= /*Error near IL_0014: Stack underflow*/);
		/*Error near IL_0014: Invalid metadata token*/;
	}

	static extern void smethod_17(Thread thread_2, bool bool_2);

	static extern void smethod_18(Thread thread_2);

	static extern string smethod_19(object[] object_0);

	static extern string smethod_20(object object_0, object object_1);

	static extern void smethod_21(Thread thread_2);

	static void smethod_22(TcpClient tcpClient_1)
	{
		//Discarded unreachable code: IL_0008, IL_000e, IL_0014
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Invalid comparison between Unknown and I4
		while (true)
		{
			/*Error: stloc 1 (out-of-bounds)*/;
			((long[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = (long)/*Error near IL_0002: Stack underflow*/;
		}
	}

	static extern TcpClient smethod_23();

	static extern void smethod_24(TcpClient tcpClient_1, bool bool_2);

	static extern void smethod_25(TcpClient tcpClient_1, int int_3);

	static extern void smethod_26(Thread thread_2);

	static extern bool smethod_27(EventWaitHandle eventWaitHandle_0);

	static extern ManualResetEvent smethod_28(bool bool_2);
}
