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
				int num = 1889157269;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x376B080Au) % 4u)
					{
					case 3u:
						result = "NUhuCgd";
						num = ((int)num2 * -2121420870) ^ 0x1320FC0C;
						continue;
					case 0u:
						num = ((int)num2 * -972447464) ^ 0x27D2BADF;
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
				int num = -1552443766;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9C6ADE5Bu) % 3u)
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
					num = ((int)num2 * -525975099) ^ -1933069145;
				}
			}
		}
	}

	public static string String_1
	{
		get
		{
			string result = "KFLv";
			while (true)
			{
				int num = 2128132846;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2CFA8224u) % 3u)
					{
					case 2u:
						goto IL_0008;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0008:
					num = (int)(num2 * 2040211529) ^ -1783723645;
				}
			}
		}
		set
		{
			while (true)
			{
				int num = -844974823;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF77ECFDDu) % 3u)
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
					string_1 = value;
					num = ((int)num2 * -1863848923) ^ 0x1664624F;
				}
			}
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	Font Font
	{
		get
		{
			Font result = this.method_1();
			while (true)
			{
				int num = 2081307481;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x600DFC27u) % 3u)
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
					num = (int)(num2 * 469773928) ^ -1513827740;
				}
			}
		}
		set
		{
			while (true)
			{
				int num = -680765804;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC98B781Eu) % 3u)
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
					this.method_2(value);
					num = ((int)num2 * -1276077456) ^ 0x4C2BD986;
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
				int num = -171872056;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD4DED0D2u) % 3u)
					{
					case 1u:
						goto IL_0003;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0003:
					result = string_2;
					num = ((int)num2 * -773958748) ^ 0x1BD7F431;
				}
			}
		}
		set
		{
			while (true)
			{
				int num = -1223401507;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBE7A9F82u) % 4u)
					{
					case 3u:
						string_2 = value;
						method_0();
						num = (int)((num2 * 428841760) ^ 0x2F4E7EF2);
						continue;
					case 0u:
						num = ((int)num2 * -1210950057) ^ 0x77F6CB77;
						continue;
					default:
						return;
					case 2u:
						break;
					case 1u:
						return;
					}
					break;
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
				int num = 864515173;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x709DDCE6u) % 4u)
					{
					case 3u:
						result = float_0;
						num = (int)(num2 * 421066216) ^ -450089429;
						continue;
					case 1u:
						num = ((int)num2 * -1187896731) ^ -417756779;
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
				int num = -2096778238;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8F0CCABBu) % 4u)
					{
					case 2u:
						num = ((int)num2 * -2041447950) ^ -1497881681;
						continue;
					case 1u:
						float_0 = value;
						method_0();
						num = (int)(num2 * 1886042070) ^ -938486953;
						continue;
					default:
						return;
					case 3u:
						break;
					case 0u:
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
			int num = -53460011;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB9051F56u) % 6u)
				{
				case 5u:
					float_0 = 14.25f;
					num = (int)((num2 * 601976627) ^ 0xAAFC3E7);
					continue;
				case 3u:
					string_2 = "Equinox Com";
					num = ((int)num2 * -1672768155) ^ 0x164A486;
					continue;
				case 1u:
					num = (int)(num2 * 641215565) ^ -1318021190;
					continue;
				case 0u:
					method_0();
					num = (int)(num2 * 772476171) ^ -107853072;
					continue;
				default:
					return;
				case 2u:
					break;
				case 4u:
					return;
				}
				break;
			}
		}
	}

	public void method_0()
	{
		bool flag = privateFontCollection_0 == null;
		while (true)
		{
			int num = 1424829912;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x18B98CAEu) % 11u)
				{
				case 10u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = 754314347;
						num6 = 754314347;
					}
					else
					{
						num5 = 1567041480;
						num6 = 1567041480;
					}
					num = num5 ^ ((int)num2 * -1238152104);
					continue;
				}
				case 8u:
					num = (int)(num2 * 1098463161) ^ -166878279;
					continue;
				case 7u:
					fontFamily_0 = GClass2.smethod_2(string_2, (FontCollection)(object)privateFontCollection_0);
					num = ((int)num2 * -1526226309) ^ 0x40D2C497;
					continue;
				case 6u:
					num = 1104847217;
					continue;
				case 4u:
					num = 1263258444;
					continue;
				case 3u:
					num = (int)((num2 * 901457358) ^ 0x17543127);
					continue;
				case 2u:
					privateFontCollection_0 = GClass2.smethod_0();
					num = ((int)num2 * -1967778451) ^ -1433977614;
					continue;
				case 1u:
					System_002EWindows_002EForms_002EControl_002EFont = GClass2.smethod_3(fontFamily_0, float_0);
					num = ((int)num2 * -467604092) ^ -342621340;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!((float_0 == 0f) | GClass2.smethod_1(string_2)))
					{
						num3 = -1577291741;
						num4 = -1577291741;
					}
					else
					{
						num3 = -1865475313;
						num4 = -1865475313;
					}
					num = num3 ^ (int)(num2 * 1142149176);
					continue;
				}
				default:
					return;
				case 5u:
					break;
				case 9u:
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
