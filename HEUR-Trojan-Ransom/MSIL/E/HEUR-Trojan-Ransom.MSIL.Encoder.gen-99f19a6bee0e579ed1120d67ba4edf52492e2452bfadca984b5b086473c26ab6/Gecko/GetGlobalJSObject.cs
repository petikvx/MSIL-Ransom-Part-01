using System;
using System.Runtime.InteropServices;

namespace Gecko;

[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
internal delegate IntPtr GetGlobalJSObject([MarshalAs(UnmanagedType.Interface)] nsIGlobalObject @this);
