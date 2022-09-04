using System.Runtime.InteropServices;

namespace SHDocVw;

[ComVisible(false)]
[TypeLibType(16)]
public delegate void DWebBrowserEvents_CommandStateChangeEventHandler([In] int Command, [In] bool Enable);
