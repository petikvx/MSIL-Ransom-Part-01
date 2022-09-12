using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("2585a7b1-7b47-43c4-bf17-c6bf84e09b7b")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIWebBrowserChrome2 : nsIWebBrowserChrome
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetStatus(uint statusType, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string status);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIWebBrowser GetWebBrowserAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetWebBrowserAttribute([MarshalAs(UnmanagedType.Interface)] nsIWebBrowser aWebBrowser);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint GetChromeFlagsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetChromeFlagsAttribute(uint aChromeFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void DestroyBrowserWindow();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SizeBrowserTo(int aCX, int aCY);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void ShowAsModal();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool IsWindowModal();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void ExitModalEventLoop(int aStatus);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetStatusWithContext(uint statusType, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase statusText, [MarshalAs(UnmanagedType.Interface)] nsISupports statusContext);
}
