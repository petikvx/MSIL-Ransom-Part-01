using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("67bc1691-fbaf-484a-a15b-c96212b45034")]
public interface nsIWindowWatcher
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMWindow OpenWindow([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aParent, [MarshalAs(UnmanagedType.LPStr)] string aUrl, [MarshalAs(UnmanagedType.LPStr)] string aName, [MarshalAs(UnmanagedType.LPStr)] string aFeatures, [MarshalAs(UnmanagedType.Interface)] nsISupports aArguments);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RegisterNotification([MarshalAs(UnmanagedType.Interface)] nsIObserver aObserver);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UnregisterNotification([MarshalAs(UnmanagedType.Interface)] nsIObserver aObserver);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISimpleEnumerator GetWindowEnumerator();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIPrompt GetNewPrompter([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aParent);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIAuthPrompt GetNewAuthPrompter([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aParent);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetWindowCreator([MarshalAs(UnmanagedType.Interface)] nsIWindowCreator creator);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool HasWindowCreator();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIWebBrowserChrome GetChromeForWindow([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMWindow GetWindowByName([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aTargetName, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aCurrentWindow);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMWindow GetActiveWindowAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetActiveWindowAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aActiveWindow);
}
