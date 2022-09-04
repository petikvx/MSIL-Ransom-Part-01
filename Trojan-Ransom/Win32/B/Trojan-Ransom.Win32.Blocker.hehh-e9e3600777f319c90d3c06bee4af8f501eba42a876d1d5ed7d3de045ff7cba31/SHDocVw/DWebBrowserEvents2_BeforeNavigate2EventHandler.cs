using System.Runtime.InteropServices;

namespace SHDocVw;

[TypeLibType(16)]
[ComVisible(false)]
public delegate void DWebBrowserEvents2_BeforeNavigate2EventHandler([In][MarshalAs(UnmanagedType.IDispatch)] object pDisp, [In][MarshalAs(UnmanagedType.Struct)] ref object URL, [In][MarshalAs(UnmanagedType.Struct)] ref object Flags, [In][MarshalAs(UnmanagedType.Struct)] ref object TargetFrameName, [In][MarshalAs(UnmanagedType.Struct)] ref object PostData, [In][MarshalAs(UnmanagedType.Struct)] ref object Headers, [In][Out] ref bool Cancel);
