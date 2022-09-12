using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("924d98d9-3518-4cb4-8708-c74fe8e3ec3c")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIFontEnumerator
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void EnumerateAllFonts(ref uint aCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ref IntPtr[] aResult);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void EnumerateFonts([MarshalAs(UnmanagedType.LPStr)] string aLangGroup, [MarshalAs(UnmanagedType.LPStr)] string aGeneric, ref uint aCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] ref IntPtr[] aResult);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool HaveFontFor([MarshalAs(UnmanagedType.LPStr)] string aLangGroup);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
	string GetDefaultFont([MarshalAs(UnmanagedType.LPStr)] string aLangGroup, [MarshalAs(UnmanagedType.LPStr)] string aGeneric);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool UpdateFontList();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
	string GetStandardFamilyName([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aName);
}
