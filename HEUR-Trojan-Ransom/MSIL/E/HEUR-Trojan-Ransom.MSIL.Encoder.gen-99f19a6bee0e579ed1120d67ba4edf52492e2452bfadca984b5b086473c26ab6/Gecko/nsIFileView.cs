using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("60b320d2-1dd2-11b2-bd73-dc3575f78ddd")]
public interface nsIFileView
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetShowHiddenFilesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetShowHiddenFilesAttribute([MarshalAs(UnmanagedType.U1)] bool aShowHiddenFiles);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetShowOnlyDirectoriesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetShowOnlyDirectoriesAttribute([MarshalAs(UnmanagedType.U1)] bool aShowOnlyDirectories);

	[MethodImpl(MethodImplOptions.InternalCall)]
	short GetSortTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetReverseSortAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Sort(short sortType, [MarshalAs(UnmanagedType.U1)] bool reverseSort);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDirectory([MarshalAs(UnmanagedType.Interface)] nsIFile directory);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetFilter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase filterString);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIArray GetSelectedFilesAttribute();
}
