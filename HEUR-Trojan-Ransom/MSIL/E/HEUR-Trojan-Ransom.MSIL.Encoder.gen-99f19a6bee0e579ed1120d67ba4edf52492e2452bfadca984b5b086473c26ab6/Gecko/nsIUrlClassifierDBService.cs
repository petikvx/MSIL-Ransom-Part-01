using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("7a258022-6765-11e5-b379-b37b1f2354be")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIUrlClassifierDBService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Lookup([MarshalAs(UnmanagedType.Interface)] nsIPrincipal principal, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase tables, [MarshalAs(UnmanagedType.Interface)] nsIUrlClassifierCallback c);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTables([MarshalAs(UnmanagedType.Interface)] nsIUrlClassifierCallback c);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetHashCompleter([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase tableName, [MarshalAs(UnmanagedType.Interface)] nsIUrlClassifierHashCompleter completer);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetLastUpdateTime([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase tableName, ulong lastUpdateTime);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void BeginUpdate([MarshalAs(UnmanagedType.Interface)] nsIUrlClassifierUpdateObserver updater, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase tables);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void BeginStream([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase table);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UpdateStream([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase updateChunk);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void FinishStream();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void FinishUpdate();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CancelUpdate();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ResetDatabase();
}
