using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("c77763df-0fb9-41a8-8074-8e882f605755")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsITransactionManager
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void DoTransaction([MarshalAs(UnmanagedType.Interface)] nsITransaction aTransaction);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UndoTransaction();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RedoTransaction();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Clear();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ClearUndoStack();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ClearRedoStack();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void BeginBatch([MarshalAs(UnmanagedType.Interface)] nsISupports aData);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void EndBatch([MarshalAs(UnmanagedType.U1)] bool aAllowEmpty);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetNumberOfUndoItemsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetNumberOfRedoItemsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetMaxTransactionCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetMaxTransactionCountAttribute(int aMaxTransactionCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void BatchTopUndo();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveTopUndo();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsITransaction PeekUndoStack();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsITransaction PeekRedoStack();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsITransactionList GetUndoList();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsITransactionList GetRedoList();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddListener([MarshalAs(UnmanagedType.Interface)] nsITransactionListener aListener);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveListener([MarshalAs(UnmanagedType.Interface)] nsITransactionListener aListener);
}
