using System.Runtime.InteropServices;

namespace SHDocVw;

[TypeLibType(16)]
[ComVisible(false)]
public delegate void DWebBrowserEvents_NewWindowEventHandler([In][MarshalAs(UnmanagedType.BStr)] string URL, [In] int Flags, [In][MarshalAs(UnmanagedType.BStr)] string TargetFrameName, [In][MarshalAs(UnmanagedType.Struct)] ref object PostData, [In][MarshalAs(UnmanagedType.BStr)] string Headers, [In][Out] ref bool Processed);
