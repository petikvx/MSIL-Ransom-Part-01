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

internal abstract class Control3 : Control
{
	protected Graphics graphics_0;

	protected Bitmap bitmap_0;

	private bool bool_0;

	private bool bool_1;

	protected Enum0 enum0_0;

	private bool bool_2;

	private bool bool_3;

	private Image image_0;

	private bool hCovBwjwlx;

	private Dictionary<string, Color> dictionary_0;

	private string string_0;

	private Size size_0;

	private int int_0;

	private int int_1;

	private bool bool_4;

	private Rectangle zIrvwoAyBx;

	private Size size_1;

	private Point point_0;

	private Point point_1;

	private Bitmap bitmap_1;

	private Graphics graphics_1;

	private SolidBrush solidBrush_0;

	private SolidBrush solidBrush_1;

	private Point point_2;

	private Size size_2;

	private Point point_3;

	private LinearGradientBrush linearGradientBrush_0;

	private Rectangle aeAvIqjaMG;

	private GraphicsPath graphicsPath_0;

	private PathGradientBrush pathGradientBrush_0;

	private LinearGradientBrush linearGradientBrush_1;

	private Rectangle rectangle_0;

	private GraphicsPath graphicsPath_1;

	private Rectangle rectangle_1;

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

	[Category("Misc")]
	public override Color BackColor
	{
		get
		{
			return ((Control)this).get_BackColor();
		}
		set
		{
			if ((!((Control)this).get_IsHandleCreated() && value == Color.Transparent) ? true : false)
			{
				bool_2 = true;
				return;
			}
			((Control)this).set_BackColor(value);
			if (((Control)this).get_Parent() != null)
			{
				ColorHook();
			}
		}
	}

