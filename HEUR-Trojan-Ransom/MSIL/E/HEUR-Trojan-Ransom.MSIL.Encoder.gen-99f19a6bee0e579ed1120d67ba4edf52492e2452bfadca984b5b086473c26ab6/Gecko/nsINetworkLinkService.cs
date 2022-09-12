using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("103e5293-77b3-4b70-af59-6e9e4a1f994a")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsINetworkLinkService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsLinkUpAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetLinkStatusKnownAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetLinkTypeAttribute();
}
