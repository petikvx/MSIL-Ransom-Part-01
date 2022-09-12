using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("b8cc9126-9319-4415-afd9-b82220d453ed")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsISecurityInfoProvider
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports GetSecurityInfoAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetHasTransferredDataAttribute();
}
