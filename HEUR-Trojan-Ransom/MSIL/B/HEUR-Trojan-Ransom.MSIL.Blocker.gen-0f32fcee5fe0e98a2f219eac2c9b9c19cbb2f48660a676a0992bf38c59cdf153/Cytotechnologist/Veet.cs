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
				int num = 796553237;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x128E2F40u) % 6u)
					{
					case 5u:
					{
						int num3;
						int num4;
						if (resourceMan != null)
						{
							num3 = -489074042;
							num4 = -489074042;
						}
						else
						{
							num3 = -1093918415;
							num4 = -1093918415;
						}
						num = num3 ^ ((int)num2 * -1052547856);
						continue;
					}
					case 3u:
						num = ((int)num2 * -926575014) ^ -1899185039;
						continue;
					case 1u:
					{
						ResourceManager resourceManager = (resourceMan = Veet.smethod_2("Cytotechnologist.Veet", Veet.smethod_1(Veet.smethod_0(typeof(Veet).TypeHandle))));
						num = (int)(num2 * 674395133) ^ -1762922487;
						continue;
					}
					case 0u:
						result = resourceMan;
						num = 888831650;
						continue;
					case 4u:
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
				int num = 831247648;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6DCD3C13u) % 4u)
					{
					case 3u:
						result = Veet.smethod_3(ResourceManager, "Sa", resourceCulture);
						num = ((int)num2 * -331992054) ^ 0x713F7B04;
						continue;
					case 1u:
						num = ((int)num2 * -1835486438) ^ 0x2AA18A5B;
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
				int num = -77359119;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDD92F0F6u) % 4u)
					{
					case 3u:
						result = Veet.smethod_3(ResourceManager, "Xe", resourceCulture);
						num = ((int)num2 * -106275666) ^ -1106210020;
						continue;
					case 0u:
						num = (int)((num2 * 136551274) ^ 0x2DFCE07);
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
				int num = -1940606232;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8854E640u) % 3u)
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
					num = ((int)num2 * -1639905961) ^ 0x2F0DE11;
				}
			}
		}
	}

	internal Veet()
	{
		while (true)
		{
			int num = 1078984772;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3E181159u) % 3u)
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
				num = (int)(num2 * 155026909) ^ -1640161839;
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
