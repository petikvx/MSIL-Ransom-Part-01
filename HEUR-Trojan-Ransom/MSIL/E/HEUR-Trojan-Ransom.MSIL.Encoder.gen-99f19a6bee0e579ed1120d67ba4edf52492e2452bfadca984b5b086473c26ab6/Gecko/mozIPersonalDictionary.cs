using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("7EF52EAF-B7E1-462B-87E2-5D1DBACA9048")]
public interface mozIPersonalDictionary
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Load();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Save();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIStringEnumerator GetWordListAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool Check([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string word, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string lang);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddWord([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string word, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string lang);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveWord([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string word, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string lang);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void IgnoreWord([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string word);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void EndSession();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddCorrection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string word, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string correction, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string lang);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveCorrection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string word, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string correction, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string lang);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetCorrection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string word, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] ref IntPtr[] words, ref uint count);
}
