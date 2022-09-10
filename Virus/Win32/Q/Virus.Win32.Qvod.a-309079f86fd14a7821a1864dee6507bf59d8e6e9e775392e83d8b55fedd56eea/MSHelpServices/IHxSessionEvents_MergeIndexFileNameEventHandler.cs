using System.Runtime.InteropServices;

namespace MSHelpServices;

[ComVisible(false)]
public delegate void IHxSessionEvents_MergeIndexFileNameEventHandler([In][MarshalAs(UnmanagedType.IDispatch)] object pDisp, [In][MarshalAs(UnmanagedType.BStr)] string bstrFile);
