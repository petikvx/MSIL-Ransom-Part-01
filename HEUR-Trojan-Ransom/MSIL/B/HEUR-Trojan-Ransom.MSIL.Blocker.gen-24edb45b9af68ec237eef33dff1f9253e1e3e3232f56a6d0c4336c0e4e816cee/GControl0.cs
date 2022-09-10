using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

public abstract class GControl0 : ContainerControl
{
	protected Graphics graphics_0;

	protected Bitmap bitmap_0;

	private bool bool_0;

	private bool bool_1;

	private Rectangle rectangle_0;

	protected GEnum0 genum0_0;

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
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			if (1 == 0)
			{
			}
			return ((Control)this).get_Dock();
		}
		set
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			bool flag = bool_14;
			int num = 0;
			while (num == 0 && flag)
			{
				((Control)this).set_Dock(value);
				num = 1;
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
			bool flag = !(value == ((Control)this).get_BackColor());
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 6:
					vmethod_0();
					num = 7;
					break;
				case 5:
					if (!flag)
					{
						((Control)this).get_Parent().set_BackColor(value);
						num = 6;
						break;
					}
					goto case 6;
				case 4:
					if (!flag)
					{
						flag = bool_14;
						num = 5;
						break;
					}
					return;
				case 3:
					flag = ((Control)this).get_Parent() == null;
					num = 4;
					break;
				case 1:
					if (!flag)
					{
						bool_7 = true;
						num = 2;
					}
					else
					{
						((Control)this).set_BackColor(value);
						num = 3;
					}
					break;
				case 0:
					if (flag)
					{
						flag = ((Control)this).get_IsHandleCreated() || !bool_14 || !(value == Color.Transparent);
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

	public override Size MinimumSize
	{
		get
		{
			if (1 == 0)
			{
			}
			return ((Control)this).get_MinimumSize();
		}
		set
		{
			((Control)this).set_MinimumSize(value);
			int num = 0;
			bool flag = default(bool);
			while (true)
			{
				switch (num)
				{
				case 1:
					if (!flag)
					{
						((Control)this).get_Parent().set_MinimumSize(value);
						num = 2;
						break;
					}
					return;
				case 0:
					flag = ((Control)this).get_Parent() == null;
					num = 1;
					break;
				default:
					return;
				}
			}
		}
	}

	public override Size MaximumSize
	{
		get
		{
			if (1 == 0)
			{
			}
			return ((Control)this).get_MaximumSize();
		}
		set
		{
			((Control)this).set_MaximumSize(value);
			int num = 0;
			bool flag = default(bool);
			while (true)
			{
				switch (num)
				{
				case 1:
					if (!flag)
					{
						((Control)this).get_Parent().set_MaximumSize(value);
						num = 2;
						break;
					}
					return;
				case 0:
					flag = ((Control)this).get_Parent() == null;
					num = 1;
					break;
				default:
					return;
				}
			}
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

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
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

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[EditorBrowsable(EditorBrowsableState.Never)]
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

	public bool Boolean_0
	{
		get
		{
			if (1 == 0)
			{
			}
			return bool_8;
		}
		set
		{
			bool_8 = value;
		}
	}

	public bool Boolean_1
	{
		get
		{
			if (1 == 0)
			{
			}
			return bool_9;
		}
		set
		{
			bool_9 = value;
		}
	}

	public bool Boolean_2
	{
		get
		{
			if (1 == 0)
			{
			}
			return bool_10;
		}
		set
		{
			bool_10 = value;
		}
	}

	public Color Color_0
	{
		get
		{
			bool flag = !bool_13 || bool_14;
			int num = 0;
			Color transparencyKey = default(Color);
			while (true)
			{
				switch (num)
				{
				case 0:
					if (!flag)
					{
						transparencyKey = ((ContainerControl)this).get_ParentForm().get_TransparencyKey();
						num = 1;
					}
					else
					{
						transparencyKey = color_0;
						num = 2;
					}
					break;
				default:
					return transparencyKey;
				}
			}
		}
		set
		{
			bool flag = !(value == color_0);
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 3:
					vmethod_0();
					num = 4;
					break;
				case 2:
					if (!flag)
					{
						((ContainerControl)this).get_ParentForm().set_TransparencyKey(value);
						num = 3;
						break;
					}
					return;
				case 1:
					flag = !bool_13 || bool_14;
					num = 2;
					break;
				case 0:
					if (flag)
					{
						color_0 = value;
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

	public FormBorderStyle FormBorderStyle_0
	{
		get
		{
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			bool flag = !bool_13 || bool_14;
			int num = 0;
			FormBorderStyle formBorderStyle = default(FormBorderStyle);
			while (true)
			{
				switch (num)
				{
				case 0:
					if (!flag)
					{
						formBorderStyle = ((ContainerControl)this).get_ParentForm().get_FormBorderStyle();
						num = 1;
					}
					else
					{
						formBorderStyle = formBorderStyle_0;
						num = 2;
					}
					break;
				default:
					return formBorderStyle;
				}
			}
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Invalid comparison between Unknown and I4
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			formBorderStyle_0 = value;
			int num = 0;
			bool flag = default(bool);
			while (true)
			{
				switch (num)
				{
				case 4:
					Boolean_2 = false;
					num = 5;
					break;
				case 3:
					if (!flag)
					{
						Boolean_1 = false;
						num = 4;
						break;
					}
					return;
				case 2:
					flag = (int)value == 0;
					num = 3;
					break;
				case 1:
					if (!flag)
					{
						((ContainerControl)this).get_ParentForm().set_FormBorderStyle(value);
						num = 2;
						break;
					}
					return;
				case 0:
					flag = !bool_13 || bool_14;
					num = 1;
					break;
				default:
					return;
				}
			}
		}
	}

	public FormStartPosition FormStartPosition_0
	{
		get
		{
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			bool flag = !bool_13 || bool_14;
			int num = 0;
			FormStartPosition startPosition = default(FormStartPosition);
			while (true)
			{
				switch (num)
				{
				case 0:
					if (!flag)
					{
						startPosition = ((ContainerControl)this).get_ParentForm().get_StartPosition();
						num = 1;
					}
					else
					{
						startPosition = formStartPosition_0;
						num = 2;
					}
					break;
				default:
					return startPosition;
				}
			}
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			formStartPosition_0 = value;
			int num = 0;
			bool flag = default(bool);
			while (true)
			{
				switch (num)
				{
				case 1:
					if (!flag)
					{
						((ContainerControl)this).get_ParentForm().set_StartPosition(value);
						num = 2;
						break;
					}
					return;
				case 0:
					flag = !bool_13 || bool_14;
					num = 1;
					break;
				default:
					return;
				}
			}
		}
	}

	public bool Boolean_3
	{
		get
		{
			if (1 == 0)
			{
			}
			return bool_11;
		}
		set
		{
			bool_11 = value;
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
				case 2:
					((Control)this).Invalidate();
					num = 3;
					break;
				case 1:
					image_0 = value;
					num = 2;
					break;
				case 0:
					if (!flag)
					{
						size_0 = Size.Empty;
						num = 1;
						break;
					}
					size_0 = value.get_Size();
					goto case 1;
				default:
					return;
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
						method_16();
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

	public bool Boolean_4
	{
		get
		{
			if (1 == 0)
			{
			}
			return bool_12;
		}
		set
		{
			bool_12 = value;
			int num = 0;
			bool flag = default(bool);
			Color backColor = default(Color);
			while (true)
			{
				int num2;
				switch (num)
				{
				case 6:
					((Control)this).Invalidate();
					num = 7;
					break;
				case 5:
					method_15();
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
					goto IL_004a;
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
						goto IL_004a;
					}
					return;
				case 0:
					flag = ((Control)this).get_IsHandleCreated() || bool_14;
					num = 1;
					break;
				default:
					return;
					IL_004a:
					flag = (byte)num2 != 0;
					num = 3;
					break;
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

	protected bool Boolean_5
	{
		get
		{
			if (1 == 0)
			{
			}
			return bool_13;
		}
	}

	protected bool Boolean_6
	{
		get
		{
			bool flag = ((Control)this).get_Parent() != null;
			int num = 0;
			bool result = default(bool);
			while (true)
			{
				switch (num)
				{
				case 0:
					if (!flag)
					{
						result = false;
						num = 1;
					}
					else
					{
						result = ((Control)this).get_Parent().get_Parent() != null;
						num = 2;
					}
					break;
				default:
					return result;
				}
			}
		}
	}

	protected int Int32_0
	{
		get
		{
			if (1 == 0)
			{
			}
			return int_2;
		}
		set
		{
			int_2 = value;
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
			return int_3;
		}
		set
		{
			int_3 = value;
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

	protected int Int32_2
	{
		get
		{
			if (1 == 0)
			{
			}
			return int_4;
		}
		set
		{
			int_4 = value;
			int num = 0;
			bool flag = default(bool);
			while (true)
			{
				switch (num)
				{
				case 2:
					((Control)this).Invalidate();
					num = 3;
					break;
				case 1:
					if (!flag)
					{
						rectangle_0 = new Rectangle(7, 7, ((Control)this).get_Width() - 14, value - 7);
						num = 2;
						break;
					}
					return;
				case 0:
					flag = bool_14;
					num = 1;
					break;
				default:
					return;
				}
			}
		}
	}

	protected bool Boolean_7
	{
		get
		{
			if (1 == 0)
			{
			}
			return bool_14;
		}
		set
		{
			bool_14 = value;
			int num = 0;
			bool flag = default(bool);
			while (true)
			{
				switch (num)
				{
				case 4:
					((Control)this).Invalidate();
					num = 5;
					break;
				case 3:
					method_15();
					num = 4;
					break;
				case 2:
					if (!flag)
					{
						((Control)this).set_BackColor(Color.Transparent);
						num = 3;
						break;
					}
					goto case 3;
				case 1:
					flag = !bool_12 || !bool_7;
					num = 2;
					break;
				case 0:
					Boolean_4 = bool_12;
					num = 1;
					break;
				default:
					return;
				}
			}
		}
	}

	protected bool Boolean_8
	{
		get
		{
			if (1 == 0)
			{
			}
			return bool_15;
		}
		set
		{
			bool_15 = value;
			for (int num = 0; num == 0; num = 1)
			{
				method_17();
			}
		}
	}

	public GControl0()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		if (1 == 0)
		{
		}
		message_0 = (Message[])(object)new Message[9];
		bool_8 = true;
		bool_9 = true;
		bool_10 = true;
		dictionary_0 = new Dictionary<string, Color>();
		int_4 = 24;
		((ContainerControl)this)._002Ector();
		((Control)this).SetStyle((ControlStyles)139270, true);
		size_0 = Size.Empty;
		((Control)this).set_Font(new Font("Verdana", 8f));
		bitmap_1 = new Bitmap(1, 1);
		graphics_1 = Graphics.FromImage((Image)(object)bitmap_1);
		graphicsPath_0 = new GraphicsPath();
		method_16();
	}

	protected sealed override void OnHandleCreated(EventArgs e)
	{
		bool flag = !bool_0;
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 12:
				((Control)this).OnHandleCreated(e);
				num = 13;
				break;
			case 11:
				if (!flag)
				{
					((Control)this).set_BackColor(Color.Transparent);
					num = 12;
					break;
				}
				goto case 12;
			case 10:
				flag = !bool_12 || !bool_7;
				num = 11;
				break;
			case 9:
				Boolean_4 = bool_12;
				num = 10;
				break;
			case 8:
				if (!flag)
				{
					((Control)this).set_Dock((DockStyle)5);
					num = 9;
					break;
				}
				goto case 9;
			case 7:
				flag = bool_14;
				num = 8;
				break;
			case 6:
				if (!flag)
				{
					((Control)this).set_Height(int_3);
					num = 7;
					break;
				}
				goto case 7;
			case 5:
				flag = int_3 == 0;
				num = 6;
				break;
			case 4:
				if (!flag)
				{
					((Control)this).set_Width(int_2);
					num = 5;
					break;
				}
				goto case 5;
			case 3:
				flag = int_2 == 0;
				num = 4;
				break;
			case 2:
				vmethod_0();
				num = 3;
				break;
			case 1:
				method_16();
				num = 2;
				break;
			case 0:
				if (!flag)
				{
					method_5();
					num = 1;
					break;
				}
				goto case 1;
			default:
				return;
			}
		}
	}

	protected sealed override void OnParentChanged(EventArgs e)
	{
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		((ContainerControl)this).OnParentChanged(e);
		int num = 0;
		bool flag = default(bool);
		while (true)
		{
			switch (num)
			{
			case 12:
				method_17();
				num = 13;
				break;
			case 11:
				bool_0 = true;
				num = 12;
				break;
			case 10:
				vmethod_2();
				num = 11;
				break;
			case 9:
				((Control)this).get_Parent().set_BackColor(((Control)this).get_BackColor());
				num = 10;
				break;
			case 8:
				if (!flag)
				{
					((ContainerControl)this).get_ParentForm().add_Shown((EventHandler)method_1);
					num = 9;
					break;
				}
				goto case 9;
			case 7:
				flag = ((Component)this).DesignMode;
				num = 8;
				break;
			case 6:
				((ContainerControl)this).get_ParentForm().set_TransparencyKey(color_0);
				num = 7;
				break;
			case 5:
				if (!flag)
				{
					((ContainerControl)this).get_ParentForm().set_FormBorderStyle(formBorderStyle_0);
					num = 6;
					break;
				}
				goto case 9;
			case 4:
				flag = !bool_13;
				num = 5;
				break;
			case 3:
				if (!flag)
				{
					method_5();
					num = 4;
					break;
				}
				goto case 10;
			case 2:
				flag = bool_14;
				num = 3;
				break;
			case 1:
				if (flag)
				{
					bool_13 = ((Control)this).get_Parent() is Form;
					num = 2;
					break;
				}
				return;
			case 0:
				flag = ((Control)this).get_Parent() != null;
				num = 1;
				break;
			default:
				return;
			}
		}
	}

	private void method_0(bool bool_16)
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
				flag = !bool_16;
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
					flag = !bool_12 || !bool_14;
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

	private void method_1(object sender, EventArgs e)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Invalid comparison between Unknown and I4
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Invalid comparison between Unknown and I4
		bool flag = !bool_14 && !bool_1;
		int num = 0;
		Rectangle bounds = default(Rectangle);
		Rectangle bounds2 = default(Rectangle);
		while (true)
		{
			switch (num)
			{
			case 3:
				((ContainerControl)this).get_ParentForm().set_Location(new Point(bounds.Width / 2 - bounds2.Width / 2, bounds.Height / 2 - bounds2.Width / 2));
				num = 4;
				break;
			case 2:
				bounds2 = ((Control)((ContainerControl)this).get_ParentForm()).get_Bounds();
				num = 3;
				break;
			case 1:
				if (!flag)
				{
					bounds = Screen.get_PrimaryScreen().get_Bounds();
					num = 2;
					break;
				}
				goto default;
			case 0:
				if (flag)
				{
					flag = (int)formStartPosition_0 != 4 && (int)formStartPosition_0 != 1;
					num = 1;
					break;
				}
				return;
			default:
				bool_1 = true;
				return;
			}
		}
	}

	protected sealed override void OnSizeChanged(EventArgs e)
	{
		bool flag = !bool_9 || bool_14;
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 3:
				((Control)this).OnSizeChanged(e);
				num = 4;
				break;
			case 2:
				((Control)this).Invalidate();
				num = 3;
				break;
			case 1:
				method_15();
				num = 2;
				break;
			case 0:
				if (!flag)
				{
					rectangle_0 = new Rectangle(7, 7, ((Control)this).get_Width() - 14, int_4 - 7);
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
		bool flag = int_2 == 0;
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 1:
				if (!flag)
				{
					height = int_3;
				}
				((Control)this).SetBoundsCore(x, y, width, height, specified);
				num = 2;
				break;
			case 0:
				if (!flag)
				{
					width = int_2;
				}
				flag = int_3 == 0;
				num = 1;
				break;
			default:
				return;
			}
		}
	}

	private void method_2(GEnum0 genum0_1)
	{
		genum0_0 = genum0_1;
		for (int num = 0; num == 0; num = 1)
		{
			((Control)this).Invalidate();
		}
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Invalid comparison between Unknown and I4
		bool flag = bool_13 && (int)((ContainerControl)this).get_ParentForm().get_WindowState() == 2;
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 2:
				((Control)this).OnMouseMove(e);
				num = 3;
				break;
			case 1:
				if (!flag)
				{
					method_4();
					num = 2;
					break;
				}
				goto case 2;
			case 0:
				if (!flag)
				{
					flag = !bool_10 || bool_14;
					num = 1;
					break;
				}
				goto case 2;
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
					method_2(GEnum0.const_0);
					num = 1;
				}
				else
				{
					method_2(GEnum0.const_3);
					num = 2;
				}
				break;
			default:
				return;
			}
		}
	}

	protected override void OnMouseEnter(EventArgs e)
	{
		method_2(GEnum0.const_1);
		for (int num = 0; num == 0; num = 1)
		{
			((Control)this).OnMouseEnter(e);
		}
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		method_2(GEnum0.const_1);
		for (int num = 0; num == 0; num = 1)
		{
			((Control)this).OnMouseUp(e);
		}
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		method_2(GEnum0.const_0);
		int num = 0;
		bool flag = default(bool);
		while (true)
		{
			switch (num)
			{
			case 4:
				((Control)this).OnMouseLeave(e);
				num = 5;
				break;
			case 3:
				int_1 = 0;
				num = 4;
				break;
			case 2:
				if (!flag)
				{
					((Control)this).set_Cursor(Cursors.get_Default());
					num = 3;
					break;
				}
				goto case 4;
			case 1:
				if (!flag)
				{
					flag = !bool_10 || bool_14;
					num = 2;
					break;
				}
				goto case 4;
			case 0:
				flag = ((Control)this).GetChildAtPoint(((Control)this).PointToClient(Control.get_MousePosition())) == null;
				num = 1;
				break;
			default:
				return;
			}
		}
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Invalid comparison between Unknown and I4
		bool flag = (int)e.get_Button() != 1048576;
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 6:
			case 10:
				((Control)this).OnMouseDown(e);
				num = 11;
				break;
			case 9:
				((Control)this).DefWndProc(ref message_0[int_1]);
				num = 10;
				break;
			case 8:
				bool_2 = true;
				num = 9;
				break;
			case 7:
				if (!flag)
				{
					((Control)this).set_Capture(false);
					num = 8;
					break;
				}
				goto case 6;
			case 5:
				((Control)this).DefWndProc(ref message_0[0]);
				num = 6;
				break;
			case 4:
				bool_2 = true;
				num = 5;
				break;
			case 3:
				if (!flag)
				{
					((Control)this).set_Capture(false);
					num = 4;
				}
				else
				{
					flag = !bool_10 || int_1 == 0;
					num = 7;
				}
				break;
			case 2:
				if (!flag)
				{
					flag = !bool_9 || !rectangle_0.Contains(e.get_Location());
					num = 3;
					break;
				}
				goto case 6;
			case 1:
				flag = (bool_13 && (int)((ContainerControl)this).get_ParentForm().get_WindowState() == 2) || bool_14;
				num = 2;
				break;
			case 0:
				if (!flag)
				{
					method_2(GEnum0.const_2);
					num = 1;
					break;
				}
				goto case 1;
			default:
				return;
			}
		}
	}

	protected override void WndProc(ref Message m)
	{
		((ContainerControl)this).WndProc(ref m);
		int num = 0;
		bool flag = default(bool);
		while (true)
		{
			switch (num)
			{
			case 5:
				if (!flag)
				{
					method_6(new Rectangle(Point.Empty, ((Control)this).get_Parent().get_Parent().get_Size()));
					num = 6;
				}
				else
				{
					method_6(Screen.FromControl(((Control)this).get_Parent()).get_WorkingArea());
					num = 7;
				}
				break;
			case 4:
				if (flag)
				{
					flag = !Boolean_6;
					num = 5;
					break;
				}
				return;
			case 3:
				flag = bool_8;
				num = 4;
				break;
			case 2:
				method_2(GEnum0.const_1);
				num = 3;
				break;
			case 1:
				if (!flag)
				{
					bool_2 = false;
					num = 2;
					break;
				}
				return;
			case 0:
				flag = !bool_2 || ((Message)(ref m)).get_Msg() != 513;
				num = 1;
				break;
			default:
				return;
			}
		}
	}

	private int method_3()
	{
		point_0 = ((Control)this).PointToClient(Control.get_MousePosition());
		int num = 0;
		bool flag = default(bool);
		int result = default(int);
		while (true)
		{
			switch (num)
			{
			case 19:
				if (!flag)
				{
					result = 6;
					num = 20;
				}
				else
				{
					result = 0;
					num = 21;
				}
				break;
			case 17:
				if (!flag)
				{
					result = 3;
					num = 18;
				}
				else
				{
					flag = !bool_6;
					num = 19;
				}
				break;
			case 15:
				if (!flag)
				{
					result = 2;
					num = 16;
				}
				else
				{
					flag = !bool_5;
					num = 17;
				}
				break;
			case 13:
				if (!flag)
				{
					result = 1;
					num = 14;
				}
				else
				{
					flag = !bool_4;
					num = 15;
				}
				break;
			case 11:
				if (!flag)
				{
					result = 8;
					num = 12;
				}
				else
				{
					flag = !bool_3;
					num = 13;
				}
				break;
			case 9:
				if (!flag)
				{
					result = 5;
					num = 10;
				}
				else
				{
					flag = !bool_4 || !bool_6;
					num = 11;
				}
				break;
			case 7:
				if (!flag)
				{
					result = 7;
					num = 8;
				}
				else
				{
					flag = !bool_4 || !bool_5;
					num = 9;
				}
				break;
			case 5:
				if (!flag)
				{
					result = 4;
					num = 6;
				}
				else
				{
					flag = !bool_3 || !bool_6;
					num = 7;
				}
				break;
			case 4:
				flag = !bool_3 || !bool_5;
				num = 5;
				break;
			case 3:
				bool_6 = point_0.Y > ((Control)this).get_Height() - 7;
				num = 4;
				break;
			case 2:
				bool_5 = point_0.Y < 7;
				num = 3;
				break;
			case 1:
				bool_4 = point_0.X > ((Control)this).get_Width() - 7;
				num = 2;
				break;
			case 0:
				bool_3 = point_0.X < 7;
				num = 1;
				break;
			default:
				return result;
			}
		}
	}

	private void method_4()
	{
		int_0 = method_3();
		int num = 0;
		int num2 = default(int);
		bool flag = default(bool);
		while (true)
		{
			switch (num)
			{
			case 3:
				switch (num2)
				{
				default:
					return;
				case 0:
					((Control)this).set_Cursor(Cursors.get_Default());
					num = 4;
					break;
				case 1:
				case 2:
					((Control)this).set_Cursor(Cursors.get_SizeWE());
					num = 5;
					break;
				case 3:
				case 6:
					((Control)this).set_Cursor(Cursors.get_SizeNS());
					num = 6;
					break;
				case 5:
				case 7:
					((Control)this).set_Cursor(Cursors.get_SizeNESW());
					num = 8;
					break;
				case 4:
				case 8:
					((Control)this).set_Cursor(Cursors.get_SizeNWSE());
					num = 7;
					break;
				}
				break;
			case 2:
				num2 = int_1;
				num = 3;
				break;
			case 1:
				if (flag)
				{
					int_1 = int_0;
					num = 2;
					break;
				}
				return;
			case 0:
				flag = int_0 != int_1;
				num = 1;
				break;
			default:
				return;
			}
		}
	}

	private void method_5()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		ref Message reference = ref message_0[0];
		reference = Message.Create(((Control)this).get_Parent().get_Handle(), 161, new IntPtr(2), IntPtr.Zero);
		int num = 0;
		int num2 = default(int);
		bool flag = default(bool);
		while (true)
		{
			switch (num)
			{
			case 2:
				num2++;
				goto case 1;
			case 1:
				flag = num2 <= 8;
				num = 3;
				continue;
			case 0:
				num2 = 1;
				num = 1;
				continue;
			}
			if (flag)
			{
				ref Message reference2 = ref message_0[num2];
				reference2 = Message.Create(((Control)this).get_Parent().get_Handle(), 161, new IntPtr(num2 + 9), IntPtr.Zero);
				num = 2;
				continue;
			}
			return;
		}
	}

	private void method_6(Rectangle rectangle_5)
	{
		bool flag = ((Control)this).get_Parent().get_Width() <= rectangle_5.Width;
		int num = 0;
		int num3 = default(int);
		int num2 = default(int);
		int num4 = default(int);
		int num5 = default(int);
		Point location = default(Point);
		while (true)
		{
			switch (num)
			{
			case 13:
				if (!flag)
				{
					num3 = num2 - ((Control)this).get_Parent().get_Height();
				}
				((Control)this).get_Parent().set_Location(new Point(num4, num3));
				num = 14;
				break;
			case 12:
				if (!flag)
				{
					num4 = num5 - ((Control)this).get_Parent().get_Width();
				}
				flag = num3 + ((Control)this).get_Parent().get_Height() <= num2;
				num = 13;
				break;
			case 11:
				flag = num4 + ((Control)this).get_Parent().get_Width() <= num5;
				num = 12;
				break;
			case 10:
				num2 = rectangle_5.Y + rectangle_5.Height;
				num = 11;
				break;
			case 9:
				if (!flag)
				{
					num3 = rectangle_5.Y;
				}
				num5 = rectangle_5.X + rectangle_5.Width;
				num = 10;
				break;
			case 8:
				if (!flag)
				{
					num4 = rectangle_5.X;
				}
				flag = num3 >= rectangle_5.Y;
				num = 9;
				break;
			case 7:
				flag = num4 >= rectangle_5.X;
				num = 8;
				break;
			case 6:
				num3 = location.Y;
				num = 7;
				break;
			case 5:
				location = ((Control)this).get_Parent().get_Location();
				num = 6;
				break;
			case 4:
				num4 = location.X;
				num = 5;
				break;
			case 3:
				location = ((Control)this).get_Parent().get_Location();
				num = 4;
				break;
			case 2:
				if (!flag)
				{
					((Control)this).get_Parent().set_Height(rectangle_5.Height);
					num = 3;
					break;
				}
				goto case 3;
			case 1:
				flag = ((Control)this).get_Parent().get_Height() <= rectangle_5.Height;
				num = 2;
				break;
			case 0:
				if (!flag)
				{
					((Control)this).get_Parent().set_Width(rectangle_5.Width);
					num = 1;
					break;
				}
				goto case 1;
			default:
				return;
			}
		}
	}

	protected Pen method_7(string string_1)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		if (1 == 0)
		{
		}
		return new Pen(dictionary_0[string_1]);
	}

	protected Pen method_8(string string_1, float float_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		if (1 == 0)
		{
		}
		return new Pen(dictionary_0[string_1], float_0);
	}

	protected SolidBrush method_9(string string_1)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		if (1 == 0)
		{
		}
		return new SolidBrush(dictionary_0[string_1]);
	}

	protected Color method_10(string string_1)
	{
		if (1 == 0)
		{
		}
		return dictionary_0[string_1];
	}

	protected void method_11(string string_1, Color color_1)
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
					dictionary_0[string_1] = color_1;
					num = 1;
				}
				else
				{
					dictionary_0.Add(string_1, color_1);
					num = 2;
				}
				break;
			default:
				return;
			}
		}
	}

	protected void method_12(string string_1, byte byte_0, byte byte_1, byte byte_2)
	{
		if (1 == 0)
		{
		}
		method_11(string_1, Color.FromArgb(byte_0, byte_1, byte_2));
	}

	protected void method_13(string string_1, byte byte_0, byte byte_1, byte byte_2, byte byte_3)
	{
		if (1 == 0)
		{
		}
		method_11(string_1, Color.FromArgb(byte_0, byte_1, byte_2, byte_3));
	}

	protected void method_14(string string_1, byte byte_0, Color color_1)
	{
		if (1 == 0)
		{
		}
		method_11(string_1, Color.FromArgb(byte_0, color_1));
	}

	private void method_15()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		bool flag = !bool_12 || !bool_14;
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 4:
				bitmap_0 = null;
				num = 5;
				break;
			case 2:
				graphics_0 = Graphics.FromImage((Image)(object)bitmap_0);
				num = 3;
				break;
			case 1:
				if (flag)
				{
					bitmap_0 = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height(), (PixelFormat)925707);
					num = 2;
					break;
				}
				return;
			case 0:
				if (!flag)
				{
					flag = ((Control)this).get_Width() != 0 && ((Control)this).get_Height() != 0;
					num = 1;
				}
				else
				{
					graphics_0 = null;
					num = 4;
				}
				break;
			default:
				return;
			}
		}
	}

	private void method_16()
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

	private void method_17()
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
					flag = !bool_15;
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

	protected Rectangle method_18(Rectangle rectangle_5, int int_5)
	{
		rectangle_1 = new Rectangle(rectangle_5.X + int_5, rectangle_5.Y + int_5, rectangle_5.Width - int_5 * 2, rectangle_5.Height - int_5 * 2);
		Rectangle result = default(Rectangle);
		for (int num = 0; num == 0; num = 1)
		{
			result = rectangle_1;
		}
		return result;
	}

	protected Size method_19(Size size_3, int int_5)
	{
		size_1 = new Size(size_3.Width + int_5, size_3.Height + int_5);
		Size result = default(Size);
		for (int num = 0; num == 0; num = 1)
		{
			result = size_1;
		}
		return result;
	}

	protected Point method_20(Point point_5, int int_5)
	{
		point_1 = new Point(point_5.X + int_5, point_5.Y + int_5);
		Point result = default(Point);
		for (int num = 0; num == 0; num = 1)
		{
			result = point_1;
		}
		return result;
	}

	protected Point method_21(Rectangle rectangle_5, Rectangle rectangle_6)
	{
		point_2 = new Point(rectangle_5.Width / 2 - rectangle_6.Width / 2 + rectangle_5.X + rectangle_6.X, rectangle_5.Height / 2 - rectangle_6.Height / 2 + rectangle_5.Y + rectangle_6.Y);
		Point result = default(Point);
		for (int num = 0; num == 0; num = 1)
		{
			result = point_2;
		}
		return result;
	}

	protected Point method_22(Rectangle rectangle_5, Size size_3)
	{
		point_2 = new Point(rectangle_5.Width / 2 - size_3.Width / 2 + rectangle_5.X, rectangle_5.Height / 2 - size_3.Height / 2 + rectangle_5.Y);
		Point result = default(Point);
		for (int num = 0; num == 0; num = 1)
		{
			result = point_2;
		}
		return result;
	}

	protected Point method_23(Rectangle rectangle_5)
	{
		if (1 == 0)
		{
		}
		return method_27(((Control)this).get_Width(), ((Control)this).get_Height(), rectangle_5.Width, rectangle_5.Height);
	}

	protected Point method_24(Size size_3)
	{
		if (1 == 0)
		{
		}
		return method_27(((Control)this).get_Width(), ((Control)this).get_Height(), size_3.Width, size_3.Height);
	}

	protected Point method_25(int int_5, int int_6)
	{
		if (1 == 0)
		{
		}
		return method_27(((Control)this).get_Width(), ((Control)this).get_Height(), int_5, int_6);
	}

	protected Point method_26(Size size_3, Size size_4)
	{
		if (1 == 0)
		{
		}
		return method_27(size_3.Width, size_3.Height, size_4.Width, size_4.Height);
	}

	protected Point method_27(int int_5, int int_6, int int_7, int int_8)
	{
		point_2 = new Point(int_5 / 2 - int_7 / 2, int_6 / 2 - int_8 / 2);
		Point result = default(Point);
		for (int num = 0; num == 0; num = 1)
		{
			result = point_2;
		}
		return result;
	}

	protected Size method_28()
	{
		lock (graphics_1)
		{
			SizeF sizeF = graphics_1.MeasureString(((Control)this).get_Text(), ((Control)this).get_Font(), ((Control)this).get_Width());
			Size result = default(Size);
			for (int num = 0; num == 0; num = 1)
			{
				result = sizeF.ToSize();
			}
			return result;
		}
	}

	protected Size method_29(string string_1)
	{
		lock (graphics_1)
		{
			SizeF sizeF = graphics_1.MeasureString(string_1, ((Control)this).get_Font(), ((Control)this).get_Width());
			Size result = default(Size);
			for (int num = 0; num == 0; num = 1)
			{
				result = sizeF.ToSize();
			}
			return result;
		}
	}

	protected void method_30(Color color_1, int int_5, int int_6)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		bool flag = !bool_12;
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 2:
				graphics_0.FillRectangle((Brush)(object)solidBrush_0, int_5, int_6, 1, 1);
				num = 3;
				break;
			case 0:
				if (!flag)
				{
					bitmap_0.SetPixel(int_5, int_6, color_1);
					num = 1;
				}
				else
				{
					solidBrush_0 = new SolidBrush(color_1);
					num = 2;
				}
				break;
			default:
				return;
			}
		}
	}

	protected void method_31(Color color_1, int int_5)
	{
		if (1 == 0)
		{
		}
		method_33(color_1, 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height(), int_5);
	}

	protected void method_32(Color color_1, Rectangle rectangle_5, int int_5)
	{
		if (1 == 0)
		{
		}
		method_33(color_1, rectangle_5.X, rectangle_5.Y, rectangle_5.Width, rectangle_5.Height, int_5);
	}

	protected void method_33(Color color_1, int int_5, int int_6, int int_7, int int_8, int int_9)
	{
		if (1 == 0)
		{
		}
		method_36(color_1, int_5 + int_9, int_6 + int_9, int_7 - int_9 * 2, int_8 - int_9 * 2);
	}

	protected void method_34(Color color_1)
	{
		if (1 == 0)
		{
		}
		method_36(color_1, 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
	}

	protected void method_35(Color color_1, Rectangle rectangle_5)
	{
		if (1 == 0)
		{
		}
		method_36(color_1, rectangle_5.X, rectangle_5.Y, rectangle_5.Width, rectangle_5.Height);
	}

	protected void method_36(Color color_1, int int_5, int int_6, int int_7, int int_8)
	{
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		bool flag = !bool_11;
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 9:
				graphics_0.FillRectangle((Brush)(object)solidBrush_1, int_5 + (int_7 - 1), int_6 + (int_8 - 1), 1, 1);
				num = 10;
				break;
			case 8:
				graphics_0.FillRectangle((Brush)(object)solidBrush_1, int_5, int_6 + (int_8 - 1), 1, 1);
				num = 9;
				break;
			case 7:
				graphics_0.FillRectangle((Brush)(object)solidBrush_1, int_5 + (int_7 - 1), int_6, 1, 1);
				num = 8;
				break;
			case 6:
				graphics_0.FillRectangle((Brush)(object)solidBrush_1, int_5, int_6, 1, 1);
				num = 7;
				break;
			case 4:
				bitmap_0.SetPixel(int_5 + (int_7 - 1), int_6 + (int_8 - 1), color_1);
				num = 5;
				break;
			case 3:
				bitmap_0.SetPixel(int_5, int_6 + (int_8 - 1), color_1);
				num = 4;
				break;
			case 2:
				bitmap_0.SetPixel(int_5 + (int_7 - 1), int_6, color_1);
				num = 3;
				break;
			case 1:
				if (!flag)
				{
					bitmap_0.SetPixel(int_5, int_6, color_1);
					num = 2;
				}
				else
				{
					solidBrush_1 = new SolidBrush(color_1);
					num = 6;
				}
				break;
			case 0:
				if (flag)
				{
					flag = !bool_12;
					num = 1;
					break;
				}
				return;
			default:
				return;
			}
		}
	}

	protected void method_37(Pen pen_0, int int_5)
	{
		if (1 == 0)
		{
		}
		method_39(pen_0, 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height(), int_5);
	}

	protected void method_38(Pen pen_0, Rectangle rectangle_5, int int_5)
	{
		if (1 == 0)
		{
		}
		method_39(pen_0, rectangle_5.X, rectangle_5.Y, rectangle_5.Width, rectangle_5.Height, int_5);
	}

	protected void method_39(Pen pen_0, int int_5, int int_6, int int_7, int int_8, int int_9)
	{
		if (1 == 0)
		{
		}
		method_42(pen_0, int_5 + int_9, int_6 + int_9, int_7 - int_9 * 2, int_8 - int_9 * 2);
	}

	protected void method_40(Pen pen_0)
	{
		if (1 == 0)
		{
		}
		method_42(pen_0, 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
	}

	protected void method_41(Pen pen_0, Rectangle rectangle_5)
	{
		if (1 == 0)
		{
		}
		method_42(pen_0, rectangle_5.X, rectangle_5.Y, rectangle_5.Width, rectangle_5.Height);
	}

	protected void method_42(Pen pen_0, int int_5, int int_6, int int_7, int int_8)
	{
		if (1 == 0)
		{
		}
		graphics_0.DrawRectangle(pen_0, int_5, int_6, int_7 - 1, int_8 - 1);
	}

	protected void method_43(Brush brush_0, HorizontalAlignment horizontalAlignment_0, int int_5, int int_6)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (1 == 0)
		{
		}
		method_44(brush_0, ((Control)this).get_Text(), horizontalAlignment_0, int_5, int_6);
	}

	protected void method_44(Brush brush_0, string string_1, HorizontalAlignment horizontalAlignment_0, int int_5, int int_6)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected I4, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
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
					graphics_0.DrawString(string_1, ((Control)this).get_Font(), brush_0, (float)int_5, (float)(point_3.Y + int_6));
					num = 4;
					break;
				case 1:
					graphics_0.DrawString(string_1, ((Control)this).get_Font(), brush_0, (float)(((Control)this).get_Width() - size_2.Width - int_5), (float)(point_3.Y + int_6));
					num = 6;
					break;
				case 2:
					graphics_0.DrawString(string_1, ((Control)this).get_Font(), brush_0, (float)(point_3.X + int_5), (float)(point_3.Y + int_6));
					num = 5;
					break;
				}
				break;
			case 2:
				val = horizontalAlignment_0;
				num = 3;
				break;
			case 1:
				point_3 = new Point(((Control)this).get_Width() / 2 - size_2.Width / 2, Int32_2 / 2 - size_2.Height / 2);
				num = 2;
				break;
			case 0:
				if (flag)
				{
					size_2 = method_29(string_1);
					num = 1;
					break;
				}
				return;
			default:
				return;
			}
		}
	}

	protected void method_45(Brush brush_0, Point point_5)
	{
		bool flag = ((Control)this).get_Text().Length != 0;
		int num = 0;
		while (num == 0 && flag)
		{
			graphics_0.DrawString(((Control)this).get_Text(), ((Control)this).get_Font(), brush_0, (PointF)point_5);
			num = 1;
		}
	}

	protected void method_46(Brush brush_0, int int_5, int int_6)
	{
		bool flag = ((Control)this).get_Text().Length != 0;
		int num = 0;
		while (num == 0 && flag)
		{
			graphics_0.DrawString(((Control)this).get_Text(), ((Control)this).get_Font(), brush_0, (float)int_5, (float)int_6);
			num = 1;
		}
	}

	protected void method_47(HorizontalAlignment horizontalAlignment_0, int int_5, int int_6)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		if (1 == 0)
		{
		}
		method_48(image_0, horizontalAlignment_0, int_5, int_6);
	}

	protected void method_48(Image image_1, HorizontalAlignment horizontalAlignment_0, int int_5, int int_6)
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
					graphics_0.DrawImage(image_1, int_5, point_4.Y + int_6, image_1.get_Width(), image_1.get_Height());
					num = 3;
					break;
				case 1:
					graphics_0.DrawImage(image_1, ((Control)this).get_Width() - image_1.get_Width() - int_5, point_4.Y + int_6, image_1.get_Width(), image_1.get_Height());
					num = 5;
					break;
				case 2:
					graphics_0.DrawImage(image_1, point_4.X + int_5, point_4.Y + int_6, image_1.get_Width(), image_1.get_Height());
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
					point_4 = new Point(((Control)this).get_Width() / 2 - image_1.get_Width() / 2, Int32_2 / 2 - image_1.get_Height() / 2);
					num = 1;
					break;
				}
				return;
			default:
				return;
			}
		}
	}

	protected void method_49(Point point_5)
	{
		if (1 == 0)
		{
		}
		method_52(image_0, point_5.X, point_5.Y);
	}

	protected void method_50(int int_5, int int_6)
	{
		if (1 == 0)
		{
		}
		method_52(image_0, int_5, int_6);
	}

	protected void method_51(Image image_1, Point point_5)
	{
		if (1 == 0)
		{
		}
		method_52(image_1, point_5.X, point_5.Y);
	}

	protected void method_52(Image image_1, int int_5, int int_6)
	{
		bool flag = image_1 != null;
		int num = 0;
		while (num == 0 && flag)
		{
			graphics_0.DrawImage(image_1, int_5, int_6, image_1.get_Width(), image_1.get_Height());
			num = 1;
		}
	}

	protected void method_53(ColorBlend colorBlend_0, int int_5, int int_6, int int_7, int int_8)
	{
		rectangle_2 = new Rectangle(int_5, int_6, int_7, int_8);
		for (int num = 0; num == 0; num = 1)
		{
			method_55(colorBlend_0, rectangle_2);
		}
	}

	protected void method_54(ColorBlend colorBlend_0, int int_5, int int_6, int int_7, int int_8, float float_0)
	{
		rectangle_2 = new Rectangle(int_5, int_6, int_7, int_8);
		for (int num = 0; num == 0; num = 1)
		{
			method_56(colorBlend_0, rectangle_2, float_0);
		}
	}

	protected void method_55(ColorBlend colorBlend_0, Rectangle rectangle_5)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		linearGradientBrush_0 = new LinearGradientBrush(rectangle_5, Color.Empty, Color.Empty, 90f);
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 1:
				graphics_0.FillRectangle((Brush)(object)linearGradientBrush_0, rectangle_5);
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

	protected void method_56(ColorBlend colorBlend_0, Rectangle rectangle_5, float float_0)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		linearGradientBrush_0 = new LinearGradientBrush(rectangle_5, Color.Empty, Color.Empty, float_0);
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 1:
				graphics_0.FillRectangle((Brush)(object)linearGradientBrush_0, rectangle_5);
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

	protected void method_57(Color color_1, Color color_2, int int_5, int int_6, int int_7, int int_8)
	{
		rectangle_2 = new Rectangle(int_5, int_6, int_7, int_8);
		for (int num = 0; num == 0; num = 1)
		{
			method_59(color_1, color_2, rectangle_2);
		}
	}

	protected void method_58(Color color_1, Color color_2, int int_5, int int_6, int int_7, int int_8, float float_0)
	{
		rectangle_2 = new Rectangle(int_5, int_6, int_7, int_8);
		for (int num = 0; num == 0; num = 1)
		{
			method_60(color_1, color_2, rectangle_2, float_0);
		}
	}

	protected void method_59(Color color_1, Color color_2, Rectangle rectangle_5)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		linearGradientBrush_0 = new LinearGradientBrush(rectangle_5, color_1, color_2, 90f);
		for (int num = 0; num == 0; num = 1)
		{
			graphics_0.FillRectangle((Brush)(object)linearGradientBrush_0, rectangle_5);
		}
	}

	protected void method_60(Color color_1, Color color_2, Rectangle rectangle_5, float float_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		linearGradientBrush_0 = new LinearGradientBrush(rectangle_5, color_1, color_2, float_0);
		for (int num = 0; num == 0; num = 1)
		{
			graphics_0.FillRectangle((Brush)(object)linearGradientBrush_0, rectangle_5);
		}
	}

	public void method_61(ColorBlend colorBlend_0, int int_5, int int_6, int int_7, int int_8)
	{
		rectangle_3 = new Rectangle(int_5, int_6, int_7, int_8);
		for (int num = 0; num == 0; num = 1)
		{
			method_66(colorBlend_0, rectangle_3, int_7 / 2, int_8 / 2);
		}
	}

	public void method_62(ColorBlend colorBlend_0, int int_5, int int_6, int int_7, int int_8, Point point_5)
	{
		rectangle_3 = new Rectangle(int_5, int_6, int_7, int_8);
		for (int num = 0; num == 0; num = 1)
		{
			method_66(colorBlend_0, rectangle_3, point_5.X, point_5.Y);
		}
	}

	public void method_63(ColorBlend colorBlend_0, int int_5, int int_6, int int_7, int int_8, int int_9, int int_10)
	{
		rectangle_3 = new Rectangle(int_5, int_6, int_7, int_8);
		for (int num = 0; num == 0; num = 1)
		{
			method_66(colorBlend_0, rectangle_3, int_9, int_10);
		}
	}

	public void method_64(ColorBlend colorBlend_0, Rectangle rectangle_5)
	{
		if (1 == 0)
		{
		}
		method_66(colorBlend_0, rectangle_5, rectangle_5.Width / 2, rectangle_5.Height / 2);
	}

	public void method_65(ColorBlend colorBlend_0, Rectangle rectangle_5, Point point_5)
	{
		if (1 == 0)
		{
		}
		method_66(colorBlend_0, rectangle_5, point_5.X, point_5.Y);
	}

	public void method_66(ColorBlend colorBlend_0, Rectangle rectangle_5, int int_5, int int_6)
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
					graphics_0.FillEllipse((Brush)(object)pathGradientBrush_0, rectangle_5.X + 1, rectangle_5.Y + 1, rectangle_5.Width - 3, rectangle_5.Height - 3);
					num = 6;
				}
				else
				{
					graphics_0.FillEllipse((Brush)(object)pathGradientBrush_0, rectangle_5);
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
				pathGradientBrush_0.set_CenterPoint((PointF)new Point(rectangle_5.X + int_5, rectangle_5.Y + int_6));
				num = 3;
				break;
			case 1:
				pathGradientBrush_0 = new PathGradientBrush(graphicsPath_0);
				num = 2;
				break;
			case 0:
				graphicsPath_0.AddEllipse(rectangle_5.X, rectangle_5.Y, rectangle_5.Width - 1, rectangle_5.Height - 1);
				num = 1;
				break;
			default:
				return;
			}
		}
	}

	protected void method_67(Color color_1, Color color_2, int int_5, int int_6, int int_7, int int_8)
	{
		rectangle_3 = new Rectangle(int_5, int_6, int_7, int_8);
		for (int num = 0; num == 0; num = 1)
		{
			method_69(color_1, color_2, rectangle_2);
		}
	}

	protected void method_68(Color color_1, Color color_2, int int_5, int int_6, int int_7, int int_8, float float_0)
	{
		rectangle_3 = new Rectangle(int_5, int_6, int_7, int_8);
		for (int num = 0; num == 0; num = 1)
		{
			method_70(color_1, color_2, rectangle_2, float_0);
		}
	}

	protected void method_69(Color color_1, Color color_2, Rectangle rectangle_5)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		linearGradientBrush_1 = new LinearGradientBrush(rectangle_5, color_1, color_2, 90f);
		for (int num = 0; num == 0; num = 1)
		{
			graphics_0.FillRectangle((Brush)(object)linearGradientBrush_0, rectangle_5);
		}
	}

	protected void method_70(Color color_1, Color color_2, Rectangle rectangle_5, float float_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		linearGradientBrush_1 = new LinearGradientBrush(rectangle_5, color_1, color_2, float_0);
		for (int num = 0; num == 0; num = 1)
		{
			graphics_0.FillEllipse((Brush)(object)linearGradientBrush_0, rectangle_5);
		}
	}

	public GraphicsPath method_71(int int_5, int int_6, int int_7, int int_8, int int_9)
	{
		rectangle_4 = new Rectangle(int_5, int_6, int_7, int_8);
		GraphicsPath result = default(GraphicsPath);
		for (int num = 0; num == 0; num = 1)
		{
			result = method_72(rectangle_4, int_9);
		}
		return result;
	}

	public GraphicsPath method_72(Rectangle rectangle_5, int int_5)
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
				graphicsPath_1.AddArc(rectangle_5.X, rectangle_5.Bottom - int_5, int_5, int_5, 90f, 90f);
				num = 4;
				break;
			case 2:
				graphicsPath_1.AddArc(rectangle_5.Right - int_5, rectangle_5.Bottom - int_5, int_5, int_5, 0f, 90f);
				num = 3;
				break;
			case 1:
				graphicsPath_1.AddArc(rectangle_5.Right - int_5, rectangle_5.Y, int_5, int_5, 270f, 90f);
				num = 2;
				break;
			case 0:
				graphicsPath_1.AddArc(rectangle_5.X, rectangle_5.Y, int_5, int_5, 180f, 90f);
				num = 1;
				break;
			default:
				return result;
			}
		}
	}
}
