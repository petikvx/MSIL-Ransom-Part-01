using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("1fb79c27-e760-4088-b19c-1ce3673ec24e")]
public interface nsITabChild
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetMessageManagerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIWebBrowserChrome3 GetWebBrowserChromeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetWebBrowserChromeAttribute([MarshalAs(UnmanagedType.Interface)] nsIWebBrowserChrome3 aWebBrowserChrome);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SendRequestFocus([MarshalAs(UnmanagedType.U1)] bool canFocus);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void EnableDisableCommands([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase action, IntPtr enabledCommands, IntPtr disabledCommands);

	[MethodImpl(MethodImplOptions.InternalCall)]
	ulong GetTabIdAttribute();
}
