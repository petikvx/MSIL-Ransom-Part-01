using System.Runtime.InteropServices;

namespace SHDocVw;

[TypeLibType(16)]
[ComVisible(false)]
public delegate void DWebBrowserEvents_FrameBeforeNavigateEventHandler([In][MarshalAs(UnmanagedType.BStr)] string URL, int Flags, [MarshalAs(UnmanagedType.BStr)] string TargetFrameName, [MarshalAs(UnmanagedType.Struct)] ref object PostData, [MarshalAs(UnmanagedType.BStr)] string Headers, [In][Out] ref bool Cancel);
