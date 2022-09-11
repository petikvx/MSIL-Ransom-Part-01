using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ns0;

public class GControl2 : Control
{
	private Image image_0;

	private Size size_0;

	internal Color color_0;

	public Image Image
	{
		get
		{
			return image_0;
		}
		set
		{
			if (value == null)
			{
				size_0 = Size.Empty;
			}
			else
			{
				size_0 = value.get_Size();
			}
			image_0 = value;
			((Control)this).Invalidate();
		}
	}

	protected Size ImageSize => size_0;

	protected override void vmethod_0(EventArgs eventArgs_0)
	{
		((Control)this).OnResize(eventArgs_0);
		((Control)this).set_Size(new Size(54, 54));
	}

	protected override void vmethod_1(EventArgs eventArgs_0)
	{
		((Control)this).OnMouseEnter(eventArgs_0);
		Color color = (color_0 = Color.FromArgb(181, 41, 42));
		((Control)this).Refresh();
	}

	protected override void vmethod_2(EventArgs eventArgs_0)
	{
		((Control)this).OnMouseLeave(eventArgs_0);
		Color color = (color_0 = Color.FromArgb(66, 76, 85));
		((Control)this).Refresh();
	}

	protected override void vmethod_3(MouseEventArgs mouseEventArgs_0)
	{
		((Control)this).OnMouseDown(mouseEventArgs_0);
		Color color = (color_0 = Color.FromArgb(153, 34, 34));
		((Control)this).Focus();
		((Control)this).Refresh();
	}

	protected override void vmethod_4(MouseEventArgs mouseEventArgs_0)
	{
		((Control)this).OnMouseUp(mouseEventArgs_0);
		Color color = (color_0 = Color.FromArgb(181, 41, 42));
		((Control)this).Refresh();
	}

	private static PointF smethod_0(StringFormat stringFormat_0, SizeF sizeF_0, SizeF sizeF_1)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Invalid comparison between Unknown and I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Invalid comparison between Unknown and I4
		PointF result = default(PointF);
		StringAlignment alignment = stringFormat_0.get_Alignment();
		if ((int)alignment == 1)
		{
			result.X = (sizeF_0.Width - sizeF_1.Width) / 2f;
		}
		alignment = stringFormat_0.get_LineAlignment();
		if ((int)alignment == 1)
		{
			result.Y = (sizeF_0.Height - sizeF_1.Height) / 2f;
		}
		return result;
	}

	private StringFormat method_0(ContentAlignment contentAlignment_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		StringFormat val = new StringFormat();
		if ((int)contentAlignment_0 == 32)
		{
			val.set_LineAlignment((StringAlignment)1);
			val.set_Alignment((StringAlignment)1);
		}
		return val;
	}

	public GControl2()
	{
		((Control)this).set_DoubleBuffered(true);
		Color color = (color_0 = Color.FromArgb(66, 76, 85));
	}

	protected override void vmethod_5(PaintEventArgs paintEventArgs_0)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		Graphics graphics = paintEventArgs_0.get_Graphics();
		graphics.Clear(((Control)this).get_Parent().get_BackColor());
		graphics.set_SmoothingMode((SmoothingMode)2);
		PointF pointF = smethod_0(method_0((ContentAlignment)32), ((Control)this).get_Size(), ImageSize);
		graphics.FillEllipse((Brush)new SolidBrush(color_0), new Rectangle(0, 0, 53, 53));
		if (Image != null)
		{
			graphics.DrawImage(image_0, (int)pointF.X, (int)pointF.Y, ImageSize.Width, ImageSize.Height);
		}
	}
}
