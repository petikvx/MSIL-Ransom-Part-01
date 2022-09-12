using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("7a180b78-0f46-4569-8c22-f3d720ea1c57")]
public interface nsIFeedResult
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetBozoAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetBozoAttribute([MarshalAs(UnmanagedType.U1)] bool aBozo);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIFeedContainer GetDocAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDocAttribute([MarshalAs(UnmanagedType.Interface)] nsIFeedContainer aDoc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetUriAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetUriAttribute([MarshalAs(UnmanagedType.Interface)] nsIURI aUri);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetVersionAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aVersion);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetVersionAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aVersion);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetStylesheetAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetStylesheetAttribute([MarshalAs(UnmanagedType.Interface)] nsIURI aStylesheet);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIProperties GetHeadersAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetHeadersAttribute([MarshalAs(UnmanagedType.Interface)] nsIProperties aHeaders);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RegisterExtensionPrefix([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aNamespace, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPrefix);
}
