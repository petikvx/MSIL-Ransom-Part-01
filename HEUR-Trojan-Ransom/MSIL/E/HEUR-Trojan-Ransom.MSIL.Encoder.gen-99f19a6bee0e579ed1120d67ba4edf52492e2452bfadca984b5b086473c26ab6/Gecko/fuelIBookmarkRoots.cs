using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("c9a80870-eb3c-11dc-95ff-0800200c9a66")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface fuelIBookmarkRoots
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	fuelIBookmarkFolder GetMenuAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	fuelIBookmarkFolder GetToolbarAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	fuelIBookmarkFolder GetTagsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	fuelIBookmarkFolder GetUnfiledAttribute();
}
