using System.Runtime.InteropServices;

namespace SHDocVw;

[TypeLibType(16)]
[ComVisible(false)]
public delegate void DWebBrowserEvents_StatusTextChangeEventHandler([In][MarshalAs(UnmanagedType.BStr)] string Text);
