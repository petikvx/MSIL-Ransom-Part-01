using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ns1;

public class MonoFlat_Button : Control
{
	private int int_0;

	private GraphicsPath graphicsPath_0;

	private LinearGradientBrush linearGradientBrush_0;

	private LinearGradientBrush linearGradientBrush_1;

	private Pen pen_0;

	private Image image_0;

	private StringAlignment stringAlignment_0 = (StringAlignment)1;

	private Color color_0;

	internal Rectangle rectangle_0;

	internal Pen pen_1;

	internal Size size_0;

	internal ContentAlignment contentAlignment_0 = (ContentAlignment)16;

	public Image Image
	{
		get
		{
			return image_0;
		}
		set
		{
			if (value != null)
			{
				Size size = (size_0 = value.get_Size());
			}
			else
			{
				Size size2 = (size_0 = Size.Empty);
			}
			image_0 = value;
			((Control)this).Invalidate();
		}
	}

	protected Size ImageSize => size_0;

	public ContentAlignment ImageAlign
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return contentAlignment_0;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			ContentAlignment val = (contentAlignment_0 = value);
			((Control)this).Invalidate();
		}
	}

	public StringAlignment TextAlignment
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return stringAlignment_0;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			stringAlignment_0 = value;
			((Control)this).Invalidate();
		}
	}

	public override Color ForeColor
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

	private static PointF smethod_0(StringFormat stringFormat_0, SizeF sizeF_0, SizeF sizeF_1)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected I4, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected I4, but got Unknown
		PointF result = default(PointF);
		StringAlignment alignment = stringFormat_0.get_Alignment();
		switch ((int)alignment)
		{
		case 0:
			result.X = 2f;
			break;
		case 1:
			result.X = (sizeF_0.Width - sizeF_1.Width) / 2f;
			break;
		case 2:
			result.X = sizeF_0.Width - sizeF_1.Width - 2f;
			break;
		}
		alignment = stringFormat_0.get_LineAlignment();
		switch ((int)alignment)
		{
		case 0:
			result.Y = 2f;
			break;
		case 1:
			result.Y = (sizeF_0.Height - sizeF_1.Height) / 2f;
			break;
		case 2:
			result.Y = sizeF_0.Height - sizeF_1.Height - 2f;
			break;
		}
		return result;
	}

	private StringFormat method_0(ContentAlignment contentAlignment_1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected I4, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Invalid comparison between Unknown and I4
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Invalid comparison between Unknown and I4
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Invalid comparison between Unknown and I4
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Invalid comparison between Unknown and I4
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Invalid comparison between Unknown and I4
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Invalid comparison between Unknown and I4
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Invalid comparison between Unknown and I4
		StringFormat val = new StringFormat();
		if ((int)contentAlignment_1 <= 32)
		{
			switch (contentAlignment_1 - 1)
			{
			default:
				if ((int)contentAlignment_1 != 16)
				{
					if ((int)contentAlignment_1 == 32)
					{
						val.set_LineAlignment((StringAlignment)1);
						val.set_Alignment((StringAlignment)1);
					}
				}
				else
				{
					val.set_LineAlignment((StringAlignment)1);
					val.set_Alignment((StringAlignment)0);
				}
				break;
			case 0:
				val.set_LineAlignment((StringAlignment)0);
				val.set_Alignment((StringAlignment)0);
				break;
			case 1:
				val.set_LineAlignment((StringAlignment)0);
				val.set_Alignment((StringAlignment)1);
				break;
			case 3:
				val.set_LineAlignment((StringAlignment)0);
				val.set_Alignment((StringAlignment)2);
				break;
			case 2:
				break;
			}
		}
		else if ((int)contentAlignment_1 <= 256)
		{
			if ((int)contentAlignment_1 != 64)
			{
				if ((int)contentAlignment_1 == 256)
				{
					val.set_LineAlignment((StringAlignment)2);
					val.set_Alignment((StringAlignment)0);
				}
			}
			else
			{
				val.set_LineAlignment((StringAlignment)1);
				val.set_Alignment((StringAlignment)2);
			}
		}
		else if ((int)contentAlignment_1 != 512)
		{
			if ((int)contentAlignment_1 == 1024)
			{
				val.set_LineAlignment((StringAlignment)2);
				val.set_Alignment((StringAlignment)2);
			}
		}
		else
		{
			val.set_LineAlignment((StringAlignment)2);
			val.set_Alignment((StringAlignment)1);
		}
		return val;
	}

	protected override void vmethod_0(MouseEventArgs mouseEventArgs_0)
	{
		int_0 = 0;
		((Control)this).Invalidate();
		((Control)this).OnMouseUp(mouseEventArgs_0);
	}

	protected override void vmethod_1(MouseEventArgs mouseEventArgs_0)
	{
		int_0 = 1;
		((Control)this).Focus();
		((Control)this).Invalidate();
		((Control)this).OnMouseDown(mouseEventArgs_0);
	}

	protected override void vmethod_2(EventArgs eventArgs_0)
	{
		int_0 = 0;
		((Control)this).Invalidate();
		((Control)this).OnMouseLeave(eventArgs_0);
	}

	protected override void vmethod_3(EventArgs eventArgs_0)
	{
		((Control)this).Invalidate();
		((Control)this).OnTextChanged(eventArgs_0);
	}

	public MonoFlat_Button()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		((Control)this).SetStyle((ControlStyles)141330, true);
		((Control)this).set_BackColor(Color.Transparent);
		((Control)this).set_DoubleBuffered(true);
		((Control)this).set_Font(new Font("Segoe UI", 12f));
		((Control)this).set_ForeColor(Color.FromArgb(255, 255, 255));
		((Control)this).set_Size(new Size(146, 41));
		stringAlignment_0 = (StringAlignment)1;
		Pen val = (pen_1 = new Pen(Color.FromArgb(181, 41, 42)));
		pen_0 = new Pen(Color.FromArgb(165, 37, 37));
	}

	protected override void vmethod_4(EventArgs eventArgs_0)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		((Control)this).OnResize(eventArgs_0);
		if (((Control)this).get_Width() > 0 && ((Control)this).get_Height() > 0)
		{
			graphicsPath_0 = new GraphicsPath();
			Rectangle rectangle = (rectangle_0 = new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height()));
			linearGradientBrush_0 = new LinearGradientBrush(new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height()), Color.FromArgb(181, 41, 42), Color.FromArgb(181, 41, 42), 90f);
			linearGradientBrush_1 = new LinearGradientBrush(new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height()), Color.FromArgb(165, 37, 37), Color.FromArgb(165, 37, 37), 90f);
		}
		graphicsPath_0.AddArc(0, 0, 10, 10, 180f, 90f);
		graphicsPath_0.AddArc(((Control)this).get_Width() - 11, 0, 10, 10, -90f, 90f);
		graphicsPath_0.AddArc(((Control)this).get_Width() - 11, ((Control)this).get_Height() - 11, 10, 10, 0f, 90f);
		graphicsPath_0.AddArc(0, ((Control)this).get_Height() - 11, 10, 10, 90f, 90f);
		graphicsPath_0.CloseAllFigures();
		((Control)this).Invalidate();
	}

	protected override void vmethod_5(PaintEventArgs paintEventArgs_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00b8: Expected O, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected O, but got Unknown
		//IL_0135: Expected O, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected O, but got Unknown
		//IL_01a6: Expected O, but got Unknown
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected O, but got Unknown
		//IL_0220: Expected O, but got Unknown
		Graphics graphics = paintEventArgs_0.get_Graphics();
		graphics.set_SmoothingMode((SmoothingMode)2);
		PointF pointF = smethod_0(method_0(ImageAlign), ((Control)this).get_Size(), ImageSize);
		switch (int_0)
		{
		case 1:
			graphics.FillPath((Brush)(object)linearGradientBrush_1, graphicsPath_0);
			graphics.DrawPath(pen_0, graphicsPath_0);
			if (Image == null)
			{
				string text3 = ((Control)this).get_Text();
				Font font3 = ((Control)this).get_Font();
				SolidBrush val5 = new SolidBrush(((Control)this).get_ForeColor());
				RectangleF rectangleF3 = rectangle_0;
				StringFormat val6 = new StringFormat();
				val6.set_Alignment(stringAlignment_0);
				val6.set_LineAlignment((StringAlignment)1);
				graphics.DrawString(text3, font3, (Brush)val5, rectangleF3, val6);
			}
			else
			{
				graphics.DrawImage(image_0, pointF.X, pointF.Y, (float)ImageSize.Width, (float)ImageSize.Height);
				string text4 = ((Control)this).get_Text();
				Font font4 = ((Control)this).get_Font();
				SolidBrush val7 = new SolidBrush(((Control)this).get_ForeColor());
				RectangleF rectangleF4 = rectangle_0;
				StringFormat val8 = new StringFormat();
				val8.set_Alignment(stringAlignment_0);
				val8.set_LineAlignment((StringAlignment)1);
				graphics.DrawString(text4, font4, (Brush)val7, rectangleF4, val8);
			}
			break;
		case 0:
			graphics.FillPath((Brush)(object)linearGradientBrush_0, graphicsPath_0);
			graphics.DrawPath(pen_1, graphicsPath_0);
			if (Image == null)
			{
				string text = ((Control)this).get_Text();
				Font font = ((Control)this).get_Font();
				SolidBrush val = new SolidBrush(((Control)this).get_ForeColor());
				RectangleF rectangleF = rectangle_0;
				StringFormat val2 = new StringFormat();
				val2.set_Alignment(stringAlignment_0);
				val2.set_LineAlignment((StringAlignment)1);
				graphics.DrawString(text, font, (Brush)val, rectangleF, val2);
			}
			else
			{
				graphics.DrawImage(image_0, pointF.X, pointF.Y, (float)ImageSize.Width, (float)ImageSize.Height);
				string text2 = ((Control)this).get_Text();
				Font font2 = ((Control)this).get_Font();
				SolidBrush val3 = new SolidBrush(((Control)this).get_ForeColor());
				RectangleF rectangleF2 = rectangle_0;
				StringFormat val4 = new StringFormat();
				val4.set_Alignment(stringAlignment_0);
				val4.set_LineAlignment((StringAlignment)1);
				graphics.DrawString(text2, font2, (Brush)val3, rectangleF2, val4);
			}
			break;
		}
		((Control)this).OnPaint(paintEventArgs_0);
	}
}
