using System.Runtime.InteropServices;

namespace SHDocVw;

[ComVisible(false)]
[TypeLibType(16)]
public delegate void DWebBrowserEvents2_NavigateErrorEventHandler([In][MarshalAs(UnmanagedType.IDispatch)] object pDisp, [In][MarshalAs(UnmanagedType.Struct)] ref object URL, [In][MarshalAs(UnmanagedType.Struct)] ref object Frame, [In][MarshalAs(UnmanagedType.Struct)] ref object StatusCode, [In][Out] ref bool Cancel);
