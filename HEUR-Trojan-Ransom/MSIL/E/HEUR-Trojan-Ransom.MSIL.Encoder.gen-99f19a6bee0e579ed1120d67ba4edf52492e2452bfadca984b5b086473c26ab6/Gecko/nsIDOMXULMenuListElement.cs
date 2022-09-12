using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("36c16a17-c0e9-4b35-951b-81a147314ef1")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDOMXULMenuListElement : nsIDOMXULControlElement, nsIDOMXULSelectControlElement
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
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetEditableAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetEditableAttribute([MarshalAs(UnmanagedType.U1)] bool aEditable);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetOpenAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetOpenAttribute([MarshalAs(UnmanagedType.U1)] bool aOpen);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetLabelAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aLabel);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetCropAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCrop);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCropAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCrop);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetImageAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aImage);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetImageAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aImage);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMNode GetInputFieldAttribute();
}
