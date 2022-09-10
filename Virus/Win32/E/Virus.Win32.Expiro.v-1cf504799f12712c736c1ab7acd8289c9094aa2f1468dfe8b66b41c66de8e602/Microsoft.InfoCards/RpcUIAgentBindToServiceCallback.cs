using System;
using System.Runtime.InteropServices;

namespace Microsoft.InfoCards;

internal delegate void RpcUIAgentBindToServiceCallback([In] IntPtr uiagentRpcHandle, [In] IntPtr nativeDesktopName, [In] int cbUserSid, [In] IntPtr pUserSid, [In] int cbTrustedSid, [In] IntPtr pTrustedSid, out IntPtr nativeStartEventHandle, out IntPtr nativeCompleteEventHandle, out RpcUIAgentGetWorkCallback callback);
