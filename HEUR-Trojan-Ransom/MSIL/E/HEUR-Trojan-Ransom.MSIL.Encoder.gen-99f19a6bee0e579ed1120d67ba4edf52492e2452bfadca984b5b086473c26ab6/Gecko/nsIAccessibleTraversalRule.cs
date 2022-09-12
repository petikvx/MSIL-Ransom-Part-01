using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("e197460d-1eff-4247-b4bb-a43be1840dae")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIAccessibleTraversalRule
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetPreFilterAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetMatchRoles([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ref uint[] aRoles);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint Match([MarshalAs(UnmanagedType.Interface)] nsIAccessible aAccessible);
}
