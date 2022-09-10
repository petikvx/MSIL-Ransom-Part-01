using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace NoobCrypt2._0;

[DefaultEvent("CheckedChanged")]
internal class NSCheckBox : Control
{
	public delegate void CheckedChangedEventHandler(object sender);

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private CheckedChangedEventHandler CheckedChangedEvent;

	private bool _Checked;

	private GraphicsPath GP1;

	private GraphicsPath GP2;

	private SizeF SZ1;

	private PointF PT1;

	private Pen P11;

	private Pen P22;

	private Pen P3;

	private Pen P4;

	private PathGradientBrush PB1;

	public bool Checked
	{
		get
		{
			return _Checked;
		}
		set
		{
			_Checked = value;
			CheckedChangedEvent?.Invoke(this);
			((Control)this).Invalidate();
		}
	}

	public event CheckedChangedEventHandler CheckedChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		add
		{
			CheckedChangedEvent = (CheckedChangedEventHandler)Delegate.Combine(CheckedChangedEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		remove
		{
			CheckedChangedEvent = (CheckedChangedEventHandler)Delegate.Remove(CheckedChangedEvent, value);
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

	public NSCheckBox()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		__ENCAddToList(this);
		((Control)this).SetStyle((ControlStyles)139286, true);
		((Control)this).SetStyle((ControlStyles)512, false);
		P11 = new Pen(Color.FromArgb(55, 55, 55));
		P22 = new Pen(Color.FromArgb(35, 35, 35));
		P3 = new Pen(Color.Black, 2f);
		P4 = new Pen(Color.White, 2f);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		ThemeModule.G = e.get_Graphics();
		ThemeModule.G.set_TextRenderingHint((TextRenderingHint)5);
		ThemeModule.G.Clear(((Control)this).get_BackColor());
		ThemeModule.G.set_SmoothingMode((SmoothingMode)4);
		checked
		{
			GP1 = ThemeModule.CreateRound(0, 2, ((Control)this).get_Height() - 5, ((Control)this).get_Height() - 5, 5);
			GP2 = ThemeModule.CreateRound(1, 3, ((Control)this).get_Height() - 7, ((Control)this).get_Height() - 7, 5);
			PB1 = new PathGradientBrush(GP1);
			PB1.set_CenterColor(Color.FromArgb(50, 50, 50));
			PB1.set_SurroundColors(new Color[1] { Color.FromArgb(45, 45, 45) });
			PathGradientBrush pB = PB1;
			PointF focusScales = new PointF(0.3f, 0.3f);
			pB.set_FocusScales(focusScales);
			ThemeModule.G.FillPath((Brush)(object)PB1, GP1);
			ThemeModule.G.DrawPath(P11, GP1);
			ThemeModule.G.DrawPath(P22, GP2);
			if (_Checked)
			{
				ThemeModule.G.DrawLine(P3, 5, ((Control)this).get_Height() - 9, 8, ((Control)this).get_Height() - 7);
				ThemeModule.G.DrawLine(P3, 7, ((Control)this).get_Height() - 7, ((Control)this).get_Height() - 8, 7);
				ThemeModule.G.DrawLine(P4, 4, ((Control)this).get_Height() - 10, 7, ((Control)this).get_Height() - 8);
				ThemeModule.G.DrawLine(P4, 6, ((Control)this).get_Height() - 8, ((Control)this).get_Height() - 9, 6);
			}
			SZ1 = ThemeModule.G.MeasureString(((Control)this).get_Text(), ((Control)this).get_Font());
			ref PointF pT = ref PT1;
			pT = new PointF(((Control)this).get_Height() - 3, (float)unchecked(((Control)this).get_Height() / 2) - SZ1.Height / 2f);
			ThemeModule.G.DrawString(((Control)this).get_Text(), ((Control)this).get_Font(), Brushes.get_Black(), PT1.X + 1f, PT1.Y + 1f);
			ThemeModule.G.DrawString(((Control)this).get_Text(), ((Control)this).get_Font(), Brushes.get_White(), PT1);
		}
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		Checked = !Checked;
	}
}
