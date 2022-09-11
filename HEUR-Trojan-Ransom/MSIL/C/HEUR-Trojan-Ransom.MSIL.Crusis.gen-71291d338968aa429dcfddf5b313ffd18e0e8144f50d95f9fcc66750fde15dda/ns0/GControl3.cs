using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using ns1;

namespace ns0;

[DefaultEvent("ToggledChanged")]
public class GControl3 : Control
{
	public enum _Type
	{
		CheckMark,
		OnOff,
		YesNo,
		IO
	}

	public delegate void ToggledChangedEventHandler();

	private ToggledChangedEventHandler toggledChangedEventHandler_0;

	private _Type _Type_0;

	private Rectangle rectangle_0;

	private int int_0;

	internal bool bool_0;

	internal int int_1;

	public bool Toggled
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool flag = (bool_0 = value);
			((Control)this).Invalidate();
			if (toggledChangedEventHandler_0 != null)
			{
				toggledChangedEventHandler_0();
			}
		}
	}

	public _Type Type
	{
		get
		{
			return _Type_0;
		}
		set
		{
			_Type_0 = value;
			((Control)this).Invalidate();
		}
	}

	public event ToggledChangedEventHandler ToggledChanged
	{
		add
		{
			toggledChangedEventHandler_0 = (ToggledChangedEventHandler)Delegate.Combine(toggledChangedEventHandler_0, value);
		}
		remove
		{
			toggledChangedEventHandler_0 = (ToggledChangedEventHandler)Delegate.Remove(toggledChangedEventHandler_0, value);
		}
	}

	protected override void vmethod_0(EventArgs eventArgs_0)
	{
		((Control)this).OnResize(eventArgs_0);
		((Control)this).set_Size(new Size(76, 33));
	}

	protected override void vmethod_1(MouseEventArgs mouseEventArgs_0)
	{
		((Control)this).OnMouseUp(mouseEventArgs_0);
		Toggled = !Toggled;
		((Control)this).Focus();
	}

	public GControl3()
	{
		((Control)this).SetStyle((ControlStyles)73746, true);
	}

	protected override void vmethod_2(PaintEventArgs paintEventArgs_0)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected O, but got Unknown
		//IL_01c4: Expected O, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected O, but got Unknown
		//IL_0216: Expected O, but got Unknown
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected O, but got Unknown
		//IL_0270: Expected O, but got Unknown
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected O, but got Unknown
		//IL_02c2: Expected O, but got Unknown
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected O, but got Unknown
		//IL_031c: Expected O, but got Unknown
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Expected O, but got Unknown
		//IL_036e: Expected O, but got Unknown
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected O, but got Unknown
		//IL_03c8: Expected O, but got Unknown
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_041a: Expected O, but got Unknown
		//IL_041a: Expected O, but got Unknown
		((Control)this).OnPaint(paintEventArgs_0);
		Graphics graphics = paintEventArgs_0.get_Graphics();
		graphics.set_SmoothingMode((SmoothingMode)2);
		graphics.Clear(((Control)this).get_Parent().get_BackColor());
		int num = (int_1 = ((Control)this).get_Width() - 1);
		int_0 = ((Control)this).get_Height() - 1;
		GraphicsPath val = null;
		GraphicsPath val2 = new GraphicsPath();
		Rectangle rectangle = new Rectangle(0, 0, int_1, int_0);
		new Rectangle(int_1 / 2, 0, 38, int_0);
		graphics.set_SmoothingMode((SmoothingMode)2);
		graphics.set_PixelOffsetMode((PixelOffsetMode)2);
		graphics.set_TextRenderingHint((TextRenderingHint)5);
		graphics.Clear(((Control)this).get_BackColor());
		val = Control1.smethod_0(rectangle, 4);
		val2 = Control1.smethod_0(new Rectangle(4, 4, 36, int_0 - 8), 4);
		graphics.FillPath((Brush)new SolidBrush(Color.FromArgb(66, 76, 85)), val);
		graphics.FillPath((Brush)new SolidBrush(Color.FromArgb(32, 41, 50)), val2);
		if (bool_0)
		{
			val = Control1.smethod_0(rectangle, 4);
			val2 = Control1.smethod_0(new Rectangle(int_1 / 2 - 2, 4, 36, int_0 - 8), 4);
			graphics.FillPath((Brush)new SolidBrush(Color.FromArgb(181, 41, 42)), val);
			graphics.FillPath((Brush)new SolidBrush(Color.FromArgb(32, 41, 50)), val2);
		}
		switch (_Type_0)
		{
		case _Type.CheckMark:
			if (Toggled)
			{
				Font val11 = new Font("Wingdings", 18f, (FontStyle)0);
				Brush whiteSmoke3 = Brushes.get_WhiteSmoke();
				float num10 = rectangle_0.X + 18;
				float num11 = rectangle_0.Y + 19;
				StringFormat val12 = new StringFormat();
				val12.set_Alignment((StringAlignment)1);
				val12.set_LineAlignment((StringAlignment)1);
				graphics.DrawString("ü", val11, whiteSmoke3, num10, num11, val12);
			}
			else
			{
				Font val13 = new Font("Marlett", 14f, (FontStyle)0);
				Brush dimGray3 = Brushes.get_DimGray();
				float num12 = rectangle_0.X + 59;
				float num13 = rectangle_0.Y + 18;
				StringFormat val14 = new StringFormat();
				val14.set_Alignment((StringAlignment)1);
				val14.set_LineAlignment((StringAlignment)1);
				graphics.DrawString("r", val13, dimGray3, num12, num13, val14);
			}
			break;
		case _Type.OnOff:
			if (Toggled)
			{
				Font val7 = new Font("Segoe UI", 12f, (FontStyle)0);
				Brush whiteSmoke2 = Brushes.get_WhiteSmoke();
				float num6 = rectangle_0.X + 18;
				float num7 = rectangle_0.Y + 16;
				StringFormat val8 = new StringFormat();
				val8.set_Alignment((StringAlignment)1);
				val8.set_LineAlignment((StringAlignment)1);
				graphics.DrawString("ON", val7, whiteSmoke2, num6, num7, val8);
			}
			else
			{
				Font val9 = new Font("Segoe UI", 12f, (FontStyle)0);
				Brush dimGray2 = Brushes.get_DimGray();
				float num8 = rectangle_0.X + 57;
				float num9 = rectangle_0.Y + 16;
				StringFormat val10 = new StringFormat();
				val10.set_Alignment((StringAlignment)1);
				val10.set_LineAlignment((StringAlignment)1);
				graphics.DrawString("OFF", val9, dimGray2, num8, num9, val10);
			}
			break;
		case _Type.YesNo:
			if (Toggled)
			{
				Font val15 = new Font("Segoe UI", 12f, (FontStyle)0);
				Brush whiteSmoke4 = Brushes.get_WhiteSmoke();
				float num14 = rectangle_0.X + 19;
				float num15 = rectangle_0.Y + 16;
				StringFormat val16 = new StringFormat();
				val16.set_Alignment((StringAlignment)1);
				val16.set_LineAlignment((StringAlignment)1);
				graphics.DrawString("YES", val15, whiteSmoke4, num14, num15, val16);
			}
			else
			{
				Font val17 = new Font("Segoe UI", 12f, (FontStyle)0);
				Brush dimGray4 = Brushes.get_DimGray();
				float num16 = rectangle_0.X + 56;
				float num17 = rectangle_0.Y + 16;
				StringFormat val18 = new StringFormat();
				val18.set_Alignment((StringAlignment)1);
				val18.set_LineAlignment((StringAlignment)1);
				graphics.DrawString("NO", val17, dimGray4, num16, num17, val18);
			}
			break;
		case _Type.IO:
			if (Toggled)
			{
				Font val3 = new Font("Segoe UI", 12f, (FontStyle)0);
				Brush whiteSmoke = Brushes.get_WhiteSmoke();
				float num2 = rectangle_0.X + 18;
				float num3 = rectangle_0.Y + 16;
				StringFormat val4 = new StringFormat();
				val4.set_Alignment((StringAlignment)1);
				val4.set_LineAlignment((StringAlignment)1);
				graphics.DrawString("I", val3, whiteSmoke, num2, num3, val4);
			}
			else
			{
				Font val5 = new Font("Segoe UI", 12f, (FontStyle)0);
				Brush dimGray = Brushes.get_DimGray();
				float num4 = rectangle_0.X + 57;
				float num5 = rectangle_0.Y + 16;
				StringFormat val6 = new StringFormat();
				val6.set_Alignment((StringAlignment)1);
				val6.set_LineAlignment((StringAlignment)1);
				graphics.DrawString("O", val5, dimGray, num4, num5, val6);
			}
			break;
		}
	}
}
