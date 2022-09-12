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
			while (true)
			{
				int num = 467791343;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x72D5418Au) % 6u)
					{
					case 5u:
						num = (int)(num2 * 2034410985) ^ -1484112695;
						continue;
					case 4u:
						result = resourceMan;
						num = 1703171131;
						continue;
					case 3u:
					{
						ResourceManager resourceManager = (resourceMan = Resources.smethod_3("Hospital_Management_System.Resources", Resources.smethod_2(Resources.smethod_1(typeof(Resources).TypeHandle))));
						num = (int)((num2 * 450481742) ^ 0xBD7EEC0);
						continue;
					}
					case 1u:
					{
						int num3;
						int num4;
						if (!Resources.smethod_0((object)resourceMan, (object)null))
						{
							num3 = -1885750716;
							num4 = -1885750716;
						}
						else
						{
							num3 = -2064222113;
							num4 = -2064222113;
						}
						num = num3 ^ (int)(num2 * 1194994054);
						continue;
					}
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			CultureInfo result = resourceCulture;
			while (true)
			{
				int num = 135113914;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7BDB62D3u) % 3u)
					{
					case 1u:
						goto IL_0008;
					case 2u:
						break;
					default:
						return result;
					}
					break;
					IL_0008:
					num = ((int)num2 * -1012108416) ^ 0x38E38531;
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
				int num = 425299406;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5C591FBCu) % 5u)
					{
					case 4u:
						obj = Resources.smethod_5(Resources.smethod_4(ResourceManager, "blood_goodpic", resourceCulture));
						num = ((int)num2 * -1013742019) ^ -1098395277;
						continue;
					case 2u:
						num = (int)(num2 * 668415967) ^ -1939922508;
						continue;
					case 0u:
						result = (Bitmap)obj;
						num = ((int)num2 * -100700464) ^ 0x400A93;
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

	internal static Bitmap checkup1
	{
		get
		{
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected O, but got Unknown
			object obj = default(object);
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = 639579366;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4798C5D1u) % 5u)
					{
					case 3u:
						obj = Resources.smethod_5(Resources.smethod_4(ResourceManager, "checkup1", resourceCulture));
						num = ((int)num2 * -1458349772) ^ 0x3CAE8B57;
						continue;
					case 1u:
						num = (int)(num2 * 1169201673) ^ -214468146;
						continue;
					case 0u:
						result = (Bitmap)obj;
						num = (int)((num2 * 155630402) ^ 0x33C98AF1);
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
				int num = 99986735;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6C49314Du) % 4u)
					{
					case 2u:
					{
						object obj = Resources.smethod_5(Resources.smethod_4(ResourceManager, "doc_Pic", resourceCulture));
						result = (Bitmap)obj;
						num = ((int)num2 * -250627866) ^ -1942009460;
						continue;
					}
					case 1u:
						num = (int)((num2 * 1667111952) ^ 0x6136701);
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

	internal static Bitmap hospi1
	{
		get
		{
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Expected O, but got Unknown
			object obj = Resources.smethod_5(Resources.smethod_4(ResourceManager, "hospi1", resourceCulture));
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = -1192430789;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC08A156Au) % 4u)
					{
					case 3u:
						num = ((int)num2 * -1510240398) ^ -1071588308;
						continue;
					case 1u:
						result = (Bitmap)obj;
						num = ((int)num2 * -846717343) ^ 0x608E11B8;
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

	internal static Bitmap Hospital_blue_icon
	{
		get
		{
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			object obj = Resources.smethod_5(Resources.smethod_4(ResourceManager, "Hospital-blue-icon", resourceCulture));
			return (Bitmap)obj;
		}
	}

	internal static Bitmap Hospital_red_icon
	{
		get
		{
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Expected O, but got Unknown
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = 1550032493;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6AD372C4u) % 4u)
					{
					case 2u:
						num = (int)((num2 * 433917810) ^ 0x171CDFE0);
						continue;
					case 1u:
					{
						object obj = Resources.smethod_5(Resources.smethod_4(ResourceManager, "Hospital-red-icon", resourceCulture));
						result = (Bitmap)obj;
						num = ((int)num2 * -1090426454) ^ -1261413340;
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

	internal static Bitmap imageedit_1_6564123496
	{
		get
		{
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Expected O, but got Unknown
			object obj = default(object);
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = 1583529318;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7F153E51u) % 4u)
					{
					case 3u:
						obj = Resources.smethod_5(Resources.smethod_4(ResourceManager, "imageedit_1_6564123496", resourceCulture));
						num = (int)(num2 * 398034695) ^ -268260548;
						continue;
					case 0u:
						result = (Bitmap)obj;
						num = ((int)num2 * -280767563) ^ -28040908;
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

	internal static Bitmap images
	{
		get
		{
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			Bitmap result = default(Bitmap);
			object obj = default(object);
			while (true)
			{
				int num = 1132963945;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7B35D945u) % 5u)
					{
					case 4u:
						num = ((int)num2 * -982694186) ^ -649443244;
						continue;
					case 3u:
						result = (Bitmap)obj;
						num = (int)((num2 * 1611570505) ^ 0x119E76FB);
						continue;
					case 1u:
						obj = Resources.smethod_5(Resources.smethod_4(ResourceManager, "images", resourceCulture));
						num = (int)(num2 * 759276132) ^ -1002247409;
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

	internal static Bitmap images1232
	{
		get
		{
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Expected O, but got Unknown
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = -497379001;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD57470AAu) % 4u)
					{
					case 1u:
					{
						object obj = Resources.smethod_5(Resources.smethod_4(ResourceManager, "images1232", resourceCulture));
						result = (Bitmap)obj;
						num = ((int)num2 * -1933581597) ^ -593501479;
						continue;
					}
					case 0u:
						num = (int)((num2 * 99704577) ^ 0x3CB65C75);
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

	internal static Bitmap medical_bed_icon
	{
		get
		{
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Expected O, but got Unknown
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = 1103262271;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x29924C3Cu) % 4u)
					{
					case 3u:
					{
						object obj = Resources.smethod_5(Resources.smethod_4(ResourceManager, "medical-bed-icon", resourceCulture));
						result = (Bitmap)obj;
						num = ((int)num2 * -1654076142) ^ -1649067977;
						continue;
					}
					case 1u:
						num = ((int)num2 * -130339823) ^ 0x14C19BBF;
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

	internal static Bitmap Medical_Nurse_Male_Light_icon
	{
		get
		{
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected O, but got Unknown
			object obj = default(object);
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = -1296055058;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBA7F4D74u) % 5u)
					{
					case 2u:
						num = ((int)num2 * -1136054596) ^ 0x233DF5DA;
						continue;
					case 1u:
						obj = Resources.smethod_5(Resources.smethod_4(ResourceManager, "Medical-Nurse-Male-Light-icon", resourceCulture));
						num = ((int)num2 * -413520464) ^ -1432953762;
						continue;
					case 0u:
						result = (Bitmap)obj;
						num = ((int)num2 * -1662126863) ^ 0x429C321A;
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

	internal static Bitmap patient_pic
	{
		get
		{
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected O, but got Unknown
			object obj = default(object);
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = 1860600473;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5ACF1040u) % 5u)
					{
					case 2u:
						num = ((int)num2 * -1901174978) ^ -61812785;
						continue;
					case 1u:
						obj = Resources.smethod_5(Resources.smethod_4(ResourceManager, "patient_pic", resourceCulture));
						num = ((int)num2 * -507208102) ^ 0x4E6BA3EB;
						continue;
					case 0u:
						result = (Bitmap)obj;
						num = (int)((num2 * 2136300376) ^ 0x609B2FBF);
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

	internal static Bitmap IHashElementEntry
	{
		get
		{
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Expected O, but got Unknown
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = -2017102127;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAA0D4FCCu) % 4u)
					{
					case 2u:
						num = ((int)num2 * -858616133) ^ 0x2758B16E;
						continue;
					case 1u:
					{
						object obj = Resources.smethod_5(Resources.smethod_4(ResourceManager, "IHashElementEntry", resourceCulture));
						result = (Bitmap)obj;
						num = (int)(num2 * 1289394265) ^ -918541993;
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

	internal static Bitmap useless_pic
	{
		get
		{
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected O, but got Unknown
			object obj = Resources.smethod_5(Resources.smethod_4(ResourceManager, "useless_pic", resourceCulture));
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = 1825585959;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x788ABAE1u) % 3u)
					{
					case 2u:
						goto IL_001c;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_001c:
					result = (Bitmap)obj;
					num = (int)((num2 * 389163614) ^ 0x48B88CD3);
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
