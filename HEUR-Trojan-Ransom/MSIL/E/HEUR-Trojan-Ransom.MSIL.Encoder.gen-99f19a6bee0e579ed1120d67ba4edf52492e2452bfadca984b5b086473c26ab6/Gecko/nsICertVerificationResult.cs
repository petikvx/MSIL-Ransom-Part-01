using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("2fd0a785-9f2d-4327-8871-8c3e0783891d")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsICertVerificationResult
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetUsagesArrayResult(ref uint verified, ref uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ref IntPtr[] usages);
}