	public Control3()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		Class14.vPNVHkezq0oMI();
		((Control)this)._002Ector();
		dictionary_0 = new Dictionary<string, Color>();
		((Control)this).SetStyle((ControlStyles)139270, true);
		size_0 = Size.Empty;
		Font = new Font("Verdana", 8f);
		bitmap_1 = new Bitmap(1, 1);
		graphics_1 = Graphics.FromImage((Image)(object)bitmap_1);
		graphicsPath_0 = new GraphicsPath();
		method_27();
	}

	protected sealed override void OnHandleCreated(EventArgs e)
	{
		method_27();
		ColorHook();
		if (int_0 != 0)
		{
			((Control)this).set_Width(int_0);
		}
		if (int_1 != 0)
		{
			((Control)this).set_Height(int_1);
		}
		method_6(hCovBwjwlx);
		if ((hCovBwjwlx && bool_2) ? true : false)
		{
			BackColor = Color.Transparent;
		}
		((Control)this).OnHandleCreated(e);
	}

	protected sealed override void OnParentChanged(EventArgs e)
	{
		if (((Control)this).get_Parent() != null)
		{
			OnCreation();
			bool_0 = true;
			method_28();
		}
		((Control)this).OnParentChanged(e);
	}

	private void method_0(bool bool_5)
	{
		vmethod_0();
		if (bool_5)
		{
			((Control)this).Invalidate();
		}
	}

	protected sealed override void OnPaint(PaintEventArgs e)
	{
		if ((((Control)this).get_Width() != 0 && ((Control)this).get_Height() != 0) || 1 == 0)
		{
			if (hCovBwjwlx)
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

	protected sealed override void OnSizeChanged(EventArgs e)
	{
		if (hCovBwjwlx)
		{
			method_26();
		}
		((Control)this).Invalidate();
		((Control)this).OnSizeChanged(e);
	}

	protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
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

	protected override void OnMouseEnter(EventArgs e)
	{
		bool_1 = true;
		method_1((Enum0)1);
		((Control)this).OnMouseEnter(e);
	}

	protected override void OnMouseUp(MouseEventArgs mevent)
	{
		if (bool_1)
		{
			method_1((Enum0)1);
		}
		((Control)this).OnMouseUp(mevent);
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576)
		{
			method_1((Enum0)2);
		}
		((Control)this).OnMouseDown(e);
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		bool_1 = false;
		method_1((Enum0)0);
		((Control)this).OnMouseLeave(e);
	}

	protected override void OnEnabledChanged(EventArgs e)
	{
		if (((Control)this).get_Enabled())
		{
			method_1((Enum0)0);
		}
		else
		{
			method_1((Enum0)3);
		}
		((Control)this).OnEnabledChanged(e);
	}

	private void method_1(Enum0 enum0_1)
	{
		enum0_0 = enum0_1;
		((Control)this).Invalidate();
	}

	[SpecialName]
	public bool method_2()
	{
		return bool_3;
	}

	[SpecialName]
	public void method_3(bool bool_5)
	{
		bool_3 = bool_5;
		((Control)this).Invalidate();
	}

	[SpecialName]
	public Image method_4()
	{
		return image_0;
	}

	[SpecialName]
	public void method_5(Image image_1)
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
	public bool lAbvfoxNx3()
	{
		return hCovBwjwlx;
	}

	[SpecialName]
	public void method_6(bool bool_5)
	{
		hCovBwjwlx = bool_5;
		if (((Control)this).get_IsHandleCreated())
		{
			if ((!bool_5 && BackColor.A != byte.MaxValue) ? true : false)
			{
				throw new Exception("Unable to change value to false while a transparent BackColor is in use.");
			}
			((Control)this).SetStyle((ControlStyles)4, !bool_5);
			((Control)this).SetStyle((ControlStyles)2048, bool_5);
			if (bool_5)
			{
				method_26();
			}
			else
			{
				bitmap_0 = null;
			}
			((Control)this).Invalidate();
		}
	}

	[SpecialName]
	public Struct0[] method_7()
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
	public void method_8(Struct0[] struct0_0)
	{
		for (int i = 0; i < struct0_0.Length; i = checked(i + 1))
		{
			Struct0 @struct = struct0_0[i];
			if (dictionary_0.ContainsKey(@struct.method_0()))
			{
				dictionary_0[@struct.method_0()] = @struct.method_1();
			}
		}
		method_27();
		ColorHook();
		((Control)this).Invalidate();
	}

	[SpecialName]
	public string method_9()
	{
		return string_0;
	}

	[SpecialName]
	public void method_10(string string_1)
	{
		if (Operators.CompareString(string_1, string_0, false) == 0)
		{
			return;
		}
		Struct0[] array = method_7();
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
			method_8(array);
			ColorHook();
			((Control)this).Invalidate();
		}
	}

	[SpecialName]
	protected Size method_11()
	{
		return size_0;
	}

	[SpecialName]
	protected int method_12()
	{
		return int_0;
	}

	[SpecialName]
	protected void method_13(int int_2)
	{
		int_0 = int_2;
		if ((method_12() != 0 && ((Control)this).get_IsHandleCreated()) ? true : false)
		{
			((Control)this).set_Width(method_12());
		}
	}

	[SpecialName]
	protected int method_14()
	{
		return int_1;
	}

	[SpecialName]
	protected void method_15(int int_2)
	{
		int_1 = int_2;
		if ((method_14() != 0 && ((Control)this).get_IsHandleCreated()) ? true : false)
		{
			((Control)this).set_Height(method_14());
		}
	}

	[SpecialName]
	protected bool method_16()
	{
		return bool_4;
	}

	[SpecialName]
	protected void method_17(bool bool_5)
	{
		bool_4 = bool_5;
		method_28();
	}

	protected Pen method_18(string string_1)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		return new Pen(dictionary_0[string_1]);
	}

	protected Pen method_19(string string_1, float float_0)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		return new Pen(dictionary_0[string_1], float_0);
	}

	protected SolidBrush method_20(string string_1)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		return new SolidBrush(dictionary_0[string_1]);
	}

	protected Color method_21(string string_1)
	{
		return dictionary_0[string_1];
	}

	protected void method_22(string string_1, Color color_0)
	{
		if (dictionary_0.ContainsKey(string_1))
		{
			dictionary_0[string_1] = color_0;
		}
		else
		{
			dictionary_0.Add(string_1, color_0);
		}
	}

	protected void method_23(string string_1, byte byte_0, byte byte_1, byte byte_2)
	{
		method_22(string_1, Color.FromArgb(byte_0, byte_1, byte_2));
	}

	protected void method_24(string string_1, byte byte_0, byte byte_1, byte byte_2, byte byte_3)
	{
		method_22(string_1, Color.FromArgb(byte_0, byte_1, byte_2, byte_3));
	}

	protected void method_25(string string_1, byte byte_0, Color color_0)
	{
		method_22(string_1, Color.FromArgb(byte_0, color_0));
	}

	private void method_26()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		if ((((Control)this).get_Width() != 0 && ((Control)this).get_Height() != 0) || 1 == 0)
		{
			bitmap_0 = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height(), (PixelFormat)925707);
			graphics_0 = Graphics.FromImage((Image)(object)bitmap_0);
		}
	}

	private void method_27()
	{
		MemoryStream memoryStream = new MemoryStream(checked(dictionary_0.Count * 4));
		Struct0[] array = method_7();
		foreach (Struct0 @struct in array)
		{
			memoryStream.Write(BitConverter.GetBytes(@struct.method_1().ToArgb()), 0, 4);
		}
		memoryStream.Close();
		string_0 = Convert.ToBase64String(memoryStream.ToArray());
	}

	private void method_28()
	{
		if ((!((Component)(object)this).DesignMode && bool_0) || 1 == 0)
		{
			if (bool_4)
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

	protected Rectangle method_29(Rectangle rectangle_2, int int_2)
	{
		ref Rectangle reference = ref zIrvwoAyBx;
		reference = checked(new Rectangle(rectangle_2.X + int_2, rectangle_2.Y + int_2, rectangle_2.Width - int_2 * 2, rectangle_2.Height - int_2 * 2));
		return zIrvwoAyBx;
	}

	protected Size method_30(Size size_3, int int_2)
	{
		ref Size reference = ref size_1;
		reference = checked(new Size(size_3.Width + int_2, size_3.Height + int_2));
		return size_1;
	}

	protected Point method_31(Point point_4, int int_2)
	{
		ref Point reference = ref point_0;
		reference = checked(new Point(point_4.X + int_2, point_4.Y + int_2));
		return point_0;
	}

	protected Point method_32(Rectangle rectangle_2, Rectangle rectangle_3)
	{
		ref Point reference = ref point_1;
		checked
		{
			reference = new Point(unchecked(rectangle_2.Width / 2) - unchecked(rectangle_3.Width / 2) + rectangle_2.X + rectangle_3.X, unchecked(rectangle_2.Height / 2) - unchecked(rectangle_3.Height / 2) + rectangle_2.Y + rectangle_3.Y);
			return point_1;
		}
	}

	protected Point method_33(Rectangle rectangle_2, Size size_3)
	{
		ref Point reference = ref point_1;
		checked
		{
			reference = new Point(unchecked(rectangle_2.Width / 2) - unchecked(size_3.Width / 2) + rectangle_2.X, unchecked(rectangle_2.Height / 2) - unchecked(size_3.Height / 2) + rectangle_2.Y);
			return point_1;
		}
	}

	protected Point method_34(Rectangle rectangle_2)
	{
		return method_38(((Control)this).get_Width(), ((Control)this).get_Height(), rectangle_2.Width, rectangle_2.Height);
	}

	protected Point method_35(Size size_3)
	{
		return method_38(((Control)this).get_Width(), ((Control)this).get_Height(), size_3.Width, size_3.Height);
	}

	protected Point method_36(int int_2, int int_3)
	{
		return method_38(((Control)this).get_Width(), ((Control)this).get_Height(), int_2, int_3);
	}

	protected Point method_37(Size size_3, Size size_4)
	{
		return method_38(size_3.Width, size_3.Height, size_4.Width, size_4.Height);
	}

	protected Point method_38(int int_2, int int_3, int int_4, int int_5)
	{
		ref Point reference = ref point_1;
		checked
		{
			reference = new Point(unchecked(int_2 / 2) - unchecked(int_4 / 2), unchecked(int_3 / 2) - unchecked(int_5 / 2));
			return point_1;
		}
	}

	protected Size method_39()
	{
		return graphics_1.MeasureString(Text, Font, ((Control)this).get_Width()).ToSize();
	}

	protected Size method_40(string string_1)
	{
		return graphics_1.MeasureString(string_1, Font, ((Control)this).get_Width()).ToSize();
	}

	protected void method_41(Color color_0, int int_2, int int_3)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		if (hCovBwjwlx)
		{
			bitmap_0.SetPixel(int_2, int_3, color_0);
			return;
		}
		solidBrush_0 = new SolidBrush(color_0);
		graphics_0.FillRectangle((Brush)(object)solidBrush_0, int_2, int_3, 1, 1);
	}

	protected void method_42(Color color_0, int int_2)
	{
		method_44(color_0, 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height(), int_2);
	}

	protected void method_43(Color color_0, Rectangle rectangle_2, int int_2)
	{
		method_44(color_0, rectangle_2.X, rectangle_2.Y, rectangle_2.Width, rectangle_2.Height, int_2);
	}

	protected void method_44(Color color_0, int int_2, int int_3, int int_4, int int_5, int int_6)
	{
		checked
		{
			method_47(color_0, int_2 + int_6, int_3 + int_6, int_4 - int_6 * 2, int_5 - int_6 * 2);
		}
	}

	protected void method_45(Color color_0)
	{
		method_47(color_0, 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
	}

	protected void method_46(Color color_0, Rectangle rectangle_2)
	{
		method_47(color_0, rectangle_2.X, rectangle_2.Y, rectangle_2.Width, rectangle_2.Height);
	}

	protected void method_47(Color color_0, int int_2, int int_3, int int_4, int int_5)
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		checked
		{
			if (!bool_3)
			{
				if (hCovBwjwlx)
				{
					bitmap_0.SetPixel(int_2, int_3, color_0);
					bitmap_0.SetPixel(int_2 + (int_4 - 1), int_3, color_0);
					bitmap_0.SetPixel(int_2, int_3 + (int_5 - 1), color_0);
					bitmap_0.SetPixel(int_2 + (int_4 - 1), int_3 + (int_5 - 1), color_0);
				}
				else
				{
					solidBrush_1 = new SolidBrush(color_0);
					graphics_0.FillRectangle((Brush)(object)solidBrush_1, int_2, int_3, 1, 1);
					graphics_0.FillRectangle((Brush)(object)solidBrush_1, int_2 + (int_4 - 1), int_3, 1, 1);
					graphics_0.FillRectangle((Brush)(object)solidBrush_1, int_2, int_3 + (int_5 - 1), 1, 1);
					graphics_0.FillRectangle((Brush)(object)solidBrush_1, int_2 + (int_4 - 1), int_3 + (int_5 - 1), 1, 1);
				}
			}
		}
	}

	protected void method_48(Pen pen_0, int int_2)
	{
		method_50(pen_0, 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height(), int_2);
	}

	protected void method_49(Pen pen_0, Rectangle rectangle_2, int int_2)
	{
		method_50(pen_0, rectangle_2.X, rectangle_2.Y, rectangle_2.Width, rectangle_2.Height, int_2);
	}

	protected void method_50(Pen pen_0, int int_2, int int_3, int int_4, int int_5, int int_6)
	{
		checked
		{
			method_53(pen_0, int_2 + int_6, int_3 + int_6, int_4 - int_6 * 2, int_5 - int_6 * 2);
		}
	}

	protected void method_51(Pen pen_0)
	{
		method_53(pen_0, 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
	}

	protected void method_52(Pen pen_0, Rectangle rectangle_2)
	{
		method_53(pen_0, rectangle_2.X, rectangle_2.Y, rectangle_2.Width, rectangle_2.Height);
	}

	protected void method_53(Pen pen_0, int int_2, int int_3, int int_4, int int_5)
	{
		checked
		{
			graphics_0.DrawRectangle(pen_0, int_2, int_3, int_4 - 1, int_5 - 1);
		}
	}

	protected void method_54(Brush brush_0, HorizontalAlignment horizontalAlignment_0, int int_2, int int_3)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		method_55(brush_0, Text, horizontalAlignment_0, int_2, int_3);
	}

	protected void method_55(Brush brush_0, string string_1, HorizontalAlignment horizontalAlignment_0, int int_2, int int_3)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected I4, but got Unknown
		checked
		{
			if (string_1.Length != 0)
			{
				size_2 = method_40(string_1);
				point_2 = method_35(size_2);
				switch (unchecked((int)horizontalAlignment_0))
				{
				case 0:
					graphics_0.DrawString(string_1, Font, brush_0, (float)int_2, (float)(point_2.Y + int_3));
					break;
				case 1:
					graphics_0.DrawString(string_1, Font, brush_0, (float)(((Control)this).get_Width() - size_2.Width - int_2), (float)(point_2.Y + int_3));
					break;
				case 2:
					graphics_0.DrawString(string_1, Font, brush_0, (float)(point_2.X + int_2), (float)(point_2.Y + int_3));
					break;
				}
			}
		}
	}

	protected void method_56(Brush brush_0, Point point_4)
	{
		if (Text.Length != 0)
		{
			graphics_0.DrawString(Text, Font, brush_0, (PointF)point_4);
		}
	}

	protected void method_57(Brush brush_0, int int_2, int int_3)
	{
		if (Text.Length != 0)
		{
			graphics_0.DrawString(Text, Font, brush_0, (float)int_2, (float)int_3);
		}
	}

	protected void DrawImage(HorizontalAlignment a, int x, int y)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		DrawImage(image_0, a, x, y);
	}

	protected void DrawImage(Image image, HorizontalAlignment a, int x, int y)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected I4, but got Unknown
		checked
		{
			if (image != null)
			{
				point_3 = method_35(image.get_Size());
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

	protected void method_58(ColorBlend colorBlend_0, int int_2, int int_3, int int_4, int int_5)
	{
		ref Rectangle reference = ref aeAvIqjaMG;
		reference = new Rectangle(int_2, int_3, int_4, int_5);
		method_60(colorBlend_0, aeAvIqjaMG);
	}

	protected void method_59(ColorBlend colorBlend_0, int int_2, int int_3, int int_4, int int_5, float float_0)
	{
		ref Rectangle reference = ref aeAvIqjaMG;
		reference = new Rectangle(int_2, int_3, int_4, int_5);
		method_61(colorBlend_0, aeAvIqjaMG, float_0);
	}

	protected void method_60(ColorBlend colorBlend_0, Rectangle rectangle_2)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		linearGradientBrush_0 = new LinearGradientBrush(rectangle_2, Color.Empty, Color.Empty, 90f);
		linearGradientBrush_0.set_InterpolationColors(colorBlend_0);
		graphics_0.FillRectangle((Brush)(object)linearGradientBrush_0, rectangle_2);
	}

	protected void method_61(ColorBlend colorBlend_0, Rectangle rectangle_2, float float_0)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		linearGradientBrush_0 = new LinearGradientBrush(rectangle_2, Color.Empty, Color.Empty, float_0);
		linearGradientBrush_0.set_InterpolationColors(colorBlend_0);
		graphics_0.FillRectangle((Brush)(object)linearGradientBrush_0, rectangle_2);
	}

	protected void method_62(Color color_0, Color color_1, int int_2, int int_3, int int_4, int int_5)
	{
		ref Rectangle reference = ref aeAvIqjaMG;
		reference = new Rectangle(int_2, int_3, int_4, int_5);
		method_64(color_0, color_1, aeAvIqjaMG);
	}

	protected void method_63(Color color_0, Color color_1, int int_2, int int_3, int int_4, int int_5, float float_0)
	{
		ref Rectangle reference = ref aeAvIqjaMG;
		reference = new Rectangle(int_2, int_3, int_4, int_5);
		method_65(color_0, color_1, aeAvIqjaMG, float_0);
	}

	protected void method_64(Color color_0, Color color_1, Rectangle rectangle_2)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		linearGradientBrush_0 = new LinearGradientBrush(rectangle_2, color_0, color_1, 90f);
		graphics_0.FillRectangle((Brush)(object)linearGradientBrush_0, rectangle_2);
	}

	protected void method_65(Color color_0, Color color_1, Rectangle rectangle_2, float float_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		linearGradientBrush_0 = new LinearGradientBrush(rectangle_2, color_0, color_1, float_0);
		graphics_0.FillRectangle((Brush)(object)linearGradientBrush_0, rectangle_2);
	}

	public void method_66(ColorBlend colorBlend_0, int int_2, int int_3, int int_4, int int_5)
	{
		ref Rectangle reference = ref rectangle_0;
		reference = new Rectangle(int_2, int_3, int_4, int_5);
		method_71(colorBlend_0, rectangle_0, int_4 / 2, int_5 / 2);
	}

	public void method_67(ColorBlend colorBlend_0, int int_2, int int_3, int int_4, int int_5, Point point_4)
	{
		ref Rectangle reference = ref rectangle_0;
		reference = new Rectangle(int_2, int_3, int_4, int_5);
		method_71(colorBlend_0, rectangle_0, point_4.X, point_4.Y);
	}

	public void method_68(ColorBlend colorBlend_0, int int_2, int int_3, int int_4, int int_5, int int_6, int int_7)
	{
		ref Rectangle reference = ref rectangle_0;
		reference = new Rectangle(int_2, int_3, int_4, int_5);
		method_71(colorBlend_0, rectangle_0, int_6, int_7);
	}

	public void method_69(ColorBlend colorBlend_0, Rectangle rectangle_2)
	{
		method_71(colorBlend_0, rectangle_2, rectangle_2.Width / 2, rectangle_2.Height / 2);
	}

	public void method_70(ColorBlend colorBlend_0, Rectangle rectangle_2, Point point_4)
	{
		method_71(colorBlend_0, rectangle_2, point_4.X, point_4.Y);
	}

	public void method_71(ColorBlend colorBlend_0, Rectangle rectangle_2, int int_2, int int_3)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Invalid comparison between Unknown and I4
		graphicsPath_0.Reset();
		checked
		{
			graphicsPath_0.AddEllipse(rectangle_2.X, rectangle_2.Y, rectangle_2.Width - 1, rectangle_2.Height - 1);
			pathGradientBrush_0 = new PathGradientBrush(graphicsPath_0);
			PathGradientBrush obj = pathGradientBrush_0;
			Point point = new Point(rectangle_2.X + int_2, rectangle_2.Y + int_3);
			obj.set_CenterPoint((PointF)point);
			pathGradientBrush_0.set_InterpolationColors(colorBlend_0);
			if (unchecked((int)graphics_0.get_SmoothingMode()) == 4)
			{
				graphics_0.FillEllipse((Brush)(object)pathGradientBrush_0, rectangle_2.X + 1, rectangle_2.Y + 1, rectangle_2.Width - 3, rectangle_2.Height - 3);
			}
			else
			{
				graphics_0.FillEllipse((Brush)(object)pathGradientBrush_0, rectangle_2);
			}
		}
	}

	protected void method_72(Color color_0, Color color_1, int int_2, int int_3, int int_4, int int_5)
	{
		ref Rectangle reference = ref rectangle_0;
		reference = new Rectangle(int_2, int_3, int_4, int_5);
		KsTvReRiJl(color_0, color_1, rectangle_0);
	}

	protected void method_73(Color color_0, Color color_1, int int_2, int int_3, int int_4, int int_5, float float_0)
	{
		ref Rectangle reference = ref rectangle_0;
		reference = new Rectangle(int_2, int_3, int_4, int_5);
		method_74(color_0, color_1, rectangle_0, float_0);
	}

	protected void KsTvReRiJl(Color color_0, Color color_1, Rectangle rectangle_2)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		linearGradientBrush_1 = new LinearGradientBrush(rectangle_2, color_0, color_1, 90f);
		graphics_0.FillEllipse((Brush)(object)linearGradientBrush_1, rectangle_2);
	}

	protected void method_74(Color color_0, Color color_1, Rectangle rectangle_2, float float_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		linearGradientBrush_1 = new LinearGradientBrush(rectangle_2, color_0, color_1, float_0);
		graphics_0.FillEllipse((Brush)(object)linearGradientBrush_1, rectangle_2);
	}

	public GraphicsPath method_75(int int_2, int int_3, int int_4, int int_5, int int_6)
	{
		ref Rectangle reference = ref rectangle_1;
		reference = new Rectangle(int_2, int_3, int_4, int_5);
		return method_76(rectangle_1, int_6);
	}

	public GraphicsPath method_76(Rectangle rectangle_2, int int_2)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		graphicsPath_1 = new GraphicsPath((FillMode)1);
		graphicsPath_1.AddArc(rectangle_2.X, rectangle_2.Y, int_2, int_2, 180f, 90f);
		checked
		{
			graphicsPath_1.AddArc(rectangle_2.Right - int_2, rectangle_2.Y, int_2, int_2, 270f, 90f);
			graphicsPath_1.AddArc(rectangle_2.Right - int_2, rectangle_2.Bottom - int_2, int_2, int_2, 0f, 90f);
			graphicsPath_1.AddArc(rectangle_2.X, rectangle_2.Bottom - int_2, int_2, int_2, 90f, 90f);
			graphicsPath_1.CloseFigure();
			return graphicsPath_1;
		}
	}
}
