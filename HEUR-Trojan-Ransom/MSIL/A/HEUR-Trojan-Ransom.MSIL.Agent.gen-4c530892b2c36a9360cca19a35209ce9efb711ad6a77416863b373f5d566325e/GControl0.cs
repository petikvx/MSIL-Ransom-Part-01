using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class GControl0 : UserControl
{
	private const int int_0 = 524288;

	private const int int_1 = 655360;

	private const int int_2 = 589824;

	private const int int_3 = 793;

	public static readonly int int_4 = 5;

	public static readonly int int_5 = 20;

	public static readonly int int_6 = 10;

	public static readonly int int_7 = 1;

	public static readonly Color color_0 = Color.Green;

	public static readonly Color color_1 = Color.Red;

	public static readonly Color color_2 = Color.Blue;

	private int int_8;

	private GEnum0 genum0_0 = GEnum0.Right;

	private List<Point> list_0;

	private const int int_9 = 10;

	private Point point_0;

	private Point point_1;

	private Graphics graphics_0;

	private bool bool_0;

	private IContainer icontainer_0 = null;

	private Timer timer_0;

	[DllImport("user32.dll")]
	public static extern IntPtr SendMessageW(IntPtr intptr_0, int int_10, IntPtr intptr_1, IntPtr intptr_2);

	private void method_0()
	{
		SendMessageW(this.method_12(), 793, this.method_12(), (IntPtr)524288);
	}

	private void method_1()
	{
		SendMessageW(this.method_12(), 793, this.method_12(), (IntPtr)589824);
	}

	private void method_2()
	{
		SendMessageW(this.method_12(), 793, this.method_12(), (IntPtr)655360);
	}

	public GControl0()
	{
		method_3();
		GControl0.smethod_0((Control)(object)this, Color.Black);
		GControl0.smethod_1((Control)(object)this, int_7 + int_5 * (int_6 + int_7));
		GControl0.smethod_2((Control)(object)this, int_7 + int_5 * (int_6 + int_7));
		method_11();
		GControl0.smethod_3(timer_0, 100);
		GControl0.smethod_4(timer_0);
	}

	private void method_3()
	{
		list_0 = new List<Point>();
		int_8 = int_4;
		bool_0 = false;
		list_0.Add(new Point(int_5 / 2, int_5 / 2));
		method_4();
		method_5();
	}

	private void method_4()
	{
		Random random_ = GControl0.smethod_5();
		Point point;
		do
		{
			point = new Point(GControl0.smethod_6(random_, int_5), GControl0.smethod_6(random_, int_5));
		}
		while (!(point != point_1) || list_0.Contains(point));
		point_0 = point;
	}

	private void method_5()
	{
		Random random_ = GControl0.smethod_5();
		Point point;
		do
		{
			point = new Point(GControl0.smethod_6(random_, int_5), GControl0.smethod_6(random_, int_5));
		}
		while (!(point != point_0) || list_0.Contains(point));
		point_1 = point;
	}

	private void method_6(Point point_2, Color color_3)
	{
		GControl0.smethod_9(graphics_0, GControl0.smethod_8(GControl0.smethod_7(color_3)), new Rectangle(int_7 + point_2.X * (int_7 + int_6), int_7 + point_2.Y * (int_7 + int_6), int_6, int_6));
	}

	private void method_7(object sender, EventArgs e)
	{
		method_3();
	}

	private void method_8(object sender, PaintEventArgs e)
	{
		graphics_0 = GControl0.smethod_10(e);
		GControl0.smethod_14(graphics_0, GControl0.smethod_11(), new Rectangle(0, 0, GControl0.smethod_12((Control)(object)this) - 1, GControl0.smethod_13((Control)(object)this) - 1));
		method_6(point_0, color_0);
		method_6(point_1, color_1);
		foreach (Point item in list_0)
		{
			method_6(item, color_2);
		}
	}

	private void method_9(object sender, EventArgs e)
	{
		int num = list_0[0].X;
		int num2 = list_0[0].Y;
		switch (genum0_0)
		{
		case GEnum0.Up:
			num2--;
			break;
		case GEnum0.Left:
			num--;
			break;
		case GEnum0.Down:
			num2++;
			break;
		case GEnum0.Right:
			num++;
			break;
		}
		if (num < 0)
		{
			num = int_5 - 1;
		}
		if (num > int_5 - 1)
		{
			num = 0;
		}
		if (num2 < 0)
		{
			num2 = int_5 - 1;
		}
		if (num2 > int_5 - 1)
		{
			num2 = 0;
		}
		Point point = new Point(num, num2);
		bool_0 = false;
		if (point == point_0)
		{
			method_2();
			method_4();
			int_8++;
		}
		if (point == point_1)
		{
			method_1();
			method_5();
			int_8++;
		}
		foreach (Point item in list_0)
		{
			if (item == point)
			{
				method_0();
				method_3();
				return;
			}
		}
		list_0.Reverse();
		list_0.Add(point);
		list_0.Reverse();
		if (int_8 == list_0.Count)
		{
			list_0.RemoveAt(list_0.Count - 1);
		}
		GControl0.smethod_15((Control)(object)this);
	}

	private void method_10(object sender, KeyEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between Unknown and I4
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Invalid comparison between Unknown and I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected I4, but got Unknown
		if (bool_0)
		{
			return;
		}
		Keys val = GControl0.smethod_16(e);
		Keys val2 = val;
		if ((int)val2 != 13 && (int)val2 != 27)
		{
			switch (val2 - 37)
			{
			case 0:
				if (genum0_0 != GEnum0.Right)
				{
					bool_0 = true;
					genum0_0 = GEnum0.Left;
				}
				break;
			case 1:
				if (genum0_0 != GEnum0.Down)
				{
					bool_0 = true;
					genum0_0 = GEnum0.Up;
				}
				break;
			case 2:
				if (genum0_0 != GEnum0.Left)
				{
					bool_0 = true;
					genum0_0 = GEnum0.Right;
				}
				break;
			case 3:
				if (genum0_0 != 0)
				{
					bool_0 = true;
					genum0_0 = GEnum0.Down;
				}
				break;
			}
		}
		else
		{
			GControl0.smethod_17();
		}
	}

	void ContainerControl.Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			GControl0.smethod_18((IDisposable)icontainer_0);
		}
		((ContainerControl)this).Dispose(disposing);
	}

	private void method_11()
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		icontainer_0 = GControl0.smethod_19();
		timer_0 = GControl0.smethod_20(icontainer_0);
		GControl0.smethod_21((Control)(object)this);
		GControl0.smethod_22(timer_0, (EventHandler)method_9);
		GControl0.smethod_23((ContainerControl)(object)this, new SizeF(6f, 13f));
		GControl0.smethod_24((ContainerControl)(object)this, (AutoScaleMode)1);
		((Control)this).set_DoubleBuffered(true);
		GControl0.smethod_25((Control)(object)this, "SnakeVolumeSlider");
		GControl0.smethod_26((UserControl)(object)this, (EventHandler)method_7);
		GControl0.smethod_27((Control)(object)this, new PaintEventHandler(method_8));
		GControl0.smethod_28((Control)(object)this, new KeyEventHandler(method_10));
		GControl0.smethod_29((Control)(object)this, bool_1: false);
	}

	IntPtr method_12()
	{
		return ((Control)this).get_Handle();
	}

	static void smethod_0(Control control_0, Color color_3)
	{
		control_0.set_BackColor(color_3);
	}

	static void smethod_1(Control control_0, int int_10)
	{
		control_0.set_Width(int_10);
	}

	static void smethod_2(Control control_0, int int_10)
	{
		control_0.set_Height(int_10);
	}

	static void smethod_3(Timer timer_1, int int_10)
	{
		timer_1.set_Interval(int_10);
	}

	static void smethod_4(Timer timer_1)
	{
		timer_1.Start();
	}

	static Random smethod_5()
	{
		return new Random();
	}

	static int smethod_6(Random random_0, int int_10)
	{
		return random_0.Next(int_10);
	}

	static Pen smethod_7(Color color_3)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new Pen(color_3);
	}

	static Brush smethod_8(Pen pen_0)
	{
		return pen_0.get_Brush();
	}

	static void smethod_9(Graphics graphics_1, Brush brush_0, Rectangle rectangle_0)
	{
		graphics_1.FillRectangle(brush_0, rectangle_0);
	}

	static Graphics smethod_10(PaintEventArgs paintEventArgs_0)
	{
		return paintEventArgs_0.get_Graphics();
	}

	static Pen smethod_11()
	{
		return Pens.get_DarkGray();
	}

	static int smethod_12(Control control_0)
	{
		return control_0.get_Width();
	}

	static int smethod_13(Control control_0)
	{
		return control_0.get_Height();
	}

	static void smethod_14(Graphics graphics_1, Pen pen_0, Rectangle rectangle_0)
	{
		graphics_1.DrawRectangle(pen_0, rectangle_0);
	}

	static void smethod_15(Control control_0)
	{
		control_0.Refresh();
	}

	static Keys smethod_16(KeyEventArgs keyEventArgs_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return keyEventArgs_0.get_KeyCode();
	}

	static void smethod_17()
	{
		Application.Exit();
	}

	static void smethod_18(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Container smethod_19()
	{
		return new Container();
	}

	static Timer smethod_20(IContainer icontainer_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new Timer(icontainer_1);
	}

	static void smethod_21(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_22(Timer timer_1, EventHandler eventHandler_0)
	{
		timer_1.add_Tick(eventHandler_0);
	}

	static void smethod_23(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_24(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_25(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_26(UserControl userControl_0, EventHandler eventHandler_0)
	{
		userControl_0.add_Load(eventHandler_0);
	}

	static void smethod_27(Control control_0, PaintEventHandler paintEventHandler_0)
	{
		control_0.add_Paint(paintEventHandler_0);
	}

	static void smethod_28(Control control_0, KeyEventHandler keyEventHandler_0)
	{
		control_0.add_KeyUp(keyEventHandler_0);
	}

	static void smethod_29(Control control_0, bool bool_1)
	{
		control_0.ResumeLayout(bool_1);
	}
}
