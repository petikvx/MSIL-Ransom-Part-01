using System.Runtime.InteropServices;

namespace UPNPLib;

[ComImport]
[Guid("ADDA3D55-6F72-4319-BFF9-18600A539B10")]
[CoClass(typeof(UPnPDeviceFinderClass))]
public interface UPnPDeviceFinder : IUPnPDeviceFinder
{
}
