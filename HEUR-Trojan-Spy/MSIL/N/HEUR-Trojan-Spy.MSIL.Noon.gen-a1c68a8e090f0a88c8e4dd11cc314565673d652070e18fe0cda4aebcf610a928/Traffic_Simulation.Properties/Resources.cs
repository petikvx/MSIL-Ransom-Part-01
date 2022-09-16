using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Traffic_Simulation.Properties;

[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
internal class Resources
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			ResourceManager result = default(ResourceManager);
			bool flag = default(bool);
			ResourceManager resourceManager = default(ResourceManager);
			while (true)
			{
				int num = 1319508734;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x766FB5AAu) % 10u)
					{
					case 9u:
						result = resourceMan;
						num = 602439745;
						continue;
					case 7u:
						num = ((int)num2 * -1065135058) ^ -969461712;
						continue;
					case 6u:
						flag = resourceMan == null;
						num = (int)((num2 * 1865472694) ^ 0x19ED8AED);
						continue;
					case 5u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -376330031;
							num4 = -376330031;
						}
						else
						{
							num3 = -408289327;
							num4 = -408289327;
						}
						num = num3 ^ ((int)num2 * -713899060);
						continue;
					}
					case 4u:
						resourceManager = Resources.smethod_2("Traffic_Simulation.Properties.Resources", Resources.smethod_1(Resources.smethod_0(typeof(Resources).TypeHandle)));
						num = ((int)num2 * -1459785179) ^ -1995108914;
						continue;
					case 3u:
						num = ((int)num2 * -1378794574) ^ -199394250;
						continue;
					case 2u:
						resourceMan = resourceManager;
						num = ((int)num2 * -1323759517) ^ -991556277;
						continue;
					case 1u:
						num = (int)(num2 * 1832388491) ^ -526949198;
						continue;
					case 8u:
						break;
					default:
						return result;
					}
					break;
				}
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			CultureInfo result = default(CultureInfo);
			while (true)
			{
				int num = -670089695;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xED6F99F4u) % 3u)
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
					result = resourceCulture;
					num = ((int)num2 * -1893435386) ^ -1594653146;
				}
			}
		}
		set
		{
			while (true)
			{
				int num = -1588801598;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB5B23681u) % 3u)
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
					resourceCulture = value;
					num = (int)((num2 * 933560509) ^ 0x27122C89);
				}
			}
		}
	}

	internal static string Aleje_East_Entry_Rondo
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = 1894991815;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4FBD5962u) % 4u)
					{
					case 3u:
						num = (int)((num2 * 1081912682) ^ 0x3C40984C);
						continue;
					case 1u:
						result = Resources.smethod_3(ResourceManager, "Aleje_East_Entry_Rondo", resourceCulture);
						num = (int)((num2 * 1267446207) ^ 0x577A266);
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
	}

	internal static string Aleje_East_Exit_1
	{
		get
		{
			string result = Resources.smethod_3(ResourceManager, "Aleje_East_Exit_1", resourceCulture);
			while (true)
			{
				int num = 2093081755;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7832A3C9u) % 3u)
					{
					case 1u:
						goto IL_0017;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0017:
					num = (int)((num2 * 91236729) ^ 0x277E412A);
				}
			}
		}
	}

	internal static string Aleje_East_Exit_2
	{
		get
		{
			string result = Resources.smethod_3(ResourceManager, "Aleje_East_Exit_2", resourceCulture);
			while (true)
			{
				int num = -323264145;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDDCFCF36u) % 3u)
					{
					case 2u:
						goto IL_0017;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0017:
					num = (int)((num2 * 25165612) ^ 0x4C472052);
				}
			}
		}
	}

	internal static string Aleje_East_Right_Bitwy
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = -833447895;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xADB6E067u) % 4u)
					{
					case 2u:
						result = Resources.smethod_3(ResourceManager, "Aleje_East_Right_Bitwy", resourceCulture);
						num = ((int)num2 * -267233133) ^ -1401726032;
						continue;
					case 1u:
						num = ((int)num2 * -781727682) ^ 0x67F3BDB9;
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
	}

	internal static string Aleje_Entry_Left_Bitwy
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = 768350936;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1A821B85u) % 4u)
					{
					case 3u:
						num = ((int)num2 * -2144613548) ^ 0x2144F031;
						continue;
					case 1u:
						result = Resources.smethod_3(ResourceManager, "Aleje_Entry_Left_Bitwy", resourceCulture);
						num = (int)(num2 * 1203091660) ^ -986894850;
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
	}

	internal static string Aleje_West_Entry_1 => Resources.smethod_3(ResourceManager, "Aleje_West_Entry_1", resourceCulture);

	internal static string Aleje_West_Entry_2
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = -925516103;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA63A94A6u) % 4u)
					{
					case 3u:
						result = Resources.smethod_3(ResourceManager, "Aleje_West_Entry_2", resourceCulture);
						num = ((int)num2 * -323995629) ^ -1370180619;
						continue;
					case 2u:
						num = ((int)num2 * -1420180783) ^ 0xEF27471;
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
	}

	internal static string Aleje_West_Entry_Bitwy
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = 1489205902;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF362819u) % 4u)
					{
					case 3u:
						result = Resources.smethod_3(ResourceManager, "Aleje_West_Entry_Bitwy", resourceCulture);
						num = (int)(num2 * 723331007) ^ -905833795;
						continue;
					case 1u:
						num = (int)(num2 * 513482897) ^ -254269342;
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
	}

	internal static string Aleje_West_Exit_1
	{
		get
		{
			string result = Resources.smethod_3(ResourceManager, "Aleje_West_Exit_1", resourceCulture);
			while (true)
			{
				int num = 1271513413;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7DADB7C4u) % 3u)
					{
					case 2u:
						goto IL_0017;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0017:
					num = ((int)num2 * -809250630) ^ -1859717634;
				}
			}
		}
	}

	internal static string Aleje_West_Exit_2
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = -325520112;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCD78E509u) % 4u)
					{
					case 1u:
						result = Resources.smethod_3(ResourceManager, "Aleje_West_Exit_2", resourceCulture);
						num = (int)(num2 * 1842466417) ^ -1272011088;
						continue;
					case 0u:
						num = (int)((num2 * 215376867) ^ 0xA1D091A);
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
	}

	internal static string Bitwy_North_Entry_1
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = -1973011206;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDF8B8123u) % 3u)
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
					result = Resources.smethod_3(ResourceManager, "Bitwy_North_Entry_1", resourceCulture);
					num = (int)((num2 * 1311882913) ^ 0x395CC73D);
				}
			}
		}
	}

	internal static string Bitwy_North_Entry_2
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = 1781318466;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x34DA6CECu) % 4u)
					{
					case 2u:
						result = Resources.smethod_3(ResourceManager, "Bitwy_North_Entry_2", resourceCulture);
						num = (int)((num2 * 1561080157) ^ 0x4F70EEBB);
						continue;
					case 1u:
						num = (int)((num2 * 478551533) ^ 0x6902078E);
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
	}

	internal static string Bitwy_North_Entry_Left_Rondo
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = -1471243481;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDC770482u) % 4u)
					{
					case 2u:
						num = (int)(num2 * 196102387) ^ -254720716;
						continue;
					case 1u:
						result = Resources.smethod_3(ResourceManager, "Bitwy_North_Entry_Left_Rondo", resourceCulture);
						num = (int)(num2 * 1987933495) ^ -1786408441;
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
	}

	internal static string Bitwy_North_Exit_1
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = -1245075578;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x95E7CAD3u) % 4u)
					{
					case 3u:
						num = ((int)num2 * -860201974) ^ -1849173013;
						continue;
					case 1u:
						result = Resources.smethod_3(ResourceManager, "Bitwy_North_Exit_1", resourceCulture);
						num = ((int)num2 * -303653713) ^ -1680001485;
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
	}

	internal static string Bitwy_North_Exit_2
	{
		get
		{
			string result = Resources.smethod_3(ResourceManager, "Bitwy_North_Exit_2", resourceCulture);
			while (true)
			{
				int num = -1579836829;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x97900325u) % 3u)
					{
					case 1u:
						goto IL_0017;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0017:
					num = ((int)num2 * -1367289294) ^ 0x44B79C68;
				}
			}
		}
	}

	internal static string Bitwy_North_Left_Exit
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = -2116273206;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9816C0AAu) % 3u)
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
					result = Resources.smethod_3(ResourceManager, "Bitwy_North_Left_Exit", resourceCulture);
					num = ((int)num2 * -306511780) ^ 0x166254EB;
				}
			}
		}
	}

	internal static string Bitwy_North_Right_Aleje
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = -1298487398;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE5C1D273u) % 4u)
					{
					case 3u:
						num = (int)((num2 * 469837507) ^ 0x44B00440);
						continue;
					case 1u:
						result = Resources.smethod_3(ResourceManager, "Bitwy_North_Right_Aleje", resourceCulture);
						num = (int)(num2 * 1965794534) ^ -1252601766;
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
	}

	internal static string Bitwy_South_Entry_1
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = -594818145;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEC7ADCEDu) % 4u)
					{
					case 3u:
						num = ((int)num2 * -1224009121) ^ -907080119;
						continue;
					case 2u:
						result = Resources.smethod_3(ResourceManager, "Bitwy_South_Entry_1", resourceCulture);
						num = (int)(num2 * 80587701) ^ -1418276740;
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
	}

	internal static string Bitwy_South_Entry_2
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = -772256140;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDDD177E7u) % 4u)
					{
					case 3u:
						result = Resources.smethod_3(ResourceManager, "Bitwy_South_Entry_2", resourceCulture);
						num = ((int)num2 * -1904863421) ^ 0x5F2E744;
						continue;
					case 2u:
						num = ((int)num2 * -1172946663) ^ 0xB5E23E8;
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
	}

	internal static string Bitwy_South_Exit_1
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = -65988427;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCFC62C78u) % 4u)
					{
					case 2u:
						num = (int)(num2 * 617173742) ^ -663491081;
						continue;
					case 1u:
						result = Resources.smethod_3(ResourceManager, "Bitwy_South_Exit_1", resourceCulture);
						num = ((int)num2 * -459323260) ^ 0x2D907622;
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
	}

	internal static string Bitwy_South_Exit_2
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = 1061311145;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x29DF1446u) % 4u)
					{
					case 3u:
						result = Resources.smethod_3(ResourceManager, "Bitwy_South_Exit_2", resourceCulture);
						num = (int)(num2 * 660376746) ^ -1018984687;
						continue;
					case 1u:
						num = ((int)num2 * -1894257952) ^ 0x11DDADBC;
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
	}

	internal static string Bitwy_South_Right_Aleje
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = 643190768;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x166855A1u) % 4u)
					{
					case 2u:
						num = (int)((num2 * 472689616) ^ 0x4AE8E902);
						continue;
					case 1u:
						result = Resources.smethod_3(ResourceManager, "Bitwy_South_Right_Aleje", resourceCulture);
						num = (int)(num2 * 208694768) ^ -1192995161;
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
	}

	internal static Bitmap mapa
	{
		get
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected O, but got Unknown
			object obj = Resources.smethod_4(ResourceManager, "mapa", resourceCulture);
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = 1251399232;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE6875B5u) % 3u)
					{
					case 1u:
						goto IL_0017;
					case 2u:
						break;
					default:
						return result;
					}
					break;
					IL_0017:
					result = (Bitmap)obj;
					num = (int)((num2 * 1460551128) ^ 0x42047A50);
				}
			}
		}
	}

	internal static Bitmap mario
	{
		get
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected O, but got Unknown
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = -450482889;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDABC80F2u) % 4u)
					{
					case 2u:
						num = (int)((num2 * 312298792) ^ 0x49EE7F5A);
						continue;
					case 1u:
					{
						object obj = Resources.smethod_4(ResourceManager, "mario", resourceCulture);
						result = (Bitmap)obj;
						num = ((int)num2 * -529654137) ^ 0x661C6E43;
						continue;
					}
					case 3u:
						break;
					default:
						return result;
					}
					break;
				}
			}
		}
	}

	internal static Bitmap pic
	{
		get
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			object obj = Resources.smethod_4(ResourceManager, "pic", resourceCulture);
			Bitmap result = (Bitmap)obj;
			while (true)
			{
				int num = -145222531;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF687EC33u) % 3u)
					{
					case 1u:
						goto IL_001e;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_001e:
					num = ((int)num2 * -711584541) ^ 0x262151C0;
				}
			}
		}
	}

	internal static Bitmap pikachu
	{
		get
		{
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Expected O, but got Unknown
			object obj = default(object);
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = 26904126;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5EACE011u) % 5u)
					{
					case 4u:
						num = ((int)num2 * -1481643680) ^ 0x41129B75;
						continue;
					case 3u:
						obj = Resources.smethod_4(ResourceManager, "pikachu", resourceCulture);
						num = ((int)num2 * -451429212) ^ 0xCC3E75B;
						continue;
					case 0u:
						result = (Bitmap)obj;
						num = ((int)num2 * -1737625852) ^ 0x62D16B1;
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
	}

	internal static Bitmap pKZA
	{
		get
		{
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Expected O, but got Unknown
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = -1846748762;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC0516C19u) % 4u)
					{
					case 3u:
					{
						object obj = Resources.smethod_4(ResourceManager, "pKZA", resourceCulture);
						result = (Bitmap)obj;
						num = (int)((num2 * 616994696) ^ 0x7615E557);
						continue;
					}
					case 2u:
						num = (int)((num2 * 757074471) ^ 0x2091674E);
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
	}

	internal static string Rondo_1_East_Entry_Rondo_2
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = 574608184;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x472740CBu) % 4u)
					{
					case 3u:
						result = Resources.smethod_3(ResourceManager, "Rondo_1_East_Entry_Rondo_2", resourceCulture);
						num = ((int)num2 * -88900874) ^ -71647117;
						continue;
					case 2u:
						num = ((int)num2 * -590581673) ^ 0x62F57A34;
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
	}

	internal static string Rondo_1_Inside_Left_Entry_Rondo_2 => Resources.smethod_3(ResourceManager, "Rondo_1_Inside_Left_Entry_Rondo_2", resourceCulture);

	internal static string Rondo_1_North_Entry_Rondo_2
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = 1078554526;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x371F7203u) % 4u)
					{
					case 1u:
						result = Resources.smethod_3(ResourceManager, "Rondo_1_North_Entry_Rondo_2", resourceCulture);
						num = ((int)num2 * -840242359) ^ -211451070;
						continue;
					case 0u:
						num = (int)(num2 * 1828255107) ^ -725960240;
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
	}

	internal static string Rondo_1_South_Entry_Rondo_2
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = -574793959;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAAC8EC31u) % 3u)
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
					result = Resources.smethod_3(ResourceManager, "Rondo_1_South_Entry_Rondo_2", resourceCulture);
					num = (int)(num2 * 664208521) ^ -1476251239;
				}
			}
		}
	}

	internal static string Rondo_1_South_Inside_Rondo_2_Inside
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = 119374310;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4862C5F3u) % 3u)
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
					result = Resources.smethod_3(ResourceManager, "Rondo_1_South_Inside_Rondo_2_Inside", resourceCulture);
					num = ((int)num2 * -1265105580) ^ -985459242;
				}
			}
		}
	}

	internal static string Rondo_1_West_Entry_Rondo_2
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = -1993885193;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD3148CCAu) % 4u)
					{
					case 1u:
						result = Resources.smethod_3(ResourceManager, "Rondo_1_West_Entry_Rondo_2", resourceCulture);
						num = ((int)num2 * -73345619) ^ 0x63C686BF;
						continue;
					case 0u:
						num = (int)((num2 * 1899443927) ^ 0x23F95345);
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
	}

	internal static string Rondo_2_East_Exit
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = -1795981452;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA1BAE739u) % 3u)
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
					result = Resources.smethod_3(ResourceManager, "Rondo_2_East_Exit", resourceCulture);
					num = ((int)num2 * -1926831563) ^ -1461002634;
				}
			}
		}
	}

	internal static string Rondo_2_Inside_Left_Entry_Rondo_3
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = 478452865;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x123C8879u) % 3u)
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
					result = Resources.smethod_3(ResourceManager, "Rondo_2_Inside_Left_Entry_Rondo_3", resourceCulture);
					num = (int)(num2 * 1369740978) ^ -409919861;
				}
			}
		}
	}

	internal static string Rondo_2_North_Entry_Rondo_3
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = 1513624333;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x38B76D2Cu) % 4u)
					{
					case 2u:
						num = (int)((num2 * 527087585) ^ 0x3263837A);
						continue;
					case 1u:
						result = Resources.smethod_3(ResourceManager, "Rondo_2_North_Entry_Rondo_3", resourceCulture);
						num = (int)((num2 * 1109833177) ^ 0x1977FCFB);
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
	}

	internal static string Rondo_2_South_Exit
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = 1253366671;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x15700F7Du) % 4u)
					{
					case 2u:
						result = Resources.smethod_3(ResourceManager, "Rondo_2_South_Exit", resourceCulture);
						num = ((int)num2 * -648576503) ^ -572591686;
						continue;
					case 1u:
						num = ((int)num2 * -1558105332) ^ -445046014;
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
	}

	internal static string Rondo_2_South_Inside_Exit
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = -328197108;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBF14A0B5u) % 4u)
					{
					case 2u:
						num = ((int)num2 * -1315424208) ^ 0x1B41A1D5;
						continue;
					case 1u:
						result = Resources.smethod_3(ResourceManager, "Rondo_2_South_Inside_Exit", resourceCulture);
						num = ((int)num2 * -1300797247) ^ -1284990906;
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
	}

	internal static string Rondo_2_West_Exit
	{
		get
		{
			string result = Resources.smethod_3(ResourceManager, "Rondo_2_West_Exit", resourceCulture);
			while (true)
			{
				int num = 2043227925;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x73A57DDBu) % 3u)
					{
					case 1u:
						goto IL_0017;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0017:
					num = (int)((num2 * 1069260052) ^ 0x25302B57);
				}
			}
		}
	}

	internal static string Rondo_3_Inside_Left_exit
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = -1167838427;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA3A6A1C8u) % 4u)
					{
					case 2u:
						num = ((int)num2 * -158786717) ^ 0x3186064E;
						continue;
					case 1u:
						result = Resources.smethod_3(ResourceManager, "Rondo_3_Inside_Left_exit", resourceCulture);
						num = ((int)num2 * -355771321) ^ -1534961307;
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
	}

	internal static string Rondo_3_North_Exit
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = -1562263657;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9F906445u) % 4u)
					{
					case 2u:
						result = Resources.smethod_3(ResourceManager, "Rondo_3_North_Exit", resourceCulture);
						num = (int)((num2 * 769942997) ^ 0x1ECA5D56);
						continue;
					case 1u:
						num = (int)(num2 * 774762789) ^ -1527688768;
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
	}

	internal static string Rondo_East_Inside => Resources.smethod_3(ResourceManager, "Rondo_East_Inside", resourceCulture);

	internal static Bitmap star
	{
		get
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected O, but got Unknown
			object obj = Resources.smethod_4(ResourceManager, "star", resourceCulture);
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = -897790035;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC2B58C95u) % 3u)
					{
					case 2u:
						goto IL_0017;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0017:
					result = (Bitmap)obj;
					num = ((int)num2 * -226151079) ^ 0x12714FB6;
				}
			}
		}
	}

	internal Resources()
	{
		while (true)
		{
			int num = 518302900;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x67BD44A6u) % 3u)
				{
				case 1u:
					goto IL_0008;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0008:
				num = ((int)num2 * -2093371329) ^ -1647505322;
			}
		}
	}

	static Type smethod_0(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static Assembly smethod_1(Type type_0)
	{
		return type_0.Assembly;
	}

	static ResourceManager smethod_2(string string_0, Assembly assembly_0)
	{
		return new ResourceManager(string_0, assembly_0);
	}

	static string smethod_3(ResourceManager resourceManager_0, string string_0, CultureInfo cultureInfo_0)
	{
		return resourceManager_0.GetString(string_0, cultureInfo_0);
	}

	static object smethod_4(ResourceManager resourceManager_0, string string_0, CultureInfo cultureInfo_0)
	{
		return resourceManager_0.GetObject(string_0, cultureInfo_0);
	}
}
