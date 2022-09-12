using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("0f2d9d75-c46b-4114-802e-83b4655e61d2")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsPIWindowWatcher
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddWindow([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow, [MarshalAs(UnmanagedType.Interface)] nsIWebBrowserChrome aChrome);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveWindow([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMWindow OpenWindow2([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aParent, [MarshalAs(UnmanagedType.LPStr)] string aUrl, [MarshalAs(UnmanagedType.LPStr)] string aName, [MarshalAs(UnmanagedType.LPStr)] string aFeatures, [MarshalAs(UnmanagedType.U1)] bool aCalledFromScript, [MarshalAs(UnmanagedType.U1)] bool aDialog, [MarshalAs(UnmanagedType.U1)] bool aNavigate, [MarshalAs(UnmanagedType.Interface)] nsITabParent aOpeningTab, [MarshalAs(UnmanagedType.Interface)] nsISupports aArgs);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDocShellTreeItem FindItemWithName([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aName, [MarshalAs(UnmanagedType.Interface)] nsIDocShellTreeItem aRequestor, [MarshalAs(UnmanagedType.Interface)] nsIDocShellTreeItem aOriginalRequestor);
}
