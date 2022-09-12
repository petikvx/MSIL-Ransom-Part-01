using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("b7b7a77c-40c4-4196-b0b7-b0338243b3fe")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIInlineSpellChecker
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIEditorSpellCheck GetSpellCheckerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init([MarshalAs(UnmanagedType.Interface)] nsIEditor aEditor);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Cleanup([MarshalAs(UnmanagedType.U1)] bool aDestroyingFrames);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetEnableRealTimeSpellAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetEnableRealTimeSpellAttribute([MarshalAs(UnmanagedType.U1)] bool aEnableRealTimeSpell);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SpellCheckAfterEditorChange(int aAction, [MarshalAs(UnmanagedType.Interface)] nsISelection aSelection, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode aPreviousSelectedNode, int aPreviousSelectedOffset, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode aStartNode, int aStartOffset, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode aEndNode, int aEndOffset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SpellCheckRange([MarshalAs(UnmanagedType.Interface)] nsIDOMRange aSelection);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMRange GetMisspelledWord([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aNode, int aOffset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ReplaceWord([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aNode, int aOffset, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aNewword);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddWordToDictionary([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aWord);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveWordFromDictionary([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aWord);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void IgnoreWord([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aWord);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void IgnoreWords([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] IntPtr[] aWordsToIgnore, uint aCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UpdateCurrentDictionary();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetSpellCheckPendingAttribute();
}
