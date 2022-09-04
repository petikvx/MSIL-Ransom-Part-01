using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Facebook_HACK_ANO;

public class ReactorTheme : ContainerControl
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	[AccessedThroughProperty("CloseBtn")]
	private ReactorTopButton _CloseBtn;

	[AccessedThroughProperty("MinimBtn")]
	private ReactorTopButton _MinimBtn;

	private Point MouseP;

	private bool Cap;

	private int MoveHeight;

	private virtual ReactorTopButton CloseBtn
	{
		[DebuggerNonUserCode]
		get
		{
			return _CloseBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CloseBtn = value;
		}
	}

	private virtual ReactorTopButton MinimBtn
	{
		[DebuggerNonUserCode]
		get
		{
			return _MinimBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_MinimBtn = value;
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

	protected override void OnPaintBackground(PaintEventArgs e)
	{
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		((Control)this).OnMouseDown(e);
		bool num = (int)e.get_Button() == 1048576;
		Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width(), MoveHeight);
		Rectangle rectangle2 = rectangle;
		if (num & rectangle2.Contains(e.get_Location()))
		{
			Cap = true;
			MouseP = e.get_Location();
		}
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		((Control)this).OnMouseUp(e);
		Cap = false;
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		((Control)this).OnMouseMove(e);
		if (Cap)
		{
			((Control)this).get_Parent().set_Location(Control.get_MousePosition() - (Size)MouseP);
		}
	}

	protected override void OnTextChanged(EventArgs e)
	{
		((Control)this).OnTextChanged(e);
		((Control)this).Invalidate();
	}

	public ReactorTheme()
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		__ENCAddToList(this);
		ReactorTopButton reactorTopButton = new ReactorTopButton();
		ReactorTopButton reactorTopButton2 = reactorTopButton;
		Point location = new Point(412, 7);
		((Control)reactorTopButton2).set_Location(location);
		reactorTopButton.ButtonType = ReactorTopButton.topButtonType.Close;
		reactorTopButton.CloseButtonFunction = ReactorTopButton.closeFunc.CloseForm;
		CloseBtn = reactorTopButton;
		reactorTopButton = new ReactorTopButton();
		ReactorTopButton reactorTopButton3 = reactorTopButton;
		location = new Point(393, 7);
		((Control)reactorTopButton3).set_Location(location);
		reactorTopButton.ButtonType = ReactorTopButton.topButtonType.Minimize;
		MinimBtn = reactorTopButton;
		ref Point mouseP = ref MouseP;
		mouseP = new Point(0, 0);
		Cap = false;
		((Control)this).set_Dock((DockStyle)5);
		MoveHeight = 45;
		((Control)this).set_Font(new Font("Verdana", 6.75f));
		((Control)this).set_DoubleBuffered(true);
		((Control)this).get_Controls().Add((Control)(object)CloseBtn);
		((Control)this).get_Controls().Add((Control)(object)MinimBtn);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected O, but got Unknown
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected O, but got Unknown
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected O, but got Unknown
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected O, but got Unknown
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected O, but got Unknown
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected O, but got Unknown
		Graphics graphics = e.get_Graphics();
		((Control)this).OnPaint(e);
		if ((int)((ContainerControl)this).get_ParentForm().get_FormBorderStyle() != 0)
		{
			((ContainerControl)this).get_ParentForm().set_FormBorderStyle((FormBorderStyle)0);
		}
		ReactorTopButton closeBtn = CloseBtn;
		checked
		{
			Point location = new Point(((Control)this).get_Width() - 23, 7);
			((Control)closeBtn).set_Location(location);
			ReactorTopButton minimBtn = MinimBtn;
			location = new Point(((Control)this).get_Width() - 42, 7);
			((Control)minimBtn).set_Location(location);
			Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width(), 15);
			LinearGradientBrush val = new LinearGradientBrush(rectangle, Color.FromArgb(102, 97, 93), Color.FromArgb(55, 54, 52), 90f);
			rectangle = new Rectangle(0, 15, ((Control)this).get_Width(), 15);
			LinearGradientBrush val2 = new LinearGradientBrush(rectangle, Color.Black, Color.FromArgb(26, 25, 21), 90f);
			rectangle = new Rectangle(5, 31, ((Control)this).get_Width() - 11, 20);
			LinearGradientBrush val3 = new LinearGradientBrush(rectangle, Color.FromArgb(23, 23, 22), Color.FromArgb(38, 38, 38), 90f);
			graphics.Clear(Color.FromArgb(26, 25, 21));
			rectangle = new Rectangle(0, 0, ((Control)this).get_Width(), 15);
			graphics.FillRectangle((Brush)(object)val, rectangle);
			rectangle = new Rectangle(0, 15, ((Control)this).get_Width(), 15);
			graphics.FillRectangle((Brush)(object)val2, rectangle);
			graphics.DrawRectangle(new Pen((Brush)new SolidBrush(Color.FromArgb(42, 41, 37))), 4, 30, ((Control)this).get_Width() - 9, ((Control)this).get_Height() - 36);
			SolidBrush val4 = new SolidBrush(Color.FromArgb(38, 38, 38));
			rectangle = new Rectangle(5, 31, ((Control)this).get_Width() - 11, ((Control)this).get_Height() - 38);
			graphics.FillRectangle((Brush)val4, rectangle);
			rectangle = new Rectangle(5, 31, ((Control)this).get_Width() - 11, 20);
			graphics.FillRectangle((Brush)(object)val3, rectangle);
			graphics.DrawLine(new Pen((Brush)new SolidBrush(Color.FromArgb(24, 24, 24))), 5, 32, ((Control)this).get_Width() - 7, 32);
			Pen black = Pens.get_Black();
			rectangle = new Rectangle(5, 31, ((Control)this).get_Width() - 11, ((Control)this).get_Height() - 38);
			graphics.DrawRectangle(black, rectangle);
			graphics.DrawLine(new Pen((Brush)new SolidBrush(Color.FromArgb(151, 150, 146))), 1, 1, ((Control)this).get_Width() - 2, 1);
			Pen black2 = Pens.get_Black();
			rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			graphics.DrawRectangle(black2, rectangle);
			string text = ((Control)this).get_Text();
			Font font = ((Control)this).get_Font();
			Brush black3 = Brushes.get_Black();
			rectangle = new Rectangle(0, 10, ((Control)this).get_Width() - 1, 10);
			RectangleF rectangleF = rectangle;
			StringFormat val5 = new StringFormat();
			val5.set_LineAlignment((StringAlignment)1);
			val5.set_Alignment((StringAlignment)1);
			graphics.DrawString(text, font, black3, rectangleF, val5);
			string text2 = ((Control)this).get_Text();
			Font font2 = ((Control)this).get_Font();
			Brush white = Brushes.get_White();
			rectangle = new Rectangle(0, 11, ((Control)this).get_Width() - 1, 11);
			RectangleF rectangleF2 = rectangle;
			val5 = new StringFormat();
			val5.set_LineAlignment((StringAlignment)1);
			val5.set_Alignment((StringAlignment)1);
			graphics.DrawString(text2, font2, white, rectangleF2, val5);
		}
	}
}
