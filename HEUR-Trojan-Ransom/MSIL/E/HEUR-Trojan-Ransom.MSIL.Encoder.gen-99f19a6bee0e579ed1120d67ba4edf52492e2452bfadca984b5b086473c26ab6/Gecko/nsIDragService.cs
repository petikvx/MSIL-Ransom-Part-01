using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("ebd6b3a2-af16-43af-a698-3091a087dd62")]
public interface nsIDragService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void InvokeDragSession([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aDOMNode, [MarshalAs(UnmanagedType.Interface)] nsISupportsArray aTransferables, [MarshalAs(UnmanagedType.Interface)] nsIScriptableRegion aRegion, uint aActionType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InvokeDragSessionWithImage([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aDOMNode, [MarshalAs(UnmanagedType.Interface)] nsISupportsArray aTransferableArray, [MarshalAs(UnmanagedType.Interface)] nsIScriptableRegion aRegion, uint aActionType, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode aImage, int aImageX, int aImageY, [MarshalAs(UnmanagedType.Interface)] nsIDOMDragEvent aDragEvent, [MarshalAs(UnmanagedType.Interface)] nsIDOMDataTransfer aDataTransfer);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InvokeDragSessionWithSelection([MarshalAs(UnmanagedType.Interface)] nsISelection aSelection, [MarshalAs(UnmanagedType.Interface)] nsISupportsArray aTransferableArray, uint aActionType, [MarshalAs(UnmanagedType.Interface)] nsIDOMDragEvent aDragEvent, [MarshalAs(UnmanagedType.Interface)] nsIDOMDataTransfer aDataTransfer);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDragSession GetCurrentSession();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void StartDragSession();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void EndDragSession([MarshalAs(UnmanagedType.U1)] bool aDoneDrag);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void FireDragEventAtSource(IntPtr aEventMessage);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Suppress();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Unsuppress();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DragMoved(int aX, int aY);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool MaybeAddChildProcess(IntPtr aChild);
}
