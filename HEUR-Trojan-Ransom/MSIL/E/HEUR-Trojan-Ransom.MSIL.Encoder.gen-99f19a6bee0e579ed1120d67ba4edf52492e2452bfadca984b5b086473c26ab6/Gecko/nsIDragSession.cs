using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("25bce737-73f0-43c7-bc20-c71044a73c5a")]
public interface nsIDragSession
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetCanDropAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCanDropAttribute([MarshalAs(UnmanagedType.U1)] bool aCanDrop);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetOnlyChromeDropAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetOnlyChromeDropAttribute([MarshalAs(UnmanagedType.U1)] bool aOnlyChromeDrop);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetDragActionAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDragActionAttribute(uint aDragAction);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetTargetSizeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTargetSizeAttribute(uint aTargetSize);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetNumDropItemsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMDocument GetSourceDocumentAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMNode GetSourceNodeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMDataTransfer GetDataTransferAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDataTransferAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMDataTransfer aDataTransfer);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetData([MarshalAs(UnmanagedType.Interface)] nsITransferable aTransferable, uint aItemIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsDataFlavorSupported([MarshalAs(UnmanagedType.LPStr)] string aDataFlavor);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UserCancelled();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DragEventDispatchedToChildProcess();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UpdateDragEffect();
}
