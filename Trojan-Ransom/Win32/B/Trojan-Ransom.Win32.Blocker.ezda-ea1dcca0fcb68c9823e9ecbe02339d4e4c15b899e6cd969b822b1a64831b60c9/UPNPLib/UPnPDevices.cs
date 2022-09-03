using System.Runtime.InteropServices;

namespace UPNPLib;

[ComImport]
[CoClass(typeof(UPnPDevicesClass))]
[Guid("FDBC0C73-BDA3-4C66-AC4F-F2D96FDAD68C")]
public interface UPnPDevices : IUPnPDevices
{
}
