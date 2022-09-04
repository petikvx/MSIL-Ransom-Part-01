using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Facebook_HACK_ANO;

public class ReactorComboBox : ComboBox
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private int _StartIndex;

	private Color LightBlack;

	private Color LighterBlack;

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

	protected override void OnPaintBackground(PaintEventArgs pevent)
	{
	}

	public void ReplaceItem(object sender, DrawItemEventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Invalid comparison between Unknown and I4
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		e.DrawBackground();
		try
		{
			if ((e.get_State() & 1) == 1)
			{
				e.get_Graphics().FillRectangle((Brush)new SolidBrush(Color.FromArgb(229, 88, 0)), e.get_Bounds());
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

	public ReactorComboBox()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		((ComboBox)this).add_DrawItem(new DrawItemEventHandler(ReplaceItem));
		__ENCAddToList(this);
		_StartIndex = 0;
		LightBlack = Color.FromArgb(37, 37, 37);
		LighterBlack = Color.FromArgb(60, 60, 60);
		((Control)this).SetStyle((ControlStyles)73746, true);
		((ComboBox)this).set_DrawMode((DrawMode)1);
		((ComboBox)this).set_BackColor(Color.FromArgb(45, 45, 45));
		((ComboBox)this).set_ForeColor(Color.White);
		((ComboBox)this).set_DropDownStyle((ComboBoxStyle)2);
		((Control)this).set_DoubleBuffered(true);
		((Control)this).Invalidate();
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected O, but got Unknown
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected O, but got Unknown
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected O, but got Unknown
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected O, but got Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected O, but got Unknown
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected O, but got Unknown
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected O, but got Unknown
		((Control)this).OnPaint(e);
		Graphics graphics = e.get_Graphics();
		Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width(), 10);
		LinearGradientBrush val = new LinearGradientBrush(rectangle, Color.FromArgb(62, Color.White), Color.FromArgb(30, Color.White), 90f);
		new SolidBrush(Color.FromArgb(37, 37, 37));
		checked
		{
			try
			{
				Graphics val2 = graphics;
				val2.set_SmoothingMode((SmoothingMode)2);
				val2.Clear(Color.FromArgb(37, 37, 37));
				Graphics obj = val2;
				rectangle = new Rectangle(((Control)this).get_Width() - 20, 0, ((Control)this).get_Width(), 9);
				obj.FillRectangle((Brush)(object)val, rectangle);
				val2.DrawLine(Pens.get_Black(), ((Control)this).get_Width() - 20, 0, ((Control)this).get_Width() - 20, ((Control)this).get_Height());
				try
				{
					Graphics obj2 = val2;
					string text = ((ComboBox)this).get_Text();
					Font font = ((Control)this).get_Font();
					Brush white = Brushes.get_White();
					rectangle = new Rectangle(3, 0, ((Control)this).get_Width() - 20, ((Control)this).get_Height());
					RectangleF rectangleF = rectangle;
					StringFormat val3 = new StringFormat();
					val3.set_LineAlignment((StringAlignment)1);
					val3.set_Alignment((StringAlignment)0);
					obj2.DrawString(text, font, white, rectangleF, val3);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				val2.DrawLine(new Pen((Brush)new SolidBrush(Color.FromArgb(37, 37, 37))), 0, 0, 0, 0);
				Graphics obj3 = val2;
				Pen val4 = new Pen((Brush)new SolidBrush(Color.FromArgb(0, 0, 0)));
				rectangle = new Rectangle(1, 1, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 3);
				obj3.DrawRectangle(val4, rectangle);
				val2.DrawLine(new Pen((Brush)new SolidBrush(Color.FromArgb(45, 45, 45))), 0, 0, ((Control)this).get_Width(), 0);
				val2.DrawLine(new Pen((Brush)new SolidBrush(Color.FromArgb(45, 45, 45))), 0, 0, 0, ((Control)this).get_Height());
				val2.DrawLine(new Pen((Brush)new SolidBrush(Color.FromArgb(45, 45, 45))), ((Control)this).get_Width() - 1, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height());
				val2.DrawLine(new Pen((Brush)new SolidBrush(Color.FromArgb(70, 70, 70))), 0, ((Control)this).get_Height() - 1, ((Control)this).get_Width(), ((Control)this).get_Height() - 1);
				Color white2 = Color.White;
				Point firstPoint = new Point(((Control)this).get_Width() - 14, 8);
				Point secondPoint = new Point(((Control)this).get_Width() - 7, 8);
				Point thirdPoint = new Point(((Control)this).get_Width() - 11, 11);
				DrawTriangle(white2, firstPoint, secondPoint, thirdPoint, graphics);
				val2 = null;
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
	}
}
