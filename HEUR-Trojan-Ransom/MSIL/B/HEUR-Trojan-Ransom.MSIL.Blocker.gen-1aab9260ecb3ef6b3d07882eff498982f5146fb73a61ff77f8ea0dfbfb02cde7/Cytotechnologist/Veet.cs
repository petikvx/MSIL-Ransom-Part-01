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
			ResourceManager resourceManager = default(ResourceManager);
			ResourceManager result = default(ResourceManager);
			while (true)
			{
				int num = -794356648;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAE2FD937u) % 8u)
					{
					case 7u:
					{
						int num3;
						int num4;
						if (resourceMan == null)
						{
							num3 = 496528755;
							num4 = 496528755;
						}
						else
						{
							num3 = 1124089632;
							num4 = 1124089632;
						}
						num = num3 ^ ((int)num2 * -1837627894);
						continue;
					}
					case 5u:
						resourceMan = resourceManager;
						num = (int)(num2 * 1257918363) ^ -1701178200;
						continue;
					case 4u:
						num = (int)((num2 * 1369297898) ^ 0x67BE1CEC);
						continue;
					case 2u:
						resourceManager = Veet.smethod_2("Cytotechnologist.Veet", Veet.smethod_1(Veet.smethod_0(typeof(Veet).TypeHandle)));
						num = (int)(num2 * 871270811) ^ -1876023076;
						continue;
					case 1u:
						result = resourceMan;
						num = -1072425069;
						continue;
					case 0u:
						num = ((int)num2 * -52645140) ^ -336386954;
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
			CultureInfo result = default(CultureInfo);
			while (true)
			{
				int num = 2088896343;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x48BC910Eu) % 3u)
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
					result = resourceCulture;
					num = (int)(num2 * 1804921350) ^ -1437509925;
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
				int num = 1891450562;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7853C284u) % 4u)
					{
					case 2u:
						result = Veet.smethod_3(ResourceManager, "Sa", resourceCulture);
						num = ((int)num2 * -1010800499) ^ -2105285877;
						continue;
					case 1u:
						num = (int)((num2 * 1607438854) ^ 0x2709917D);
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
				int num = -136911818;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA84B7470u) % 4u)
					{
					case 3u:
						num = ((int)num2 * -258352273) ^ 0x1A044290;
						continue;
					case 2u:
						result = Veet.smethod_3(ResourceManager, "Xe", resourceCulture);
						num = ((int)num2 * -1856396921) ^ -476324051;
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
				int num = 101030366;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3EEFAE9u) % 3u)
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
					num = (int)(num2 * 850537749) ^ -1358893081;
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
