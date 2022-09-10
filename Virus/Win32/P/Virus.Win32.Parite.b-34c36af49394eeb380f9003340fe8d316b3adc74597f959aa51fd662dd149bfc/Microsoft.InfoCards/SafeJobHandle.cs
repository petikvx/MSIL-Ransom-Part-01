using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.InfoCards;

internal sealed class SafeJobHandle : SafeHandle
{
	public override bool IsInvalid => IntPtr.Zero == handle;

	[DllImport("Kernel32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool TerminateJobObject([In] IntPtr hJob, [In] uint uExitCode);

	public SafeJobHandle()
		: base(IntPtr.Zero, ownsHandle: true)
	{
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public void UpdateHandle(IntPtr handle)
	{
		SetHandle(handle);
	}

	protected override bool ReleaseHandle()
	{
		TerminateJobObject(handle, 0u);
		return NativeMethods.SafeHandleOnlyMethods.CloseHandle(handle);
	}
}
