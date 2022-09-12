using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("3dfb2f54-378d-4d3c-a9f9-95dd2673248c")]
public interface nsISHistoryInternal
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddEntry([MarshalAs(UnmanagedType.Interface)] nsISHEntry aEntry, [MarshalAs(UnmanagedType.U1)] bool aPersist);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISHTransaction GetRootTransactionAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetRootDocShell([MarshalAs(UnmanagedType.Interface)] nsIDocShell rootDocShell);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UpdateIndex();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ReplaceEntry(int aIndex, [MarshalAs(UnmanagedType.Interface)] nsISHEntry aReplaceEntry);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool NotifyOnHistoryReload([MarshalAs(UnmanagedType.Interface)] nsIURI aReloadURI, uint aReloadFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void EvictOutOfRangeContentViewers(int aIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void EvictExpiredContentViewerForEntry([MarshalAs(UnmanagedType.Interface)] nsIBFCacheEntry aEntry);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void EvictAllContentViewers();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveEntries(IntPtr aIDs, int aStartIndex);
}
