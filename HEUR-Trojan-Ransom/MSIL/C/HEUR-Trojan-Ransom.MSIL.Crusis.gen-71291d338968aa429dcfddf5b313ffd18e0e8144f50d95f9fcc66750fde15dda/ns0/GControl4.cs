using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ns0;

[DefaultEvent("CheckedChanged")]
public class GControl4 : Control
{
	public delegate void CheckedChangedEventHandler(object sender);

	private int int_0;

	private bool bool_0;

	private GraphicsPath graphicsPath_0;

	private CheckedChangedEventHandler checkedChangedEventHandler_0;

	public bool Checked
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

	public event CheckedChangedEventHandler CheckedChanged
	{
		add
		{
			checkedChangedEventHandler_0 = (CheckedChangedEventHandler)Delegate.Combine(checkedChangedEventHandler_0, value);
		}
		remove
		{
			checkedChangedEventHandler_0 = (CheckedChangedEventHandler)Delegate.Remove(checkedChangedEventHandler_0, value);
		}
	}

	protected override void vmethod_0(MouseEventArgs mouseEventArgs_0)
	{
		((Control)this).OnMouseMove(mouseEventArgs_0);
		int_0 = mouseEventArgs_0.get_Location().X;
		((Control)this).Invalidate();
	}

	protected override void vmethod_1(MouseEventArgs mouseEventArgs_0)
	{
		bool_0 = !bool_0;
		((Control)this).Focus();
		if (checkedChangedEventHandler_0 != null)
		{
			checkedChangedEventHandler_0(this);
		}
		((Control)this).OnMouseDown(mouseEventArgs_0);
	}

	protected override void vmethod_2(EventArgs eventArgs_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		((Control)this).OnResize(eventArgs_0);
		((Control)this).set_Height(16);
		graphicsPath_0 = new GraphicsPath();
		graphicsPath_0.AddArc(0, 0, 10, 10, 180f, 90f);
		graphicsPath_0.AddArc(((Control)this).get_Width() - 11, 0, 10, 10, -90f, 90f);
		graphicsPath_0.AddArc(((Control)this).get_Width() - 11, ((Control)this).get_Height() - 11, 10, 10, 0f, 90f);
		graphicsPath_0.AddArc(0, ((Control)this).get_Height() - 11, 10, 10, 90f, 90f);
		graphicsPath_0.CloseAllFigures();
		((Control)this).Invalidate();
	}

	public GControl4()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		((Control)this).set_Width(148);
		((Control)this).set_Height(16);
		((Control)this).set_Font(new Font("Microsoft Sans Serif", 9f));
		((Control)this).set_DoubleBuffered(true);
	}

	protected override void vmethod_3(PaintEventArgs paintEventArgs_0)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_00f8: Expected O, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0134: Expected O, but got Unknown
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		((Control)this).OnPaint(paintEventArgs_0);
		Graphics graphics = paintEventArgs_0.get_Graphics();
		graphics.Clear(((Control)this).get_Parent().get_BackColor());
		if (bool_0)
		{
			graphics.FillRectangle((Brush)new SolidBrush(Color.FromArgb(66, 76, 85)), new Rectangle(0, 0, 16, 16));
			graphics.FillRectangle((Brush)new SolidBrush(Color.FromArgb(66, 76, 85)), new Rectangle(1, 1, 14, 14));
		}
		else
		{
			graphics.FillRectangle((Brush)new SolidBrush(Color.FromArgb(66, 76, 85)), new Rectangle(0, 0, 16, 16));
			graphics.FillRectangle((Brush)new SolidBrush(Color.FromArgb(66, 76, 85)), new Rectangle(1, 1, 14, 14));
		}
		if (((Control)this).get_Enabled())
		{
			if (bool_0)
			{
				graphics.DrawString("a", new Font("Marlett", 16f), (Brush)new SolidBrush(Color.FromArgb(181, 41, 42)), (PointF)new Point(-5, -3));
			}
		}
		else if (bool_0)
		{
			graphics.DrawString("a", new Font("Marlett", 16f), (Brush)new SolidBrush(Color.Gray), (PointF)new Point(-5, -3));
		}
		graphics.DrawString(((Control)this).get_Text(), ((Control)this).get_Font(), (Brush)new SolidBrush(Color.FromArgb(116, 125, 132)), (PointF)new Point(20, 0));
	}
}
