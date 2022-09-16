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
			bool flag = default(bool);
			ResourceManager result = default(ResourceManager);
			ResourceManager resourceManager = default(ResourceManager);
			while (true)
			{
				int num = 1080448564;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x36AA51FAu) % 9u)
					{
					case 8u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -299178893;
							num4 = -299178893;
						}
						else
						{
							num3 = -423997617;
							num4 = -423997617;
						}
						num = num3 ^ ((int)num2 * -687494104);
						continue;
					}
					case 7u:
						flag = resourceMan == null;
						num = ((int)num2 * -684777228) ^ 0x609F5C3;
						continue;
					case 6u:
						result = resourceMan;
						num = 1269134127;
						continue;
					case 3u:
						num = ((int)num2 * -762914817) ^ 0x5B34C772;
						continue;
					case 2u:
						num = ((int)num2 * -1234237630) ^ 0xA343045;
						continue;
					case 1u:
						resourceManager = Resources.smethod_2("Traffic_Simulation.Properties.Resources", Resources.smethod_1(Resources.smethod_0(typeof(Resources).TypeHandle)));
						num = (int)((num2 * 407024291) ^ 0x700830EF);
						continue;
					case 0u:
						resourceMan = resourceManager;
						num = ((int)num2 * -2055490797) ^ 0x2ADA8A55;
						continue;
					case 5u:
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
				int num = -731541187;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF512C5ACu) % 4u)
					{
					case 3u:
						num = (int)(num2 * 1029110467) ^ -1205542267;
						continue;
					case 1u:
						result = resourceCulture;
						num = (int)((num2 * 2078092768) ^ 0x62CC4F37);
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
			resourceCulture = value;
		}
	}

	internal static string Aleje_East_Entry_Rondo
	{
		get
		{
			string result = Resources.smethod_3(ResourceManager, "Aleje_East_Entry_Rondo", resourceCulture);
			while (true)
			{
				int num = 238230970;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2435E9C4u) % 3u)
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
					num = (int)((num2 * 485507923) ^ 0x1994E537);
				}
			}
		}
	}

	internal static string Aleje_East_Exit_1
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = -1197421024;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA3B1801Cu) % 3u)
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
					result = Resources.smethod_3(ResourceManager, "Aleje_East_Exit_1", resourceCulture);
					num = (int)((num2 * 90898677) ^ 0x9D282D1);
				}
			}
		}
	}

	internal static string Aleje_East_Exit_2
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = -129409934;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x88465C9Fu) % 4u)
					{
					case 1u:
						result = Resources.smethod_3(ResourceManager, "Aleje_East_Exit_2", resourceCulture);
						num = (int)(num2 * 1454319257) ^ -2004695802;
						continue;
					case 0u:
						num = (int)((num2 * 1029184660) ^ 0x4D256F78);
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

	internal static string Aleje_East_Right_Bitwy
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = 584597910;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x435607C4u) % 3u)
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
					result = Resources.smethod_3(ResourceManager, "Aleje_East_Right_Bitwy", resourceCulture);
					num = (int)((num2 * 272505437) ^ 0x58E17BBF);
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
				int num = 1100188855;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3B62F9A3u) % 3u)
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
					result = Resources.smethod_3(ResourceManager, "Aleje_Entry_Left_Bitwy", resourceCulture);
					num = ((int)num2 * -1117068808) ^ -970354084;
				}
			}
		}
	}

	internal static string Aleje_West_Entry_1
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = 533126457;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x21C9620Au) % 3u)
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
					result = Resources.smethod_3(ResourceManager, "Aleje_West_Entry_1", resourceCulture);
					num = (int)((num2 * 744604898) ^ 0x40FF7BE3);
				}
			}
		}
	}

	internal static string Aleje_West_Entry_2
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = -157468396;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA5771185u) % 3u)
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
					result = Resources.smethod_3(ResourceManager, "Aleje_West_Entry_2", resourceCulture);
					num = ((int)num2 * -2113519014) ^ -1489377591;
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
				int num = 1531802077;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2F2CC4DAu) % 3u)
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
					result = Resources.smethod_3(ResourceManager, "Aleje_West_Entry_Bitwy", resourceCulture);
					num = ((int)num2 * -467447685) ^ 0x336BE68F;
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
				int num = 1553260431;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1AE9BB5Fu) % 3u)
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
					num = ((int)num2 * -251650161) ^ 0x4478DB07;
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
				int num = 906400286;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6903BE38u) % 3u)
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
					result = Resources.smethod_3(ResourceManager, "Aleje_West_Exit_2", resourceCulture);
					num = (int)(num2 * 1148034581) ^ -613143277;
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
				int num = 994367513;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5ACF0E8Cu) % 4u)
					{
					case 2u:
						num = ((int)num2 * -348862153) ^ -1362706850;
						continue;
					case 1u:
						result = Resources.smethod_3(ResourceManager, "Bitwy_North_Entry_1", resourceCulture);
						num = (int)(num2 * 939250046) ^ -1207855732;
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

	internal static string Bitwy_North_Entry_2
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = -1757032624;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE6DA9F29u) % 4u)
					{
					case 2u:
						num = ((int)num2 * -827389261) ^ -300757824;
						continue;
					case 1u:
						result = Resources.smethod_3(ResourceManager, "Bitwy_North_Entry_2", resourceCulture);
						num = (int)(num2 * 704013522) ^ -1585425103;
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
				int num = -1536494749;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA710171Du) % 4u)
					{
					case 3u:
						num = (int)(num2 * 182178358) ^ -1926526062;
						continue;
					case 2u:
						result = Resources.smethod_3(ResourceManager, "Bitwy_North_Entry_Left_Rondo", resourceCulture);
						num = ((int)num2 * -810129255) ^ -703307796;
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

	internal static string Bitwy_North_Exit_1 => Resources.smethod_3(ResourceManager, "Bitwy_North_Exit_1", resourceCulture);

	internal static string Bitwy_North_Exit_2
	{
		get
		{
			string result = Resources.smethod_3(ResourceManager, "Bitwy_North_Exit_2", resourceCulture);
			while (true)
			{
				int num = 1577559271;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x69370740u) % 3u)
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
					num = ((int)num2 * -162545713) ^ -310899834;
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
				int num = -890886071;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x890AEEEAu) % 4u)
					{
					case 3u:
						result = Resources.smethod_3(ResourceManager, "Bitwy_North_Left_Exit", resourceCulture);
						num = ((int)num2 * -1135345489) ^ -105822497;
						continue;
					case 0u:
						num = ((int)num2 * -389660918) ^ -1917155549;
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

	internal static string Bitwy_North_Right_Aleje
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = -340210938;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE09DB511u) % 3u)
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
					result = Resources.smethod_3(ResourceManager, "Bitwy_North_Right_Aleje", resourceCulture);
					num = ((int)num2 * -1269975395) ^ 0x73D218F3;
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
				int num = -325394986;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF2ED1BF3u) % 4u)
					{
					case 2u:
						num = (int)((num2 * 1693969491) ^ 0x16FD1D11);
						continue;
					case 1u:
						result = Resources.smethod_3(ResourceManager, "Bitwy_South_Entry_1", resourceCulture);
						num = (int)(num2 * 259068693) ^ -206755804;
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

	internal static string Bitwy_South_Entry_2
	{
		get
		{
			string result = Resources.smethod_3(ResourceManager, "Bitwy_South_Entry_2", resourceCulture);
			while (true)
			{
				int num = 2122878109;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD616FC7u) % 3u)
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
					num = (int)((num2 * 1062916896) ^ 0x31077C27);
				}
			}
		}
	}

	internal static string Bitwy_South_Exit_1 => Resources.smethod_3(ResourceManager, "Bitwy_South_Exit_1", resourceCulture);

	internal static string Bitwy_South_Exit_2
	{
		get
		{
			string result = Resources.smethod_3(ResourceManager, "Bitwy_South_Exit_2", resourceCulture);
			while (true)
			{
				int num = 744197799;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x290B07D6u) % 3u)
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
					num = ((int)num2 * -1619048108) ^ 0x7D06B253;
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
				int num = -1487400899;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC5CE5318u) % 4u)
					{
					case 3u:
						num = (int)(num2 * 1489462002) ^ -1263617692;
						continue;
					case 1u:
						result = Resources.smethod_3(ResourceManager, "Bitwy_South_Right_Aleje", resourceCulture);
						num = ((int)num2 * -92296913) ^ 0x561A478C;
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
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected O, but got Unknown
			object obj = default(object);
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = -1433248629;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD16D64AAu) % 4u)
					{
					case 1u:
						obj = Resources.smethod_4(ResourceManager, "mapa", resourceCulture);
						num = (int)(num2 * 355414731) ^ -773427491;
						continue;
					case 0u:
						result = (Bitmap)obj;
						num = (int)((num2 * 1949813743) ^ 0x35A4A128);
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

	internal static Bitmap mario
	{
		get
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected O, but got Unknown
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = 2066884900;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1A4EC3F6u) % 4u)
					{
					case 3u:
						num = ((int)num2 * -1239375170) ^ 0x22DB0DD1;
						continue;
					case 2u:
					{
						object obj = Resources.smethod_4(ResourceManager, "mario", resourceCulture);
						result = (Bitmap)obj;
						num = (int)(num2 * 2144907274) ^ -1024006503;
						continue;
					}
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

	internal static Bitmap pic
	{
		get
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected O, but got Unknown
			object obj = default(object);
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = -366493677;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA73E4429u) % 4u)
					{
					case 2u:
						obj = Resources.smethod_4(ResourceManager, "pic", resourceCulture);
						num = ((int)num2 * -648229140) ^ -79117324;
						continue;
					case 1u:
						result = (Bitmap)obj;
						num = ((int)num2 * -1351774942) ^ 0x54523CEF;
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

	internal static Bitmap pikachu
	{
		get
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Expected O, but got Unknown
			Bitmap result = default(Bitmap);
			object obj = default(object);
			while (true)
			{
				int num = 1768680879;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x651EC782u) % 5u)
					{
					case 3u:
						result = (Bitmap)obj;
						num = ((int)num2 * -1564386393) ^ -1897621046;
						continue;
					case 2u:
						num = ((int)num2 * -454348588) ^ -1077109201;
						continue;
					case 1u:
						obj = Resources.smethod_4(ResourceManager, "pikachu", resourceCulture);
						num = (int)(num2 * 1044505656) ^ -1289757218;
						continue;
					case 4u:
						break;
					default:
						return result;
					}
					break;
				}
			}
		}
	}

	internal static Bitmap rTHb
	{
		get
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Expected O, but got Unknown
			Bitmap result = default(Bitmap);
			object obj = default(object);
			while (true)
			{
				int num = -863292041;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBFF11E45u) % 4u)
					{
					case 3u:
						result = (Bitmap)obj;
						num = ((int)num2 * -1995378299) ^ -1278492353;
						continue;
					case 2u:
						obj = Resources.smethod_4(ResourceManager, "rTHb", resourceCulture);
						num = ((int)num2 * -101469787) ^ 0x2971E314;
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
				int num = 402306682;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x64F54BB4u) % 3u)
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
					result = Resources.smethod_3(ResourceManager, "Rondo_1_East_Entry_Rondo_2", resourceCulture);
					num = ((int)num2 * -230611784) ^ 0x50259EEE;
				}
			}
		}
	}

	internal static string Rondo_1_Inside_Left_Entry_Rondo_2
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = 387560991;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x20FEF46Eu) % 4u)
					{
					case 3u:
						num = ((int)num2 * -1477140058) ^ -1906409104;
						continue;
					case 1u:
						result = Resources.smethod_3(ResourceManager, "Rondo_1_Inside_Left_Entry_Rondo_2", resourceCulture);
						num = (int)((num2 * 1164630022) ^ 0x31FFB643);
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

	internal static string Rondo_1_North_Entry_Rondo_2
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = 194628916;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x586D1FE6u) % 4u)
					{
					case 3u:
						num = (int)((num2 * 1817487327) ^ 0x248EA972);
						continue;
					case 2u:
						result = Resources.smethod_3(ResourceManager, "Rondo_1_North_Entry_Rondo_2", resourceCulture);
						num = (int)(num2 * 1187393665) ^ -357804725;
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

	internal static string Rondo_1_South_Entry_Rondo_2 => Resources.smethod_3(ResourceManager, "Rondo_1_South_Entry_Rondo_2", resourceCulture);

	internal static string Rondo_1_South_Inside_Rondo_2_Inside => Resources.smethod_3(ResourceManager, "Rondo_1_South_Inside_Rondo_2_Inside", resourceCulture);

	internal static string Rondo_1_West_Entry_Rondo_2
	{
		get
		{
			string result = Resources.smethod_3(ResourceManager, "Rondo_1_West_Entry_Rondo_2", resourceCulture);
			while (true)
			{
				int num = -1088217118;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB9168A4Du) % 3u)
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
					num = ((int)num2 * -1107584277) ^ 0x27EDD983;
				}
			}
		}
	}

	internal static string Rondo_2_East_Exit
	{
		get
		{
			string result = Resources.smethod_3(ResourceManager, "Rondo_2_East_Exit", resourceCulture);
			while (true)
			{
				int num = 1374169293;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6C0AF41Bu) % 3u)
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
					num = (int)(num2 * 1894464256) ^ -2077684883;
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
				int num = -1160543066;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA960D4A1u) % 4u)
					{
					case 3u:
						result = Resources.smethod_3(ResourceManager, "Rondo_2_Inside_Left_Entry_Rondo_3", resourceCulture);
						num = ((int)num2 * -1871413649) ^ 0x7DDF765C;
						continue;
					case 0u:
						num = ((int)num2 * -1216196613) ^ 0x63216C98;
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

	internal static string Rondo_2_North_Entry_Rondo_3
	{
		get
		{
			string result = Resources.smethod_3(ResourceManager, "Rondo_2_North_Entry_Rondo_3", resourceCulture);
			while (true)
			{
				int num = 1862085323;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x33808861u) % 3u)
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
					num = ((int)num2 * -1899564044) ^ 0x3234AB8E;
				}
			}
		}
	}

	internal static string Rondo_2_South_Exit
	{
		get
		{
			string result = Resources.smethod_3(ResourceManager, "Rondo_2_South_Exit", resourceCulture);
			while (true)
			{
				int num = -2080882657;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC7353EBFu) % 3u)
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
					num = (int)((num2 * 532478113) ^ 0x7987E3BA);
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
				int num = -1087410878;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC0B4C778u) % 4u)
					{
					case 3u:
						num = (int)((num2 * 1864242534) ^ 0x4177F66F);
						continue;
					case 2u:
						result = Resources.smethod_3(ResourceManager, "Rondo_2_South_Inside_Exit", resourceCulture);
						num = ((int)num2 * -1570516823) ^ -1541866543;
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

	internal static string Rondo_2_West_Exit
	{
		get
		{
			string result = Resources.smethod_3(ResourceManager, "Rondo_2_West_Exit", resourceCulture);
			while (true)
			{
				int num = -2085436005;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB1FB8661u) % 3u)
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
					num = (int)(num2 * 1366097743) ^ -1004489889;
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
				int num = 1825836833;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4851A65Au) % 4u)
					{
					case 3u:
						result = Resources.smethod_3(ResourceManager, "Rondo_3_Inside_Left_exit", resourceCulture);
						num = ((int)num2 * -1270876311) ^ 0x76645838;
						continue;
					case 1u:
						num = (int)(num2 * 761154674) ^ -646805930;
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

	internal static string Rondo_3_North_Exit
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = -638988013;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE9A10609u) % 3u)
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
					result = Resources.smethod_3(ResourceManager, "Rondo_3_North_Exit", resourceCulture);
					num = (int)((num2 * 31115510) ^ 0x59E6284);
				}
			}
		}
	}

	internal static string Rondo_East_Inside
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = -2145980302;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF07A8A8Cu) % 4u)
					{
					case 2u:
						result = Resources.smethod_3(ResourceManager, "Rondo_East_Inside", resourceCulture);
						num = (int)((num2 * 1890840296) ^ 0x35215F5D);
						continue;
					case 1u:
						num = ((int)num2 * -1912067012) ^ 0x1FFE6A63;
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
				int num = 222427640;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6CAA748Cu) % 3u)
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
					num = (int)(num2 * 611535338) ^ -360385858;
				}
			}
		}
	}

	internal Resources()
	{
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
