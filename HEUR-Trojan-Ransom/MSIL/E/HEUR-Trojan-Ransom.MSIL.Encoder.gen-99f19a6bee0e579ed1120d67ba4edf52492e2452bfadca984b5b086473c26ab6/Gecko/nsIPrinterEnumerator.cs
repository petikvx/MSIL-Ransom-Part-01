using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("5e738fff-404c-4c94-9189-e8f2cce93e94")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIPrinterEnumerator
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
	string GetDefaultPrinterNameAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InitPrintSettingsFromPrinter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aPrinterName, [MarshalAs(UnmanagedType.Interface)] nsIPrintSettings aPrintSettings);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIStringEnumerator GetPrinterNameListAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DisplayPropertiesDlg([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aPrinter, [MarshalAs(UnmanagedType.Interface)] nsIPrintSettings aPrintSettings);
}
