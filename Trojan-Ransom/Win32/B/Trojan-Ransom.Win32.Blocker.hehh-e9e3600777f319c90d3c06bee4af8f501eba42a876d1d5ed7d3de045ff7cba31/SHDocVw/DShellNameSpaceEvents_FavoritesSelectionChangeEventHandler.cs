using System.Runtime.InteropServices;

namespace SHDocVw;

[ComVisible(false)]
[TypeLibType(16)]
public delegate void DShellNameSpaceEvents_FavoritesSelectionChangeEventHandler([In] int cItems, [In] int hItem, [In][MarshalAs(UnmanagedType.BStr)] string strName, [In][MarshalAs(UnmanagedType.BStr)] string strUrl, [In] int cVisits, [In][MarshalAs(UnmanagedType.BStr)] string strDate, [In] int fAvailableOffline);
