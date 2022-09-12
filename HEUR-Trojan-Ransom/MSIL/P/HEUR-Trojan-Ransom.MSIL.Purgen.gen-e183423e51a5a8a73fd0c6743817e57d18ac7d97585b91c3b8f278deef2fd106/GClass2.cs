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
			string result = "IPJ";
			while (true)
			{
				int num = -184861333;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9E66CA40u) % 3u)
					{
					case 1u:
						goto IL_0008;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0008:
					num = ((int)num2 * -923905974) ^ 0x2B18889B;
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
				int num = -769750423;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBD9E0612u) % 3u)
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
					result = "nTxO";
					num = (int)(num2 * 1339242818) ^ -439912501;
				}
			}
		}
		set
		{
			while (true)
			{
				int num = -744867067;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE6535C3Fu) % 3u)
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
					string_1 = value;
					num = ((int)num2 * -478749663) ^ -1641683573;
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
			Font result = default(Font);
			while (true)
			{
				int num = -866557291;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x933A63D1u) % 3u)
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
					num = (int)((num2 * 840297338) ^ 0x1E49E507);
				}
			}
		}
		set
		{
			while (true)
			{
				int num = -1138782121;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8C92AFC4u) % 4u)
					{
					case 3u:
						this.method_2(value);
						num = ((int)num2 * -1863505040) ^ 0x240F8D50;
						continue;
					case 0u:
						num = (int)(num2 * 554814089) ^ -44538331;
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

	[DefaultValue("Equinox Com")]
	public string String_2
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = -1470097353;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB20F65B6u) % 3u)
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
					num = ((int)num2 * -38787019) ^ 0x4343BD31;
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
			float result = default(float);
			while (true)
			{
				int num = -1573137698;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDE471C0Bu) % 3u)
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
					result = float_0;
					num = (int)(num2 * 303013718) ^ -994980327;
				}
			}
		}
		set
		{
			while (true)
			{
				int num = -1546839640;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD81C1F42u) % 4u)
					{
					case 2u:
						float_0 = value;
						method_0();
						num = (int)(num2 * 1953152368) ^ -132455725;
						continue;
					case 1u:
						num = (int)(num2 * 1238584230) ^ -1879238680;
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
			int num = -2034412989;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA5114AEFu) % 5u)
				{
				case 4u:
					string_2 = "Equinox Com";
					num = (int)((num2 * 2079907410) ^ 0x64837ED1);
					continue;
				case 3u:
					num = (int)((num2 * 228928092) ^ 0x217F0B0A);
					continue;
				case 1u:
					float_0 = 14.25f;
					method_0();
					num = (int)(num2 * 809383322) ^ -1826103998;
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

	public void method_0()
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -2024497056;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE3E36107u) % 10u)
				{
				case 9u:
					flag = privateFontCollection_0 == null;
					num = ((int)num2 * -244111674) ^ -643940057;
					continue;
				case 8u:
				{
					int num5;
					if ((float_0 == 0f) | GClass2.smethod_1(string_2))
					{
						num = -373904892;
						num5 = -373904892;
					}
					else
					{
						num = -666262712;
						num5 = -666262712;
					}
					continue;
				}
				case 7u:
					fontFamily_0 = GClass2.smethod_2(string_2, (FontCollection)(object)privateFontCollection_0);
					System_002EWindows_002EForms_002EControl_002EFont = GClass2.smethod_3(fontFamily_0, float_0);
					num = -1650282576;
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1627128263;
						num4 = 1627128263;
					}
					else
					{
						num3 = 301073449;
						num4 = 301073449;
					}
					num = num3 ^ (int)(num2 * 140926277);
					continue;
				}
				case 5u:
					num = (int)(num2 * 343000748) ^ -1443313445;
					continue;
				case 4u:
					privateFontCollection_0 = GClass2.smethod_0();
					num = (int)(num2 * 817236337) ^ -1945898785;
					continue;
				case 1u:
					num = (int)((num2 * 1864683104) ^ 0x2FD32F0F);
					continue;
				case 0u:
					num = (int)((num2 * 1761729702) ^ 0xF6E1A6D);
					continue;
				default:
					return;
				case 3u:
					break;
				case 2u:
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
