using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("e787be29-db5d-4a45-a3d6-1de1d6b85c30")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIXPConnectWrappedNative : nsIXPConnectJSObjectHolder
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new IntPtr GetJSObject();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports GetNativeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetJSObjectPrototypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIInterfaceInfo FindInterfaceWithMember(ref IntPtr nameID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIInterfaceInfo FindInterfaceWithName(ref IntPtr nameID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool HasNativeMember(ref IntPtr name);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DebugDump(short depth);
}
