using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace nO_bUILDER;

public class InfluenceTheme : ContainerControl
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private Point MouseP;

	private bool Cap;

	private int MoveHeight;

	private int pos;

	private bool _closesEnv;

	private bool _minimBool;

	[AccessedThroughProperty("minimBtn")]
	private InfluenceTopButton _minimBtn;

	[AccessedThroughProperty("closeBtn")]
	private InfluenceTopButton _closeBtn;

	public bool CloseButtonExitsApp
	{
		get
		{
			return _closesEnv;
		}
		set
		{
			_closesEnv = value;
			((Control)this).Invalidate();
		}
	}

	public bool MinimizeButton
	{
		get
		{
			return _minimBool;
		}
		set
		{
			_minimBool = value;
			((Control)this).Invalidate();
		}
	}

	private virtual InfluenceTopButton minimBtn
	{
		[DebuggerNonUserCode]
		get
		{
			return _minimBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = delegate
			{
				minimBtnClick();
			};
			if (_minimBtn != null)
			{
				((Control)_minimBtn).remove_Click(eventHandler);
			}
			_minimBtn = value;
			if (_minimBtn != null)
			{
				((Control)_minimBtn).add_Click(eventHandler);
			}
		}
	}

	private virtual InfluenceTopButton closeBtn
	{
		[DebuggerNonUserCode]
		get
		{
			return _closeBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = delegate
			{
				closeBtnClick();
			};
			if (_closeBtn != null)
			{
				((Control)_closeBtn).remove_Click(eventHandler);
			}
			_closeBtn = value;
			if (_closeBtn != null)
			{
				((Control)_closeBtn).add_Click(eventHandler);
			}
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

	protected override void OnInvalidated(InvalidateEventArgs e)
	{
		((Control)this).OnInvalidated(e);
		((Control)((ContainerControl)this).get_ParentForm()).FindForm().set_Text(((Control)this).get_Text());
	}

	protected override void OnPaintBackground(PaintEventArgs e)
	{
	}

	protected override void OnTextChanged(EventArgs e)
	{
		((Control)this).OnTextChanged(e);
		((Control)this).Invalidate();
	}

	protected override void OnCreateControl()
	{
		((ContainerControl)this).OnCreateControl();
		((ContainerControl)this).get_ParentForm().set_FormBorderStyle((FormBorderStyle)0);
	}

	protected override void CreateHandle()
	{
		((Control)this).CreateHandle();
	}

	public InfluenceTheme()
	{
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		__ENCAddToList(this);
		ref Point mouseP = ref MouseP;
		mouseP = new Point(0, 0);
		Cap = false;
		pos = 0;
		_closesEnv = false;
		InfluenceTopButton influenceTopButton = new InfluenceTopButton
		{
			ButtonIcon = InfluenceTopButton.ButtonType.Minim
		};
		InfluenceTopButton influenceTopButton2 = influenceTopButton;
		checked
		{
			Point location = new Point(((Control)this).get_Width() - 81, 0);
			((Control)influenceTopButton2).set_Location(location);
			minimBtn = influenceTopButton;
			influenceTopButton = new InfluenceTopButton
			{
				ButtonIcon = InfluenceTopButton.ButtonType.Close
			};
			InfluenceTopButton influenceTopButton3 = influenceTopButton;
			location = new Point(((Control)this).get_Width() - 52, 0);
			((Control)influenceTopButton3).set_Location(location);
			closeBtn = influenceTopButton;
			((Control)this).set_Dock((DockStyle)5);
			MoveHeight = 25;
			((Control)this).set_Font(new Font("Verdana", 8.25f));
			((Control)this).set_DoubleBuffered(true);
			((Control)this).get_Controls().Add((Control)(object)closeBtn);
			((Control)closeBtn).Refresh();
			((Control)minimBtn).Refresh();
		}
	}

	private void minimBtnClick()
	{
		((Control)((ContainerControl)this).get_ParentForm()).FindForm().set_WindowState((FormWindowState)1);
	}

	private void closeBtnClick()
	{
		if (CloseButtonExitsApp)
		{
			Environment.Exit(0);
		}
		else
		{
			((Control)((ContainerControl)this).get_ParentForm()).FindForm().Close();
		}
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected O, but got Unknown
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected O, but got Unknown
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected O, but got Unknown
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected O, but got Unknown
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		if (_minimBool)
		{
			((Control)this).get_Controls().Add((Control)(object)minimBtn);
		}
		else
		{
			((Control)this).get_Controls().Remove((Control)(object)minimBtn);
		}
		InfluenceTopButton influenceTopButton = minimBtn;
		checked
		{
			Point location = new Point(((Control)this).get_Width() - 81, 0);
			((Control)influenceTopButton).set_Location(location);
			InfluenceTopButton influenceTopButton2 = closeBtn;
			location = new Point(((Control)this).get_Width() - 52, 0);
			((Control)influenceTopButton2).set_Location(location);
			val2.set_SmoothingMode((SmoothingMode)1);
			Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			Color transparencyKey = ((ContainerControl)this).get_ParentForm().get_TransparencyKey();
			Draw draw = new Draw();
			((Control)this).OnPaint(e);
			val2.Clear(transparencyKey);
			val2.FillPath((Brush)new SolidBrush(Color.FromArgb(20, 20, 20)), draw.RoundRect(rectangle, 2));
			HatchBrush val3 = new HatchBrush((HatchStyle)21, Color.FromArgb(100, 31, 31, 31), Color.FromArgb(100, 36, 36, 36));
			Rectangle rectangle2 = new Rectangle(0, 2, ((Control)this).get_Width() - 1, 25);
			LinearGradientBrush val4 = new LinearGradientBrush(rectangle2, Color.FromArgb(40, 40, 40), Color.FromArgb(29, 29, 29), 90f);
			rectangle2 = new Rectangle(0, 2, ((Control)this).get_Width() - 1, 25);
			val2.FillPath((Brush)(object)val4, draw.RoundRect(rectangle2, 2));
			rectangle2 = new Rectangle(0, 2, ((Control)this).get_Width() - 1, 25);
			val2.FillPath((Brush)(object)val3, draw.RoundRect(rectangle2, 2));
			LinearGradientBrush val5 = new LinearGradientBrush(val4.get_Rectangle(), Color.FromArgb(15, Color.White), Color.FromArgb(0, Color.White), 90f);
			rectangle2 = new Rectangle(1, 1, ((Control)this).get_Width() - 1, 13);
			val2.FillRectangle((Brush)(object)val5, rectangle2);
			val2.DrawLine(new Pen(Color.FromArgb(75, Color.White)), 1, 1, ((Control)this).get_Width() - 1, 1);
			val2.DrawLine(new Pen(Color.FromArgb(18, 18, 18)), 1, 26, ((Control)this).get_Width() - 1, 26);
			Pen val6 = new Pen(Color.FromArgb(37, 37, 37));
			rectangle2 = new Rectangle(1, 27, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 29);
			val2.DrawRectangle(val6, rectangle2);
			val2.DrawPath(Pens.get_Black(), draw.RoundRect(rectangle, 2));
			string text = ((Control)this).get_Text();
			Font font = ((Control)this).get_Font();
			Brush black = Brushes.get_Black();
			rectangle2 = new Rectangle(8, 8, ((Control)this).get_Width() - 1, 10);
			RectangleF rectangleF = rectangle2;
			StringFormat val7 = new StringFormat();
			val7.set_LineAlignment((StringAlignment)1);
			val7.set_Alignment((StringAlignment)0);
			val2.DrawString(text, font, black, rectangleF, val7);
			string text2 = ((Control)this).get_Text();
			Font font2 = ((Control)this).get_Font();
			Brush white = Brushes.get_White();
			rectangle2 = new Rectangle(8, 9, ((Control)this).get_Width() - 1, 11);
			RectangleF rectangleF2 = rectangle2;
			val7 = new StringFormat();
			val7.set_LineAlignment((StringAlignment)1);
			val7.set_Alignment((StringAlignment)0);
			val2.DrawString(text2, font2, white, rectangleF2, val7);
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
