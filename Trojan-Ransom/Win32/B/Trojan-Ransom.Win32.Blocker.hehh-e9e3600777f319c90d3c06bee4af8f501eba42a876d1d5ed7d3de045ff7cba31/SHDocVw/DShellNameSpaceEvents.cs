using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SHDocVw;

[ComImport]
[TypeLibType(4096)]
[InterfaceType(2)]
[Guid("55136806-B2DE-11D1-B9F2-00A0C98BC547")]
public interface DShellNameSpaceEvents
{
	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
	[DispId(1)]
	void FavoritesSelectionChange([In] int cItems, [In] int hItem, [In][MarshalAs(UnmanagedType.BStr)] string strName, [In][MarshalAs(UnmanagedType.BStr)] string strUrl, [In] int cVisits, [In][MarshalAs(UnmanagedType.BStr)] string strDate, [In] int fAvailableOffline);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
	[DispId(2)]
	void SelectionChange();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
	[DispId(3)]
	void DoubleClick();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
	[DispId(4)]
	void Initialized();
}
