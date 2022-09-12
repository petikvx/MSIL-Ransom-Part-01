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
			ResourceManager resourceManager = default(ResourceManager);
			while (true)
			{
				int num = -45810588;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x97BD4451u) % 9u)
					{
					case 7u:
						num = ((int)num2 * -1585437931) ^ 0x42079EC3;
						continue;
					case 6u:
						num = ((int)num2 * -1527312713) ^ -1206856975;
						continue;
					case 5u:
						result = resourceMan;
						num = -106358738;
						continue;
					case 3u:
						resourceManager = Veet.smethod_2("Cytotechnologist.Veet", Veet.smethod_1(Veet.smethod_0(typeof(Veet).TypeHandle)));
						num = (int)(num2 * 732776496) ^ -427141479;
						continue;
					case 2u:
						num = ((int)num2 * -292548489) ^ -1580267680;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (resourceMan == null)
						{
							num3 = -1960469195;
							num4 = -1960469195;
						}
						else
						{
							num3 = -105636628;
							num4 = -105636628;
						}
						num = num3 ^ (int)(num2 * 1022677680);
						continue;
					}
					case 0u:
						resourceMan = resourceManager;
						num = ((int)num2 * -1954453844) ^ 0x29B4360A;
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
	internal static CultureInfo Culture
	{
		get
		{
			return resourceCulture;
		}
		set
		{
			while (true)
			{
				int num = 234722067;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7103BA57u) % 3u)
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
					resourceCulture = value;
					num = (int)((num2 * 1804438741) ^ 0x799BE43D);
				}
			}
		}
	}

	internal static string Sa
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = -880523488;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBE68FE91u) % 4u)
					{
					case 3u:
						num = ((int)num2 * -1379259758) ^ 0x25047A7B;
						continue;
					case 1u:
						result = Veet.smethod_3(ResourceManager, "Sa", resourceCulture);
						num = (int)((num2 * 1547328601) ^ 0x26253F73);
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

	internal static string Xe
	{
		get
		{
			string result = Veet.smethod_3(ResourceManager, "Xe", resourceCulture);
			while (true)
			{
				int num = 573847136;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7CDD41BDu) % 3u)
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
					num = ((int)num2 * -852151099) ^ 0x7050FB3B;
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
				int num = 2106657940;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x267154BFu) % 4u)
					{
					case 3u:
						result = Veet.smethod_3(ResourceManager, "Zr", resourceCulture);
						num = ((int)num2 * -17802382) ^ -1888051195;
						continue;
					case 0u:
						num = (int)((num2 * 1264600680) ^ 0x70B5AE2);
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
		while (true)
		{
			int num = -225039487;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8F05AE90u) % 4u)
				{
				case 1u:
					num = (int)((num2 * 1846911596) ^ 0xF51BDD8);
					continue;
				case 0u:
					num = ((int)num2 * -795283822) ^ 0x7F2985A3;
					continue;
				default:
					return;
				case 2u:
					break;
				case 3u:
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
