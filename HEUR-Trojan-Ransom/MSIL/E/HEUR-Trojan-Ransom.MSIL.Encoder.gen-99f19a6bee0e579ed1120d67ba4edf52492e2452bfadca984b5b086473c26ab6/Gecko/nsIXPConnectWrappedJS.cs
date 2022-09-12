using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("3a01b0d6-074b-49ed-bac3-08c76366cae4")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIXPConnectWrappedJS : nsIXPConnectJSObjectHolder
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new IntPtr GetJSObject();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIInterfaceInfo GetInterfaceInfoAttribute();

	Guid GetInterfaceIIDAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DebugDump(short depth);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr AggregatedQueryInterface(ref Guid uuid);
}
