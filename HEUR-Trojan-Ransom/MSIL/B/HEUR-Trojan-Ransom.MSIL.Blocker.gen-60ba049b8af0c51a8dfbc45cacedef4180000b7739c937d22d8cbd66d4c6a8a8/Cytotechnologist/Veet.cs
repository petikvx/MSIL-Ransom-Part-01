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
				int num = 1399690543;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5ECF8139u) % 7u)
					{
					case 6u:
						num = ((int)num2 * -900446065) ^ -1588614846;
						continue;
					case 5u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -262614485;
							num4 = -262614485;
						}
						else
						{
							num3 = -603408456;
							num4 = -603408456;
						}
						num = num3 ^ (int)(num2 * 1856451402);
						continue;
					}
					case 4u:
					{
						ResourceManager resourceManager = (resourceMan = Veet.smethod_2("Cytotechnologist.Veet", Veet.smethod_1(Veet.smethod_0(typeof(Veet).TypeHandle))));
						num = (int)(num2 * 105984258) ^ -1027417001;
						continue;
					}
					case 1u:
						result = resourceMan;
						num = 1348594951;
						continue;
					case 0u:
						num = ((int)num2 * -2095027478) ^ -1240716481;
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
			CultureInfo result = default(CultureInfo);
			while (true)
			{
				int num = -453912937;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9A5A393Au) % 4u)
					{
					case 1u:
						result = resourceCulture;
						num = ((int)num2 * -570904862) ^ -1902400784;
						continue;
					case 0u:
						num = ((int)num2 * -1809999673) ^ -1064300595;
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
		set
		{
			while (true)
			{
				int num = -2010783630;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCC7A4F24u) % 3u)
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
					num = (int)(num2 * 1301790668) ^ -600925966;
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
				int num = 794998431;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x614B0F52u) % 3u)
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
					num = ((int)num2 * -676531398) ^ 0x6D303596;
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
				int num = 226334472;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x66583133u) % 4u)
					{
					case 3u:
						result = Veet.smethod_3(ResourceManager, "Xe", resourceCulture);
						num = (int)(num2 * 1052294247) ^ -268615274;
						continue;
					case 0u:
						num = (int)(num2 * 307989270) ^ -445126486;
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

	internal static string Zr
	{
		get
		{
			string result = Veet.smethod_3(ResourceManager, "Zr", resourceCulture);
			while (true)
			{
				int num = 244233312;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3C94D20u) % 3u)
					{
					case 1u:
						goto IL_0017;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0017:
					num = (int)(num2 * 536778252) ^ -797218749;
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
