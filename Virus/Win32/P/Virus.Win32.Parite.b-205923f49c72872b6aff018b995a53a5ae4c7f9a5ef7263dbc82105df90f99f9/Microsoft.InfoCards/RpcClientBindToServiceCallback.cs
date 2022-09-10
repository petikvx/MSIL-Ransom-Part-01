using System;
using System.Runtime.InteropServices;

namespace Microsoft.InfoCards;

internal delegate int RpcClientBindToServiceCallback([In] IntPtr rpcHandle, out IntPtr context);
