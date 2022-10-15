using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

internal class Control9 : Control
{
	public enum Enum1
	{

	}

	private static List<WeakReference> list_0;

	private Enum1 enum1_0;

	[DebuggerNonUserCode]
	static Control9()
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

	public Control9()
	{
		Class14.vPNVHkezq0oMI();
		((Control)this)._002Ector();
		smethod_0(this);
		enum1_0 = (Enum1)3;
		((Control)this).set_DoubleBuffered(true);
		((Control)this).SetStyle((ControlStyles)8192, true);
		((Control)this).SetStyle((ControlStyles)2, true);
		((Control)this).SetStyle((ControlStyles)2048, true);
		((Control)this).SetStyle((ControlStyles)16, true);
		((Control)this).SetStyle((ControlStyles)131072, true);
		((Control)this).set_ForeColor(Color.White);
		((Control)this).set_BackColor(Color.Transparent);
		((Control)this).set_Anchor((AnchorStyles)9);
	}

	protected override void OnResize(EventArgs e)
	{
		((Control)this).OnResize(e);
		Size size = new Size(60, 25);
		((Control)this).set_Size(size);
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		((Control)this).OnMouseMove(e);
		int x = e.get_Location().X;
		int y = e.get_Location().Y;
		if ((y > 0 && y < checked(((Control)this).get_Height() - 2)) ? true : false)
		{
			if ((x > 0 && x < 30) ? true : false)
			{
				enum1_0 = (Enum1)0;
			}
			else if ((x > 31 && x < ((Control)this).get_Width()) ? true : false)
			{
				enum1_0 = (Enum1)2;
			}
			else
			{
				enum1_0 = (Enum1)3;
			}
		}
		else
		{
			enum1_0 = (Enum1)3;
		}
		((Control)this).Invalidate();
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_0080: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_00bd: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected O, but got Unknown
		//IL_01e5: Expected O, but got Unknown
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected O, but got Unknown
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected O, but got Unknown
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Expected O, but got Unknown
		//IL_02f2: Expected O, but got Unknown
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		((Control)this).OnPaint(e);
		val2.Clear(((Control)this).get_BackColor());
		Font val3 = new Font("Marlett", 9f);
		SolidBrush val4 = new SolidBrush(Color.FromArgb(90, 90, 90));
		checked
		{
			Point point = new Point(((Control)this).get_Width() - 16, 7);
			PointF pointF = point;
			StringFormat val5 = new StringFormat();
			val5.set_Alignment((StringAlignment)1);
			val2.DrawString("r", val3, (Brush)val4, pointF, val5);
			SolidBrush val6 = new SolidBrush(Color.FromArgb(90, 90, 90));
			point = new Point(22, 7);
			PointF pointF2 = point;
			val5 = new StringFormat();
			val5.set_Alignment((StringAlignment)1);
			val2.DrawString("0", val3, (Brush)val6, pointF2, val5);
			Rectangle rectangle;
			switch (enum1_0)
			{
			case (Enum1)0:
			{
				SolidBrush val11 = new SolidBrush(Color.FromArgb(20, 20, 20));
				rectangle = new Rectangle(10, 0, ((Control)this).get_Width() - 40, ((Control)this).get_Height() - 1);
				val2.FillRectangle((Brush)val11, rectangle);
				HatchBrush val12 = new HatchBrush((HatchStyle)21, Color.FromArgb(15, Color.White), Color.Transparent);
				rectangle = new Rectangle(10, 0, ((Control)this).get_Width() - 40, ((Control)this).get_Height() - 1);
				val2.FillRectangle((Brush)(object)val12, rectangle);
				Pen val13 = new Pen(Color.FromArgb(40, 40, 40));
				rectangle = new Rectangle(11, 1, ((Control)this).get_Width() - 40, ((Control)this).get_Height() - 3);
				val2.DrawRectangle(val13, rectangle);
				Pen black2 = Pens.get_Black();
				rectangle = new Rectangle(10, 0, ((Control)this).get_Width() - 40, ((Control)this).get_Height() - 1);
				val2.DrawRectangle(black2, rectangle);
				SolidBrush val14 = new SolidBrush(Color.Cyan);
				point = new Point(22, 7);
				PointF pointF4 = point;
				val5 = new StringFormat();
				val5.set_Alignment((StringAlignment)1);
				val2.DrawString("0", val3, (Brush)val14, pointF4, val5);
				break;
			}
			case (Enum1)2:
			{
				SolidBrush val7 = new SolidBrush(Color.FromArgb(20, 20, 20));
				rectangle = new Rectangle(30, 0, ((Control)this).get_Width() - 5, ((Control)this).get_Height() - 2);
				val2.FillRectangle((Brush)val7, rectangle);
				HatchBrush val8 = new HatchBrush((HatchStyle)21, Color.FromArgb(15, Color.White), Color.Transparent);
				rectangle = new Rectangle(30, 0, ((Control)this).get_Width() - 5, ((Control)this).get_Height() - 2);
				val2.FillRectangle((Brush)(object)val8, rectangle);
				Pen val9 = new Pen(Color.FromArgb(40, 40, 40));
				rectangle = new Rectangle(31, 1, ((Control)this).get_Width() - 5, ((Control)this).get_Height() - 1);
				val2.DrawRectangle(val9, rectangle);
				Pen black = Pens.get_Black();
				rectangle = new Rectangle(30, 0, ((Control)this).get_Width() - 10, ((Control)this).get_Height() - 1);
				val2.DrawRectangle(black, rectangle);
				SolidBrush val10 = new SolidBrush(Color.Red);
				point = new Point(((Control)this).get_Width() - 16, 7);
				PointF pointF3 = point;
				val5 = new StringFormat();
				val5.set_Alignment((StringAlignment)1);
				val2.DrawString("r", val3, (Brush)val10, pointF3, val5);
				break;
			}
			}
			Pen val15 = new Pen(Color.FromArgb(40, 40, 40));
			rectangle = new Rectangle(10, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			val2.DrawRectangle(val15, rectangle);
			Pen black3 = Pens.get_Black();
			rectangle = new Rectangle(9, 0, ((Control)this).get_Width() - 3, ((Control)this).get_Height() + 1);
			val2.DrawRectangle(black3, rectangle);
			Graphics graphics = e.get_Graphics();
			point = new Point(0, 0);
			graphics.DrawImage((Image)(object)val, point);
			val2.Dispose();
			((Image)val).Dispose();
		}
	}

	protected override void OnMouseUp(MouseEventArgs mevent)
	{
		((Control)this).OnMouseDown(mevent);
		switch (enum1_0)
		{
		case (Enum1)0:
			((Control)this).get_Parent().FindForm().set_WindowState((FormWindowState)1);
			break;
		case (Enum1)1:
			((Control)this).get_Parent().FindForm().set_WindowState((FormWindowState)2);
			break;
		case (Enum1)2:
			((Control)this).get_Parent().FindForm().Close();
			break;
		}
		((Control)this).Invalidate();
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		((Control)this).OnMouseLeave(e);
		enum1_0 = (Enum1)3;
		((Control)this).Invalidate();
	}
}
