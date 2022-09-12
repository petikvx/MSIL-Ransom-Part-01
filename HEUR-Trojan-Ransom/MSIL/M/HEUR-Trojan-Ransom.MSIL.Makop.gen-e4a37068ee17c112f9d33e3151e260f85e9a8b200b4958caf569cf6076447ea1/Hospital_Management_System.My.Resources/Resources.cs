using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Hospital_Management_System.My.Resources;

[StandardModule]
[DebuggerNonUserCode]
[HideModuleName]
[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
internal sealed class Resources
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
			while (true)
			{
				int num = -563295014;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA2AD233Bu) % 7u)
					{
					case 5u:
						result = resourceMan;
						num = -197358647;
						continue;
					case 4u:
					{
						int num3;
						int num4;
						if (!Resources.smethod_0((object)resourceMan, (object)null))
						{
							num3 = 2063297505;
							num4 = 2063297505;
						}
						else
						{
							num3 = 965747187;
							num4 = 965747187;
						}
						num = num3 ^ ((int)num2 * -1035041435);
						continue;
					}
					case 3u:
						num = ((int)num2 * -54191593) ^ 0x97EE531;
						continue;
					case 1u:
						resourceMan = resourceManager;
						num = ((int)num2 * -122737327) ^ 0x6D7CAEA;
						continue;
					case 0u:
						resourceManager = Resources.smethod_3("Hospital_Management_System.Resources", Resources.smethod_2(Resources.smethod_1(typeof(Resources).TypeHandle)));
						num = (int)(num2 * 565990530) ^ -1710004381;
						continue;
					case 6u:
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
				int num = -700358214;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA9D20CE4u) % 4u)
					{
					case 2u:
						result = resourceCulture;
						num = (int)((num2 * 1989101132) ^ 0x5240D9D1);
						continue;
					case 1u:
						num = (int)(num2 * 965239553) ^ -1675997150;
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
			resourceCulture = value;
		}
	}

	internal static Bitmap blood_goodpic
	{
		get
		{
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected O, but got Unknown
			object obj = default(object);
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = 1244445163;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x50A4844Fu) % 5u)
					{
					case 3u:
						num = ((int)num2 * -293603154) ^ -625618872;
						continue;
					case 2u:
						obj = Resources.smethod_5(Resources.smethod_4(ResourceManager, "blood_goodpic", resourceCulture));
						num = (int)((num2 * 2076150900) ^ 0x1AFB550B);
						continue;
					case 1u:
						result = (Bitmap)obj;
						num = (int)((num2 * 1224643638) ^ 0x7A27446C);
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

	internal static Bitmap checkup1
	{
		get
		{
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected O, but got Unknown
			object obj = Resources.smethod_5(Resources.smethod_4(ResourceManager, "checkup1", resourceCulture));
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = -1732302260;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFA37446Fu) % 4u)
					{
					case 3u:
						result = (Bitmap)obj;
						num = (int)((num2 * 203758598) ^ 0x571CFD7D);
						continue;
					case 0u:
						num = (int)((num2 * 1958932568) ^ 0x670246D2);
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

	internal static Bitmap doc_Pic
	{
		get
		{
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Expected O, but got Unknown
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = -121912398;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCFD17255u) % 3u)
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
					object obj = Resources.smethod_5(Resources.smethod_4(ResourceManager, "doc_Pic", resourceCulture));
					result = (Bitmap)obj;
					num = (int)((num2 * 1579630685) ^ 0x57B3EA29);
				}
			}
		}
	}

	internal static Bitmap hospi1
	{
		get
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Expected O, but got Unknown
			Bitmap result = default(Bitmap);
			object obj = default(object);
			while (true)
			{
				int num = 1118070241;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3281D4A8u) % 4u)
					{
					case 2u:
						result = (Bitmap)obj;
						num = ((int)num2 * -2044122353) ^ 0x4B417D4E;
						continue;
					case 1u:
						obj = Resources.smethod_5(Resources.smethod_4(ResourceManager, "hospi1", resourceCulture));
						num = (int)((num2 * 1264121298) ^ 0x43ACF484);
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

	internal static Bitmap Hospital_blue_icon
	{
		get
		{
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Expected O, but got Unknown
			object obj = default(object);
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = -1714652143;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA971F973u) % 5u)
					{
					case 3u:
						obj = Resources.smethod_5(Resources.smethod_4(ResourceManager, "Hospital-blue-icon", resourceCulture));
						num = (int)((num2 * 312703844) ^ 0x208D0831);
						continue;
					case 2u:
						result = (Bitmap)obj;
						num = ((int)num2 * -1126514760) ^ -248121857;
						continue;
					case 1u:
						num = (int)(num2 * 681274128) ^ -730606855;
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

	internal static Bitmap Hospital_red_icon
	{
		get
		{
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected O, but got Unknown
			object obj = default(object);
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = -1048117036;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA37C9A25u) % 5u)
					{
					case 4u:
						obj = Resources.smethod_5(Resources.smethod_4(ResourceManager, "Hospital-red-icon", resourceCulture));
						num = (int)((num2 * 1677060058) ^ 0x633C830D);
						continue;
					case 2u:
						num = (int)(num2 * 1996784561) ^ -200903077;
						continue;
					case 1u:
						result = (Bitmap)obj;
						num = ((int)num2 * -226578300) ^ 0x5DC92ABD;
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

	internal static Bitmap imageedit_1_6564123496
	{
		get
		{
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected O, but got Unknown
			object obj = Resources.smethod_5(Resources.smethod_4(ResourceManager, "imageedit_1_6564123496", resourceCulture));
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = 825794948;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x316C302Fu) % 3u)
					{
					case 1u:
						goto IL_001c;
					case 2u:
						break;
					default:
						return result;
					}
					break;
					IL_001c:
					result = (Bitmap)obj;
					num = (int)((num2 * 721542515) ^ 0x15F84544);
				}
			}
		}
	}

	internal static Bitmap images
	{
		get
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Expected O, but got Unknown
			Bitmap result = default(Bitmap);
			object obj = default(object);
			while (true)
			{
				int num = -125084938;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE2D368D7u) % 4u)
					{
					case 2u:
						result = (Bitmap)obj;
						num = (int)((num2 * 1510641686) ^ 0x742F1A58);
						continue;
					case 1u:
						obj = Resources.smethod_5(Resources.smethod_4(ResourceManager, "images", resourceCulture));
						num = (int)(num2 * 1816621142) ^ -1235559845;
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

	internal static Bitmap images1232
	{
		get
		{
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			object obj = Resources.smethod_5(Resources.smethod_4(ResourceManager, "images1232", resourceCulture));
			Bitmap result = (Bitmap)obj;
			while (true)
			{
				int num = -43834563;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD7145C0Au) % 3u)
					{
					case 1u:
						goto IL_0023;
					case 2u:
						break;
					default:
						return result;
					}
					break;
					IL_0023:
					num = (int)((num2 * 595654727) ^ 0x75A2BE57);
				}
			}
		}
	}

	internal static Bitmap medical_bed_icon
	{
		get
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Expected O, but got Unknown
			Bitmap result = default(Bitmap);
			object obj = default(object);
			while (true)
			{
				int num = 997274198;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5006487Au) % 5u)
					{
					case 3u:
						result = (Bitmap)obj;
						num = (int)(num2 * 1625295686) ^ -2052055945;
						continue;
					case 2u:
						obj = Resources.smethod_5(Resources.smethod_4(ResourceManager, "medical-bed-icon", resourceCulture));
						num = ((int)num2 * -1578141989) ^ -1990612882;
						continue;
					case 1u:
						num = (int)((num2 * 2055104321) ^ 0x40D43701);
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

	internal static Bitmap Medical_Nurse_Male_Light_icon
	{
		get
		{
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Expected O, but got Unknown
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = 219427396;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB29B241u) % 4u)
					{
					case 1u:
					{
						object obj = Resources.smethod_5(Resources.smethod_4(ResourceManager, "Medical-Nurse-Male-Light-icon", resourceCulture));
						result = (Bitmap)obj;
						num = (int)((num2 * 1550925355) ^ 0x3B805832);
						continue;
					}
					case 0u:
						num = ((int)num2 * -1015539397) ^ 0x7ACBE7AA;
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

	internal static Bitmap patient_pic
	{
		get
		{
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			object obj = Resources.smethod_5(Resources.smethod_4(ResourceManager, "patient_pic", resourceCulture));
			return (Bitmap)obj;
		}
	}

	internal static Bitmap ProgIdRedirectionEntry
	{
		get
		{
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			object obj = Resources.smethod_5(Resources.smethod_4(ResourceManager, "ProgIdRedirectionEntry", resourceCulture));
			Bitmap result = (Bitmap)obj;
			while (true)
			{
				int num = -253927824;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC22E41E5u) % 3u)
					{
					case 2u:
						goto IL_0023;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0023:
					num = (int)((num2 * 778672383) ^ 0x2C2CEE09);
				}
			}
		}
	}

	internal static Bitmap useless_pic
	{
		get
		{
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			Bitmap result = default(Bitmap);
			object obj = default(object);
			while (true)
			{
				int num = -535508993;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x83D22A1Bu) % 5u)
					{
					case 4u:
						num = (int)((num2 * 1271860200) ^ 0x2B365717);
						continue;
					case 3u:
						result = (Bitmap)obj;
						num = ((int)num2 * -1788258114) ^ -331795568;
						continue;
					case 2u:
						obj = Resources.smethod_5(Resources.smethod_4(ResourceManager, "useless_pic", resourceCulture));
						num = (int)(num2 * 1799806616) ^ -2074147993;
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

	static bool smethod_0(object object_0, object object_1)
	{
		return object.ReferenceEquals(object_0, object_1);
	}

	static Type smethod_1(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static Assembly smethod_2(Type type_0)
	{
		return type_0.Assembly;
	}

	static ResourceManager smethod_3(string string_0, Assembly assembly_0)
	{
		return new ResourceManager(string_0, assembly_0);
	}

	static object smethod_4(ResourceManager resourceManager_0, string string_0, CultureInfo cultureInfo_0)
	{
		return resourceManager_0.GetObject(string_0, cultureInfo_0);
	}

	static object smethod_5(object object_0)
	{
		return RuntimeHelpers.GetObjectValue(object_0);
	}
}
