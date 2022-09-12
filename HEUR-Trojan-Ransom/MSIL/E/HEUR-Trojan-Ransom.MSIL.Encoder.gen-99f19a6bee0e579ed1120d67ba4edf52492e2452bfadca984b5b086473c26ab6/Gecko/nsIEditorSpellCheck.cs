using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("a171c25f-e4a8-4d08-adef-b797e6377bdc")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIEditorSpellCheck
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool CanSpellCheck();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InitSpellChecker([MarshalAs(UnmanagedType.Interface)] nsIEditor editor, [MarshalAs(UnmanagedType.U1)] bool enableSelectionChecking, [MarshalAs(UnmanagedType.Interface)] nsIEditorSpellCheckCallback callback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
	string GetNextMisspelledWord();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
	string GetSuggestedWord();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool CheckCurrentWord([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string suggestedWord);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ReplaceWord([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string misspelledWord, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string replaceWord, [MarshalAs(UnmanagedType.U1)] bool allOccurrences);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void IgnoreWordAllOccurrences([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string word);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPersonalDictionary();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
	string GetPersonalDictionaryWord();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddWordToDictionary([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string word);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveWordFromDictionary([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string word);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetDictionaryList([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ref IntPtr[] dictionaryList, ref uint count);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetCurrentDictionary([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCurrentDictionary([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase dictionary);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UninitSpellChecker();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetFilter([MarshalAs(UnmanagedType.Interface)] nsITextServicesFilter filter);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool CheckCurrentWordNoSuggest([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string suggestedWord);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UpdateCurrentDictionary([MarshalAs(UnmanagedType.Interface)] nsIEditorSpellCheckCallback callback);
}
