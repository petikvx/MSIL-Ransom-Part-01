using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace nO_bUILDER;

public class InfluenceMultiLineTextBox : Control
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	[AccessedThroughProperty("txtbox")]
	private TextBox _txtbox;

	private int _maxchars;

	private HorizontalAlignment _align;

	private virtual TextBox txtbox
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtbox;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = delegate
			{
				TextChngTxtBox();
			};
			if (_txtbox != null)
			{
				((Control)_txtbox).remove_TextChanged(eventHandler);
			}
			_txtbox = value;
			if (_txtbox != null)
			{
				((Control)_txtbox).add_TextChanged(eventHandler);
			}
		}
	}

	public int MaxCharacters
	{
		get
		{
			return _maxchars;
		}
		set
		{
			_maxchars = value;
			((Control)this).Invalidate();
		}
	}

	public HorizontalAlignment TextAlignment
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return _align;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_align = value;
			((Control)this).Invalidate();
		}
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
	}

	protected override void OnTextChanged(EventArgs e)
	{
		((Control)this).OnTextChanged(e);
		((Control)this).Invalidate();
	}

	protected override void OnBackColorChanged(EventArgs e)
	{
		((Control)this).OnBackColorChanged(e);
		((TextBoxBase)txtbox).set_BackColor(Color.FromArgb(43, 43, 43));
		((Control)this).Invalidate();
	}

	protected override void OnForeColorChanged(EventArgs e)
	{
		((Control)this).OnForeColorChanged(e);
		((TextBoxBase)txtbox).set_ForeColor(((Control)this).get_ForeColor());
		((Control)this).Invalidate();
	}

	protected override void OnSizeChanged(EventArgs e)
	{
		((Control)this).OnSizeChanged(e);
		TextBox obj = txtbox;
		Size size = checked(new Size(((Control)this).get_Width() - 10, ((Control)this).get_Height() - 11));
		((Control)obj).set_Size(size);
	}

	protected override void OnFontChanged(EventArgs e)
	{
		((Control)this).OnFontChanged(e);
		((Control)txtbox).set_Font(((Control)this).get_Font());
	}

	protected override void OnGotFocus(EventArgs e)
	{
		((Control)this).OnGotFocus(e);
		((Control)txtbox).Focus();
	}

	public void TextChngTxtBox()
	{
		((Control)this).set_Text(txtbox.get_Text());
	}

	public void TextChng()
	{
		txtbox.set_Text(((Control)this).get_Text());
	}

	public void NewTextBox()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		TextBox val = txtbox;
		val.set_Multiline(true);
		((TextBoxBase)val).set_BackColor(((Control)this).get_BackColor());
		((TextBoxBase)val).set_ForeColor(((Control)this).get_ForeColor());
		val.set_Text(string.Empty);
		val.set_TextAlign((HorizontalAlignment)2);
		((TextBoxBase)val).set_BorderStyle((BorderStyle)0);
		TextBox obj = val;
		Point location = new Point(3, 4);
		((Control)obj).set_Location(location);
		((Control)val).set_Font(new Font("Verdana", 8.25f));
		TextBox obj2 = val;
		Size size = checked(new Size(((Control)this).get_Width() - 10, ((Control)this).get_Height() - 10));
		((Control)obj2).set_Size(size);
		val = null;
		((Control)txtbox).set_Font(new Font("Verdana", 8.25f));
	}

	public InfluenceMultiLineTextBox()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		((Control)this).add_TextChanged((EventHandler)delegate
		{
			TextChng();
		});
		__ENCAddToList(this);
		txtbox = new TextBox();
		_maxchars = 32767;
		NewTextBox();
		((Control)this).get_Controls().Add((Control)(object)txtbox);
		((Control)this).set_Text(string.Empty);
		((Control)this).SetStyle((ControlStyles)2050, true);
		((Control)this).set_BackColor(Color.Transparent);
		((Control)this).set_ForeColor(Color.White);
		Size size = new Size(135, 35);
		((Control)this).set_Size(size);
		((Control)this).set_DoubleBuffered(true);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected O, but got Unknown
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected O, but got Unknown
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		val2.set_SmoothingMode((SmoothingMode)2);
		Draw draw = new Draw();
		checked
		{
			Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			txtbox.set_TextAlign(TextAlignment);
			val2.Clear(((Control)this).get_BackColor());
			Rectangle rectangle2 = new Rectangle(0, 0, ((Control)this).get_Width() - 1, (int)Math.Round((double)((Control)this).get_Height() / 2.0));
			LinearGradientBrush val3 = new LinearGradientBrush(rectangle2, Color.FromArgb(40, 40, 40), Color.FromArgb(45, 45, 45), 90f);
			rectangle2 = new Rectangle(0, 0, ((Control)this).get_Width() - 1, (int)Math.Round((double)((Control)this).get_Height() / 2.0));
			val2.FillPath((Brush)(object)val3, draw.RoundRect(rectangle2, 2));
			rectangle2 = new Rectangle(0, (int)Math.Round((double)((Control)this).get_Height() / 2.0), ((Control)this).get_Width() - 1, (int)Math.Round((double)((Control)this).get_Height() / 2.0));
			LinearGradientBrush val4 = new LinearGradientBrush(rectangle2, Color.FromArgb(45, 45, 45), Color.FromArgb(40, 40, 40), 90f);
			rectangle2 = new Rectangle(0, (int)Math.Round((double)((Control)this).get_Height() / 2.0 - 3.0), ((Control)this).get_Width() - 1, (int)Math.Round((double)((Control)this).get_Height() / 2.0 + 2.0));
			val2.FillPath((Brush)(object)val4, draw.RoundRect(rectangle2, 2));
			Pen val5 = new Pen(Color.FromArgb(150, 97, 94, 90));
			rectangle2 = new Rectangle(0, 1, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 3);
			val2.DrawPath(val5, draw.RoundRect(rectangle2, 2));
			val2.DrawPath(new Pen(Color.FromArgb(10, 10, 10)), draw.RoundRect(rectangle, 2));
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
