using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace NoobCrypt2._0;

internal class NSComboBox : ComboBox
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private GraphicsPath GP1;

	private GraphicsPath GP2;

	private SizeF SZ1;

	private PointF PT1;

	private Pen P1;

	private Pen P2;

	private Pen P3;

	private Pen P4;

	private SolidBrush B1;

	private SolidBrush B2;

	private LinearGradientBrush GB1;

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

	public NSComboBox()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		__ENCAddToList(this);
		((Control)this).SetStyle((ControlStyles)139286, true);
		((Control)this).SetStyle((ControlStyles)512, false);
		((ComboBox)this).set_DrawMode((DrawMode)1);
		((ComboBox)this).set_DropDownStyle((ComboBoxStyle)2);
		((ComboBox)this).set_BackColor(Color.FromArgb(50, 50, 50));
		((ComboBox)this).set_ForeColor(Color.White);
		P1 = new Pen(Color.FromArgb(35, 35, 35));
		P2 = new Pen(Color.White, 2f);
		P3 = new Pen(Brushes.get_Black(), 2f);
		P4 = new Pen(Color.FromArgb(65, 65, 65));
		B1 = new SolidBrush(Color.FromArgb(65, 65, 65));
		B2 = new SolidBrush(Color.FromArgb(55, 55, 55));
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		ThemeModule.G = e.get_Graphics();
		ThemeModule.G.set_TextRenderingHint((TextRenderingHint)5);
		ThemeModule.G.Clear(((ComboBox)this).get_BackColor());
		ThemeModule.G.set_SmoothingMode((SmoothingMode)4);
		checked
		{
			GP1 = ThemeModule.CreateRound(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1, 7);
			GP2 = ThemeModule.CreateRound(1, 1, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 3, 7);
			GB1 = new LinearGradientBrush(((Control)this).get_ClientRectangle(), Color.FromArgb(60, 60, 60), Color.FromArgb(55, 55, 55), 90f);
			ThemeModule.G.SetClip(GP1);
			ThemeModule.G.FillRectangle((Brush)(object)GB1, ((Control)this).get_ClientRectangle());
			ThemeModule.G.ResetClip();
			ThemeModule.G.DrawPath(P1, GP1);
			ThemeModule.G.DrawPath(P4, GP2);
			SZ1 = ThemeModule.G.MeasureString(((ComboBox)this).get_Text(), ((Control)this).get_Font());
			ref PointF pT = ref PT1;
			pT = new PointF(5f, (float)unchecked(((Control)this).get_Height() / 2) - SZ1.Height / 2f);
			ThemeModule.G.DrawString(((ComboBox)this).get_Text(), ((Control)this).get_Font(), Brushes.get_Black(), PT1.X + 1f, PT1.Y + 1f);
			ThemeModule.G.DrawString(((ComboBox)this).get_Text(), ((Control)this).get_Font(), Brushes.get_White(), PT1);
			ThemeModule.G.DrawLine(P3, ((Control)this).get_Width() - 15, 10, ((Control)this).get_Width() - 11, 13);
			ThemeModule.G.DrawLine(P3, ((Control)this).get_Width() - 7, 10, ((Control)this).get_Width() - 11, 13);
			ThemeModule.G.DrawLine(Pens.get_Black(), ((Control)this).get_Width() - 11, 13, ((Control)this).get_Width() - 11, 14);
			ThemeModule.G.DrawLine(P2, ((Control)this).get_Width() - 16, 9, ((Control)this).get_Width() - 12, 12);
			ThemeModule.G.DrawLine(P2, ((Control)this).get_Width() - 8, 9, ((Control)this).get_Width() - 12, 12);
			ThemeModule.G.DrawLine(Pens.get_White(), ((Control)this).get_Width() - 12, 12, ((Control)this).get_Width() - 12, 13);
			ThemeModule.G.DrawLine(P1, ((Control)this).get_Width() - 22, 0, ((Control)this).get_Width() - 22, ((Control)this).get_Height());
			ThemeModule.G.DrawLine(P4, ((Control)this).get_Width() - 23, 1, ((Control)this).get_Width() - 23, ((Control)this).get_Height() - 2);
			ThemeModule.G.DrawLine(P4, ((Control)this).get_Width() - 21, 1, ((Control)this).get_Width() - 21, ((Control)this).get_Height() - 2);
		}
	}

	protected override void OnDrawItem(DrawItemEventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between Unknown and I4
		e.get_Graphics().set_TextRenderingHint((TextRenderingHint)5);
		if ((e.get_State() & 1) == 1)
		{
			e.get_Graphics().FillRectangle((Brush)(object)B1, e.get_Bounds());
		}
		else
		{
			e.get_Graphics().FillRectangle((Brush)(object)B2, e.get_Bounds());
		}
		if (e.get_Index() != -1)
		{
			e.get_Graphics().DrawString(((ListControl)this).GetItemText(RuntimeHelpers.GetObjectValue(((ComboBox)this).get_Items().get_Item(e.get_Index()))), e.get_Font(), Brushes.get_White(), (RectangleF)e.get_Bounds());
		}
	}
}
