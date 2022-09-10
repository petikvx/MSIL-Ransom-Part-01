using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

public abstract class GControl17 : Control
{
	protected Graphics graphics_0;

	protected Bitmap bitmap_0;

	protected GEnum1 genum1_0;

	private Color color_0;

	private bool bool_0;

	private Image image_0;

	private Size size_0;

	private int int_0;

	private int int_1;

	private bool bool_1;

	private Dictionary<string, Color> dictionary_0;

	private string string_0;

	private Point point_0;

	private Bitmap bitmap_1;

	private Graphics graphics_1;

	private SolidBrush solidBrush_0;

	private Point point_1;

	private Size size_1;

	private Point point_2;

	private LinearGradientBrush linearGradientBrush_0;

	private Rectangle rectangle_0;

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
			return bool_0;
		}
		set
		{
			bool_0 = value;
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

	protected int Int32_0
	{
		get
		{
			return int_0;
		}
		set
		{
			if (1 == 0)
			{
			}
			int_0 = value;
			if (Int32_0 != 0 && ((Control)this).get_IsHandleCreated())
			{
				((Control)this).set_Width(Int32_0);
			}
		}
	}

	protected int Int32_1
	{
		get
		{
			return int_1;
		}
		set
		{
			if (1 == 0)
			{
			}
			int_1 = value;
			if (Int32_1 != 0 && ((Control)this).get_IsHandleCreated())
			{
				((Control)this).set_Height(Int32_1);
			}
		}
	}

	public bool Boolean_1
	{
		get
		{
			return bool_1;
		}
		set
		{
			Color backColor = default(Color);
			int num;
			if (!value)
			{
				backColor = BackColor;
				num = 0;
				goto IL_0042;
			}
			goto IL_006d;
			IL_0042:
			while (true)
			{
				switch (num)
				{
				case 4:
					((Control)this).Invalidate();
					num = 5;
					continue;
				case 3:
					bool_1 = value;
					num = 4;
					continue;
				case 2:
					if (value)
					{
						method_1();
						num = 3;
						continue;
					}
					bitmap_0 = null;
					goto case 3;
				case 1:
					((Control)this).SetStyle((ControlStyles)2048, value);
					num = 2;
					continue;
				default:
					return;
				case 0:
					break;
				}
				break;
			}
			if (backColor.A != byte.MaxValue)
			{
				throw new Exception("Unable to change value to false while a transparent BackColor is in use.");
			}
			goto IL_006d;
			IL_006d:
			((Control)this).SetStyle((ControlStyles)4, !value);
			num = 1;
			goto IL_0042;
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
						method_7();
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

	public GControl17()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		if (1 == 0)
		{
		}
		((Control)this)._002Ector();
		dictionary_0 = new Dictionary<string, Color>();
		((Control)this).SetStyle((ControlStyles)139270, true);
		size_0 = Size.Empty;
		bitmap_1 = new Bitmap(1, 1);
		graphics_1 = Graphics.FromImage((Image)(object)bitmap_1);
		Font = new Font("Verdana", 8f);
		method_7();
	}

	protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		if (1 == 0)
		{
		}
		if (int_0 != 0)
		{
			width = int_0;
		}
		if (int_1 != 0)
		{
			height = int_1;
		}
		((Control)this).SetBoundsCore(x, y, width, height, specified);
	}

	protected sealed override void OnSizeChanged(EventArgs e)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		int num;
		if (bool_1 && ((Control)this).get_Width() != 0 && ((Control)this).get_Height() != 0)
		{
			bitmap_0 = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
			num = 0;
			goto IL_003c;
		}
		goto IL_005c;
		IL_003c:
		while (true)
		{
			switch (num)
			{
			case 1:
				goto IL_0034;
			default:
				return;
			case 0:
				break;
			}
			break;
			IL_0034:
			((Control)this).OnSizeChanged(e);
			num = 2;
		}
		graphics_0 = Graphics.FromImage((Image)(object)bitmap_0);
		goto IL_005c;
		IL_005c:
		((Control)this).Invalidate();
		num = 1;
		goto IL_003c;
	}

	protected sealed override void OnPaint(PaintEventArgs e)
	{
		if (((Control)this).get_Width() == 0 || ((Control)this).get_Height() == 0)
		{
			return;
		}
		int num;
		if (bool_1)
		{
			vmethod_2();
			num = 0;
		}
		else
		{
			graphics_0 = e.get_Graphics();
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			case 0:
				break;
			default:
				vmethod_2();
				return;
			case 1:
				return;
			}
			e.get_Graphics().DrawImage((Image)(object)bitmap_0, 0, 0);
			num = 1;
		}
	}

	protected override void OnHandleCreated(EventArgs e)
	{
		method_7();
		int num = 0;
		Color color = default(Color);
		while (true)
		{
			switch (num)
			{
			case 2:
				((Control)this).OnHandleCreated(e);
				num = 3;
				break;
			case 1:
				if (int_0 != 0)
				{
					((Control)this).set_Width(int_0);
				}
				if (int_1 != 0)
				{
					((Control)this).set_Height(int_1);
				}
				if (!(color_0 == color))
				{
					BackColor = color_0;
				}
				vmethod_0();
				num = 2;
				break;
			case 0:
				vmethod_1();
				num = 1;
				break;
			default:
				return;
			}
		}
	}

	protected virtual void vmethod_0()
	{
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

	protected override void OnMouseDown(MouseEventArgs e)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Invalid comparison between Unknown and I4
		if (1 == 0)
		{
		}
		if ((int)e.get_Button() == 1048576)
		{
			method_0(GEnum1.const_2);
		}
		((Control)this).OnMouseDown(e);
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		method_0(GEnum1.const_0);
		for (int num = 0; num == 0; num = 1)
		{
			((Control)this).OnMouseLeave(e);
		}
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

	private void method_0(GEnum1 genum1_1)
	{
		genum1_0 = genum1_1;
		for (int num = 0; num == 0; num = 1)
		{
			((Control)this).Invalidate();
		}
	}

	private void method_1()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		if (1 == 0)
		{
		}
		if (((Control)this).get_Width() != 0 && ((Control)this).get_Height() != 0)
		{
			bitmap_0 = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
			graphics_0 = Graphics.FromImage((Image)(object)bitmap_0);
		}
	}

	protected Color method_2(string string_1)
	{
		return dictionary_0[string_1];
	}

	protected void method_3(string string_1, Color color_1)
	{
		if (1 == 0)
		{
		}
		if (dictionary_0.ContainsKey(string_1))
		{
			dictionary_0[string_1] = color_1;
		}
		else
		{
			dictionary_0.Add(string_1, color_1);
		}
	}

	protected void method_4(string string_1, byte byte_0, byte byte_1, byte byte_2)
	{
		if (1 == 0)
		{
		}
		method_3(string_1, Color.FromArgb(byte_0, byte_1, byte_2));
	}

	protected void method_5(string string_1, byte byte_0, byte byte_1, byte byte_2, byte byte_3)
	{
		if (1 == 0)
		{
		}
		method_3(string_1, Color.FromArgb(byte_0, byte_1, byte_2, byte_3));
	}

	protected void method_6(string string_1, byte byte_0, Color color_1)
	{
		if (1 == 0)
		{
		}
		method_3(string_1, Color.FromArgb(byte_0, color_1));
	}

	private void method_7()
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

	protected Point method_8(Rectangle rectangle_1, Size size_2)
	{
		if (1 == 0)
		{
		}
		ref Point reference = ref point_0;
		checked
		{
			reference = new Point(unchecked(rectangle_1.Width / 2) - unchecked(size_2.Width / 2) + rectangle_1.X, unchecked(rectangle_1.Height / 2) - unchecked(size_2.Height / 2) + rectangle_1.Y);
			return point_0;
		}
	}

	protected Point method_9(Rectangle rectangle_1, Rectangle rectangle_2)
	{
		if (1 == 0)
		{
		}
		return method_8(rectangle_1, rectangle_2.Size);
	}

	protected Point method_10(int int_2, int int_3, int int_4, int int_5)
	{
		if (1 == 0)
		{
		}
		ref Point reference = ref point_0;
		checked
		{
			reference = new Point(unchecked(int_2 / 2) - unchecked(int_4 / 2), unchecked(int_3 / 2) - unchecked(int_5 / 2));
			return point_0;
		}
	}

	protected Point method_11(Size size_2, Size size_3)
	{
		if (1 == 0)
		{
		}
		return method_10(size_2.Width, size_2.Height, size_3.Width, size_3.Height);
	}

	protected Point method_12(Rectangle rectangle_1)
	{
		if (1 == 0)
		{
		}
		return method_10(((Control)this).get_ClientRectangle().Width, ((Control)this).get_ClientRectangle().Height, rectangle_1.Width, rectangle_1.Height);
	}

	protected Point method_13(Size size_2)
	{
		if (1 == 0)
		{
		}
		return method_10(((Control)this).get_Width(), ((Control)this).get_Height(), size_2.Width, size_2.Height);
	}

	protected Point method_14(int int_2, int int_3)
	{
		if (1 == 0)
		{
		}
		return method_10(((Control)this).get_Width(), ((Control)this).get_Height(), int_2, int_3);
	}

	protected Size method_15(string string_1)
	{
		if (1 == 0)
		{
		}
		return graphics_1.MeasureString(string_1, Font, ((Control)this).get_Width()).ToSize();
	}

	protected Size method_16()
	{
		if (1 == 0)
		{
		}
		return graphics_1.MeasureString(Text, Font, ((Control)this).get_Width()).ToSize();
	}

	protected void method_17(Color color_1)
	{
		if (1 == 0)
		{
		}
		method_19(color_1, 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
	}

	protected void method_18(Color color_1, Rectangle rectangle_1)
	{
		if (1 == 0)
		{
		}
		method_19(color_1, rectangle_1.X, rectangle_1.Y, rectangle_1.Width, rectangle_1.Height);
	}

	protected void method_19(Color color_1, int int_2, int int_3, int int_4, int int_5)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (bool_0)
		{
			return;
		}
		int num;
		if (bool_1)
		{
			bitmap_0.SetPixel(int_2, int_3, color_1);
			num = 0;
		}
		else
		{
			solidBrush_0 = new SolidBrush(color_1);
			num = 4;
		}
		checked
		{
			while (true)
			{
				switch (num)
				{
				case 6:
					graphics_0.FillRectangle((Brush)(object)solidBrush_0, int_2, int_3 + (int_5 - 1), 1, 1);
					num = 7;
					break;
				case 5:
					graphics_0.FillRectangle((Brush)(object)solidBrush_0, int_2 + (int_4 - 1), int_3, 1, 1);
					num = 6;
					break;
				case 4:
					graphics_0.FillRectangle((Brush)(object)solidBrush_0, int_2, int_3, 1, 1);
					num = 5;
					break;
				case 2:
					bitmap_0.SetPixel(int_2 + (int_4 - 1), int_3 + (int_5 - 1), color_1);
					num = 3;
					break;
				case 1:
					bitmap_0.SetPixel(int_2, int_3 + (int_5 - 1), color_1);
					num = 2;
					break;
				case 0:
					bitmap_0.SetPixel(int_2 + (int_4 - 1), int_3, color_1);
					num = 1;
					break;
				default:
					graphics_0.FillRectangle((Brush)(object)solidBrush_0, int_2 + (int_4 - 1), int_3 + (int_5 - 1), 1, 1);
					return;
				case 3:
					return;
				}
			}
		}
	}

	protected void method_20(Pen pen_0, int int_2, int int_3, int int_4, int int_5, int int_6)
	{
		if (1 == 0)
		{
		}
		checked
		{
			method_23(pen_0, int_2 + int_6, int_3 + int_6, int_4 - int_6 * 2, int_5 - int_6 * 2);
		}
	}

	protected void method_21(Pen pen_0, int int_2)
	{
		if (1 == 0)
		{
		}
		method_20(pen_0, 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height(), int_2);
	}

	protected void method_22(Pen pen_0, Rectangle rectangle_1, int int_2)
	{
		if (1 == 0)
		{
		}
		method_20(pen_0, rectangle_1.X, rectangle_1.Y, rectangle_1.Width, rectangle_1.Height, int_2);
	}

	protected void method_23(Pen pen_0, int int_2, int int_3, int int_4, int int_5)
	{
		if (1 == 0)
		{
		}
		checked
		{
			graphics_0.DrawRectangle(pen_0, int_2, int_3, int_4 - 1, int_5 - 1);
		}
	}

	protected void method_24(Pen pen_0)
	{
		if (1 == 0)
		{
		}
		method_23(pen_0, 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
	}

	protected void method_25(Pen pen_0, Rectangle rectangle_1)
	{
		if (1 == 0)
		{
		}
		method_23(pen_0, rectangle_1.X, rectangle_1.Y, rectangle_1.Width, rectangle_1.Height);
	}

	protected void method_26(Brush brush_0, HorizontalAlignment horizontalAlignment_0, int int_2, int int_3)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (1 == 0)
		{
		}
		method_29(brush_0, Text, horizontalAlignment_0, int_2, int_3);
	}

	protected void method_27(Brush brush_0, Point point_3)
	{
		if (1 == 0)
		{
		}
		method_31(brush_0, Text, point_3.X, point_3.Y);
	}

	protected void method_28(Brush brush_0, int int_2, int int_3)
	{
		if (1 == 0)
		{
		}
		method_31(brush_0, Text, int_2, int_3);
	}

	protected void method_29(Brush brush_0, string string_1, HorizontalAlignment horizontalAlignment_0, int int_2, int int_3)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected I4, but got Unknown
		if (string_1.Length == 0)
		{
			return;
		}
		size_1 = method_15(string_1);
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
						method_31(brush_0, string_1, int_2, point_1.Y + int_3);
						num = 2;
						break;
					case 2:
						method_31(brush_0, string_1, point_1.X + int_2, point_1.Y + int_3);
						num = 3;
						break;
					case 1:
						method_31(brush_0, string_1, ((Control)this).get_Width() - size_1.Width - int_2, point_1.Y + int_3);
						return;
					}
					break;
				case 0:
					point_1 = method_13(size_1);
					num = 1;
					break;
				default:
					return;
				case 2:
					return;
				}
			}
		}
	}

	protected void method_30(Brush brush_0, string string_1, Point point_3)
	{
		if (1 == 0)
		{
		}
		method_31(brush_0, string_1, point_3.X, point_3.Y);
	}

	protected void method_31(Brush brush_0, string string_1, int int_2, int int_3)
	{
		if (1 == 0)
		{
		}
		if (string_1.Length != 0)
		{
			graphics_0.DrawString(string_1, Font, brush_0, (float)int_2, (float)int_3);
		}
	}

	protected void method_32(HorizontalAlignment horizontalAlignment_0, int int_2, int int_3)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		if (1 == 0)
		{
		}
		method_35(image_0, horizontalAlignment_0, int_2, int_3);
	}

	protected void method_33(Point point_3)
	{
		if (1 == 0)
		{
		}
		method_37(image_0, point_3.X, point_3.Y);
	}

	protected void method_34(int int_2, int int_3)
	{
		if (1 == 0)
		{
		}
		method_37(image_0, int_2, int_3);
	}

	protected void method_35(Image image_1, HorizontalAlignment horizontalAlignment_0, int int_2, int int_3)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected I4, but got Unknown
		if (image_1 == null)
		{
			return;
		}
		point_2 = method_13(image_1.get_Size());
		int num = 0;
		checked
		{
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
						method_37(image_1, int_2, point_2.Y + int_3);
						num = 1;
						break;
					case 2:
						method_37(image_1, point_2.X + int_2, point_2.Y + int_3);
						num = 2;
						break;
					case 1:
						method_37(image_1, ((Control)this).get_Width() - image_1.get_Width() - int_2, point_2.Y + int_3);
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

	protected void method_36(Image image_1, Point point_3)
	{
		if (1 == 0)
		{
		}
		method_37(image_1, point_3.X, point_3.Y);
	}

	protected void method_37(Image image_1, int int_2, int int_3)
	{
		if (1 == 0)
		{
		}
		if (image_1 != null)
		{
			graphics_0.DrawImage(image_1, int_2, int_3, image_1.get_Width(), image_1.get_Height());
		}
	}

	protected void method_38(ColorBlend colorBlend_0, int int_2, int int_3, int int_4, int int_5)
	{
		if (1 == 0)
		{
		}
		method_40(colorBlend_0, int_2, int_3, int_4, int_5, 90f);
	}

	protected void method_39(Color color_1, Color color_2, int int_2, int int_3, int int_4, int int_5)
	{
		if (1 == 0)
		{
		}
		method_41(color_1, color_2, int_2, int_3, int_4, int_5, 90f);
	}

	protected void method_40(ColorBlend colorBlend_0, int int_2, int int_3, int int_4, int int_5, float float_0)
	{
		ref Rectangle reference = ref rectangle_0;
		reference = new Rectangle(int_2, int_3, int_4, int_5);
		for (int num = 0; num == 0; num = 1)
		{
			method_42(colorBlend_0, rectangle_0, float_0);
		}
	}

	protected void method_41(Color color_1, Color color_2, int int_2, int int_3, int int_4, int int_5, float float_0)
	{
		ref Rectangle reference = ref rectangle_0;
		reference = new Rectangle(int_2, int_3, int_4, int_5);
		for (int num = 0; num == 0; num = 1)
		{
			method_43(color_1, color_2, rectangle_0, float_0);
		}
	}

	protected void method_42(ColorBlend colorBlend_0, Rectangle rectangle_1, float float_0)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		linearGradientBrush_0 = new LinearGradientBrush(rectangle_1, Color.Empty, Color.Empty, float_0);
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 1:
				graphics_0.FillRectangle((Brush)(object)linearGradientBrush_0, rectangle_1);
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

	protected void method_43(Color color_1, Color color_2, Rectangle rectangle_1, float float_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		linearGradientBrush_0 = new LinearGradientBrush(rectangle_1, color_1, color_2, float_0);
		for (int num = 0; num == 0; num = 1)
		{
			graphics_0.FillRectangle((Brush)(object)linearGradientBrush_0, rectangle_1);
		}
	}
}
