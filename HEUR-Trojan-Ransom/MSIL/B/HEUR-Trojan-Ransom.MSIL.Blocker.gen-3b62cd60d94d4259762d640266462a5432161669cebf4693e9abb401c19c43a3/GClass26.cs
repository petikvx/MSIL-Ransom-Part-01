using System;
using System.Collections;
using System.Collections.Concurrent;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;

public class GClass26 : GClass24
{
	private class Class12
	{
		public readonly TcpClient tcpClient_0;

		public readonly ManualResetEvent manualResetEvent_0;

		public readonly GClass30<byte[]> gclass30_0;

		public extern Class12(TcpClient tcpClient_1);

		static extern ManualResetEvent smethod_0(bool bool_0);
	}

	[CompilerGenerated]
	private sealed class Class13
	{
		public int int_0;

		public TcpClient tcpClient_0;

		public Class12 class12_0;

		public Thread thread_0;

		public GClass26 gclass26_0;

		public extern Class13();

		internal extern void method_0();

		internal unsafe void method_1()
		{
			//IL_000d: Incompatible stack heights: 0 vs 1
			checked
			{
				while (true)
				{
					_ = (nint)(*unchecked((short*)(nint)/*Error near IL_0001: Stack underflow*/));
					if (unchecked((nuint)(-1.7661610359177974E+42)) != 0)
					{
						/*Error: Could not find block for branch target IL_0012*/;
					}
				}
			}
		}

		static extern string smethod_0(object object_0, object object_1);

		static extern void smethod_1(Thread thread_1);
	}

	[CompilerGenerated]
	private sealed class Class14
	{
		public GClass26 gclass26_0;

		public int int_0;

		public extern Class14();

		internal extern void method_0();
	}

	private static int int_3;

	private readonly ConcurrentDictionary<int, Class12> concurrentDictionary_0;

	public TcpListener tcpListener_0;

	private Thread thread_0;

	public extern bool Boolean_0 { get; }

	public static extern int smethod_13();

	private extern void method_1(int int_4);

	public extern bool method_2(int int_4);

	public extern void method_3();

	public extern bool method_4(int int_4, byte[] byte_0);

	public extern string method_5(int int_4);

	public unsafe bool method_6(int int_4)
	{
		//Discarded unreachable code: IL_0010, IL_0015, IL_001d, IL_0022, IL_0027, IL_0032, IL_0037, IL_003d
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Expected I4, but got I8
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		do
		{
			sbyte num = *(sbyte*)(nint)/*Error near IL_0002: Stack underflow*/;
			long num2 = *(long*)(nint)(/*Error near IL_0003: Stack underflow*/ >> (int)num);
			((sbyte[])/*Error near IL_0005: Stack underflow*/)[/*Error near IL_0005: Stack underflow*/] = (sbyte)num2;
		}
		while ((int)/*Error near IL_000b: Stack underflow*/ != 0);
		/*Error near IL_000b: Invalid metadata token*/;
	}

	public unsafe GClass26()
	{
		//Discarded unreachable code: IL_000c
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected I8, but got Unknown
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		_003F val = checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		*(long*)(nint)/*Error near IL_0002: Stack underflow*/ = (long)val;
		_003F val2 = /*Error near IL_0003: Stack underflow*/* /*Error near IL_0003: Stack underflow*/;
		int num = /*Error near IL_0004: Stack underflow*/% val2;
		checked
		{
			_ = /*Error near IL_0007: Stack underflow*/* num;
			/*Error near IL_0007: Invalid metadata token*/;
		}
	}

	static extern bool smethod_14(Thread thread_1);

	static extern int smethod_15(ref int int_4);

	static extern string smethod_16(object object_0, object object_1);

	static extern Exception smethod_17(string string_0);

	static extern IPEndPoint smethod_18(IPAddress ipaddress_0, int int_4);

	static extern TcpListener smethod_19(IPEndPoint ipendPoint_0);

	static Socket smethod_20(TcpListener tcpListener_1)
	{
		checked
		{
			_ = (ulong)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0002: stloc 3 (out-of-bounds)*/;
			/*Error near IL_0003: Invalid metadata token*/;
		}
	}

	static void smethod_21(Socket socket_0, bool bool_1)
	{
		/*Error: Invalid metadata token*/;
	}

	static extern void smethod_22(Socket socket_0, int int_4);

	static void smethod_23(TcpListener tcpListener_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		_003F val = /*Error near IL_0002: Stack underflow*/% /*Error near IL_0002: Stack underflow*/;
		_ = ((double[])/*Error near IL_0003: Stack underflow*/)[val];
		/*Error near IL_0003: Invalid metadata token*/;
	}

	unsafe static TcpClient smethod_24(TcpListener tcpListener_1)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			if (*(object*)(nint)/*Error near IL_0003: Stack underflow*/ != null)
			{
				_003F val = /*Error near IL_000a: Stack underflow*/| /*Error near IL_000a: Stack underflow*/;
				if (/*Error near IL_0011: Stack underflow*/ >= val)
				{
					break;
				}
			}
		}
		nuint num = (nuint)/*Error near IL_0012: Stack underflow*/;
		_003F val2 = /*Error near IL_0013: Stack underflow*// num;
		_003F val3 = checked(/*Error near IL_0015: Stack underflow*/ * (double)val2);
		ushort num2 = ((ushort[])/*Error near IL_0016: Stack underflow*/)[val3];
		_ = /*Error near IL_0018: Stack underflow*/<< (int)num2;
		/*Error: Unexpected end of block*/;
	}

	unsafe static Thread smethod_25(ThreadStart threadStart_0)
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

	static extern void smethod_26(Thread thread_1, bool bool_1);

	static extern void smethod_27(Thread thread_1);

	static extern void smethod_28(Thread thread_1, ThreadPriority threadPriority_0);

	static extern void smethod_29(TcpListener tcpListener_1);

	static extern void smethod_30(Thread thread_1);

	static extern NetworkStream smethod_31(TcpClient tcpClient_0);

	static extern void smethod_32(Stream stream_0);

	static void smethod_33(TcpClient tcpClient_0)
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

	static extern bool smethod_34(IEnumerator ienumerator_0);

	static extern void smethod_35(IDisposable idisposable_0);

	static extern bool smethod_36(EventWaitHandle eventWaitHandle_0);

	static extern string smethod_37(object[] object_0);

	static extern Socket smethod_38(TcpClient tcpClient_0);

	static extern EndPoint smethod_39(Socket socket_0);

	static IPAddress smethod_40(IPEndPoint ipendPoint_0)
	{
		//Discarded unreachable code: IL_0012, IL_0017
		checked
		{
			nint num = (nint)unchecked((ushort)((sbyte[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/]);
			_ = (ushort)unchecked((int)checked((ushort)((byte[])/*Error near IL_0006: Stack underflow*/)[num]));
			/*Error near IL_000c: ldarg 2 (out-of-bounds)*/;
			/*Error near IL_000d: Invalid metadata token*/;
		}
	}

	static extern string smethod_41(object object_0);
}
