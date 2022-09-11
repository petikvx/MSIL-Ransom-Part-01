using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace ns1;

[DefaultEvent("CheckedChanged")]
public class MonoFlat_RadioButton : Control
{
	public delegate void CheckedChangedEventHandler(object sender);

	private bool bool_0;

	private CheckedChangedEventHandler checkedChangedEventHandler_0;

	internal int int_0;

	public bool Checked
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
			method_0();
			if (checkedChangedEventHandler_0 != null)
			{
				checkedChangedEventHandler_0(this);
			}
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
		if (!bool_0)
		{
			Checked = true;
		}
		((Control)this).Focus();
		((Control)this).OnMouseDown(mouseEventArgs_0);
	}

	protected override void vmethod_1(MouseEventArgs mouseEventArgs_0)
	{
		((Control)this).OnMouseMove(mouseEventArgs_0);
		int num = (int_0 = mouseEventArgs_0.get_X());
		((Control)this).Invalidate();
	}

	protected override void vmethod_2(EventArgs eventArgs_0)
	{
		((Control)this).OnTextChanged(eventArgs_0);
		int num = 0;
		num = (int)((Control)this).CreateGraphics().MeasureString(((Control)this).get_Text(), ((Control)this).get_Font()).Width;
		((Control)this).set_Width(28 + num);
	}

	protected override void vmethod_3(EventArgs eventArgs_0)
	{
		((Control)this).OnResize(eventArgs_0);
		((Control)this).set_Height(17);
	}

	public MonoFlat_RadioButton()
	{
		((Control)this).set_Width(159);
		((Control)this).set_Height(17);
		((Control)this).set_DoubleBuffered(true);
	}

	private void method_0()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		if (!((Control)this).get_IsHandleCreated() || !bool_0)
		{
			return;
		}
		foreach (Control item in (ArrangedElementCollection)((Control)this).get_Parent().get_Controls())
		{
			Control val = item;
			if (val != this && val is MonoFlat_RadioButton)
			{
				((MonoFlat_RadioButton)(object)val).Checked = false;
			}
		}
	}

	protected override void vmethod_4(PaintEventArgs paintEventArgs_0)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008a: Expected O, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		((Control)this).OnPaint(paintEventArgs_0);
		Graphics graphics = paintEventArgs_0.get_Graphics();
		graphics.Clear(((Control)this).get_Parent().get_BackColor());
		graphics.set_SmoothingMode((SmoothingMode)2);
		graphics.FillEllipse((Brush)new SolidBrush(Color.FromArgb(66, 76, 85)), new Rectangle(0, 0, 16, 16));
		if (bool_0)
		{
			graphics.DrawString("a", new Font("Marlett", 15f), (Brush)new SolidBrush(Color.FromArgb(181, 41, 42)), (PointF)new Point(-3, -2));
		}
		graphics.DrawString(((Control)this).get_Text(), ((Control)this).get_Font(), (Brush)new SolidBrush(Color.FromArgb(116, 125, 132)), (PointF)new Point(20, 0));
	}
}
