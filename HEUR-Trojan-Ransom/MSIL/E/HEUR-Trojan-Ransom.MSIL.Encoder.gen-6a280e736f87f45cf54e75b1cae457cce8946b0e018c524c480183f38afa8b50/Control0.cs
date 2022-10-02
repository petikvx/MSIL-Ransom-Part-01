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

	private bool WaDaplxmss;

	private Size cCpaDqmku7;

	private bool bool_12;

	private int int_2;

	private int int_3;

	private int opUayMorAB;

	private bool bool_13;

	private bool bool_14;

	private Rectangle rectangle_1;

	private Size size_0;

	private Point point_1;

	private Point WplauAfXo6;

	private Bitmap bitmap_1;

	private Graphics graphics_1;

	private SolidBrush solidBrush_0;

	private SolidBrush solidBrush_1;

	private Point point_2;

	private Size size_1;

	private Point point_3;

	private LinearGradientBrush linearGradientBrush_0;

	private Rectangle rectangle_2;

	private GraphicsPath graphicsPath_0;

	private PathGradientBrush pathGradientBrush_0;

	private LinearGradientBrush linearGradientBrush_1;

	private Rectangle rectangle_3;

	private GraphicsPath graphicsPath_1;

	private Rectangle rectangle_4;

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
			if (bool_13)
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
			if ((!((Control)this).get_IsHandleCreated() && bool_13 && value == Color.Transparent) ? true : false)
			{
				bool_7 = true;
				return;
			}
			((Control)this).set_BackColor(value);
			if (((Control)this).get_Parent() != null)
			{
				if (!bool_13)
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
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[EditorBrowsable(EditorBrowsableState.Never)]
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

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[EditorBrowsable(EditorBrowsableState.Never)]
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

	protected int Header
	{
		get
		{
			return opUayMorAB;
		}
		set
		{
			opUayMorAB = value;
			if (!bool_13)
			{
				ref Rectangle reference = ref rectangle_0;
				reference = checked(new Rectangle(7, 7, ((Control)this).get_Width() - 14, value - 7));
				((Control)this).Invalidate();
			}
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
		Class14.vPNVHkezq0oMI();
		((ContainerControl)this)._002Ector();
		message_0 = (Message[])(object)new Message[9];
		bool_8 = true;
		bool_9 = true;
		bool_10 = true;
		dictionary_0 = new Dictionary<string, Color>();
		opUayMorAB = 24;
		((Control)this).SetStyle((ControlStyles)139270, true);
		cCpaDqmku7 = Size.Empty;
		Font = new Font("Verdana", 8f);
		bitmap_1 = new Bitmap(1, 1);
		graphics_1 = Graphics.FromImage((Image)(object)bitmap_1);
		graphicsPath_0 = new GraphicsPath();
		method_48();
	}

	protected sealed override void OnHandleCreated(EventArgs e)
	{
		if (bool_0)
		{
			method_5();
		}
		method_48();
		ColorHook();
		if (int_2 != 0)
		{
			((Control)this).set_Width(int_2);
		}
		if (int_3 != 0)
		{
			((Control)this).set_Height(int_3);
		}
		if (!bool_13)
		{
			((Control)this).set_Dock((DockStyle)5);
		}
		method_27(WaDaplxmss);
		if ((WaDaplxmss && bool_7) ? true : false)
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
		bool_12 = ((Control)this).get_Parent() is Form;
		if (!bool_13)
		{
			method_5();
			if (bool_12)
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
		method_49();
	}

	private void method_0(bool bool_15)
	{
		vmethod_0();
		if (bool_15)
		{
			((Control)this).Invalidate();
		}
	}

	protected sealed override void OnPaint(PaintEventArgs e)
	{
		if ((((Control)this).get_Width() != 0 && ((Control)this).get_Height() != 0) || 1 == 0)
		{
			if ((WaDaplxmss && bool_13) ? true : false)
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
		Class8.smethod_3(new Class8.Delegate0(method_0));
		((Control)this).OnHandleDestroyed(e);
	}

	private void method_1(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Invalid comparison between Unknown and I4
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Invalid comparison between Unknown and I4
		if ((!bool_13 && !bool_1) || 1 == 0)
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
		if ((bool_9 && !bool_13) ? true : false)
		{
			ref Rectangle reference = ref rectangle_0;
			reference = checked(new Rectangle(7, 7, ((Control)this).get_Width() - 14, opUayMorAB - 7));
		}
		method_47();
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
		if ((!bool_12 || (int)((ContainerControl)this).get_ParentForm().get_WindowState() != 2) && true && ((bool_10 && !bool_13) ? true : false))
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

	protected override void OnMouseUp(MouseEventArgs mevent)
	{
		method_2((Enum0)1);
		((Control)this).OnMouseUp(mevent);
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		method_2((Enum0)0);
		if (((Control)this).GetChildAtPoint(((Control)this).PointToClient(Control.get_MousePosition())) != null && ((bool_10 && !bool_13) ? true : false))
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
		if ((!bool_12 || (int)((ContainerControl)this).get_ParentForm().get_WindowState() != 2) && ((!bool_13) ? true : false))
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
			if (method_30())
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

	private void method_6(Rectangle rectangle_5)
	{
		if (((Control)this).get_Parent().get_Width() > rectangle_5.Width)
		{
			((Control)this).get_Parent().set_Width(rectangle_5.Width);
		}
		if (((Control)this).get_Parent().get_Height() > rectangle_5.Height)
		{
			((Control)this).get_Parent().set_Height(rectangle_5.Height);
		}
		int num = ((Control)this).get_Parent().get_Location().X;
		int num2 = ((Control)this).get_Parent().get_Location().Y;
		if (num < rectangle_5.X)
		{
			num = rectangle_5.X;
		}
		if (num2 < rectangle_5.Y)
		{
			num2 = rectangle_5.Y;
		}
		checked
		{
			int num3 = rectangle_5.X + rectangle_5.Width;
			int num4 = rectangle_5.Y + rectangle_5.Height;
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
	public void method_8(bool bool_15)
	{
		bool_8 = bool_15;
	}

	[SpecialName]
	public bool method_9()
	{
		return bool_9;
	}

	[SpecialName]
	public void method_10(bool bool_15)
	{
		bool_9 = bool_15;
	}

	[SpecialName]
	public bool method_11()
	{
		return bool_10;
	}

	[SpecialName]
	public void method_12(bool bool_15)
	{
		bool_10 = bool_15;
	}

	[SpecialName]
	public Color method_13()
	{
		if ((bool_12 && !bool_13) ? true : false)
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
			if ((bool_12 && !bool_13) ? true : false)
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
		if ((bool_12 && !bool_13) ? true : false)
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
		if ((bool_12 && !bool_13) ? true : false)
		{
			((ContainerControl)this).get_ParentForm().set_FormBorderStyle(formBorderStyle_1);
			if ((int)formBorderStyle_1 != 0)
			{
				method_10(bool_15: false);
				method_12(bool_15: false);
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
		if ((bool_12 && !bool_13) ? true : false)
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
		if ((bool_12 && !bool_13) ? true : false)
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
	public void method_20(bool bool_15)
	{
		bool_11 = bool_15;
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
			cCpaDqmku7 = Size.Empty;
		}
		else
		{
			cCpaDqmku7 = image_1.get_Size();
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
		method_48();
		ColorHook();
		((Control)this).Invalidate();
	}

	[SpecialName]
	public string method_25()
	{
		return string_0;
	}

	[SpecialName]
	public void lXyFuQbeuJ(string string_1)
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
	public bool method_26()
	{
		return WaDaplxmss;
	}

	[SpecialName]
	public void method_27(bool bool_15)
	{
		WaDaplxmss = bool_15;
		if ((((Control)this).get_IsHandleCreated() || bool_13) && 0 == 0)
		{
			if ((!bool_15 && BackColor.A != byte.MaxValue) ? true : false)
			{
				throw new Exception("Unable to change value to false while a transparent BackColor is in use.");
			}
			((Control)this).SetStyle((ControlStyles)4, !bool_15);
			((Control)this).SetStyle((ControlStyles)2048, bool_15);
			method_47();
			((Control)this).Invalidate();
		}
	}

	[SpecialName]
	protected Size method_28()
	{
		return cCpaDqmku7;
	}

	[SpecialName]
	protected bool method_29()
	{
		return bool_12;
	}

	[SpecialName]
	protected bool method_30()
	{
		if (((Control)this).get_Parent() == null)
		{
			return false;
		}
		return ((Control)this).get_Parent().get_Parent() != null;
	}

	[SpecialName]
	protected int method_31()
	{
		return int_2;
	}

	[SpecialName]
	protected void method_32(int int_4)
	{
		int_2 = int_4;
		if ((method_31() != 0 && ((Control)this).get_IsHandleCreated()) ? true : false)
		{
			((Control)this).set_Width(method_31());
		}
	}

	[SpecialName]
	protected int method_33()
	{
		return int_3;
	}

	[SpecialName]
	protected void method_34(int int_4)
	{
		int_3 = int_4;
		if ((method_33() != 0 && ((Control)this).get_IsHandleCreated()) ? true : false)
		{
			((Control)this).set_Height(method_33());
		}
	}

	[SpecialName]
	protected bool method_35()
	{
		return bool_13;
	}

	[SpecialName]
	protected void method_36(bool bool_15)
	{
		bool_13 = bool_15;
		method_27(WaDaplxmss);
		if ((WaDaplxmss && bool_7) ? true : false)
		{
			BackColor = Color.Transparent;
		}
		method_47();
		((Control)this).Invalidate();
	}

	[SpecialName]
	protected bool method_37()
	{
		return bool_14;
	}

	[SpecialName]
	protected void method_38(bool bool_15)
	{
		bool_14 = bool_15;
		method_49();
	}

	protected Pen method_39(string string_1)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		return new Pen(dictionary_0[string_1]);
	}

	protected Pen method_40(string string_1, float float_0)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		return new Pen(dictionary_0[string_1], float_0);
	}

	protected SolidBrush method_41(string string_1)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		return new SolidBrush(dictionary_0[string_1]);
	}

	protected Color method_42(string string_1)
	{
		return dictionary_0[string_1];
	}

	protected void method_43(string string_1, Color color_1)
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

	protected void method_44(string string_1, byte byte_0, byte byte_1, byte byte_2)
	{
		method_43(string_1, Color.FromArgb(byte_0, byte_1, byte_2));
	}

	protected void method_45(string string_1, byte byte_0, byte byte_1, byte byte_2, byte byte_3)
	{
		method_43(string_1, Color.FromArgb(byte_0, byte_1, byte_2, byte_3));
	}

	protected void method_46(string string_1, byte byte_0, Color color_1)
	{
		method_43(string_1, Color.FromArgb(byte_0, color_1));
	}

	private void method_47()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		if ((WaDaplxmss && bool_13) ? true : false)
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

	private void method_48()
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

	private void method_49()
	{
		if ((!((Component)(object)this).DesignMode && bool_0) || 1 == 0)
		{
			if (bool_14)
			{
				Class8.smethod_2(new Class8.Delegate0(method_0));
			}
			else
			{
				Class8.smethod_3(new Class8.Delegate0(method_0));
			}
		}
	}

	protected abstract void ColorHook();

	protected abstract void PaintHook();

	protected virtual void OnCreation()
	{
	}

	protected virtual void vmethod_0()
	{
	}

	protected Rectangle method_50(Rectangle rectangle_5, int int_4)
	{
		ref Rectangle reference = ref rectangle_1;
		reference = checked(new Rectangle(rectangle_5.X + int_4, rectangle_5.Y + int_4, rectangle_5.Width - int_4 * 2, rectangle_5.Height - int_4 * 2));
		return rectangle_1;
	}

	protected Size method_51(Size size_2, int int_4)
	{
		ref Size reference = ref size_0;
		reference = checked(new Size(size_2.Width + int_4, size_2.Height + int_4));
		return size_0;
	}

	protected Point method_52(Point point_4, int int_4)
	{
		ref Point reference = ref point_1;
		reference = checked(new Point(point_4.X + int_4, point_4.Y + int_4));
		return point_1;
	}

	protected Point method_53(Rectangle rectangle_5, Rectangle rectangle_6)
	{
		ref Point wplauAfXo = ref WplauAfXo6;
		checked
		{
			wplauAfXo = new Point(unchecked(rectangle_5.Width / 2) - unchecked(rectangle_6.Width / 2) + rectangle_5.X + rectangle_6.X, unchecked(rectangle_5.Height / 2) - unchecked(rectangle_6.Height / 2) + rectangle_5.Y + rectangle_6.Y);
			return WplauAfXo6;
		}
	}

	protected Point method_54(Rectangle rectangle_5, Size size_2)
	{
		ref Point wplauAfXo = ref WplauAfXo6;
		checked
		{
			wplauAfXo = new Point(unchecked(rectangle_5.Width / 2) - unchecked(size_2.Width / 2) + rectangle_5.X, unchecked(rectangle_5.Height / 2) - unchecked(size_2.Height / 2) + rectangle_5.Y);
			return WplauAfXo6;
		}
	}

	protected Point method_55(Rectangle rectangle_5)
	{
		return method_59(((Control)this).get_Width(), ((Control)this).get_Height(), rectangle_5.Width, rectangle_5.Height);
	}

	protected Point method_56(Size size_2)
	{
		return method_59(((Control)this).get_Width(), ((Control)this).get_Height(), size_2.Width, size_2.Height);
	}

	protected Point method_57(int int_4, int int_5)
	{
		return method_59(((Control)this).get_Width(), ((Control)this).get_Height(), int_4, int_5);
	}

	protected Point method_58(Size size_2, Size size_3)
	{
		return method_59(size_2.Width, size_2.Height, size_3.Width, size_3.Height);
	}

	protected Point method_59(int int_4, int int_5, int int_6, int int_7)
	{
		ref Point wplauAfXo = ref WplauAfXo6;
		checked
		{
			wplauAfXo = new Point(unchecked(int_4 / 2) - unchecked(int_6 / 2), unchecked(int_5 / 2) - unchecked(int_7 / 2));
			return WplauAfXo6;
		}
	}

	protected Size method_60()
	{
		lock (graphics_1)
		{
			return graphics_1.MeasureString(Text, Font, ((Control)this).get_Width()).ToSize();
		}
	}

	protected Size method_61(string string_1)
	{
		lock (graphics_1)
		{
			return graphics_1.MeasureString(string_1, Font, ((Control)this).get_Width()).ToSize();
		}
	}

	protected void method_62(Color color_1, int int_4, int int_5)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		if (WaDaplxmss)
		{
			bitmap_0.SetPixel(int_4, int_5, color_1);
			return;
		}
		solidBrush_0 = new SolidBrush(color_1);
		graphics_0.FillRectangle((Brush)(object)solidBrush_0, int_4, int_5, 1, 1);
	}

	protected void method_63(Color color_1, int int_4)
	{
		method_65(color_1, 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height(), int_4);
	}

	protected void method_64(Color color_1, Rectangle rectangle_5, int int_4)
	{
		method_65(color_1, rectangle_5.X, rectangle_5.Y, rectangle_5.Width, rectangle_5.Height, int_4);
	}

	protected void method_65(Color color_1, int int_4, int int_5, int int_6, int int_7, int int_8)
	{
		checked
		{
			method_68(color_1, int_4 + int_8, int_5 + int_8, int_6 - int_8 * 2, int_7 - int_8 * 2);
		}
	}

	protected void method_66(Color color_1)
	{
		method_68(color_1, 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
	}

	protected void method_67(Color color_1, Rectangle rectangle_5)
	{
		method_68(color_1, rectangle_5.X, rectangle_5.Y, rectangle_5.Width, rectangle_5.Height);
	}

	protected void method_68(Color color_1, int int_4, int int_5, int int_6, int int_7)
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		checked
		{
			if (!bool_11)
			{
				if (WaDaplxmss)
				{
					bitmap_0.SetPixel(int_4, int_5, color_1);
					bitmap_0.SetPixel(int_4 + (int_6 - 1), int_5, color_1);
					bitmap_0.SetPixel(int_4, int_5 + (int_7 - 1), color_1);
					bitmap_0.SetPixel(int_4 + (int_6 - 1), int_5 + (int_7 - 1), color_1);
				}
				else
				{
					solidBrush_1 = new SolidBrush(color_1);
					graphics_0.FillRectangle((Brush)(object)solidBrush_1, int_4, int_5, 1, 1);
					graphics_0.FillRectangle((Brush)(object)solidBrush_1, int_4 + (int_6 - 1), int_5, 1, 1);
					graphics_0.FillRectangle((Brush)(object)solidBrush_1, int_4, int_5 + (int_7 - 1), 1, 1);
					graphics_0.FillRectangle((Brush)(object)solidBrush_1, int_4 + (int_6 - 1), int_5 + (int_7 - 1), 1, 1);
				}
			}
		}
	}

	protected void method_69(Pen pen_0, int int_4)
	{
		method_71(pen_0, 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height(), int_4);
	}

	protected void method_70(Pen pen_0, Rectangle rectangle_5, int int_4)
	{
		method_71(pen_0, rectangle_5.X, rectangle_5.Y, rectangle_5.Width, rectangle_5.Height, int_4);
	}

	protected void method_71(Pen pen_0, int int_4, int int_5, int int_6, int int_7, int int_8)
	{
		checked
		{
			method_73(pen_0, int_4 + int_8, int_5 + int_8, int_6 - int_8 * 2, int_7 - int_8 * 2);
		}
	}

	protected void method_72(Pen pen_0)
	{
		method_73(pen_0, 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
	}

	protected void gffRovqGn0(Pen pen_0, Rectangle rectangle_5)
	{
		method_73(pen_0, rectangle_5.X, rectangle_5.Y, rectangle_5.Width, rectangle_5.Height);
	}

	protected void method_73(Pen pen_0, int int_4, int int_5, int int_6, int int_7)
	{
		checked
		{
			graphics_0.DrawRectangle(pen_0, int_4, int_5, int_6 - 1, int_7 - 1);
		}
	}

	protected void method_74(Brush brush_0, HorizontalAlignment horizontalAlignment_0, int int_4, int int_5)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		method_75(brush_0, Text, horizontalAlignment_0, int_4, int_5);
	}

	protected void method_75(Brush brush_0, string string_1, HorizontalAlignment horizontalAlignment_0, int int_4, int int_5)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected I4, but got Unknown
		checked
		{
			if (string_1.Length != 0)
			{
				size_1 = method_61(string_1);
				ref Point reference = ref point_2;
				reference = new Point(unchecked(((Control)this).get_Width() / 2) - unchecked(size_1.Width / 2), unchecked(Header / 2) - unchecked(size_1.Height / 2));
				switch (unchecked((int)horizontalAlignment_0))
				{
				case 0:
					graphics_0.DrawString(string_1, Font, brush_0, (float)int_4, (float)(point_2.Y + int_5));
					break;
				case 1:
					graphics_0.DrawString(string_1, Font, brush_0, (float)(((Control)this).get_Width() - size_1.Width - int_4), (float)(point_2.Y + int_5));
					break;
				case 2:
					graphics_0.DrawString(string_1, Font, brush_0, (float)(point_2.X + int_4), (float)(point_2.Y + int_5));
					break;
				}
			}
		}
	}

	protected void method_76(Brush brush_0, Point point_4)
	{
		if (Text.Length != 0)
		{
			graphics_0.DrawString(Text, Font, brush_0, (PointF)point_4);
		}
	}

	protected void method_77(Brush brush_0, int int_4, int int_5)
	{
		if (Text.Length != 0)
		{
			graphics_0.DrawString(Text, Font, brush_0, (float)int_4, (float)int_5);
		}
	}

	protected void DrawImage(HorizontalAlignment a, int x, int y)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		DrawImage(image_0, a, x, y);
	}

	protected void DrawImage(Image image, HorizontalAlignment a, int x, int y)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected I4, but got Unknown
		checked
		{
			if (image != null)
			{
				ref Point reference = ref point_3;
				reference = new Point(unchecked(((Control)this).get_Width() / 2) - unchecked(image.get_Width() / 2), unchecked(Header / 2) - unchecked(image.get_Height() / 2));
				switch (unchecked((int)a))
				{
				case 0:
					graphics_0.DrawImage(image, x, point_3.Y + y, image.get_Width(), image.get_Height());
					break;
				case 1:
					graphics_0.DrawImage(image, ((Control)this).get_Width() - image.get_Width() - x, point_3.Y + y, image.get_Width(), image.get_Height());
					break;
				case 2:
					graphics_0.DrawImage(image, point_3.X + x, point_3.Y + y, image.get_Width(), image.get_Height());
					break;
				}
			}
		}
	}

	protected void DrawImage(Point p1)
	{
		DrawImage(image_0, p1.X, p1.Y);
	}

	protected void DrawImage(int x, int y)
	{
		DrawImage(image_0, x, y);
	}

	protected void DrawImage(Image image, Point p1)
	{
		DrawImage(image, p1.X, p1.Y);
	}

	protected void DrawImage(Image image, int x, int y)
	{
		if (image != null)
		{
			graphics_0.DrawImage(image, x, y, image.get_Width(), image.get_Height());
		}
	}

	protected void method_78(ColorBlend colorBlend_0, int int_4, int int_5, int int_6, int int_7)
	{
		ref Rectangle reference = ref rectangle_2;
		reference = new Rectangle(int_4, int_5, int_6, int_7);
		method_80(colorBlend_0, rectangle_2);
	}

	protected void method_79(ColorBlend colorBlend_0, int int_4, int int_5, int int_6, int int_7, float float_0)
	{
		ref Rectangle reference = ref rectangle_2;
		reference = new Rectangle(int_4, int_5, int_6, int_7);
		method_81(colorBlend_0, rectangle_2, float_0);
	}

	protected void method_80(ColorBlend colorBlend_0, Rectangle rectangle_5)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		linearGradientBrush_0 = new LinearGradientBrush(rectangle_5, Color.Empty, Color.Empty, 90f);
		linearGradientBrush_0.set_InterpolationColors(colorBlend_0);
		graphics_0.FillRectangle((Brush)(object)linearGradientBrush_0, rectangle_5);
	}

	protected void method_81(ColorBlend colorBlend_0, Rectangle rectangle_5, float float_0)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		linearGradientBrush_0 = new LinearGradientBrush(rectangle_5, Color.Empty, Color.Empty, float_0);
		linearGradientBrush_0.set_InterpolationColors(colorBlend_0);
		graphics_0.FillRectangle((Brush)(object)linearGradientBrush_0, rectangle_5);
	}

	protected void method_82(Color color_1, Color color_2, int int_4, int int_5, int int_6, int int_7)
	{
		ref Rectangle reference = ref rectangle_2;
		reference = new Rectangle(int_4, int_5, int_6, int_7);
		method_84(color_1, color_2, rectangle_2);
	}

	protected void method_83(Color color_1, Color color_2, int int_4, int int_5, int int_6, int int_7, float float_0)
	{
		ref Rectangle reference = ref rectangle_2;
		reference = new Rectangle(int_4, int_5, int_6, int_7);
		method_85(color_1, color_2, rectangle_2, float_0);
	}

	protected void method_84(Color color_1, Color color_2, Rectangle rectangle_5)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		linearGradientBrush_0 = new LinearGradientBrush(rectangle_5, color_1, color_2, 90f);
		graphics_0.FillRectangle((Brush)(object)linearGradientBrush_0, rectangle_5);
	}

	protected void method_85(Color color_1, Color color_2, Rectangle rectangle_5, float float_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		linearGradientBrush_0 = new LinearGradientBrush(rectangle_5, color_1, color_2, float_0);
		graphics_0.FillRectangle((Brush)(object)linearGradientBrush_0, rectangle_5);
	}

	public void method_86(ColorBlend colorBlend_0, int int_4, int int_5, int int_6, int int_7)
	{
		ref Rectangle reference = ref rectangle_3;
		reference = new Rectangle(int_4, int_5, int_6, int_7);
		method_91(colorBlend_0, rectangle_3, int_6 / 2, int_7 / 2);
	}

	public void method_87(ColorBlend colorBlend_0, int int_4, int int_5, int int_6, int int_7, Point point_4)
	{
		ref Rectangle reference = ref rectangle_3;
		reference = new Rectangle(int_4, int_5, int_6, int_7);
		method_91(colorBlend_0, rectangle_3, point_4.X, point_4.Y);
	}

	public void method_88(ColorBlend colorBlend_0, int int_4, int int_5, int int_6, int int_7, int int_8, int int_9)
	{
		ref Rectangle reference = ref rectangle_3;
		reference = new Rectangle(int_4, int_5, int_6, int_7);
		method_91(colorBlend_0, rectangle_3, int_8, int_9);
	}

	public void method_89(ColorBlend colorBlend_0, Rectangle rectangle_5)
	{
		method_91(colorBlend_0, rectangle_5, rectangle_5.Width / 2, rectangle_5.Height / 2);
	}

	public void method_90(ColorBlend colorBlend_0, Rectangle rectangle_5, Point point_4)
	{
		method_91(colorBlend_0, rectangle_5, point_4.X, point_4.Y);
	}

	public void method_91(ColorBlend colorBlend_0, Rectangle rectangle_5, int int_4, int int_5)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Invalid comparison between Unknown and I4
		graphicsPath_0.Reset();
		checked
		{
			graphicsPath_0.AddEllipse(rectangle_5.X, rectangle_5.Y, rectangle_5.Width - 1, rectangle_5.Height - 1);
			pathGradientBrush_0 = new PathGradientBrush(graphicsPath_0);
			PathGradientBrush obj = pathGradientBrush_0;
			Point point = new Point(rectangle_5.X + int_4, rectangle_5.Y + int_5);
			obj.set_CenterPoint((PointF)point);
			pathGradientBrush_0.set_InterpolationColors(colorBlend_0);
			if (unchecked((int)graphics_0.get_SmoothingMode()) == 4)
			{
				graphics_0.FillEllipse((Brush)(object)pathGradientBrush_0, rectangle_5.X + 1, rectangle_5.Y + 1, rectangle_5.Width - 3, rectangle_5.Height - 3);
			}
			else
			{
				graphics_0.FillEllipse((Brush)(object)pathGradientBrush_0, rectangle_5);
			}
		}
	}

	protected void method_92(Color color_1, Color color_2, int int_4, int int_5, int int_6, int int_7)
	{
		ref Rectangle reference = ref rectangle_3;
		reference = new Rectangle(int_4, int_5, int_6, int_7);
		method_94(color_1, color_2, rectangle_2);
	}

	protected void method_93(Color color_1, Color color_2, int int_4, int int_5, int int_6, int int_7, float float_0)
	{
		ref Rectangle reference = ref rectangle_3;
		reference = new Rectangle(int_4, int_5, int_6, int_7);
		method_95(color_1, color_2, rectangle_2, float_0);
	}

	protected void method_94(Color color_1, Color color_2, Rectangle rectangle_5)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		linearGradientBrush_1 = new LinearGradientBrush(rectangle_5, color_1, color_2, 90f);
		graphics_0.FillRectangle((Brush)(object)linearGradientBrush_0, rectangle_5);
	}

	protected void method_95(Color color_1, Color color_2, Rectangle rectangle_5, float float_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		linearGradientBrush_1 = new LinearGradientBrush(rectangle_5, color_1, color_2, float_0);
		graphics_0.FillEllipse((Brush)(object)linearGradientBrush_0, rectangle_5);
	}

	public GraphicsPath method_96(int int_4, int int_5, int int_6, int int_7, int int_8)
	{
		ref Rectangle reference = ref rectangle_4;
		reference = new Rectangle(int_4, int_5, int_6, int_7);
		return method_97(rectangle_4, int_8);
	}

	public GraphicsPath method_97(Rectangle rectangle_5, int int_4)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		graphicsPath_1 = new GraphicsPath((FillMode)1);
		graphicsPath_1.AddArc(rectangle_5.X, rectangle_5.Y, int_4, int_4, 180f, 90f);
		checked
		{
			graphicsPath_1.AddArc(rectangle_5.Right - int_4, rectangle_5.Y, int_4, int_4, 270f, 90f);
			graphicsPath_1.AddArc(rectangle_5.Right - int_4, rectangle_5.Bottom - int_4, int_4, int_4, 0f, 90f);
			graphicsPath_1.AddArc(rectangle_5.X, rectangle_5.Bottom - int_4, int_4, int_4, 90f, 90f);
			graphicsPath_1.CloseFigure();
			return graphicsPath_1;
		}
	}
}
