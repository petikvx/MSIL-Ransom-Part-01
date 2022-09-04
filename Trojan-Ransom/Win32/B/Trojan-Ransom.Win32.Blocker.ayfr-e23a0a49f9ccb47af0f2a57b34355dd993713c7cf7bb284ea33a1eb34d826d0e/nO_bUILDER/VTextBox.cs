using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace nO_bUILDER;

internal class VTextBox : ThemeControl154
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	[AccessedThroughProperty("Txt")]
	private TextBox _Txt;

	private bool _Mulitline;

	private bool _PassMask;

	private int _maxchars;

	private virtual TextBox Txt
	{
		[DebuggerNonUserCode]
		get
		{
			return _Txt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = delegate
			{
				TextChngTxtBox();
			};
			if (_Txt != null)
			{
				((Control)_Txt).remove_TextChanged(eventHandler);
			}
			_Txt = value;
			if (_Txt != null)
			{
				((Control)_Txt).add_TextChanged(eventHandler);
			}
		}
	}

	public bool Multiline
	{
		get
		{
			return _Mulitline;
		}
		set
		{
			_Mulitline = value;
		}
	}

	public bool UsePasswordMask
	{
		get
		{
			return _PassMask;
		}
		set
		{
			_PassMask = value;
			Txt.set_UseSystemPasswordChar(value);
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
			((TextBoxBase)Txt).set_MaxLength(value);
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

	public VTextBox()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		((Control)this).add_TextChanged((EventHandler)delegate
		{
			TextChng();
		});
		__ENCAddToList(this);
		Txt = new TextBox();
		Txt.set_TextAlign((HorizontalAlignment)0);
		((TextBoxBase)Txt).set_BorderStyle((BorderStyle)0);
		TextBox txt = Txt;
		Point location = new Point(10, 6);
		((Control)txt).set_Location(location);
		((Control)Txt).set_Font(new Font("Verdana", 8f));
		((Control)this).get_Controls().Add((Control)(object)Txt);
		Text = "";
		Txt.set_Text("");
		Size size = new Size(150, 25);
		((Control)this).set_Size(size);
	}

	protected override void ColorHook()
	{
		((TextBoxBase)Txt).set_ForeColor(Color.White);
		((TextBoxBase)Txt).set_BackColor(Color.FromArgb(15, 15, 15));
	}

	protected override void PaintHook()
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		G.Clear(Color.FromArgb(15, 15, 15));
		TextBox txt = Txt;
		checked
		{
			Size size = new Size(((Control)this).get_Width() - 20, ((Control)this).get_Height() - 10);
			((Control)txt).set_Size(size);
			switch (Multiline)
			{
			case false:
				size = new Size(((Control)this).get_Width(), 25);
				((Control)this).set_Size(size);
				break;
			case true:
				size = new Size(((Control)this).get_Width(), ((Control)this).get_Height());
				((Control)this).set_Size(size);
				break;
			}
			Graphics g = G;
			SolidBrush val = new SolidBrush(Color.FromArgb(15, 15, 15));
			Rectangle rectangle = new Rectangle(1, 1, ((Control)this).get_Width() - 2, ((Control)this).get_Height() - 2);
			g.FillRectangle((Brush)val, rectangle);
			DrawBorders(new Pen((Brush)new SolidBrush(Color.FromArgb(32, 32, 32))), 1);
			DrawBorders(new Pen((Brush)new SolidBrush(Color.Black)));
			DrawCorners(Color.FromArgb(15, 15, 15));
			Color c = Color.FromArgb(15, 15, 15);
			rectangle = new Rectangle(1, 1, ((Control)this).get_Width() - 2, ((Control)this).get_Height() - 2);
			DrawCorners(c, rectangle);
		}
	}

	public void TextChngTxtBox()
	{
		Text = Txt.get_Text();
	}

	public void TextChng()
	{
		Txt.set_Text(Text);
	}
}
