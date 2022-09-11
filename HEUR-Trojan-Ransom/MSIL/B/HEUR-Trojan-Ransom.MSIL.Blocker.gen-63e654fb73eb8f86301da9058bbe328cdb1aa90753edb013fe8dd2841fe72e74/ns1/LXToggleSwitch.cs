using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using ns0;

namespace ns1;

public class LXToggleSwitch : Control
{
	public delegate void CheckedChangedEventHandler(object sender);

	private Enum0 enum0_0;

	private bool bool_0;

	[CompilerGenerated]
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
		((Control)this).OnTextChanged(eventArgs_0);
		((Control)this).Invalidate();
	}

	protected override void vmethod_5(EventArgs eventArgs_0)
	{
		((Control)this).OnResize(eventArgs_0);
		((Control)this).set_Height(24);
		((Control)this).set_Width(50);
	}

	protected override void vmethod_6(EventArgs eventArgs_0)
	{
		bool_0 = !bool_0;
		checkedChangedEventHandler_0?.Invoke(this);
		((Control)this).OnClick(eventArgs_0);
	}

	public LXToggleSwitch()
	{
		((Control)this).SetStyle((ControlStyles)133122, true);
		((Control)this).set_BackColor(Color.Transparent);
		((Control)this).set_ForeColor(Color.Black);
		((Control)this).set_Size(new Size(50, 24));
		((Control)this).set_DoubleBuffered(true);
	}

	protected override void vmethod_7(PaintEventArgs paintEventArgs_0)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected O, but got Unknown
		//IL_01cb: Expected O, but got Unknown
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected O, but got Unknown
		//IL_0218: Expected O, but got Unknown
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected O, but got Unknown
		//IL_0265: Expected O, but got Unknown
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected O, but got Unknown
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Expected O, but got Unknown
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Expected O, but got Unknown
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Expected O, but got Unknown
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Expected O, but got Unknown
		//IL_03c5: Expected O, but got Unknown
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Expected O, but got Unknown
		//IL_0412: Expected O, but got Unknown
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_0444: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Expected O, but got Unknown
		//IL_045c: Expected O, but got Unknown
		//IL_0468: Unknown result type (might be due to invalid IL or missing references)
		//IL_0474: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
		val2.set_SmoothingMode((SmoothingMode)2);
		val2.set_CompositingQuality((CompositingQuality)2);
		val2.Clear(Color.Transparent);
		LinearGradientBrush val3 = new LinearGradientBrush(rectangle, Color.FromArgb(40, 40, 40), Color.FromArgb(45, 45, 45), 90f);
		val2.FillPath((Brush)(object)val3, Class7.smethod_0(rectangle, 4));
		val2.DrawPath(new Pen(Color.FromArgb(15, 15, 15)), Class7.smethod_0(rectangle, 4));
		val2.DrawPath(new Pen(Color.FromArgb(50, 50, 50)), Class7.smethod_0(new Rectangle(1, 1, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 3), 4));
		if (Checked)
		{
			val2.FillPath((Brush)new SolidBrush(Color.FromArgb(80, Color.Green)), Class7.smethod_0(new Rectangle(4, 2, 25, ((Control)this).get_Height() - 5), 4));
			val2.FillPath((Brush)new SolidBrush(Color.FromArgb(35, 35, 35)), Class7.smethod_0(new Rectangle(2, 2, 25, ((Control)this).get_Height() - 5), 4));
			val2.DrawPath(new Pen((Brush)new SolidBrush(Color.FromArgb(20, 20, 20))), Class7.smethod_0(new Rectangle(2, 2, 25, ((Control)this).get_Height() - 5), 4));
			switch (enum0_0)
			{
			case Enum0.const_0:
			{
				Font val8 = new Font(" ", 8f, (FontStyle)0);
				Brush silver2 = Brushes.get_Silver();
				PointF pointF3 = new Point(16, ((Control)this).get_Height() - 12);
				StringFormat val9 = new StringFormat();
				val9.set_Alignment((StringAlignment)1);
				val9.set_LineAlignment((StringAlignment)1);
				val2.DrawString(" ", val8, silver2, pointF3, val9);
				break;
			}
			case Enum0.const_1:
			{
				Font val6 = new Font(" ", 8f, (FontStyle)0);
				Brush white = Brushes.get_White();
				PointF pointF2 = new Point(16, ((Control)this).get_Height() - 12);
				StringFormat val7 = new StringFormat();
				val7.set_Alignment((StringAlignment)1);
				val7.set_LineAlignment((StringAlignment)1);
				val2.DrawString(" ", val6, white, pointF2, val7);
				break;
			}
			case Enum0.const_2:
			{
				Font val4 = new Font(" ", 8f, (FontStyle)0);
				Brush silver = Brushes.get_Silver();
				PointF pointF = new Point(16, ((Control)this).get_Height() - 12);
				StringFormat val5 = new StringFormat();
				val5.set_Alignment((StringAlignment)1);
				val5.set_LineAlignment((StringAlignment)1);
				val2.DrawString(" ", val4, silver, pointF, val5);
				break;
			}
			}
		}
		else
		{
			val2.FillPath((Brush)new SolidBrush(Color.FromArgb(60, Color.Red)), Class7.smethod_0(new Rectangle((int)((double)((Control)this).get_Width() / 2.0 - 7.0), 2, ((Control)this).get_Width() - 25, ((Control)this).get_Height() - 5), 4));
			val2.FillPath((Brush)new SolidBrush(Color.FromArgb(35, 35, 35)), Class7.smethod_0(new Rectangle((int)((double)((Control)this).get_Width() / 2.0 - 5.0), 2, ((Control)this).get_Width() - 23, ((Control)this).get_Height() - 5), 4));
			val2.DrawPath(new Pen((Brush)new SolidBrush(Color.FromArgb(20, 20, 20))), Class7.smethod_0(new Rectangle((int)((double)((Control)this).get_Width() / 2.0 - 5.0), 2, ((Control)this).get_Width() - 23, ((Control)this).get_Height() - 5), 4));
			switch (enum0_0)
			{
			case Enum0.const_0:
			{
				Font val14 = new Font(" ", 8f, (FontStyle)0);
				Brush silver4 = Brushes.get_Silver();
				PointF pointF6 = new Point(34, ((Control)this).get_Height() - 11);
				StringFormat val15 = new StringFormat();
				val15.set_Alignment((StringAlignment)1);
				val15.set_LineAlignment((StringAlignment)1);
				val2.DrawString(" ", val14, silver4, pointF6, val15);
				break;
			}
			case Enum0.const_1:
			{
				Font val12 = new Font(" ", 8f, (FontStyle)0);
				Brush white2 = Brushes.get_White();
				PointF pointF5 = new Point(34, ((Control)this).get_Height() - 11);
				StringFormat val13 = new StringFormat();
				val13.set_Alignment((StringAlignment)1);
				val13.set_LineAlignment((StringAlignment)1);
				val2.DrawString(" ", val12, white2, pointF5, val13);
				break;
			}
			case Enum0.const_2:
			{
				Font val10 = new Font(" ", 8f, (FontStyle)0);
				Brush silver3 = Brushes.get_Silver();
				PointF pointF4 = new Point(34, ((Control)this).get_Height() - 11);
				StringFormat val11 = new StringFormat();
				val11.set_Alignment((StringAlignment)1);
				val11.set_LineAlignment((StringAlignment)1);
				val2.DrawString(" ", val10, silver3, pointF4, val11);
				break;
			}
			}
		}
		paintEventArgs_0.get_Graphics().DrawImage((Image)((Image)val).Clone(), 0, 0);
		val2.Dispose();
		((Image)val).Dispose();
	}
}
