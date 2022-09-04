using System.Runtime.InteropServices;

namespace SHDocVw;

[TypeLibType(16)]
[ComVisible(false)]
public delegate void DWebBrowserEvents2_DocumentCompleteEventHandler([In][MarshalAs(UnmanagedType.IDispatch)] object pDisp, [In][MarshalAs(UnmanagedType.Struct)] ref object URL);
