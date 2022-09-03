using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UPNPLib;

[ComImport]
[Guid("983DFC0B-1796-44DF-8975-CA545B620EE5")]
[InterfaceType(1)]
public interface IUPnPDeviceFinderAddCallbackWithInterface
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeviceAddedWithInterface([In] int int_0, [In][MarshalAs(UnmanagedType.Interface)] UPnPDevice upnPDevice_0, [In] ref Guid guid_0);
}
