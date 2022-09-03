using System.Runtime.InteropServices;

namespace UPNPLib;

[ComImport]
[CoClass(typeof(UPnPServiceClass))]
[Guid("A295019C-DC65-47DD-90DC-7FE918A1AB44")]
public interface UPnPService : IUPnPService
{
}
