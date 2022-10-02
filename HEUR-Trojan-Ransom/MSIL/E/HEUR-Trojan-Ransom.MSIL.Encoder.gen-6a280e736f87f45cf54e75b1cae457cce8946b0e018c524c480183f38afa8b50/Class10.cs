using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

internal class Class10 : TextBox
{
	private static List<WeakReference> list_0;

	[DebuggerNonUserCode]
	static Class10()
	{
		Class14.vPNVHkezq0oMI();
		list_0 = new List<WeakReference>();
	}

	[DebuggerNonUserCode]
	private static void smethod_0(object object_0)
	{
		checked
		{
			lock (list_0)
			{
				if (list_0.Count == list_0.Capacity)
				{
					int num = 0;
					int num2 = list_0.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = list_0[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								list_0[num] = list_0[num3];
							}
							num++;
						}
						num3++;
					}
					list_0.RemoveRange(num, list_0.Count - num);
					list_0.Capacity = list_0.Count;
				}
				list_0.Add(new WeakReference(RuntimeHelpers.GetObjectValue(object_0)));
			}
		}
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetWindowDC(IntPtr intptr_0);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int ReleaseDC(IntPtr intptr_0, IntPtr intptr_1);

	protected override void WndProc(ref Message m)
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		((TextBox)this).WndProc(ref m);
		checked
		{
			if (((Message)(ref m)).get_Msg() == 15)
			{
				Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
				IntPtr windowDC = GetWindowDC(((Control)this).get_Handle());
				Graphics val = Graphics.FromHdc(windowDC);
				Pen black = Pens.get_Black();
				Rectangle rectangle2 = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
				val.DrawRectangle(black, rectangle2);
				Pen val2 = new Pen(Color.FromArgb(40, 40, 40));
				rectangle2 = new Rectangle(1, 1, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 3);
				val.DrawRectangle(val2, rectangle2);
				ReleaseDC(((Control)this).get_Handle(), windowDC);
				val.Dispose();
			}
		}
	}

	public Class10()
	{
		Class14.vPNVHkezq0oMI();
		((TextBox)this)._002Ector();
		smethod_0(this);
		((TextBoxBase)this).set_DoubleBuffered(true);
		((TextBoxBase)this).set_BackColor(Color.FromArgb(20, 20, 20));
		((TextBoxBase)this).set_ForeColor(Color.Orange);
		((TextBox)this).set_Text(((TextBox)this).get_Text());
		((Control)this).SetStyle((ControlStyles)65536, true);
	}
}
