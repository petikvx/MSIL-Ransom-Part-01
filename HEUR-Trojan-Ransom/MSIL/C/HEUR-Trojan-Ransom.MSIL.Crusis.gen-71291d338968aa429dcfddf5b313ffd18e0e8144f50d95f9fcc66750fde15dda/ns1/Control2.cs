using System;
using System.Drawing;
using System.Windows.Forms;

namespace ns1;

internal sealed class Control2 : Control
{
	public enum Enum1
	{
		const_0,
		const_1,
		const_2,
		const_3
	}

	private Enum1 enum1_0 = Enum1.const_3;

	private bool bool_0 = true;

	internal bool bool_1 = true;

	internal bool bool_2;

	public bool Boolean_0
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
			((Control)this).Invalidate();
		}
	}

	public bool Boolean_1
	{
		get
		{
			return bool_1;
		}
		set
		{
			bool flag = (bool_1 = value);
			((Control)this).Invalidate();
		}
	}

	public bool Boolean_2
	{
		get
		{
			return bool_2;
		}
		set
		{
			bool flag = (bool_2 = value);
			((Control)this).Invalidate();
		}
	}

	protected override void vmethod_0(EventArgs eventArgs_0)
	{
		((Control)this).OnResize(eventArgs_0);
		((Control)this).set_Size(new Size(100, 25));
	}

	protected override void vmethod_1(MouseEventArgs mouseEventArgs_0)
	{
		((Control)this).OnMouseMove(mouseEventArgs_0);
		int x = mouseEventArgs_0.get_Location().X;
		int y = mouseEventArgs_0.get_Location().Y;
		if (y > 0 && y < ((Control)this).get_Height() - 2)
		{
			if (x > 0 && x < 34)
			{
				enum1_0 = Enum1.const_0;
			}
			else if (x > 33 && x < 65)
			{
				enum1_0 = Enum1.const_1;
			}
			else if (x > 64 && x < ((Control)this).get_Width())
			{
				enum1_0 = Enum1.const_2;
			}
			else
			{
				enum1_0 = Enum1.const_3;
			}
		}
		else
		{
			enum1_0 = Enum1.const_3;
		}
		((Control)this).Invalidate();
	}

	protected override void vmethod_2(MouseEventArgs mouseEventArgs_0)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).OnMouseDown(mouseEventArgs_0);
		switch (enum1_0)
		{
		case Enum1.const_0:
			if (bool_1)
			{
				((Control)this).get_Parent().FindForm().set_WindowState((FormWindowState)1);
			}
			break;
		case Enum1.const_1:
			if (bool_0)
			{
				if ((int)((Control)this).get_Parent().FindForm().get_WindowState() == 0)
				{
					((Control)this).get_Parent().FindForm().set_WindowState((FormWindowState)2);
				}
				else
				{
					((Control)this).get_Parent().FindForm().set_WindowState((FormWindowState)0);
				}
			}
			break;
		case Enum1.const_2:
			((Control)this).get_Parent().FindForm().Close();
			break;
		}
	}

	protected override void vmethod_3(EventArgs eventArgs_0)
	{
		((Control)this).OnMouseLeave(eventArgs_0);
		enum1_0 = Enum1.const_3;
		((Control)this).Invalidate();
	}

	protected override void vmethod_4(MouseEventArgs mouseEventArgs_0)
	{
		((Control)this).OnMouseDown(mouseEventArgs_0);
		((Control)this).Focus();
	}

	public Control2()
	{
		((Control)this).set_DoubleBuffered(true);
		((Control)this).set_Anchor((AnchorStyles)9);
	}

	protected override void vmethod_5()
	{
		((Control)this).OnCreateControl();
		try
		{
			((Control)this).set_Location(new Point(((Control)this).get_Parent().get_Width() - 112, 15));
		}
		catch (Exception)
		{
		}
	}

	protected override void vmethod_6(PaintEventArgs paintEventArgs_0)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected O, but got Unknown
		//IL_0149: Expected O, but got Unknown
		//IL_0149: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Invalid comparison between Unknown and I4
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected O, but got Unknown
		//IL_01bb: Expected O, but got Unknown
		//IL_01bb: Expected O, but got Unknown
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected O, but got Unknown
		//IL_01fd: Expected O, but got Unknown
		//IL_01fd: Expected O, but got Unknown
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected O, but got Unknown
		//IL_0256: Expected O, but got Unknown
		//IL_0256: Expected O, but got Unknown
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected O, but got Unknown
		//IL_0295: Expected O, but got Unknown
		//IL_0295: Expected O, but got Unknown
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected O, but got Unknown
		//IL_02e9: Expected O, but got Unknown
		//IL_02e9: Expected O, but got Unknown
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected O, but got Unknown
		//IL_0327: Expected O, but got Unknown
		//IL_0327: Expected O, but got Unknown
		((Control)this).OnPaint(paintEventArgs_0);
		Graphics graphics = paintEventArgs_0.get_Graphics();
		graphics.Clear(Color.FromArgb(181, 41, 42));
		if (bool_2)
		{
			switch (enum1_0)
			{
			case Enum1.const_0:
				if (bool_1)
				{
					graphics.FillRectangle((Brush)new SolidBrush(Color.FromArgb(156, 35, 35)), new Rectangle(3, 0, 30, ((Control)this).get_Height()));
				}
				break;
			case Enum1.const_1:
				if (bool_0)
				{
					graphics.FillRectangle((Brush)new SolidBrush(Color.FromArgb(156, 35, 35)), new Rectangle(35, 0, 30, ((Control)this).get_Height()));
				}
				break;
			case Enum1.const_2:
				graphics.FillRectangle((Brush)new SolidBrush(Color.FromArgb(156, 35, 35)), new Rectangle(66, 0, 35, ((Control)this).get_Height()));
				break;
			case Enum1.const_3:
				graphics.Clear(Color.FromArgb(181, 41, 42));
				break;
			}
		}
		Font val = new Font("Marlett", 12f);
		SolidBrush val2 = new SolidBrush(Color.FromArgb(255, 254, 255));
		PointF pointF = new Point(((Control)this).get_Width() - 16, 8);
		StringFormat val3 = new StringFormat();
		val3.set_Alignment((StringAlignment)1);
		graphics.DrawString("r", val, (Brush)val2, pointF, val3);
		FormWindowState windowState = ((Control)this).get_Parent().FindForm().get_WindowState();
		if ((int)windowState != 0)
		{
			if ((int)windowState == 2)
			{
				if (bool_0)
				{
					Font val4 = new Font("Marlett", 12f);
					SolidBrush val5 = new SolidBrush(Color.FromArgb(255, 254, 255));
					PointF pointF2 = new Point(51, 7);
					StringFormat val6 = new StringFormat();
					val6.set_Alignment((StringAlignment)1);
					graphics.DrawString("2", val4, (Brush)val5, pointF2, val6);
				}
				else
				{
					Font val7 = new Font("Marlett", 12f);
					SolidBrush val8 = new SolidBrush(Color.LightGray);
					PointF pointF3 = new Point(51, 7);
					StringFormat val9 = new StringFormat();
					val9.set_Alignment((StringAlignment)1);
					graphics.DrawString("2", val7, (Brush)val8, pointF3, val9);
				}
			}
		}
		else if (bool_0)
		{
			Font val10 = new Font("Marlett", 12f);
			SolidBrush val11 = new SolidBrush(Color.FromArgb(255, 254, 255));
			PointF pointF4 = new Point(51, 7);
			StringFormat val12 = new StringFormat();
			val12.set_Alignment((StringAlignment)1);
			graphics.DrawString("1", val10, (Brush)val11, pointF4, val12);
		}
		else
		{
			Font val13 = new Font("Marlett", 12f);
			SolidBrush val14 = new SolidBrush(Color.LightGray);
			PointF pointF5 = new Point(51, 7);
			StringFormat val15 = new StringFormat();
			val15.set_Alignment((StringAlignment)1);
			graphics.DrawString("1", val13, (Brush)val14, pointF5, val15);
		}
		if (bool_1)
		{
			Font val16 = new Font("Marlett", 12f);
			SolidBrush val17 = new SolidBrush(Color.FromArgb(255, 254, 255));
			PointF pointF6 = new Point(20, 7);
			StringFormat val18 = new StringFormat();
			val18.set_Alignment((StringAlignment)1);
			graphics.DrawString("0", val16, (Brush)val17, pointF6, val18);
		}
		else
		{
			Font val19 = new Font("Marlett", 12f);
			SolidBrush val20 = new SolidBrush(Color.LightGray);
			PointF pointF7 = new Point(20, 7);
			StringFormat val21 = new StringFormat();
			val21.set_Alignment((StringAlignment)1);
			graphics.DrawString("0", val19, (Brush)val20, pointF7, val21);
		}
	}
}
