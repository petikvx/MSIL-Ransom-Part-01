using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Facebook_HACK_ANO;

public class ReactorTabControl : TabControl
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private LinearGradientBrush DrawGradientBrush;

	private LinearGradientBrush DrawGradientBrush2;

	private Color _TabBrColor;

	private Color _ControlBColor;

	public Color TabBorderColor
	{
		get
		{
			return _TabBrColor;
		}
		set
		{
			_TabBrColor = value;
			((Control)this).Invalidate();
		}
	}

	public Color TabTextColor
	{
		get
		{
			return _ControlBColor;
		}
		set
		{
			_ControlBColor = value;
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

	public ReactorTabControl()
	{
		__ENCAddToList(this);
		((Control)this).SetStyle((ControlStyles)73746, true);
		TabBorderColor = Color.White;
		TabTextColor = Color.White;
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected O, but got Unknown
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected O, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected O, but got Unknown
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected O, but got Unknown
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Expected O, but got Unknown
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected O, but got Unknown
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Expected O, but got Unknown
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Expected O, but got Unknown
		//IL_0436: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Expected O, but got Unknown
		//IL_04f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f8: Expected O, but got Unknown
		//IL_0541: Unknown result type (might be due to invalid IL or missing references)
		//IL_054b: Expected O, but got Unknown
		//IL_0546: Unknown result type (might be due to invalid IL or missing references)
		//IL_055d: Expected O, but got Unknown
		//IL_0563: Unknown result type (might be due to invalid IL or missing references)
		//IL_056d: Expected O, but got Unknown
		//IL_0568: Unknown result type (might be due to invalid IL or missing references)
		//IL_058d: Expected O, but got Unknown
		//IL_0599: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a3: Expected O, but got Unknown
		//IL_059e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c3: Expected O, but got Unknown
		//IL_05cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d9: Expected O, but got Unknown
		//IL_05d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e7: Expected O, but got Unknown
		//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fd: Expected O, but got Unknown
		//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_060b: Expected O, but got Unknown
		//IL_0617: Unknown result type (might be due to invalid IL or missing references)
		//IL_0621: Expected O, but got Unknown
		//IL_061c: Unknown result type (might be due to invalid IL or missing references)
		//IL_063d: Expected O, but got Unknown
		//IL_0649: Unknown result type (might be due to invalid IL or missing references)
		//IL_0653: Expected O, but got Unknown
		//IL_064e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Expected O, but got Unknown
		Graphics graphics = e.get_Graphics();
		((Control)this).OnPaint(e);
		checked
		{
			Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, 25);
			Rectangle rectangle2 = new Rectangle(0, 0, ((Control)this).get_Width() - 1, 25);
			Rectangle rectangle3 = new Rectangle(2, 0, ((Control)this).get_Width() - 1, 13);
			SolidBrush val = new SolidBrush(Color.Empty);
			SolidBrush val2 = new SolidBrush(Color.DimGray);
			LinearGradientBrush val3 = new LinearGradientBrush(rectangle3, Color.FromArgb(50, Color.White), Color.FromArgb(25, Color.White), 90f);
			graphics.Clear(Color.FromArgb(32, 32, 32));
			DrawGradientBrush2 = new LinearGradientBrush(rectangle2, Color.FromArgb(10, 10, 10), Color.FromArgb(50, 50, 50), 90f);
			Pen val4 = new Pen((Brush)new SolidBrush(Color.FromArgb(28, 28, 28)));
			Rectangle rectangle4 = new Rectangle(1, 1, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 3);
			graphics.DrawRectangle(val4, rectangle4);
			graphics.FillRectangle((Brush)(object)DrawGradientBrush2, rectangle);
			graphics.FillRectangle((Brush)(object)val3, rectangle3);
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
				Rectangle tabRect = ((TabControl)this).GetTabRect(num2);
				if ((unchecked((uint)num2) & (true ? 1u : 0u)) != 0)
				{
					val2.set_Color(Color.Transparent);
				}
				else
				{
					val2.set_Color(Color.Transparent);
				}
				graphics.FillRectangle((Brush)(object)val2, tabRect);
				Pen val5;
				if (num2 == ((TabControl)this).get_SelectedIndex())
				{
					val5 = new Pen(Color.Transparent, 1f);
					rectangle4 = new Rectangle(tabRect.Location.X + 3, tabRect.Location.Y + 3, tabRect.Width - 8, tabRect.Height - 6);
					LinearGradientBrush val6 = new LinearGradientBrush(rectangle4, Color.FromArgb(175, 219, 78, 0), Color.FromArgb(175, 229, 98, 0), 90f);
					rectangle4 = new Rectangle(tabRect.Location.X + 3, tabRect.Location.Y + 3, tabRect.Width - 8, (int)Math.Round((double)tabRect.Height / 2.0 - 5.0));
					LinearGradientBrush val7 = new LinearGradientBrush(rectangle4, Color.FromArgb(80, Color.White), Color.FromArgb(20, Color.White), 90f);
					rectangle4 = new Rectangle(tabRect.Location.X + 3, tabRect.Location.Y + 3, tabRect.Width - 8, tabRect.Height - 6);
					graphics.FillRectangle((Brush)(object)val6, rectangle4);
					rectangle4 = new Rectangle(tabRect.Location.X + 3, tabRect.Location.Y + 3, tabRect.Width - 8, (int)Math.Round((double)tabRect.Height / 2.0 - 4.0));
					graphics.FillRectangle((Brush)(object)val7, rectangle4);
					Pen val8 = new Pen((Brush)new SolidBrush(Color.FromArgb(10, 10, 10)));
					rectangle4 = new Rectangle(tabRect.Location.X + 3, tabRect.Location.Y + 3, tabRect.Width - 8, tabRect.Height - 6);
					graphics.DrawRectangle(val8, rectangle4);
					Pen val9 = new Pen((Brush)new SolidBrush(Color.FromArgb(100, 230, 90, 0)));
					rectangle4 = new Rectangle(tabRect.Location.X + 4, tabRect.Location.Y + 4, tabRect.Width - 10, tabRect.Height - 8);
					graphics.DrawRectangle(val9, rectangle4);
					Rectangle rectangle5 = new Rectangle(1, 1, ((Control)this).get_Width() - 1, 3);
				}
				else
				{
					val5 = new Pen(Color.Transparent, 1f);
				}
				Pen obj = val5;
				rectangle4 = new Rectangle(tabRect.Location.X + 3, tabRect.Location.Y + 1, tabRect.Width - 8, tabRect.Height - 4);
				graphics.DrawRectangle(obj, rectangle4);
				val5.Dispose();
				StringFormat val10 = new StringFormat();
				val10.set_LineAlignment((StringAlignment)1);
				val10.set_Alignment((StringAlignment)1);
				if (((TabControl)this).get_SelectedIndex() == num2)
				{
					val.set_Color(TabTextColor);
				}
				else
				{
					val.set_Color(Color.DimGray);
				}
				graphics.DrawString(((TabControl)this).get_TabPages().get_Item(num2).get_Text(), ((Control)this).get_Font(), (Brush)(object)val, (RectangleF)((TabControl)this).GetTabRect(num2), val10);
				try
				{
					((TabControl)this).get_TabPages().get_Item(num2).set_BackColor(Color.FromArgb(32, 32, 32));
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				num2++;
			}
			try
			{
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = ((TabControl)this).get_TabPages().GetEnumerator();
					while (enumerator.MoveNext())
					{
						TabPage val11 = (TabPage)enumerator.Current;
						((Panel)val11).set_BorderStyle((BorderStyle)0);
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			graphics.DrawLine(new Pen((Brush)new SolidBrush(Color.FromArgb(10, 10, 10))), 2, 24, ((Control)this).get_Width() - 2, 24);
			Pen val12 = new Pen((Brush)new SolidBrush(Color.Black));
			rectangle4 = new Rectangle(1, 1, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 3);
			graphics.DrawRectangle(val12, rectangle4);
			Pen val13 = new Pen((Brush)new SolidBrush(Color.FromArgb(70, 70, 70)));
			rectangle4 = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			graphics.DrawRectangle(val13, rectangle4);
			graphics.DrawLine(new Pen((Brush)new SolidBrush(Color.FromArgb(45, 45, 45))), 0, 0, ((Control)this).get_Width(), 0);
			graphics.DrawLine(new Pen((Brush)new SolidBrush(Color.FromArgb(45, 45, 45))), 0, 0, 0, ((Control)this).get_Height());
			graphics.DrawLine(new Pen((Brush)new SolidBrush(Color.FromArgb(45, 45, 45))), ((Control)this).get_Width() - 1, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height());
			graphics.DrawLine(new Pen((Brush)new SolidBrush(Color.FromArgb(31, 31, 31))), 2, 2, ((Control)this).get_Width() - 3, 2);
		}
	}
}
