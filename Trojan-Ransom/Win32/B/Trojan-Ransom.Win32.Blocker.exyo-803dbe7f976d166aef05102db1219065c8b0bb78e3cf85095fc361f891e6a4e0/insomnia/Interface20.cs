using System.Runtime.InteropServices;
using UPNPLib;

namespace insomnia;

[ComImport]
[CoClass(typeof(UPnPDeviceFinderClass))]
[Guid("ADDA3D55-6F72-4319-BFF9-18600A539B10")]
public interface Interface20 : Interface10
{
}
