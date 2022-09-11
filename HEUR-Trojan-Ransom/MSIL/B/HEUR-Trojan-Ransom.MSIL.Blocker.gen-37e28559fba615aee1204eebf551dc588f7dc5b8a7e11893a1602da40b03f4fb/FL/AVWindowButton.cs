using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace FL;

public class AVWindowButton : Control
{
	private Color color_0;

	private string string_0;

	[TypeConverter(typeof(btnimProperty))]
	[Category("Misc")]
	[Description("Select Image from the list")]
	public string SetImage
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

	public AVWindowButton()
	{
		Class8.t3hvLuccnmfIO();
		Class8.t3hvLuccnmfIO();
		((Control)this)._002Ector();
		color_0 = Color.FromArgb(242, 242, 242);
		string_0 = "Close";
		((Control)this).set_Size(new Size(33, 33));
		((Control)this).set_DoubleBuffered(true);
		((Control)this).SetStyle((ControlStyles)2048, true);
		((Control)this).set_BackColor(Color.Transparent);
	}

	protected override void OnMouseEnter(EventArgs e)
	{
		color_0 = Color.FromArgb(228, 228, 228);
		((Control)this).Invalidate();
		((Control)this).OnMouseEnter(e);
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		color_0 = Color.FromArgb(242, 242, 242);
		((Control)this).Invalidate();
		((Control)this).OnMouseEnter(e);
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		color_0 = Color.FromArgb(214, 214, 214);
		((Control)this).Invalidate();
		((Control)this).OnMouseUp(e);
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		color_0 = Color.FromArgb(151, 151, 151);
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
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected O, but got Unknown
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected O, but got Unknown
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected O, but got Unknown
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Expected O, but got Unknown
		((Control)this).OnPaint(e);
		Graphics graphics = e.get_Graphics();
		graphics.set_SmoothingMode((SmoothingMode)2);
		checked
		{
			graphics.FillPath((Brush)new SolidBrush(Color.FromArgb(color_0.ToArgb())), RoundRect(new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1), 3));
			graphics.set_SmoothingMode((SmoothingMode)3);
			if (Operators.CompareString(string_0, "Close", false) == 0)
			{
				Pen val = new Pen(Brushes.get_DimGray(), 2f);
				try
				{
					val.set_StartCap((LineCap)3);
					val.set_EndCap((LineCap)3);
					graphics.DrawLine(val, 6, 6, ((Control)this).get_Width() - 6, ((Control)this).get_Height() - 6);
					graphics.DrawLine(val, ((Control)this).get_Width() - 6, 6, 6, ((Control)this).get_Height() - 6);
					return;
				}
				finally
				{
					((IDisposable)val)?.Dispose();
				}
			}
			if (Operators.CompareString(string_0, "Minimize", false) == 0)
			{
				Pen val2 = new Pen(Brushes.get_DimGray(), 2f);
				try
				{
					val2.set_StartCap((LineCap)3);
					val2.set_EndCap((LineCap)3);
					graphics.DrawLine(val2, 6, ((Control)this).get_Height() - 6, ((Control)this).get_Width() - 6, ((Control)this).get_Height() - 6);
					return;
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
			}
			if (Operators.CompareString(string_0, "Maximize", false) == 0)
			{
				Pen val3 = new Pen(Brushes.get_DimGray(), 2f);
				try
				{
					val3.set_StartCap((LineCap)3);
					val3.set_EndCap((LineCap)3);
					graphics.FillRectangle((Brush)new SolidBrush(Color.FromArgb(color_0.ToArgb())), 6, 8, 16, 13);
					graphics.DrawRectangle(val3, 6, 8, 16, 13);
					graphics.FillRectangle((Brush)new SolidBrush(Color.FromArgb(color_0.ToArgb())), 12, ((Control)this).get_Height() - 19, 16, 13);
					graphics.DrawRectangle(val3, 12, ((Control)this).get_Height() - 19, 16, 13);
					return;
				}
				finally
				{
					((IDisposable)val3)?.Dispose();
				}
			}
			if (Operators.CompareString(string_0, "Stop", false) == 0)
			{
				Rectangle rectangle = new Rectangle((int)Math.Round((double)((Control)this).get_Height() / 2.0 - 6.0), (int)Math.Round((double)((Control)this).get_Width() / 2.0 - 6.0), 12, 12);
				graphics.FillRectangle((Brush)new SolidBrush(Color.DimGray), rectangle);
			}
			else if (Operators.CompareString(string_0, "Play", false) == 0)
			{
				graphics.set_SmoothingMode((SmoothingMode)4);
				PointF[] array = new PointF[4]
				{
					new PointF(10f, 10f),
					new PointF(((Control)this).get_Width() - 10, (float)((double)((Control)this).get_Height() / 2.0)),
					new PointF(10f, ((Control)this).get_Height() - 10),
					new PointF(10f, 10f)
				};
				GraphicsPath val4 = new GraphicsPath((FillMode)0);
				val4.AddLines(array);
				val4.CloseFigure();
				graphics.FillPath(Brushes.get_DimGray(), val4);
			}
		}
	}
}
