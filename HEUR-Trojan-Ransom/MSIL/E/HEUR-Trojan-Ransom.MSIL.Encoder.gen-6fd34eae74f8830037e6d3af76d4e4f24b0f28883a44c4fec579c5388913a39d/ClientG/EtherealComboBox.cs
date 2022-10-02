using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ClientG;

public class EtherealComboBox : ComboBox
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private int _StartIndex;

	private int StartIndex
	{
		get
		{
			return _StartIndex;
		}
		set
		{
			_StartIndex = value;
			try
			{
				((ComboBox)this).set_SelectedIndex(value);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
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

	public EtherealComboBox()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		((ComboBox)this).add_DrawItem(new DrawItemEventHandler(MyBase_DrawItem));
		__ENCAddToList(this);
		_StartIndex = 0;
		((Control)this).SetStyle((ControlStyles)73746, true);
		((ComboBox)this).set_DrawMode((DrawMode)1);
		Size size = new Size(200, 35);
		((Control)this).set_Size(size);
		((ComboBox)this).set_DropDownStyle((ComboBoxStyle)2);
		((Control)this).set_Font(new Font("Segoe UI", 15f));
		((Control)this).set_DoubleBuffered(true);
	}

	public void MyBase_DrawItem(object sender, DrawItemEventArgs e)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_0091: Expected O, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		checked
		{
			try
			{
				Graphics graphics = e.get_Graphics();
				graphics.set_SmoothingMode((SmoothingMode)2);
				graphics.set_TextRenderingHint((TextRenderingHint)4);
				e.DrawBackground();
				if ((e.get_State() & 1) == 1)
				{
					graphics.FillRectangle((Brush)(object)HelperMethods.SolidBrushHTMlColor("3b2551"), e.get_Bounds());
					graphics.DrawString(((ListControl)this).GetItemText(RuntimeHelpers.GetObjectValue(((ComboBox)this).get_Items().get_Item(e.get_Index()))), new Font("Segoe UI", 10f, (FontStyle)1), (Brush)new SolidBrush(Color.WhiteSmoke), 1f, (float)(e.get_Bounds().Top + 5));
				}
				else
				{
					graphics.FillRectangle((Brush)new SolidBrush(e.get_BackColor()), e.get_Bounds());
					graphics.DrawString(((ListControl)this).GetItemText(RuntimeHelpers.GetObjectValue(((ComboBox)this).get_Items().get_Item(e.get_Index()))), new Font("Segoe UI", 10f, (FontStyle)1), (Brush)(object)HelperMethods.SolidBrushHTMlColor("b8c6d6"), 1f, (float)(e.get_Bounds().Top + 5));
				}
				graphics = null;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			((Control)this).Invalidate();
		}
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_0143: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		checked
		{
			try
			{
				Graphics val2 = Graphics.FromImage((Image)(object)val);
				try
				{
					Rectangle rect = new Rectangle(1, 1, ((Control)this).get_Width() - 2, ((Control)this).get_Height() - 2);
					Graphics val3 = val2;
					val3.set_TextRenderingHint((TextRenderingHint)4);
					val3.set_SmoothingMode((SmoothingMode)2);
					val3.set_PixelOffsetMode((PixelOffsetMode)2);
					Color hTMLColor = HelperMethods.GetHTMLColor("999999");
					Point p1_ = new Point(((Control)this).get_Width() - 20, 16);
					Point p1_2 = new Point(((Control)this).get_Width() - 16, 20);
					Point p2_ = new Point(((Control)this).get_Width() - 16, 20);
					Point p2_2 = new Point(((Control)this).get_Width() - 12, 16);
					Point p3_ = new Point(((Control)this).get_Width() - 16, 21);
					Point p3_2 = new Point(((Control)this).get_Width() - 16, 20);
					HelperMethods.DrawTriangle(val2, hTMLColor, 2, p1_, p1_2, p2_, p2_2, p3_, p3_2);
					HelperMethods.DrawRoundedPath(val2, HelperMethods.GetHTMLColor("ececec"), 1.5f, rect, 4);
					Graphics obj = val3;
					string text = ((ComboBox)this).get_Text();
					Font font = ((Control)this).get_Font();
					SolidBrush val4 = new SolidBrush(HelperMethods.GetHTMLColor("b8c6d6"));
					Rectangle rectangle = new Rectangle(7, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
					RectangleF rectangleF = rectangle;
					StringFormat val5 = new StringFormat();
					val5.set_LineAlignment((StringAlignment)1);
					val5.set_Alignment((StringAlignment)0);
					obj.DrawString(text, font, (Brush)val4, rectangleF, val5);
					val3 = null;
					e.get_Graphics().DrawImage((Image)(object)val, 0, 0);
					val2.Dispose();
					((Image)val).Dispose();
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
	}
}
