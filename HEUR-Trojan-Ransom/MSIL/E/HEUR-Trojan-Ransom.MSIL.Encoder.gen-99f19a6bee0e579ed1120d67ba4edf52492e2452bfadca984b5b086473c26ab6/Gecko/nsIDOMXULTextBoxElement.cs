using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("7edd8215-5155-4845-a02f-dc2c08645cb9")]
public interface nsIDOMXULTextBoxElement : nsIDOMXULControlElement
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
	nsIDOMNode GetInputFieldAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetTextLengthAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetMaxLengthAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetMaxLengthAttribute(int aMaxLength);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetSizeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSizeAttribute(int aSize);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetSelectionStartAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSelectionStartAttribute(int aSelectionStart);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetSelectionEndAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSelectionEndAttribute(int aSelectionEnd);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetValueAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetValueAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTypeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTypeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Select();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSelectionRange(int selectionStart, int selectionEnd);
}
