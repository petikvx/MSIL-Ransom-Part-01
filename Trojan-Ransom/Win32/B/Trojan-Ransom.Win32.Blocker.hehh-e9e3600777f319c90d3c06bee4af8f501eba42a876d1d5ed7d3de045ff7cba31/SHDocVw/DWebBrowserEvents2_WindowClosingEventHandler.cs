using System.Runtime.InteropServices;

namespace SHDocVw;

[ComVisible(false)]
[TypeLibType(16)]
public delegate void DWebBrowserEvents2_WindowClosingEventHandler([In] bool IsChildWindow, [In][Out] ref bool Cancel);
