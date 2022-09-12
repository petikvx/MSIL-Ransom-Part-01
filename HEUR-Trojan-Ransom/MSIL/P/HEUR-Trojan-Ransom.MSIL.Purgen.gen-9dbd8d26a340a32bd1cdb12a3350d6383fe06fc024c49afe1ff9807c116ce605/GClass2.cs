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
				int num = 904425424;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x49878AB5u) % 4u)
					{
					case 2u:
						num = (int)((num2 * 14144460) ^ 0x254D2A7E);
						continue;
					case 1u:
						result = "kLoSCmw";
						num = ((int)num2 * -298329109) ^ 0x557EFF88;
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
			while (true)
			{
				int num = -411665209;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFB6A0C5Au) % 3u)
					{
					case 1u:
						goto IL_0003;
					default:
						return;
					case 0u:
						break;
					case 2u:
						return;
					}
					break;
					IL_0003:
					string_0 = value;
					num = ((int)num2 * -1575044497) ^ -185199274;
				}
			}
		}
	}

	public static string String_1
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = 279800468;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1069C165u) % 4u)
					{
					case 1u:
						result = "HnTf";
						num = (int)(num2 * 839254570) ^ -422233461;
						continue;
					case 0u:
						num = (int)((num2 * 1239291959) ^ 0x7BA68F1A);
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
				int num = 1453526006;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEBC401Bu) % 3u)
					{
					case 2u:
						goto IL_0003;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0003:
					result = this.method_1();
					num = ((int)num2 * -2045586401) ^ -657610040;
				}
			}
		}
		set
		{
			this.method_2(value);
		}
	}

	[DefaultValue("Equinox Com")]
	public string String_2
	{
		get
		{
			string result = string_2;
			while (true)
			{
				int num = 1357242266;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3C3800C8u) % 3u)
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
					num = (int)(num2 * 110528286) ^ -939960504;
				}
			}
		}
		set
		{
			while (true)
			{
				int num = 114930997;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3ED9DA6Cu) % 3u)
					{
					case 1u:
						goto IL_0003;
					case 0u:
						break;
					default:
						method_0();
						return;
					}
					break;
					IL_0003:
					string_2 = value;
					num = ((int)num2 * -1590573339) ^ -1810048759;
				}
			}
		}
	}

	[DefaultValue(14.25f)]
	public float Single_0
	{
		get
		{
			float result = default(float);
			while (true)
			{
				int num = -593752462;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE4A48003u) % 4u)
					{
					case 2u:
						num = ((int)num2 * -1540625766) ^ -1018124629;
						continue;
					case 1u:
						result = float_0;
						num = (int)((num2 * 1976115611) ^ 0x21F6300A);
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
			while (true)
			{
				int num = 2116985392;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3065DB19u) % 4u)
					{
					case 1u:
						float_0 = value;
						num = (int)((num2 * 173764250) ^ 0xC0E99EB);
						continue;
					case 0u:
						method_0();
						num = ((int)num2 * -1000693926) ^ 0x72A23A6E;
						continue;
					default:
						return;
					case 2u:
						break;
					case 3u:
						return;
					}
					break;
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
			int num = 1905790828;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x391BFCACu) % 12u)
				{
				case 11u:
				{
					int num5;
					int num6;
					if (!flag2)
					{
						num5 = -272705331;
						num6 = -272705331;
					}
					else
					{
						num5 = -1266391106;
						num6 = -1266391106;
					}
					num = num5 ^ ((int)num2 * -1918004896);
					continue;
				}
				case 10u:
					num = ((int)num2 * -72644240) ^ 0x479DA36D;
					continue;
				case 9u:
					System_002EWindows_002EForms_002EControl_002EFont = GClass2.smethod_3(fontFamily_0, float_0);
					num = ((int)num2 * -358736906) ^ -134369068;
					continue;
				case 8u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -24536737;
						num4 = -24536737;
					}
					else
					{
						num3 = -1520942409;
						num4 = -1520942409;
					}
					num = num3 ^ ((int)num2 * -913919535);
					continue;
				}
				case 7u:
					privateFontCollection_0 = GClass2.smethod_0();
					num = (int)((num2 * 1169486939) ^ 0x7AD4A919);
					continue;
				case 6u:
					flag2 = (float_0 == 0f) | GClass2.smethod_1(string_2);
					num = ((int)num2 * -533275374) ^ -757124149;
					continue;
				case 5u:
					fontFamily_0 = GClass2.smethod_2(string_2, (FontCollection)(object)privateFontCollection_0);
					num = 2074983377;
					continue;
				case 4u:
					num = ((int)num2 * -609768560) ^ 0x315AD65F;
					continue;
				case 3u:
					num = 875548558;
					continue;
				case 2u:
					num = (int)(num2 * 983436744) ^ -851330851;
					continue;
				default:
					return;
				case 0u:
					break;
				case 1u:
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
