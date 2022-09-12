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
				int num = 1380735652;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x676D7005u) % 9u)
					{
					case 7u:
						result = resourceMan;
						num = 1558468341;
						continue;
					case 6u:
						num = ((int)num2 * -1688317687) ^ 0x42432249;
						continue;
					case 5u:
						num = ((int)num2 * -1565019034) ^ 0x59EA2A7A;
						continue;
					case 4u:
						num = ((int)num2 * -2145022538) ^ 0x6CAFD5DE;
						continue;
					case 3u:
						resourceMan = resourceManager;
						num = ((int)num2 * -1866423608) ^ -529696684;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 80004326;
							num4 = 80004326;
						}
						else
						{
							num3 = 693765598;
							num4 = 693765598;
						}
						num = num3 ^ ((int)num2 * -1563336930);
						continue;
					}
					case 0u:
						resourceManager = Veet.smethod_2("Cytotechnologist.Veet", Veet.smethod_1(Veet.smethod_0(typeof(Veet).TypeHandle)));
						num = (int)((num2 * 481511742) ^ 0x1F8F3940);
						continue;
					case 8u:
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
				int num = 1364540295;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x78BAAC07u) % 3u)
					{
					case 1u:
						goto IL_0003;
					default:
						return;
					case 2u:
						break;
					case 0u:
						return;
					}
					break;
					IL_0003:
					resourceCulture = value;
					num = (int)((num2 * 1249618464) ^ 0x5D7B9B05);
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
				int num = 670888121;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4BA0FFD7u) % 4u)
					{
					case 3u:
						num = (int)(num2 * 1074847560) ^ -2120965686;
						continue;
					case 2u:
						result = Veet.smethod_3(ResourceManager, "Sa", resourceCulture);
						num = (int)((num2 * 1415242437) ^ 0x7E60B2CE);
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
			string result = default(string);
			while (true)
			{
				int num = 1741698750;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x56855304u) % 4u)
					{
					case 2u:
						result = Veet.smethod_3(ResourceManager, "Xe", resourceCulture);
						num = ((int)num2 * -1674716131) ^ 0x6D139503;
						continue;
					case 1u:
						num = ((int)num2 * -1259530001) ^ 0x7CD23C0;
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
				int num = 1655284861;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x31337B47u) % 4u)
					{
					case 2u:
						result = Veet.smethod_3(ResourceManager, "Zr", resourceCulture);
						num = (int)((num2 * 279306354) ^ 0x7A4019CA);
						continue;
					case 1u:
						num = ((int)num2 * -870066259) ^ -406472235;
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
		while (true)
		{
			int num = -2109236056;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9D49D4C5u) % 3u)
				{
				case 1u:
					goto IL_0008;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0008:
				num = (int)((num2 * 1625309556) ^ 0x23680BAD);
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
