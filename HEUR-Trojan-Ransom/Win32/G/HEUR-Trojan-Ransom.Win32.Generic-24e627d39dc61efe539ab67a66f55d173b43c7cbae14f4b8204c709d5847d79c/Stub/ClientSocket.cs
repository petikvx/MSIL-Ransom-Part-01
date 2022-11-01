using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace Stub;

public class ClientSocket
{
	public static bool isConnected;

	public static Socket S;

	private static long BufferLength;

	private static bool BufferLengthReceived;

	private static byte[] Buffer;

	private static MemoryStream MS;

	private static Timer Tick;

	public static ManualResetEvent allDone;

	private static object SendSync;

	public static readonly string SPL;

	static ClientSocket()
	{
		Class0.smethod_13();
		isConnected = false;
		S = null;
		BufferLength = 0L;
		BufferLengthReceived = false;
		MS = null;
		Tick = null;
		SPL = Settings.SPL;
	}

	public static void BeginConnect()
	{
	}

	public static object Info()
	{
		return null;
	}

	public static void BeginReceive(IAsyncResult iasyncResult_0)
	{
	}

	public static void BeginRead(byte[] byte_0)
	{
	}

	public static void Send(string string_0)
	{
	}

	public static void EndSend(IAsyncResult iasyncResult_0)
	{
	}

	public static void isDisconnected()
	{
	}

	public static void Ping()
	{
	}
}
