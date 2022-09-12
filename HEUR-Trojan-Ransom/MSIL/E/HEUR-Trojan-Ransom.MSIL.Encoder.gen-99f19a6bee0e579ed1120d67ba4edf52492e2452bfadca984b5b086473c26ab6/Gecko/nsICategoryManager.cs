using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("3275b2cd-af6d-429a-80d7-f0c5120342ac")]
public interface nsICategoryManager
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.StringMarshaler")]
	string GetCategoryEntry([MarshalAs(UnmanagedType.LPStr)] string aCategory, [MarshalAs(UnmanagedType.LPStr)] string aEntry);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.StringMarshaler")]
	string AddCategoryEntry([MarshalAs(UnmanagedType.LPStr)] string aCategory, [MarshalAs(UnmanagedType.LPStr)] string aEntry, [MarshalAs(UnmanagedType.LPStr)] string aValue, [MarshalAs(UnmanagedType.U1)] bool aPersist, [MarshalAs(UnmanagedType.U1)] bool aReplace);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteCategoryEntry([MarshalAs(UnmanagedType.LPStr)] string aCategory, [MarshalAs(UnmanagedType.LPStr)] string aEntry, [MarshalAs(UnmanagedType.U1)] bool aPersist);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteCategory([MarshalAs(UnmanagedType.LPStr)] string aCategory);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISimpleEnumerator EnumerateCategory([MarshalAs(UnmanagedType.LPStr)] string aCategory);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISimpleEnumerator EnumerateCategories();
}
