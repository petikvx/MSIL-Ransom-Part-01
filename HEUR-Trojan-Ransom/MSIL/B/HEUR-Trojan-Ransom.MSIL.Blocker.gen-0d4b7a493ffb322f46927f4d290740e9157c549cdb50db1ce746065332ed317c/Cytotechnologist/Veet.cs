using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Cytotechnologist;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal class Veet
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
				int num = 2074811367;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6E439D23u) % 8u)
					{
					case 6u:
						result = resourceMan;
						num = 647745366;
						continue;
					case 5u:
						num = (int)((num2 * 673638403) ^ 0x12E6C697);
						continue;
					case 4u:
					{
						int num3;
						int num4;
						if (resourceMan == null)
						{
							num3 = -1645933717;
							num4 = -1645933717;
						}
						else
						{
							num3 = -1952777003;
							num4 = -1952777003;
						}
						num = num3 ^ ((int)num2 * -1237601118);
						continue;
					}
					case 2u:
					{
						ResourceManager resourceManager = (resourceMan = Veet.smethod_2("Cytotechnologist.Veet", Veet.smethod_1(Veet.smethod_0(typeof(Veet).TypeHandle))));
						num = ((int)num2 * -1984015986) ^ -217741538;
						continue;
					}
					case 1u:
						num = ((int)num2 * -425973409) ^ 0x107BD282;
						continue;
					case 0u:
						num = ((int)num2 * -1304568421) ^ -603866735;
						continue;
					case 7u:
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
				int num = 424879489;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1C660AD3u) % 3u)
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
					result = resourceCulture;
					num = (int)(num2 * 295898390) ^ -1103436370;
				}
			}
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static string Sa => Veet.smethod_3(ResourceManager, "Sa", resourceCulture);

	internal static string Xe
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = -112916559;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE0B0703Du) % 3u)
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
					result = Veet.smethod_3(ResourceManager, "Xe", resourceCulture);
					num = (int)(num2 * 1940074508) ^ -1150701597;
				}
			}
		}
	}

	internal static string Zr
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = 301324745;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x77847843u) % 3u)
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
					result = Veet.smethod_3(ResourceManager, "Zr", resourceCulture);
					num = (int)((num2 * 1128896249) ^ 0x59EA983C);
				}
			}
		}
	}

	internal Veet()
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
}
