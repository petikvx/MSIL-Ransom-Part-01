using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using ns0;

namespace ns1;

public class LXRadioButton : Control
{
	public delegate void CheckedChangedEventHandler(object sender);

	private Enum0 enum0_0;

	[CompilerGenerated]
	private CheckedChangedEventHandler checkedChangedEventHandler_0;

	internal Rectangle rectangle_0;

	internal LinearGradientBrush linearGradientBrush_0;

	internal bool bool_0;

	public bool Checked
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool flag = (bool_0 = value);
			method_0();
			checkedChangedEventHandler_0?.Invoke(this);
			((Control)this).Invalidate();
		}
	}

	public event CheckedChangedEventHandler CheckedChanged
	{
		[CompilerGenerated]
		add
		{
			CheckedChangedEventHandler checkedChangedEventHandler = checkedChangedEventHandler_0;
			CheckedChangedEventHandler checkedChangedEventHandler2;
			do
			{
				checkedChangedEventHandler2 = checkedChangedEventHandler;
				CheckedChangedEventHandler value2 = (CheckedChangedEventHandler)Delegate.Combine(checkedChangedEventHandler2, value);
				checkedChangedEventHandler = Interlocked.CompareExchange(ref checkedChangedEventHandler_0, value2, checkedChangedEventHandler2);
			}
			while ((object)checkedChangedEventHandler != checkedChangedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			CheckedChangedEventHandler checkedChangedEventHandler = checkedChangedEventHandler_0;
			CheckedChangedEventHandler checkedChangedEventHandler2;
			do
			{
				checkedChangedEventHandler2 = checkedChangedEventHandler;
				CheckedChangedEventHandler value2 = (CheckedChangedEventHandler)Delegate.Remove(checkedChangedEventHandler2, value);
				checkedChangedEventHandler = Interlocked.CompareExchange(ref checkedChangedEventHandler_0, value2, checkedChangedEventHandler2);
			}
			while ((object)checkedChangedEventHandler != checkedChangedEventHandler2);
		}
	}

	protected override void vmethod_0(EventArgs eventArgs_0)
	{
		((Control)this).OnMouseEnter(eventArgs_0);
		enum0_0 = Enum0.const_1;
		((Control)this).Invalidate();
	}

	protected override void vmethod_1(MouseEventArgs mouseEventArgs_0)
	{
		((Control)this).OnMouseDown(mouseEventArgs_0);
		enum0_0 = Enum0.const_2;
		((Control)this).Invalidate();
	}

	protected override void vmethod_2(EventArgs eventArgs_0)
	{
		((Control)this).OnMouseLeave(eventArgs_0);
		enum0_0 = Enum0.const_0;
		((Control)this).Invalidate();
	}

	protected override void vmethod_3(MouseEventArgs mouseEventArgs_0)
	{
		((Control)this).OnMouseUp(mouseEventArgs_0);
		enum0_0 = Enum0.const_1;
		((Control)this).Invalidate();
	}

	protected override void vmethod_4(EventArgs eventArgs_0)
	{
		((Control)this).OnResize(eventArgs_0);
		((Control)this).set_Height(13);
	}

	protected override void vmethod_5(EventArgs eventArgs_0)
	{
		((Control)this).OnTextChanged(eventArgs_0);
		((Control)this).Invalidate();
	}

	protected override void vmethod_6(EventArgs eventArgs_0)
	{
		if (!bool_0)
		{
			Checked = true;
		}
		((Control)this).OnClick(eventArgs_0);
	}

	protected override void vmethod_7()
	{
		((Control)this).OnCreateControl();
		method_0();
	}

	private void method_0()
	{
		if (((Control)this).get_IsHandleCreated())
		{
		}
	}

	public LXRadioButton()
	{
		((Control)this).SetStyle((ControlStyles)2050, true);
		((Control)this).set_BackColor(Color.Transparent);
		((Control)this).set_ForeColor(Color.Black);
		((Control)this).set_Size(new Size(150, 16));
		((Control)this).set_DoubleBuffered(true);
	}

	protected override void vmethod_8(PaintEventArgs paintEventArgs_0)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Height(), ((Control)this).get_Height() - 1);
		Rectangle rectangle2 = new Rectangle(1, 1, ((Control)this).get_Height() - 2, ((Control)this).get_Height() - 3);
		val2.set_SmoothingMode((SmoothingMode)2);
		val2.set_CompositingQuality((CompositingQuality)2);
		val2.Clear(((Control)this).get_BackColor());
		LinearGradientBrush val3 = new LinearGradientBrush(rectangle, Color.FromArgb(50, 50, 50), Color.FromArgb(40, 40, 40), 90f);
		val2.FillEllipse((Brush)(object)val3, rectangle);
		val2.DrawEllipse(new Pen(Color.FromArgb(20, 20, 20)), rectangle);
		val2.DrawEllipse(new Pen(Color.FromArgb(55, 55, 55)), rectangle2);
		if (Checked)
		{
			val2.DrawEllipse(new Pen(Color.FromArgb(25, 25, 25)), rectangle2);
		}
		Font val4 = new Font(" ", 8f, (FontStyle)0);
		Brush val5 = (Brush)new SolidBrush(Color.FromArgb(200, 200, 200));
		string text = ((Control)this).get_Text();
		PointF pointF = new Point(18, 7);
		StringFormat val6 = new StringFormat();
		val6.set_Alignment((StringAlignment)0);
		val6.set_LineAlignment((StringAlignment)1);
		val2.DrawString(text, val4, val5, pointF, val6);
		paintEventArgs_0.get_Graphics().DrawImage((Image)((Image)val).Clone(), 0, 0);
		val2.Dispose();
		((Image)val).Dispose();
	}
}
