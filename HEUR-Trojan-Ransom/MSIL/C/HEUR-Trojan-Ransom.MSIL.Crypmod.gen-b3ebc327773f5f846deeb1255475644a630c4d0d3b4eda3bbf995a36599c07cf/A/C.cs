using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace A;

internal class C
{
	public struct A
	{
		[MarshalAs(UnmanagedType.LPStr)]
		public string A;

		public int A;

		public IntPtr A;
	}

	public struct a
	{
		public uint A;

		public IntPtr A;

		public uint a;
	}

	public struct B
	{
		public A A;

		public a A;
	}

	public const uint A = 1u;

	public const uint a = 65536u;

	public const uint B = 32768u;

	public const uint b = 8u;

	public const uint C = 19u;

	public const uint c = 72u;

	[DllImport("crypt32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool CryptDecodeObjectEx(uint uint_0, uint uint_1, IntPtr intptr_0, uint uint_2, uint uint_3, IntPtr intptr_1, out c c_0, out uint uint_4);

	[DllImport("crypt32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool CryptEncodeObjectEx(uint uint_0, uint uint_1, IntPtr intptr_0, uint uint_2, IntPtr intptr_1, out c c_0, out uint uint_3);
}
internal sealed class c : SafeHandleZeroOrMinusOneIsInvalid
{
	private c()
		: base(ownsHandle: true)
	{
	}

	public static c A(int int_0)
	{
		c c2 = new c();
		c2.a(int_0);
		return c2;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	private void a(int int_0)
	{
		SetHandle(Marshal.AllocHGlobal(int_0));
	}

	protected override bool ReleaseHandle()
	{
		Marshal.FreeHGlobal(handle);
		return true;
	}
}
