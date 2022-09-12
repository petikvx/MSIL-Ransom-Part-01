using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("948A0023-E3A7-11d2-96CF-0060B0FB9956")]
public interface nsIFormatConverter
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupportsArray GetInputDataFlavors();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupportsArray GetOutputDataFlavors();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool CanConvert([MarshalAs(UnmanagedType.LPStr)] string aFromDataFlavor, [MarshalAs(UnmanagedType.LPStr)] string aToDataFlavor);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Convert([MarshalAs(UnmanagedType.LPStr)] string aFromDataFlavor, [MarshalAs(UnmanagedType.Interface)] nsISupports aFromData, uint aDataLen, [MarshalAs(UnmanagedType.LPStr)] string aToDataFlavor, [MarshalAs(UnmanagedType.Interface)] ref nsISupports aToData, ref uint aDataToLen);
}
