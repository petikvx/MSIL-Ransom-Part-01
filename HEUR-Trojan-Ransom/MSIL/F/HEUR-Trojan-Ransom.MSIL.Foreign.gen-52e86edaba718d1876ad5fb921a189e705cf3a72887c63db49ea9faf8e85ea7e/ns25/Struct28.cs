using System;
using System.Runtime.InteropServices;
using ns4;

namespace ns25;

internal struct Struct28 : IDisposable
{
	public int int_0;

	public int int_1;

	public IntPtr intptr_0;

	public Struct28(int int_2)
	{
		int_0 = int_2;
		int_1 = 2;
		intptr_0 = Marshal.AllocHGlobal(int_2);
	}

	public Struct28(byte[] byte_0)
	{
		int_0 = byte_0.Length;
		int_1 = 2;
		intptr_0 = Marshal.AllocHGlobal(int_0);
		Marshal.Copy(byte_0, 0, intptr_0, int_0);
	}

	public Struct28(byte[] byte_0, Enum55 enum55_0)
	{
		int_0 = byte_0.Length;
		int_1 = (int)enum55_0;
		intptr_0 = Marshal.AllocHGlobal(int_0);
		Marshal.Copy(byte_0, 0, intptr_0, int_0);
	}

	void IDisposable.Dispose()
	{
		if (intptr_0 != IntPtr.Zero)
		{
			Marshal.FreeHGlobal(intptr_0);
			intptr_0 = IntPtr.Zero;
		}
	}
}
