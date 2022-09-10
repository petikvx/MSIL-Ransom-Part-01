using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

public abstract class GControl14 : ContainerControl
{
	protected Graphics graphics_0;

	private Rectangle rectangle_0;

	protected GEnum1 genum1_0;

	private Point point_0;

	private bool bool_0;

	private bool bool_1;

	private bool bool_2;

	private bool bool_3;

	private int int_0;

	private int int_1;

	private Message[] message_0;

	private Color color_0;

	private bool bool_4;

	private bool bool_5;

	private int int_2;

	private bool bool_6;

	private Color color_1;

	private FormBorderStyle formBorderStyle_0;

	private bool bool_7;

	private Image image_0;

	private Size size_0;

	private bool bool_8;

	private int int_3;

	private int int_4;

	private Dictionary<string, Color> dictionary_0;

	private string string_0;

	private Point point_1;

	private Bitmap bitmap_0;

	private Graphics graphics_1;

	private SolidBrush solidBrush_0;

	private Point point_2;

	private Size size_1;

	private Point point_3;

	private LinearGradientBrush linearGradientBrush_0;

	private Rectangle rectangle_1;

	public override Color BackColor
	{
		get
		{
			return ((Control)this).get_BackColor();
		}
		set
		{
			if (1 == 0)
			{
			}
			if (((Control)this).get_IsHandleCreated())
			{
				if (!bool_6)
				{
					((Control)this).get_Parent().set_BackColor(value);
				}
				((Control)this).set_BackColor(value);
			}
			else
			{
				color_0 = value;
			}
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
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

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
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

	public override string Text
	{
		get
		{
			return ((Control)this).get_Text();
		}
		set
		{
			((Control)this).set_Text(value);
			for (int num = 0; num == 0; num = 1)
			{
				((Control)this).Invalidate();
			}
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
			for (int num = 0; num == 0; num = 1)
			{
				((Control)this).Invalidate();
			}
		}
	}

	public bool Boolean_0
	{
		get
		{
			return bool_4;
		}
		set
		{
			bool_4 = value;
		}
	}

	public bool Boolean_1
	{
		get
		{
			return bool_5;
		}
		set
		{
			bool_5 = value;
		}
	}

	protected int Int32_0
	{
		get
		{
			return int_2;
		}
		set
		{
			if (value < 8)
			{
				return;
			}
			ref Rectangle reference = ref rectangle_0;
			reference = checked(new Rectangle(7, 7, ((Control)this).get_Width() - 14, value - 7));
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 1:
					((Control)this).Invalidate();
					num = 2;
					break;
				case 0:
					int_2 = value;
					num = 1;
					break;
				default:
					return;
				}
			}
		}
	}

	protected bool Boolean_2
	{
		get
		{
			return bool_6;
		}
		set
		{
			bool_6 = value;
		}
	}

	public Color Color_0
	{
		get
		{
			if (1 == 0)
			{
			}
			if (bool_8 && !bool_6)
			{
				return ((ContainerControl)this).get_ParentForm().get_TransparencyKey();
			}
			return color_1;
		}
		set
		{
			if (1 == 0)
			{
			}
			if (bool_8 && !bool_6)
			{
				((ContainerControl)this).get_ParentForm().set_TransparencyKey(value);
			}
			color_1 = value;
		}
	}

	public FormBorderStyle FormBorderStyle_0
	{
		get
		{
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			if (1 == 0)
			{
			}
			if (bool_8 && !bool_6)
			{
				return ((ContainerControl)this).get_ParentForm().get_FormBorderStyle();
			}
			return formBorderStyle_0;
		}
		set
		{
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			if (1 == 0)
			{
			}
			if (bool_8 && !bool_6)
			{
				((ContainerControl)this).get_ParentForm().set_FormBorderStyle(value);
			}
			formBorderStyle_0 = value;
		}
	}

	public bool Boolean_3
	{
		get
		{
			return bool_7;
		}
		set
		{
			bool_7 = value;
			for (int num = 0; num == 0; num = 1)
			{
				((Control)this).Invalidate();
			}
		}
	}

