using System;
using System.Runtime.InteropServices;

namespace Microsoft.InfoCards;

internal delegate IntPtr RpcAllocMemCallback([In] IntPtr size);
