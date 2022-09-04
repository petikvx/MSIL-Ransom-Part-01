using System.Runtime.InteropServices;
using UPNPLib;

namespace insomnia;

[ComImport]
[Guid("3D44D0D1-98C9-4889-ACD1-F9D674BF2221")]
[CoClass(typeof(UPnPDeviceClass))]
public interface Interface19 : Interface7
{
}
