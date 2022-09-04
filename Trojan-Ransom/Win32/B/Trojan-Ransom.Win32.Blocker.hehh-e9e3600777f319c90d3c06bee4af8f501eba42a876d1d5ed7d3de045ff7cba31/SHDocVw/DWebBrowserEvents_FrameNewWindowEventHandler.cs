using System.Runtime.InteropServices;

namespace SHDocVw;

[ComVisible(false)]
[TypeLibType(16)]
public delegate void DWebBrowserEvents_FrameNewWindowEventHandler([In][MarshalAs(UnmanagedType.BStr)] string URL, [In] int Flags, [In][MarshalAs(UnmanagedType.BStr)] string TargetFrameName, [In][MarshalAs(UnmanagedType.Struct)] ref object PostData, [In][MarshalAs(UnmanagedType.BStr)] string Headers, [In][Out] ref bool Processed);
