using System.Runtime.InteropServices;

namespace SHDocVw;

[ComImport]
[CoClass(typeof(ShellNameSpaceClass))]
[Guid("E572D3C9-37BE-4AE2-825D-D521763E3108")]
public interface ShellNameSpace : IShellNameSpace, DShellNameSpaceEvents_Event
{
}
