using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("E8C414C4-DC38-4BA3-AB4E-EC4CBBE22907")]
public interface nsIWebBrowserChrome
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetStatus(uint statusType, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string status);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIWebBrowser GetWebBrowserAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetWebBrowserAttribute([MarshalAs(UnmanagedType.Interface)] nsIWebBrowser aWebBrowser);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetChromeFlagsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetChromeFlagsAttribute(uint aChromeFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DestroyBrowserWindow();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SizeBrowserTo(int aCX, int aCY);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ShowAsModal();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsWindowModal();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ExitModalEventLoop(int aStatus);
}
