using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

internal sealed class Class5
{
	private struct Struct2
	{
		public int int_0;

		public int int_1;

		public IntPtr intptr_0;

		public Struct3 struct3_0;
	}

	private struct Struct3
	{
		public int int_0;

		public int int_1;
	}

	[DllImport("user32.dll")]
	private static extern bool DrawIcon(IntPtr intptr_0, int int_0, int int_1, IntPtr intptr_1);

	[DllImport("user32.dll")]
	private static extern bool GetCursorInfo(out Struct2 struct2_0);

	public Bitmap method_0(int int_0)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected O, but got Unknown
		Struct2 struct2_ = default(Struct2);
		int width = Screen.get_PrimaryScreen().get_Bounds().Width;
		Bitmap val = new Bitmap(width, Screen.get_PrimaryScreen().get_Bounds().Height, (PixelFormat)137224);
		try
		{
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			try
			{
				val2.CopyFromScreen(0, 0, 0, 0, Screen.get_PrimaryScreen().get_Bounds().Size, (CopyPixelOperation)13369376);
				struct2_.int_0 = Marshal.SizeOf(typeof(Struct2));
				if (GetCursorInfo(out struct2_) && struct2_.int_1 == 1)
				{
					DrawIcon(val2.GetHdc(), struct2_.struct3_0.int_0, struct2_.struct3_0.int_1, struct2_.intptr_0);
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
		int height = ((Image)val).get_Height() * (int_0 * 100 / ((Image)val).get_Height()) / 100;
		int width2 = int_0 + int_0 * 100 / ((Image)val).get_Width() * int_0 / 100 + 100;
		return new Bitmap((Image)(object)val, new Size(width2, height));
	}
}
