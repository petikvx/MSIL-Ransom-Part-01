using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

public class GClass2 : Button
{
	private static PrivateFontCollection privateFontCollection_0;

	private FontFamily fontFamily_0;

	private static string string_0;

	private static string string_1;

	private string string_2;

	private float float_0;

	public static string String_0
	{
		get
		{
			return "ldYJbqb";
		}
		set
		{
			string_0 = value;
		}
	}

	public static string String_1
	{
		get
		{
			return "BwnS";
		}
		set
		{
			string_1 = value;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	Font Font
	{
		get
		{
			return this.method_1();
		}
		set
		{
			while (true)
			{
				int num = 1239526021;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x30F19698u) % 4u)
					{
					case 2u:
						num = ((int)num2 * -1955921426) ^ -1685477253;
						continue;
					case 1u:
						this.method_2(value);
						num = ((int)num2 * -1516377906) ^ -1222750172;
						continue;
					default:
						return;
					case 0u:
						break;
					case 3u:
						return;
					}
					break;
				}
			}
		}
	}

	[DefaultValue("Equinox Com")]
	public string String_2
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = -354551261;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF4F7EBFAu) % 4u)
					{
					case 1u:
						result = string_2;
						num = (int)(num2 * 2058007403) ^ -678141679;
						continue;
					case 0u:
						num = (int)(num2 * 1115517933) ^ -981055048;
						continue;
					case 3u:
						break;
					default:
						return result;
					}
					break;
				}
			}
		}
		set
		{
			string_2 = value;
			method_0();
			while (true)
			{
				int num = -1939943418;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCD55CE14u) % 3u)
					{
					case 1u:
						goto IL_000f;
					default:
						return;
					case 2u:
						break;
					case 0u:
						return;
					}
					break;
					IL_000f:
					num = ((int)num2 * -1220230934) ^ 0x4CA28682;
				}
			}
		}
	}

	[DefaultValue(14.25f)]
	public float Single_0
	{
		get
		{
			float result = float_0;
			while (true)
			{
				int num = 1506360918;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6B14D7B8u) % 3u)
					{
					case 1u:
						goto IL_0009;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0009:
					num = (int)(num2 * 978300099) ^ -756837423;
				}
			}
		}
		set
		{
			float_0 = value;
			while (true)
			{
				int num = 2107713823;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x25855704u) % 3u)
					{
					case 1u:
						goto IL_0009;
					default:
						return;
					case 0u:
						break;
					case 2u:
						return;
					}
					break;
					IL_0009:
					method_0();
					num = (int)(num2 * 625374879) ^ -185058865;
				}
			}
		}
	}

	public GClass2()
	{
		string_2 = "Equinox Com";
		float_0 = 14.25f;
		method_0();
	}

	public void method_0()
	{
		bool flag = default(bool);
		while (true)
		{
			int num = 934751194;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x371686Au) % 10u)
				{
				case 8u:
					flag = privateFontCollection_0 == null;
					num = ((int)num2 * -1922520936) ^ -2016021639;
					continue;
				case 7u:
				{
					int num5;
					if ((float_0 == 0f) | GClass2.smethod_1(string_2))
					{
						num = 517628675;
						num5 = 517628675;
					}
					else
					{
						num = 1021192408;
						num5 = 1021192408;
					}
					continue;
				}
				case 6u:
					num = (int)(num2 * 105706733) ^ -1671481495;
					continue;
				case 4u:
					privateFontCollection_0 = GClass2.smethod_0();
					num = ((int)num2 * -1886250755) ^ -1752536976;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -982023086;
						num4 = -982023086;
					}
					else
					{
						num3 = -1180547261;
						num4 = -1180547261;
					}
					num = num3 ^ ((int)num2 * -499766686);
					continue;
				}
				case 2u:
					System_002EWindows_002EForms_002EControl_002EFont = GClass2.smethod_3(fontFamily_0, float_0);
					num = (int)((num2 * 969853543) ^ 0x4F3C740B);
					continue;
				case 1u:
					num = (int)(num2 * 620302313) ^ -1610167164;
					continue;
				case 0u:
					fontFamily_0 = GClass2.smethod_2(string_2, (FontCollection)(object)privateFontCollection_0);
					num = 1034553176;
					continue;
				default:
					return;
				case 9u:
					break;
				case 5u:
					return;
				}
				break;
			}
		}
	}

	Font method_1()
	{
		return ((Control)this).get_Font();
	}

	void method_2(Font font_0)
	{
		((Control)this).set_Font(font_0);
	}

	static PrivateFontCollection smethod_0()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new PrivateFontCollection();
	}

	static bool smethod_1(string string_3)
	{
		return string.IsNullOrEmpty(string_3);
	}

	static FontFamily smethod_2(string string_3, FontCollection fontCollection_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new FontFamily(string_3, fontCollection_0);
	}

	static Font smethod_3(FontFamily fontFamily_1, float float_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new Font(fontFamily_1, float_1);
	}
}
