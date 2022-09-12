using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("013b62af-1e2f-4b07-9091-d7c0fc4687e2")]
public interface nsIDOMXULTreeElement
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsITreeColumns GetColumnsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsITreeView GetViewAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetViewAttribute([MarshalAs(UnmanagedType.Interface)] nsITreeView aView);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMElement GetBodyAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetEditableAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetEditableAttribute([MarshalAs(UnmanagedType.U1)] bool aEditable);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMXULTextBoxElement GetInputFieldAttribute();
}
