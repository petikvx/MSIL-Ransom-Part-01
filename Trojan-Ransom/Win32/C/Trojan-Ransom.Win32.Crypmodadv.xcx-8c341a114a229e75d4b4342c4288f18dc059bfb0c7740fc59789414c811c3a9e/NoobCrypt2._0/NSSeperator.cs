using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace NoobCrypt2._0;

internal class NSSeperator : Control
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private Pen P1;

	private Pen P2;

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

	public NSSeperator()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		__ENCAddToList(this);
		((Control)this).SetStyle((ControlStyles)139286, true);
		((Control)this).SetStyle((ControlStyles)512, false);
		((Control)this).set_Height(10);
		P1 = new Pen(Color.FromArgb(35, 35, 35));
		P2 = new Pen(Color.FromArgb(55, 55, 55));
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		ThemeModule.G = e.get_Graphics();
		ThemeModule.G.Clear(((Control)this).get_BackColor());
		ThemeModule.G.DrawLine(P1, 0, 5, ((Control)this).get_Width(), 5);
		ThemeModule.G.DrawLine(P2, 0, 6, ((Control)this).get_Width(), 6);
	}
}
