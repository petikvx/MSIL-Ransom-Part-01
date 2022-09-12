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
			ResourceManager result = default(ResourceManager);
			while (true)
			{
				int num = -1588683495;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF91D56E1u) % 9u)
					{
					case 8u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 881679366;
							num4 = 881679366;
						}
						else
						{
							num3 = 1262738677;
							num4 = 1262738677;
						}
						num = num3 ^ ((int)num2 * -1433146580);
						continue;
					}
					case 7u:
						result = resourceMan;
						num = -912068319;
						continue;
					case 5u:
						num = (int)((num2 * 1075845420) ^ 0x642DCAAE);
						continue;
					case 4u:
						num = ((int)num2 * -1081282648) ^ 0x280CC6CE;
						continue;
					case 3u:
					{
						ResourceManager resourceManager = (resourceMan = Veet.smethod_2("Cytotechnologist.Veet", Veet.smethod_1(Veet.smethod_0(typeof(Veet).TypeHandle))));
						num = ((int)num2 * -196633672) ^ -413747203;
						continue;
					}
					case 2u:
						num = (int)((num2 * 1805518978) ^ 0x68AB3182);
						continue;
					case 1u:
						flag = resourceMan == null;
						num = (int)(num2 * 1641194407) ^ -1613454360;
						continue;
					case 6u:
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
				int num = -645144601;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA79C7129u) % 3u)
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
					num = (int)((num2 * 509620175) ^ 0x3627A804);
				}
			}
		}
	}

	internal static string Sa
	{
		get
		{
			string result = Veet.smethod_3(ResourceManager, "Sa", resourceCulture);
			while (true)
			{
				int num = 938498610;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6C76D55Eu) % 3u)
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
					num = (int)((num2 * 285059418) ^ 0x277E9FA9);
				}
			}
		}
	}

	internal static string Xe => Veet.smethod_3(ResourceManager, "Xe", resourceCulture);

	internal static string Zr
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = 1675604660;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7A45F002u) % 3u)
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
					result = Veet.smethod_3(ResourceManager, "Zr", resourceCulture);
					num = ((int)num2 * -1670890154) ^ 0x2972C9AA;
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
