using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("934697e4-3807-47f8-b6c9-6caa8d83ccd1")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsISessionStartup
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetOnceInitializedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetStateAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool DoRestore();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsAutomaticRestoreEnabled();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetWillOverrideHomepageAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetSessionTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetPreviousSessionCrashedAttribute();
}
