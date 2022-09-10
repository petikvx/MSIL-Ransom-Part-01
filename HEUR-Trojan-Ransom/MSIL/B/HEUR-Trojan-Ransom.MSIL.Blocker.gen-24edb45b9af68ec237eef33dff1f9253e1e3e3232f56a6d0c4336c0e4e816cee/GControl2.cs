using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

public abstract class GControl2 : Control
{
	protected Graphics graphics_0;

	protected Bitmap bitmap_0;

	private bool bool_0;

	private bool bool_1;

	protected GEnum0 genum0_0;

	private bool bool_2;

	private bool bool_3;

	private Image image_0;

	private bool bool_4;

	private Dictionary<string, Color> dictionary_0;

	private string string_0;

	private Size size_0;

	private int int_0;

	private int int_1;

	private bool bool_5;

	private Rectangle rectangle_0;

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

	private Rectangle rectangle_1;

	private GraphicsPath graphicsPath_0;

	private PathGradientBrush pathGradientBrush_0;

	private LinearGradientBrush linearGradientBrush_1;

	private Rectangle rectangle_2;

	private GraphicsPath graphicsPath_1;

	private Rectangle rectangle_3;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override Color ForeColor
	{
		get
		{
			if (1 == 0)
			{
			}
			return Color.Empty;
		}
		set
		{
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override Image BackgroundImage
	{
		get
		{
			if (1 == 0)
			{
			}
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
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			if (1 == 0)
			{
			}
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
			if (1 == 0)
			{
			}
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
			if (1 == 0)
			{
			}
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

	[Category("Misc")]
	public override Color BackColor
	{
		get
		{
			if (1 == 0)
			{
			}
			return ((Control)this).get_BackColor();
		}
		set
		{
			bool flag = ((Control)this).get_IsHandleCreated() || !(value == Color.Transparent);
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 3:
					if (!flag)
					{
						vmethod_0();
						num = 4;
						break;
					}
					return;
				case 2:
					flag = ((Control)this).get_Parent() == null;
					num = 3;
					break;
				case 0:
					if (!flag)
					{
						bool_2 = true;
						num = 1;
					}
					else
					{
						((Control)this).set_BackColor(value);
						num = 2;
					}
					break;
				default:
					return;
				}
			}
		}
	}

	public bool Boolean_0
	{
		get
		{
			if (1 == 0)
			{
			}
			return bool_3;
		}
		set
		{
			bool_3 = value;
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
			if (1 == 0)
			{
			}
			return image_0;
		}
		set
		{
			bool flag = value != null;
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 3:
					((Control)this).Invalidate();
					num = 4;
					break;
				case 1:
				case 2:
					image_0 = value;
					num = 3;
					break;
				case 0:
					if (!flag)
					{
						size_0 = Size.Empty;
						num = 1;
					}
					else
					{
						size_0 = value.get_Size();
						num = 2;
					}
					break;
				default:
					return;
				}
			}
		}
	}

	public bool Boolean_1
	{
		get
		{
			if (1 == 0)
			{
			}
			return bool_4;
		}
		set
		{
			bool_4 = value;
			int num = 0;
			bool flag = default(bool);
			Color backColor = default(Color);
			while (true)
			{
				int num2;
				switch (num)
				{
				case 7:
					((Control)this).Invalidate();
					num = 8;
					break;
				case 6:
					if (!flag)
					{
						method_10();
						num = 7;
						break;
					}
					bitmap_0 = null;
					goto case 7;
				case 5:
					flag = !value;
					num = 6;
					break;
				case 4:
					((Control)this).SetStyle((ControlStyles)2048, value);
					num = 5;
					break;
				case 3:
					if (flag)
					{
						((Control)this).SetStyle((ControlStyles)4, !value);
						num = 4;
						break;
					}
					throw new Exception("Unable to change value to false while a transparent BackColor is in use.");
				case 2:
					num2 = ((backColor.A == byte.MaxValue) ? 1 : 0);
					goto IL_005e;
				case 1:
					if (flag)
					{
						if (!value)
						{
							backColor = ((Control)this).get_BackColor();
							num = 2;
							break;
						}
						num2 = 1;
						goto IL_005e;
					}
					return;
				case 0:
					flag = ((Control)this).get_IsHandleCreated();
					num = 1;
					break;
				default:
					return;
					IL_005e:
					flag = (byte)num2 != 0;
					num = 3;
					break;
				}
			}
		}
	}

