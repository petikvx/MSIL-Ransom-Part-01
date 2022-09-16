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
			ResourceManager resourceManager = default(ResourceManager);
			bool flag = default(bool);
			while (true)
			{
				int num = -612411640;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA0C537A9u) % 8u)
					{
					case 7u:
						result = resourceMan;
						num = -399726254;
						continue;
					case 6u:
						resourceManager = Resources.smethod_2("Traffic_Simulation.Properties.Resources", Resources.smethod_1(Resources.smethod_0(typeof(Resources).TypeHandle)));
						num = ((int)num2 * -1053685076) ^ 0x39138A35;
						continue;
					case 4u:
						resourceMan = resourceManager;
						num = ((int)num2 * -600216267) ^ 0x57A05C4D;
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 1575474549;
							num4 = 1575474549;
						}
						else
						{
							num3 = 2143776484;
							num4 = 2143776484;
						}
						num = num3 ^ ((int)num2 * -1615198323);
						continue;
					}
					case 1u:
						flag = resourceMan == null;
						num = (int)(num2 * 2146912845) ^ -1914946018;
						continue;
					case 0u:
						num = ((int)num2 * -855121065) ^ 0x27891556;
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
			return resourceCulture;
		}
		set
		{
			while (true)
			{
				int num = 1056727608;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5A745ACBu) % 3u)
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
					resourceCulture = value;
					num = ((int)num2 * -633581615) ^ 0xCDAE7A8;
				}
			}
		}
	}

	internal static string Aleje_East_Entry_Rondo
	{
		get
		{
			string result = Resources.smethod_3(ResourceManager, "Aleje_East_Entry_Rondo", resourceCulture);
			while (true)
			{
				int num = 573930453;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x794462Cu) % 3u)
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
					num = ((int)num2 * -999796072) ^ -1767993398;
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
				int num = -1027481272;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x97821DEFu) % 3u)
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
					result = Resources.smethod_3(ResourceManager, "Aleje_East_Exit_1", resourceCulture);
					num = ((int)num2 * -640071914) ^ 0x500EE1FB;
				}
			}
		}
	}

	internal static string Aleje_East_Exit_2 => Resources.smethod_3(ResourceManager, "Aleje_East_Exit_2", resourceCulture);

	internal static string Aleje_East_Right_Bitwy => Resources.smethod_3(ResourceManager, "Aleje_East_Right_Bitwy", resourceCulture);

	internal static string Aleje_Entry_Left_Bitwy
	{
		get
		{
			string result = Resources.smethod_3(ResourceManager, "Aleje_Entry_Left_Bitwy", resourceCulture);
			while (true)
			{
				int num = 1055675980;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x612995FEu) % 3u)
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
					num = (int)(num2 * 595412102) ^ -2138974214;
				}
			}
		}
	}

	internal static string Aleje_West_Entry_1
	{
		get
		{
			string result = Resources.smethod_3(ResourceManager, "Aleje_West_Entry_1", resourceCulture);
			while (true)
			{
				int num = -1363613298;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAC4C44F4u) % 3u)
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
					num = (int)((num2 * 509773988) ^ 0x603C847C);
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
				int num = 376773990;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x625F6965u) % 3u)
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
					num = ((int)num2 * -437972784) ^ 0x5E56E467;
				}
			}
		}
	}

	internal static string Aleje_West_Entry_Bitwy => Resources.smethod_3(ResourceManager, "Aleje_West_Entry_Bitwy", resourceCulture);

	internal static string Aleje_West_Exit_1
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = -1125580833;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD982CF40u) % 4u)
					{
					case 3u:
						result = Resources.smethod_3(ResourceManager, "Aleje_West_Exit_1", resourceCulture);
						num = ((int)num2 * -686513947) ^ -1557528450;
						continue;
					case 1u:
						num = (int)((num2 * 893603601) ^ 0xE8C8EF3);
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

	internal static string Aleje_West_Exit_2
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = 1371896083;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6A8ADE1Du) % 3u)
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
					result = Resources.smethod_3(ResourceManager, "Aleje_West_Exit_2", resourceCulture);
					num = ((int)num2 * -2116813748) ^ -637919897;
				}
			}
		}
	}

	internal static string Bitwy_North_Entry_1
	{
		get
		{
			string result = Resources.smethod_3(ResourceManager, "Bitwy_North_Entry_1", resourceCulture);
			while (true)
			{
				int num = 1193490483;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5FA83B88u) % 3u)
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
					num = (int)(num2 * 1157491476) ^ -1478159024;
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
				int num = 224463511;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1FE1751Cu) % 3u)
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
					result = Resources.smethod_3(ResourceManager, "Bitwy_North_Entry_2", resourceCulture);
					num = (int)((num2 * 1933457627) ^ 0x6B686129);
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
				int num = -1716040978;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD666AA6Fu) % 4u)
					{
					case 1u:
						result = Resources.smethod_3(ResourceManager, "Bitwy_North_Entry_Left_Rondo", resourceCulture);
						num = (int)((num2 * 243428407) ^ 0x48BEF120);
						continue;
					case 0u:
						num = ((int)num2 * -1296451259) ^ 0x186119A5;
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
				int num = -705092707;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x96438A08u) % 4u)
					{
					case 2u:
						num = (int)(num2 * 434350537) ^ -1478594467;
						continue;
					case 1u:
						result = Resources.smethod_3(ResourceManager, "Bitwy_North_Exit_1", resourceCulture);
						num = ((int)num2 * -980048283) ^ -1084832257;
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

	internal static string Bitwy_North_Exit_2 => Resources.smethod_3(ResourceManager, "Bitwy_North_Exit_2", resourceCulture);

	internal static string Bitwy_North_Left_Exit
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = 1238453203;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1C8FD514u) % 3u)
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
					result = Resources.smethod_3(ResourceManager, "Bitwy_North_Left_Exit", resourceCulture);
					num = ((int)num2 * -991332994) ^ 0x38E5CF1B;
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
				int num = 988994012;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x108480C1u) % 4u)
					{
					case 1u:
						result = Resources.smethod_3(ResourceManager, "Bitwy_North_Right_Aleje", resourceCulture);
						num = (int)((num2 * 2021535252) ^ 0x19FD98C9);
						continue;
					case 0u:
						num = (int)((num2 * 1888378772) ^ 0x2A4C570F);
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

	internal static string Bitwy_South_Entry_1
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = -1268474341;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA252E938u) % 3u)
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
					result = Resources.smethod_3(ResourceManager, "Bitwy_South_Entry_1", resourceCulture);
					num = ((int)num2 * -927658641) ^ 0x25E79885;
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
				int num = 1819441579;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x72D264F8u) % 3u)
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
					result = Resources.smethod_3(ResourceManager, "Bitwy_South_Entry_2", resourceCulture);
					num = (int)((num2 * 1780190479) ^ 0x9A887AF);
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
				int num = -1407431710;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBD1A8E48u) % 4u)
					{
					case 2u:
						result = Resources.smethod_3(ResourceManager, "Bitwy_South_Exit_1", resourceCulture);
						num = (int)((num2 * 1131851275) ^ 0x67E73407);
						continue;
					case 1u:
						num = (int)((num2 * 1727639496) ^ 0x4BF08270);
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

	internal static string Bitwy_South_Exit_2
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = -1657625867;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD87D3D9Cu) % 4u)
					{
					case 3u:
						num = (int)((num2 * 373959487) ^ 0x793306C1);
						continue;
					case 1u:
						result = Resources.smethod_3(ResourceManager, "Bitwy_South_Exit_2", resourceCulture);
						num = (int)((num2 * 1702711383) ^ 0x6B406A98);
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

	internal static string Bitwy_South_Right_Aleje => Resources.smethod_3(ResourceManager, "Bitwy_South_Right_Aleje", resourceCulture);

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
				int num = -614527483;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD1238BE4u) % 4u)
					{
					case 1u:
						result = (Bitmap)obj;
						num = ((int)num2 * -830372480) ^ -1484941432;
						continue;
					case 0u:
						num = (int)((num2 * 1381912563) ^ 0x60BFDE9A);
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
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			object obj = Resources.smethod_4(ResourceManager, "mario", resourceCulture);
			Bitmap result = (Bitmap)obj;
			while (true)
			{
				int num = 1076766747;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x72A74DD9u) % 3u)
					{
					case 2u:
						goto IL_001e;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_001e:
					num = (int)((num2 * 1034302111) ^ 0x2729789B);
				}
			}
		}
	}

	internal static Bitmap pic
	{
		get
		{
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Expected O, but got Unknown
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = 289398063;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7EE8AE04u) % 3u)
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
					object obj = Resources.smethod_4(ResourceManager, "pic", resourceCulture);
					result = (Bitmap)obj;
					num = (int)((num2 * 695370800) ^ 0x61DCFD62);
				}
			}
		}
	}

	internal static Bitmap pikachu
	{
		get
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected O, but got Unknown
			object obj = default(object);
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = -365276958;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE81A648Fu) % 4u)
					{
					case 1u:
						obj = Resources.smethod_4(ResourceManager, "pikachu", resourceCulture);
						num = ((int)num2 * -1605780736) ^ 0x5117AD17;
						continue;
					case 0u:
						result = (Bitmap)obj;
						num = ((int)num2 * -38919713) ^ -277950907;
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

	internal static Bitmap iLCPXp
	{
		get
		{
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Expected O, but got Unknown
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = -1853820528;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCD2F3653u) % 3u)
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
					object obj = Resources.smethod_4(ResourceManager, "iLCPXp", resourceCulture);
					result = (Bitmap)obj;
					num = ((int)num2 * -1127311471) ^ -1290157686;
				}
			}
		}
	}

	internal static string Rondo_1_East_Entry_Rondo_2 => Resources.smethod_3(ResourceManager, "Rondo_1_East_Entry_Rondo_2", resourceCulture);

	internal static string Rondo_1_Inside_Left_Entry_Rondo_2
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = -1134695310;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCA72880Cu) % 3u)
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
					result = Resources.smethod_3(ResourceManager, "Rondo_1_Inside_Left_Entry_Rondo_2", resourceCulture);
					num = ((int)num2 * -147108025) ^ -1925163109;
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
				int num = -1929379106;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA63EA080u) % 3u)
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
					result = Resources.smethod_3(ResourceManager, "Rondo_1_North_Entry_Rondo_2", resourceCulture);
					num = (int)((num2 * 1738365886) ^ 0x59C27322);
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
				int num = -1796115362;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF1CACF83u) % 4u)
					{
					case 3u:
						num = (int)(num2 * 1698013475) ^ -1820391128;
						continue;
					case 1u:
						result = Resources.smethod_3(ResourceManager, "Rondo_1_South_Entry_Rondo_2", resourceCulture);
						num = (int)(num2 * 633484245) ^ -49952019;
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

	internal static string Rondo_1_South_Inside_Rondo_2_Inside
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = -348911762;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAFF4894Du) % 3u)
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
					result = Resources.smethod_3(ResourceManager, "Rondo_1_South_Inside_Rondo_2_Inside", resourceCulture);
					num = (int)((num2 * 1179026131) ^ 0x1A49C27D);
				}
			}
		}
	}

	internal static string Rondo_1_West_Entry_Rondo_2
	{
		get
		{
			string result = Resources.smethod_3(ResourceManager, "Rondo_1_West_Entry_Rondo_2", resourceCulture);
			while (true)
			{
				int num = -1349689513;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD3ACD9C6u) % 3u)
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
					num = ((int)num2 * -1710994109) ^ 0x2F62E439;
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
				int num = -1914624881;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE6A5FEF0u) % 3u)
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
					num = ((int)num2 * -1448667343) ^ -1889455438;
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
				int num = 9142446;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2F025BFFu) % 3u)
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
					result = Resources.smethod_3(ResourceManager, "Rondo_2_Inside_Left_Entry_Rondo_3", resourceCulture);
					num = ((int)num2 * -1501722324) ^ -1806181994;
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
				int num = 483332579;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3F1FB141u) % 3u)
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
					result = Resources.smethod_3(ResourceManager, "Rondo_2_North_Entry_Rondo_3", resourceCulture);
					num = ((int)num2 * -331994827) ^ 0x2E9D8FB6;
				}
			}
		}
	}

	internal static string Rondo_2_South_Exit => Resources.smethod_3(ResourceManager, "Rondo_2_South_Exit", resourceCulture);

	internal static string Rondo_2_South_Inside_Exit
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = -355889678;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEFEA947Du) % 3u)
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
					result = Resources.smethod_3(ResourceManager, "Rondo_2_South_Inside_Exit", resourceCulture);
					num = ((int)num2 * -1224949632) ^ 0x1A8D45CA;
				}
			}
		}
	}

	internal static string Rondo_2_West_Exit
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = -92356126;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x98B22357u) % 3u)
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
					result = Resources.smethod_3(ResourceManager, "Rondo_2_West_Exit", resourceCulture);
					num = ((int)num2 * -620482347) ^ -2071084805;
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
				int num = 1631142994;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x46A43C14u) % 3u)
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
					result = Resources.smethod_3(ResourceManager, "Rondo_3_Inside_Left_exit", resourceCulture);
					num = (int)(num2 * 1647989088) ^ -940942242;
				}
			}
		}
	}

	internal static string Rondo_3_North_Exit => Resources.smethod_3(ResourceManager, "Rondo_3_North_Exit", resourceCulture);

	internal static string Rondo_East_Inside => Resources.smethod_3(ResourceManager, "Rondo_East_Inside", resourceCulture);

	internal static Bitmap star
	{
		get
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Expected O, but got Unknown
			Bitmap result = default(Bitmap);
			object obj = default(object);
			while (true)
			{
				int num = -473923584;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFBB1EFDEu) % 4u)
					{
					case 3u:
						result = (Bitmap)obj;
						num = ((int)num2 * -1667365774) ^ -222933423;
						continue;
					case 2u:
						obj = Resources.smethod_4(ResourceManager, "star", resourceCulture);
						num = ((int)num2 * -1623659181) ^ -643097933;
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
