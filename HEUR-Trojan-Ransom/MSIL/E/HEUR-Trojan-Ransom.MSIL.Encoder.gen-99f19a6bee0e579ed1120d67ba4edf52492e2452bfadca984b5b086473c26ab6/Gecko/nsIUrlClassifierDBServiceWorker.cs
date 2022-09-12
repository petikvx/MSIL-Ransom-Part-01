using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("b7b505d0-bfa2-44db-abf8-6e2bfc25bbab")]
public interface nsIUrlClassifierDBServiceWorker : nsIUrlClassifierDBService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Lookup([MarshalAs(UnmanagedType.Interface)] nsIPrincipal principal, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase tables, [MarshalAs(UnmanagedType.Interface)] nsIUrlClassifierCallback c);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetTables([MarshalAs(UnmanagedType.Interface)] nsIUrlClassifierCallback c);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetHashCompleter([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase tableName, [MarshalAs(UnmanagedType.Interface)] nsIUrlClassifierHashCompleter completer);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetLastUpdateTime([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase tableName, ulong lastUpdateTime);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void BeginUpdate([MarshalAs(UnmanagedType.Interface)] nsIUrlClassifierUpdateObserver updater, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase tables);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void BeginStream([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase table);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void UpdateStream([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase updateChunk);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void FinishStream();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void FinishUpdate();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void CancelUpdate();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void ResetDatabase();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OpenDb();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CloseDb();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CacheCompletions(IntPtr completions);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CacheMisses(IntPtr misses);
}
