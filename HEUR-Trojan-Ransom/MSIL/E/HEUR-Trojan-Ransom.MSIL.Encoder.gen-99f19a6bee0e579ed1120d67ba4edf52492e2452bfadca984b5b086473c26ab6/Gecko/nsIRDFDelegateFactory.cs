using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("A1B89470-A124-11d3-BE59-0020A6361667")]
public interface nsIRDFDelegateFactory
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr CreateDelegate([MarshalAs(UnmanagedType.Interface)] nsIRDFResource aOuter, [MarshalAs(UnmanagedType.LPStr)] string aKey, ref Guid aIID);
}
