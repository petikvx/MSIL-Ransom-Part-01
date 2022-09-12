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
				int num = -759066958;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE360125Bu) % 7u)
					{
					case 6u:
						result = resourceMan;
						num = -1949120686;
						continue;
					case 5u:
						num = ((int)num2 * -1229622039) ^ -1997325837;
						continue;
					case 4u:
					{
						ResourceManager resourceManager = (resourceMan = Veet.smethod_2("Cytotechnologist.Veet", Veet.smethod_1(Veet.smethod_0(typeof(Veet).TypeHandle))));
						num = ((int)num2 * -1517261047) ^ -671584710;
						continue;
					}
					case 3u:
					{
						int num3;
						int num4;
						if (resourceMan != null)
						{
							num3 = 1823111806;
							num4 = 1823111806;
						}
						else
						{
							num3 = 310698216;
							num4 = 310698216;
						}
						num = num3 ^ (int)(num2 * 1676836862);
						continue;
					}
					case 1u:
						num = (int)((num2 * 1128976676) ^ 0x6ED1B840);
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			CultureInfo result = default(CultureInfo);
			while (true)
			{
				int num = 1763726166;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x45830BD9u) % 4u)
					{
					case 3u:
						result = resourceCulture;
						num = ((int)num2 * -615198378) ^ -158995875;
						continue;
					case 2u:
						num = ((int)num2 * -979183163) ^ -708336210;
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
				int num = 449332531;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x40D8E7D2u) % 3u)
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
					num = (int)(num2 * 877575956) ^ -1048364353;
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
				int num = -330778689;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA3BC2298u) % 3u)
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
					num = ((int)num2 * -588525480) ^ 0x1B94F56C;
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
				int num = 225945949;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4FFA9C30u) % 4u)
					{
					case 3u:
						num = (int)(num2 * 626601229) ^ -194461947;
						continue;
					case 1u:
						result = Veet.smethod_3(ResourceManager, "Zr", resourceCulture);
						num = (int)((num2 * 725992631) ^ 0x18C9BEA8);
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
