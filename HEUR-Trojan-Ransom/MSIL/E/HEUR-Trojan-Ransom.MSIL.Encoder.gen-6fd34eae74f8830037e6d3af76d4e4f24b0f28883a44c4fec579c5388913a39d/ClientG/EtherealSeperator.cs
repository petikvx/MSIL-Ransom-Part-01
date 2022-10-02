using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ClientG;

public class EtherealSeperator : Control
{
	public enum Style
	{
		Horizental,
		Vertiacal
	}

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	public Style SepStyle
	{
		[DebuggerNonUserCode]
		get;
		[DebuggerNonUserCode]
		set;
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

	public EtherealSeperator()
	{
		__ENCAddToList(this);
		SepStyle = Style.Horizental;
		((Control)this).SetStyle((ControlStyles)2050, true);
		((Control)this).set_DoubleBuffered(true);
		((Control)this).set_BackColor(Color.Transparent);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics graphics = e.get_Graphics();
		Graphics val = graphics;
		val.set_SmoothingMode((SmoothingMode)2);
		ColorBlend val2 = new ColorBlend();
		new ColorBlend();
		val2.set_Positions(new float[4] { 0f, 0.15f, 0.85f, 1f });
		val2.set_Colors(new Color[4]
		{
			Color.Transparent,
			HelperMethods.GetHTMLColor("3b2551"),
			HelperMethods.GetHTMLColor("3b2551"),
			Color.Transparent
		});
		switch (SepStyle)
		{
		case Style.Horizental:
		{
			LinearGradientBrush val4 = new LinearGradientBrush(((Control)this).get_ClientRectangle(), Color.Empty, Color.Empty, 0f);
			val4.set_InterpolationColors(val2);
			val.DrawLine(new Pen((Brush)(object)val4), 0, 1, ((Control)this).get_Width(), 1);
			break;
		}
		case Style.Vertiacal:
		{
			LinearGradientBrush val3 = new LinearGradientBrush(((Control)this).get_ClientRectangle(), Color.Empty, Color.Empty, 90f);
			val3.set_InterpolationColors(val2);
			val.DrawLine(new Pen((Brush)(object)val3), 1, 0, 1, ((Control)this).get_Height());
			break;
		}
		}
		val = null;
	}
}