	public GStruct0[] GStruct0_0
	{
		get
		{
			List<GStruct0> list = new List<GStruct0>();
			int num = 0;
			bool flag = default(bool);
			GStruct0[] result = default(GStruct0[]);
			Dictionary<string, Color>.Enumerator enumerator = default(Dictionary<string, Color>.Enumerator);
			while (true)
			{
				switch (num)
				{
				case 3:
					if (!flag)
					{
						result = list.ToArray();
						num = 4;
					}
					else
					{
						list.Add(new GStruct0(enumerator.Current.Key, enumerator.Current.Value));
						num = 2;
					}
					break;
				case 1:
				case 2:
					flag = enumerator.MoveNext();
					num = 3;
					break;
				case 0:
					enumerator = dictionary_0.GetEnumerator();
					num = 1;
					break;
				default:
					return result;
				}
			}
		}
		set
		{
			int num = 0;
			bool flag = default(bool);
			GStruct0 gStruct = default(GStruct0);
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				case 7:
					((Control)this).Invalidate();
					num = 8;
					break;
				case 6:
					vmethod_0();
					num = 7;
					break;
				case 5:
					if (!flag)
					{
						method_11();
						num = 6;
					}
					else
					{
						gStruct = value[num2];
						num = 2;
					}
					break;
				case 4:
					num2++;
					goto case 1;
				case 1:
					flag = num2 < value.Length;
					num = 5;
					break;
				case 3:
					if (!flag)
					{
						dictionary_0[gStruct.String_0] = gStruct.Color_0;
						num = 4;
						break;
					}
					goto case 4;
				case 2:
					flag = !dictionary_0.ContainsKey(gStruct.String_0);
					num = 3;
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
			if (1 == 0)
			{
			}
			return string_0;
		}
		set
		{
			bool flag = !(value == string_0);
			int num = 0;
			GStruct0[] gStruct0_ = default(GStruct0[]);
			int num3 = default(int);
			while (true)
			{
				switch (num)
				{
				case 4:
					((Control)this).Invalidate();
					num = 5;
					break;
				case 3:
					vmethod_0();
					num = 4;
					break;
				case 2:
					GStruct0_0 = gStruct0_;
					num = 3;
					break;
				case 1:
					gStruct0_ = GStruct0_0;
					try
					{
						byte[] array = Convert.FromBase64String(value);
						int num2 = 0;
						while (true)
						{
							switch (num2)
							{
							case 2:
								num3++;
								goto case 1;
							case 1:
								flag = num3 <= gStruct0_.Length - 1;
								num2 = 3;
								continue;
							case 0:
								num3 = 0;
								num2 = 1;
								continue;
							default:
								if (flag)
								{
									gStruct0_[num3].Color_0 = Color.FromArgb(BitConverter.ToInt32(array, num3 * 4));
									num2 = 2;
									continue;
								}
								break;
							}
							break;
						}
					}
					catch
					{
						return;
					}
					string_0 = value;
					num = 2;
					break;
				case 0:
					if (flag)
					{
						byte[] array = null;
						num = 1;
						break;
					}
					return;
				default:
					return;
				}
			}
		}
	}

	protected Size Size_0
	{
		get
		{
			if (1 == 0)
			{
			}
			return size_0;
		}
	}

	protected int Int32_0
	{
		get
		{
			if (1 == 0)
			{
			}
			return int_0;
		}
		set
		{
			int_0 = value;
			int num = 0;
			bool flag = default(bool);
			while (true)
			{
				switch (num)
				{
				case 1:
					if (!flag)
					{
						((Control)this).set_Width(Int32_0);
						num = 2;
						break;
					}
					return;
				case 0:
					flag = Int32_0 == 0 || !((Control)this).get_IsHandleCreated();
					num = 1;
					break;
				default:
					return;
				}
			}
		}
	}

