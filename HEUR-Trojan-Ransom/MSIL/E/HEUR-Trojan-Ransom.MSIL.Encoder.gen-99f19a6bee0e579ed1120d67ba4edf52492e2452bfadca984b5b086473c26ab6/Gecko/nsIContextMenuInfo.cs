using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("2f977d56-5485-11d4-87e2-0010a4e75ef2")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIContextMenuInfo
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMEvent GetMouseEventAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMNode GetTargetNodeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAssociatedLinkAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAssociatedLink);

	[MethodImpl(MethodImplOptions.InternalCall)]
	imgIContainer GetImageContainerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetImageSrcAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	imgIContainer GetBackgroundImageContainerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetBackgroundImageSrcAttribute();
}
