using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("efa36ea2-5b07-46fc-9534-a5acb8b77b72")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIRedirectChannelRegistrar
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	uint RegisterChannel([MarshalAs(UnmanagedType.Interface)] nsIChannel channel);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIChannel LinkChannels(uint id, [MarshalAs(UnmanagedType.Interface)] nsIParentChannel channel);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIChannel GetRegisteredChannel(uint id);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIParentChannel GetParentChannel(uint id);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeregisterChannels(uint id);
}
