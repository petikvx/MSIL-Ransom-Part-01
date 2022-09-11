using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns1;

public class MonoFlat_ThemeContainer : ContainerControl
{
	public enum MouseState
	{
		None,
		Over,
		Down,
		Block
	}

	private Rectangle rectangle_0;

	protected MouseState mouseState_0;

	private Point point_0;

	private bool bool_0;

	private int int_0;

	private bool bool_1;

	internal int int_1;

	internal Point point_1;

	internal bool bool_2;

	internal bool bool_3;

	internal bool bool_4;

	internal bool bool_5;

	internal bool bool_6;

	internal bool bool_7;

	internal bool bool_8;

	internal FormStartPosition formStartPosition_0;

	internal bool bool_9;

	internal bool bool_10;

	internal bool bool_11;

	internal int int_2;

	internal Message[] message_0;

	public bool Sizable
	{
		get
		{
			return bool_4;
		}
		set
		{
			bool flag = (bool_4 = value);
		}
	}

	public bool SmartBounds
	{
		get
		{
			return bool_5;
		}
		set
		{
			bool flag = (bool_5 = value);
		}
	}

	public bool RoundCorners
	{
		get
		{
			return bool_6;
		}
		set
		{
			bool flag = (bool_6 = value);
			((Control)this).Invalidate();
		}
	}

	protected bool IsParentForm => bool_7;

	protected bool IsParentMdi
	{
		get
		{
			if (((Control)this).get_Parent() == null)
			{
				return false;
			}
			return ((Control)this).get_Parent().get_Parent() != null;
		}
	}

	protected bool ControlMode
	{
		get
		{
			return bool_8;
		}
		set
		{
			bool flag = (bool_8 = value);
			((Control)this).Invalidate();
		}
	}

