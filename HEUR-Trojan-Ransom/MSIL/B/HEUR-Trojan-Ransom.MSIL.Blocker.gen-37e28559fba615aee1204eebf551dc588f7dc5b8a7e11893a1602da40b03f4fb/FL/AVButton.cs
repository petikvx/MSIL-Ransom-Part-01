using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace FL;

public class AVButton : Control
{
	private Color color_0;

	private string string_0;

	private bool bool_0;

	[Description("Select color from the list")]
	[Category("Misc")]
	[TypeConverter(typeof(btnColorProperty))]
	public string MainColor
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = value;
		}
	}

	public AVButton()
	{
		Class8.t3hvLuccnmfIO();
		Class8.t3hvLuccnmfIO();
		((Control)this)._002Ector();
		((Control)this).set_Size(new Size(33, 33));
		((Control)this).set_DoubleBuffered(true);
		((Control)this).SetStyle((ControlStyles)2048, true);
		((Control)this).set_BackColor(Color.Transparent);
	}

	protected override void OnMouseEnter(EventArgs e)
	{
		color_0 = Color.FromArgb(228, 228, 228);
		if (Operators.CompareString(string_0, "Light", false) == 0)
		{
			color_0 = Color.FromArgb(228, 228, 228);
		}
		else
		{
			color_0 = Color.FromArgb(117, 117, 117);
		}
		((Control)this).Invalidate();
		((Control)this).OnMouseEnter(e);
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		color_0 = Color.FromArgb(242, 242, 242);
		if (Operators.CompareString(string_0, "Light", false) == 0)
		{
			color_0 = Color.FromArgb(242, 242, 242);
		}
		else
		{
			color_0 = Color.DimGray;
		}
		((Control)this).Invalidate();
		((Control)this).OnMouseEnter(e);
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		if (Operators.CompareString(string_0, "Light", false) == 0)
		{
			color_0 = Color.FromArgb(228, 228, 228);
		}
		else
		{
			color_0 = Color.FromArgb(117, 117, 117);
		}
		((Control)this).Invalidate();
		((Control)this).OnMouseUp(e);
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		if (Operators.CompareString(string_0, "Light", false) == 0)
		{
			color_0 = Color.FromArgb(151, 151, 151);
		}
		else
		{
			color_0 = Color.FromArgb(66, 66, 66);
		}
		((Control)this).Invalidate();
		((Control)this).OnMouseClick(e);
	}

	public GraphicsPath RoundRect(Rectangle rectangle_0, int int_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		GraphicsPath val = new GraphicsPath();
		checked
		{
			int num = int_0 * 2;
			val.AddArc(new Rectangle(rectangle_0.X, rectangle_0.Y, num, num), -180f, 90f);
			val.AddArc(new Rectangle(rectangle_0.Width - num + rectangle_0.X, rectangle_0.Y, num, num), -90f, 90f);
			val.AddArc(new Rectangle(rectangle_0.Width - num + rectangle_0.X, rectangle_0.Height - num + rectangle_0.Y, num, num), 0f, 90f);
			val.AddArc(new Rectangle(rectangle_0.X, rectangle_0.Height - num + rectangle_0.Y, num, num), 90f, 90f);
			val.AddLine(new Point(rectangle_0.X, rectangle_0.Height - num + rectangle_0.Y), new Point(rectangle_0.X, int_0 + rectangle_0.Y));
			return val;
		}
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected O, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected O, but got Unknown
		//IL_0188: Expected O, but got Unknown
		((Control)this).OnPaint(e);
		Graphics graphics = e.get_Graphics();
		if (!bool_0)
		{
			if (Operators.CompareString(MainColor, "Light", false) == 0)
			{
				color_0 = Color.FromArgb(242, 242, 242);
			}
			else
			{
				color_0 = Color.DimGray;
			}
			bool_0 = true;
		}
		graphics.set_SmoothingMode((SmoothingMode)2);
		checked
		{
			if (Operators.CompareString(MainColor, "Light", false) == 0)
			{
				graphics.FillPath((Brush)new SolidBrush(Color.FromArgb(color_0.ToArgb())), RoundRect(new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1), 5));
			}
			else
			{
				graphics.FillPath((Brush)new SolidBrush(Color.FromArgb(color_0.ToArgb())), RoundRect(new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1), 5));
			}
			graphics.DrawString(((Control)this).get_Text(), new Font("Verdana", 10f), Brushes.get_Black(), (float)((double)((Control)this).get_Width() / 2.0 - (double)(graphics.MeasureString(((Control)this).get_Text(), new Font("Verdana", 10f)).Width / 2f)), (float)((double)((Control)this).get_Height() / 2.0 - (double)(graphics.MeasureString(((Control)this).get_Text(), new Font("Verdana", 10f)).Height / 2f)));
			graphics.set_SmoothingMode((SmoothingMode)3);
		}
	}
}
