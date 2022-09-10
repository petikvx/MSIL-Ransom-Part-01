using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace NoobCrypt2._0;

internal class NSTabControl : TabControl
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private GraphicsPath GP1;

	private GraphicsPath GP2;

	private GraphicsPath GP3;

	private GraphicsPath GP4;

	private Rectangle R1;

	private Rectangle R2;

	private Pen P1;

	private Pen P2;

	private Pen P3;

	private SolidBrush B1;

	private SolidBrush B2;

	private SolidBrush B3;

	private SolidBrush B4;

	private PathGradientBrush PB1;

	private TabPage TP1;

	private StringFormat SF1;

	private int Offset;

	private int ItemHeight;

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

	public NSTabControl()
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		__ENCAddToList(this);
		((Control)this).SetStyle((ControlStyles)139286, true);
		((Control)this).SetStyle((ControlStyles)512, false);
		((TabControl)this).set_SizeMode((TabSizeMode)2);
		((TabControl)this).set_Alignment((TabAlignment)2);
		Size itemSize = new Size(28, 115);
		((TabControl)this).set_ItemSize(itemSize);
		((TabControl)this).set_DrawMode((TabDrawMode)1);
		P1 = new Pen(Color.FromArgb(55, 55, 55));
		P2 = new Pen(Color.FromArgb(35, 35, 35));
		P3 = new Pen(Color.FromArgb(45, 45, 45), 2f);
		B1 = new SolidBrush(Color.FromArgb(50, 50, 50));
		B2 = new SolidBrush(Color.FromArgb(35, 35, 35));
		B3 = new SolidBrush(Color.FromArgb(205, 150, 0));
		B4 = new SolidBrush(Color.FromArgb(65, 65, 65));
		SF1 = new StringFormat();
		SF1.set_LineAlignment((StringAlignment)1);
	}

	protected override void OnControlAdded(ControlEventArgs e)
	{
		if (e.get_Control() is TabPage)
		{
			e.get_Control().set_BackColor(Color.FromArgb(50, 50, 50));
		}
		((Control)this).OnControlAdded(e);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		ThemeModule.G = e.get_Graphics();
		ThemeModule.G.set_TextRenderingHint((TextRenderingHint)5);
		ThemeModule.G.Clear(Color.FromArgb(50, 50, 50));
		ThemeModule.G.set_SmoothingMode((SmoothingMode)4);
		checked
		{
			ItemHeight = ((TabControl)this).get_ItemSize().Height + 2;
			GP1 = ThemeModule.CreateRound(0, 0, ItemHeight + 3, ((Control)this).get_Height() - 1, 7);
			GP2 = ThemeModule.CreateRound(1, 1, ItemHeight + 3, ((Control)this).get_Height() - 3, 7);
			PB1 = new PathGradientBrush(GP1);
			PB1.set_CenterColor(Color.FromArgb(50, 50, 50));
			PB1.set_SurroundColors(new Color[1] { Color.FromArgb(45, 45, 45) });
			PathGradientBrush pB = PB1;
			PointF focusScales = new PointF(0.8f, 0.95f);
			pB.set_FocusScales(focusScales);
			ThemeModule.G.FillPath((Brush)(object)PB1, GP1);
			ThemeModule.G.DrawPath(P1, GP1);
			ThemeModule.G.DrawPath(P2, GP2);
			int num = ((TabControl)this).get_TabCount() - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				R1 = ((TabControl)this).GetTabRect(num2);
				R1.Y += 2;
				R1.Height -= 3;
				R1.Width += 1;
				R1.X -= 1;
				TP1 = ((TabControl)this).get_TabPages().get_Item(num2);
				Offset = 0;
				if (((TabControl)this).get_SelectedIndex() == num2)
				{
					ThemeModule.G.FillRectangle((Brush)(object)B1, R1);
					int num5 = 0;
					int num6;
					do
					{
						ThemeModule.G.FillRectangle((Brush)(object)B2, R1.X + 5 + num5 * 5, R1.Y + 6, 2, R1.Height - 9);
						ThemeModule.G.set_SmoothingMode((SmoothingMode)3);
						ThemeModule.G.FillRectangle((Brush)(object)B3, R1.X + 5 + num5 * 5, R1.Y + 5, 2, R1.Height - 9);
						ThemeModule.G.set_SmoothingMode((SmoothingMode)4);
						Offset += 5;
						num5++;
						num6 = num5;
						num4 = 1;
					}
					while (num6 <= 1);
					ThemeModule.G.DrawRectangle(P3, R1.X + 1, R1.Y - 1, R1.Width, R1.Height + 2);
					ThemeModule.G.DrawRectangle(P1, R1.X + 1, R1.Y + 1, R1.Width - 2, R1.Height - 2);
					ThemeModule.G.DrawRectangle(P2, R1);
				}
				else
				{
					int num7 = 0;
					int num8;
					do
					{
						ThemeModule.G.FillRectangle((Brush)(object)B2, R1.X + 5 + num7 * 5, R1.Y + 6, 2, R1.Height - 9);
						ThemeModule.G.set_SmoothingMode((SmoothingMode)3);
						ThemeModule.G.FillRectangle((Brush)(object)B4, R1.X + 5 + num7 * 5, R1.Y + 5, 2, R1.Height - 9);
						ThemeModule.G.set_SmoothingMode((SmoothingMode)4);
						Offset += 5;
						num7++;
						num8 = num7;
						num4 = 1;
					}
					while (num8 <= 1);
				}
				R1.X += 5 + Offset;
				R2 = R1;
				R2.Y += 1;
				R2.X += 1;
				ThemeModule.G.DrawString(TP1.get_Text(), ((Control)this).get_Font(), Brushes.get_Black(), (RectangleF)R2, SF1);
				ThemeModule.G.DrawString(TP1.get_Text(), ((Control)this).get_Font(), Brushes.get_White(), (RectangleF)R1, SF1);
				num2++;
			}
			GP3 = ThemeModule.CreateRound(ItemHeight, 0, ((Control)this).get_Width() - ItemHeight - 1, ((Control)this).get_Height() - 1, 7);
			GP4 = ThemeModule.CreateRound(ItemHeight + 1, 1, ((Control)this).get_Width() - ItemHeight - 3, ((Control)this).get_Height() - 3, 7);
			ThemeModule.G.DrawPath(P2, GP3);
			ThemeModule.G.DrawPath(P1, GP4);
		}
	}
}
