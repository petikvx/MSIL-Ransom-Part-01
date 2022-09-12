using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("58e330c4-7b48-11d2-98b9-00805f297d89")]
public interface nsITransactionListener
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool WillDo([MarshalAs(UnmanagedType.Interface)] nsITransactionManager aManager, [MarshalAs(UnmanagedType.Interface)] nsITransaction aTransaction);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DidDo([MarshalAs(UnmanagedType.Interface)] nsITransactionManager aManager, [MarshalAs(UnmanagedType.Interface)] nsITransaction aTransaction, int aDoResult);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool WillUndo([MarshalAs(UnmanagedType.Interface)] nsITransactionManager aManager, [MarshalAs(UnmanagedType.Interface)] nsITransaction aTransaction);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DidUndo([MarshalAs(UnmanagedType.Interface)] nsITransactionManager aManager, [MarshalAs(UnmanagedType.Interface)] nsITransaction aTransaction, int aUndoResult);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool WillRedo([MarshalAs(UnmanagedType.Interface)] nsITransactionManager aManager, [MarshalAs(UnmanagedType.Interface)] nsITransaction aTransaction);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DidRedo([MarshalAs(UnmanagedType.Interface)] nsITransactionManager aManager, [MarshalAs(UnmanagedType.Interface)] nsITransaction aTransaction, int aRedoResult);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool WillBeginBatch([MarshalAs(UnmanagedType.Interface)] nsITransactionManager aManager);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DidBeginBatch([MarshalAs(UnmanagedType.Interface)] nsITransactionManager aManager, int aResult);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool WillEndBatch([MarshalAs(UnmanagedType.Interface)] nsITransactionManager aManager);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DidEndBatch([MarshalAs(UnmanagedType.Interface)] nsITransactionManager aManager, int aResult);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool WillMerge([MarshalAs(UnmanagedType.Interface)] nsITransactionManager aManager, [MarshalAs(UnmanagedType.Interface)] nsITransaction aTopTransaction, [MarshalAs(UnmanagedType.Interface)] nsITransaction aTransactionToMerge);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DidMerge([MarshalAs(UnmanagedType.Interface)] nsITransactionManager aManager, [MarshalAs(UnmanagedType.Interface)] nsITransaction aTopTransaction, [MarshalAs(UnmanagedType.Interface)] nsITransaction aTransactionToMerge, [MarshalAs(UnmanagedType.U1)] bool aDidMerge, int aMergeResult);
}
