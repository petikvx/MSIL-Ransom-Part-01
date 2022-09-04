using System.Runtime.InteropServices;

namespace SHDocVw;

[ComImport]
[CoClass(typeof(ShellWindowsClass))]
[Guid("85CB6900-4D95-11CF-960C-0080C7F4EE85")]
public interface ShellWindows : IShellWindows, DShellWindowsEvents_Event
{
}
