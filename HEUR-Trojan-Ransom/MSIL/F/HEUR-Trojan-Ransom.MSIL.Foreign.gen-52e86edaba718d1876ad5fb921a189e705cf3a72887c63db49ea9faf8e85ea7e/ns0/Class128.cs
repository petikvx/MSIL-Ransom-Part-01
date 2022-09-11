using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ns0;

internal sealed class Class128
{
	[StructLayout(LayoutKind.Sequential)]
	public sealed class Class129
	{
		public int int_0;

		public IntPtr intptr_0 = IntPtr.Zero;

		public bool bool_0;

		[NonSerialized]
		internal static GetString getString_0;

		public Class129()
		{
			int_0 = Marshal.SizeOf<Class129>();
		}

		static Class129()
		{
			Strings.CreateGetStringDelegate(typeof(Class129));
			bool bool_ = false;
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107398144), getString_0(107398139)).Replace(getString_0(107398102), getString_0(107398097)));
			if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_1: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107398092)))
			{
				throw new SecurityException(getString_0(107398067));
			}
		}

		[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_1, [MarshalAs(UnmanagedType.Bool)] out bool bool_2);
	}

	public const uint uint_0 = 2147483648u;

	public const uint uint_1 = 1073741824u;

	public const int int_0 = -1;

	public const uint uint_2 = 1073741824u;

	public const uint uint_3 = 536870912u;

	public const uint uint_4 = 3u;

	private Class128()
	{
	}

	[DllImport("Kernel32", CharSet = CharSet.Unicode)]
	public static extern IntPtr CreateFile(string string_0, uint uint_5, uint uint_6, Class129 class129_0, uint uint_7, uint uint_8, uint uint_9);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool PeekNamedPipe(IntPtr intptr_0, byte[] byte_0, uint uint_5, ref uint uint_6, ref uint uint_7, ref uint uint_8);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool ReadFile(IntPtr intptr_0, [Out] byte[] byte_0, uint uint_5, out uint uint_6, IntPtr intptr_1);

	[DllImport("Kernel32")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool WriteFile(IntPtr intptr_0, [In] byte[] byte_0, uint uint_5, out uint uint_6, IntPtr intptr_1);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool CloseHandle(IntPtr intptr_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool CancelIo(IntPtr intptr_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool FlushFileBuffers(IntPtr intptr_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
	public static extern IntPtr OpenEvent(uint uint_5, [MarshalAs(UnmanagedType.Bool)] bool bool_0, string string_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
	public static extern IntPtr OpenFileMapping(uint uint_5, [MarshalAs(UnmanagedType.Bool)] bool bool_0, string string_0);

	[DllImport("kernel32.dll")]
	public static extern IntPtr MapViewOfFile(IntPtr intptr_0, uint uint_5, uint uint_6, uint uint_7, IntPtr intptr_1);

	[DllImport("kernel32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool UnmapViewOfFile(IntPtr intptr_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern int FlushViewOfFile(IntPtr intptr_0, uint uint_5);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool WaitNamedPipe(string string_0, uint uint_5);

	[DllImport("ws2_32.dll", SetLastError = true)]
	public static extern IntPtr socket(int int_1, int int_2, int int_3);

	[DllImport("ws2_32.dll", SetLastError = true)]
	public static extern int ioctlsocket(IntPtr intptr_0, uint uint_5, ref uint uint_6);

	[DllImport("ws2_32.dll", SetLastError = true)]
	public static extern int WSAIoctl(IntPtr intptr_0, uint uint_5, byte[] byte_0, uint uint_6, byte[] byte_1, uint uint_7, IntPtr intptr_1, IntPtr intptr_2, IntPtr intptr_3);

	[DllImport("ws2_32.dll", SetLastError = true)]
	public static extern int WSAGetLastError();

	[DllImport("ws2_32.dll", SetLastError = true)]
	public static extern int connect(IntPtr intptr_0, byte[] byte_0, int int_1);

	[DllImport("ws2_32.dll", SetLastError = true)]
	public static extern int recv(IntPtr intptr_0, byte[] byte_0, int int_1, int int_2);

	[DllImport("ws2_32.dll", SetLastError = true)]
	public static extern int send(IntPtr intptr_0, byte[] byte_0, int int_1, int int_2);
}
