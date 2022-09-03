using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public sealed class GClass0
{
	private struct Struct0
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;
	}

	[DllImport("user32.dll")]
	private static extern bool GetWindowRect(IntPtr intptr_0, out Struct0 struct0_0);

	[DllImport("user32.dll")]
	private static extern int GetForegroundWindow();

	public Bitmap method_0()
	{
		return method_4(0, 0, Screen.get_PrimaryScreen().get_Bounds().Width, Screen.get_PrimaryScreen().get_Bounds().Height);
	}

	public Bitmap method_1(Point point_0, Point point_1)
	{
		return method_4(point_0.X, point_0.Y, point_1.X, point_1.Y);
	}

	public Bitmap method_2(IntPtr intptr_0)
	{
		return method_5(intptr_0);
	}

	public Bitmap method_3()
	{
		return method_5((IntPtr)GetForegroundWindow());
	}

	private Bitmap method_4(int int_0, int int_1, int int_2, int int_3)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		Bitmap val = new Bitmap(int_2, int_3);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		val2.CopyFromScreen(int_0, int_1, 0, 0, new Size(int_2, int_3));
		val2.Dispose();
		return val;
	}

	private Bitmap method_5(IntPtr intptr_0)
	{
		GetWindowRect(intptr_0, out var struct0_);
		return method_4(struct0_.int_0, struct0_.int_1, struct0_.int_2 - struct0_.int_0, struct0_.int_3 - struct0_.int_1);
	}
}
