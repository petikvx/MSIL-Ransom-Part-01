using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FC2ServerLauncher;

public class ListViewImage : ListView
{
	public struct LV_ITEM
	{
		public uint mask;

		public int iItem;

		public int iSubItem;

		public uint state;

		public uint stateMask;

		public string pszText;

		public int cchTextMax;

		public int iImage;

		public IntPtr lParam;
	}

	public const int LVM_FIRST = 4096;

	public const int LVM_GETITEM = 4101;

	public const int LVM_SETITEM = 4102;

	public const int LVIF_TEXT = 1;

	public const int LVIF_IMAGE = 2;

	public const int LVW_FIRST = 4096;

	public const int LVM_GETEXTENDEDLISTVIEWSTYLE = 4150;

	public const int LVS_EX_GRIDLINES = 1;

	public const int LVS_EX_SUBITEMIMAGES = 2;

	public const int LVS_EX_CHECKBOXES = 4;

	public const int LVS_EX_TRACKSELECT = 8;

	public const int LVS_EX_HEADERDRAGDROP = 16;

	public const int LVS_EX_FULLROWSELECT = 32;

	public const int LVS_EX_ONECLICKACTIVATE = 64;

	public ListViewImage()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		Message val = default(Message);
		((Message)(ref val)).set_HWnd(((Control)this).get_Handle());
		((Message)(ref val)).set_Msg(4150);
		((Message)(ref val)).set_LParam((IntPtr)47);
		((Message)(ref val)).set_WParam(IntPtr.Zero);
		((Control)this).WndProc(ref val);
	}

	[DllImport("user32.dll")]
	public static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

	[DllImport("user32.dll")]
	public static extern bool SendMessage(IntPtr hWnd, int msg, int wParam, ref LV_ITEM lParam);
}
