using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("44E314CA-75B1-4f3d-9553-9B3507912108")]
public interface nsIPrintingPrompt
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void ShowPrintDialog([MarshalAs(UnmanagedType.Interface)] nsIWebBrowserPrint webBrowserPrint, [MarshalAs(UnmanagedType.Interface)] nsIPrintSettings printSettings);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ShowProgress([MarshalAs(UnmanagedType.Interface)] nsIWebBrowserPrint webBrowserPrint, [MarshalAs(UnmanagedType.Interface)] nsIPrintSettings printSettings, [MarshalAs(UnmanagedType.Interface)] nsIObserver openDialogObserver, [MarshalAs(UnmanagedType.U1)] bool isForPrinting, [MarshalAs(UnmanagedType.Interface)] ref nsIWebProgressListener webProgressListener, [MarshalAs(UnmanagedType.Interface)] ref nsIPrintProgressParams printProgressParams, [MarshalAs(UnmanagedType.U1)] ref bool notifyOnOpen);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ShowPageSetup([MarshalAs(UnmanagedType.Interface)] nsIPrintSettings printSettings, [MarshalAs(UnmanagedType.Interface)] nsIObserver aObs);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ShowPrinterProperties([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string printerName, [MarshalAs(UnmanagedType.Interface)] nsIPrintSettings printSettings);
}
