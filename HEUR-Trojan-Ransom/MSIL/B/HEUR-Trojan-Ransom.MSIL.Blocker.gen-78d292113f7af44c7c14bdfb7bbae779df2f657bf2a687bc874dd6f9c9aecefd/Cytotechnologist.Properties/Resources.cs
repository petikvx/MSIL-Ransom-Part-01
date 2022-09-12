using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Cytotechnologist.Properties;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
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
				int num = -198717997;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC08E775Bu) % 10u)
					{
					case 9u:
						result = resourceMan;
						num = -1926870262;
						continue;
					case 8u:
						flag = resourceMan == null;
						num = (int)(num2 * 1203553638) ^ -1999164833;
						continue;
					case 7u:
						num = (int)((num2 * 387833794) ^ 0x3CC8BEE2);
						continue;
					case 6u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -501466488;
							num4 = -501466488;
						}
						else
						{
							num3 = -1812098760;
							num4 = -1812098760;
						}
						num = num3 ^ (int)(num2 * 1687073457);
						continue;
					}
					case 5u:
						num = ((int)num2 * -1931729742) ^ -1427729827;
						continue;
					case 4u:
						resourceMan = resourceManager;
						num = ((int)num2 * -16415892) ^ 0x26174C7C;
						continue;
					case 1u:
						num = ((int)num2 * -1043545283) ^ 0x324C8178;
						continue;
					case 0u:
						resourceManager = Resources.smethod_2("Cytotechnologist.Properties.Resources", Resources.smethod_1(Resources.smethod_0(typeof(Resources).TypeHandle)));
						num = (int)((num2 * 423043456) ^ 0x13F94FA7);
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return resourceCulture;
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static Bitmap IDictiona
	{
		get
		{
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Expected O, but got Unknown
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = -1296161522;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA51E1243u) % 4u)
					{
					case 1u:
					{
						object obj = Resources.smethod_3(ResourceManager, "IDictiona", resourceCulture);
						result = (Bitmap)obj;
						num = (int)((num2 * 1417724551) ^ 0x526C8488);
						continue;
					}
					case 0u:
						num = ((int)num2 * -1234449316) ^ 0x1ACC69F0;
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

	internal Resources()
	{
		while (true)
		{
			int num = -1721044681;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD55296DEu) % 4u)
				{
				case 3u:
					num = ((int)num2 * -147787792) ^ 0x5BB73A96;
					continue;
				case 1u:
					num = (int)(num2 * 611623033) ^ -451153504;
					continue;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
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

	static object smethod_3(ResourceManager resourceManager_0, string string_0, CultureInfo cultureInfo_0)
	{
		return resourceManager_0.GetObject(string_0, cultureInfo_0);
	}
}
