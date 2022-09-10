using System;
using System.Runtime.InteropServices;

namespace Microsoft.InfoCards;

internal delegate uint RpcAuthorizeCallback([In] IntPtr rpcIfHandle, [In] IntPtr Context);
