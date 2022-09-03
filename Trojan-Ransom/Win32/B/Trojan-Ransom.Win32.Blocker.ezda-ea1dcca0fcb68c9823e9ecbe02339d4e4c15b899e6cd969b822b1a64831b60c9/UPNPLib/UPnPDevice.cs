using System.Runtime.InteropServices;

namespace UPNPLib;

[ComImport]
[Guid("3D44D0D1-98C9-4889-ACD1-F9D674BF2221")]
[CoClass(typeof(UPnPDeviceClass))]
public interface UPnPDevice : IUPnPDevice
{
}
