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
			return "LlAA";
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
			string result = default(string);
			while (true)
			{
				int num = -1434610975;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA339AAFCu) % 4u)
					{
					case 3u:
						num = ((int)num2 * -1044921076) ^ -854237018;
						continue;
					case 1u:
						result = "pygc";
						num = (int)((num2 * 408985142) ^ 0x72021E39);
						continue;
					case 0u:
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
			string_1 = value;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	Font Font
	{
		get
		{
			Font result = default(Font);
			while (true)
			{
				int num = 90980855;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x44C9E3DAu) % 4u)
					{
					case 2u:
						num = (int)((num2 * 1992901522) ^ 0x78B7FE1D);
						continue;
					case 1u:
						result = this.method_1();
						num = (int)((num2 * 114317775) ^ 0x5540EA8B);
						continue;
					case 0u:
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
			this.method_2(value);
			while (true)
			{
				int num = -934610662;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8B99AFE9u) % 3u)
					{
					case 1u:
						goto IL_0009;
					default:
						return;
					case 2u:
						break;
					case 0u:
						return;
					}
					break;
					IL_0009:
					num = ((int)num2 * -950435570) ^ -132940508;
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
				int num = -1224965818;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF11ADF43u) % 4u)
					{
					case 1u:
						result = string_2;
						num = ((int)num2 * -1302814578) ^ 0xA8444C1;
						continue;
					case 0u:
						num = (int)((num2 * 1802093470) ^ 0x313CD660);
						continue;
					case 2u:
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
				int num = -2137792758;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB712954Eu) % 3u)
					{
					case 2u:
						goto IL_0009;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0009:
					num = ((int)num2 * -531177791) ^ -709703708;
				}
			}
		}
		set
		{
			while (true)
			{
				int num = 1890541341;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x170D964u) % 4u)
					{
					case 3u:
						num = ((int)num2 * -1504681888) ^ -426482762;
						continue;
					case 1u:
						float_0 = value;
						method_0();
						num = ((int)num2 * -240103550) ^ 0x1D4C4F8D;
						continue;
					default:
						return;
					case 0u:
						break;
					case 2u:
						return;
					}
					break;
				}
			}
		}
	}

	public GClass2()
	{
		while (true)
		{
			int num = -1039914390;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE7A0899Fu) % 6u)
				{
				case 4u:
					float_0 = 14.25f;
					num = ((int)num2 * -1173601324) ^ 0x6B031348;
					continue;
				case 3u:
					string_2 = "Equinox Com";
					num = (int)((num2 * 1541183509) ^ 0x432673CA);
					continue;
				case 1u:
					method_0();
					num = (int)((num2 * 912280484) ^ 0x4EC1A2D5);
					continue;
				case 0u:
					num = (int)(num2 * 2009885634) ^ -1740243586;
					continue;
				default:
					return;
				case 2u:
					break;
				case 5u:
					return;
				}
				break;
			}
		}
	}

	public void method_0()
	{
		if (privateFontCollection_0 == null)
		{
			goto IL_005f;
		}
		goto IL_0101;
		IL_0101:
		bool flag = (float_0 == 0f) | GClass2.smethod_1(string_2);
		int num = 855272382;
		goto IL_00c7;
		IL_00c7:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x714566AEu) % 10u)
			{
			case 9u:
				num = ((int)num2 * -2060484776) ^ -839001873;
				continue;
			case 8u:
				fontFamily_0 = GClass2.smethod_2(string_2, (FontCollection)(object)privateFontCollection_0);
				num = 1179955659;
				continue;
			case 6u:
				num = (int)(num2 * 1318489932) ^ -1430178650;
				continue;
			case 5u:
				num = (int)(num2 * 953915489) ^ -99620802;
				continue;
			case 4u:
				break;
			case 3u:
				System_002EWindows_002EForms_002EControl_002EFont = GClass2.smethod_3(fontFamily_0, float_0);
				num = ((int)num2 * -2028944077) ^ 0x5D105258;
				continue;
			case 2u:
			{
				int num3;
				int num4;
				if (!flag)
				{
					num3 = -1460181054;
					num4 = -1460181054;
				}
				else
				{
					num3 = -1376575305;
					num4 = -1376575305;
				}
				num = num3 ^ (int)(num2 * 346203690);
				continue;
			}
			case 1u:
				privateFontCollection_0 = GClass2.smethod_0();
				num = (int)((num2 * 871834428) ^ 0x5ED4F356);
				continue;
			default:
				return;
			case 0u:
				goto IL_0101;
			case 7u:
				return;
			}
			break;
		}
		goto IL_005f;
		IL_005f:
		num = 1472883423;
		goto IL_00c7;
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
