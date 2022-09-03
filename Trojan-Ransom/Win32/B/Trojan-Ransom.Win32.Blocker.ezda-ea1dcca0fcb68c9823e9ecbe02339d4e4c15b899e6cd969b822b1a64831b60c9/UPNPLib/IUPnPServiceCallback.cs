using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UPNPLib;

[ComImport]
[InterfaceType(1)]
[Guid("31FADCA9-AB73-464B-B67D-5C1D0F83C8B8")]
public interface IUPnPServiceCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void StateVariableChanged([In][MarshalAs(UnmanagedType.Interface)] UPnPService upnPService_0, [In][MarshalAs(UnmanagedType.LPWStr)] string string_0, [In][MarshalAs(UnmanagedType.Struct)] object object_0);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ServiceInstanceDied([In][MarshalAs(UnmanagedType.Interface)] UPnPService upnPService_0);
}
