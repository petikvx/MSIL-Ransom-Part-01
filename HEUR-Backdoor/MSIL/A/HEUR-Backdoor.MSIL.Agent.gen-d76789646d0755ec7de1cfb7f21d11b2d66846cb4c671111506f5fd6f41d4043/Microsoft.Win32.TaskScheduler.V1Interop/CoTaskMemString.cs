using System;
using System.Runtime.InteropServices;

namespace Microsoft.Win32.TaskScheduler.V1Interop;

internal sealed class CoTaskMemString : SafeHandle
{
	public override bool IsInvalid => handle == IntPtr.Zero;

	public CoTaskMemString()
		: base(IntPtr.Zero, ownsHandle: true)
	{
	}

	public CoTaskMemString(IntPtr handle)
		: this()
	{
		SetHandle(handle);
	}

	public CoTaskMemString(string text)
		: this()
	{
		SetHandle(Marshal.StringToCoTaskMemUni(text));
	}

	public static implicit operator string(CoTaskMemString cmem)
	{
		return cmem.ToString();
	}

	protected override bool ReleaseHandle()
	{
		Marshal.FreeCoTaskMem(handle);
		return true;
	}

	public override string ToString()
	{
		return Marshal.PtrToStringUni(handle);
	}
}
