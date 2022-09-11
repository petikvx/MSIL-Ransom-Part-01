using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ForMe;
using ns0;

namespace ns1;

public abstract class MintForm : Form
{
	private Class1 class1_0;

	private bool bool_0;

	private bool bool_1;

	private FormButton formButton_0;

	private bool bool_2;

	private bool bool_3;

	internal bool bool_4;

	internal Icon icon_0;

	protected Icon CaptionIcon => icon_0;

	public Icon Icon
	{
		get
		{
			return ((Form)this).get_Icon();
		}
		set
		{
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			((Form)this).set_Icon(value);
			Icon val = (icon_0 = new Icon(((Form)this).get_Icon(), SystemInformation.get_SmallIconSize()));
		}
	}

	protected bool ModernFrame
	{
		get
		{
			return bool_2;
		}
		set
		{
			bool_2 = value;
			method_5();
		}
	}

	protected MintForm()
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		((Control)this).set_ResizeRedraw(false);
		class1_0 = new Class1((Form)(object)this, (Delegate0)vmethod_1);
		Icon val = (icon_0 = new Icon(((Form)this).get_Icon(), SystemInformation.get_SmallIconSize()));
	}

	private void method_0()
	{
		bool_0 = false;
		formButton_0 = FormButton.const_0;
	}

	private bool method_1(Point point_0)
	{
		if (!class1_0.Rectangle_2.Contains(point_0) && !class1_0.Rectangle_4.Contains(point_0))
		{
			return class1_0.Rectangle_5.Contains(point_0);
		}
		return true;
	}

	private void method_2()
	{
		Rectangle rectangle_ = class1_0.Rectangle_0;
		checked
		{
			if (bool_2)
			{
				rectangle_.Y -= class1_0.Int32_0;
				rectangle_.X -= class1_0.Int32_0;
				rectangle_.Width += class1_0.Int32_0 * 2;
				rectangle_.Height += class1_0.Int32_0;
			}
			IntPtr windowDC = Class5.GetWindowDC(((Control)this).get_Handle());
			BufferedGraphics obj = BufferedGraphicsManager.get_Current().Allocate(windowDC, rectangle_);
			Graphics graphics = obj.get_Graphics();
			MouseState mouseState_ = method_6();
			MouseState mouseState_2 = method_7();
			MouseState mouseState_3 = method_8();
			graphics.SetClip(rectangle_);
			FormPaintCaptionEventArgs formPaintCaptionEventArgs_ = new FormPaintCaptionEventArgs(graphics, mouseState_, mouseState_2, mouseState_3, class1_0.Boolean_1, class1_0.Boolean_0, class1_0.Boolean_2, class1_0.Int32_0, rectangle_, class1_0.Rectangle_2, class1_0.Rectangle_4, class1_0.Rectangle_5, class1_0.Rectangle_3, class1_0.Rectangle_6);
			vmethod_4(formPaintCaptionEventArgs_);
			obj.Render();
			obj.Dispose();
		}
	}

	internal static void smethod_0()
	{
		Program.Main();
	}

	private void method_3()
	{
		checked
		{
			if (bool_3)
			{
				Graphics val = Graphics.FromHdc(Class5.GetWindowDC(((Control)this).get_Handle()));
				Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
				Rectangle rectangle2 = rectangle;
				rectangle2.Inflate(-class1_0.Int32_0, -class1_0.Int32_0);
				val.ExcludeClip(rectangle2);
				if (bool_2)
				{
					int width = ((Control)this).get_Width();
					Rectangle rectangle3 = new Rectangle(0, 0, width, class1_0.Rectangle_0.Bottom);
					val.ExcludeClip(rectangle3);
				}
				FormPaintFrameEventArgs formPaintFrameEventArgs_ = new FormPaintFrameEventArgs(val, rectangle, rectangle2, class1_0.Int32_0);
				vmethod_5(formPaintFrameEventArgs_);
				val.Dispose();
				return;
			}
			Rectangle rectangle_ = new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
			rectangle_.Inflate(-class1_0.Int32_0, -class1_0.Int32_0);
			Rectangle rectangle_2 = new Rectangle(0, 0, ((Control)this).get_Width(), class1_0.Int32_0);
			Rectangle rectangle_3 = new Rectangle(0, ((Control)this).get_Height() - class1_0.Int32_0, ((Control)this).get_Width(), class1_0.Int32_0);
			Rectangle rectangle_4 = new Rectangle(0, rectangle_2.Bottom, class1_0.Int32_0, ((Control)this).get_Height() - class1_0.Int32_0 - class1_0.Int32_0);
			Rectangle rectangle_5 = new Rectangle(((Control)this).get_Width() - class1_0.Int32_0, rectangle_2.Bottom, class1_0.Int32_0, ((Control)this).get_Height() - class1_0.Int32_0 - class1_0.Int32_0);
			if (!bool_2)
			{
				method_4(rectangle_2, rectangle_);
			}
			else
			{
				int y = rectangle_3.Y;
				rectangle_4.Height = y - class1_0.Rectangle_0.Bottom;
				rectangle_4.Y = class1_0.Rectangle_0.Bottom;
				rectangle_5.Height = rectangle_4.Height;
				rectangle_5.Y = rectangle_4.Y;
			}
			method_4(rectangle_3, rectangle_);
			method_4(rectangle_4, rectangle_);
			method_4(rectangle_5, rectangle_);
		}
	}

	private void method_4(Rectangle rectangle_0, Rectangle rectangle_1)
	{
		IntPtr windowDC = Class5.GetWindowDC(((Control)this).get_Handle());
		BufferedGraphics obj = BufferedGraphicsManager.get_Current().Allocate(windowDC, rectangle_0);
		Graphics graphics = obj.get_Graphics();
		graphics.SetClip(rectangle_0);
		FormPaintFrameEventArgs formPaintFrameEventArgs_ = new FormPaintFrameEventArgs(graphics, rectangle_0, rectangle_1, class1_0.Int32_0);
		vmethod_5(formPaintFrameEventArgs_);
		obj.Render();
		obj.Dispose();
	}

	private void method_5()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (bool_4 && (int)((Form)this).get_FormBorderStyle() != 0)
		{
			class1_0.method_2();
			method_3();
			method_2();
		}
	}

	private MouseState method_6()
	{
		if (formButton_0 != FormButton.const_1)
		{
			return MouseState.const_0;
		}
		return (!bool_0) ? MouseState.const_1 : MouseState.const_2;
	}

	private MouseState method_7()
	{
		if (formButton_0 != FormButton.const_2)
		{
			return MouseState.const_0;
		}
		return (!bool_0) ? MouseState.const_1 : MouseState.const_2;
	}

	private MouseState method_8()
	{
		if (formButton_0 != FormButton.const_3)
		{
			return MouseState.const_0;
		}
		return (!bool_0) ? MouseState.const_1 : MouseState.const_2;
	}

	protected override void vmethod_0(EventArgs eventArgs_0)
	{
		((Form)this).OnHandleCreated(eventArgs_0);
		if (LicenseManager.UsageMode == LicenseUsageMode.Runtime)
		{
			bool_4 = true;
			Class5.SetWindowTheme(((Control)this).get_Handle(), null, string.Empty);
		}
	}

	public virtual void vmethod_1(FormLayoutCaptionEventArgs formLayoutCaptionEventArgs_0)
	{
	}

	protected override void vmethod_2(EventArgs eventArgs_0)
	{
		((Control)this).OnMove(eventArgs_0);
		method_11();
	}

	protected override void vmethod_3(PaintEventArgs paintEventArgs_0)
	{
		paintEventArgs_0.get_Graphics().Clear(((Control)this).get_BackColor());
	}

	public abstract void vmethod_4(FormPaintCaptionEventArgs formPaintCaptionEventArgs_0);

	public abstract void vmethod_5(FormPaintFrameEventArgs formPaintFrameEventArgs_0);

	protected override void vmethod_6(EventArgs eventArgs_0)
	{
		((Form)this).OnResizeBegin(eventArgs_0);
		bool_3 = true;
		method_5();
	}

	protected override void vmethod_7(EventArgs eventArgs_0)
	{
		((Form)this).OnResizeEnd(eventArgs_0);
		bool_3 = false;
		method_5();
	}

	protected override void vmethod_8(EventArgs eventArgs_0)
	{
		((Control)this).OnSizeChanged(eventArgs_0);
		method_5();
	}

	private Point method_9(IntPtr intptr_0)
	{
		int num = intptr_0.ToInt32();
		Point result = new Point(num << 16 >> 16, num >> 16);
		checked
		{
			result.Offset(-((Control)this).get_Left(), -((Control)this).get_Top());
			return result;
		}
	}

	private void method_10()
	{
		Class5.Struct2 struct2_ = default(Class5.Struct2);
		if (!bool_1)
		{
			struct2_.int_0 = Marshal.SizeOf(typeof(Class5.Struct2));
			struct2_.intptr_0 = ((Control)this).get_Handle();
			struct2_.int_1 = 18;
			bool_1 = Class5.TrackMouseEvent(ref struct2_);
		}
	}

	private void method_11()
	{
		Rectangle rectangle = default(Rectangle);
		Rectangle rectangle2 = new Rectangle(1, 1, 0, 0);
		rectangle2.Size = Screen.GetWorkingArea((Control)(object)this).Size;
		checked
		{
			rectangle2.Width = rectangle.Width - 1;
			rectangle2.Height = rectangle.Height - 1;
			rectangle = rectangle2;
			((Form)this).set_MaximizedBounds(rectangle);
		}
	}

	private void method_12(bool bool_5)
	{
		if (bool_0 != bool_5)
		{
			bool_0 = bool_5;
			method_5();
		}
	}

	private void method_13(FormButton formButton_1)
	{
		if (formButton_0 != formButton_1)
		{
			formButton_0 = formButton_1;
			method_5();
		}
	}

	protected override void vmethod_9(ref Message message_0)
	{
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		if (bool_4)
		{
			if (((Message)(ref message_0)).get_Msg() == 133 || ((Message)(ref message_0)).get_Msg() == 174 || ((Message)(ref message_0)).get_Msg() == 175)
			{
				method_5();
				return;
			}
			if (((Message)(ref message_0)).get_Msg() == 6)
			{
				((Form)this).WndProc(ref message_0);
				method_5();
				return;
			}
			if (((Message)(ref message_0)).get_Msg() != 674 && ((Message)(ref message_0)).get_Msg() != 675)
			{
				if (((Message)(ref message_0)).get_Msg() == 160)
				{
					method_10();
				}
				else if (((Message)(ref message_0)).get_Msg() == 161 && ((Form)this).get_ControlBox())
				{
					Point point_ = method_9(((Message)(ref message_0)).get_LParam());
					method_12(method_1(point_));
				}
				else if (((Message)(ref message_0)).get_Msg() == 162 && ((Form)this).get_ControlBox())
				{
					method_0();
					Point pt = method_9(((Message)(ref message_0)).get_LParam());
					if (class1_0.Rectangle_2.Contains(pt))
					{
						((Form)this).Close();
					}
					else if (class1_0.Rectangle_4.Contains(pt))
					{
						if (((Form)this).get_MaximizeBox())
						{
							if ((int)((Form)this).get_WindowState() != 0)
							{
								((Form)this).set_WindowState((FormWindowState)0);
							}
							else
							{
								((Form)this).set_WindowState((FormWindowState)2);
							}
						}
					}
					else if (class1_0.Rectangle_5.Contains(pt) && ((Form)this).get_MinimizeBox())
					{
						((Form)this).set_WindowState((FormWindowState)1);
					}
				}
				else
				{
					if (((Message)(ref message_0)).get_Msg() != 163 || !((Form)this).get_ControlBox() || !((Form)this).get_ShowIcon())
					{
						if (((Message)(ref message_0)).get_Msg() != 132)
						{
							((Form)this).WndProc(ref message_0);
							return;
						}
						if (((Form)this).get_ControlBox())
						{
							Point pt2 = method_9(((Message)(ref message_0)).get_LParam());
							bool flag = true;
							if (class1_0.Rectangle_2.Contains(pt2))
							{
								method_13(FormButton.const_1);
							}
							else if (class1_0.Rectangle_4.Contains(pt2))
							{
								method_13(FormButton.const_2);
							}
							else if (!class1_0.Rectangle_5.Contains(pt2))
							{
								method_13(FormButton.const_0);
								flag = false;
							}
							else
							{
								method_13(FormButton.const_3);
							}
							if (flag)
							{
								((Message)(ref message_0)).set_Result(new IntPtr(5));
								return;
							}
						}
						((Form)this).WndProc(ref message_0);
						int num = ((Message)(ref message_0)).get_Result().ToInt32();
						if (num == 3 || num == 8 || num == 9 || num == 20)
						{
							((Message)(ref message_0)).set_Result(new IntPtr(2));
						}
						return;
					}
					Point pt3 = method_9(((Message)(ref message_0)).get_LParam());
					if (class1_0.Rectangle_3.Contains(pt3))
					{
						((Form)this).Close();
					}
				}
			}
			else
			{
				bool_1 = false;
				method_0();
				method_5();
			}
		}
		((Form)this).WndProc(ref message_0);
	}

	private void method_14()
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(MintForm));
		((Control)this).SuspendLayout();
		((Form)this).set_ClientSize(new Size(315, 75));
		Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Control)this).set_Name("MintForm");
		((Control)this).ResumeLayout(false);
	}
}
