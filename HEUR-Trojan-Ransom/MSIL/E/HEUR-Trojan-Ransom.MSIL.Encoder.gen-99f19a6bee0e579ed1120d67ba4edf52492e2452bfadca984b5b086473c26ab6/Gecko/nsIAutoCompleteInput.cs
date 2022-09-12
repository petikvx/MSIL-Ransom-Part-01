using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("B068E70F-F82C-4C12-AD87-82E271C5C180")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIAutoCompleteInput
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIAutoCompletePopup GetPopupAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIAutoCompleteController GetControllerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetPopupOpenAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPopupOpenAttribute([MarshalAs(UnmanagedType.U1)] bool aPopupOpen);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetDisableAutoCompleteAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDisableAutoCompleteAttribute([MarshalAs(UnmanagedType.U1)] bool aDisableAutoComplete);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetCompleteDefaultIndexAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCompleteDefaultIndexAttribute([MarshalAs(UnmanagedType.U1)] bool aCompleteDefaultIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetCompleteSelectedIndexAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCompleteSelectedIndexAttribute([MarshalAs(UnmanagedType.U1)] bool aCompleteSelectedIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetForceCompleteAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetForceCompleteAttribute([MarshalAs(UnmanagedType.U1)] bool aForceComplete);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetMinResultsForPopupAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetMinResultsForPopupAttribute(uint aMinResultsForPopup);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetMaxRowsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetMaxRowsAttribute(uint aMaxRows);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetShowCommentColumnAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetShowCommentColumnAttribute([MarshalAs(UnmanagedType.U1)] bool aShowCommentColumn);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetShowImageColumnAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetShowImageColumnAttribute([MarshalAs(UnmanagedType.U1)] bool aShowImageColumn);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetTimeoutAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTimeoutAttribute(uint aTimeout);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSearchParamAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSearchParam);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSearchParamAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSearchParam);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetSearchCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSearchAt(uint index, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTextValueAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aTextValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTextValueAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aTextValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetSelectionStartAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetSelectionEndAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SelectTextRange(int startIndex, int endIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnSearchBegin();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnSearchComplete();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool OnTextEntered();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool OnTextReverted();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetConsumeRollupEventAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetInPrivateContextAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetNoRollupOnCaretMoveAttribute();
}
