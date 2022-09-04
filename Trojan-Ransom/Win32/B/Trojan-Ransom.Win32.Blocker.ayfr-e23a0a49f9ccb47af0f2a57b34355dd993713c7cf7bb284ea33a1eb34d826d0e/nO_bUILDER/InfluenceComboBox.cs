using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace nO_bUILDER;

public class InfluenceComboBox : ComboBox
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private int _StartIndex;

	private Color _highlightColor;

	public int StartIndex
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

	public Color ItemHighlightColor
	{
		get
		{
			return _highlightColor;
		}
		set
		{
			_highlightColor = value;
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

	public void ReplaceItem(object sender, DrawItemEventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Invalid comparison between Unknown and I4
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		e.DrawBackground();
		try
		{
			if ((e.get_State() & 1) == 1)
			{
				e.get_Graphics().FillRectangle((Brush)new SolidBrush(_highlightColor), e.get_Bounds());
			}
			SolidBrush val = new SolidBrush(e.get_ForeColor());
			try
			{
				e.get_Graphics().DrawString(((ListControl)this).GetItemText(RuntimeHelpers.GetObjectValue(((ComboBox)this).get_Items().get_Item(e.get_Index()))), e.get_Font(), (Brush)(object)val, (RectangleF)e.get_Bounds());
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		e.DrawFocusRectangle();
		((Control)this).Invalidate();
	}

	protected void DrawTriangle(Color Clr, Point FirstPoint, Point SecondPoint, Point ThirdPoint, Graphics G)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		List<Point> list = new List<Point>();
		list.Add(FirstPoint);
		list.Add(SecondPoint);
		list.Add(ThirdPoint);
		G.FillPolygon((Brush)new SolidBrush(Clr), list.ToArray());
	}

	public InfluenceComboBox()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		((ComboBox)this).add_DrawItem(new DrawItemEventHandler(ReplaceItem));
		__ENCAddToList(this);
		_StartIndex = 0;
		_highlightColor = Color.FromArgb(128, 128, 128);
		((Control)this).SetStyle((ControlStyles)75794, true);
		((ComboBox)this).set_DrawMode((DrawMode)1);
		((ComboBox)this).set_BackColor(Color.Transparent);
		((ComboBox)this).set_ForeColor(Color.White);
		((ComboBox)this).set_DropDownStyle((ComboBoxStyle)2);
		((Control)this).set_DoubleBuffered(true);
		((Control)this).Invalidate();
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected O, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected O, but got Unknown
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		Draw draw = new Draw();
		val2.set_SmoothingMode((SmoothingMode)2);
		val2.Clear(((ComboBox)this).get_BackColor());
		LinearGradientBrush val3 = new LinearGradientBrush(((Control)this).get_ClientRectangle(), Color.FromArgb(125, 78, 75, 73), Color.FromArgb(125, 61, 59, 55), 90f);
		checked
		{
			Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 2);
			val2.FillPath((Brush)(object)val3, draw.RoundRect(rectangle, 2));
			HatchBrush val4 = new HatchBrush((HatchStyle)21, Color.FromArgb(100, 31, 31, 31), Color.FromArgb(100, 36, 36, 36));
			rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 2);
			val2.FillPath((Brush)(object)val4, draw.RoundRect(rectangle, 2));
			rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, (int)Math.Round((double)((Control)this).get_Height() / 2.0));
			LinearGradientBrush val5 = new LinearGradientBrush(rectangle, Color.FromArgb(35, Color.White), Color.FromArgb(0, Color.White), 90f);
			rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, (int)Math.Round((double)((Control)this).get_Height() / 2.0 - 1.0));
			val2.FillPath((Brush)(object)val5, draw.RoundRect(rectangle, 2));
			val2.DrawLine(new Pen(Color.FromArgb(85, 83, 80)), ((Control)this).get_Width() - 18, 0, ((Control)this).get_Width() - 18, ((Control)this).get_Height() - 1);
			val2.DrawLine(new Pen(Color.FromArgb(15, 13, 10)), ((Control)this).get_Width() - 19, 0, ((Control)this).get_Width() - 19, ((Control)this).get_Height() - 1);
			Pen val6 = new Pen(Color.FromArgb(150, 97, 94, 90));
			rectangle = new Rectangle(0, 1, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 3);
			val2.DrawPath(val6, draw.RoundRect(rectangle, 2));
			Pen val7 = new Pen(Color.FromArgb(0, 0, 0));
			rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			val2.DrawPath(val7, draw.RoundRect(rectangle, 2));
			Color white = Color.White;
			Point point = new Point(((Control)this).get_Width() - 14, 12);
			Point firstPoint = point;
			Point point2 = new Point(((Control)this).get_Width() - 7, 12);
			Point secondPoint = point2;
			Point thirdPoint = new Point(((Control)this).get_Width() - 11, 15);
			DrawTriangle(white, firstPoint, secondPoint, thirdPoint, val2);
			Color white2 = Color.White;
			thirdPoint = new Point(((Control)this).get_Width() - 14, 9);
			Point firstPoint2 = thirdPoint;
			point2 = new Point(((Control)this).get_Width() - 7, 9);
			Point secondPoint2 = point2;
			point = new Point(((Control)this).get_Width() - 11, 6);
			DrawTriangle(white2, firstPoint2, secondPoint2, point, val2);
			try
			{
				string text = ((ComboBox)this).get_Text();
				Font font = ((Control)this).get_Font();
				Brush white3 = Brushes.get_White();
				rectangle = new Rectangle(3, 0, ((Control)this).get_Width() - 20, ((Control)this).get_Height());
				RectangleF rectangleF = rectangle;
				StringFormat val8 = new StringFormat();
				val8.set_LineAlignment((StringAlignment)1);
				val8.set_Alignment((StringAlignment)0);
				val2.DrawString(text, font, white3, rectangleF, val8);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			NewLateBinding.LateCall((object)e.get_Graphics(), (Type)null, "DrawImage", new object[3]
			{
				RuntimeHelpers.GetObjectValue(((Image)val).Clone()),
				0,
				0
			}, (string[])null, (Type[])null, (bool[])null, true);
			val2.Dispose();
			((Image)val).Dispose();
		}
	}
}
