using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("c2229ce3-2159-4001-859c-7013c52f7619")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsINavHistoryResult
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	ushort GetSortingModeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSortingModeAttribute(ushort aSortingMode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSortingAnnotationAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aSortingAnnotation);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSortingAnnotationAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aSortingAnnotation);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetSuppressNotificationsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSuppressNotificationsAttribute([MarshalAs(UnmanagedType.U1)] bool aSuppressNotifications);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddObserver([MarshalAs(UnmanagedType.Interface)] nsINavHistoryResultObserver aObserver, [MarshalAs(UnmanagedType.U1)] bool aOwnsWeak);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveObserver([MarshalAs(UnmanagedType.Interface)] nsINavHistoryResultObserver aObserver);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsINavHistoryContainerResultNode GetRootAttribute();
}
