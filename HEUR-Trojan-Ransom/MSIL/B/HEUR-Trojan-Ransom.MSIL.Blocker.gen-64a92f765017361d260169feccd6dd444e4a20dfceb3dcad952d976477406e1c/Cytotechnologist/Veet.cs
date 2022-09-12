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
			bool flag = default(bool);
			while (true)
			{
				int num = 1509207629;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x19777A6Au) % 10u)
					{
					case 9u:
						result = resourceMan;
						num = 107601666;
						continue;
					case 7u:
						num = ((int)num2 * -935161779) ^ -1233685542;
						continue;
					case 6u:
						resourceMan = resourceManager;
						num = ((int)num2 * -494736753) ^ 0x61D68EA7;
						continue;
					case 5u:
						resourceManager = Veet.smethod_2("Cytotechnologist.Veet", Veet.smethod_1(Veet.smethod_0(typeof(Veet).TypeHandle)));
						num = ((int)num2 * -860662787) ^ -2043505885;
						continue;
					case 4u:
						num = (int)(num2 * 526881647) ^ -783077791;
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -1069825442;
							num4 = -1069825442;
						}
						else
						{
							num3 = -2072837747;
							num4 = -2072837747;
						}
						num = num3 ^ ((int)num2 * -65557376);
						continue;
					}
					case 1u:
						flag = resourceMan == null;
						num = (int)(num2 * 1162082335) ^ -1544671123;
						continue;
					case 0u:
						num = ((int)num2 * -696790310) ^ 0x1079AF5;
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
			CultureInfo result = default(CultureInfo);
			while (true)
			{
				int num = -1298817307;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEB85B3BBu) % 4u)
					{
					case 2u:
						result = resourceCulture;
						num = (int)((num2 * 670415430) ^ 0x22DEEB2);
						continue;
					case 1u:
						num = (int)((num2 * 500263453) ^ 0x2531E1A2);
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
			string result = default(string);
			while (true)
			{
				int num = -1744964468;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF5C75706u) % 3u)
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
					result = Veet.smethod_3(ResourceManager, "Sa", resourceCulture);
					num = (int)(num2 * 426793453) ^ -555507440;
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
				int num = -1727595345;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB5BE61E3u) % 3u)
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
					result = Veet.smethod_3(ResourceManager, "Zr", resourceCulture);
					num = ((int)num2 * -386061275) ^ 0x37B32840;
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
