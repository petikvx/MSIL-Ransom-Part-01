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
			bool flag = default(bool);
			ResourceManager resourceManager = default(ResourceManager);
			ResourceManager result = default(ResourceManager);
			while (true)
			{
				int num = 1446821242;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5B264EA7u) % 9u)
					{
					case 7u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -1880822568;
							num4 = -1880822568;
						}
						else
						{
							num3 = -1651527077;
							num4 = -1651527077;
						}
						num = num3 ^ ((int)num2 * -246087848);
						continue;
					}
					case 6u:
						num = (int)(num2 * 1462147508) ^ -2075143970;
						continue;
					case 5u:
						resourceManager = Veet.smethod_2("Cytotechnologist.Veet", Veet.smethod_1(Veet.smethod_0(typeof(Veet).TypeHandle)));
						num = (int)((num2 * 163871040) ^ 0x2A7BC807);
						continue;
					case 4u:
						result = resourceMan;
						num = 1775043628;
						continue;
					case 3u:
						num = (int)(num2 * 169441605) ^ -166111265;
						continue;
					case 2u:
						flag = resourceMan == null;
						num = ((int)num2 * -1487800262) ^ 0x500FC3A5;
						continue;
					case 1u:
						resourceMan = resourceManager;
						num = (int)((num2 * 267162681) ^ 0xD75895C);
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
			CultureInfo result = default(CultureInfo);
			while (true)
			{
				int num = 1919370776;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x52446A45u) % 4u)
					{
					case 1u:
						result = resourceCulture;
						num = ((int)num2 * -1141093142) ^ 0x4ED44E43;
						continue;
					case 0u:
						num = (int)((num2 * 1521989034) ^ 0x792ABF2B);
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
		set
		{
			resourceCulture = value;
		}
	}

	internal static string Sa
	{
		get
		{
			string result = Veet.smethod_3(ResourceManager, "Sa", resourceCulture);
			while (true)
			{
				int num = -329661378;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBB9B94E2u) % 3u)
					{
					case 2u:
						goto IL_0017;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0017:
					num = ((int)num2 * -315363036) ^ -1460783543;
				}
			}
		}
	}

	internal static string Xe
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = -1742127269;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEB60A10Du) % 4u)
					{
					case 2u:
						result = Veet.smethod_3(ResourceManager, "Xe", resourceCulture);
						num = (int)(num2 * 1258446315) ^ -1378888422;
						continue;
					case 1u:
						num = ((int)num2 * -1169598387) ^ -649322196;
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

	internal static string Zr
	{
		get
		{
			string result = Veet.smethod_3(ResourceManager, "Zr", resourceCulture);
			while (true)
			{
				int num = 208826535;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7CC88798u) % 3u)
					{
					case 2u:
						goto IL_0017;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0017:
					num = ((int)num2 * -149038108) ^ 0x703641A;
				}
			}
		}
	}

	internal Veet()
	{
		while (true)
		{
			int num = -1830586796;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE1910CB6u) % 3u)
				{
				case 1u:
					goto IL_0008;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0008:
				num = ((int)num2 * -834734516) ^ 0x6C699CED;
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
