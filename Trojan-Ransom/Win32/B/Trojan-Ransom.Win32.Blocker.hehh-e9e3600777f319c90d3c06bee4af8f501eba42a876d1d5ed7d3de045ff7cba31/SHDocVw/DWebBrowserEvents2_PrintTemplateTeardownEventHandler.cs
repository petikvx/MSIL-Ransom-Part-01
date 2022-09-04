using System.Runtime.InteropServices;

namespace SHDocVw;

[ComVisible(false)]
[TypeLibType(16)]
public delegate void DWebBrowserEvents2_PrintTemplateTeardownEventHandler([In][MarshalAs(UnmanagedType.IDispatch)] object pDisp);
