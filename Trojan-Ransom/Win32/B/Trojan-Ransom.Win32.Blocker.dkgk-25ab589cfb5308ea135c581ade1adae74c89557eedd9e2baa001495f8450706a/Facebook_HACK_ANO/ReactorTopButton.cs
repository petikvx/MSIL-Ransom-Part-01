using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Facebook_HACK_ANO;

public class ReactorTopButton : Control
{
	public enum topButtonType : byte
	{
		Blank,
		Minimize,
		Maximize,
		Close
	}

	public enum closeFunc : byte
	{
		CloseForm,
		CloseApp
	}

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private Color buttonColor;

	private MouseState State;

	private topButtonType _tbType;

	private bool _defaultFunc;

	private closeFunc _closeFunc;

	public topButtonType ButtonType
	{
		get
		{
			return _tbType;
		}
		set
		{
			_tbType = value;
			((Control)this).Invalidate();
		}
	}

	public bool UseStandardFunction
	{
		get
		{
			return _defaultFunc;
		}
		set
		{
			_defaultFunc = value;
		}
	}

	public closeFunc CloseButtonFunction
	{
		get
		{
			return _closeFunc;
		}
		set
		{
			_closeFunc = value;
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

	protected override void OnMouseEnter(EventArgs e)
	{
		((Control)this).OnMouseEnter(e);
		State = MouseState.Over;
		((Control)this).Invalidate();
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		((Control)this).OnMouseDown(e);
		State = MouseState.Down;
		((Control)this).Invalidate();
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		((Control)this).OnMouseLeave(e);
		State = MouseState.None;
		((Control)this).Invalidate();
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		((Control)this).OnMouseUp(e);
		State = MouseState.Over;
		((Control)this).Invalidate();
	}

	protected override void OnPaintBackground(PaintEventArgs pevent)
	{
	}

	protected override void OnTextChanged(EventArgs e)
	{
		((Control)this).OnTextChanged(e);
		((Control)this).Invalidate();
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public void buttonFunction()
	{
		if (!_defaultFunc)
		{
			return;
		}
		switch (ButtonType)
		{
		case topButtonType.Minimize:
			((Control)this).get_Parent().FindForm().set_WindowState((FormWindowState)1);
			break;
		case topButtonType.Maximize:
			((Control)this).get_Parent().FindForm().set_WindowState((FormWindowState)2);
			break;
		case topButtonType.Close:
			switch (CloseButtonFunction)
			{
			case closeFunc.CloseForm:
				((Control)this).get_Parent().FindForm().Close();
				break;
			case closeFunc.CloseApp:
				Application.Exit();
				ProjectData.EndApp();
				break;
			}
			break;
		}
	}

	public ReactorTopButton()
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		((Control)this).add_Click((EventHandler)delegate
		{
			buttonFunction();
		});
		__ENCAddToList(this);
		State = MouseState.None;
		_tbType = topButtonType.Blank;
		_defaultFunc = true;
		_closeFunc = closeFunc.CloseForm;
		((Control)this).set_BackColor(Color.FromArgb(38, 38, 38));
		((Control)this).set_Font(new Font("Verdana", 6.75f));
		Size size = new Size(17, 17);
		((Control)this).set_Size(size);
		((Control)this).set_DoubleBuffered(true);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected O, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected O, but got Unknown
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected O, but got Unknown
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected O, but got Unknown
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected O, but got Unknown
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected O, but got Unknown
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Expected O, but got Unknown
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Expected O, but got Unknown
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Expected O, but got Unknown
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected O, but got Unknown
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Expected O, but got Unknown
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Expected O, but got Unknown
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Expected O, but got Unknown
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Expected O, but got Unknown
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_039d: Expected O, but got Unknown
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Expected O, but got Unknown
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Expected O, but got Unknown
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cf: Expected O, but got Unknown
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Expected O, but got Unknown
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Expected O, but got Unknown
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Expected O, but got Unknown
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Expected O, but got Unknown
		//IL_0452: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Expected O, but got Unknown
		//IL_0457: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Expected O, but got Unknown
		Graphics graphics = e.get_Graphics();
		((Control)this).OnPaint(e);
		Size size = new Size(17, 17);
		((Control)this).set_Size(size);
		graphics.Clear(Color.FromArgb(36, 34, 30));
		checked
		{
			Rectangle rectangle;
			switch (State)
			{
			case MouseState.None:
			{
				graphics.DrawLine(new Pen((Brush)new SolidBrush(Color.FromArgb(36, 34, 30))), 2, ((Control)this).get_Height() - 1, ((Control)this).get_Width() - 4, ((Control)this).get_Height() - 1);
				rectangle = new Rectangle(1, 1, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 2);
				LinearGradientBrush val5 = new LinearGradientBrush(rectangle, Color.FromArgb(10, 9, 8), Color.FromArgb(31, 29, 26), 90f);
				rectangle = new Rectangle(1, 1, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 2);
				graphics.FillRectangle((Brush)(object)val5, rectangle);
				Pen val6 = new Pen((Brush)new SolidBrush(Color.FromArgb(46, 45, 44)));
				rectangle = new Rectangle(1, 1, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 4);
				graphics.DrawRectangle(val6, rectangle);
				buttonColor = Color.FromArgb(163, 163, 162);
				break;
			}
			case MouseState.Over:
			{
				graphics.DrawLine(new Pen((Brush)new SolidBrush(Color.FromArgb(46, 44, 38))), 2, ((Control)this).get_Height() - 1, ((Control)this).get_Width() - 4, ((Control)this).get_Height() - 1);
				rectangle = new Rectangle(1, 1, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 2);
				LinearGradientBrush val3 = new LinearGradientBrush(rectangle, Color.FromArgb(219, 78, 0), Color.FromArgb(230, 95, 0), 90f);
				rectangle = new Rectangle(1, 1, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 2);
				graphics.FillRectangle((Brush)(object)val3, rectangle);
				Pen val4 = new Pen((Brush)new SolidBrush(Color.FromArgb(245, 120, 10)));
				rectangle = new Rectangle(1, 1, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 4);
				graphics.DrawRectangle(val4, rectangle);
				buttonColor = Color.FromArgb(255, 255, 255);
				break;
			}
			case MouseState.Down:
			{
				graphics.DrawLine(new Pen((Brush)new SolidBrush(Color.FromArgb(36, 34, 30))), 2, ((Control)this).get_Height() - 1, ((Control)this).get_Width() - 4, ((Control)this).get_Height() - 1);
				rectangle = new Rectangle(1, 1, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 2);
				LinearGradientBrush val = new LinearGradientBrush(rectangle, Color.FromArgb(10, 9, 8), Color.FromArgb(31, 29, 26), 270f);
				rectangle = new Rectangle(1, 1, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 2);
				graphics.FillRectangle((Brush)(object)val, rectangle);
				Pen val2 = new Pen((Brush)new SolidBrush(Color.FromArgb(46, 45, 44)));
				rectangle = new Rectangle(1, 1, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 4);
				graphics.DrawRectangle(val2, rectangle);
				break;
			}
			}
			switch (ButtonType)
			{
			case topButtonType.Minimize:
			{
				SolidBrush val8 = new SolidBrush(buttonColor);
				rectangle = new Rectangle(4, 10, 9, 2);
				graphics.FillRectangle((Brush)val8, rectangle);
				break;
			}
			case topButtonType.Maximize:
			{
				Pen val7 = new Pen((Brush)new SolidBrush(buttonColor));
				rectangle = new Rectangle(4, 4, 8, 7);
				graphics.DrawRectangle(val7, rectangle);
				graphics.DrawLine(new Pen((Brush)new SolidBrush(buttonColor)), 4, 5, ((Control)this).get_Width() - 6, 5);
				break;
			}
			case topButtonType.Close:
				graphics.DrawLine(new Pen((Brush)new SolidBrush(buttonColor), 2f), 4, 4, 12, 11);
				graphics.DrawLine(new Pen((Brush)new SolidBrush(buttonColor), 2f), 12, 4, 4, 11);
				graphics.DrawLine(new Pen((Brush)new SolidBrush(buttonColor)), 4, 4, 5, 5);
				graphics.DrawLine(new Pen((Brush)new SolidBrush(buttonColor)), 4, 11, 5, 10);
				break;
			}
			rectangle = new Rectangle(1, 1, ((Control)this).get_Width() - 2, 7);
			LinearGradientBrush val9 = new LinearGradientBrush(rectangle, Color.FromArgb(80, Color.White), Color.FromArgb(50, Color.White), 90f);
			rectangle = new Rectangle(1, 1, ((Control)this).get_Width() - 2, 7);
			graphics.FillRectangle((Brush)(object)val9, rectangle);
			Pen val10 = new Pen((Brush)new SolidBrush(Color.FromArgb(21, 20, 18)));
			rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 2);
			graphics.DrawRectangle(val10, rectangle);
		}
	}
}
