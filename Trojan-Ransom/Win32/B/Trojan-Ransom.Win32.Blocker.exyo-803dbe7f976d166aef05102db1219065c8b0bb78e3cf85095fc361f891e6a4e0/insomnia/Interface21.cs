using System.Runtime.InteropServices;
using UPNPLib;

namespace insomnia;

[ComImport]
[CoClass(typeof(UPnPDevicesClass))]
[Guid("FDBC0C73-BDA3-4C66-AC4F-F2D96FDAD68C")]
public interface Interface21 : Interface13
{
}
