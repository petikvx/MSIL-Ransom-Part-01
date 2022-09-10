using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace NoobCrypt2._0;

internal class NSLabel : Control
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private string _Value1;

	private string _Value2;

	private SolidBrush B1;

	private PointF PT1;

	private PointF PT2;

	private SizeF SZ1;

	private SizeF SZ2;

	public string Value1
	{
		get
		{
			return _Value1;
		}
		set
		{
			_Value1 = value;
			((Control)this).Invalidate();
		}
	}

	public string Value2
	{
		get
		{
			return _Value2;
		}
		set
		{
			_Value2 = value;
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

	public NSLabel()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		__ENCAddToList(this);
		_Value1 = "NET";
		_Value2 = "SEAL";
		((Control)this).SetStyle((ControlStyles)139286, true);
		((Control)this).SetStyle((ControlStyles)512, false);
		((Control)this).set_Font(new Font("Segoe UI", 11.25f, (FontStyle)1));
		B1 = new SolidBrush(Color.FromArgb(205, 150, 0));
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		ThemeModule.G = e.get_Graphics();
		ThemeModule.G.set_TextRenderingHint((TextRenderingHint)5);
		ThemeModule.G.Clear(((Control)this).get_BackColor());
		SZ1 = ThemeModule.G.MeasureString(Value1, ((Control)this).get_Font(), ((Control)this).get_Width(), StringFormat.get_GenericTypographic());
		SZ2 = ThemeModule.G.MeasureString(Value2, ((Control)this).get_Font(), ((Control)this).get_Width(), StringFormat.get_GenericTypographic());
		ref PointF pT = ref PT1;
		pT = new PointF(0f, (float)(((Control)this).get_Height() / 2) - SZ1.Height / 2f);
		ref PointF pT2 = ref PT2;
		pT2 = new PointF(SZ1.Width + 1f, (float)(((Control)this).get_Height() / 2) - SZ1.Height / 2f);
		ThemeModule.G.DrawString(Value1, ((Control)this).get_Font(), Brushes.get_Black(), PT1.X + 1f, PT1.Y + 1f);
		ThemeModule.G.DrawString(Value1, ((Control)this).get_Font(), Brushes.get_White(), PT1);
		ThemeModule.G.DrawString(Value2, ((Control)this).get_Font(), Brushes.get_Black(), PT2.X + 1f, PT2.Y + 1f);
		ThemeModule.G.DrawString(Value2, ((Control)this).get_Font(), (Brush)(object)B1, PT2);
	}
}
