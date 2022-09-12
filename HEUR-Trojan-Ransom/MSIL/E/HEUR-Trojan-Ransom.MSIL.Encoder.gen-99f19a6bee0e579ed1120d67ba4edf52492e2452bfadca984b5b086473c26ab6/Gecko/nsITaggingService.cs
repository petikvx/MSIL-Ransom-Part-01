using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("9759bd0e-78e2-4421-9ed1-c676e1af3513")]
public interface nsITaggingService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void TagURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsIVariant aTags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UntagURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsIVariant aTags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIVariant GetURIsForTag([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aTag);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTagsForURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, ref uint length, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ref IntPtr[] aTags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIVariant GetAllTagsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetHasTagsAttribute();
}
