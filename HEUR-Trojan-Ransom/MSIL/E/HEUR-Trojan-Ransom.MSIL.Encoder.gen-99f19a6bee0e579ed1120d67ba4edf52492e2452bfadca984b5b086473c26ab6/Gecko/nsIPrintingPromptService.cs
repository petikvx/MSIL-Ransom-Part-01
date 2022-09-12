using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("75D1553D-63BF-4b5d-A8F7-E4E4CAC21BA4")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIPrintingPromptService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void ShowPrintDialog([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow parent, [MarshalAs(UnmanagedType.Interface)] nsIWebBrowserPrint webBrowserPrint, [MarshalAs(UnmanagedType.Interface)] nsIPrintSettings printSettings);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ShowProgress([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow parent, [MarshalAs(UnmanagedType.Interface)] nsIWebBrowserPrint webBrowserPrint, [MarshalAs(UnmanagedType.Interface)] nsIPrintSettings printSettings, [MarshalAs(UnmanagedType.Interface)] nsIObserver openDialogObserver, [MarshalAs(UnmanagedType.U1)] bool isForPrinting, [MarshalAs(UnmanagedType.Interface)] ref nsIWebProgressListener webProgressListener, [MarshalAs(UnmanagedType.Interface)] ref nsIPrintProgressParams printProgressParams, [MarshalAs(UnmanagedType.U1)] ref bool notifyOnOpen);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ShowPageSetup([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow parent, [MarshalAs(UnmanagedType.Interface)] nsIPrintSettings printSettings, [MarshalAs(UnmanagedType.Interface)] nsIObserver aObs);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ShowPrinterProperties([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow parent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string printerName, [MarshalAs(UnmanagedType.Interface)] nsIPrintSettings printSettings);
}
