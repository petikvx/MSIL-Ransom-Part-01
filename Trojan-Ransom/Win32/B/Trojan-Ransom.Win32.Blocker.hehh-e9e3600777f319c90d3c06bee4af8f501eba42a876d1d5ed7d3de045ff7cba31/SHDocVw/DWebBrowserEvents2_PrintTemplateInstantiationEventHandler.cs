using System.Runtime.InteropServices;

namespace SHDocVw;

[ComVisible(false)]
[TypeLibType(16)]
public delegate void DWebBrowserEvents2_PrintTemplateInstantiationEventHandler([In][MarshalAs(UnmanagedType.IDispatch)] object pDisp);
