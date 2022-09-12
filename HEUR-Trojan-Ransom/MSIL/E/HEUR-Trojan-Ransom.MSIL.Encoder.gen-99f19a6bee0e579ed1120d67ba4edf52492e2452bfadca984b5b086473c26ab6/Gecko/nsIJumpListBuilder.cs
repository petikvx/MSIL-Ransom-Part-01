using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("1FE6A9CD-2B18-4dd5-A176-C2B32FA4F683")]
public interface nsIJumpListBuilder
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	short GetAvailableAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsListCommittedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	short GetMaxListItemsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool InitListBuild([MarshalAs(UnmanagedType.Interface)] nsIMutableArray removedItems);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool AddListToBuild(short aCatType, [MarshalAs(UnmanagedType.Interface)] nsIArray items, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase catName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AbortListBuild();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool CommitListBuild();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool DeleteActiveList();
}