	protected int Int32_1
	{
		get
		{
			if (1 == 0)
			{
			}
			return int_1;
		}
		set
		{
			int_1 = value;
			int num = 0;
			bool flag = default(bool);
			while (true)
			{
				switch (num)
				{
				case 1:
					if (!flag)
					{
						((Control)this).set_Height(Int32_1);
						num = 2;
						break;
					}
					return;
				case 0:
					flag = Int32_1 == 0 || !((Control)this).get_IsHandleCreated();
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
			if (1 == 0)
			{
			}
			return bool_5;
		}
		set
		{
			bool_5 = value;
			for (int num = 0; num == 0; num = 1)
			{
				method_12();
			}
		}
	}

	public GControl2()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		if (1 == 0)
		{
		}
		dictionary_0 = new Dictionary<string, Color>();
		((Control)this)._002Ector();
		((Control)this).SetStyle((ControlStyles)139270, true);
		size_0 = Size.Empty;
		((Control)this).set_Font(new Font("Verdana", 8f));
		bitmap_1 = new Bitmap(1, 1);
		graphics_1 = Graphics.FromImage((Image)(object)bitmap_1);
		graphicsPath_0 = new GraphicsPath();
		method_11();
	}

	protected sealed override void OnHandleCreated(EventArgs e)
	{
		method_11();
		int num = 0;
		bool flag = default(bool);
		while (true)
		{
			switch (num)
			{
			case 8:
				((Control)this).OnHandleCreated(e);
				num = 9;
				break;
			case 7:
				if (!flag)
				{
					((Control)this).set_BackColor(Color.Transparent);
					num = 8;
					break;
				}
				goto case 8;
			case 6:
				flag = !bool_4 || !bool_2;
				num = 7;
				break;
			case 5:
				Boolean_1 = bool_4;
				num = 6;
				break;
			case 4:
				if (!flag)
				{
					((Control)this).set_Height(int_1);
					num = 5;
					break;
				}
				goto case 5;
			case 3:
				flag = int_1 == 0;
				num = 4;
				break;
			case 2:
				if (!flag)
				{
					((Control)this).set_Width(int_0);
					num = 3;
					break;
				}
				goto case 3;
			case 1:
				flag = int_0 == 0;
				num = 2;
				break;
			case 0:
				vmethod_0();
				num = 1;
				break;
			default:
				return;
			}
		}
	}

	protected sealed override void OnParentChanged(EventArgs e)
	{
		bool flag = ((Control)this).get_Parent() == null;
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 3:
				((Control)this).OnParentChanged(e);
				num = 4;
				break;
			case 2:
				method_12();
				num = 3;
				break;
			case 1:
				bool_0 = true;
				num = 2;
				break;
			case 0:
				if (!flag)
				{
					vmethod_2();
					num = 1;
					break;
				}
				goto case 3;
			default:
				return;
			}
		}
	}

	private void method_0(bool bool_6)
	{
		vmethod_3();
		int num = 0;
		bool flag = default(bool);
		while (true)
		{
			switch (num)
			{
			case 1:
				if (!flag)
				{
					((Control)this).Invalidate();
					num = 2;
					break;
				}
				return;
			case 0:
				flag = !bool_6;
				num = 1;
				break;
			default:
				return;
			}
		}
	}

	protected sealed override void OnPaint(PaintEventArgs e)
	{
		bool flag = ((Control)this).get_Width() != 0 && ((Control)this).get_Height() != 0;
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 4:
				vmethod_1();
				num = 5;
				break;
			case 2:
				e.get_Graphics().DrawImage((Image)(object)bitmap_0, 0, 0);
				num = 3;
				break;
			case 1:
				if (!flag)
				{
					vmethod_1();
					num = 2;
				}
				else
				{
					graphics_0 = e.get_Graphics();
					num = 4;
				}
				break;
			case 0:
				if (flag)
				{
					flag = !bool_4;
					num = 1;
					break;
				}
				return;
			default:
				return;
			}
		}
	}

	protected override void OnHandleDestroyed(EventArgs e)
	{
		GClass4.smethod_3(method_0);
		for (int num = 0; num == 0; num = 1)
		{
			((Control)this).OnHandleDestroyed(e);
		}
	}

	protected sealed override void OnSizeChanged(EventArgs e)
	{
		bool flag = !bool_4;
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 2:
				((Control)this).OnSizeChanged(e);
				num = 3;
				break;
			case 1:
				((Control)this).Invalidate();
				num = 2;
				break;
			case 0:
				if (!flag)
				{
					method_10();
					num = 1;
					break;
				}
				goto case 1;
			default:
				return;
			}
		}
	}

	protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		bool flag = int_0 == 0;
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 1:
				if (!flag)
				{
					height = int_1;
				}
				((Control)this).SetBoundsCore(x, y, width, height, specified);
				num = 2;
				break;
			case 0:
				if (!flag)
				{
					width = int_0;
				}
				flag = int_1 == 0;
				num = 1;
				break;
			default:
				return;
			}
		}
	}

	protected override void OnMouseEnter(EventArgs e)
	{
		bool_1 = true;
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 1:
				((Control)this).OnMouseEnter(e);
				num = 2;
				break;
			case 0:
				method_1(GEnum0.const_1);
				num = 1;
				break;
			default:
				return;
			}
		}
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		bool flag = !bool_1;
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 1:
				((Control)this).OnMouseUp(e);
				num = 2;
				break;
			case 0:
				if (!flag)
				{
					method_1(GEnum0.const_1);
					num = 1;
					break;
				}
				goto case 1;
			default:
				return;
			}
		}
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		bool flag = (int)e.get_Button() != 1048576;
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 1:
				((Control)this).OnMouseDown(e);
				num = 2;
				break;
			case 0:
				if (!flag)
				{
					method_1(GEnum0.const_2);
					num = 1;
					break;
				}
				goto case 1;
			default:
				return;
			}
		}
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		bool_1 = false;
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 1:
				((Control)this).OnMouseLeave(e);
				num = 2;
				break;
			case 0:
				method_1(GEnum0.const_0);
				num = 1;
				break;
			default:
				return;
			}
		}
	}

	protected override void OnEnabledChanged(EventArgs e)
	{
		bool flag = !((Control)this).get_Enabled();
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				((Control)this).OnEnabledChanged(e);
				num = 3;
				break;
			case 0:
				if (!flag)
				{
					method_1(GEnum0.const_0);
					num = 1;
				}
				else
				{
					method_1(GEnum0.const_3);
					num = 2;
				}
				break;
			default:
				return;
			}
		}
	}

	private void method_1(GEnum0 genum0_1)
	{
		genum0_0 = genum0_1;
		for (int num = 0; num == 0; num = 1)
		{
			((Control)this).Invalidate();
		}
	}

	protected Pen method_2(string string_1)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		if (1 == 0)
		{
		}
		return new Pen(dictionary_0[string_1]);
	}

	protected Pen method_3(string string_1, float float_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		if (1 == 0)
		{
		}
		return new Pen(dictionary_0[string_1], float_0);
	}

	protected SolidBrush method_4(string string_1)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		if (1 == 0)
		{
		}
		return new SolidBrush(dictionary_0[string_1]);
	}

	protected Color method_5(string string_1)
	{
		if (1 == 0)
		{
		}
		return dictionary_0[string_1];
	}

	protected void method_6(string string_1, Color color_0)
	{
		bool flag = !dictionary_0.ContainsKey(string_1);
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 0:
				if (!flag)
				{
					dictionary_0[string_1] = color_0;
					num = 1;
				}
				else
				{
					dictionary_0.Add(string_1, color_0);
					num = 2;
				}
				break;
			default:
				return;
			}
		}
	}

	protected void method_7(string string_1, byte byte_0, byte byte_1, byte byte_2)
	{
		if (1 == 0)
		{
		}
		method_6(string_1, Color.FromArgb(byte_0, byte_1, byte_2));
	}

	protected void method_8(string string_1, byte byte_0, byte byte_1, byte byte_2, byte byte_3)
	{
		if (1 == 0)
		{
		}
		method_6(string_1, Color.FromArgb(byte_0, byte_1, byte_2, byte_3));
	}

	protected void method_9(string string_1, byte byte_0, Color color_0)
	{
		if (1 == 0)
		{
		}
		method_6(string_1, Color.FromArgb(byte_0, color_0));
	}

	private void method_10()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		bool flag = ((Control)this).get_Width() != 0 && ((Control)this).get_Height() != 0;
		int num = 0;
		while (true)
		{
			if (num == 0)
			{
				if (flag)
				{
					bitmap_0 = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height(), (PixelFormat)925707);
					num = 1;
					continue;
				}
				break;
			}
			graphics_0 = Graphics.FromImage((Image)(object)bitmap_0);
			break;
		}
	}

	private void method_11()
	{
		MemoryStream memoryStream = new MemoryStream(dictionary_0.Count * 4);
		int num = 0;
		bool flag = default(bool);
		GStruct0 gStruct = default(GStruct0);
		GStruct0[] gStruct0_ = default(GStruct0[]);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			case 6:
				string_0 = Convert.ToBase64String(memoryStream.ToArray());
				num = 7;
				break;
			case 5:
				if (!flag)
				{
					memoryStream.Close();
					num = 6;
				}
				else
				{
					gStruct = gStruct0_[num2];
					num = 3;
				}
				break;
			case 4:
				num2++;
				goto case 2;
			case 2:
				flag = num2 < gStruct0_.Length;
				num = 5;
				break;
			case 3:
				memoryStream.Write(BitConverter.GetBytes(gStruct.Color_0.ToArgb()), 0, 4);
				num = 4;
				break;
			case 1:
				num2 = 0;
				num = 2;
				break;
			case 0:
				gStruct0_ = GStruct0_0;
				num = 1;
				break;
			default:
				return;
			}
		}
	}

	private void method_12()
	{
		bool flag = !((Component)this).DesignMode && bool_0;
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 1:
				if (!flag)
				{
					GClass4.smethod_2(method_0);
					num = 2;
				}
				else
				{
					GClass4.smethod_3(method_0);
					num = 3;
				}
				break;
			case 0:
				if (flag)
				{
					flag = !bool_5;
					num = 1;
					break;
				}
				return;
			default:
				return;
			}
		}
	}

	protected abstract void vmethod_0();

	protected abstract void vmethod_1();

	protected virtual void vmethod_2()
	{
	}

	protected virtual void vmethod_3()
	{
	}

	protected Rectangle method_13(Rectangle rectangle_4, int int_2)
	{
		rectangle_0 = new Rectangle(rectangle_4.X + int_2, rectangle_4.Y + int_2, rectangle_4.Width - int_2 * 2, rectangle_4.Height - int_2 * 2);
		Rectangle result = default(Rectangle);
		for (int num = 0; num == 0; num = 1)
		{
			result = rectangle_0;
		}
		return result;
	}

	protected Size method_14(Size size_3, int int_2)
	{
		size_1 = new Size(size_3.Width + int_2, size_3.Height + int_2);
		Size result = default(Size);
		for (int num = 0; num == 0; num = 1)
		{
			result = size_1;
		}
		return result;
	}

	protected Point method_15(Point point_4, int int_2)
	{
		point_0 = new Point(point_4.X + int_2, point_4.Y + int_2);
		Point result = default(Point);
		for (int num = 0; num == 0; num = 1)
		{
			result = point_0;
		}
		return result;
	}

	protected Point method_16(Rectangle rectangle_4, Rectangle rectangle_5)
	{
		point_1 = new Point(rectangle_4.Width / 2 - rectangle_5.Width / 2 + rectangle_4.X + rectangle_5.X, rectangle_4.Height / 2 - rectangle_5.Height / 2 + rectangle_4.Y + rectangle_5.Y);
		Point result = default(Point);
		for (int num = 0; num == 0; num = 1)
		{
			result = point_1;
		}
		return result;
	}

	protected Point method_17(Rectangle rectangle_4, Size size_3)
	{
		point_1 = new Point(rectangle_4.Width / 2 - size_3.Width / 2 + rectangle_4.X, rectangle_4.Height / 2 - size_3.Height / 2 + rectangle_4.Y);
		Point result = default(Point);
		for (int num = 0; num == 0; num = 1)
		{
			result = point_1;
		}
		return result;
	}

	protected Point method_18(Rectangle rectangle_4)
	{
		if (1 == 0)
		{
		}
		return method_22(((Control)this).get_Width(), ((Control)this).get_Height(), rectangle_4.Width, rectangle_4.Height);
	}

	protected Point method_19(Size size_3)
	{
		if (1 == 0)
		{
		}
		return method_22(((Control)this).get_Width(), ((Control)this).get_Height(), size_3.Width, size_3.Height);
	}

	protected Point method_20(int int_2, int int_3)
	{
		if (1 == 0)
		{
		}
		return method_22(((Control)this).get_Width(), ((Control)this).get_Height(), int_2, int_3);
	}

	protected Point method_21(Size size_3, Size size_4)
	{
		if (1 == 0)
		{
		}
		return method_22(size_3.Width, size_3.Height, size_4.Width, size_4.Height);
	}

	protected Point method_22(int int_2, int int_3, int int_4, int int_5)
	{
		point_1 = new Point(int_2 / 2 - int_4 / 2, int_3 / 2 - int_5 / 2);
		Point result = default(Point);
		for (int num = 0; num == 0; num = 1)
		{
			result = point_1;
		}
		return result;
	}

	protected Size method_23()
	{
		SizeF sizeF = graphics_1.MeasureString(((Control)this).get_Text(), ((Control)this).get_Font(), ((Control)this).get_Width());
		Size result = default(Size);
		for (int num = 0; num == 0; num = 1)
		{
			result = sizeF.ToSize();
		}
		return result;
	}

	protected Size method_24(string string_1)
	{
		SizeF sizeF = graphics_1.MeasureString(string_1, ((Control)this).get_Font(), ((Control)this).get_Width());
		Size result = default(Size);
		for (int num = 0; num == 0; num = 1)
		{
			result = sizeF.ToSize();
		}
		return result;
	}

	protected void method_25(Color color_0, int int_2, int int_3)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		bool flag = !bool_4;
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 2:
				graphics_0.FillRectangle((Brush)(object)solidBrush_0, int_2, int_3, 1, 1);
				num = 3;
				break;
			case 0:
				if (!flag)
				{
					bitmap_0.SetPixel(int_2, int_3, color_0);
					num = 1;
				}
				else
				{
					solidBrush_0 = new SolidBrush(color_0);
					num = 2;
				}
				break;
			default:
				return;
			}
		}
	}

	protected void method_26(Color color_0, int int_2)
	{
		if (1 == 0)
		{
		}
		method_28(color_0, 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height(), int_2);
	}

	protected void method_27(Color color_0, Rectangle rectangle_4, int int_2)
	{
		if (1 == 0)
		{
		}
		method_28(color_0, rectangle_4.X, rectangle_4.Y, rectangle_4.Width, rectangle_4.Height, int_2);
	}

	protected void method_28(Color color_0, int int_2, int int_3, int int_4, int int_5, int int_6)
	{
		if (1 == 0)
		{
		}
		method_31(color_0, int_2 + int_6, int_3 + int_6, int_4 - int_6 * 2, int_5 - int_6 * 2);
	}

	protected void method_29(Color color_0)
	{
		if (1 == 0)
		{
		}
		method_31(color_0, 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
	}

	protected void method_30(Color color_0, Rectangle rectangle_4)
	{
		if (1 == 0)
		{
		}
		method_31(color_0, rectangle_4.X, rectangle_4.Y, rectangle_4.Width, rectangle_4.Height);
	}

	protected void method_31(Color color_0, int int_2, int int_3, int int_4, int int_5)
	{
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		bool flag = !bool_3;
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 9:
				graphics_0.FillRectangle((Brush)(object)solidBrush_1, int_2 + (int_4 - 1), int_3 + (int_5 - 1), 1, 1);
				num = 10;
				break;
			case 8:
				graphics_0.FillRectangle((Brush)(object)solidBrush_1, int_2, int_3 + (int_5 - 1), 1, 1);
				num = 9;
				break;
			case 7:
				graphics_0.FillRectangle((Brush)(object)solidBrush_1, int_2 + (int_4 - 1), int_3, 1, 1);
				num = 8;
				break;
			case 6:
				graphics_0.FillRectangle((Brush)(object)solidBrush_1, int_2, int_3, 1, 1);
				num = 7;
				break;
			case 4:
				bitmap_0.SetPixel(int_2 + (int_4 - 1), int_3 + (int_5 - 1), color_0);
				num = 5;
				break;
			case 3:
				bitmap_0.SetPixel(int_2, int_3 + (int_5 - 1), color_0);
				num = 4;
				break;
			case 2:
				bitmap_0.SetPixel(int_2 + (int_4 - 1), int_3, color_0);
				num = 3;
				break;
			case 1:
				if (!flag)
				{
					bitmap_0.SetPixel(int_2, int_3, color_0);
					num = 2;
				}
				else
				{
					solidBrush_1 = new SolidBrush(color_0);
					num = 6;
				}
				break;
			case 0:
				if (flag)
				{
					flag = !bool_4;
					num = 1;
					break;
				}
				return;
			default:
				return;
			}
		}
	}

	protected void method_32(Pen pen_0, int int_2)
	{
		if (1 == 0)
		{
		}
		method_34(pen_0, 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height(), int_2);
	}

	protected void method_33(Pen pen_0, Rectangle rectangle_4, int int_2)
	{
		if (1 == 0)
		{
		}
		method_34(pen_0, rectangle_4.X, rectangle_4.Y, rectangle_4.Width, rectangle_4.Height, int_2);
	}

	protected void method_34(Pen pen_0, int int_2, int int_3, int int_4, int int_5, int int_6)
	{
		if (1 == 0)
		{
		}
		method_37(pen_0, int_2 + int_6, int_3 + int_6, int_4 - int_6 * 2, int_5 - int_6 * 2);
	}

	protected void method_35(Pen pen_0)
	{
		if (1 == 0)
		{
		}
		method_37(pen_0, 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
	}

	protected void method_36(Pen pen_0, Rectangle rectangle_4)
	{
		if (1 == 0)
		{
		}
		method_37(pen_0, rectangle_4.X, rectangle_4.Y, rectangle_4.Width, rectangle_4.Height);
	}

	protected void method_37(Pen pen_0, int int_2, int int_3, int int_4, int int_5)
	{
		if (1 == 0)
		{
		}
		graphics_0.DrawRectangle(pen_0, int_2, int_3, int_4 - 1, int_5 - 1);
	}

	protected void method_38(Brush brush_0, HorizontalAlignment horizontalAlignment_0, int int_2, int int_3)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (1 == 0)
		{
		}
		method_39(brush_0, ((Control)this).get_Text(), horizontalAlignment_0, int_2, int_3);
	}

	protected void method_39(Brush brush_0, string string_1, HorizontalAlignment horizontalAlignment_0, int int_2, int int_3)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected I4, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		bool flag = string_1.Length != 0;
		int num = 0;
		HorizontalAlignment val = default(HorizontalAlignment);
		while (true)
		{
			switch (num)
			{
			case 3:
				switch ((int)val)
				{
				default:
					return;
				case 0:
					graphics_0.DrawString(string_1, ((Control)this).get_Font(), brush_0, (float)int_2, (float)(point_2.Y + int_3));
					num = 4;
					break;
				case 1:
					graphics_0.DrawString(string_1, ((Control)this).get_Font(), brush_0, (float)(((Control)this).get_Width() - size_2.Width - int_2), (float)(point_2.Y + int_3));
					num = 6;
					break;
				case 2:
					graphics_0.DrawString(string_1, ((Control)this).get_Font(), brush_0, (float)(point_2.X + int_2), (float)(point_2.Y + int_3));
					num = 5;
					break;
				}
				break;
			case 2:
				val = horizontalAlignment_0;
				num = 3;
				break;
			case 1:
				point_2 = method_19(size_2);
				num = 2;
				break;
			case 0:
				if (flag)
				{
					size_2 = method_24(string_1);
					num = 1;
					break;
				}
				return;
			default:
				return;
			}
		}
	}

	protected void method_40(Brush brush_0, Point point_4)
	{
		bool flag = ((Control)this).get_Text().Length != 0;
		int num = 0;
		while (num == 0 && flag)
		{
			graphics_0.DrawString(((Control)this).get_Text(), ((Control)this).get_Font(), brush_0, (PointF)point_4);
			num = 1;
		}
	}

	protected void method_41(Brush brush_0, int int_2, int int_3)
	{
		bool flag = ((Control)this).get_Text().Length != 0;
		int num = 0;
		while (num == 0 && flag)
		{
			graphics_0.DrawString(((Control)this).get_Text(), ((Control)this).get_Font(), brush_0, (float)int_2, (float)int_3);
			num = 1;
		}
	}

	protected void method_42(HorizontalAlignment horizontalAlignment_0, int int_2, int int_3)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		if (1 == 0)
		{
		}
		method_43(image_0, horizontalAlignment_0, int_2, int_3);
	}

	protected void method_43(Image image_1, HorizontalAlignment horizontalAlignment_0, int int_2, int int_3)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected I4, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		bool flag = image_1 != null;
		int num = 0;
		HorizontalAlignment val = default(HorizontalAlignment);
		while (true)
		{
			switch (num)
			{
			case 2:
				switch ((int)val)
				{
				default:
					return;
				case 0:
					graphics_0.DrawImage(image_1, int_2, point_3.Y + int_3, image_1.get_Width(), image_1.get_Height());
					num = 3;
					break;
				case 1:
					graphics_0.DrawImage(image_1, ((Control)this).get_Width() - image_1.get_Width() - int_2, point_3.Y + int_3, image_1.get_Width(), image_1.get_Height());
					num = 5;
					break;
				case 2:
					graphics_0.DrawImage(image_1, point_3.X + int_2, point_3.Y + int_3, image_1.get_Width(), image_1.get_Height());
					num = 4;
					break;
				}
				break;
			case 1:
				val = horizontalAlignment_0;
				num = 2;
				break;
			case 0:
				if (flag)
				{
					point_3 = method_19(image_1.get_Size());
					num = 1;
					break;
				}
				return;
			default:
				return;
			}
		}
	}

	protected void method_44(Point point_4)
	{
		if (1 == 0)
		{
		}
		method_47(image_0, point_4.X, point_4.Y);
	}

	protected void method_45(int int_2, int int_3)
	{
		if (1 == 0)
		{
		}
		method_47(image_0, int_2, int_3);
	}

	protected void method_46(Image image_1, Point point_4)
	{
		if (1 == 0)
		{
		}
		method_47(image_1, point_4.X, point_4.Y);
	}

	protected void method_47(Image image_1, int int_2, int int_3)
	{
		bool flag = image_1 != null;
		int num = 0;
		while (num == 0 && flag)
		{
			graphics_0.DrawImage(image_1, int_2, int_3, image_1.get_Width(), image_1.get_Height());
			num = 1;
		}
	}

	protected void method_48(ColorBlend colorBlend_0, int int_2, int int_3, int int_4, int int_5)
	{
		rectangle_1 = new Rectangle(int_2, int_3, int_4, int_5);
		for (int num = 0; num == 0; num = 1)
		{
			method_50(colorBlend_0, rectangle_1);
		}
	}

	protected void method_49(ColorBlend colorBlend_0, int int_2, int int_3, int int_4, int int_5, float float_0)
	{
		rectangle_1 = new Rectangle(int_2, int_3, int_4, int_5);
		for (int num = 0; num == 0; num = 1)
		{
			method_51(colorBlend_0, rectangle_1, float_0);
		}
	}

	protected void method_50(ColorBlend colorBlend_0, Rectangle rectangle_4)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		linearGradientBrush_0 = new LinearGradientBrush(rectangle_4, Color.Empty, Color.Empty, 90f);
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 1:
				graphics_0.FillRectangle((Brush)(object)linearGradientBrush_0, rectangle_4);
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

	protected void method_51(ColorBlend colorBlend_0, Rectangle rectangle_4, float float_0)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		linearGradientBrush_0 = new LinearGradientBrush(rectangle_4, Color.Empty, Color.Empty, float_0);
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 1:
				graphics_0.FillRectangle((Brush)(object)linearGradientBrush_0, rectangle_4);
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

	protected void method_52(Color color_0, Color color_1, int int_2, int int_3, int int_4, int int_5)
	{
		rectangle_1 = new Rectangle(int_2, int_3, int_4, int_5);
		for (int num = 0; num == 0; num = 1)
		{
			method_54(color_0, color_1, rectangle_1);
		}
	}

	protected void method_53(Color color_0, Color color_1, int int_2, int int_3, int int_4, int int_5, float float_0)
	{
		rectangle_1 = new Rectangle(int_2, int_3, int_4, int_5);
		for (int num = 0; num == 0; num = 1)
		{
			method_55(color_0, color_1, rectangle_1, float_0);
		}
	}

	protected void method_54(Color color_0, Color color_1, Rectangle rectangle_4)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		linearGradientBrush_0 = new LinearGradientBrush(rectangle_4, color_0, color_1, 90f);
		for (int num = 0; num == 0; num = 1)
		{
			graphics_0.FillRectangle((Brush)(object)linearGradientBrush_0, rectangle_4);
		}
	}

	protected void method_55(Color color_0, Color color_1, Rectangle rectangle_4, float float_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		linearGradientBrush_0 = new LinearGradientBrush(rectangle_4, color_0, color_1, float_0);
		for (int num = 0; num == 0; num = 1)
		{
			graphics_0.FillRectangle((Brush)(object)linearGradientBrush_0, rectangle_4);
		}
	}

	public void method_56(ColorBlend colorBlend_0, int int_2, int int_3, int int_4, int int_5)
	{
		rectangle_2 = new Rectangle(int_2, int_3, int_4, int_5);
		for (int num = 0; num == 0; num = 1)
		{
			method_61(colorBlend_0, rectangle_2, int_4 / 2, int_5 / 2);
		}
	}

	public void method_57(ColorBlend colorBlend_0, int int_2, int int_3, int int_4, int int_5, Point point_4)
	{
		rectangle_2 = new Rectangle(int_2, int_3, int_4, int_5);
		for (int num = 0; num == 0; num = 1)
		{
			method_61(colorBlend_0, rectangle_2, point_4.X, point_4.Y);
		}
	}

	public void method_58(ColorBlend colorBlend_0, int int_2, int int_3, int int_4, int int_5, int int_6, int int_7)
	{
		rectangle_2 = new Rectangle(int_2, int_3, int_4, int_5);
		for (int num = 0; num == 0; num = 1)
		{
			method_61(colorBlend_0, rectangle_2, int_6, int_7);
		}
	}

	public void method_59(ColorBlend colorBlend_0, Rectangle rectangle_4)
	{
		if (1 == 0)
		{
		}
		method_61(colorBlend_0, rectangle_4, rectangle_4.Width / 2, rectangle_4.Height / 2);
	}

	public void method_60(ColorBlend colorBlend_0, Rectangle rectangle_4, Point point_4)
	{
		if (1 == 0)
		{
		}
		method_61(colorBlend_0, rectangle_4, point_4.X, point_4.Y);
	}

	public void method_61(ColorBlend colorBlend_0, Rectangle rectangle_4, int int_2, int int_3)
	{
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Invalid comparison between Unknown and I4
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		graphicsPath_0.Reset();
		int num = 0;
		bool flag = default(bool);
		while (true)
		{
			switch (num)
			{
			case 5:
				if (!flag)
				{
					graphics_0.FillEllipse((Brush)(object)pathGradientBrush_0, rectangle_4.X + 1, rectangle_4.Y + 1, rectangle_4.Width - 3, rectangle_4.Height - 3);
					num = 6;
				}
				else
				{
					graphics_0.FillEllipse((Brush)(object)pathGradientBrush_0, rectangle_4);
					num = 7;
				}
				break;
			case 4:
				flag = (int)graphics_0.get_SmoothingMode() != 4;
				num = 5;
				break;
			case 3:
				pathGradientBrush_0.set_InterpolationColors(colorBlend_0);
				num = 4;
				break;
			case 2:
				pathGradientBrush_0.set_CenterPoint((PointF)new Point(rectangle_4.X + int_2, rectangle_4.Y + int_3));
				num = 3;
				break;
			case 1:
				pathGradientBrush_0 = new PathGradientBrush(graphicsPath_0);
				num = 2;
				break;
			case 0:
				graphicsPath_0.AddEllipse(rectangle_4.X, rectangle_4.Y, rectangle_4.Width - 1, rectangle_4.Height - 1);
				num = 1;
				break;
			default:
				return;
			}
		}
	}

	protected void method_62(Color color_0, Color color_1, int int_2, int int_3, int int_4, int int_5)
	{
		rectangle_2 = new Rectangle(int_2, int_3, int_4, int_5);
		for (int num = 0; num == 0; num = 1)
		{
			method_64(color_0, color_1, rectangle_2);
		}
	}

	protected void method_63(Color color_0, Color color_1, int int_2, int int_3, int int_4, int int_5, float float_0)
	{
		rectangle_2 = new Rectangle(int_2, int_3, int_4, int_5);
		for (int num = 0; num == 0; num = 1)
		{
			method_65(color_0, color_1, rectangle_2, float_0);
		}
	}

	protected void method_64(Color color_0, Color color_1, Rectangle rectangle_4)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		linearGradientBrush_1 = new LinearGradientBrush(rectangle_4, color_0, color_1, 90f);
		for (int num = 0; num == 0; num = 1)
		{
			graphics_0.FillEllipse((Brush)(object)linearGradientBrush_1, rectangle_4);
		}
	}

	protected void method_65(Color color_0, Color color_1, Rectangle rectangle_4, float float_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		linearGradientBrush_1 = new LinearGradientBrush(rectangle_4, color_0, color_1, float_0);
		for (int num = 0; num == 0; num = 1)
		{
			graphics_0.FillEllipse((Brush)(object)linearGradientBrush_1, rectangle_4);
		}
	}

	public GraphicsPath method_66(int int_2, int int_3, int int_4, int int_5, int int_6)
	{
		rectangle_3 = new Rectangle(int_2, int_3, int_4, int_5);
		GraphicsPath result = default(GraphicsPath);
		for (int num = 0; num == 0; num = 1)
		{
			result = method_67(rectangle_3, int_6);
		}
		return result;
	}

	public GraphicsPath method_67(Rectangle rectangle_4, int int_2)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		graphicsPath_1 = new GraphicsPath((FillMode)1);
		int num = 0;
		GraphicsPath result = default(GraphicsPath);
		while (true)
		{
			switch (num)
			{
			case 5:
				result = graphicsPath_1;
				num = 6;
				break;
			case 4:
				graphicsPath_1.CloseFigure();
				num = 5;
				break;
			case 3:
				graphicsPath_1.AddArc(rectangle_4.X, rectangle_4.Bottom - int_2, int_2, int_2, 90f, 90f);
				num = 4;
				break;
			case 2:
				graphicsPath_1.AddArc(rectangle_4.Right - int_2, rectangle_4.Bottom - int_2, int_2, int_2, 0f, 90f);
				num = 3;
				break;
			case 1:
				graphicsPath_1.AddArc(rectangle_4.Right - int_2, rectangle_4.Y, int_2, int_2, 270f, 90f);
				num = 2;
				break;
			case 0:
				graphicsPath_1.AddArc(rectangle_4.X, rectangle_4.Y, int_2, int_2, 180f, 90f);
				num = 1;
				break;
			default:
				return result;
			}
		}
	}
}
