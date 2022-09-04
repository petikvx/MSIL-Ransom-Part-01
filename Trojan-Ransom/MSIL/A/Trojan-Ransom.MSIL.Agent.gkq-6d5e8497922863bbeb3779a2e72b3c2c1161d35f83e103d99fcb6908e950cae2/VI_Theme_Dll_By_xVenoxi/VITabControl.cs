using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace VI_Theme_Dll_By_xVenoxi;

public class VITabControl : TabControl
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private int OldIndex;

	private int _Speed;

	private Color LightBlack;

	private Color LighterBlack;

	private LinearGradientBrush DrawGradientBrush;

	private LinearGradientBrush DrawGradientBrush2;

	private LinearGradientBrush DrawGradientBrushPen;

	private LinearGradientBrush DrawGradientBrushTab;

	private Color _ControlBColor;

	public int Speed
	{
		get
		{
			return _Speed;
		}
		set
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			if (value > 20 || value < -20)
			{
				Interaction.MsgBox((object)"Speed needs to be in between -20 and 20.", (MsgBoxStyle)0, (object)null);
			}
			else
			{
				_Speed = value;
			}
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

	public VITabControl()
	{
		__ENCAddToList(this);
		_Speed = 10;
		LightBlack = Color.FromArgb(18, 18, 18);
		LighterBlack = Color.FromArgb(21, 21, 21);
		((Control)this).SetStyle((ControlStyles)139282, true);
		TabTextColor = Color.White;
		((TabControl)this).set_Alignment((TabAlignment)0);
		Size itemSize = new Size(25, 30);
		((TabControl)this).set_ItemSize(itemSize);
		((TabControl)this).set_SizeMode((TabSizeMode)1);
		((TabControl)this).set_DrawMode((TabDrawMode)1);
	}

	public void DoAnimationScrollDown(Control Control1, Control Control2)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected O, but got Unknown
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		Graphics val = Control1.CreateGraphics();
		Bitmap val2 = new Bitmap(Control1.get_Width(), Control1.get_Height());
		Bitmap val3 = new Bitmap(Control2.get_Width(), Control2.get_Height());
		Rectangle rectangle = new Rectangle(0, 0, Control1.get_Width(), Control1.get_Height());
		Control1.DrawToBitmap(val2, rectangle);
		rectangle = new Rectangle(0, 0, Control2.get_Width(), Control2.get_Height());
		Control2.DrawToBitmap(val3, rectangle);
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = Control1.get_Controls().GetEnumerator();
			while (enumerator.MoveNext())
			{
				Control val4 = (Control)enumerator.Current;
				val4.Hide();
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		checked
		{
			int num = Control1.get_Height() - unchecked(Control1.get_Height() % _Speed);
			int num2 = num;
			int speed = _Speed;
			int num3 = 0;
			while (true)
			{
				int num4 = (speed >> 31) ^ num3;
				int num5 = (speed >> 31) ^ num2;
				if (num4 > num5)
				{
					break;
				}
				rectangle = new Rectangle(0, num3, Control1.get_Width(), Control1.get_Height());
				val.DrawImage((Image)(object)val2, rectangle);
				rectangle = new Rectangle(0, num3 - Control2.get_Height(), Control2.get_Width(), Control2.get_Height());
				val.DrawImage((Image)(object)val3, rectangle);
				num3 += speed;
			}
			num3 = Control1.get_Width();
			rectangle = new Rectangle(0, num3, Control1.get_Width(), Control1.get_Height());
			val.DrawImage((Image)(object)val2, rectangle);
			rectangle = new Rectangle(0, num3 - Control2.get_Height(), Control2.get_Width(), Control2.get_Height());
			val.DrawImage((Image)(object)val3, rectangle);
			((TabControl)this).set_SelectedTab((TabPage)Control2);
			IEnumerator enumerator2 = default(IEnumerator);
			try
			{
				enumerator2 = Control2.get_Controls().GetEnumerator();
				while (enumerator2.MoveNext())
				{
					Control val5 = (Control)enumerator2.Current;
					val5.Show();
				}
			}
			finally
			{
				if (enumerator2 is IDisposable)
				{
					(enumerator2 as IDisposable).Dispose();
				}
			}
			IEnumerator enumerator3 = default(IEnumerator);
			try
			{
				enumerator3 = Control1.get_Controls().GetEnumerator();
				while (enumerator3.MoveNext())
				{
					Control val6 = (Control)enumerator3.Current;
					val6.Show();
				}
			}
			finally
			{
				if (enumerator3 is IDisposable)
				{
					(enumerator3 as IDisposable).Dispose();
				}
			}
		}
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected O, but got Unknown
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected O, but got Unknown
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected O, but got Unknown
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected O, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected O, but got Unknown
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected O, but got Unknown
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected O, but got Unknown
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Expected O, but got Unknown
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Expected O, but got Unknown
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Expected O, but got Unknown
		((Control)this).OnPaint(e);
		e.get_Graphics().Clear(Color.FromArgb(18, 18, 18));
		SolidBrush val = new SolidBrush(Color.Empty);
		SolidBrush val2 = new SolidBrush(Color.Black);
		checked
		{
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
				e.get_Graphics().FillRectangle((Brush)(object)val2, tabRect);
				Pen val3 = ((num2 != ((TabControl)this).get_SelectedIndex()) ? new Pen(Color.Black, 1f) : new Pen(Color.Black, 1f));
				Rectangle rectangle = new Rectangle(tabRect.Location.X + 3, tabRect.Location.Y + 0, tabRect.Width - 4, tabRect.Height - 2);
				e.get_Graphics().DrawRectangle(val3, rectangle);
				Brush val4 = (Brush)new LinearGradientBrush(rectangle, Color.FromArgb(15, 15, 15), Color.FromArgb(24, 24, 24), (LinearGradientMode)1);
				e.get_Graphics().FillRectangle(val4, rectangle);
				val3.Dispose();
				StringFormat val5 = new StringFormat();
				val5.set_LineAlignment((StringAlignment)1);
				val5.set_Alignment((StringAlignment)1);
				if (((TabControl)this).get_SelectedIndex() == num2)
				{
					val.set_Color(TabTextColor);
				}
				else
				{
					val.set_Color(Color.Gray);
				}
				e.get_Graphics().DrawString(((TabControl)this).get_TabPages().get_Item(num2).get_Text(), ((Control)this).get_Font(), (Brush)(object)val, (RectangleF)((TabControl)this).GetTabRect(num2), val5);
				try
				{
					((TabControl)this).get_TabPages().get_Item(num2).set_BackColor(Color.FromArgb(15, 15, 15));
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
						TabPage val6 = (TabPage)enumerator.Current;
						((Panel)val6).set_BorderStyle((BorderStyle)0);
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
			e.get_Graphics().DrawRectangle(new Pen((Brush)new SolidBrush(Color.FromArgb(255, Color.Black))), 2, 0, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 3);
			Graphics graphics = e.get_Graphics();
			Pen val7 = new Pen((Brush)new SolidBrush(LighterBlack));
			Rectangle rectangle2 = new Rectangle(3, 2, ((Control)this).get_Width() - 5, ((Control)this).get_Height() - 7);
			graphics.DrawRectangle(val7, rectangle2);
			e.get_Graphics().DrawLine(new Pen((Brush)new SolidBrush(Color.FromArgb(255, Color.Black))), 2, 2, ((Control)this).get_Width() - 2, 2);
			e.get_Graphics().DrawLine(new Pen((Brush)new SolidBrush(Color.FromArgb(35, 35, 35))), 0, 0, 1, 1);
			e.get_Graphics().DrawLine(new Pen((Brush)new SolidBrush(Color.FromArgb(70, 70, 70))), 2, ((Control)this).get_Height() - 2, ((Control)this).get_Width() + 1, ((Control)this).get_Height() - 2);
		}
	}

	protected override void OnSelecting(TabControlCancelEventArgs e)
	{
		if (OldIndex < e.get_TabPageIndex())
		{
			DoAnimationScrollUp((Control)(object)((TabControl)this).get_TabPages().get_Item(OldIndex), (Control)(object)((TabControl)this).get_TabPages().get_Item(e.get_TabPageIndex()));
		}
		else
		{
			DoAnimationScrollDown((Control)(object)((TabControl)this).get_TabPages().get_Item(OldIndex), (Control)(object)((TabControl)this).get_TabPages().get_Item(e.get_TabPageIndex()));
		}
	}

	protected override void OnDeselecting(TabControlCancelEventArgs e)
	{
		OldIndex = e.get_TabPageIndex();
	}

	public void DoAnimationScrollUp(Control Control1, Control Control2)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected O, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected O, but got Unknown
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected O, but got Unknown
		Graphics val = Control1.CreateGraphics();
		Bitmap val2 = new Bitmap(Control1.get_Width(), Control1.get_Height());
		Bitmap val3 = new Bitmap(Control2.get_Width(), Control2.get_Height());
		Rectangle rectangle = new Rectangle(0, 0, Control1.get_Width(), Control1.get_Height());
		Control1.DrawToBitmap(val2, rectangle);
		rectangle = new Rectangle(0, 0, Control2.get_Width(), Control2.get_Height());
		Control2.DrawToBitmap(val3, rectangle);
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = Control1.get_Controls().GetEnumerator();
			while (enumerator.MoveNext())
			{
				Control val4 = (Control)enumerator.Current;
				val4.Hide();
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		checked
		{
			int num = Control1.get_Height() - unchecked(Control1.get_Height() % _Speed);
			int num2 = -num;
			int num3 = -_Speed;
			int num4 = 0;
			while (true)
			{
				int num5 = (num3 >> 31) ^ num4;
				int num6 = (num3 >> 31) ^ num2;
				if (num5 > num6)
				{
					break;
				}
				rectangle = new Rectangle(0, num4, Control1.get_Width(), Control1.get_Height());
				val.DrawImage((Image)(object)val2, rectangle);
				rectangle = new Rectangle(0, num4 + Control2.get_Height(), Control2.get_Width(), Control2.get_Height());
				val.DrawImage((Image)(object)val3, rectangle);
				num4 += num3;
			}
			num4 = Control1.get_Width();
			rectangle = new Rectangle(0, num4, Control1.get_Width(), Control1.get_Height());
			val.DrawImage((Image)(object)val2, rectangle);
			rectangle = new Rectangle(0, num4 + Control2.get_Height(), Control2.get_Width(), Control2.get_Height());
			val.DrawImage((Image)(object)val3, rectangle);
			((TabControl)this).set_SelectedTab((TabPage)Control2);
			IEnumerator enumerator2 = default(IEnumerator);
			try
			{
				enumerator2 = Control2.get_Controls().GetEnumerator();
				while (enumerator2.MoveNext())
				{
					Control val5 = (Control)enumerator2.Current;
					val5.Show();
				}
			}
			finally
			{
				if (enumerator2 is IDisposable)
				{
					(enumerator2 as IDisposable).Dispose();
				}
			}
			IEnumerator enumerator3 = default(IEnumerator);
			try
			{
				enumerator3 = Control1.get_Controls().GetEnumerator();
				while (enumerator3.MoveNext())
				{
					Control val6 = (Control)enumerator3.Current;
					val6.Show();
				}
			}
			finally
			{
				if (enumerator3 is IDisposable)
				{
					(enumerator3 as IDisposable).Dispose();
				}
			}
		}
	}
}
