using System.Runtime.InteropServices;

namespace SHDocVw;

[ComVisible(false)]
[TypeLibType(16)]
public delegate void DWebBrowserEvents2_NewWindow2EventHandler([In][Out][MarshalAs(UnmanagedType.IDispatch)] ref object ppDisp, [In][Out] ref bool Cancel);
