using System.Runtime.InteropServices;

namespace MSHelpServices;

[ComVisible(false)]
public delegate void IHxSessionEvents_IndexMergeStatusEventHandler([In][MarshalAs(UnmanagedType.IDispatch)] object pSession, [In][MarshalAs(UnmanagedType.IDispatch)] object pCancel, [In] int status);
