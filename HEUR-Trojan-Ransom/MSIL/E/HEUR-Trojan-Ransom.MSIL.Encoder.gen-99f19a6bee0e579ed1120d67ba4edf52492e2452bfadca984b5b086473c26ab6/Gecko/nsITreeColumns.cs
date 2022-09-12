using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("f8a8d6b4-6788-438d-9009-7142798767ab")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsITreeColumns
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsITreeBoxObject GetTreeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetLengthAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsITreeColumn GetFirstColumn();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsITreeColumn GetLastColumn();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsITreeColumn GetPrimaryColumn();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsITreeColumn GetSortedColumn();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsITreeColumn GetKeyColumn();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsITreeColumn GetColumnFor([MarshalAs(UnmanagedType.Interface)] nsIDOMElement element);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsITreeColumn GetNamedColumn([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase id);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsITreeColumn GetColumnAt(int index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InvalidateColumns();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RestoreNaturalOrder();
}
