using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UPNPLib;

[ComImport]
[InterfaceType(1)]
[Guid("415A984A-88B3-49F3-92AF-0508BEDF0D6C")]
public interface IUPnPDeviceFinderCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeviceAdded([In] int int_0, [In][MarshalAs(UnmanagedType.Interface)] UPnPDevice upnPDevice_0);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeviceRemoved([In] int int_0, [In][MarshalAs(UnmanagedType.BStr)] string string_0);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SearchComplete([In] int int_0);
}
