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
			while (true)
			{
				int num = -1254464691;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8D8707EFu) % 8u)
					{
					case 7u:
						num = (int)(num2 * 2037057249) ^ -967159328;
						continue;
					case 5u:
						num = ((int)num2 * -754479184) ^ 0x1B127F1;
						continue;
					case 4u:
					{
						ResourceManager resourceManager = (resourceMan = Veet.smethod_2("Cytotechnologist.Veet", Veet.smethod_1(Veet.smethod_0(typeof(Veet).TypeHandle))));
						num = (int)(num2 * 297012121) ^ -439016876;
						continue;
					}
					case 2u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -62122555;
							num4 = -62122555;
						}
						else
						{
							num3 = -1268486444;
							num4 = -1268486444;
						}
						num = num3 ^ (int)(num2 * 227785697);
						continue;
					}
					case 1u:
						num = ((int)num2 * -651686027) ^ 0x466E00BE;
						continue;
					case 0u:
						result = resourceMan;
						num = -375921574;
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			CultureInfo result = resourceCulture;
			while (true)
			{
				int num = -126616229;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF3CB1F97u) % 3u)
					{
					case 1u:
						goto IL_0008;
					case 2u:
						break;
					default:
						return result;
					}
					break;
					IL_0008:
					num = ((int)num2 * -1365042613) ^ -20632018;
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
				int num = -844228132;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD175C557u) % 4u)
					{
					case 3u:
						result = Veet.smethod_3(ResourceManager, "Sa", resourceCulture);
						num = (int)((num2 * 1119514236) ^ 0x3D1501E);
						continue;
					case 1u:
						num = (int)((num2 * 886656801) ^ 0x154F9100);
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
				int num = -2089116904;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEF5FA2F5u) % 3u)
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
					result = Veet.smethod_3(ResourceManager, "Xe", resourceCulture);
					num = ((int)num2 * -74100184) ^ 0x6BBFDB91;
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
				int num = -196179979;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE00C810Eu) % 4u)
					{
					case 3u:
						result = Veet.smethod_3(ResourceManager, "Zr", resourceCulture);
						num = ((int)num2 * -885584145) ^ -493076417;
						continue;
					case 0u:
						num = ((int)num2 * -365333259) ^ -130186721;
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
			int num = 1003368890;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x69E4AA98u) % 4u)
				{
				case 2u:
					num = ((int)num2 * -1808507043) ^ -1139955417;
					continue;
				case 1u:
					num = ((int)num2 * -1794489762) ^ 0x31771F8A;
					continue;
				default:
					return;
				case 3u:
					break;
				case 0u:
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
