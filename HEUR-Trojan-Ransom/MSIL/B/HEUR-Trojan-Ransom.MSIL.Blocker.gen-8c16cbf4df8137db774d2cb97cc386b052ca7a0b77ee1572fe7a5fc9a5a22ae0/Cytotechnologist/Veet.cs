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
			ResourceManager resourceManager = default(ResourceManager);
			ResourceManager result = default(ResourceManager);
			while (true)
			{
				int num = -1469550274;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA67C54EDu) % 6u)
					{
					case 5u:
						resourceMan = resourceManager;
						num = (int)(num2 * 1019604513) ^ -607369028;
						continue;
					case 4u:
						result = resourceMan;
						num = -1292760590;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (resourceMan != null)
						{
							num3 = -1168547626;
							num4 = -1168547626;
						}
						else
						{
							num3 = -129836130;
							num4 = -129836130;
						}
						num = num3 ^ ((int)num2 * -1607866479);
						continue;
					}
					case 0u:
						resourceManager = Veet.smethod_2("Cytotechnologist.Veet", Veet.smethod_1(Veet.smethod_0(typeof(Veet).TypeHandle)));
						num = (int)((num2 * 530562412) ^ 0x626BAB64);
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
			return resourceCulture;
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static string Sa
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = -141222583;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF04D21FAu) % 4u)
					{
					case 3u:
						result = Veet.smethod_3(ResourceManager, "Sa", resourceCulture);
						num = ((int)num2 * -513659095) ^ 0x949C538;
						continue;
					case 1u:
						num = ((int)num2 * -919956315) ^ 0x604FA34D;
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

	internal static string Xe
	{
		get
		{
			string result = Veet.smethod_3(ResourceManager, "Xe", resourceCulture);
			while (true)
			{
				int num = -1424008373;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA2188B7Eu) % 3u)
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
					num = (int)(num2 * 817234377) ^ -1824686649;
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
				int num = -1462016085;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x99F54D86u) % 4u)
					{
					case 1u:
						result = Veet.smethod_3(ResourceManager, "Zr", resourceCulture);
						num = (int)(num2 * 2072081301) ^ -839703029;
						continue;
					case 0u:
						num = ((int)num2 * -1678755858) ^ 0x33F99B35;
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
