using System.Runtime.InteropServices;

namespace SHDocVw;

[ComVisible(false)]
[TypeLibType(16)]
public delegate void DWebBrowserEvents_PropertyChangeEventHandler([In][MarshalAs(UnmanagedType.BStr)] string Property);
