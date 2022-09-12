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

[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[StandardModule]
[DebuggerNonUserCode]
[HideModuleName]
internal sealed class Resources
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			bool flag = Resources.smethod_0((object)resourceMan, (object)null);
			ResourceManager resourceManager = default(ResourceManager);
			ResourceManager result = default(ResourceManager);
			while (true)
			{
				int num = 1948839752;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1FE76D57u) % 7u)
					{
					case 6u:
						resourceManager = Resources.smethod_3("Hospital_Management_System.Resources", Resources.smethod_2(Resources.smethod_1(typeof(Resources).TypeHandle)));
						num = (int)((num2 * 149137506) ^ 0x2BE4A92D);
						continue;
					case 4u:
						num = (int)((num2 * 221404651) ^ 0x53356683);
						continue;
					case 3u:
						resourceMan = resourceManager;
						num = ((int)num2 * -819234188) ^ -583029179;
						continue;
					case 2u:
						result = resourceMan;
						num = 1355401070;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 1943614333;
							num4 = 1943614333;
						}
						else
						{
							num3 = 30865752;
							num4 = 30865752;
						}
						num = num3 ^ (int)(num2 * 698461267);
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			CultureInfo result = resourceCulture;
			while (true)
			{
				int num = 1206513881;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x27BFEDB6u) % 3u)
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
					num = ((int)num2 * -1398416117) ^ 0x33374C81;
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
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Expected O, but got Unknown
			object obj = default(object);
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = -434233232;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF68A5B43u) % 4u)
					{
					case 3u:
						obj = Resources.smethod_5(Resources.smethod_4(ResourceManager, "blood_goodpic", resourceCulture));
						num = ((int)num2 * -1103887669) ^ -1177011473;
						continue;
					case 1u:
						result = (Bitmap)obj;
						num = (int)((num2 * 1670478268) ^ 0x19B883D1);
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
				int num = -1123727017;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC4AC45B7u) % 3u)
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
					num = ((int)num2 * -1662594542) ^ -256849567;
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
				int num = 1358541360;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x240C7C12u) % 3u)
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
					object obj = Resources.smethod_5(Resources.smethod_4(ResourceManager, "doc_Pic", resourceCulture));
					result = (Bitmap)obj;
					num = (int)((num2 * 716518623) ^ 0x7D7690B8);
				}
			}
		}
	}

	internal static Bitmap hospi1
	{
		get
		{
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			object obj = Resources.smethod_5(Resources.smethod_4(ResourceManager, "hospi1", resourceCulture));
			Bitmap result = (Bitmap)obj;
			while (true)
			{
				int num = -706365553;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF82020CFu) % 3u)
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
					num = ((int)num2 * -107111853) ^ 0x22799ABE;
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
				int num = -1677560038;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE8661601u) % 4u)
					{
					case 3u:
						obj = Resources.smethod_5(Resources.smethod_4(ResourceManager, "Hospital-blue-icon", resourceCulture));
						num = ((int)num2 * -1419429825) ^ 0x4CA2C946;
						continue;
					case 2u:
						result = (Bitmap)obj;
						num = ((int)num2 * -1623919450) ^ 0x2191B230;
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
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Expected O, but got Unknown
			object obj = Resources.smethod_5(Resources.smethod_4(ResourceManager, "Hospital-red-icon", resourceCulture));
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = 234926083;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x707A522Au) % 4u)
					{
					case 2u:
						num = ((int)num2 * -1704767679) ^ 0x5FD2368;
						continue;
					case 1u:
						result = (Bitmap)obj;
						num = ((int)num2 * -336266214) ^ 0x65FD2C3A;
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
				int num = -1403193987;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBE01CFEEu) % 4u)
					{
					case 3u:
						result = (Bitmap)obj;
						num = (int)(num2 * 1533614588) ^ -2125387226;
						continue;
					case 0u:
						num = ((int)num2 * -1730654906) ^ 0x3BAB0E0B;
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
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Expected O, but got Unknown
			object obj = default(object);
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = 1023339441;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2BB4AEA0u) % 5u)
					{
					case 3u:
						obj = Resources.smethod_5(Resources.smethod_4(ResourceManager, "images", resourceCulture));
						num = ((int)num2 * -1240818407) ^ -1282980486;
						continue;
					case 2u:
						result = (Bitmap)obj;
						num = (int)(num2 * 1650329031) ^ -131183261;
						continue;
					case 1u:
						num = ((int)num2 * -240635403) ^ -73469231;
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
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Expected O, but got Unknown
			Bitmap result = default(Bitmap);
			object obj = default(object);
			while (true)
			{
				int num = -646842628;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB5BB528Du) % 4u)
					{
					case 3u:
						result = (Bitmap)obj;
						num = (int)((num2 * 1030009600) ^ 0x36AD3E9);
						continue;
					case 1u:
						obj = Resources.smethod_5(Resources.smethod_4(ResourceManager, "images1232", resourceCulture));
						num = (int)(num2 * 1556156336) ^ -1777619130;
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
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Expected O, but got Unknown
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = 1930548868;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4E48D781u) % 4u)
					{
					case 3u:
						num = (int)(num2 * 1979344351) ^ -893494514;
						continue;
					case 1u:
					{
						object obj = Resources.smethod_5(Resources.smethod_4(ResourceManager, "medical-bed-icon", resourceCulture));
						result = (Bitmap)obj;
						num = (int)((num2 * 1706207237) ^ 0xD92CBD3);
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

	internal static Bitmap Medical_Nurse_Male_Light_icon
	{
		get
		{
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected O, but got Unknown
			object obj = Resources.smethod_5(Resources.smethod_4(ResourceManager, "Medical-Nurse-Male-Light-icon", resourceCulture));
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = -1660700274;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC0E7E2C9u) % 4u)
					{
					case 3u:
						result = (Bitmap)obj;
						num = ((int)num2 * -1553478820) ^ 0x801385B;
						continue;
					case 2u:
						num = ((int)num2 * -1848589892) ^ -532935392;
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

	internal static Bitmap patient_pic
	{
		get
		{
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected O, but got Unknown
			object obj = Resources.smethod_5(Resources.smethod_4(ResourceManager, "patient_pic", resourceCulture));
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = -1183718387;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xADC50670u) % 4u)
					{
					case 1u:
						result = (Bitmap)obj;
						num = ((int)num2 * -2133156556) ^ 0x7152723C;
						continue;
					case 0u:
						num = ((int)num2 * -1664607314) ^ 0x5D602213;
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

	internal static Bitmap DomainCompressedStack
	{
		get
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Expected O, but got Unknown
			Bitmap result = default(Bitmap);
			object obj = default(object);
			while (true)
			{
				int num = 2033947001;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCEA8D84u) % 5u)
					{
					case 3u:
						result = (Bitmap)obj;
						num = (int)(num2 * 1346899498) ^ -894140650;
						continue;
					case 2u:
						obj = Resources.smethod_5(Resources.smethod_4(ResourceManager, "DomainCompressedStack", resourceCulture));
						num = (int)((num2 * 1296278768) ^ 0x9BE4CED);
						continue;
					case 1u:
						num = ((int)num2 * -1501579794) ^ 0x7D4FBEEA;
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

	internal static Bitmap useless_pic
	{
		get
		{
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Expected O, but got Unknown
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = -1911797644;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDEADE14Du) % 4u)
					{
					case 1u:
					{
						object obj = Resources.smethod_5(Resources.smethod_4(ResourceManager, "useless_pic", resourceCulture));
						result = (Bitmap)obj;
						num = (int)(num2 * 2104334416) ^ -746779507;
						continue;
					}
					case 0u:
						num = (int)(num2 * 601634462) ^ -2070421101;
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
