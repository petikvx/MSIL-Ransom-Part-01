using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ClientG;

public class EtherealLabel : Control
{
	public enum Style : byte
	{
		SemiBlack,
		DarkPink,
		LightPink
	}

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private Style _ColorStyle;

	public Style ColorStyle
	{
		get
		{
			return _ColorStyle;
		}
		set
		{
			_ColorStyle = value;
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

	public EtherealLabel()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		__ENCAddToList(this);
		_ColorStyle = Style.DarkPink;
		((Control)this).SetStyle((ControlStyles)133122, true);
		((Control)this).set_DoubleBuffered(true);
		((Control)this).set_Font(new Font("Montserrat", 10f, (FontStyle)1));
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		Graphics graphics = e.get_Graphics();
		Graphics val = graphics;
		val.set_TextRenderingHint((TextRenderingHint)4);
		switch (ColorStyle)
		{
		case Style.SemiBlack:
			val.DrawString(((Control)this).get_Text(), ((Control)this).get_Font(), (Brush)(object)HelperMethods.SolidBrushHTMlColor("222222"), (RectangleF)((Control)this).get_ClientRectangle());
			break;
		case Style.DarkPink:
			val.DrawString(((Control)this).get_Text(), ((Control)this).get_Font(), (Brush)(object)HelperMethods.SolidBrushHTMlColor("3b2551"), (RectangleF)((Control)this).get_ClientRectangle());
			break;
		case Style.LightPink:
			val.DrawString(((Control)this).get_Text(), ((Control)this).get_Font(), (Brush)(object)HelperMethods.SolidBrushHTMlColor("9d92a8"), (RectangleF)((Control)this).get_ClientRectangle());
			break;
		}
		val = null;
	}
}
