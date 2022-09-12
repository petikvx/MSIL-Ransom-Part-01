using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("7a4aeb2e-fcf3-443e-b002-ca1c8ea322e9")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDOMHTMLTextAreaElement
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetAutofocusAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAutofocusAttribute([MarshalAs(UnmanagedType.U1)] bool aAutofocus);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetColsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetColsAttribute(uint aCols);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetDisabledAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDisabledAttribute([MarshalAs(UnmanagedType.U1)] bool aDisabled);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMHTMLFormElement GetFormAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetMaxLengthAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetMaxLengthAttribute(int aMaxLength);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPlaceholderAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPlaceholder);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPlaceholderAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPlaceholder);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetReadOnlyAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetReadOnlyAttribute([MarshalAs(UnmanagedType.U1)] bool aReadOnly);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetRequiredAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetRequiredAttribute([MarshalAs(UnmanagedType.U1)] bool aRequired);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetRowsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetRowsAttribute(uint aRows);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetWrapAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aWrap);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetWrapAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aWrap);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTypeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetDefaultValueAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDefaultValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDefaultValueAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDefaultValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetValueAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetValueAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetTextLengthAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetWillValidateAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMValidityState GetValidityAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetValidationMessageAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aValidationMessage);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool CheckValidity();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCustomValidity([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase error);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Select();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetSelectionStartAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSelectionStartAttribute(int aSelectionStart);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetSelectionEndAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSelectionEndAttribute(int aSelectionEnd);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSelectionRange(int selectionStart, int selectionEnd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase direction);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSelectionDirectionAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSelectionDirection);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSelectionDirectionAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSelectionDirection);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIControllers GetControllersAttribute();
}
