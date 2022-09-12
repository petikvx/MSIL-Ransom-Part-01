using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("534ab795-6a99-4195-bfab-cfdd7836657d")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIFormSubmitObserver
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Notify([MarshalAs(UnmanagedType.Interface)] nsIDOMHTMLFormElement formNode, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow window, [MarshalAs(UnmanagedType.Interface)] nsIURI actionURL, [MarshalAs(UnmanagedType.U1)] ref bool cancelSubmit);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void NotifyInvalidSubmit([MarshalAs(UnmanagedType.Interface)] nsIDOMHTMLFormElement formNode, [MarshalAs(UnmanagedType.Interface)] nsIArray invalidElements);
}
