using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace ns1;

public class EtherealCheckBox : Control
{
	public delegate void CheckedChangedEventHandler(object sender);

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 10)]
	private struct Struct1
	{
	}

	private static bool bool_0;

	[CompilerGenerated]
	private CheckedChangedEventHandler checkedChangedEventHandler_0;

	private Color color_0;

	private static readonly object object_0;

	private static readonly Array array_0 = new char[5];

	private static readonly object object_1;

	internal static byte byte_0/* Not supported: data(00) */;

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
			((Control)this).Invalidate();
		}
	}

	public Color CheckColor
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

	public Color BorderColor
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

	public EtherealCheckBox()
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		Color color = (color_1 = HelperMethods.smethod_11(" "));
		color_0 = HelperMethods.smethod_11(" ");
		((Control)this)._002Ector();
		((Control)this).SetStyle((ControlStyles)141330, true);
		((Control)this).set_DoubleBuffered(true);
		((Control)this).set_Cursor(Cursors.get_Hand());
		((Control)this).set_Size(new Size(200, 20));
		((Control)this).set_Font(new Font(" ", 11f, (FontStyle)0));
		((Control)this).set_BackColor(Color.Transparent);
	}

	protected override void vmethod_0(PaintEventArgs paintEventArgs_0)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		try
		{
			val2.set_TextRenderingHint((TextRenderingHint)4);
			val2.set_SmoothingMode((SmoothingMode)4);
			HelperMethods.smethod_5(val2, BorderColor, 3f, new Rectangle(1, 1, 16, 16), 3);
			if (Checked)
			{
				HelperMethods.smethod_3(val2, CheckColor, new Rectangle(5, 5, 8, 8), 1);
			}
			val2.DrawString(((Control)this).get_Text(), ((Control)this).get_Font(), Brushes.get_Gray(), (RectangleF)new Rectangle(22, Convert.ToInt32(-1.2), ((Control)this).get_Width(), ((Control)this).get_Height() - 2));
			paintEventArgs_0.get_Graphics().DrawImage((Image)((Image)val).Clone(), 0, 0);
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
		((Control)this).set_Height(20);
		((Control)this).OnResize(eventArgs_0);
		((Control)this).Invalidate();
	}

	protected override void vmethod_2(EventArgs eventArgs_0)
	{
		bool_0 = !bool_0;
		if (checkedChangedEventHandler_0 != null)
		{
			checkedChangedEventHandler_0(this);
		}
		((Control)this).OnClick(eventArgs_0);
		((Control)this).Invalidate();
	}

	static EtherealCheckBox()
	{
		char[] array = new char[8];
		array[0] = '㕀';
		array[6] = '\u1b41';
		array[4] = 'ᦌ';
		array[5] = 'ב';
		array[3] = '\u0fdd';
		array[2] = 'ቶ';
		array[7] = '㔙';
		array[1] = '⹉';
		object_1 = new string[1];
		object_0 = array;
	}
}
