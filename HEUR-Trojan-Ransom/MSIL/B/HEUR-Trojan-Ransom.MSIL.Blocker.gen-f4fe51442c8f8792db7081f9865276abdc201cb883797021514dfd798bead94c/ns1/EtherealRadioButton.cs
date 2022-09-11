using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace ns1;

public class EtherealRadioButton : Control
{
	public delegate void CheckedChangedEventHandler(object sender);

	private bool bool_0;

	[CompilerGenerated]
	private CheckedChangedEventHandler checkedChangedEventHandler_0;

	internal int int_0 = 1;

	internal Color color_0;

	internal Color color_1;

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
			((Control)this).Invalidate();
		}
	}

	public int Group
	{
		get
		{
			return int_0;
		}
		set
		{
			int num = (int_0 = value);
		}
	}

	public Color CheckColor
	{
		get
		{
			return color_0;
		}
		set
		{
			Color color = (color_0 = value);
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

	public EtherealRadioButton()
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		Color color = (color_0 = HelperMethods.smethod_11(" "));
		Color color2 = (color_1 = HelperMethods.smethod_11(" "));
		((Control)this)._002Ector();
		((Control)this).SetStyle((ControlStyles)141314, true);
		((Control)this).set_DoubleBuffered(true);
		((Control)this).UpdateStyles();
		((Control)this).set_Cursor(Cursors.get_Hand());
		((Control)this).set_Font(new Font(" ", 11f, (FontStyle)0));
	}

	protected override void vmethod_0(PaintEventArgs paintEventArgs_0)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		try
		{
			val2.set_TextRenderingHint((TextRenderingHint)4);
			val2.set_SmoothingMode((SmoothingMode)4);
			val2.DrawEllipse(new Pen(BorderColor, (float)Convert.ToInt32(2.5)), 1, 1, 18, 18);
			if (Checked)
			{
				val2.FillEllipse((Brush)new SolidBrush(CheckColor), new Rectangle(5, 5, 10, 10));
			}
			val2.DrawString(((Control)this).get_Text(), ((Control)this).get_Font(), Brushes.get_Gray(), (RectangleF)new Rectangle(23, Convert.ToInt32(-0.3), ((Control)this).get_Width(), ((Control)this).get_Height()));
			paintEventArgs_0.get_Graphics().DrawImage((Image)(object)val, 0, 0);
			val2.Dispose();
			((Image)val).Dispose();
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
	}

	protected override void vmethod_1(EventArgs eventArgs_0)
	{
		((Control)this).OnTextChanged(eventArgs_0);
		((Control)this).Invalidate();
	}

	protected override void vmethod_2(MouseEventArgs mouseEventArgs_0)
	{
		if (!bool_0)
		{
			Checked = true;
		}
		((Control)this).OnMouseDown(mouseEventArgs_0);
	}

	protected override void vmethod_3(EventArgs eventArgs_0)
	{
		((Control)this).set_Height(21);
		((Control)this).Invalidate();
		((Control)this).OnResize(eventArgs_0);
	}

	private void method_0()
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		if (!((Control)this).get_IsHandleCreated() || !bool_0)
		{
			return;
		}
		foreach (Control item in (ArrangedElementCollection)((Control)this).get_Parent().get_Controls())
		{
			Control val = item;
			if (val != this && val is EtherealRadioButton && ((EtherealRadioButton)(object)val).Group == int_0)
			{
				((EtherealRadioButton)(object)val).Checked = false;
			}
		}
		if (checkedChangedEventHandler_0 != null)
		{
			checkedChangedEventHandler_0(this);
		}
	}

	protected override void vmethod_4()
	{
		((Control)this).OnCreateControl();
	}
}
