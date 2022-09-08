using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace builder;

public class BlackShadesNetRichTextBox : Control
{
	private static List<WeakReference> list_0;

	[AccessedThroughProperty("txtbox")]
	private RichTextBox richTextBox_0;

	[DebuggerNonUserCode]
	static BlackShadesNetRichTextBox()
	{
		Class14.hYiyYvszsKHjE();
		list_0 = new List<WeakReference>();
	}

	[DebuggerNonUserCode]
	private static void smethod_0(object object_0)
	{
		checked
		{
			lock (list_0)
			{
				if (list_0.Count == list_0.Capacity)
				{
					int num = 0;
					int num2 = list_0.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = list_0[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								list_0[num] = list_0[num3];
							}
							num++;
						}
						num3++;
					}
					list_0.RemoveRange(num, list_0.Count - num);
					list_0.Capacity = list_0.Count;
				}
				list_0.Add(new WeakReference(RuntimeHelpers.GetObjectValue(object_0)));
			}
		}
	}

	[SpecialName]
	[DebuggerNonUserCode]
	private virtual RichTextBox vmethod_0()
	{
		return richTextBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	private virtual void vmethod_1(RichTextBox WithEventsValue)
	{
		EventHandler eventHandler = delegate
		{
			TextChngTxtBox();
		};
		if (richTextBox_0 != null)
		{
			((Control)richTextBox_0).remove_TextChanged(eventHandler);
		}
		richTextBox_0 = WithEventsValue;
		if (richTextBox_0 != null)
		{
			((Control)richTextBox_0).add_TextChanged(eventHandler);
		}
	}

	protected override void OnPaintBackground(PaintEventArgs pevent)
	{
	}

	protected override void OnTextChanged(EventArgs e)
	{
		((Control)this).OnTextChanged(e);
		((Control)this).Invalidate();
	}

	protected override void OnBackColorChanged(EventArgs e)
	{
		((Control)this).OnBackColorChanged(e);
		((TextBoxBase)vmethod_0()).set_BackColor(((Control)this).get_BackColor());
		((Control)this).Invalidate();
	}

	protected override void OnForeColorChanged(EventArgs e)
	{
		((Control)this).OnForeColorChanged(e);
		vmethod_0().set_ForeColor(((Control)this).get_ForeColor());
		((Control)this).Invalidate();
	}

	protected override void OnSizeChanged(EventArgs e)
	{
		((Control)this).OnSizeChanged(e);
		RichTextBox obj = vmethod_0();
		Size size = checked(new Size(((Control)this).get_Width() - 10, ((Control)this).get_Height() - 11));
		((Control)obj).set_Size(size);
	}

	protected override void OnFontChanged(EventArgs e)
	{
		((Control)this).OnFontChanged(e);
		vmethod_0().set_Font(((Control)this).get_Font());
	}

	protected override void OnGotFocus(EventArgs e)
	{
		((Control)this).OnGotFocus(e);
		((Control)vmethod_0()).Focus();
	}

	public void TextChngTxtBox()
	{
		((Control)this).set_Text(vmethod_0().get_Text());
	}

	public void TextChng()
	{
		vmethod_0().set_Text(((Control)this).get_Text());
	}

	public void NewTextBox()
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		RichTextBox val = vmethod_0();
		val.set_Multiline(true);
		((TextBoxBase)val).set_BackColor(((Control)this).get_BackColor());
		val.set_ForeColor(((Control)this).get_ForeColor());
		val.set_Text(string.Empty);
		((TextBoxBase)val).set_BorderStyle((BorderStyle)0);
		RichTextBox obj = val;
		Point location = new Point(3, 4);
		((Control)obj).set_Location(location);
		val.set_Font(new Font("Trebuchet MS", 8.25f, (FontStyle)1));
		RichTextBox obj2 = val;
		Size size = checked(new Size(((Control)this).get_Width() - 10, ((Control)this).get_Height() - 10));
		((Control)obj2).set_Size(size);
		val = null;
		vmethod_0().set_Font(new Font("Trebuchet MS", 8.25f, (FontStyle)1));
	}

	public BlackShadesNetRichTextBox()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		Class14.hYiyYvszsKHjE();
		((Control)this)._002Ector();
		((Control)this).add_TextChanged((EventHandler)delegate
		{
			TextChng();
		});
		smethod_0(this);
		vmethod_1(new RichTextBox());
		NewTextBox();
		((Control)this).get_Controls().Add((Control)(object)vmethod_0());
		((Control)this).set_Text("");
		((Control)this).set_BackColor(Color.FromArgb(36, 40, 42));
		((Control)this).set_ForeColor(Color.FromArgb(142, 152, 156));
		Size size = new Size(135, 35);
		((Control)this).set_Size(size);
		((Control)this).set_DoubleBuffered(true);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		val2.set_SmoothingMode((SmoothingMode)2);
		new Class10();
		checked
		{
			Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			val2.Clear(Color.FromArgb(36, 40, 42));
			val2.DrawRectangle(new Pen(Color.FromArgb(30, 33, 35), 2f), rectangle);
			val2.DrawLine(new Pen(Color.FromArgb(83, 90, 94)), ((Control)this).get_Width() - 1, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height());
			val2.DrawLine(new Pen(Color.FromArgb(83, 90, 94)), 0, ((Control)this).get_Height() - 1, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			NewLateBinding.LateCall((object)e.get_Graphics(), (Type)null, "DrawImage", new object[3]
			{
				RuntimeHelpers.GetObjectValue(((Image)val).Clone()),
				0,
				0
			}, (string[])null, (Type[])null, (bool[])null, true);
			val2.Dispose();
			((Image)val).Dispose();
		}
	}
}
