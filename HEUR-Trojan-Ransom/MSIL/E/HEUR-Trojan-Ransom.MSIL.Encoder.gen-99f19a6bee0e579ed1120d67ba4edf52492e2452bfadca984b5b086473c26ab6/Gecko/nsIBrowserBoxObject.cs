using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("db436f2f-c656-4754-b0fa-99bc353bd63f")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIBrowserBoxObject : nsIContainerBoxObject
{
}
