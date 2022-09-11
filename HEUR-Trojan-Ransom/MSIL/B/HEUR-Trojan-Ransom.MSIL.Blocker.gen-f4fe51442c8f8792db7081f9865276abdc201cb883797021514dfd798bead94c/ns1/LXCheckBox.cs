using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using ns0;

namespace ns1;

public class LXCheckBox : Control
{
	public delegate void CheckedChangedEventHandler(object sender);

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 6)]
	private struct Struct1
	{
	}

	private bool bool_0;

	private Color color_0;

	[CompilerGenerated]
	private CheckedChangedEventHandler checkedChangedEventHandler_0;

	private static readonly Array array_0;

	private static readonly Array array_1 = new char[3];

	private static readonly Array array_2;

	internal static byte byte_0/* Not supported: data(00) */;

	internal Enum0 enum0_0;

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

	public Color AccentColor
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
		((Control)this).set_Height(12);
	}

	protected override void vmethod_6(EventArgs eventArgs_0)
	{
		bool_0 = !bool_0;
		checkedChangedEventHandler_0?.Invoke(this);
		((Control)this).OnClick(eventArgs_0);
	}

	public LXCheckBox()
	{
		((Control)this).SetStyle((ControlStyles)133122, true);
		((Control)this).set_BackColor(Color.Transparent);
		((Control)this).set_ForeColor(Color.Black);
		((Control)this).set_Size(new Size(115, 12));
		color_0 = Color.Maroon;
		((Control)this).set_DoubleBuffered(true);
	}

	protected override void vmethod_7(PaintEventArgs paintEventArgs_0)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Height() - 1, ((Control)this).get_Height() - 1);
		Rectangle rectangle2 = new Rectangle(5, 5, ((Control)this).get_Height() - 11, ((Control)this).get_Height() - 11);
		val2.set_SmoothingMode((SmoothingMode)2);
		val2.set_CompositingQuality((CompositingQuality)2);
		val2.Clear(((Control)this).get_BackColor());
		LinearGradientBrush val3 = new LinearGradientBrush(rectangle, Color.FromArgb(50, 50, 50), Color.FromArgb(40, 40, 40), 90f);
		val2.FillRectangle((Brush)(object)val3, rectangle);
		val2.DrawRectangle(new Pen(Color.FromArgb(20, 20, 20)), rectangle);
		val2.DrawRectangle(new Pen(Color.FromArgb(55, 55, 55)), new Rectangle(1, 1, ((Control)this).get_Height() - 3, ((Control)this).get_Height() - 3));
		if (Checked)
		{
			LinearGradientBrush val4 = new LinearGradientBrush(rectangle2, color_0, Color.FromArgb(color_0.R + 5, color_0.G + 5, color_0.B + 5), 90f);
			val2.FillRectangle((Brush)(object)val4, rectangle2);
			val2.DrawRectangle(new Pen(Color.FromArgb(25, 25, 25)), rectangle2);
		}
		Font val5 = new Font(" ", 8f, (FontStyle)0);
		Brush val6 = (Brush)new SolidBrush(Color.FromArgb(200, 200, 200));
		string text = ((Control)this).get_Text();
		PointF pointF = new Point(15, 6);
		StringFormat val7 = new StringFormat();
		val7.set_Alignment((StringAlignment)0);
		val7.set_LineAlignment((StringAlignment)1);
		val2.DrawString(text, val5, val6, pointF, val7);
		paintEventArgs_0.get_Graphics().DrawImage((Image)((Image)val).Clone(), 0, 0);
		val2.Dispose();
		((Image)val).Dispose();
	}

	static LXCheckBox()
	{
		char[] array = new char[8];
		array[4] = '⫸';
		array[1] = '⇛';
		array[2] = 'ᔤ';
		array[5] = 'Ӿ';
		array[6] = '㑬';
		array[0] = '\u192f';
		array[3] = 'ᒣ';
		array[7] = '࿊';
		array_2 = new string[1];
		array_0 = array;
	}
}
