using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ns3;

internal sealed class Class10
{
	private struct Struct0
	{
		public int int_0;

		public int int_1;
	}

	private struct Struct1
	{
		public int int_0;

		public int int_1;

		public IntPtr intptr_0;

		public Struct0 struct0_0;
	}

	[DllImport("user32.dll")]
	private static extern bool DrawIcon(IntPtr intptr_0, int int_0, int int_1, IntPtr intptr_1);

	public Bitmap method_0(int int_0)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		Bitmap val = new Bitmap(Screen.get_PrimaryScreen().get_Bounds().Width, Screen.get_PrimaryScreen().get_Bounds().Height, (PixelFormat)137224);
		try
		{
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			try
			{
				val2.CopyFromScreen(0, 0, 0, 0, Screen.get_PrimaryScreen().get_Bounds().Size, (CopyPixelOperation)13369376);
				Struct1 struct1_ = default(Struct1);
				struct1_.int_0 = Marshal.SizeOf(typeof(Struct1));
				if (GetCursorInfo(out struct1_) && struct1_.int_1 == 1)
				{
					DrawIcon(val2.GetHdc(), struct1_.struct0_0.int_0, struct1_.struct0_0.int_1, struct1_.intptr_0);
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
		int width = int_0 + int_0 * 100 / ((Image)val).get_Width() * int_0 / 100 + 100;
		return new Bitmap((Image)(object)val, new Size(width, height));
	}

	[DllImport("user32.dll")]
	private static extern bool GetCursorInfo(out Struct1 struct1_0);
}
