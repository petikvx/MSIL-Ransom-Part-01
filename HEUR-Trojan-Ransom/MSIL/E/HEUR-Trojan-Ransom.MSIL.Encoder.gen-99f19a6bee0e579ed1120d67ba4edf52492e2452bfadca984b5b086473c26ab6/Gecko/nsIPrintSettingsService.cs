using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("841387C8-72E6-484b-9296-BF6EEA80D58A")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIPrintSettingsService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIPrintSettings GetGlobalPrintSettingsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIPrintSettings GetNewPrintSettingsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
	string GetDefaultPrinterNameAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InitPrintSettingsFromPrinter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aPrinterName, [MarshalAs(UnmanagedType.Interface)] nsIPrintSettings aPrintSettings);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InitPrintSettingsFromPrefs([MarshalAs(UnmanagedType.Interface)] nsIPrintSettings aPrintSettings, [MarshalAs(UnmanagedType.U1)] bool aUsePrinterNamePrefix, uint aFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SavePrintSettingsToPrefs([MarshalAs(UnmanagedType.Interface)] nsIPrintSettings aPrintSettings, [MarshalAs(UnmanagedType.U1)] bool aUsePrinterNamePrefix, uint aFlags);
}
