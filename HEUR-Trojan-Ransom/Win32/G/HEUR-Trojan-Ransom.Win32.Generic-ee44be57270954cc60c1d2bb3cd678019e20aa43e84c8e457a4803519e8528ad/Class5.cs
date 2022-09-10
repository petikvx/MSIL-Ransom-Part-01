using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[HideModuleName]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[CompilerGenerated]
[DebuggerNonUserCode]
[StandardModule]
internal sealed class Class5
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager_0
	{
		get
		{
			bool flag = default(bool);
			ResourceManager resourceManager = default(ResourceManager);
			ResourceManager result = default(ResourceManager);
			while (true)
			{
				int num = 1168134522;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3BC3DF96u) % 10u)
					{
					case 9u:
						num = (int)(num2 * 1017017363) ^ -509451787;
						continue;
					case 8u:
						flag = object.ReferenceEquals(resourceManager_0, null);
						num = (int)(num2 * 1315554306) ^ -1014932907;
						continue;
					case 6u:
						resourceManager_0 = resourceManager;
						num = (int)((num2 * 1848994786) ^ 0x6FB7D7C1);
						continue;
					case 5u:
						result = resourceManager_0;
						num = (int)(num2 * 1019729280) ^ -927464143;
						continue;
					case 3u:
						num = (int)(num2 * 265577763) ^ -775399220;
						continue;
					case 2u:
						resourceManager = new ResourceManager("QMBVMDQaJJw.Resources", typeof(Class5).Assembly);
						num = (int)(num2 * 244530870) ^ -604362314;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 1859375158;
							num4 = 1859375158;
						}
						else
						{
							num3 = 1027288300;
							num4 = 1027288300;
						}
						num = num3 ^ ((int)num2 * -1361797902);
						continue;
					}
					case 0u:
						num = 325090279;
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo CultureInfo_0
	{
		get
		{
			CultureInfo result = default(CultureInfo);
			while (true)
			{
				int num = -1567390539;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDCEA7C3Au) % 4u)
					{
					case 3u:
						result = cultureInfo_0;
						num = (int)(num2 * 2078094717) ^ -1421771924;
						continue;
					case 1u:
						num = ((int)num2 * -197418464) ^ 0x4995D120;
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
				int num = -942672029;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDEDBB92Cu) % 3u)
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
					cultureInfo_0 = value;
					num = (int)((num2 * 2070534711) ^ 0x7BD0FB67);
				}
			}
		}
	}

	internal static Bitmap Bitmap_0
	{
		get
		{
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected O, but got Unknown
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager_0.GetObject("zlpQE", cultureInfo_0));
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = -739853564;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA1AB864Bu) % 4u)
					{
					case 3u:
						result = (Bitmap)objectValue;
						num = (int)(num2 * 83468429) ^ -1265872740;
						continue;
					case 0u:
						num = (int)(num2 * 1793565684) ^ -590287866;
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

	internal static Bitmap Bitmap_1
	{
		get
		{
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Expected O, but got Unknown
			object objectValue = default(object);
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = 18490669;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x497B9668u) % 4u)
					{
					case 1u:
						objectValue = RuntimeHelpers.GetObjectValue(ResourceManager_0.GetObject("BuNK", cultureInfo_0));
						num = (int)((num2 * 374572006) ^ 0x646D1462);
						continue;
					case 0u:
						result = (Bitmap)objectValue;
						num = ((int)num2 * -1187039279) ^ -1115733625;
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

	internal static Bitmap Bitmap_2
	{
		get
		{
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Expected O, but got Unknown
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = 463612712;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x52044187u) % 4u)
					{
					case 3u:
					{
						object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager_0.GetObject("hDbhdpsHce", cultureInfo_0));
						result = (Bitmap)objectValue;
						num = (int)(num2 * 230666211) ^ -1940522840;
						continue;
					}
					case 2u:
						num = (int)((num2 * 286808237) ^ 0x4BC1E774);
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

	internal static Bitmap Bitmap_3
	{
		get
		{
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected O, but got Unknown
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager_0.GetObject("UDDpcEamBi", cultureInfo_0));
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = 1306990824;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3A649D95u) % 4u)
					{
					case 1u:
						result = (Bitmap)objectValue;
						num = (int)(num2 * 689428844) ^ -740894967;
						continue;
					case 0u:
						num = ((int)num2 * -1533518737) ^ -2114298641;
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

	internal static string String_0
	{
		get
		{
			string @string = ResourceManager_0.GetString("nxsWlEYrlb", cultureInfo_0);
			while (true)
			{
				int num = -1653561744;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB564DD72u) % 3u)
					{
					case 2u:
						goto IL_0017;
					case 0u:
						break;
					default:
						return @string;
					}
					break;
					IL_0017:
					num = (int)((num2 * 1705026522) ^ 0x6B193014);
				}
			}
		}
	}
}
