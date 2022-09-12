using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("8c589e65-3237-4cd1-8bad-c5c47135e79b")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDOMWindowInternal : nsIDOMWindow
{
}
