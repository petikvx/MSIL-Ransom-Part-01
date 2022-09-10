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
internal class NSOnOffBox : Control
{
	public delegate void CheckedChangedEventHandler(object sender);

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private CheckedChangedEventHandler CheckedChangedEvent;

	private bool _Checked;

	private GraphicsPath GP1;

	private GraphicsPath GP2;

	private GraphicsPath GP3;

	private GraphicsPath GP4;

	private Pen P1;

	private Pen P2;

	private Pen P3;

	private SolidBrush B1;

	private SolidBrush B2;

	private SolidBrush B3;

	private SolidBrush B4;

	private SolidBrush B5;

	private PathGradientBrush PB1;

	private LinearGradientBrush GB1;

	private Rectangle R1;

	private Rectangle R2;

	private Rectangle R3;

	private StringFormat SF1;

	private StringFormat SF2;

	private int Offset;

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

	public NSOnOffBox()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		__ENCAddToList(this);
		((Control)this).SetStyle((ControlStyles)139286, true);
		((Control)this).SetStyle((ControlStyles)512, false);
		P1 = new Pen(Color.FromArgb(55, 55, 55));
		P2 = new Pen(Color.FromArgb(35, 35, 35));
		P3 = new Pen(Color.FromArgb(65, 65, 65));
		B1 = new SolidBrush(Color.FromArgb(35, 35, 35));
		B2 = new SolidBrush(Color.FromArgb(85, 85, 85));
		B3 = new SolidBrush(Color.FromArgb(65, 65, 65));
		B4 = new SolidBrush(Color.FromArgb(205, 150, 0));
		B5 = new SolidBrush(Color.FromArgb(40, 40, 40));
		SF1 = new StringFormat();
		SF1.set_LineAlignment((StringAlignment)1);
		SF1.set_Alignment((StringAlignment)0);
		SF2 = new StringFormat();
		SF2.set_LineAlignment((StringAlignment)1);
		SF2.set_Alignment((StringAlignment)2);
		Size size = new Size(56, 24);
		((Control)this).set_Size(size);
		((Control)this).set_MinimumSize(((Control)this).get_Size());
		((Control)this).set_MaximumSize(((Control)this).get_Size());
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected O, but got Unknown
		ThemeModule.G = e.get_Graphics();
		ThemeModule.G.set_TextRenderingHint((TextRenderingHint)5);
		ThemeModule.G.Clear(((Control)this).get_BackColor());
		ThemeModule.G.set_SmoothingMode((SmoothingMode)4);
		checked
		{
			GP1 = ThemeModule.CreateRound(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1, 7);
			GP2 = ThemeModule.CreateRound(1, 1, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 3, 7);
			PB1 = new PathGradientBrush(GP1);
			PB1.set_CenterColor(Color.FromArgb(50, 50, 50));
			PB1.set_SurroundColors(new Color[1] { Color.FromArgb(45, 45, 45) });
			PathGradientBrush pB = PB1;
			PointF focusScales = new PointF(0.3f, 0.3f);
			pB.set_FocusScales(focusScales);
			ThemeModule.G.FillPath((Brush)(object)PB1, GP1);
			ThemeModule.G.DrawPath(P1, GP1);
			ThemeModule.G.DrawPath(P2, GP2);
			ref Rectangle r = ref R1;
			r = new Rectangle(5, 0, ((Control)this).get_Width() - 10, ((Control)this).get_Height() + 2);
			ref Rectangle r2 = ref R2;
			r2 = new Rectangle(6, 1, ((Control)this).get_Width() - 10, ((Control)this).get_Height() + 2);
			ref Rectangle r3 = ref R3;
			r3 = new Rectangle(1, 1, unchecked(((Control)this).get_Width() / 2) - 1, ((Control)this).get_Height() - 3);
			if (_Checked)
			{
				ThemeModule.G.DrawString("On", ((Control)this).get_Font(), Brushes.get_Black(), (RectangleF)R2, SF1);
				ThemeModule.G.DrawString("On", ((Control)this).get_Font(), Brushes.get_White(), (RectangleF)R1, SF1);
				R3.X += unchecked(((Control)this).get_Width() / 2) - 1;
			}
			else
			{
				ThemeModule.G.DrawString("Off", ((Control)this).get_Font(), (Brush)(object)B1, (RectangleF)R2, SF2);
				ThemeModule.G.DrawString("Off", ((Control)this).get_Font(), (Brush)(object)B2, (RectangleF)R1, SF2);
			}
			GP3 = ThemeModule.CreateRound(R3, 7);
			GP4 = ThemeModule.CreateRound(R3.X + 1, R3.Y + 1, R3.Width - 2, R3.Height - 2, 7);
			GB1 = new LinearGradientBrush(((Control)this).get_ClientRectangle(), Color.FromArgb(60, 60, 60), Color.FromArgb(55, 55, 55), 90f);
			ThemeModule.G.FillPath((Brush)(object)GB1, GP3);
			ThemeModule.G.DrawPath(P2, GP3);
			ThemeModule.G.DrawPath(P3, GP4);
			Offset = R3.X + unchecked(R3.Width / 2) - 3;
			int num = 0;
			do
			{
				if (!_Checked)
				{
					ThemeModule.G.FillRectangle((Brush)(object)B3, Offset + num * 5, 7, 2, ((Control)this).get_Height() - 14);
				}
				else
				{
					ThemeModule.G.FillRectangle((Brush)(object)B1, Offset + num * 5, 7, 2, ((Control)this).get_Height() - 14);
				}
				ThemeModule.G.set_SmoothingMode((SmoothingMode)3);
				if (_Checked)
				{
					ThemeModule.G.FillRectangle((Brush)(object)B4, Offset + num * 5, 7, 2, ((Control)this).get_Height() - 14);
				}
				else
				{
					ThemeModule.G.FillRectangle((Brush)(object)B5, Offset + num * 5, 7, 2, ((Control)this).get_Height() - 14);
				}
				ThemeModule.G.set_SmoothingMode((SmoothingMode)4);
				num++;
			}
			while (num <= 1);
		}
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		Checked = !Checked;
		((Control)this).OnMouseDown(e);
	}
}
