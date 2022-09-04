using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace insomnia;

[ComImport]
[InterfaceType(1)]
[Guid("983DFC0B-1796-44DF-8975-CA545B620EE5")]
public interface Interface11
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Method1([In] int A_1, [In][MarshalAs(UnmanagedType.Interface)] Interface19 A_2, [In] ref Guid A_3);
}
