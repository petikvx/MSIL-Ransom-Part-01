using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("b2bc96b8-31fc-42f4-937a-bd27291af40b")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDOMXULContainerElement : nsIDOMXULContainerItemElement
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIDOMXULContainerElement GetParentContainerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMXULElement AppendItem([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aLabel, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMXULElement InsertItemAt(int aIndex, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aLabel, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMXULElement RemoveItemAt(int aIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetItemCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetIndexOfItem([MarshalAs(UnmanagedType.Interface)] nsIDOMXULElement aItem);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMXULElement GetItemAtIndex(int aIndex);
}
