using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("64aeda0b-e9b5-4868-a4f9-e4776e32e733")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDOMHTMLInputElement
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAcceptAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAccept);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAcceptAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAccept);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAltAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAlt);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAltAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAlt);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAutocompleteAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAutocomplete);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAutocompleteAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAutocomplete);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetAutofocusAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAutofocusAttribute([MarshalAs(UnmanagedType.U1)] bool aAutofocus);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetDefaultCheckedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDefaultCheckedAttribute([MarshalAs(UnmanagedType.U1)] bool aDefaultChecked);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetCheckedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCheckedAttribute([MarshalAs(UnmanagedType.U1)] bool aChecked);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetDisabledAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDisabledAttribute([MarshalAs(UnmanagedType.U1)] bool aDisabled);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMHTMLFormElement GetFormAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetFormActionAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aFormAction);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetFormActionAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aFormAction);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetFormEnctypeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aFormEnctype);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetFormEnctypeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aFormEnctype);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetFormMethodAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aFormMethod);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetFormMethodAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aFormMethod);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetFormNoValidateAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetFormNoValidateAttribute([MarshalAs(UnmanagedType.U1)] bool aFormNoValidate);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetFormTargetAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aFormTarget);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetFormTargetAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aFormTarget);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMFileList GetFilesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetHeightAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetHeightAttribute(uint aHeight);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIndeterminateAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetIndeterminateAttribute([MarshalAs(UnmanagedType.U1)] bool aIndeterminate);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetInputModeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aInputMode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetInputModeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aInputMode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMHTMLElement GetListAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetMaxAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aMax);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetMaxAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aMax);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetMaxLengthAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetMaxLengthAttribute(int aMaxLength);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetMinAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aMin);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetMinAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aMin);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetMultipleAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetMultipleAttribute([MarshalAs(UnmanagedType.U1)] bool aMultiple);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPatternAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPattern);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPatternAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPattern);

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
	void GetStepAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aStep);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetStepAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aStep);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAlignAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAlign);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAlignAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAlign);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetSizeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSizeAttribute(uint aSize);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetWidthAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetWidthAttribute(uint aWidth);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSrcAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSrc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSrcAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSrc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTypeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTypeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetDefaultValueAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDefaultValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDefaultValueAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDefaultValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetValueAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetValueAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	double GetValueAsNumberAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetValueAsNumberAttribute(double aValueAsNumber);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void StepDown(int n, int argc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void StepUp(int n, int argc);

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
	void GetUseMapAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aUseMap);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetUseMapAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aUseMap);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIControllers GetControllersAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetTextLengthAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void MozGetFileNameArray(ref uint aLength, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ref IntPtr[] aFileNames);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void MozSetFileNameArray([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] IntPtr[] aFileNames, uint aLength);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool MozIsTextField([MarshalAs(UnmanagedType.U1)] bool aExcludePassword);
}
