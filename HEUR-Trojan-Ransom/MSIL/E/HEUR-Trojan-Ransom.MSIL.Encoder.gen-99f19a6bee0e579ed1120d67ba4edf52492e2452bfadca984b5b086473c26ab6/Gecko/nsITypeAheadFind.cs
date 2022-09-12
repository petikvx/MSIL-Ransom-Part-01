using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("f4411c5b-761b-498c-8050-dcfc8311f69e")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsITypeAheadFind
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init([MarshalAs(UnmanagedType.Interface)] nsIDocShell aDocShell);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint Find([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSearchString, [MarshalAs(UnmanagedType.U1)] bool aLinksOnly);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint FindAgain([MarshalAs(UnmanagedType.U1)] bool findBackwards, [MarshalAs(UnmanagedType.U1)] bool aLinksOnly);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMRange GetFoundRange();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDocShell([MarshalAs(UnmanagedType.Interface)] nsIDocShell aDocShell);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSelectionModeAndRepaint(short toggle);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CollapseSelection();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsRangeVisible([MarshalAs(UnmanagedType.Interface)] nsIDOMRange aRange, [MarshalAs(UnmanagedType.U1)] bool aMustBeInViewPort);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSearchStringAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSearchString);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetCaseSensitiveAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCaseSensitiveAttribute([MarshalAs(UnmanagedType.U1)] bool aCaseSensitive);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMElement GetFoundLinkAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMElement GetFoundEditableAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMWindow GetCurrentWindowAttribute();
}
