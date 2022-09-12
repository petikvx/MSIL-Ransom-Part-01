using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("237f85a2-1dd2-11b2-94af-8122582fc45e")]
public interface nsIRDFBlob : nsIRDFNode
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool EqualsNode([MarshalAs(UnmanagedType.Interface)] nsIRDFNode aNode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetValueAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetLengthAttribute();
}
