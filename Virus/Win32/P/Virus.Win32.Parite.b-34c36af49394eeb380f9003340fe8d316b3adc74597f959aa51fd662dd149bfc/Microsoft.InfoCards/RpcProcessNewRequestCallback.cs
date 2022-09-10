using System;
using System.Runtime.InteropServices;

namespace Microsoft.InfoCards;

internal delegate int RpcProcessNewRequestCallback([In] int parentRequestHandle, [In] IntPtr rpcHandle, [In] IntPtr inArgs, out IntPtr outArgs);
