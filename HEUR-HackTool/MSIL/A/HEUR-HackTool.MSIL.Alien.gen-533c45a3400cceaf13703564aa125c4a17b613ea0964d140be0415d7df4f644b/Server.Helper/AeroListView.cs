using System;
using System.Collections;
using System.Windows.Forms;

namespace Server.Helper;

internal class AeroListView : ListView
{
	private const uint WM_CHANGEUISTATE = 295u;

	private const short UIS_SET = 1;

	private const short UISF_HIDEFOCUS = 1;

	private readonly IntPtr _removeDots = new IntPtr(MakeWin32Long(1, 1));

	private ListViewColumnSorter LvwColumnSorter { get; set; }

	public static int MakeWin32Long(short wLow, short wHigh)
	{
		return (wLow << 16) | wHigh;
	}

	public AeroListView()
	{
		((Control)this).SetStyle((ControlStyles)139264, true);
		LvwColumnSorter = new ListViewColumnSorter();
		((ListView)this).set_ListViewItemSorter((IComparer)LvwColumnSorter);
		((ListView)this).set_View((View)1);
		((ListView)this).set_FullRowSelect(true);
	}

	protected override void OnHandleCreated(EventArgs e)
	{
		((ListView)this).OnHandleCreated(e);
		if (Environment.OSVersion.Platform == PlatformID.Win32NT && Environment.OSVersion.Version.Major >= 6)
		{
			NativeMethods.SetWindowTheme(((Control)this).get_Handle(), "explorer", null);
		}
		if (Environment.OSVersion.Platform == PlatformID.Win32NT && Environment.OSVersion.Version.Major >= 5)
		{
			NativeMethods.SendMessage(((Control)this).get_Handle(), 295u, _removeDots, IntPtr.Zero);
		}
	}

	protected override void OnColumnClick(ColumnClickEventArgs e)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Invalid comparison between Unknown and I4
		((ListView)this).OnColumnClick(e);
		if (e.get_Column() == LvwColumnSorter.SortColumn)
		{
			LvwColumnSorter.Order = (SortOrder)(((int)LvwColumnSorter.Order != 1) ? 1 : 2);
		}
		else
		{
			LvwColumnSorter.SortColumn = e.get_Column();
			LvwColumnSorter.Order = (SortOrder)1;
		}
		if (!((ListView)this).get_VirtualMode())
		{
			((ListView)this).Sort();
		}
	}
}
