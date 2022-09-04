using System.Runtime.InteropServices;

namespace SHDocVw;

[TypeLibType(16)]
[ComVisible(false)]
public delegate void DWebBrowserEvents_ProgressChangeEventHandler([In] int Progress, [In] int ProgressMax);
