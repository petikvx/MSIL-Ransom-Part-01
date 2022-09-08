using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

internal abstract class Control0 : ContainerControl
{
	protected Graphics graphics_0;

	protected Bitmap bitmap_0;

	private bool bool_0;

	private bool bool_1;

	private Rectangle rectangle_0;

	protected Enum0 enum0_0;

	private bool bool_2;

	private Point point_0;

	private bool bool_3;

	private bool bool_4;

	private bool bool_5;

	private bool bool_6;

	private int int_0;

	private int int_1;

	private Message[] message_0;

	private bool bool_7;

	private bool bool_8;

	private bool bool_9;

	private bool bool_10;

	private Color color_0;

	private FormBorderStyle formBorderStyle_0;

	private FormStartPosition formStartPosition_0;

	private bool bool_11;

	private Image image_0;

	private Dictionary<string, Color> dictionary_0;

	private string string_0;

	private bool bool_12;

	private Size size_0;

	private bool bool_13;

	private int int_2;

	private int int_3;

	private int int_4;

	private bool bool_14;

	private bool bool_15;

	private Rectangle rectangle_1;

	private Size size_1;

	private Point point_1;

	private Point point_2;

	private Bitmap bitmap_1;

	private Graphics graphics_1;

	private SolidBrush solidBrush_0;

	private SolidBrush solidBrush_1;

	private Point point_3;

	private Size size_2;

	private Point point_4;

	private LinearGradientBrush ofYincMjJU;

	private Rectangle XfTioibyUt;

	private GraphicsPath graphicsPath_0;

	private PathGradientBrush pathGradientBrush_0;

	private LinearGradientBrush linearGradientBrush_0;

	private Rectangle rectangle_2;

	private GraphicsPath graphicsPath_1;

	private Rectangle rectangle_3;

