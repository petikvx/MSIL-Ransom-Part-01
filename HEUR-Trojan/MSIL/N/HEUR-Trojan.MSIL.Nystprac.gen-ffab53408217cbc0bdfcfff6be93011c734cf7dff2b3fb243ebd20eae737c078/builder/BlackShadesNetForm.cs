using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace builder;

public class BlackShadesNetForm : ContainerControl
{
	private static List<WeakReference> jvRedGscla;

	private Point point_0;

	private bool bool_0;

	private int int_0;

	private int int_1;

	private bool bool_1;

	private bool bool_2;

	[AccessedThroughProperty("minimBtn")]
	private BlackShadesNetTopButton blackShadesNetTopButton_0;

	[AccessedThroughProperty("closeBtn")]
	private BlackShadesNetTopButton blackShadesNetTopButton_1;

	public bool CloseButtonExitsApp
	{
		get
		{
			return bool_1;
		}
		set
		{
			bool_1 = value;
			((Control)this).Invalidate();
		}
	}

	public bool MinimizeButton
	{
		get
		{
			return bool_2;
		}
		set
		{
			bool_2 = value;
			((Control)this).Invalidate();
		}
	}

	[DebuggerNonUserCode]
	static BlackShadesNetForm()
	{
		Class14.hYiyYvszsKHjE();
		jvRedGscla = new List<WeakReference>();
	}

