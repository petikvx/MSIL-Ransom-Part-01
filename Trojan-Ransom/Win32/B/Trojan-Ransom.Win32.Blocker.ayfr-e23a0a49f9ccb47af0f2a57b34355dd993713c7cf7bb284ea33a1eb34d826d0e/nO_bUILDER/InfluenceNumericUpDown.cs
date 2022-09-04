using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace nO_bUILDER;

public class InfluenceNumericUpDown : Control
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private MouseState State;

	private int X;

	private int Y;

	private long _Value;

	private long _Max;

	private long _Min;

	private bool Typing;

	public long Value
	{
		get
		{
			return _Value;
		}
		set
		{
			if ((value <= _Max) & (value >= _Min))
			{
				_Value = value;
			}
			((Control)this).Invalidate();
		}
	}

	public long Maximum
	{
		get
		{
			return _Max;
		}
		set
		{
			if (value > _Min)
			{
				_Max = value;
			}
			if (_Value > _Max)
			{
				_Value = _Max;
			}
			((Control)this).Invalidate();
		}
	}

	public long Minimum
	{
		get
		{
			return _Min;
		}
		set
		{
			if (value < _Max)
			{
				_Min = value;
			}
			if (_Value < _Min)
			{
				_Value = _Min;
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

	protected override void OnMouseMove(MouseEventArgs e)
	{
		((Control)this).OnMouseMove(e);
		X = e.get_Location().X;
		Y = e.get_Location().Y;
		((Control)this).Invalidate();
		if (e.get_X() < checked(((Control)this).get_Width() - 23))
		{
			((Control)this).set_Cursor(Cursors.get_IBeam());
		}
		else
		{
			((Control)this).set_Cursor(Cursors.get_Default());
		}
	}

	protected override void OnResize(EventArgs e)
	{
		((Control)this).OnResize(e);
		((Control)this).set_Height(22);
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		((Control)this).OnMouseClick(e);
		checked
		{
			if (X > ((Control)this).get_Width() - 21)
			{
				if (Y < 10)
				{
					if (Value + 1L <= _Max)
					{
						_Value++;
					}
				}
				else if (Value - 1L >= _Min)
				{
					_Value--;
				}
			}
			else
			{
				Typing = !Typing;
				((Control)this).Focus();
			}
			((Control)this).Invalidate();
		}
	}

	protected override void OnKeyPress(KeyPressEventArgs e)
	{
		((Control)this).OnKeyPress(e);
		try
		{
			if (Typing)
			{
				_Value = Conversions.ToLong(Conversions.ToString(_Value) + e.get_KeyChar());
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	protected override void OnKeyUp(KeyEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Invalid comparison between Unknown and I4
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Invalid comparison between Unknown and I4
		((Control)this).OnKeyUp(e);
		checked
		{
			if (unchecked((int)e.get_KeyCode()) == 38)
			{
				if (Value + 1L <= _Max)
				{
					_Value++;
				}
				((Control)this).Invalidate();
			}
			else if (unchecked((int)e.get_KeyCode()) == 40 && Value - 1L >= _Min)
			{
				_Value--;
			}
			((Control)this).Invalidate();
		}
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

	public InfluenceNumericUpDown()
	{
		__ENCAddToList(this);
		State = default(MouseState);
		_Max = 9999999L;
		_Min = 0L;
		((Control)this).set_Cursor(Cursors.get_IBeam());
		((Control)this).SetStyle((ControlStyles)2050, true);
		((Control)this).set_BackColor(Color.Transparent);
		((Control)this).set_DoubleBuffered(true);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected O, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected O, but got Unknown
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected O, but got Unknown
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected O, but got Unknown
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected O, but got Unknown
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		val2.Clear(((Control)this).get_BackColor());
		Draw draw = new Draw();
		val2.set_SmoothingMode((SmoothingMode)2);
		val2.Clear(Color.FromArgb(20, 20, 20));
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
			Pen val6 = new Pen(Color.FromArgb(150, 97, 94, 90));
			rectangle = new Rectangle(0, 1, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 3);
			val2.DrawPath(val6, draw.RoundRect(rectangle, 2));
			Pen val7 = new Pen(Color.FromArgb(0, 0, 0));
			rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			val2.DrawPath(val7, draw.RoundRect(rectangle, 2));
			Pen val8 = new Pen(Color.FromArgb(10, 10, 10));
			Point point = new Point(((Control)this).get_Width() - 21, 0);
			Point point2 = point;
			Point point3 = new Point(((Control)this).get_Width() - 21, ((Control)this).get_Height());
			val2.DrawLine(val8, point2, point3);
			Pen val9 = new Pen(Color.FromArgb(70, 70, 70));
			point3 = new Point(((Control)this).get_Width() - 20, 1);
			Point point4 = point3;
			point = new Point(((Control)this).get_Width() - 20, ((Control)this).get_Height() - 3);
			val2.DrawLine(val9, point4, point);
			Pen val10 = new Pen(Color.FromArgb(10, 10, 10));
			point3 = new Point(((Control)this).get_Width() - 20, 10);
			Point point5 = point3;
			point = new Point(((Control)this).get_Width(), 10);
			val2.DrawLine(val10, point5, point);
			Pen val11 = new Pen(Color.FromArgb(70, 70, 70));
			point3 = new Point(((Control)this).get_Width() - 19, 11);
			Point point6 = point3;
			point = new Point(((Control)this).get_Width() - 3, 11);
			val2.DrawLine(val11, point6, point);
			Color white = Color.White;
			point3 = new Point(((Control)this).get_Width() - 14, 14);
			Point firstPoint = point3;
			point = new Point(((Control)this).get_Width() - 7, 14);
			Point secondPoint = point;
			Point thirdPoint = new Point(((Control)this).get_Width() - 11, 18);
			DrawTriangle(white, firstPoint, secondPoint, thirdPoint, val2);
			Color white2 = Color.White;
			thirdPoint = new Point(((Control)this).get_Width() - 14, 7);
			Point firstPoint2 = thirdPoint;
			point3 = new Point(((Control)this).get_Width() - 7, 7);
			Point secondPoint2 = point3;
			point = new Point(((Control)this).get_Width() - 11, 3);
			DrawTriangle(white2, firstPoint2, secondPoint2, point, val2);
			string text = Conversions.ToString(Value);
			Font font = ((Control)this).get_Font();
			Brush white3 = Brushes.get_White();
			thirdPoint = new Point(5, 4);
			val2.DrawString(text, font, white3, (PointF)thirdPoint);
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
