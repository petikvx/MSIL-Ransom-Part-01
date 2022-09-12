using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("3073ceff-777c-41ce-9ace-ab37268147c1")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface fuelIBrowserTab
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetUriAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetIndexAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	fuelIWindow GetWindowAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMHTMLDocument GetDocumentAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	extIEvents GetEventsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Load([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Focus();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Close();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void MoveBefore(fuelIBrowserTab aBefore);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void MoveToEnd();
}