	[DebuggerNonUserCode]
	private static void hdgejffnLy(object object_0)
	{
		checked
		{
			lock (jvRedGscla)
			{
				if (jvRedGscla.Count == jvRedGscla.Capacity)
				{
					int num = 0;
					int num2 = jvRedGscla.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = jvRedGscla[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								jvRedGscla[num] = jvRedGscla[num3];
							}
							num++;
						}
						num3++;
					}
					jvRedGscla.RemoveRange(num, jvRedGscla.Count - num);
					jvRedGscla.Capacity = jvRedGscla.Count;
				}
				jvRedGscla.Add(new WeakReference(RuntimeHelpers.GetObjectValue(object_0)));
			}
		}
	}

	private void method_0()
	{
		((Control)((ContainerControl)this).get_ParentForm()).FindForm().set_WindowState((FormWindowState)1);
	}

	private void method_1()
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

	protected override void OnMouseDown(MouseEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		((Control)this).OnMouseDown(e);
		bool num = (int)e.get_Button() == 1048576;
		Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width(), int_0);
		Rectangle rectangle2 = rectangle;
		if (num & rectangle2.Contains(e.get_Location()))
		{
			bool_0 = true;
			point_0 = e.get_Location();
		}
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		((Control)this).OnMouseUp(e);
		bool_0 = false;
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		((Control)this).OnMouseMove(e);
		if (bool_0)
		{
			((Control)this).get_Parent().set_Location(Control.get_MousePosition() - (Size)point_0);
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
		((ContainerControl)this).get_ParentForm().set_TransparencyKey(Color.Fuchsia);
	}

	protected override void CreateHandle()
	{
		((Control)this).CreateHandle();
	}

	[SpecialName]
	[DebuggerNonUserCode]
	private virtual BlackShadesNetTopButton vmethod_0()
	{
		return blackShadesNetTopButton_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	private virtual void vmethod_1(BlackShadesNetTopButton WithEventsValue)
	{
		EventHandler eventHandler = delegate
		{
			method_0();
		};
		if (blackShadesNetTopButton_0 != null)
		{
			((Control)blackShadesNetTopButton_0).remove_Click(eventHandler);
		}
		blackShadesNetTopButton_0 = WithEventsValue;
		if (blackShadesNetTopButton_0 != null)
		{
			((Control)blackShadesNetTopButton_0).add_Click(eventHandler);
		}
	}

	[SpecialName]
	[DebuggerNonUserCode]
	private virtual BlackShadesNetTopButton vmethod_2()
	{
		return blackShadesNetTopButton_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	private virtual void vmethod_3(BlackShadesNetTopButton WithEventsValue)
	{
		EventHandler eventHandler = delegate
		{
			method_1();
		};
		if (blackShadesNetTopButton_1 != null)
		{
			((Control)blackShadesNetTopButton_1).remove_Click(eventHandler);
		}
		blackShadesNetTopButton_1 = WithEventsValue;
		if (blackShadesNetTopButton_1 != null)
		{
			((Control)blackShadesNetTopButton_1).add_Click(eventHandler);
		}
	}

	public BlackShadesNetForm()
	{
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		Class14.hYiyYvszsKHjE();
		((ContainerControl)this)._002Ector();
		hdgejffnLy(this);
		ref Point reference = ref point_0;
		reference = new Point(0, 0);
		bool_0 = false;
		int_1 = 0;
		bool_1 = false;
		bool_2 = true;
		BlackShadesNetTopButton blackShadesNetTopButton = new BlackShadesNetTopButton();
		BlackShadesNetTopButton blackShadesNetTopButton2 = blackShadesNetTopButton;
		checked
		{
			Point location = new Point(((Control)this).get_Width() - 44, 7);
			((Control)blackShadesNetTopButton2).set_Location(location);
			vmethod_1(blackShadesNetTopButton);
			blackShadesNetTopButton = new BlackShadesNetTopButton();
			BlackShadesNetTopButton blackShadesNetTopButton3 = blackShadesNetTopButton;
			location = new Point(((Control)this).get_Width() - 27, 7);
			((Control)blackShadesNetTopButton3).set_Location(location);
			vmethod_3(blackShadesNetTopButton);
			((Control)this).set_Dock((DockStyle)5);
			int_0 = 25;
			((Control)this).set_Font(new Font("Trebuchet MS", 8.25f, (FontStyle)1));
			((Control)this).set_ForeColor(Color.FromArgb(142, 152, 156));
			((Control)this).set_DoubleBuffered(true);
			((Control)this).get_Controls().Add((Control)(object)vmethod_2());
			((Control)vmethod_2()).Refresh();
			((Control)vmethod_0()).Refresh();
		}
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected O, but got Unknown
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected O, but got Unknown
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected O, but got Unknown
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected O, but got Unknown
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Expected O, but got Unknown
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Expected O, but got Unknown
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Expected O, but got Unknown
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Expected O, but got Unknown
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Expected O, but got Unknown
		//IL_0444: Unknown result type (might be due to invalid IL or missing references)
		//IL_044b: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		if (bool_2)
		{
			((Control)this).get_Controls().Add((Control)(object)vmethod_0());
		}
		else
		{
			((Control)this).get_Controls().Remove((Control)(object)vmethod_0());
		}
		BlackShadesNetTopButton blackShadesNetTopButton = vmethod_0();
		checked
		{
			Point location = new Point(((Control)this).get_Width() - 44, 7);
			((Control)blackShadesNetTopButton).set_Location(location);
			BlackShadesNetTopButton blackShadesNetTopButton2 = vmethod_2();
			location = new Point(((Control)this).get_Width() - 27, 7);
			((Control)blackShadesNetTopButton2).set_Location(location);
			val2.set_SmoothingMode((SmoothingMode)0);
			Rectangle rectangle_ = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			Color transparencyKey = ((ContainerControl)this).get_ParentForm().get_TransparencyKey();
			Class10 @class = new Class10();
			((Control)this).OnPaint(e);
			val2.Clear(transparencyKey);
			val2.FillPath((Brush)new SolidBrush(Color.FromArgb(42, 47, 49)), @class.method_0(rectangle_, 7));
			Rectangle rectangle = new Rectangle(1, 1, (int)Math.Round((double)((Control)this).get_Width() / 2.0 - 1.0), ((Control)this).get_Height() - 3);
			LinearGradientBrush val3 = new LinearGradientBrush(rectangle, Color.FromArgb(102, 108, 112), Color.FromArgb(204, 216, 224), 0f);
			rectangle = new Rectangle(1, 1, (int)Math.Round((double)((Control)this).get_Width() / 2.0 - 1.0), ((Control)this).get_Height() - 3);
			LinearGradientBrush val4 = new LinearGradientBrush(rectangle, Color.FromArgb(204, 216, 224), Color.FromArgb(102, 108, 112), 0f);
			Pen val5 = new Pen((Brush)(object)val3);
			rectangle = new Rectangle(1, 1, (int)Math.Round((double)((Control)this).get_Width() / 2.0 + 3.0), ((Control)this).get_Height() - 3);
			val2.DrawPath(val5, @class.method_0(rectangle, 7));
			Pen val6 = new Pen((Brush)(object)val4);
			rectangle = new Rectangle((int)Math.Round((double)((Control)this).get_Width() / 2.0 - 5.0), 1, (int)Math.Round((double)((Control)this).get_Width() / 2.0 + 3.0), ((Control)this).get_Height() - 3);
			val2.DrawPath(val6, @class.method_0(rectangle, 7));
			SolidBrush val7 = new SolidBrush(Color.FromArgb(42, 47, 49));
			rectangle = new Rectangle(2, 2, ((Control)this).get_Width() - 5, ((Control)this).get_Height() - 5);
			val2.FillPath((Brush)val7, @class.method_0(rectangle, 7));
			rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, 25);
			LinearGradientBrush val8 = new LinearGradientBrush(rectangle, Color.FromArgb(42, 46, 48), Color.FromArgb(93, 98, 101), 0f);
			rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, 25);
			LinearGradientBrush val9 = new LinearGradientBrush(rectangle, Color.FromArgb(93, 98, 101), Color.FromArgb(42, 46, 48), 0f);
			rectangle = new Rectangle(2, 2, (int)Math.Round((double)((Control)this).get_Width() / 2.0 + 2.0), 25);
			val2.FillPath((Brush)(object)val8, @class.method_0(rectangle, 7));
			rectangle = new Rectangle((int)Math.Round((double)((Control)this).get_Width() / 2.0 - 3.0), 2, (int)Math.Round((double)((Control)this).get_Width() / 2.0 - 1.0), 25);
			val2.FillPath((Brush)(object)val9, @class.method_0(rectangle, 7));
			SolidBrush val10 = new SolidBrush(Color.FromArgb(42, 47, 49));
			rectangle = new Rectangle(2, 23, ((Control)this).get_Width() - 5, 10);
			val2.FillRectangle((Brush)val10, rectangle);
			Pen val11 = new Pen(Color.FromArgb(42, 46, 48));
			rectangle = new Rectangle(2, 2, ((Control)this).get_Width() - 5, ((Control)this).get_Height() - 5);
			val2.DrawPath(val11, @class.method_0(rectangle, 7));
			val2.DrawPath(new Pen(Color.FromArgb(9, 11, 12)), @class.method_0(rectangle_, 7));
			string text = ((Control)this).get_Text();
			Font font = ((Control)this).get_Font();
			Brush white = Brushes.get_White();
			rectangle = new Rectangle(7, 5, ((Control)this).get_Width() - 1, 22);
			RectangleF rectangleF = rectangle;
			StringFormat val12 = new StringFormat();
			val12.set_Alignment((StringAlignment)0);
			val12.set_LineAlignment((StringAlignment)0);
			val2.DrawString(text, font, white, rectangleF, val12);
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
