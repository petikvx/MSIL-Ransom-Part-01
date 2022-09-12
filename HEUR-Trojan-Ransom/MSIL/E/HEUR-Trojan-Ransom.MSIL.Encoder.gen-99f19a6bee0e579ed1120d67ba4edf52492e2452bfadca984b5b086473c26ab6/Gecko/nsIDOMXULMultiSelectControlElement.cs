using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("40654a10-8204-4f06-9f21-7baa31c7b1dd")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDOMXULMultiSelectControlElement : nsIDOMXULControlElement, nsIDOMXULSelectControlElement
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
	new nsIDOMXULSelectControlItemElement GetSelectedItemAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetSelectedItemAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMXULSelectControlItemElement aSelectedItem);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new int GetSelectedIndexAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetSelectedIndexAttribute(int aSelectedIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetValueAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetValueAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIDOMXULSelectControlItemElement AppendItem([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase label, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase value);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIDOMXULSelectControlItemElement InsertItemAt(int index, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase label, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase value);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIDOMXULSelectControlItemElement RemoveItemAt(int index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint GetItemCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new int GetIndexOfItem([MarshalAs(UnmanagedType.Interface)] nsIDOMXULSelectControlItemElement item);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIDOMXULSelectControlItemElement GetItemAtIndex(int index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSelTypeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSelType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSelTypeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSelType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMXULSelectControlItemElement GetCurrentItemAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCurrentItemAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMXULSelectControlItemElement aCurrentItem);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetCurrentIndexAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCurrentIndexAttribute(int aCurrentIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMNodeList GetSelectedItemsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddItemToSelection([MarshalAs(UnmanagedType.Interface)] nsIDOMXULSelectControlItemElement item);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveItemFromSelection([MarshalAs(UnmanagedType.Interface)] nsIDOMXULSelectControlItemElement item);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ToggleItemSelection([MarshalAs(UnmanagedType.Interface)] nsIDOMXULSelectControlItemElement item);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SelectItem([MarshalAs(UnmanagedType.Interface)] nsIDOMXULSelectControlItemElement item);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SelectItemRange([MarshalAs(UnmanagedType.Interface)] nsIDOMXULSelectControlItemElement startItem, [MarshalAs(UnmanagedType.Interface)] nsIDOMXULSelectControlItemElement item);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SelectAll();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InvertSelection();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ClearSelection();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetSelectedCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMXULSelectControlItemElement GetSelectedItem(int index);
}
