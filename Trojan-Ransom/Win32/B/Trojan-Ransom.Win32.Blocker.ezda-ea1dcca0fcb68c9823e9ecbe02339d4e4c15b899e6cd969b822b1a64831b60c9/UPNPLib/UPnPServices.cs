using System.Runtime.InteropServices;

namespace UPNPLib;

[ComImport]
[Guid("3F8C8E9E-9A7A-4DC8-BC41-FF31FA374956")]
[CoClass(typeof(UPnPServicesClass))]
public interface UPnPServices : IUPnPServices
{
}
