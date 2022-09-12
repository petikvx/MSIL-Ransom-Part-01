using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("d60a08ee-5c83-4eb6-bdfb-79fd0716501e")]
public interface nsIUrlListManager
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetGethashUrl([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase tableName, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool RegisterTable([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase tableName, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase providerName, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase updateUrl, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase gethashUrl);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void EnableUpdate([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase tableName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DisableUpdate([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase tableName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void MaybeToggleUpdateChecking();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SafeLookup([MarshalAs(UnmanagedType.Interface)] nsIPrincipal key, [MarshalAs(UnmanagedType.Interface)] nsIUrlListManagerCallback cb);
}
