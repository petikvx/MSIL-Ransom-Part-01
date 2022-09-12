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
			ResourceManager resourceManager = default(ResourceManager);
			ResourceManager result = default(ResourceManager);
			while (true)
			{
				int num = 1210563961;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3F333567u) % 7u)
					{
					case 6u:
						resourceManager = Veet.smethod_2("Cytotechnologist.Veet", Veet.smethod_1(Veet.smethod_0(typeof(Veet).TypeHandle)));
						num = (int)((num2 * 255681992) ^ 0x1F20E294);
						continue;
					case 5u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 1446996771;
							num4 = 1446996771;
						}
						else
						{
							num3 = 1431255841;
							num4 = 1431255841;
						}
						num = num3 ^ (int)(num2 * 1981844452);
						continue;
					}
					case 4u:
						num = ((int)num2 * -549294802) ^ 0x524E59F5;
						continue;
					case 2u:
						result = resourceMan;
						num = 1449011067;
						continue;
					case 1u:
						resourceMan = resourceManager;
						num = (int)(num2 * 2121299216) ^ -1826871699;
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
				int num = 640503552;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x33B74581u) % 4u)
					{
					case 2u:
						num = ((int)num2 * -95482978) ^ 0x67BEDF8D;
						continue;
					case 1u:
						result = Veet.smethod_3(ResourceManager, "Sa", resourceCulture);
						num = (int)(num2 * 286391473) ^ -834023034;
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

	internal static string Xe
	{
		get
		{
			string result = Veet.smethod_3(ResourceManager, "Xe", resourceCulture);
			while (true)
			{
				int num = 863552868;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x27EFD806u) % 3u)
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
					num = ((int)num2 * -558231202) ^ -1344517199;
				}
			}
		}
	}

	internal static string Zr => Veet.smethod_3(ResourceManager, "Zr", resourceCulture);

	internal Veet()
	{
		while (true)
		{
			int num = 1509846397;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x407D5AD0u) % 4u)
				{
				case 1u:
					num = ((int)num2 * -2103976193) ^ -627847777;
					continue;
				case 0u:
					num = (int)((num2 * 1290290236) ^ 0x6B0E75D6);
					continue;
				default:
					return;
				case 3u:
					break;
				case 2u:
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

	static string smethod_3(ResourceManager resourceManager_0, string string_0, CultureInfo cultureInfo_0)
	{
		return resourceManager_0.GetString(string_0, cultureInfo_0);
	}
}
