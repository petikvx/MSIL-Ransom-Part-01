using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("8ba643a4-7ddc-4662-b976-7ec123843f10")]
public interface mozISpellCheckingEngine
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
	string GetDictionaryAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDictionaryAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aDictionary);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
	string GetLanguageAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetProvidesPersonalDictionaryAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetProvidesWordUtilsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
	string GetNameAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
	string GetCopyrightAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	mozIPersonalDictionary GetPersonalDictionaryAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPersonalDictionaryAttribute(mozIPersonalDictionary aPersonalDictionary);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetDictionaryList([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ref IntPtr[] dictionaries, ref uint count);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool Check([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string word);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Suggest([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string word, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] ref IntPtr[] suggestions, ref uint count);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void LoadDictionariesFromDir([MarshalAs(UnmanagedType.Interface)] nsIFile dir);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddDirectory([MarshalAs(UnmanagedType.Interface)] nsIFile dir);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveDirectory([MarshalAs(UnmanagedType.Interface)] nsIFile dir);
}
