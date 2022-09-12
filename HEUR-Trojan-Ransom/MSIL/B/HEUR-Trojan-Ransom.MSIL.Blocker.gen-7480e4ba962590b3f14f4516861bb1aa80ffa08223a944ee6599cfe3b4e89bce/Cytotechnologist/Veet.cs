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
			bool flag = default(bool);
			while (true)
			{
				int num = -1464028828;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD1FDBD20u) % 6u)
					{
					case 5u:
					{
						ResourceManager resourceManager = (resourceMan = Veet.smethod_2("Cytotechnologist.Veet", Veet.smethod_1(Veet.smethod_0(typeof(Veet).TypeHandle))));
						num = ((int)num2 * -181810987) ^ -1701688171;
						continue;
					}
					case 4u:
						result = resourceMan;
						num = -438750201;
						continue;
					case 2u:
						flag = resourceMan == null;
						num = (int)(num2 * 1979230138) ^ -705781403;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 1581082255;
							num4 = 1581082255;
						}
						else
						{
							num3 = 352265062;
							num4 = 352265062;
						}
						num = num3 ^ ((int)num2 * -1180748886);
						continue;
					}
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
				int num = -1500856022;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF25F27F0u) % 3u)
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
					num = (int)((num2 * 1825424895) ^ 0x1F0E141C);
				}
			}
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static string Sa => Veet.smethod_3(ResourceManager, "Sa", resourceCulture);

	internal static string Xe
	{
		get
		{
			string result = Veet.smethod_3(ResourceManager, "Xe", resourceCulture);
			while (true)
			{
				int num = -1289863418;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF779ADEFu) % 3u)
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
					num = (int)(num2 * 1768821585) ^ -1226970280;
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
				int num = -372342712;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC6ED6E62u) % 4u)
					{
					case 2u:
						result = Veet.smethod_3(ResourceManager, "Zr", resourceCulture);
						num = ((int)num2 * -1897888226) ^ -944917809;
						continue;
					case 1u:
						num = (int)(num2 * 910972662) ^ -1491128745;
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
