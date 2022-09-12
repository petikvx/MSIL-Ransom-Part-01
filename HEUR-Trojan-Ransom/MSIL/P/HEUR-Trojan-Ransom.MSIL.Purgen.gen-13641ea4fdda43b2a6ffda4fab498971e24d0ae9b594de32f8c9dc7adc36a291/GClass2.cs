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
			string result = default(string);
			while (true)
			{
				int num = -788571577;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC727728Au) % 3u)
					{
					case 1u:
						goto IL_0003;
					case 2u:
						break;
					default:
						return result;
					}
					break;
					IL_0003:
					result = "uktYfg";
					num = (int)(num2 * 576252375) ^ -1644719349;
				}
			}
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
			return "rgsN";
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
				int num = -269601810;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x932E153Fu) % 4u)
					{
					case 2u:
						num = ((int)num2 * -1108988883) ^ 0x6F8E9796;
						continue;
					case 1u:
						this.method_2(value);
						num = ((int)num2 * -881874494) ^ 0x7F1CC97;
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
				int num = 165277042;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6B37626Fu) % 3u)
					{
					case 1u:
						goto IL_0003;
					case 2u:
						break;
					default:
						return result;
					}
					break;
					IL_0003:
					result = string_2;
					num = ((int)num2 * -809594290) ^ -1068482268;
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
				int num = -378487969;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDC327FAEu) % 3u)
					{
					case 1u:
						goto IL_0009;
					case 2u:
						break;
					default:
						return result;
					}
					break;
					IL_0009:
					num = ((int)num2 * -777679600) ^ 0x30FE9BDD;
				}
			}
		}
		set
		{
			float_0 = value;
			while (true)
			{
				int num = 1967272121;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8C91F6Cu) % 3u)
					{
					case 2u:
						goto IL_0009;
					default:
						return;
					case 0u:
						break;
					case 1u:
						return;
					}
					break;
					IL_0009:
					method_0();
					num = (int)((num2 * 2109914248) ^ 0x1F14CF93);
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
		bool flag = privateFontCollection_0 == null;
		bool flag2 = default(bool);
		while (true)
		{
			int num = -594874873;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDF45C799u) % 12u)
				{
				case 11u:
					num = -1572118390;
					continue;
				case 10u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = 1264200613;
						num6 = 1264200613;
					}
					else
					{
						num5 = 1992626096;
						num6 = 1992626096;
					}
					num = num5 ^ ((int)num2 * -10681599);
					continue;
				}
				case 9u:
					num = ((int)num2 * -166913050) ^ 0x7EEEC3DB;
					continue;
				case 7u:
					flag2 = (float_0 == 0f) | GClass2.smethod_1(string_2);
					num = ((int)num2 * -646379800) ^ 0xAAC2370;
					continue;
				case 6u:
					privateFontCollection_0 = GClass2.smethod_0();
					num = (int)(num2 * 1591259302) ^ -1590734291;
					continue;
				case 4u:
					num = ((int)num2 * -413689015) ^ 0x37F32E56;
					continue;
				case 3u:
					fontFamily_0 = GClass2.smethod_2(string_2, (FontCollection)(object)privateFontCollection_0);
					System_002EWindows_002EForms_002EControl_002EFont = GClass2.smethod_3(fontFamily_0, float_0);
					num = ((int)num2 * -1684142497) ^ -1648872742;
					continue;
				case 2u:
					num = (int)(num2 * 1001811583) ^ -1007739173;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag2)
					{
						num3 = -759811725;
						num4 = -759811725;
					}
					else
					{
						num3 = -729307210;
						num4 = -729307210;
					}
					num = num3 ^ (int)(num2 * 1255542551);
					continue;
				}
				case 0u:
					num = -165636010;
					continue;
				default:
					return;
				case 5u:
					break;
				case 8u:
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
