using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("f2b1ab53-f0bd-4adb-9365-e59b1701a258")]
public interface nsIStreamConverterService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool CanConvert([MarshalAs(UnmanagedType.LPStr)] string aFromType, [MarshalAs(UnmanagedType.LPStr)] string aToType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIInputStream Convert([MarshalAs(UnmanagedType.Interface)] nsIInputStream aFromStream, [MarshalAs(UnmanagedType.LPStr)] string aFromType, [MarshalAs(UnmanagedType.LPStr)] string aToType, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIStreamListener AsyncConvertData([MarshalAs(UnmanagedType.LPStr)] string aFromType, [MarshalAs(UnmanagedType.LPStr)] string aToType, [MarshalAs(UnmanagedType.Interface)] nsIStreamListener aListener, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext);
}
