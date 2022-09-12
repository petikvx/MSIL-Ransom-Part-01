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
				int num = 1422203040;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6BB71719u) % 6u)
					{
					case 5u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -1419997606;
							num4 = -1419997606;
						}
						else
						{
							num3 = -674736877;
							num4 = -674736877;
						}
						num = num3 ^ (int)(num2 * 11629100);
						continue;
					}
					case 3u:
						resourceMan = resourceManager;
						num = (int)((num2 * 291708222) ^ 0x6F830A8C);
						continue;
					case 2u:
						resourceManager = Veet.smethod_2("Cytotechnologist.Veet", Veet.smethod_1(Veet.smethod_0(typeof(Veet).TypeHandle)));
						num = ((int)num2 * -854865594) ^ 0x6F37F46E;
						continue;
					case 1u:
						result = resourceMan;
						num = 740377951;
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
			CultureInfo result = resourceCulture;
			while (true)
			{
				int num = 1649090258;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x68032209u) % 3u)
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
					num = ((int)num2 * -392043925) ^ -1363765415;
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
				int num = -296534528;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9ED65CE9u) % 4u)
					{
					case 1u:
						result = Veet.smethod_3(ResourceManager, "Sa", resourceCulture);
						num = ((int)num2 * -745396990) ^ 0xA0EEC23;
						continue;
					case 0u:
						num = (int)((num2 * 1110944038) ^ 0x4BE5B5F6);
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
			string result = default(string);
			while (true)
			{
				int num = 1378260201;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1A97AB66u) % 4u)
					{
					case 3u:
						result = Veet.smethod_3(ResourceManager, "Xe", resourceCulture);
						num = ((int)num2 * -1474145358) ^ 0x5DAB2A4C;
						continue;
					case 0u:
						num = (int)(num2 * 1380969245) ^ -1096337937;
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
				int num = 1531942180;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x429C0C4Fu) % 3u)
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
					num = (int)((num2 * 1763558560) ^ 0x77DC6C69);
				}
			}
		}
	}

	internal Veet()
	{
		while (true)
		{
			int num = -1506134301;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDDB7716Au) % 4u)
				{
				case 2u:
					num = ((int)num2 * -2056566729) ^ 0x735CDB70;
					continue;
				case 1u:
					num = (int)(num2 * 1324872755) ^ -356277137;
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
