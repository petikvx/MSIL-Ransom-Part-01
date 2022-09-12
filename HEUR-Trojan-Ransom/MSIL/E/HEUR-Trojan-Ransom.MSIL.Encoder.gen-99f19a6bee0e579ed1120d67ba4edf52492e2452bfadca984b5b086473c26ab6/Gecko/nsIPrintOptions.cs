using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("2ac74034-700e-40fd-8059-81d33223af58")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIPrintOptions
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void ShowPrintSetupDialog([MarshalAs(UnmanagedType.Interface)] nsIPrintSettings aThePrintSettings);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIPrintSettings CreatePrintSettings();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetPrinterPrefInt([MarshalAs(UnmanagedType.Interface)] nsIPrintSettings aPrintSettings, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aPrefName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DisplayJobProperties([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aPrinter, [MarshalAs(UnmanagedType.Interface)] nsIPrintSettings aPrintSettings, [MarshalAs(UnmanagedType.U1)] ref bool aDisplayed);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetNativeData(short aDataType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SerializeToPrintData([MarshalAs(UnmanagedType.Interface)] nsIPrintSettings aPrintSettings, [MarshalAs(UnmanagedType.Interface)] nsIWebBrowserPrint aWebBrowserPrint, IntPtr data);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeserializeToPrintSettings(IntPtr data, [MarshalAs(UnmanagedType.Interface)] nsIPrintSettings aPrintSettings);
}
