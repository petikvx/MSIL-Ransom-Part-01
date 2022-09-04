using System.Runtime.InteropServices;

namespace SHDocVw;

[TypeLibType(16)]
[ComVisible(false)]
public delegate void DShellWindowsEvents_WindowRegisteredEventHandler([In] int lCookie);
