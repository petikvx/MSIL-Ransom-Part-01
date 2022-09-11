using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace ns1;

public class EtherealSwitch : Control
{
	public delegate void CheckedChangedEventHandler(object sender);

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 20)]
	private struct Struct2
	{
	}

	protected bool bool_0;

	protected HelperMethods.MouseMode mouseMode_0;

	[CompilerGenerated]
	private CheckedChangedEventHandler checkedChangedEventHandler_0;

	private static readonly object object_0;

	private static readonly Array array_0 = new char[10];

	private static readonly Array array_1;

	internal static byte byte_0/* Not supported: data(00) */;

	internal Color color_0;

	public bool Switched
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

	public Color SwitchColor
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
		((Control)this).OnTextChanged(eventArgs_0);
		((Control)this).Invalidate();
	}

	protected override void vmethod_1(PaintEventArgs paintEventArgs_0)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		try
		{
			val2.set_SmoothingMode((SmoothingMode)4);
			if (Switched)
			{
				HelperMethods.smethod_4(val2, (Brush)new SolidBrush(SwitchColor), new Rectangle(1, 1, 42, 22), 22);
				HelperMethods.smethod_5(val2, HelperMethods.smethod_11(" "), 1.5f, new Rectangle(1, 1, 42, 22), 20);
				val2.FillEllipse((Brush)(object)HelperMethods.smethod_10(" "), new Rectangle(22, Convert.ToInt32(2.6), 19, 18));
				val2.DrawEllipse(HelperMethods.smethod_8(" ", 1.5f), new Rectangle(22, Convert.ToInt32(2.6), 19, 18));
			}
			else
			{
				HelperMethods.smethod_3(val2, HelperMethods.smethod_11(" "), new Rectangle(1, 1, 42, 22), 22);
				HelperMethods.smethod_5(val2, HelperMethods.smethod_11(" "), 1.5f, new Rectangle(1, 1, 42, 22), 20);
				val2.FillEllipse((Brush)(object)HelperMethods.smethod_10(" "), new Rectangle(3, Convert.ToInt32(2.6), 19, 18));
				val2.DrawEllipse(HelperMethods.smethod_8(" ", 1.5f), new Rectangle(3, Convert.ToInt32(2.6), 19, 18));
			}
			paintEventArgs_0.get_Graphics().DrawImage((Image)(object)val, 0, 0);
			val2.Dispose();
			((Image)val).Dispose();
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
	}

	public EtherealSwitch()
	{
		Color color = (color_0 = HelperMethods.smethod_11(" "));
		((Control)this)._002Ector();
		((Control)this).SetStyle((ControlStyles)141314, true);
		((Control)this).set_DoubleBuffered(true);
		((Control)this).set_Cursor(Cursors.get_Hand());
		((Control)this).UpdateStyles();
	}

	protected override void vmethod_2(EventArgs eventArgs_0)
	{
		((Control)this).OnHandleCreated(eventArgs_0);
	}

	protected override void vmethod_3()
	{
		((Control)this).OnCreateControl();
	}

	protected override void vmethod_4(EventArgs eventArgs_0)
	{
		((Control)this).OnMouseHover(eventArgs_0);
		mouseMode_0 = HelperMethods.MouseMode.Hovered;
		((Control)this).Invalidate();
	}

	protected override void vmethod_5(EventArgs eventArgs_0)
	{
		((Control)this).OnMouseLeave(eventArgs_0);
		mouseMode_0 = HelperMethods.MouseMode.NormalMode;
		((Control)this).Invalidate();
	}

	protected override void vmethod_6(EventArgs eventArgs_0)
	{
		bool_0 = !bool_0;
		if (checkedChangedEventHandler_0 != null)
		{
			checkedChangedEventHandler_0(this);
		}
		((Control)this).OnClick(eventArgs_0);
		((Control)this).Invalidate();
	}

	protected override void vmethod_7(EventArgs eventArgs_0)
	{
		((Control)this).OnResize(eventArgs_0);
		((Control)this).set_Size(new Size(46, 25));
	}

	static EtherealSwitch()
	{
		char[] array = new char[8];
		array[5] = '㼭';
		array[3] = '\u2d2b';
		array[0] = 'ಲ';
		array[2] = '⩙';
		array[6] = '㭻';
		array[1] = '᮷';
		array[4] = '⬹';
		array[7] = 'Ⱳ';
		array_1 = new string[2];
		object_0 = array;
	}
}
