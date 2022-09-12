using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("bd9dc0fa-68ce-47d0-8859-6418c2ae8576")]
public interface nsIAuthPromptProvider
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetAuthPrompt(uint aPromptReason, ref Guid iid);
}
