using System.Runtime.InteropServices;

namespace SHDocVw;

[ComImport]
[Guid("E572D3C9-37BE-4AE2-825D-D521763E3108")]
[CoClass(typeof(ShellShellNameSpaceClass))]
public interface ShellShellNameSpace : IShellNameSpace, DShellNameSpaceEvents_Event
{
}
