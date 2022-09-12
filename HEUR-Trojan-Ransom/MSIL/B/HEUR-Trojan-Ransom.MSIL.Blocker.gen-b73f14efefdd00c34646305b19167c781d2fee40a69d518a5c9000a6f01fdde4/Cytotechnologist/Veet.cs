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
			bool flag = resourceMan == null;
			ResourceManager result = default(ResourceManager);
			ResourceManager resourceManager = default(ResourceManager);
			while (true)
			{
				int num = -1259865096;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCB3B0A5Bu) % 8u)
					{
					case 6u:
						result = resourceMan;
						num = -46723725;
						continue;
					case 5u:
						resourceMan = resourceManager;
						num = ((int)num2 * -2059583179) ^ -1686988432;
						continue;
					case 4u:
						resourceManager = Veet.smethod_2("Cytotechnologist.Veet", Veet.smethod_1(Veet.smethod_0(typeof(Veet).TypeHandle)));
						num = ((int)num2 * -546524912) ^ -84333386;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 1840435893;
							num4 = 1840435893;
						}
						else
						{
							num3 = 1820002018;
							num4 = 1820002018;
						}
						num = num3 ^ (int)(num2 * 1966954013);
						continue;
					}
					case 2u:
						num = (int)((num2 * 1187350128) ^ 0x3620D6F5);
						continue;
					case 1u:
						num = (int)(num2 * 32888960) ^ -754574329;
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
			return resourceCulture;
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
				int num = -2006347653;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFB02BC80u) % 4u)
					{
					case 3u:
						result = Veet.smethod_3(ResourceManager, "Xe", resourceCulture);
						num = ((int)num2 * -1972854326) ^ -1249446104;
						continue;
					case 2u:
						num = (int)((num2 * 1650201545) ^ 0x770CC747);
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

	internal static string Zr
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = -1942117570;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC5808958u) % 4u)
					{
					case 3u:
						num = (int)(num2 * 459138279) ^ -1666768228;
						continue;
					case 2u:
						result = Veet.smethod_3(ResourceManager, "Zr", resourceCulture);
						num = (int)(num2 * 584785697) ^ -1502653271;
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
