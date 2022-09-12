using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("883643d4-93a5-4f32-922c-6f06e01363c1")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIAccessibleHyperLink
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetStartIndexAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetEndIndexAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetValidAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetAnchorCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetURI(int index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIAccessible GetAnchor(int index);
}
