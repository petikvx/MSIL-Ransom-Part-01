using System.Runtime.InteropServices;

namespace SHDocVw;

[TypeLibType(16)]
[ComVisible(false)]
public delegate void DWebBrowserEvents2_ClientToHostWindowEventHandler([In][Out] ref int CX, [In][Out] ref int CY);