	public Image Image_0
	{
		get
		{
			return image_0;
		}
		set
		{
			int num;
			if (value == null)
			{
				size_0 = Size.Empty;
				num = 0;
				goto IL_0026;
			}
			size_0 = value.get_Size();
			goto IL_0035;
			IL_0035:
			image_0 = value;
			num = 1;
			goto IL_0026;
			IL_0026:
			while (true)
			{
				switch (num)
				{
				case 1:
					goto IL_001f;
				default:
					return;
				case 0:
					break;
				}
				break;
				IL_001f:
				((Control)this).Invalidate();
				num = 2;
			}
			goto IL_0035;
		}
	}

	protected Size Size_0 => size_0;

	protected bool Boolean_4 => bool_8;

	protected int Int32_1
	{
		get
		{
			return int_3;
		}
		set
		{
			if (1 == 0)
			{
			}
			int_3 = value;
			if (Int32_1 != 0 && ((Control)this).get_IsHandleCreated())
			{
				((Control)this).set_Width(Int32_1);
			}
		}
	}

	protected int Int32_2
	{
		get
		{
			return int_4;
		}
		set
		{
			if (1 == 0)
			{
			}
			int_4 = value;
			if (Int32_2 != 0 && ((Control)this).get_IsHandleCreated())
			{
				((Control)this).set_Height(Int32_2);
			}
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public GClass7[] GClass7_0
	{
		get
		{
			List<GClass7> list = new List<GClass7>();
			Dictionary<string, Color>.Enumerator enumerator = default(Dictionary<string, Color>.Enumerator);
			for (int num = 0; num == 0; num = 1)
			{
				enumerator = dictionary_0.GetEnumerator();
			}
			while (enumerator.MoveNext())
			{
				list.Add(new GClass7(enumerator.Current.Key, enumerator.Current.Value));
			}
			return list.ToArray();
		}
		set
		{
			int num = 0;
			GClass7 gClass = default(GClass7);
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				case 4:
					((Control)this).Invalidate();
					num = 5;
					break;
				case 3:
					vmethod_1();
					num = 4;
					break;
				case 2:
					if (dictionary_0.ContainsKey(gClass.String_0))
					{
						dictionary_0[gClass.String_0] = gClass.Color_0;
					}
					num2 = checked(num2 + 1);
					goto case 1;
				case 1:
					if (num2 >= value.Length)
					{
						method_9();
						num = 3;
					}
					else
					{
						gClass = value[num2];
						num = 2;
					}
					break;
				case 0:
					num2 = 0;
					num = 1;
					break;
				default:
					return;
				}
			}
		}
	}

	public string String_0
	{
		get
		{
			return string_0;
		}
		set
		{
			if (Operators.CompareString(value, string_0, false) == 0)
			{
				return;
			}
			GClass7[] gClass7_ = GClass7_0;
			checked
			{
				try
				{
					byte[] value2 = Convert.FromBase64String(value);
					int num = 0;
					int num2 = default(int);
					int num3 = default(int);
					while (true)
					{
						switch (num)
						{
						case 1:
							if (num2 <= num3)
							{
								gClass7_[num2].Color_0 = Color.FromArgb(BitConverter.ToInt32(value2, num2 * 4));
								num = 2;
								break;
							}
							goto end_IL_0054;
						case 0:
							num3 = gClass7_.Length - 1;
							num2 = 0;
							num = 1;
							break;
						default:
							num2++;
							goto case 1;
						}
						continue;
						end_IL_0054:
						break;
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					for (int num4 = 0; num4 == 0; num4 = 1)
					{
						ProjectData.ClearProjectError();
					}
					return;
				}
				string_0 = value;
				int num5 = 0;
				while (true)
				{
					switch (num5)
					{
					case 1:
						vmethod_1();
						num5 = 2;
						break;
					case 0:
						GClass7_0 = gClass7_;
						num5 = 1;
						break;
					default:
						((Control)this).Invalidate();
						return;
					}
				}
			}
		}
	}

	public GControl14()
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		if (1 == 0)
		{
		}
		((ContainerControl)this)._002Ector();
		message_0 = (Message[])(object)new Message[9];
		bool_4 = true;
		bool_5 = true;
		int_2 = 24;
		dictionary_0 = new Dictionary<string, Color>();
		((Control)this).SetStyle((ControlStyles)139270, true);
		size_0 = Size.Empty;
		bitmap_0 = new Bitmap(1, 1);
		graphics_1 = Graphics.FromImage((Image)(object)bitmap_0);
		Font = new Font("Verdana", 8f);
		method_9();
	}

	protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		if (1 == 0)
		{
		}
		if (int_3 != 0)
		{
			width = int_3;
		}
		if (int_4 != 0)
		{
			height = int_4;
		}
		((Control)this).SetBoundsCore(x, y, width, height, specified);
	}

	protected sealed override void OnSizeChanged(EventArgs e)
	{
		((Control)this).OnSizeChanged(e);
		for (int num = 0; num == 0; num = 1)
		{
			if (bool_4 && !bool_6)
			{
				ref Rectangle reference = ref rectangle_0;
				reference = checked(new Rectangle(7, 7, ((Control)this).get_Width() - 14, int_2 - 7));
			}
			((Control)this).Invalidate();
		}
	}

	protected sealed override void OnPaint(PaintEventArgs e)
	{
		if (1 == 0)
		{
		}
		if (((Control)this).get_Width() != 0 && ((Control)this).get_Height() != 0)
		{
			graphics_0 = e.get_Graphics();
			vmethod_2();
		}
	}

	protected sealed override void OnHandleCreated(EventArgs e)
	{
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		method_3();
		int num = 0;
		Color color = default(Color);
		while (true)
		{
			switch (num)
			{
			case 5:
				((Control)this).OnHandleCreated(e);
				num = 6;
				break;
			case 4:
				((ContainerControl)this).get_ParentForm().set_TransparencyKey(color_1);
				goto IL_002a;
			case 3:
				if (!bool_6)
				{
					((Control)this).set_Dock((DockStyle)5);
				}
				if (int_3 != 0)
				{
					((Control)this).set_Width(int_3);
				}
				if (int_4 != 0)
				{
					((Control)this).set_Height(int_4);
				}
				if (!(color_0 == color))
				{
					BackColor = color_0;
				}
				if (bool_8 && !bool_6)
				{
					((ContainerControl)this).get_ParentForm().set_FormBorderStyle(formBorderStyle_0);
					num = 4;
					break;
				}
				goto IL_002a;
			case 2:
				bool_8 = ((Control)this).get_Parent() is Form;
				num = 3;
				break;
			case 1:
				vmethod_1();
				num = 2;
				break;
			case 0:
				method_9();
				num = 1;
				break;
			default:
				return;
				IL_002a:
				vmethod_0();
				num = 5;
				break;
			}
		}
	}

	protected virtual void vmethod_0()
	{
	}

	private void method_0(GEnum1 genum1_1)
	{
		genum1_0 = genum1_1;
		for (int num = 0; num == 0; num = 1)
		{
			((Control)this).Invalidate();
		}
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		if (1 == 0)
		{
		}
		if (bool_5 && !bool_6)
		{
			method_2();
		}
		((Control)this).OnMouseMove(e);
	}

	protected override void OnEnabledChanged(EventArgs e)
	{
		int num;
		if (((Control)this).get_Enabled())
		{
			method_0(GEnum1.const_0);
			num = 0;
			goto IL_001b;
		}
		method_0(GEnum1.const_3);
		goto IL_001d;
		IL_001d:
		((Control)this).OnEnabledChanged(e);
		num = 1;
		goto IL_001b;
		IL_001b:
		if (num != 0)
		{
			return;
		}
		goto IL_001d;
	}

	protected override void OnMouseEnter(EventArgs e)
	{
		method_0(GEnum1.const_1);
		for (int num = 0; num == 0; num = 1)
		{
			((Control)this).OnMouseEnter(e);
		}
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		method_0(GEnum1.const_1);
		for (int num = 0; num == 0; num = 1)
		{
			((Control)this).OnMouseUp(e);
		}
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		method_0(GEnum1.const_0);
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 1:
				int_1 = 0;
				goto IL_0011;
			case 0:
				if (bool_5 && !bool_6 && ((Control)this).GetChildAtPoint(((Control)this).PointToClient(Control.get_MousePosition())) != null)
				{
					((Control)this).set_Cursor(Cursors.get_Default());
					num = 1;
					break;
				}
				goto IL_0011;
			default:
				return;
				IL_0011:
				((Control)this).OnMouseLeave(e);
				num = 2;
				break;
			}
		}
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Invalid comparison between Unknown and I4
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Invalid comparison between Unknown and I4
		((Control)this).OnMouseDown(e);
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 2:
				((Control)this).DefWndProc(ref message_0[0]);
				num = 3;
				break;
			case 1:
				if ((bool_8 && (int)((ContainerControl)this).get_ParentForm().get_WindowState() == 2) || bool_6)
				{
					return;
				}
				if (bool_4 && rectangle_0.Contains(e.get_Location()))
				{
					((Control)this).set_Capture(false);
					num = 2;
					break;
				}
				if (bool_5 && int_1 != 0)
				{
					((Control)this).set_Capture(false);
					num = 4;
					break;
				}
				return;
			case 0:
				if ((int)e.get_Button() != 1048576)
				{
					return;
				}
				method_0(GEnum1.const_2);
				num = 1;
				break;
			default:
				((Control)this).DefWndProc(ref message_0[int_1]);
				return;
			case 3:
				return;
			}
		}
	}

	private int method_1()
	{
		point_0 = ((Control)this).PointToClient(Control.get_MousePosition());
		int num = 0;
		checked
		{
			while (true)
			{
				switch (num)
				{
				case 3:
					bool_3 = point_0.Y > ((Control)this).get_Height() - 7;
					num = 4;
					continue;
				case 2:
					bool_2 = point_0.Y < 7;
					num = 3;
					continue;
				case 1:
					bool_1 = point_0.X > ((Control)this).get_Width() - 7;
					num = 2;
					continue;
				case 0:
					bool_0 = point_0.X < 7;
					num = 1;
					continue;
				}
				if (bool_0 && bool_2)
				{
					return 4;
				}
				if (bool_0 && bool_3)
				{
					return 7;
				}
				if (bool_1 && bool_2)
				{
					return 5;
				}
				if (bool_1 && bool_3)
				{
					return 8;
				}
				if (bool_0)
				{
					return 1;
				}
				if (bool_1)
				{
					return 2;
				}
				if (bool_2)
				{
					return 3;
				}
				if (bool_3)
				{
					return 6;
				}
				return 0;
			}
		}
	}

	private void method_2()
	{
		int_0 = method_1();
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 1:
				switch (int_1)
				{
				default:
					return;
				case 0:
					((Control)this).set_Cursor(Cursors.get_Default());
					num = 2;
					break;
				case 1:
				case 2:
					((Control)this).set_Cursor(Cursors.get_SizeWE());
					num = 3;
					break;
				case 3:
				case 6:
					((Control)this).set_Cursor(Cursors.get_SizeNS());
					num = 4;
					break;
				case 4:
				case 8:
					((Control)this).set_Cursor(Cursors.get_SizeNWSE());
					num = 5;
					break;
				case 5:
				case 7:
					((Control)this).set_Cursor(Cursors.get_SizeNESW());
					return;
				}
				break;
			case 0:
				if (int_0 == int_1)
				{
					return;
				}
				int_1 = int_0;
				num = 1;
				break;
			default:
				return;
			case 2:
			case 3:
			case 4:
				return;
			}
		}
	}

	private void method_3()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		ref Message reference = ref message_0[0];
		IntPtr handle = ((Control)this).get_Parent().get_Handle();
		IntPtr intPtr = new IntPtr(2);
		reference = Message.Create(handle, 161, intPtr, IntPtr.Zero);
		int num = 0;
		checked
		{
			int num2 = default(int);
			while (true)
			{
				ref Message reference2;
				IntPtr handle2;
				switch (num)
				{
				case 1:
					num2++;
					num = 2;
					break;
				case 0:
					num2 = 1;
					goto IL_0040;
				default:
					{
						if (num2 > 8)
						{
							return;
						}
						goto IL_0040;
					}
					IL_0040:
					reference2 = ref message_0[num2];
					handle2 = ((Control)this).get_Parent().get_Handle();
					intPtr = new IntPtr(num2 + 9);
					reference2 = Message.Create(handle2, 161, intPtr, IntPtr.Zero);
					num = 1;
					break;
				}
			}
		}
	}

	protected Color method_4(string string_1)
	{
		return dictionary_0[string_1];
	}

	protected void method_5(string string_1, Color color_2)
	{
		if (1 == 0)
		{
		}
		if (dictionary_0.ContainsKey(string_1))
		{
			dictionary_0[string_1] = color_2;
		}
		else
		{
			dictionary_0.Add(string_1, color_2);
		}
	}

	protected void method_6(string string_1, byte byte_0, byte byte_1, byte byte_2)
	{
		if (1 == 0)
		{
		}
		method_5(string_1, Color.FromArgb(byte_0, byte_1, byte_2));
	}

	protected void method_7(string string_1, byte byte_0, byte byte_1, byte byte_2, byte byte_3)
	{
		if (1 == 0)
		{
		}
		method_5(string_1, Color.FromArgb(byte_0, byte_1, byte_2, byte_3));
	}

	protected void method_8(string string_1, byte byte_0, Color color_2)
	{
		if (1 == 0)
		{
		}
		method_5(string_1, Color.FromArgb(byte_0, color_2));
	}

	private void method_9()
	{
		checked
		{
			MemoryStream memoryStream = new MemoryStream(dictionary_0.Count * 4);
			int num = 0;
			int num2 = default(int);
			GClass7[] gClass7_ = default(GClass7[]);
			GClass7 gClass = default(GClass7);
			while (true)
			{
				switch (num)
				{
				case 5:
					string_0 = Convert.ToBase64String(memoryStream.ToArray());
					num = 6;
					break;
				case 4:
					num2++;
					goto case 2;
				case 2:
					if (num2 >= gClass7_.Length)
					{
						memoryStream.Close();
						num = 5;
					}
					else
					{
						gClass = gClass7_[num2];
						num = 3;
					}
					break;
				case 3:
					memoryStream.Write(BitConverter.GetBytes(gClass.Color_0.ToArgb()), 0, 4);
					num = 4;
					break;
				case 1:
					num2 = 0;
					num = 2;
					break;
				case 0:
					gClass7_ = GClass7_0;
					num = 1;
					break;
				default:
					return;
				}
			}
		}
	}

	protected abstract void vmethod_1();

	protected abstract void vmethod_2();

	protected Point method_10(Rectangle rectangle_2, Size size_2)
	{
		if (1 == 0)
		{
		}
		ref Point reference = ref point_1;
		checked
		{
			reference = new Point(unchecked(rectangle_2.Width / 2) - unchecked(size_2.Width / 2) + rectangle_2.X, unchecked(rectangle_2.Height / 2) - unchecked(size_2.Height / 2) + rectangle_2.Y);
			return point_1;
		}
	}

	protected Point method_11(Rectangle rectangle_2, Rectangle rectangle_3)
	{
		if (1 == 0)
		{
		}
		return method_10(rectangle_2, rectangle_3.Size);
	}

	protected Point method_12(int int_5, int int_6, int int_7, int int_8)
	{
		if (1 == 0)
		{
		}
		ref Point reference = ref point_1;
		checked
		{
			reference = new Point(unchecked(int_5 / 2) - unchecked(int_7 / 2), unchecked(int_6 / 2) - unchecked(int_8 / 2));
			return point_1;
		}
	}

	protected Point method_13(Size size_2, Size size_3)
	{
		if (1 == 0)
		{
		}
		return method_12(size_2.Width, size_2.Height, size_3.Width, size_3.Height);
	}

	protected Point method_14(Rectangle rectangle_2)
	{
		if (1 == 0)
		{
		}
		return method_12(((Control)this).get_ClientRectangle().Width, ((Control)this).get_ClientRectangle().Height, rectangle_2.Width, rectangle_2.Height);
	}

	protected Point method_15(Size size_2)
	{
		if (1 == 0)
		{
		}
		return method_12(((Control)this).get_Width(), ((Control)this).get_Height(), size_2.Width, size_2.Height);
	}

	protected Point method_16(int int_5, int int_6)
	{
		if (1 == 0)
		{
		}
		return method_12(((Control)this).get_Width(), ((Control)this).get_Height(), int_5, int_6);
	}

	protected Size method_17(string string_1)
	{
		if (1 == 0)
		{
		}
		return graphics_1.MeasureString(string_1, Font, ((Control)this).get_Width()).ToSize();
	}

	protected Size method_18()
	{
		if (1 == 0)
		{
		}
		return graphics_1.MeasureString(Text, Font).ToSize();
	}

	protected void method_19(Color color_2)
	{
		if (1 == 0)
		{
		}
		method_21(color_2, 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
	}

	protected void method_20(Color color_2, Rectangle rectangle_2)
	{
		if (1 == 0)
		{
		}
		method_21(color_2, rectangle_2.X, rectangle_2.Y, rectangle_2.Width, rectangle_2.Height);
	}

	protected void method_21(Color color_2, int int_5, int int_6, int int_7, int int_8)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		if (bool_7)
		{
			return;
		}
		solidBrush_0 = new SolidBrush(color_2);
		int num = 0;
		checked
		{
			while (true)
			{
				switch (num)
				{
				case 3:
					graphics_0.FillRectangle((Brush)(object)solidBrush_0, int_5 + (int_7 - 1), int_6 + (int_8 - 1), 1, 1);
					num = 4;
					break;
				case 2:
					graphics_0.FillRectangle((Brush)(object)solidBrush_0, int_5, int_6 + (int_8 - 1), 1, 1);
					num = 3;
					break;
				case 1:
					graphics_0.FillRectangle((Brush)(object)solidBrush_0, int_5 + (int_7 - 1), int_6, 1, 1);
					num = 2;
					break;
				case 0:
					graphics_0.FillRectangle((Brush)(object)solidBrush_0, int_5, int_6, 1, 1);
					num = 1;
					break;
				default:
					return;
				}
			}
		}
	}

	protected void method_22(Pen pen_0, int int_5, int int_6, int int_7, int int_8, int int_9)
	{
		if (1 == 0)
		{
		}
		checked
		{
			method_25(pen_0, int_5 + int_9, int_6 + int_9, int_7 - int_9 * 2, int_8 - int_9 * 2);
		}
	}

	protected void method_23(Pen pen_0, int int_5)
	{
		if (1 == 0)
		{
		}
		method_22(pen_0, 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height(), int_5);
	}

	protected void method_24(Pen pen_0, Rectangle rectangle_2, int int_5)
	{
		if (1 == 0)
		{
		}
		method_22(pen_0, rectangle_2.X, rectangle_2.Y, rectangle_2.Width, rectangle_2.Height, int_5);
	}

	protected void method_25(Pen pen_0, int int_5, int int_6, int int_7, int int_8)
	{
		if (1 == 0)
		{
		}
		checked
		{
			graphics_0.DrawRectangle(pen_0, int_5, int_6, int_7 - 1, int_8 - 1);
		}
	}

	protected void method_26(Pen pen_0)
	{
		if (1 == 0)
		{
		}
		method_25(pen_0, 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
	}

	protected void method_27(Pen pen_0, Rectangle rectangle_2)
	{
		if (1 == 0)
		{
		}
		method_25(pen_0, rectangle_2.X, rectangle_2.Y, rectangle_2.Width, rectangle_2.Height);
	}

	protected void method_28(Brush brush_0, HorizontalAlignment horizontalAlignment_0, int int_5, int int_6)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (1 == 0)
		{
		}
		method_31(brush_0, Text, horizontalAlignment_0, int_5, int_6);
	}

	protected void method_29(Brush brush_0, Point point_4)
	{
		if (1 == 0)
		{
		}
		method_33(brush_0, Text, point_4.X, point_4.Y);
	}

	protected void method_30(Brush brush_0, int int_5, int int_6)
	{
		if (1 == 0)
		{
		}
		method_33(brush_0, Text, int_5, int_6);
	}

	protected void method_31(Brush brush_0, string string_1, HorizontalAlignment horizontalAlignment_0, int int_5, int int_6)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected I4, but got Unknown
		if (string_1.Length == 0)
		{
			return;
		}
		size_1 = method_17(string_1);
		int num = 0;
		checked
		{
			while (true)
			{
				switch (num)
				{
				case 1:
					switch (unchecked((int)horizontalAlignment_0))
					{
					default:
						return;
					case 0:
						method_33(brush_0, string_1, int_5, point_2.Y + int_6);
						num = 2;
						break;
					case 2:
						method_33(brush_0, string_1, point_2.X + int_5, point_2.Y + int_6);
						num = 3;
						break;
					case 1:
						method_33(brush_0, string_1, ((Control)this).get_Width() - size_1.Width - int_5, point_2.Y + int_6);
						return;
					}
					break;
				case 0:
				{
					ref Point reference = ref point_2;
					reference = new Point(unchecked(((Control)this).get_Width() / 2) - unchecked(size_1.Width / 2), unchecked(Int32_0 / 2) - unchecked(size_1.Height / 2));
					num = 1;
					break;
				}
				default:
					return;
				case 2:
					return;
				}
			}
		}
	}

	protected void method_32(Brush brush_0, string string_1, Point point_4)
	{
		if (1 == 0)
		{
		}
		method_33(brush_0, string_1, point_4.X, point_4.Y);
	}

	protected void method_33(Brush brush_0, string string_1, int int_5, int int_6)
	{
		if (1 == 0)
		{
		}
		if (string_1.Length != 0)
		{
			graphics_0.DrawString(string_1, Font, brush_0, (float)int_5, (float)int_6);
		}
	}

	protected void method_34(HorizontalAlignment horizontalAlignment_0, int int_5, int int_6)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		if (1 == 0)
		{
		}
		method_37(image_0, horizontalAlignment_0, int_5, int_6);
	}

	protected void method_35(Point point_4)
	{
		if (1 == 0)
		{
		}
		method_39(image_0, point_4.X, point_4.Y);
	}

	protected void method_36(int int_5, int int_6)
	{
		if (1 == 0)
		{
		}
		method_39(image_0, int_5, int_6);
	}

	protected void method_37(Image image_1, HorizontalAlignment horizontalAlignment_0, int int_5, int int_6)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected I4, but got Unknown
		if (image_1 == null)
		{
			return;
		}
		ref Point reference = ref point_3;
		checked
		{
			reference = new Point(unchecked(((Control)this).get_Width() / 2) - unchecked(image_1.get_Width() / 2), unchecked(Int32_0 / 2) - unchecked(image_1.get_Height() / 2));
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 0:
					switch (unchecked((int)horizontalAlignment_0))
					{
					default:
						return;
					case 0:
						method_39(image_1, int_5, point_3.Y + int_6);
						num = 1;
						break;
					case 2:
						method_39(image_1, point_3.X + int_5, point_3.Y + int_6);
						num = 2;
						break;
					case 1:
						method_39(image_1, ((Control)this).get_Width() - image_1.get_Width() - int_5, point_3.Y + int_6);
						return;
					}
					break;
				default:
					return;
				case 1:
					return;
				}
			}
		}
	}

	protected void method_38(Image image_1, Point point_4)
	{
		if (1 == 0)
		{
		}
		method_39(image_1, point_4.X, point_4.Y);
	}

	protected void method_39(Image image_1, int int_5, int int_6)
	{
		if (1 == 0)
		{
		}
		if (image_1 != null)
		{
			graphics_0.DrawImage(image_1, int_5, int_6, image_1.get_Width(), image_1.get_Height());
		}
	}

	protected void method_40(ColorBlend colorBlend_0, int int_5, int int_6, int int_7, int int_8)
	{
		if (1 == 0)
		{
		}
		method_42(colorBlend_0, int_5, int_6, int_7, int_8, 90f);
	}

	protected void method_41(Color color_2, Color color_3, int int_5, int int_6, int int_7, int int_8)
	{
		if (1 == 0)
		{
		}
		method_43(color_2, color_3, int_5, int_6, int_7, int_8, 90f);
	}

	protected void method_42(ColorBlend colorBlend_0, int int_5, int int_6, int int_7, int int_8, float float_0)
	{
		ref Rectangle reference = ref rectangle_1;
		reference = new Rectangle(int_5, int_6, int_7, int_8);
		for (int num = 0; num == 0; num = 1)
		{
			method_44(colorBlend_0, rectangle_1, float_0);
		}
	}

	protected void method_43(Color color_2, Color color_3, int int_5, int int_6, int int_7, int int_8, float float_0)
	{
		ref Rectangle reference = ref rectangle_1;
		reference = new Rectangle(int_5, int_6, int_7, int_8);
		for (int num = 0; num == 0; num = 1)
		{
			method_45(color_2, color_3, rectangle_1, float_0);
		}
	}

	protected void method_44(ColorBlend colorBlend_0, Rectangle rectangle_2, float float_0)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		linearGradientBrush_0 = new LinearGradientBrush(rectangle_2, Color.Empty, Color.Empty, float_0);
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 1:
				graphics_0.FillRectangle((Brush)(object)linearGradientBrush_0, rectangle_2);
				num = 2;
				break;
			case 0:
				linearGradientBrush_0.set_InterpolationColors(colorBlend_0);
				num = 1;
				break;
			default:
				return;
			}
		}
	}

	protected void method_45(Color color_2, Color color_3, Rectangle rectangle_2, float float_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		linearGradientBrush_0 = new LinearGradientBrush(rectangle_2, color_2, color_3, float_0);
		for (int num = 0; num == 0; num = 1)
		{
			graphics_0.FillRectangle((Brush)(object)linearGradientBrush_0, rectangle_2);
		}
	}
}