	public FormStartPosition StartPosition
	{
		get
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			if (bool_7 && !bool_8)
			{
				return ((ContainerControl)this).get_ParentForm().get_StartPosition();
			}
			return formStartPosition_0;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			FormStartPosition val = (formStartPosition_0 = value);
			if (bool_7 && !bool_8)
			{
				((ContainerControl)this).get_ParentForm().set_StartPosition(value);
			}
		}
	}

	protected sealed override void vmethod_0(EventArgs eventArgs_0)
	{
		((ContainerControl)this).OnParentChanged(eventArgs_0);
		if (((Control)this).get_Parent() == null)
		{
			return;
		}
		bool flag = (bool_7 = ((Control)this).get_Parent() is Form);
		if (bool_8)
		{
			return;
		}
		method_3();
		if (bool_7)
		{
			((ContainerControl)this).get_ParentForm().set_FormBorderStyle((FormBorderStyle)0);
			((ContainerControl)this).get_ParentForm().set_TransparencyKey(Color.Fuchsia);
			if (!((Component)this).DesignMode)
			{
				((ContainerControl)this).get_ParentForm().add_Shown((EventHandler)QWxTCet1io3AI0xLohzYkkzmzn7lUnexafOMjDK4QQMnWxgIVCbhlvqFcAtVRDoJLmV5UsBPD5O0fR6OkXTFXMlHs4auXT9lv3puCNDZns1NPgbui95p);
			}
		}
		((Control)this).get_Parent().set_BackColor(((Control)this).get_BackColor());
	}

	protected sealed override void KH3Jxq9Dn4xckCUH0h9dNtUvnZ3Xn0V4lLcX9iZQ9EtddgTsq4XHnHuiDDgJvDnhO4V2qzU58MdMppt1DwD5AMyx7VOsLgM8PbQfizWxySncsJkvTiaC(EventArgs eventArgs_0)
	{
		((Control)this).OnSizeChanged(eventArgs_0);
		if (!bool_8)
		{
			rectangle_0 = new Rectangle(0, 0, ((Control)this).get_Width() - 14, int_1 - 7);
		}
		((Control)this).Invalidate();
	}

	protected override void vmethod_1(MouseEventArgs mouseEventArgs_0)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Invalid comparison between Unknown and I4
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Invalid comparison between Unknown and I4
		((Control)this).OnMouseDown(mouseEventArgs_0);
		((Control)this).Focus();
		if ((int)mouseEventArgs_0.get_Button() == 1048576)
		{
			method_0(MouseState.Down);
		}
		if ((!bool_7 || (int)((ContainerControl)this).get_ParentForm().get_WindowState() != 2) && !bool_8)
		{
			if (rectangle_0.Contains(mouseEventArgs_0.get_Location()))
			{
				((Control)this).set_Capture(false);
				bool_1 = true;
				((Control)this).DefWndProc(ref message_0[0]);
			}
			else if (bool_4 && int_0 != 0)
			{
				((Control)this).set_Capture(false);
				bool_1 = true;
				((Control)this).DefWndProc(ref message_0[int_0]);
			}
		}
	}

	protected override void vmethod_2(MouseEventArgs mouseEventArgs_0)
	{
		((Control)this).OnMouseUp(mouseEventArgs_0);
		bool_2 = false;
	}

	protected override void vmethod_3(MouseEventArgs mouseEventArgs_0)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Invalid comparison between Unknown and I4
		((Control)this).OnMouseMove(mouseEventArgs_0);
		if ((!bool_7 || (int)((ContainerControl)this).get_ParentForm().get_WindowState() != 2) && bool_4 && !bool_8)
		{
			method_2();
		}
		if (bool_2)
		{
			((Control)this).get_Parent().set_Location((Point)(object)(Convert.ToDouble(Control.get_MousePosition()) - Convert.ToDouble(point_1)));
		}
	}

	protected override void vmethod_4(InvalidateEventArgs HgI1uavuvv9g2kIykEOwnvmz2ntdpXvfhl0GjxkuKFpRLKTEEth5y92pMk9UYBfWql8JWOU43a8hJnuoDMVdyGwDEiXW2lWvaJyppun9ch3vR0C0vMvG)
	{
		((Control)this).OnInvalidated(HgI1uavuvv9g2kIykEOwnvmz2ntdpXvfhl0GjxkuKFpRLKTEEth5y92pMk9UYBfWql8JWOU43a8hJnuoDMVdyGwDEiXW2lWvaJyppun9ch3vR0C0vMvG);
		((Control)((ContainerControl)this).get_ParentForm()).set_Text(((Control)this).get_Text());
	}

	protected override void vmethod_5(PaintEventArgs paintEventArgs_0)
	{
		((ScrollableControl)this).OnPaintBackground(paintEventArgs_0);
	}

	protected override void vmethod_6(EventArgs eventArgs_0)
	{
		((Control)this).OnTextChanged(eventArgs_0);
		((Control)this).Invalidate();
	}

	private void QWxTCet1io3AI0xLohzYkkzmzn7lUnexafOMjDK4QQMnWxgIVCbhlvqFcAtVRDoJLmV5UsBPD5O0fR6OkXTFXMlHs4auXT9lv3puCNDZns1NPgbui95p(object sender, EventArgs e)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between Unknown and I4
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		if (!bool_8 && !bool_3)
		{
			if ((int)formStartPosition_0 == 4 || (int)formStartPosition_0 == 1)
			{
				Rectangle bounds = Screen.get_PrimaryScreen().get_Bounds();
				Rectangle bounds2 = ((Control)((ContainerControl)this).get_ParentForm()).get_Bounds();
				((ContainerControl)this).get_ParentForm().set_Location(new Point(bounds.Width / 2 - bounds2.Width / 2, bounds.Height / 2 - bounds2.Width / 2));
			}
			bool_3 = true;
		}
	}

	private void method_0(MouseState mouseState_1)
	{
		mouseState_0 = mouseState_1;
		((Control)this).Invalidate();
	}

	private int method_1()
	{
		point_0 = ((Control)this).PointToClient(Control.get_MousePosition());
		bool flag = (bool_9 = point_0.X < 7);
		bool flag2 = (bool_10 = point_0.X > ((Control)this).get_Width() - 7);
		bool flag3 = (bool_11 = point_0.Y < 7);
		bool_0 = point_0.Y > ((Control)this).get_Height() - 7;
		if (bool_9 && bool_11)
		{
			return 4;
		}
		if (bool_9 && bool_0)
		{
			return 7;
		}
		if (bool_10 && bool_11)
		{
			return 5;
		}
		if (bool_10 && bool_0)
		{
			return 8;
		}
		if (bool_9)
		{
			return 1;
		}
		if (bool_10)
		{
			return 2;
		}
		if (bool_11)
		{
			return 3;
		}
		if (bool_0)
		{
			return 6;
		}
		return 0;
	}

	private void method_2()
	{
		int num = (int_2 = method_1());
		if (int_2 != int_0)
		{
			int_0 = int_2;
			switch (int_0)
			{
			case 6:
				((Control)this).set_Cursor(Cursors.get_SizeNS());
				break;
			case 7:
				((Control)this).set_Cursor(Cursors.get_SizeNESW());
				break;
			case 8:
				((Control)this).set_Cursor(Cursors.get_SizeNWSE());
				break;
			case 0:
				((Control)this).set_Cursor(Cursors.get_Default());
				break;
			}
		}
	}

	private void method_3()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		message_0[0] = Message.Create(((Control)this).get_Parent().get_Handle(), 161, new IntPtr(2), IntPtr.Zero);
		for (int i = 1; i <= 8; i++)
		{
			message_0[i] = Message.Create(((Control)this).get_Parent().get_Handle(), 161, new IntPtr(i + 9), IntPtr.Zero);
		}
	}

	private void method_4(Rectangle rectangle_1)
	{
		if (((Control)this).get_Parent().get_Width() > rectangle_1.Width)
		{
			((Control)this).get_Parent().set_Width(rectangle_1.Width);
		}
		if (((Control)this).get_Parent().get_Height() > rectangle_1.Height)
		{
			((Control)this).get_Parent().set_Height(rectangle_1.Height);
		}
		int num = ((Control)this).get_Parent().get_Location().X;
		int num2 = ((Control)this).get_Parent().get_Location().Y;
		if (num < rectangle_1.X)
		{
			num = rectangle_1.X;
		}
		if (num2 < rectangle_1.Y)
		{
			num2 = rectangle_1.Y;
		}
		int num3 = rectangle_1.X + rectangle_1.Width;
		int num4 = rectangle_1.Y + rectangle_1.Height;
		if (num + ((Control)this).get_Parent().get_Width() > num3)
		{
			num = num3 - ((Control)this).get_Parent().get_Width();
		}
		if (num2 + ((Control)this).get_Parent().get_Height() > num4)
		{
			num2 = num4 - ((Control)this).get_Parent().get_Height();
		}
		((Control)this).get_Parent().set_Location(new Point(num, num2));
	}

	protected override void vmethod_7(ref Message message_1)
	{
		((ContainerControl)this).WndProc(ref message_1);
		if (!bool_1 || ((Message)(ref message_1)).get_Msg() != 513)
		{
			return;
		}
		bool_1 = false;
		method_0(MouseState.Over);
		if (bool_5)
		{
			if (IsParentMdi)
			{
				method_4(new Rectangle(Point.Empty, ((Control)this).get_Parent().get_Parent().get_Size()));
			}
			else
			{
				method_4(Screen.FromControl(((Control)this).get_Parent()).get_WorkingArea());
			}
		}
	}

	protected override void vmethod_8()
	{
		((Control)this).CreateHandle();
	}

	public MonoFlat_ThemeContainer()
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		Point point = (point_1 = new Point(0, 0));
		bool_4 = true;
		bool_5 = true;
		bool_6 = true;
		Message[] array = (message_0 = (Message[])(object)new Message[9]);
		((ContainerControl)this)._002Ector();
		((Control)this).SetStyle((ControlStyles)139270, true);
		((Control)this).set_BackColor(Color.FromArgb(32, 41, 50));
		((Control)this).set_Padding(new Padding(10, 70, 10, 9));
		((Control)this).set_DoubleBuffered(true);
		((Control)this).set_Dock((DockStyle)5);
		int_1 = 66;
		((Control)this).set_Font(new Font("Segoe UI", 9f));
	}

	protected override void vmethod_9(PaintEventArgs paintEventArgs_0)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected O, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected O, but got Unknown
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected O, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected O, but got Unknown
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected O, but got Unknown
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Expected O, but got Unknown
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected O, but got Unknown
		//IL_0528: Unknown result type (might be due to invalid IL or missing references)
		//IL_0544: Expected O, but got Unknown
		//IL_0550: Unknown result type (might be due to invalid IL or missing references)
		//IL_056c: Expected O, but got Unknown
		//IL_0578: Unknown result type (might be due to invalid IL or missing references)
		//IL_0594: Expected O, but got Unknown
		//IL_05a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bc: Expected O, but got Unknown
		//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0608: Unknown result type (might be due to invalid IL or missing references)
		//IL_060d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0614: Unknown result type (might be due to invalid IL or missing references)
		//IL_0620: Expected O, but got Unknown
		//IL_0620: Expected O, but got Unknown
		//IL_0620: Expected O, but got Unknown
		((Control)this).OnPaint(paintEventArgs_0);
		Graphics graphics = paintEventArgs_0.get_Graphics();
		graphics.Clear(Color.FromArgb(32, 41, 50));
		graphics.FillRectangle((Brush)new SolidBrush(Color.FromArgb(181, 41, 42)), new Rectangle(0, 0, ((Control)this).get_Width(), 60));
		if (bool_6)
		{
			graphics.FillRectangle(Brushes.get_Fuchsia(), 0, 0, 1, 1);
			graphics.FillRectangle(Brushes.get_Fuchsia(), 1, 0, 1, 1);
			graphics.FillRectangle(Brushes.get_Fuchsia(), 2, 0, 1, 1);
			graphics.FillRectangle(Brushes.get_Fuchsia(), 3, 0, 1, 1);
			graphics.FillRectangle(Brushes.get_Fuchsia(), 0, 1, 1, 1);
			graphics.FillRectangle(Brushes.get_Fuchsia(), 0, 2, 1, 1);
			graphics.FillRectangle(Brushes.get_Fuchsia(), 0, 3, 1, 1);
			graphics.FillRectangle(Brushes.get_Fuchsia(), 1, 1, 1, 1);
			graphics.FillRectangle((Brush)new SolidBrush(Color.FromArgb(181, 41, 42)), 1, 3, 1, 1);
			graphics.FillRectangle((Brush)new SolidBrush(Color.FromArgb(181, 41, 42)), 1, 2, 1, 1);
			graphics.FillRectangle((Brush)new SolidBrush(Color.FromArgb(181, 41, 42)), 2, 1, 1, 1);
			graphics.FillRectangle((Brush)new SolidBrush(Color.FromArgb(181, 41, 42)), 3, 1, 1, 1);
			graphics.FillRectangle(Brushes.get_Fuchsia(), ((Control)this).get_Width() - 1, 0, 1, 1);
			graphics.FillRectangle(Brushes.get_Fuchsia(), ((Control)this).get_Width() - 2, 0, 1, 1);
			graphics.FillRectangle(Brushes.get_Fuchsia(), ((Control)this).get_Width() - 3, 0, 1, 1);
			graphics.FillRectangle(Brushes.get_Fuchsia(), ((Control)this).get_Width() - 4, 0, 1, 1);
			graphics.FillRectangle(Brushes.get_Fuchsia(), ((Control)this).get_Width() - 1, 1, 1, 1);
			graphics.FillRectangle(Brushes.get_Fuchsia(), ((Control)this).get_Width() - 1, 2, 1, 1);
			graphics.FillRectangle(Brushes.get_Fuchsia(), ((Control)this).get_Width() - 1, 3, 1, 1);
			graphics.FillRectangle(Brushes.get_Fuchsia(), ((Control)this).get_Width() - 2, 1, 1, 1);
			graphics.FillRectangle((Brush)new SolidBrush(Color.FromArgb(181, 41, 42)), ((Control)this).get_Width() - 2, 3, 1, 1);
			graphics.FillRectangle((Brush)new SolidBrush(Color.FromArgb(181, 41, 42)), ((Control)this).get_Width() - 2, 2, 1, 1);
			graphics.FillRectangle((Brush)new SolidBrush(Color.FromArgb(181, 41, 42)), ((Control)this).get_Width() - 3, 1, 1, 1);
			graphics.FillRectangle((Brush)new SolidBrush(Color.FromArgb(181, 41, 42)), ((Control)this).get_Width() - 4, 1, 1, 1);
			graphics.FillRectangle(Brushes.get_Fuchsia(), 0, ((Control)this).get_Height() - 1, 1, 1);
			graphics.FillRectangle(Brushes.get_Fuchsia(), 0, ((Control)this).get_Height() - 2, 1, 1);
			graphics.FillRectangle(Brushes.get_Fuchsia(), 0, ((Control)this).get_Height() - 3, 1, 1);
			graphics.FillRectangle(Brushes.get_Fuchsia(), 0, ((Control)this).get_Height() - 4, 1, 1);
			graphics.FillRectangle(Brushes.get_Fuchsia(), 1, ((Control)this).get_Height() - 1, 1, 1);
			graphics.FillRectangle(Brushes.get_Fuchsia(), 2, ((Control)this).get_Height() - 1, 1, 1);
			graphics.FillRectangle(Brushes.get_Fuchsia(), 3, ((Control)this).get_Height() - 1, 1, 1);
			graphics.FillRectangle(Brushes.get_Fuchsia(), 1, ((Control)this).get_Height() - 1, 1, 1);
			graphics.FillRectangle(Brushes.get_Fuchsia(), 1, ((Control)this).get_Height() - 2, 1, 1);
			graphics.FillRectangle((Brush)new SolidBrush(Color.FromArgb(32, 41, 50)), 1, ((Control)this).get_Height() - 3, 1, 1);
			graphics.FillRectangle((Brush)new SolidBrush(Color.FromArgb(32, 41, 50)), 1, ((Control)this).get_Height() - 4, 1, 1);
			graphics.FillRectangle((Brush)new SolidBrush(Color.FromArgb(32, 41, 50)), 3, ((Control)this).get_Height() - 2, 1, 1);
			graphics.FillRectangle((Brush)new SolidBrush(Color.FromArgb(32, 41, 50)), 2, ((Control)this).get_Height() - 2, 1, 1);
			graphics.FillRectangle(Brushes.get_Fuchsia(), ((Control)this).get_Width() - 1, ((Control)this).get_Height(), 1, 1);
			graphics.FillRectangle(Brushes.get_Fuchsia(), ((Control)this).get_Width() - 2, ((Control)this).get_Height(), 1, 1);
			graphics.FillRectangle(Brushes.get_Fuchsia(), ((Control)this).get_Width() - 3, ((Control)this).get_Height(), 1, 1);
			graphics.FillRectangle(Brushes.get_Fuchsia(), ((Control)this).get_Width() - 4, ((Control)this).get_Height(), 1, 1);
			graphics.FillRectangle(Brushes.get_Fuchsia(), ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1, 1, 1);
			graphics.FillRectangle(Brushes.get_Fuchsia(), ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 2, 1, 1);
			graphics.FillRectangle(Brushes.get_Fuchsia(), ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 3, 1, 1);
			graphics.FillRectangle(Brushes.get_Fuchsia(), ((Control)this).get_Width() - 2, ((Control)this).get_Height() - 1, 1, 1);
			graphics.FillRectangle(Brushes.get_Fuchsia(), ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 1, 1, 1);
			graphics.FillRectangle(Brushes.get_Fuchsia(), ((Control)this).get_Width() - 4, ((Control)this).get_Height() - 1, 1, 1);
			graphics.FillRectangle(Brushes.get_Fuchsia(), ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 4, 1, 1);
			graphics.FillRectangle(Brushes.get_Fuchsia(), ((Control)this).get_Width() - 2, ((Control)this).get_Height() - 2, 1, 1);
			graphics.FillRectangle((Brush)new SolidBrush(Color.FromArgb(32, 41, 50)), ((Control)this).get_Width() - 2, ((Control)this).get_Height() - 3, 1, 1);
			graphics.FillRectangle((Brush)new SolidBrush(Color.FromArgb(32, 41, 50)), ((Control)this).get_Width() - 2, ((Control)this).get_Height() - 4, 1, 1);
			graphics.FillRectangle((Brush)new SolidBrush(Color.FromArgb(32, 41, 50)), ((Control)this).get_Width() - 4, ((Control)this).get_Height() - 2, 1, 1);
			graphics.FillRectangle((Brush)new SolidBrush(Color.FromArgb(32, 41, 50)), ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 2, 1, 1);
		}
		string text = ((Control)this).get_Text();
		Font val = new Font("Microsoft Sans Serif", 12f, (FontStyle)1);
		SolidBrush val2 = new SolidBrush(Color.FromArgb(255, 254, 255));
		RectangleF rectangleF = new Rectangle(20, 20, ((Control)this).get_Width() - 1, ((Control)this).get_Height());
		StringFormat val3 = new StringFormat();
		val3.set_Alignment((StringAlignment)0);
		val3.set_LineAlignment((StringAlignment)0);
		graphics.DrawString(text, val, (Brush)val2, rectangleF, val3);
	}
}
