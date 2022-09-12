using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("b33684e2-090c-4e1d-a3d9-f4b46f4237b9")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIAccessibleHyperText
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetLinkCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIAccessibleHyperLink GetLinkAt(int index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetLinkIndex([MarshalAs(UnmanagedType.Interface)] nsIAccessibleHyperLink link);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetLinkIndexAtOffset(int offset);
}
