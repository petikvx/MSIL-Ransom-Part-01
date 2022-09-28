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

	public unsafe bool method_0(out GClass28 gclass28_0)
	{
		//Discarded unreachable code: IL_0007, IL_000c, IL_0017
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		float num = *(float*)(nint)/*Error near IL_0001: Stack underflow*/;
		_ = /*Error near IL_0002: Stack underflow*/& num;
		/*Error near IL_0002: Invalid metadata token*/;
	}

	protected unsafe static bool smethod_0(NetworkStream networkStream_0, byte[][] byte_0)
	{
		//Discarded unreachable code: IL_000b, IL_0012, IL_0025
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected native int or pointer, but got F8
		//IL_0020: Expected F8, but got I4
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		ushort num;
		checked
		{
			num = (ushort)unchecked((sbyte)/*Error near IL_0002: Stack underflow*/);
		}
		_ = *(double*)(nint)(/*Error near IL_0004: Stack underflow*/ * num);
		/*Error near IL_0006: Invalid metadata token*/;
	}

	protected static extern bool smethod_1(NetworkStream networkStream_0, int int_3, out byte[] byte_0);

	protected static extern void smethod_2(int int_3, TcpClient tcpClient_0, ConcurrentQueue<GClass28> concurrentQueue_1, int int_4);

	protected static extern void smethod_3(int int_3, TcpClient tcpClient_0, GClass30<byte[]> gclass30_0, ManualResetEvent manualResetEvent_0);

	protected extern GClass24();

	static extern void smethod_4(Array array_0, int int_3, Array array_1, int int_4, int int_5);

	static extern void smethod_5(Stream stream_0, byte[] byte_0, int int_3, int int_4);

	static extern string smethod_6(object object_0, object object_1);

	static extern string smethod_7(object object_0, object object_1, object object_2);

	static extern NetworkStream smethod_8(TcpClient tcpClient_0);

	static extern bool smethod_9(EventWaitHandle eventWaitHandle_0);

	unsafe static bool smethod_10(WaitHandle waitHandle_0)
	{
		//Discarded unreachable code: IL_0009
		_ = *(*(short**)(sbyte)/*Error: ldarg 1 (out-of-bounds)*/);
		/*Error near IL_0004: Invalid metadata token*/;
	}

	static extern bool smethod_11(TcpClient tcpClient_0);

	static extern string smethod_12(object[] object_0);
}
