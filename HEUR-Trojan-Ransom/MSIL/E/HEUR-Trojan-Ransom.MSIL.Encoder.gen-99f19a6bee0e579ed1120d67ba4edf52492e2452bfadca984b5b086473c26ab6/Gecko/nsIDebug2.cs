using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("9641dc15-10fb-42e3-a285-18be90a5c10b")]
public interface nsIDebug2
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsDebugBuildAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetAssertionCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsDebuggerAttachedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Assertion([MarshalAs(UnmanagedType.LPStr)] string aStr, [MarshalAs(UnmanagedType.LPStr)] string aExpr, [MarshalAs(UnmanagedType.LPStr)] string aFile, int aLine);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Warning([MarshalAs(UnmanagedType.LPStr)] string aStr, [MarshalAs(UnmanagedType.LPStr)] string aFile, int aLine);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Break([MarshalAs(UnmanagedType.LPStr)] string aFile, int aLine);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Abort([MarshalAs(UnmanagedType.LPStr)] string aFile, int aLine);
}
