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
				int num = 360650659;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6E3FD09Au) % 4u)
					{
					case 1u:
						result = "OUxW";
						num = ((int)num2 * -1080373672) ^ -869835846;
						continue;
					case 0u:
						num = (int)(num2 * 857787080) ^ -2133678491;
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
			while (true)
			{
				int num = 1646259443;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2D046FF9u) % 3u)
					{
					case 1u:
						goto IL_0003;
					default:
						return;
					case 2u:
						break;
					case 0u:
						return;
					}
					break;
					IL_0003:
					string_0 = value;
					num = (int)((num2 * 198891296) ^ 0x432AD818);
				}
			}
		}
	}

	public static string String_1
	{
		get
		{
			return "tbFG";
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
				int num = 904614813;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3B125B5Cu) % 4u)
					{
					case 2u:
						num = (int)((num2 * 1087549390) ^ 0x4AA9F0B);
						continue;
					case 1u:
						result = this.method_1();
						num = ((int)num2 * -1965232404) ^ -553292278;
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
				int num = 2000073451;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x430C740Fu) % 3u)
					{
					case 2u:
						goto IL_0003;
					default:
						return;
					case 0u:
						break;
					case 1u:
						return;
					}
					break;
					IL_0003:
					this.method_2(value);
					num = ((int)num2 * -940034934) ^ 0x56FA51DE;
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
				int num = 1675968436;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1B695EC5u) % 4u)
					{
					case 2u:
						num = ((int)num2 * -125402745) ^ 0x7D34A6F;
						continue;
					case 1u:
						result = string_2;
						num = ((int)num2 * -1629286396) ^ -1069179417;
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
				int num = 31364380;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5FAAC038u) % 3u)
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
					string_2 = value;
					method_0();
					num = ((int)num2 * -1587691465) ^ 0x3D1C16C8;
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
				int num = 111992976;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2AB9F845u) % 3u)
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
					num = ((int)num2 * -1934072971) ^ -1364201506;
				}
			}
		}
		set
		{
			while (true)
			{
				int num = -481045706;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF11B7170u) % 3u)
					{
					case 1u:
						goto IL_0003;
					default:
						return;
					case 2u:
						break;
					case 0u:
						return;
					}
					break;
					IL_0003:
					float_0 = value;
					method_0();
					num = ((int)num2 * -889709926) ^ 0x66B2D7FA;
				}
			}
		}
	}

	public GClass2()
	{
		while (true)
		{
			int num = -38985539;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFBE47E50u) % 6u)
				{
				case 5u:
					num = ((int)num2 * -1987186122) ^ 0x2E123486;
					continue;
				case 4u:
					float_0 = 14.25f;
					method_0();
					num = ((int)num2 * -1422644205) ^ -285908174;
					continue;
				case 2u:
					num = (int)(num2 * 1796192460) ^ -760182315;
					continue;
				case 0u:
					string_2 = "Equinox Com";
					num = (int)(num2 * 1783508870) ^ -1204204650;
					continue;
				default:
					return;
				case 3u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	public void method_0()
	{
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 437933786;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5A678504u) % 12u)
				{
				case 11u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = 2023434677;
						num6 = 2023434677;
					}
					else
					{
						num5 = 56609574;
						num6 = 56609574;
					}
					num = num5 ^ ((int)num2 * -1155885736);
					continue;
				}
				case 10u:
					flag2 = privateFontCollection_0 == null;
					num = (int)((num2 * 1903220618) ^ 0x1F873F1F);
					continue;
				case 9u:
					flag = (float_0 == 0f) | GClass2.smethod_1(string_2);
					num = (int)((num2 * 1060672429) ^ 0x39FC7043);
					continue;
				case 8u:
					System_002EWindows_002EForms_002EControl_002EFont = GClass2.smethod_3(fontFamily_0, float_0);
					num = ((int)num2 * -1818924176) ^ -1937713033;
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 2139781540;
						num4 = 2139781540;
					}
					else
					{
						num3 = 1848312448;
						num4 = 1848312448;
					}
					num = num3 ^ ((int)num2 * -733527408);
					continue;
				}
				case 4u:
					num = ((int)num2 * -2112502364) ^ -1918043829;
					continue;
				case 3u:
					num = ((int)num2 * -4111026) ^ 0x6ECF0941;
					continue;
				case 2u:
					num = 1196979241;
					continue;
				case 1u:
					privateFontCollection_0 = GClass2.smethod_0();
					num = ((int)num2 * -454167051) ^ 0x64EEE9E3;
					continue;
				case 0u:
					fontFamily_0 = GClass2.smethod_2(string_2, (FontCollection)(object)privateFontCollection_0);
					num = 1500474636;
					continue;
				default:
					return;
				case 5u:
					break;
				case 7u:
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
