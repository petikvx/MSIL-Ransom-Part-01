using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("9bf188a7-d6f9-431b-b5c7-118013998e8b")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDOMXULSelectControlElement : nsIDOMXULControlElement
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool GetDisabledAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetDisabledAttribute([MarshalAs(UnmanagedType.U1)] bool aDisabled);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new int GetTabIndexAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetTabIndexAttribute(int aTabIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMXULSelectControlItemElement GetSelectedItemAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSelectedItemAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMXULSelectControlItemElement aSelectedItem);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetSelectedIndexAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSelectedIndexAttribute(int aSelectedIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetValueAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetValueAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMXULSelectControlItemElement AppendItem([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase label, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase value);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMXULSelectControlItemElement InsertItemAt(int index, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase label, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase value);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMXULSelectControlItemElement RemoveItemAt(int index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetItemCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetIndexOfItem([MarshalAs(UnmanagedType.Interface)] nsIDOMXULSelectControlItemElement item);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMXULSelectControlItemElement GetItemAtIndex(int index);
}
