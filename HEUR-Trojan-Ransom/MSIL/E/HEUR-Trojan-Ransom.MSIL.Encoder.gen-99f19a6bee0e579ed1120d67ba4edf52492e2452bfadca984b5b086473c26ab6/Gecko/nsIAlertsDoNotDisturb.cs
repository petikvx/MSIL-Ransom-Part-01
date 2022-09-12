using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("c5d63e3a-259d-45a8-b964-8377967cb4d2")]
public interface nsIAlertsDoNotDisturb
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetManualDoNotDisturbAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetManualDoNotDisturbAttribute([MarshalAs(UnmanagedType.U1)] bool aManualDoNotDisturb);
}
