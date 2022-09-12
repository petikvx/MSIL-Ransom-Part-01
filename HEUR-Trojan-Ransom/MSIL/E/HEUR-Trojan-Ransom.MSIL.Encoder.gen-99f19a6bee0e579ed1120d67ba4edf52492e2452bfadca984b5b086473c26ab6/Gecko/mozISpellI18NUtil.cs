using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("B075D5DC-1DF1-441A-BEBF-680D8CAAA19C")]
public interface mozISpellI18NUtil
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
	string GetLanguageAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetRootForm([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string word, uint type, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] ref IntPtr[] words, ref uint count);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void FromRootForm([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string word, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] IntPtr[] iwords, uint icount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] ref IntPtr[] owords, ref uint ocount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void FindNextWord([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string word, uint length, uint offset, ref int begin, ref int end);
}
