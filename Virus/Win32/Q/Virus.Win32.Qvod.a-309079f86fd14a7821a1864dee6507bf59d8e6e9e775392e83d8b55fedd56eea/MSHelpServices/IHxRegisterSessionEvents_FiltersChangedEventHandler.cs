using System.Runtime.InteropServices;

namespace MSHelpServices;

[ComVisible(false)]
public delegate void IHxRegisterSessionEvents_FiltersChangedEventHandler([In][MarshalAs(UnmanagedType.IDispatch)] object pDisp, [In][MarshalAs(UnmanagedType.Struct)] ref object pvar);
