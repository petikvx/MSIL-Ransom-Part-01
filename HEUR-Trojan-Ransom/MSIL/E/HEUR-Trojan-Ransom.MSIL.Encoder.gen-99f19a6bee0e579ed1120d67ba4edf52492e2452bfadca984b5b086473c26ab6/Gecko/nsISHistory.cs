using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("7b807041-e60a-4384-935f-af3061d8b815")]
public interface nsISHistory
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetIndexAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetRequestedIndexAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetMaxLengthAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetMaxLengthAttribute(int aMaxLength);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISHEntry GetEntryAtIndex(int index, [MarshalAs(UnmanagedType.U1)] bool modifyIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void PurgeHistory(int numEntries);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddSHistoryListener([MarshalAs(UnmanagedType.Interface)] nsISHistoryListener aListener);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveSHistoryListener([MarshalAs(UnmanagedType.Interface)] nsISHistoryListener aListener);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISimpleEnumerator GetSHistoryEnumeratorAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ReloadCurrentEntry();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetIndexOfEntry([MarshalAs(UnmanagedType.Interface)] nsISHEntry aEntry);
}
