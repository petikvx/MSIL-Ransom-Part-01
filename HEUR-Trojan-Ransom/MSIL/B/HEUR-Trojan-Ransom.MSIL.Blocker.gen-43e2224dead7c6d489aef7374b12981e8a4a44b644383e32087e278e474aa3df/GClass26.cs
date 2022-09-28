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

		internal void method_0()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0003: Invalid comparison between Unknown and I
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			nint num;
			do
			{
				num = checked((nint)(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
			}
			while ((nint)/*Error near IL_0008: Stack underflow*/ < num);
			_003F val = /*Error near IL_0009: ldloc 2 (out-of-bounds)*/;
			_ = /*Error near IL_000c: Stack underflow*// val;
			_ = -116;
			/*Error: Unexpected end of block*/;
		}

		internal void method_1()
		{
			//Discarded unreachable code: IL_0009
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0003: Expected F8, but got Unknown
			do
			{
				_003F val = checked(/*Error near IL_0002: Stack underflow*/ * /*Error near IL_0002: Stack underflow*/);
				((double[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = (double)val;
			}
			while (/*Error near IL_0008: Stack underflow*/ <= /*Error near IL_0008: Stack underflow*/);
			/*Error near IL_0008: Unknown opcode: 0xFB*/;
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

	public static int smethod_13()
	{
		/*Error: Unknown opcode: 0xF8*/;
	}

	private extern void method_1(int int_4);

	public extern bool method_2(int int_4);

	public void method_3()
	{
		//Discarded unreachable code: IL_0005, IL_000e, IL_0014, IL_0019
		/*Error: Invalid metadata token*/;
	}

	public extern bool method_4(int int_4, byte[] byte_0);

	public extern string method_5(int int_4);

	public bool method_6(int int_4)
	{
		//Discarded unreachable code: IL_0010, IL_0016, IL_001a, IL_001f
		while (/*Error near IL_0005: Stack underflow*/ == /*Error near IL_0005: Stack underflow*/|| /*Error near IL_000a: Stack underflow*/!= /*Error near IL_000a: Stack underflow*/)
		{
		}
		_ = (sbyte)/*Error near IL_000b: Stack underflow*/;
		/*Error near IL_000b: Invalid metadata token*/;
	}

	public extern GClass26();

	static extern bool smethod_14(Thread thread_1);

	static extern int smethod_15(ref int int_4);

	static extern string smethod_16(object object_0, object object_1);

	unsafe static Exception smethod_17(string string_0)
	{
		//Discarded unreachable code: IL_0024, IL_002a, IL_0030
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected I8, but got I4
		//IL_0011: Expected I4, but got F8
		//IL_0013: Invalid comparison between Unknown and I4
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			uint num = ((uint[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/];
			ushort num2 = checked((ushort)(/*Error near IL_0005: Stack underflow*/ + num));
			*(long*)(nint)/*Error near IL_0009: Stack underflow*/ = (int)num2;
			if (/*Error near IL_000e: Stack underflow*/ >= /*Error near IL_000e: Stack underflow*/)
			{
				double num3 = ((double[])/*Error near IL_0010: Stack underflow*/)[/*Error near IL_0010: Stack underflow*/];
				((short[])/*Error near IL_0011: Stack underflow*/)[/*Error near IL_0011: Stack underflow*/] = (short)(int)num3;
				int num4;
				checked
				{
					num4 = (int)(*unchecked((double*)(nint)/*Error near IL_0012: Stack underflow*/));
				}
				if ((int)/*Error near IL_0018: Stack underflow*/ <= num4 && /*Error near IL_001d: Stack underflow*/>= /*Error near IL_001d: Stack underflow*/)
				{
					break;
				}
			}
		}
		*(_003F*)(nint)/*Error near IL_001e: Stack underflow*/ = /*Error near IL_001e: Stack underflow*/;
		/*Error near IL_001f: Invalid metadata token*/;
	}

	static IPEndPoint smethod_18(IPAddress ipaddress_0, int int_4)
	{
		//Discarded unreachable code: IL_0006, IL_0010, IL_0015, IL_001b
		//IL_000b: Invalid comparison between Unknown and I4
		/*Error near IL_0001: Invalid metadata token*/;
	}

	unsafe static TcpListener smethod_19(IPEndPoint ipendPoint_0)
	{
		//IL_0001: Invalid comparison between Unknown and I
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between Unknown and I4
		while (true)
		{
			nint num = checked((nint)/*Error near IL_0001: Stack underflow*/);
			if ((nint)/*Error near IL_0006: Stack underflow*/ > num)
			{
				long num2 = *(long*)(nint)/*Error near IL_0006: ldloc 0 (out-of-bounds)*/;
				_003F val = /*Error near IL_0009: Stack underflow*// num2;
				int num3 = ((int[])/*Error near IL_000a: Stack underflow*/)[val];
				if ((int)/*Error near IL_000f: Stack underflow*/ >= num3)
				{
					break;
				}
			}
		}
		/*Error near IL_000f: Invalid metadata token*/;
	}

	static extern Socket smethod_20(TcpListener tcpListener_1);

	static extern void smethod_21(Socket socket_0, bool bool_1);

	static extern void smethod_22(Socket socket_0, int int_4);

	static extern void smethod_23(TcpListener tcpListener_1);

	unsafe static TcpClient smethod_24(TcpListener tcpListener_1)
	{
		//Discarded unreachable code: IL_0013, IL_0018
		IntPtr intPtr = (nint)((Array)/*Error near IL_0001: Stack underflow*/).LongLength;
		*(IntPtr*)(nint)/*Error near IL_0004: Stack underflow*/ = (nint)(short)(nint)intPtr;
		_ = 3.3361041384776725E+127;
		/*Error near IL_000e: Invalid metadata token*/;
	}

	static extern Thread smethod_25(ThreadStart threadStart_0);

	static extern void smethod_26(Thread thread_1, bool bool_1);

	static extern void smethod_27(Thread thread_1);

	static extern void smethod_28(Thread thread_1, ThreadPriority threadPriority_0);

	static extern void smethod_29(TcpListener tcpListener_1);

	unsafe static void smethod_30(Thread thread_1)
	{
		//Discarded unreachable code: IL_000b, IL_0012
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		while ((int)/*Error near IL_0005: Stack underflow*/ == 0)
		{
		}
		*(_003F*)(nint)/*Error near IL_0006: Stack underflow*/ = /*Error near IL_0006: Stack underflow*/;
		/*Error near IL_0006: Invalid metadata token*/;
	}

	static NetworkStream smethod_31(TcpClient tcpClient_0)
	{
		//Discarded unreachable code: IL_0013
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Invalid comparison between Unknown and I8
		//IL_0009: Invalid comparison between Unknown and I4
		while (true)
		{
			_003F val = /*Error near IL_0002: Stack underflow*// -1;
			long num = ((long[])/*Error near IL_0003: Stack underflow*/)[val];
			if ((long)/*Error near IL_0008: Stack underflow*/ < num)
			{
				sbyte num2 = (sbyte)/*Error near IL_0009: Stack underflow*/;
				if ((int)/*Error near IL_000e: Stack underflow*/ >= (int)num2)
				{
					break;
				}
			}
		}
		/*Error near IL_000e: Invalid metadata token*/;
	}

	static extern void smethod_32(Stream stream_0);

	static extern void smethod_33(TcpClient tcpClient_0);

	static extern bool smethod_34(IEnumerator ienumerator_0);

	static extern void smethod_35(IDisposable idisposable_0);

	static extern bool smethod_36(EventWaitHandle eventWaitHandle_0);

	static string smethod_37(object[] object_0)
	{
		//IL_000b: Invalid comparison between F8 and Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		while (/*Error near IL_0005: Stack underflow*/ > /*Error near IL_0005: Stack underflow*/|| (double)(int)checked((byte)/*Error near IL_0008: Stack underflow*/) >= (double)/*Error near IL_0009: ldloca 0 (out-of-bounds)*/)
		{
		}
		checked
		{
			_ = /*Error near IL_0013: Stack underflow*/* /*Error near IL_0013: Stack underflow*/;
			_ = 0;
			/*Error near IL_0015: Invalid metadata token*/;
		}
	}

	static extern Socket smethod_38(TcpClient tcpClient_0);

	static EndPoint smethod_39(Socket socket_0)
	{
		//Discarded unreachable code: IL_0002
		/*Error near IL_0001: Unknown opcode: 0xFB*/;
	}

	static IPAddress smethod_40(IPEndPoint ipendPoint_0)
	{
		//Discarded unreachable code: IL_0008
		_ = ref ipendPoint_0;
		/*Error near IL_0003: Invalid metadata token*/;
	}

	static extern string smethod_41(object object_0);
}
