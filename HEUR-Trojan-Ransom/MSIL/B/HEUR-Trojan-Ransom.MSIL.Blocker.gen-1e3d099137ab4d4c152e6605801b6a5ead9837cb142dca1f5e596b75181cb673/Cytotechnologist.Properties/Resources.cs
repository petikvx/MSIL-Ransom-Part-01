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
			ResourceManager resourceManager = default(ResourceManager);
			ResourceManager result = default(ResourceManager);
			bool flag = default(bool);
			while (true)
			{
				int num = -2088461878;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF188E978u) % 7u)
					{
					case 6u:
						resourceMan = resourceManager;
						num = ((int)num2 * -1044726012) ^ -1610675478;
						continue;
					case 5u:
						result = resourceMan;
						num = -1334447019;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 2019837561;
							num4 = 2019837561;
						}
						else
						{
							num3 = 876691366;
							num4 = 876691366;
						}
						num = num3 ^ (int)(num2 * 1025866260);
						continue;
					}
					case 1u:
						flag = resourceMan == null;
						num = (int)(num2 * 2024888003) ^ -468223785;
						continue;
					case 0u:
						resourceManager = Resources.smethod_2("Cytotechnologist.Properties.Resources", Resources.smethod_1(Resources.smethod_0(typeof(Resources).TypeHandle)));
						num = (int)(num2 * 2089998839) ^ -564327979;
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			CultureInfo result = default(CultureInfo);
			while (true)
			{
				int num = -1100939015;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD428AF79u) % 3u)
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
					result = resourceCulture;
					num = (int)(num2 * 612677427) ^ -92152501;
				}
			}
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static Bitmap XmlToFieldTypeM
	{
		get
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected O, but got Unknown
			object obj = Resources.smethod_3(ResourceManager, "XmlToFieldTypeM", resourceCulture);
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = 934138552;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x617D3F82u) % 3u)
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
					result = (Bitmap)obj;
					num = (int)(num2 * 1330148023) ^ -727898993;
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

	static object smethod_3(ResourceManager resourceManager_0, string string_0, CultureInfo cultureInfo_0)
	{
		return resourceManager_0.GetObject(string_0, cultureInfo_0);
	}
}
