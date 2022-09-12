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
				int num = 1345915856;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x742B5FB1u) % 7u)
					{
					case 6u:
						result = resourceMan;
						num = 1089014998;
						continue;
					case 4u:
						num = ((int)num2 * -723983012) ^ -885687779;
						continue;
					case 2u:
					{
						ResourceManager resourceManager = (resourceMan = Veet.smethod_2("Cytotechnologist.Veet", Veet.smethod_1(Veet.smethod_0(typeof(Veet).TypeHandle))));
						num = ((int)num2 * -735323988) ^ -1902097748;
						continue;
					}
					case 1u:
					{
						int num3;
						int num4;
						if (resourceMan != null)
						{
							num3 = 806751568;
							num4 = 806751568;
						}
						else
						{
							num3 = 1168659283;
							num4 = 1168659283;
						}
						num = num3 ^ ((int)num2 * -2071306420);
						continue;
					}
					case 0u:
						num = (int)(num2 * 2082370158) ^ -2024110015;
						continue;
					case 5u:
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
				int num = -2122325388;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8E845418u) % 3u)
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
					num = (int)(num2 * 465764223) ^ -1463104810;
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
				int num = 785603803;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x35F8600Bu) % 3u)
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
					num = (int)((num2 * 1844285118) ^ 0x63F1A670);
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
				int num = -1348671224;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDAC21467u) % 4u)
					{
					case 3u:
						result = Veet.smethod_3(ResourceManager, "Xe", resourceCulture);
						num = ((int)num2 * -891129868) ^ -1809339546;
						continue;
					case 1u:
						num = (int)(num2 * 806573741) ^ -1503139732;
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
			string result = Veet.smethod_3(ResourceManager, "Zr", resourceCulture);
			while (true)
			{
				int num = -851931088;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB4C1A540u) % 3u)
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
					num = ((int)num2 * -2069225631) ^ 0x652E2CB6;
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
