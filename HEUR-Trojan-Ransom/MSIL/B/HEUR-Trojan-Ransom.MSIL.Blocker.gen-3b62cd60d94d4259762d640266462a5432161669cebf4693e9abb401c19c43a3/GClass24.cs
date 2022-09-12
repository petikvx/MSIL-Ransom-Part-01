using System;
using System.Collections.Concurrent;
using System.IO;
using System.Net.Sockets;
using System.Threading;

public abstract class GClass24
{
	public static int int_0;

	public int int_1;

	public bool bool_0;

	protected ConcurrentQueue<GClass28> concurrentQueue_0;

	public int int_2;

	public extern int Int32_0 { get; }

	public extern bool method_0(out GClass28 gclass28_0);

	protected static extern bool smethod_0(NetworkStream networkStream_0, byte[][] byte_0);

	protected static bool smethod_1(NetworkStream networkStream_0, int int_3, out byte[] byte_0)
	{
		//Discarded unreachable code: IL_0005, IL_0013
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Invalid comparison between Unknown and I4
		/*Error: Invalid metadata token*/;
	}

	protected static extern void smethod_2(int int_3, TcpClient tcpClient_0, ConcurrentQueue<GClass28> concurrentQueue_1, int int_4);

	protected static extern void smethod_3(int int_3, TcpClient tcpClient_0, GClass30<byte[]> gclass30_0, ManualResetEvent manualResetEvent_0);

	protected unsafe GClass24()
	{
		//IL_000d: Invalid comparison between Unknown and I4
		while (true)
		{
			((object[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = (object)/*Error near IL_0003: Stack underflow*/;
			if ((nint)(&this) > (nint)3)
			{
				byte num = ((byte[])/*Error near IL_000c: Stack underflow*/)[/*Error near IL_000c: Stack underflow*/];
				if ((int)/*Error near IL_0012: Stack underflow*/ == num && (int)/*Error near IL_0017: Stack underflow*/ != 0)
				{
					/*Error: Could not find block for branch target IL_0017*/;
				}
			}
		}
	}

	static extern void smethod_4(Array array_0, int int_3, Array array_1, int int_4, int int_5);

	static extern void smethod_5(Stream stream_0, byte[] byte_0, int int_3, int int_4);

	static extern string smethod_6(object object_0, object object_1);

	static extern string smethod_7(object object_0, object object_1, object object_2);

	static extern NetworkStream smethod_8(TcpClient tcpClient_0);

	static bool smethod_9(EventWaitHandle eventWaitHandle_0)
	{
		/*Error: ldloc 1 (out-of-bounds)*/;
		_ = 8;
		switch (8)
		{
		default:
			;
			break;
		}
		/*Error: Unexpected end of block*/;
	}

	static extern bool smethod_10(WaitHandle waitHandle_0);

	unsafe static bool smethod_11(TcpClient tcpClient_0)
	{
		_ = *(short*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error: Unexpected end of block*/;
	}

	static extern string smethod_12(object[] object_0);
}
