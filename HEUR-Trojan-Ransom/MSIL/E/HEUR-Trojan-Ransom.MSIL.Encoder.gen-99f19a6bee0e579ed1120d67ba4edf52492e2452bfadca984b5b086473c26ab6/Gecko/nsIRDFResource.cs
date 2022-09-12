using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("fb9686a7-719a-49dc-9107-10dea5739341")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIRDFResource : nsIRDFNode
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool EqualsNode([MarshalAs(UnmanagedType.Interface)] nsIRDFNode aNode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.LPStr)]
	string GetValueAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetValueUTF8Attribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aValueUTF8);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetValueConst([MarshalAs(UnmanagedType.LPStr)] ref string aConstValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init([MarshalAs(UnmanagedType.LPStr)] string uri);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool EqualsString([MarshalAs(UnmanagedType.LPStr)] string aURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetDelegate([MarshalAs(UnmanagedType.LPStr)] string aKey, ref Guid aIID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ReleaseDelegate([MarshalAs(UnmanagedType.LPStr)] string aKey);
}
