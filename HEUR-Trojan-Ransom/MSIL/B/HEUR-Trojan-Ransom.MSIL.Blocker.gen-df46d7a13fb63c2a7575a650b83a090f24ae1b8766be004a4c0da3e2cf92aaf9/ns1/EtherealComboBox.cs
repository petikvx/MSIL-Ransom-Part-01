using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace ns1;

public class EtherealComboBox : ComboBox
{
	private Color color_0;

	internal int int_0;

	internal Color color_1;

	internal Color color_2;

	public int StartIndex
	{
		get
		{
			return int_0;
		}
		set
		{
			int num = (int_0 = value);
			try
			{
				((ComboBox)this).set_SelectedIndex(value);
			}
			catch
			{
			}
			((Control)this).Invalidate();
		}
	}

	public Color BorderColor
	{
		get
		{
			return color_1;
		}
		set
		{
			Color color = (color_1 = value);
			((Control)this).Invalidate();
		}
	}

	public Color TextColor
	{
		get
		{
			return color_2;
		}
		set
		{
			Color color = (color_2 = value);
			((Control)this).Invalidate();
		}
	}

	public Color TriangleColor
	{
		get
		{
			return color_0;
		}
		set
		{
			color_0 = value;
			((Control)this).Invalidate();
		}
	}

	public EtherealComboBox()
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		Color color = (color_1 = HelperMethods.smethod_11(" "));
		Color color2 = (color_2 = HelperMethods.smethod_11(" "));
		color_0 = HelperMethods.smethod_11("   ");
		((ComboBox)this)._002Ector();
		((Control)this).SetStyle((ControlStyles)141314, true);
		((ComboBox)this).set_DrawMode((DrawMode)1);
		((Control)this).set_Size(new Size(200, 35));
		((ComboBox)this).set_DropDownStyle((ComboBoxStyle)2);
		((Control)this).set_Font(new Font(" ", 15f));
		((Control)this).set_BackColor(Color.Transparent);
		((Control)this).set_DoubleBuffered(true);
	}

	protected override void vmethod_0(PaintEventArgs paintEventArgs_0)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_011e: Expected O, but got Unknown
		((Control)this).OnPaint(paintEventArgs_0);
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		try
		{
			Rectangle rectangle_ = new Rectangle(1, 1, ((Control)this).get_Width() - 2, ((Control)this).get_Height() - 2);
			val2.set_TextRenderingHint((TextRenderingHint)4);
			val2.set_SmoothingMode((SmoothingMode)2);
			val2.set_PixelOffsetMode((PixelOffsetMode)2);
			HelperMethods.smethod_6(val2, TriangleColor, 2f, new Point(((Control)this).get_Width() - 20, 16), new Point(((Control)this).get_Width() - 16, 20), new Point(((Control)this).get_Width() - 16, 20), new Point(((Control)this).get_Width() - 12, 16), new Point(((Control)this).get_Width() - 16, 21), new Point(((Control)this).get_Width() - 16, 20));
			HelperMethods.smethod_5(val2, BorderColor, 1f, rectangle_, 4);
			string text = ((Control)this).get_Text();
			Font font = ((Control)this).get_Font();
			SolidBrush val3 = new SolidBrush(TextColor);
			RectangleF rectangleF = new Rectangle(7, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			StringFormat val4 = new StringFormat();
			val4.set_LineAlignment((StringAlignment)1);
			val4.set_Alignment((StringAlignment)0);
			val2.DrawString(text, font, (Brush)val3, rectangleF, val4);
			paintEventArgs_0.get_Graphics().DrawImage((Image)(object)val, 0, 0);
			val2.Dispose();
			((Image)val).Dispose();
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
	}

	protected override void vmethod_1(DrawItemEventArgs drawItemEventArgs_0)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		drawItemEventArgs_0.get_Graphics().set_SmoothingMode((SmoothingMode)2);
		drawItemEventArgs_0.get_Graphics().set_TextRenderingHint((TextRenderingHint)4);
		if (Convert.ToInt32((object)(DrawItemState)(drawItemEventArgs_0.get_State() & 1)) == 1)
		{
			if (drawItemEventArgs_0.get_Index() != -1)
			{
				drawItemEventArgs_0.get_Graphics().FillRectangle((Brush)(object)HelperMethods.smethod_10(" "), drawItemEventArgs_0.get_Bounds());
				drawItemEventArgs_0.get_Graphics().DrawString(((ListControl)this).GetItemText(((ComboBox)this).get_Items().get_Item(drawItemEventArgs_0.get_Index())), drawItemEventArgs_0.get_Font(), (Brush)new SolidBrush(Color.WhiteSmoke), (RectangleF)drawItemEventArgs_0.get_Bounds());
			}
		}
		else if (drawItemEventArgs_0.get_Index() != -1)
		{
			drawItemEventArgs_0.get_Graphics().FillRectangle((Brush)new SolidBrush(drawItemEventArgs_0.get_BackColor()), drawItemEventArgs_0.get_Bounds());
			drawItemEventArgs_0.get_Graphics().DrawString(((ListControl)this).GetItemText(((ComboBox)this).get_Items().get_Item(drawItemEventArgs_0.get_Index())), drawItemEventArgs_0.get_Font(), (Brush)(object)HelperMethods.smethod_10(" "), (RectangleF)drawItemEventArgs_0.get_Bounds());
		}
		((Control)this).Invalidate();
	}

	protected override void vmethod_2()
	{
		((Control)this).OnCreateControl();
	}

	protected override void vmethod_3(EventArgs eventArgs_0)
	{
		((ComboBox)this).OnResize(eventArgs_0);
	}
}
