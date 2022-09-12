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
				int num = 1709024664;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4BBFE48Au) % 4u)
					{
					case 2u:
						result = "kNhcac";
						num = (int)((num2 * 1089561717) ^ 0x3129110D);
						continue;
					case 1u:
						num = ((int)num2 * -54430058) ^ -2098693773;
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
				int num = -9929963;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x98715E81u) % 3u)
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
					result = "ZBVn";
					num = (int)(num2 * 1953449785) ^ -1244605543;
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
				int num = 2043806992;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x135024ADu) % 4u)
					{
					case 3u:
						num = ((int)num2 * -825955000) ^ -599989263;
						continue;
					case 1u:
						result = this.method_1();
						num = (int)((num2 * 5525772) ^ 0x29C8CEAE);
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
				int num = -1799875627;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFED73657u) % 4u)
					{
					case 2u:
						this.method_2(value);
						num = ((int)num2 * -1727964107) ^ 0x749FDAFC;
						continue;
					case 1u:
						num = ((int)num2 * -1236193482) ^ -1754065826;
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
			string result = string_2;
			while (true)
			{
				int num = 510475251;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6D70EC81u) % 3u)
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
					num = (int)((num2 * 1945290003) ^ 0x47A02BC4);
				}
			}
		}
		set
		{
			while (true)
			{
				int num = -1898418448;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8665E75Eu) % 3u)
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
					num = (int)((num2 * 284793053) ^ 0x23D44A6D);
				}
			}
		}
	}

	[DefaultValue(14.25f)]
	public float Single_0
	{
		get
		{
			return float_0;
		}
		set
		{
			float_0 = value;
			method_0();
		}
	}

	public GClass2()
	{
		while (true)
		{
			int num = 1414807986;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7EDD2D91u) % 6u)
				{
				case 4u:
					method_0();
					num = (int)((num2 * 1842413817) ^ 0x71C23E6F);
					continue;
				case 3u:
					float_0 = 14.25f;
					num = (int)(num2 * 224348642) ^ -475597991;
					continue;
				case 2u:
					num = (int)((num2 * 1005182867) ^ 0x3A336F9E);
					continue;
				case 1u:
					string_2 = "Equinox Com";
					num = (int)(num2 * 1868629988) ^ -730967470;
					continue;
				default:
					return;
				case 0u:
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
		bool flag = default(bool);
		while (true)
		{
			int num = 1908284754;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x435C445Au) % 13u)
				{
				case 12u:
					privateFontCollection_0 = GClass2.smethod_0();
					num = ((int)num2 * -726048767) ^ 0x36EAFA1B;
					continue;
				case 11u:
					num = 841320063;
					continue;
				case 10u:
					flag = (float_0 == 0f) | GClass2.smethod_1(string_2);
					num = ((int)num2 * -666939152) ^ 0x265DFAE1;
					continue;
				case 9u:
					num = 1972046174;
					continue;
				case 8u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = -1419063140;
						num6 = -1419063140;
					}
					else
					{
						num5 = -1738814687;
						num6 = -1738814687;
					}
					num = num5 ^ (int)(num2 * 1723888125);
					continue;
				}
				case 6u:
					num = (int)(num2 * 2118568079) ^ -980850542;
					continue;
				case 5u:
					fontFamily_0 = GClass2.smethod_2(string_2, (FontCollection)(object)privateFontCollection_0);
					num = (int)(num2 * 632417129) ^ -1144214214;
					continue;
				case 4u:
					num = (int)(num2 * 1733302523) ^ -676796235;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (privateFontCollection_0 != null)
					{
						num3 = 1443581042;
						num4 = 1443581042;
					}
					else
					{
						num3 = 1960204795;
						num4 = 1960204795;
					}
					num = num3 ^ ((int)num2 * -1069614740);
					continue;
				}
				case 1u:
					System_002EWindows_002EForms_002EControl_002EFont = GClass2.smethod_3(fontFamily_0, float_0);
					num = ((int)num2 * -129451278) ^ 0x68BE8B60;
					continue;
				case 0u:
					num = ((int)num2 * -2144490631) ^ 0x12F394A2;
					continue;
				default:
					return;
				case 2u:
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
