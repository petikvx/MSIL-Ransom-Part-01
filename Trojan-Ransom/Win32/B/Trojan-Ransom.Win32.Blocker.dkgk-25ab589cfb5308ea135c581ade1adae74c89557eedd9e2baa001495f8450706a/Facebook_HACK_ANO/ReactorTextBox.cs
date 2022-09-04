using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Facebook_HACK_ANO;

public class ReactorTextBox : Control
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	[AccessedThroughProperty("txtbox")]
	private TextBox _txtbox;

	private bool _passmask;

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

	public bool UsePasswordMask
	{
		get
		{
			return _passmask;
		}
		set
		{
			_passmask = value;
			((Control)this).Invalidate();
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

	public HorizontalAlignment TextAlign
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
		((TextBoxBase)txtbox).set_BackColor(((Control)this).get_BackColor());
		((Control)this).Invalidate();
	}

	protected override void OnForeColorChanged(EventArgs e)
	{
		((Control)this).OnForeColorChanged(e);
		((TextBoxBase)txtbox).set_ForeColor(((Control)this).get_ForeColor());
		((Control)this).Invalidate();
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
		TextBox val = txtbox;
		val.set_Multiline(false);
		((TextBoxBase)val).set_BackColor(((Control)this).get_BackColor());
		((TextBoxBase)val).set_ForeColor(((Control)this).get_ForeColor());
		val.set_Text(string.Empty);
		val.set_TextAlign((HorizontalAlignment)2);
		((TextBoxBase)val).set_BorderStyle((BorderStyle)0);
		TextBox obj = val;
		Point location = new Point(5, 5);
		((Control)obj).set_Location(location);
		((Control)val).set_Font(new Font("Verdana", 7.25f));
		TextBox obj2 = val;
		Size size = checked(new Size(((Control)this).get_Width() - 10, ((Control)this).get_Height() - 11));
		((Control)obj2).set_Size(size);
		val.set_UseSystemPasswordChar(UsePasswordMask);
		val = null;
	}

	public ReactorTextBox()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		((Control)this).add_TextChanged((EventHandler)delegate
		{
			TextChng();
		});
		__ENCAddToList(this);
		txtbox = new TextBox();
		_passmask = false;
		_maxchars = 32767;
		NewTextBox();
		((Control)this).get_Controls().Add((Control)(object)txtbox);
		((Control)this).set_Text("");
		((Control)this).set_BackColor(Color.FromArgb(37, 37, 37));
		((Control)this).set_ForeColor(Color.White);
		Size size = new Size(135, 35);
		((Control)this).set_Size(size);
		((Control)this).set_DoubleBuffered(true);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected O, but got Unknown
		Graphics graphics = e.get_Graphics();
		((Control)this).OnPaint(e);
		checked
		{
			((Control)this).set_Height(((Control)txtbox).get_Height() + 11);
			TextBox val = txtbox;
			((Control)val).set_Width(((Control)this).get_Width() - 10);
			val.set_TextAlign(TextAlign);
			val.set_UseSystemPasswordChar(UsePasswordMask);
			val = null;
			graphics.Clear(((Control)this).get_BackColor());
			SolidBrush val2 = new SolidBrush(Color.FromArgb(37, 37, 37));
			Rectangle rectangle = new Rectangle(1, 1, ((Control)this).get_Width() - 2, ((Control)this).get_Height() - 2);
			graphics.FillRectangle((Brush)val2, rectangle);
			Pen val3 = new Pen((Brush)new SolidBrush(Color.Black));
			rectangle = new Rectangle(1, 1, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 3);
			graphics.DrawRectangle(val3, rectangle);
			Pen val4 = new Pen((Brush)new SolidBrush(Color.FromArgb(70, 70, 70)));
			rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			graphics.DrawRectangle(val4, rectangle);
			graphics.DrawLine(new Pen((Brush)new SolidBrush(Color.FromArgb(45, 45, 45))), 0, 0, ((Control)this).get_Width(), 0);
			graphics.DrawLine(new Pen((Brush)new SolidBrush(Color.FromArgb(45, 45, 45))), 0, 0, 0, ((Control)this).get_Height());
			graphics.DrawLine(new Pen((Brush)new SolidBrush(Color.FromArgb(45, 45, 45))), ((Control)this).get_Width() - 1, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height());
			graphics.DrawLine(new Pen((Brush)new SolidBrush(Color.FromArgb(31, 31, 31))), 2, 2, ((Control)this).get_Width() - 3, 2);
		}
	}
}
