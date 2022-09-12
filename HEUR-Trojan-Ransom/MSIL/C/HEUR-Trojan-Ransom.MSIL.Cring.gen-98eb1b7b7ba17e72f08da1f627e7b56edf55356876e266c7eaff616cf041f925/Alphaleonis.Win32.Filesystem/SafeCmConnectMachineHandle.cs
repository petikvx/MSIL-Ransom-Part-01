using System.Security;
using Microsoft.Win32.SafeHandles;

namespace Alphaleonis.Win32.Filesystem;

[SecurityCritical]
internal sealed class SafeCmConnectMachineHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	public SafeCmConnectMachineHandle()
		: base(ownsHandle: true)
	{
	}

	protected override bool ReleaseHandle()
	{
		return NativeMethods.CM_Disconnect_Machine(handle) == 0L;
	}
}