	public override DockStyle Dock
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return ((Control)this).get_Dock();
		}
		set
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			if (bool_14)
			{
				((Control)this).set_Dock(value);
			}
		}
	}

	[Category("Misc")]
	public override Color BackColor
	{
		get
		{
			return ((Control)this).get_BackColor();
		}
		set
		{
			if (value == ((Control)this).get_BackColor())
			{
				return;
			}
			if ((!((Control)this).get_IsHandleCreated() && bool_14 && value == Color.Transparent) ? true : false)
			{
				bool_7 = true;
				return;
			}
			((Control)this).set_BackColor(value);
			if (((Control)this).get_Parent() != null)
			{
				if (!bool_14)
				{
					((Control)this).get_Parent().set_BackColor(value);
				}
				ColorHook();
			}
		}
	}

	public override Size MinimumSize
	{
		get
		{
			return ((Control)this).get_MinimumSize();
		}
		set
		{
			((Control)this).set_MinimumSize(value);
			if (((Control)this).get_Parent() != null)
			{
				((Control)this).get_Parent().set_MinimumSize(value);
			}
		}
	}

	public override Size MaximumSize
	{
		get
		{
			return ((Control)this).get_MaximumSize();
		}
		set
		{
			((Control)this).set_MaximumSize(value);
			if (((Control)this).get_Parent() != null)
			{
				((Control)this).get_Parent().set_MaximumSize(value);
			}
		}
	}

	public override string Text
	{
		get
		{
			return ((Control)this).get_Text();
		}
		set
		{
			((Control)this).set_Text(value);
			((Control)this).Invalidate();
		}
	}

	public override Font Font
	{
		get
		{
			return ((Control)this).get_Font();
		}
		set
		{
			((Control)this).set_Font(value);
			((Control)this).Invalidate();
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public override Color ForeColor
	{
		get
		{
			return Color.Empty;
		}
		set
		{
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public override Image BackgroundImage
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public override ImageLayout BackgroundImageLayout
	{
		get
		{
			return (ImageLayout)0;
		}
		set
		{
		}
	}

	public Control0()
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		Class14.hYiyYvszsKHjE();
		((ContainerControl)this)._002Ector();
		message_0 = (Message[])(object)new Message[9];
		bool_8 = true;
		bool_9 = true;
		bool_10 = true;
		dictionary_0 = new Dictionary<string, Color>();
		int_4 = 24;
		((Control)this).SetStyle((ControlStyles)139270, true);
		size_0 = Size.Empty;
		Font = new Font("Verdana", 8f);
		bitmap_1 = new Bitmap(1, 1);
		graphics_1 = Graphics.FromImage((Image)(object)bitmap_1);
		graphicsPath_0 = new GraphicsPath();
		method_51();
	}

	protected sealed override void OnHandleCreated(EventArgs e)
	{
		if (bool_0)
		{
			method_5();
		}
		method_51();
		ColorHook();
		if (int_2 != 0)
		{
			((Control)this).set_Width(int_2);
		}
		if (int_3 != 0)
		{
			((Control)this).set_Height(int_3);
		}
		if (!bool_14)
		{
			((Control)this).set_Dock((DockStyle)5);
		}
		method_28(bool_12);
		if ((bool_12 && bool_7) ? true : false)
		{
			BackColor = Color.Transparent;
		}
		((Control)this).OnHandleCreated(e);
	}

	protected sealed override void OnParentChanged(EventArgs e)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		((ContainerControl)this).OnParentChanged(e);
		if (((Control)this).get_Parent() == null)
		{
			return;
		}
		bool_13 = ((Control)this).get_Parent() is Form;
		if (!bool_14)
		{
			method_5();
			if (bool_13)
			{
				((ContainerControl)this).get_ParentForm().set_FormBorderStyle(formBorderStyle_0);
				((ContainerControl)this).get_ParentForm().set_TransparencyKey(color_0);
				if (!((Component)(object)this).DesignMode)
				{
					((ContainerControl)this).get_ParentForm().add_Shown((EventHandler)method_1);
				}
			}
			((Control)this).get_Parent().set_BackColor(BackColor);
		}
		OnCreation();
		bool_0 = true;
		method_52();
	}

	private void method_0(bool bool_16)
	{
		OnAnimation();
		if (bool_16)
		{
			((Control)this).Invalidate();
		}
	}

	protected sealed override void OnPaint(PaintEventArgs e)
	{
		if ((((Control)this).get_Width() != 0 && ((Control)this).get_Height() != 0) || 1 == 0)
		{
			if ((bool_12 && bool_14) ? true : false)
			{
				PaintHook();
				e.get_Graphics().DrawImage((Image)(object)bitmap_0, 0, 0);
			}
			else
			{
				graphics_0 = e.get_Graphics();
				PaintHook();
			}
		}
	}

	protected override void OnHandleDestroyed(EventArgs e)
	{
		((Control)this).OnHandleDestroyed(e);
	}

	private void method_1(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Invalid comparison between Unknown and I4
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Invalid comparison between Unknown and I4
		if ((!bool_14 && !bool_1) || 1 == 0)
		{
			if (((int)formStartPosition_0 == 4 || (int)formStartPosition_0 == 1) ? true : false)
			{
				Rectangle bounds = Screen.get_PrimaryScreen().get_Bounds();
				Rectangle bounds2 = ((Control)((ContainerControl)this).get_ParentForm()).get_Bounds();
				Form parentForm = ((ContainerControl)this).get_ParentForm();
				checked
				{
					Point location = new Point(unchecked(bounds.Width / 2) - unchecked(bounds2.Width / 2), unchecked(bounds.Height / 2) - unchecked(bounds2.Width / 2));
					parentForm.set_Location(location);
				}
			}
			bool_1 = true;
		}
	}

	protected sealed override void OnSizeChanged(EventArgs e)
	{
		if ((bool_9 && !bool_14) ? true : false)
		{
			ref Rectangle reference = ref rectangle_0;
			reference = checked(new Rectangle(7, 7, ((Control)this).get_Width() - 14, int_4 - 7));
		}
		method_50();
		((Control)this).Invalidate();
		((Control)this).OnSizeChanged(e);
	}

	protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (int_2 != 0)
		{
			width = int_2;
		}
		if (int_3 != 0)
		{
			height = int_3;
		}
		((Control)this).SetBoundsCore(x, y, width, height, specified);
	}

	private void method_2(Enum0 enum0_1)
	{
		enum0_0 = enum0_1;
		((Control)this).Invalidate();
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Invalid comparison between Unknown and I4
		if ((!bool_13 || (int)((ContainerControl)this).get_ParentForm().get_WindowState() != 2) && true && ((bool_10 && !bool_14) ? true : false))
		{
			method_4();
		}
		((Control)this).OnMouseMove(e);
	}

	protected override void OnEnabledChanged(EventArgs e)
	{
		if (((Control)this).get_Enabled())
		{
			method_2((Enum0)0);
		}
		else
		{
			method_2((Enum0)3);
		}
		((Control)this).OnEnabledChanged(e);
	}

	protected override void OnMouseEnter(EventArgs e)
	{
		method_2((Enum0)1);
		((Control)this).OnMouseEnter(e);
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		method_2((Enum0)1);
		((Control)this).OnMouseUp(e);
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		method_2((Enum0)0);
		if (((Control)this).GetChildAtPoint(((Control)this).PointToClient(Control.get_MousePosition())) != null && ((bool_10 && !bool_14) ? true : false))
		{
			((Control)this).set_Cursor(Cursors.get_Default());
			int_1 = 0;
		}
		((Control)this).OnMouseLeave(e);
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576)
		{
			method_2((Enum0)2);
		}
		if ((!bool_13 || (int)((ContainerControl)this).get_ParentForm().get_WindowState() != 2) && ((!bool_14) ? true : false))
		{
			if ((bool_9 && rectangle_0.Contains(e.get_Location())) ? true : false)
			{
				((Control)this).set_Capture(false);
				bool_2 = true;
				((Control)this).DefWndProc(ref message_0[0]);
			}
			else if ((bool_10 && int_1 != 0) ? true : false)
			{
				((Control)this).set_Capture(false);
				bool_2 = true;
				((Control)this).DefWndProc(ref message_0[int_1]);
			}
		}
		((Control)this).OnMouseDown(e);
	}

	protected override void WndProc(ref Message m)
	{
		((ContainerControl)this).WndProc(ref m);
		if (!bool_2 || ((Message)(ref m)).get_Msg() != 513 || 1 == 0)
		{
			return;
		}
		bool_2 = false;
		method_2((Enum0)1);
		if (bool_8)
		{
			if (method_31())
			{
				Rectangle rectangle_ = new Rectangle(Point.Empty, ((Control)this).get_Parent().get_Parent().get_Size());
				method_6(rectangle_);
			}
			else
			{
				method_6(Screen.FromControl(((Control)this).get_Parent()).get_WorkingArea());
			}
		}
	}

	private int method_3()
	{
		point_0 = ((Control)this).PointToClient(Control.get_MousePosition());
		bool_3 = point_0.X < 7;
		checked
		{
			bool_4 = point_0.X > ((Control)this).get_Width() - 7;
			bool_5 = point_0.Y < 7;
			bool_6 = point_0.Y > ((Control)this).get_Height() - 7;
			if ((bool_3 && bool_5) ? true : false)
			{
				return 4;
			}
			if ((bool_3 && bool_6) ? true : false)
			{
				return 7;
			}
			if ((bool_4 && bool_5) ? true : false)
			{
				return 5;
			}
			if ((bool_4 && bool_6) ? true : false)
			{
				return 8;
			}
			if (bool_3)
			{
				return 1;
			}
			if (bool_4)
			{
				return 2;
			}
			if (bool_5)
			{
				return 3;
			}
			if (bool_6)
			{
				return 6;
			}
			return 0;
		}
	}

	private void method_4()
	{
		int_0 = method_3();
		if (int_0 != int_1)
		{
			int_1 = int_0;
			switch (int_1)
			{
			case 0:
				((Control)this).set_Cursor(Cursors.get_Default());
				break;
			case 1:
			case 2:
				((Control)this).set_Cursor(Cursors.get_SizeWE());
				break;
			case 3:
			case 6:
				((Control)this).set_Cursor(Cursors.get_SizeNS());
				break;
			case 5:
			case 7:
				((Control)this).set_Cursor(Cursors.get_SizeNESW());
				break;
			case 4:
			case 8:
				((Control)this).set_Cursor(Cursors.get_SizeNWSE());
				break;
			}
		}
	}

	private void method_5()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		ref Message reference = ref message_0[0];
		IntPtr handle = ((Control)this).get_Parent().get_Handle();
		IntPtr intPtr = new IntPtr(2);
		reference = Message.Create(handle, 161, intPtr, IntPtr.Zero);
		int num = 1;
		checked
		{
			do
			{
				ref Message reference2 = ref message_0[num];
				IntPtr handle2 = ((Control)this).get_Parent().get_Handle();
				intPtr = new IntPtr(num + 9);
				reference2 = Message.Create(handle2, 161, intPtr, IntPtr.Zero);
				num++;
			}
			while (num <= 8);
		}
	}

	private void method_6(Rectangle rectangle_4)
	{
		if (((Control)this).get_Parent().get_Width() > rectangle_4.Width)
		{
			((Control)this).get_Parent().set_Width(rectangle_4.Width);
		}
		if (((Control)this).get_Parent().get_Height() > rectangle_4.Height)
		{
			((Control)this).get_Parent().set_Height(rectangle_4.Height);
		}
		int num = ((Control)this).get_Parent().get_Location().X;
		int num2 = ((Control)this).get_Parent().get_Location().Y;
		if (num < rectangle_4.X)
		{
			num = rectangle_4.X;
		}
		if (num2 < rectangle_4.Y)
		{
			num2 = rectangle_4.Y;
		}
		checked
		{
			int num3 = rectangle_4.X + rectangle_4.Width;
			int num4 = rectangle_4.Y + rectangle_4.Height;
			if (num + ((Control)this).get_Parent().get_Width() > num3)
			{
				num = num3 - ((Control)this).get_Parent().get_Width();
			}
			if (num2 + ((Control)this).get_Parent().get_Height() > num4)
			{
				num2 = num4 - ((Control)this).get_Parent().get_Height();
			}
			Control parent = ((Control)this).get_Parent();
			Point location = new Point(num, num2);
			parent.set_Location(location);
		}
	}

	[SpecialName]
	public bool method_7()
	{
		return bool_8;
	}

	[SpecialName]
	public void method_8(bool bool_16)
	{
		bool_8 = bool_16;
	}

	[SpecialName]
	public bool method_9()
	{
		return bool_9;
	}

	[SpecialName]
	public void method_10(bool bool_16)
	{
		bool_9 = bool_16;
	}

	[SpecialName]
	public bool method_11()
	{
		return bool_10;
	}

	[SpecialName]
	public void method_12(bool bool_16)
	{
		bool_10 = bool_16;
	}

	[SpecialName]
	public Color method_13()
	{
		if ((bool_13 && !bool_14) ? true : false)
		{
			return ((ContainerControl)this).get_ParentForm().get_TransparencyKey();
		}
		return color_0;
	}

	[SpecialName]
	public void method_14(Color color_1)
	{
		if (!(color_1 == color_0))
		{
			color_0 = color_1;
			if ((bool_13 && !bool_14) ? true : false)
			{
				((ContainerControl)this).get_ParentForm().set_TransparencyKey(color_1);
				ColorHook();
			}
		}
	}

	[SpecialName]
	public FormBorderStyle method_15()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if ((bool_13 && !bool_14) ? true : false)
		{
			return ((ContainerControl)this).get_ParentForm().get_FormBorderStyle();
		}
		return formBorderStyle_0;
	}

	[SpecialName]
	public void method_16(FormBorderStyle formBorderStyle_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Invalid comparison between Unknown and I4
		formBorderStyle_0 = formBorderStyle_1;
		if ((bool_13 && !bool_14) ? true : false)
		{
			((ContainerControl)this).get_ParentForm().set_FormBorderStyle(formBorderStyle_1);
			if ((int)formBorderStyle_1 != 0)
			{
				method_10(bool_16: false);
				method_12(bool_16: false);
			}
		}
	}

	[SpecialName]
	public FormStartPosition method_17()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if ((bool_13 && !bool_14) ? true : false)
		{
			return ((ContainerControl)this).get_ParentForm().get_StartPosition();
		}
		return formStartPosition_0;
	}

	[SpecialName]
	public void method_18(FormStartPosition formStartPosition_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		formStartPosition_0 = formStartPosition_1;
		if ((bool_13 && !bool_14) ? true : false)
		{
			((ContainerControl)this).get_ParentForm().set_StartPosition(formStartPosition_1);
		}
	}

	[SpecialName]
	public bool method_19()
	{
		return bool_11;
	}

	[SpecialName]
	public void method_20(bool bool_16)
	{
		bool_11 = bool_16;
		((Control)this).Invalidate();
	}

	[SpecialName]
	public Image method_21()
	{
		return image_0;
	}

	[SpecialName]
	public void method_22(Image image_1)
	{
		if (image_1 == null)
		{
			size_0 = Size.Empty;
		}
		else
		{
			size_0 = image_1.get_Size();
		}
		image_0 = image_1;
		((Control)this).Invalidate();
	}

	[SpecialName]
	public Struct0[] method_23()
	{
		List<Struct0> list = new List<Struct0>();
		Dictionary<string, Color>.Enumerator enumerator = dictionary_0.GetEnumerator();
		while (enumerator.MoveNext())
		{
			Struct0 item = new Struct0(enumerator.Current.Key, enumerator.Current.Value);
			list.Add(item);
		}
		return list.ToArray();
	}

	[SpecialName]
	public void method_24(Struct0[] struct0_0)
	{
		for (int i = 0; i < struct0_0.Length; i = checked(i + 1))
		{
			Struct0 @struct = struct0_0[i];
			if (dictionary_0.ContainsKey(@struct.method_0()))
			{
				dictionary_0[@struct.method_0()] = @struct.method_1();
			}
		}
		method_51();
		ColorHook();
		((Control)this).Invalidate();
	}

	[SpecialName]
	public string method_25()
	{
		return string_0;
	}

	[SpecialName]
	public void method_26(string string_1)
	{
		if (Operators.CompareString(string_1, string_0, false) == 0)
		{
			return;
		}
		Struct0[] array = method_23();
		checked
		{
			try
			{
				byte[] value = Convert.FromBase64String(string_1);
				int num = array.Length - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 <= num4)
					{
						array[num2].method_2(Color.FromArgb(BitConverter.ToInt32(value, num2 * 4)));
						num2++;
						continue;
					}
					break;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return;
			}
			string_0 = string_1;
			method_24(array);
			ColorHook();
			((Control)this).Invalidate();
		}
	}

	[SpecialName]
	public bool method_27()
	{
		return bool_12;
	}

	[SpecialName]
	public void method_28(bool bool_16)
	{
		bool_12 = bool_16;
		if ((((Control)this).get_IsHandleCreated() || bool_14) && 0 == 0)
		{
			if ((!bool_16 && BackColor.A != byte.MaxValue) ? true : false)
			{
				throw new Exception("Unable to change value to false while a transparent BackColor is in use.");
			}
			((Control)this).SetStyle((ControlStyles)4, !bool_16);
			((Control)this).SetStyle((ControlStyles)2048, bool_16);
			method_50();
			((Control)this).Invalidate();
		}
	}

	[SpecialName]
	protected Size method_29()
	{
		return size_0;
	}

	[SpecialName]
	protected bool method_30()
	{
		return bool_13;
	}

	[SpecialName]
	protected bool method_31()
	{
		if (((Control)this).get_Parent() == null)
		{
			return false;
		}
		return ((Control)this).get_Parent().get_Parent() != null;
	}

	[SpecialName]
	protected int method_32()
	{
		return int_2;
	}

	[SpecialName]
	protected void method_33(int int_5)
	{
		int_2 = int_5;
		if ((method_32() != 0 && ((Control)this).get_IsHandleCreated()) ? true : false)
		{
			((Control)this).set_Width(method_32());
		}
	}

	[SpecialName]
	protected int method_34()
	{
		return int_3;
	}

	[SpecialName]
	protected void method_35(int int_5)
	{
		int_3 = int_5;
		if ((method_34() != 0 && ((Control)this).get_IsHandleCreated()) ? true : false)
		{
			((Control)this).set_Height(method_34());
		}
	}

	[SpecialName]
	protected int method_36()
	{
		return int_4;
	}

	[SpecialName]
	protected void method_37(int int_5)
	{
		int_4 = int_5;
		if (!bool_14)
		{
			ref Rectangle reference = ref rectangle_0;
			reference = checked(new Rectangle(7, 7, ((Control)this).get_Width() - 14, int_5 - 7));
			((Control)this).Invalidate();
		}
	}

	[SpecialName]
	protected bool method_38()
	{
		return bool_14;
	}

	[SpecialName]
	protected void method_39(bool bool_16)
	{
		bool_14 = bool_16;
		method_28(bool_12);
		if ((bool_12 && bool_7) ? true : false)
		{
			BackColor = Color.Transparent;
		}
		method_50();
		((Control)this).Invalidate();
	}

	[SpecialName]
	protected bool method_40()
	{
		return bool_15;
	}

	[SpecialName]
	protected void method_41(bool bool_16)
	{
		bool_15 = bool_16;
		method_52();
	}

	protected Pen method_42(string string_1)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		return new Pen(dictionary_0[string_1]);
	}

	protected Pen method_43(string string_1, float float_0)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		return new Pen(dictionary_0[string_1], float_0);
	}

	protected SolidBrush method_44(string string_1)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		return new SolidBrush(dictionary_0[string_1]);
	}

	protected Color method_45(string string_1)
	{
		return dictionary_0[string_1];
	}

	protected void method_46(string string_1, Color color_1)
	{
		if (dictionary_0.ContainsKey(string_1))
		{
			dictionary_0[string_1] = color_1;
		}
		else
		{
			dictionary_0.Add(string_1, color_1);
		}
	}

	protected void method_47(string string_1, byte byte_0, byte byte_1, byte byte_2)
	{
		method_46(string_1, Color.FromArgb(byte_0, byte_1, byte_2));
	}

	protected void method_48(string string_1, byte byte_0, byte byte_1, byte byte_2, byte byte_3)
	{
		method_46(string_1, Color.FromArgb(byte_0, byte_1, byte_2, byte_3));
	}

	protected void method_49(string string_1, byte byte_0, Color color_1)
	{
		method_46(string_1, Color.FromArgb(byte_0, color_1));
	}

	private void method_50()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		if ((bool_12 && bool_14) ? true : false)
		{
			if ((((Control)this).get_Width() != 0 && ((Control)this).get_Height() != 0) || 1 == 0)
			{
				bitmap_0 = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height(), (PixelFormat)925707);
				graphics_0 = Graphics.FromImage((Image)(object)bitmap_0);
			}
		}
		else
		{
			graphics_0 = null;
			bitmap_0 = null;
		}
	}

	private void method_51()
	{
		MemoryStream memoryStream = new MemoryStream(checked(dictionary_0.Count * 4));
		Struct0[] array = method_23();
		foreach (Struct0 @struct in array)
		{
			memoryStream.Write(BitConverter.GetBytes(@struct.method_1().ToArgb()), 0, 4);
		}
		memoryStream.Close();
		string_0 = Convert.ToBase64String(memoryStream.ToArray());
	}

	private void method_52()
	{
		if (((!((Component)(object)this).DesignMode && bool_0) || 1 == 0) && bool_15)
		{
		}
	}

	protected abstract void ColorHook();

	protected abstract void PaintHook();

	protected virtual void OnCreation()
	{
	}

	protected virtual void OnAnimation()
	{
	}

	protected Rectangle method_53(Rectangle rectangle_4, int int_5)
	{
		ref Rectangle reference = ref rectangle_1;
		reference = checked(new Rectangle(rectangle_4.X + int_5, rectangle_4.Y + int_5, rectangle_4.Width - int_5 * 2, rectangle_4.Height - int_5 * 2));
		return rectangle_1;
	}

	protected Size method_54(Size size_3, int int_5)
	{
		ref Size reference = ref size_1;
		reference = checked(new Size(size_3.Width + int_5, size_3.Height + int_5));
		return size_1;
	}

	protected Point method_55(Point point_5, int int_5)
	{
		ref Point reference = ref point_1;
		reference = checked(new Point(point_5.X + int_5, point_5.Y + int_5));
		return point_1;
	}

	protected Point method_56(Rectangle rectangle_4, Rectangle rectangle_5)
	{
		ref Point reference = ref point_2;
		checked
		{
			reference = new Point(unchecked(rectangle_4.Width / 2) - unchecked(rectangle_5.Width / 2) + rectangle_4.X + rectangle_5.X, unchecked(rectangle_4.Height / 2) - unchecked(rectangle_5.Height / 2) + rectangle_4.Y + rectangle_5.Y);
			return point_2;
		}
	}

	protected Point method_57(Rectangle rectangle_4, Size size_3)
	{
		ref Point reference = ref point_2;
		checked
		{
			reference = new Point(unchecked(rectangle_4.Width / 2) - unchecked(size_3.Width / 2) + rectangle_4.X, unchecked(rectangle_4.Height / 2) - unchecked(size_3.Height / 2) + rectangle_4.Y);
			return point_2;
		}
	}

	protected Point method_58(Rectangle rectangle_4)
	{
		return method_62(((Control)this).get_Width(), ((Control)this).get_Height(), rectangle_4.Width, rectangle_4.Height);
	}

	protected Point method_59(Size size_3)
	{
		return method_62(((Control)this).get_Width(), ((Control)this).get_Height(), size_3.Width, size_3.Height);
	}

	protected Point method_60(int int_5, int int_6)
	{
		return method_62(((Control)this).get_Width(), ((Control)this).get_Height(), int_5, int_6);
	}

	protected Point method_61(Size size_3, Size size_4)
	{
		return method_62(size_3.Width, size_3.Height, size_4.Width, size_4.Height);
	}

	protected Point method_62(int int_5, int int_6, int int_7, int int_8)
	{
		ref Point reference = ref point_2;
		checked
		{
			reference = new Point(unchecked(int_5 / 2) - unchecked(int_7 / 2), unchecked(int_6 / 2) - unchecked(int_8 / 2));
			return point_2;
		}
	}

	protected Size method_63()
	{
		lock (graphics_1)
		{
			return graphics_1.MeasureString(Text, Font, ((Control)this).get_Width()).ToSize();
		}
	}

	protected Size method_64(string string_1)
	{
		lock (graphics_1)
		{
			return graphics_1.MeasureString(string_1, Font, ((Control)this).get_Width()).ToSize();
		}
	}

	protected void method_65(Color color_1, int int_5, int int_6)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		if (bool_12)
		{
			bitmap_0.SetPixel(int_5, int_6, color_1);
			return;
		}
		solidBrush_0 = new SolidBrush(color_1);
		graphics_0.FillRectangle((Brush)(object)solidBrush_0, int_5, int_6, 1, 1);
	}

	protected void method_66(Color color_1, int int_5)
	{
		method_68(color_1, 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height(), int_5);
	}

	protected void method_67(Color color_1, Rectangle rectangle_4, int int_5)
	{
		method_68(color_1, rectangle_4.X, rectangle_4.Y, rectangle_4.Width, rectangle_4.Height, int_5);
	}

	protected void method_68(Color color_1, int int_5, int int_6, int int_7, int int_8, int int_9)
	{
		checked
		{
			method_71(color_1, int_5 + int_9, int_6 + int_9, int_7 - int_9 * 2, int_8 - int_9 * 2);
		}
	}

	protected void method_69(Color color_1)
	{
		method_71(color_1, 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
	}

	protected void method_70(Color color_1, Rectangle rectangle_4)
	{
		method_71(color_1, rectangle_4.X, rectangle_4.Y, rectangle_4.Width, rectangle_4.Height);
	}

	protected void method_71(Color color_1, int int_5, int int_6, int int_7, int int_8)
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		checked
		{
			if (!bool_11)
			{
				if (bool_12)
				{
					bitmap_0.SetPixel(int_5, int_6, color_1);
					bitmap_0.SetPixel(int_5 + (int_7 - 1), int_6, color_1);
					bitmap_0.SetPixel(int_5, int_6 + (int_8 - 1), color_1);
					bitmap_0.SetPixel(int_5 + (int_7 - 1), int_6 + (int_8 - 1), color_1);
				}
				else
				{
					solidBrush_1 = new SolidBrush(color_1);
					graphics_0.FillRectangle((Brush)(object)solidBrush_1, int_5, int_6, 1, 1);
					graphics_0.FillRectangle((Brush)(object)solidBrush_1, int_5 + (int_7 - 1), int_6, 1, 1);
					graphics_0.FillRectangle((Brush)(object)solidBrush_1, int_5, int_6 + (int_8 - 1), 1, 1);
					graphics_0.FillRectangle((Brush)(object)solidBrush_1, int_5 + (int_7 - 1), int_6 + (int_8 - 1), 1, 1);
				}
			}
		}
	}

	protected void method_72(Pen pen_0, int int_5)
	{
		method_74(pen_0, 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height(), int_5);
	}

	protected void method_73(Pen pen_0, Rectangle rectangle_4, int int_5)
	{
		method_74(pen_0, rectangle_4.X, rectangle_4.Y, rectangle_4.Width, rectangle_4.Height, int_5);
	}

	protected void method_74(Pen pen_0, int int_5, int int_6, int int_7, int int_8, int int_9)
	{
		checked
		{
			method_77(pen_0, int_5 + int_9, int_6 + int_9, int_7 - int_9 * 2, int_8 - int_9 * 2);
		}
	}

	protected void method_75(Pen pen_0)
	{
		method_77(pen_0, 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
	}

	protected void method_76(Pen pen_0, Rectangle rectangle_4)
	{
		method_77(pen_0, rectangle_4.X, rectangle_4.Y, rectangle_4.Width, rectangle_4.Height);
	}

	protected void method_77(Pen pen_0, int int_5, int int_6, int int_7, int int_8)
	{
		checked
		{
			graphics_0.DrawRectangle(pen_0, int_5, int_6, int_7 - 1, int_8 - 1);
		}
	}

	protected void method_78(Brush brush_0, HorizontalAlignment horizontalAlignment_0, int int_5, int int_6)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		method_79(brush_0, Text, horizontalAlignment_0, int_5, int_6);
	}

	protected void method_79(Brush brush_0, string string_1, HorizontalAlignment horizontalAlignment_0, int int_5, int int_6)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected I4, but got Unknown
		checked
		{
			if (string_1.Length != 0)
			{
				size_2 = method_64(string_1);
				ref Point reference = ref point_3;
				reference = new Point(unchecked(((Control)this).get_Width() / 2) - unchecked(size_2.Width / 2), unchecked(method_36() / 2) - unchecked(size_2.Height / 2));
				switch (unchecked((int)horizontalAlignment_0))
				{
				case 0:
					graphics_0.DrawString(string_1, Font, brush_0, (float)int_5, (float)(point_3.Y + int_6));
					break;
				case 1:
					graphics_0.DrawString(string_1, Font, brush_0, (float)(((Control)this).get_Width() - size_2.Width - int_5), (float)(point_3.Y + int_6));
					break;
				case 2:
					graphics_0.DrawString(string_1, Font, brush_0, (float)(point_3.X + int_5), (float)(point_3.Y + int_6));
					break;
				}
			}
		}
	}

	protected void method_80(Brush brush_0, Point point_5)
	{
		if (Text.Length != 0)
		{
			graphics_0.DrawString(Text, Font, brush_0, (PointF)point_5);
		}
	}

	protected void method_81(Brush brush_0, int int_5, int int_6)
	{
		if (Text.Length != 0)
		{
			graphics_0.DrawString(Text, Font, brush_0, (float)int_5, (float)int_6);
		}
	}

	protected void method_82(HorizontalAlignment horizontalAlignment_0, int int_5, int int_6)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		method_83(image_0, horizontalAlignment_0, int_5, int_6);
	}

	protected void method_83(Image image_1, HorizontalAlignment horizontalAlignment_0, int int_5, int int_6)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected I4, but got Unknown
		checked
		{
			if (image_1 != null)
			{
				ref Point reference = ref point_4;
				reference = new Point(unchecked(((Control)this).get_Width() / 2) - unchecked(image_1.get_Width() / 2), unchecked(method_36() / 2) - unchecked(image_1.get_Height() / 2));
				switch (unchecked((int)horizontalAlignment_0))
				{
				case 0:
					graphics_0.DrawImage(image_1, int_5, point_4.Y + int_6, image_1.get_Width(), image_1.get_Height());
					break;
				case 1:
					graphics_0.DrawImage(image_1, ((Control)this).get_Width() - image_1.get_Width() - int_5, point_4.Y + int_6, image_1.get_Width(), image_1.get_Height());
					break;
				case 2:
					graphics_0.DrawImage(image_1, point_4.X + int_5, point_4.Y + int_6, image_1.get_Width(), image_1.get_Height());
					break;
				}
			}
		}
	}

	protected void method_84(Point point_5)
	{
		method_87(image_0, point_5.X, point_5.Y);
	}

	protected void method_85(int int_5, int int_6)
	{
		method_87(image_0, int_5, int_6);
	}

	protected void method_86(Image image_1, Point point_5)
	{
		method_87(image_1, point_5.X, point_5.Y);
	}

	protected void method_87(Image image_1, int int_5, int int_6)
	{
		if (image_1 != null)
		{
			graphics_0.DrawImage(image_1, int_5, int_6, image_1.get_Width(), image_1.get_Height());
		}
	}

	protected void method_88(ColorBlend colorBlend_0, int int_5, int int_6, int int_7, int int_8)
	{
		ref Rectangle xfTioibyUt = ref XfTioibyUt;
		xfTioibyUt = new Rectangle(int_5, int_6, int_7, int_8);
		method_90(colorBlend_0, XfTioibyUt);
	}

	protected void method_89(ColorBlend colorBlend_0, int int_5, int int_6, int int_7, int int_8, float float_0)
	{
		ref Rectangle xfTioibyUt = ref XfTioibyUt;
		xfTioibyUt = new Rectangle(int_5, int_6, int_7, int_8);
		method_91(colorBlend_0, XfTioibyUt, float_0);
	}

	protected void method_90(ColorBlend colorBlend_0, Rectangle rectangle_4)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		ofYincMjJU = new LinearGradientBrush(rectangle_4, Color.Empty, Color.Empty, 90f);
		ofYincMjJU.set_InterpolationColors(colorBlend_0);
		graphics_0.FillRectangle((Brush)(object)ofYincMjJU, rectangle_4);
	}

	protected void method_91(ColorBlend colorBlend_0, Rectangle rectangle_4, float float_0)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		ofYincMjJU = new LinearGradientBrush(rectangle_4, Color.Empty, Color.Empty, float_0);
		ofYincMjJU.set_InterpolationColors(colorBlend_0);
		graphics_0.FillRectangle((Brush)(object)ofYincMjJU, rectangle_4);
	}

	protected void method_92(Color color_1, Color color_2, int int_5, int int_6, int int_7, int int_8)
	{
		ref Rectangle xfTioibyUt = ref XfTioibyUt;
		xfTioibyUt = new Rectangle(int_5, int_6, int_7, int_8);
		method_94(color_1, color_2, XfTioibyUt);
	}

	protected void method_93(Color color_1, Color color_2, int int_5, int int_6, int int_7, int int_8, float float_0)
	{
		ref Rectangle xfTioibyUt = ref XfTioibyUt;
		xfTioibyUt = new Rectangle(int_5, int_6, int_7, int_8);
		method_95(color_1, color_2, XfTioibyUt, float_0);
	}

	protected void method_94(Color color_1, Color color_2, Rectangle rectangle_4)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		ofYincMjJU = new LinearGradientBrush(rectangle_4, color_1, color_2, 90f);
		graphics_0.FillRectangle((Brush)(object)ofYincMjJU, rectangle_4);
	}

	protected void method_95(Color color_1, Color color_2, Rectangle rectangle_4, float float_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		ofYincMjJU = new LinearGradientBrush(rectangle_4, color_1, color_2, float_0);
		graphics_0.FillRectangle((Brush)(object)ofYincMjJU, rectangle_4);
	}

	public void method_96(ColorBlend colorBlend_0, int int_5, int int_6, int int_7, int int_8)
	{
		ref Rectangle reference = ref rectangle_2;
		reference = new Rectangle(int_5, int_6, int_7, int_8);
		method_101(colorBlend_0, rectangle_2, int_7 / 2, int_8 / 2);
	}

	public void method_97(ColorBlend colorBlend_0, int int_5, int int_6, int int_7, int int_8, Point point_5)
	{
		ref Rectangle reference = ref rectangle_2;
		reference = new Rectangle(int_5, int_6, int_7, int_8);
		method_101(colorBlend_0, rectangle_2, point_5.X, point_5.Y);
	}

	public void method_98(ColorBlend colorBlend_0, int int_5, int int_6, int int_7, int int_8, int int_9, int int_10)
	{
		ref Rectangle reference = ref rectangle_2;
		reference = new Rectangle(int_5, int_6, int_7, int_8);
		method_101(colorBlend_0, rectangle_2, int_9, int_10);
	}

	public void method_99(ColorBlend colorBlend_0, Rectangle rectangle_4)
	{
		method_101(colorBlend_0, rectangle_4, rectangle_4.Width / 2, rectangle_4.Height / 2);
	}

	public void method_100(ColorBlend colorBlend_0, Rectangle rectangle_4, Point point_5)
	{
		method_101(colorBlend_0, rectangle_4, point_5.X, point_5.Y);
	}

	public void method_101(ColorBlend colorBlend_0, Rectangle rectangle_4, int int_5, int int_6)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Invalid comparison between Unknown and I4
		graphicsPath_0.Reset();
		checked
		{
			graphicsPath_0.AddEllipse(rectangle_4.X, rectangle_4.Y, rectangle_4.Width - 1, rectangle_4.Height - 1);
			pathGradientBrush_0 = new PathGradientBrush(graphicsPath_0);
			PathGradientBrush obj = pathGradientBrush_0;
			Point point = new Point(rectangle_4.X + int_5, rectangle_4.Y + int_6);
			obj.set_CenterPoint((PointF)point);
			pathGradientBrush_0.set_InterpolationColors(colorBlend_0);
			if (unchecked((int)graphics_0.get_SmoothingMode()) == 4)
			{
				graphics_0.FillEllipse((Brush)(object)pathGradientBrush_0, rectangle_4.X + 1, rectangle_4.Y + 1, rectangle_4.Width - 3, rectangle_4.Height - 3);
			}
			else
			{
				graphics_0.FillEllipse((Brush)(object)pathGradientBrush_0, rectangle_4);
			}
		}
	}

	protected void method_102(Color color_1, Color color_2, int int_5, int int_6, int int_7, int int_8)
	{
		ref Rectangle reference = ref rectangle_2;
		reference = new Rectangle(int_5, int_6, int_7, int_8);
		method_104(color_1, color_2, XfTioibyUt);
	}

	protected void method_103(Color color_1, Color color_2, int int_5, int int_6, int int_7, int int_8, float float_0)
	{
		ref Rectangle reference = ref rectangle_2;
		reference = new Rectangle(int_5, int_6, int_7, int_8);
		method_105(color_1, color_2, XfTioibyUt, float_0);
	}

	protected void method_104(Color color_1, Color color_2, Rectangle rectangle_4)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		linearGradientBrush_0 = new LinearGradientBrush(rectangle_4, color_1, color_2, 90f);
		graphics_0.FillRectangle((Brush)(object)ofYincMjJU, rectangle_4);
	}

	protected void method_105(Color color_1, Color color_2, Rectangle rectangle_4, float float_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		linearGradientBrush_0 = new LinearGradientBrush(rectangle_4, color_1, color_2, float_0);
		graphics_0.FillEllipse((Brush)(object)ofYincMjJU, rectangle_4);
	}

	public GraphicsPath method_106(int int_5, int int_6, int int_7, int int_8, int int_9)
	{
		ref Rectangle reference = ref rectangle_3;
		reference = new Rectangle(int_5, int_6, int_7, int_8);
		return method_107(rectangle_3, int_9);
	}

	public GraphicsPath method_107(Rectangle rectangle_4, int int_5)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		graphicsPath_1 = new GraphicsPath((FillMode)1);
		graphicsPath_1.AddArc(rectangle_4.X, rectangle_4.Y, int_5, int_5, 180f, 90f);
		checked
		{
			graphicsPath_1.AddArc(rectangle_4.Right - int_5, rectangle_4.Y, int_5, int_5, 270f, 90f);
			graphicsPath_1.AddArc(rectangle_4.Right - int_5, rectangle_4.Bottom - int_5, int_5, int_5, 0f, 90f);
			graphicsPath_1.AddArc(rectangle_4.X, rectangle_4.Bottom - int_5, int_5, int_5, 90f, 90f);
			graphicsPath_1.CloseFigure();
			return graphicsPath_1;
		}
	}
}
