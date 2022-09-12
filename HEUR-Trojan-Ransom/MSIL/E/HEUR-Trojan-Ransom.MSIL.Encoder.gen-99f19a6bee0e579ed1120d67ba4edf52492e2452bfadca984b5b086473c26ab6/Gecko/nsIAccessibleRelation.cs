using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("55b308c4-2ae4-46bc-b4cd-4d4370e0a660")]
public interface nsIAccessibleRelation
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetRelationTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetTargetsCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIAccessible GetTarget(uint index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIArray GetTargets();
}
