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
			if (resourceMan == null)
			{
				goto IL_005c;
			}
			goto IL_00b0;
			IL_00b0:
			ResourceManager result = resourceMan;
			int num = -422127680;
			goto IL_007f;
			IL_007f:
			ResourceManager resourceManager = default(ResourceManager);
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDA7EA023u) % 8u)
				{
				case 7u:
					resourceMan = resourceManager;
					num = ((int)num2 * -1495096149) ^ -214589338;
					continue;
				case 6u:
					resourceManager = Veet.smethod_2("Cytotechnologist.Veet", Veet.smethod_1(Veet.smethod_0(typeof(Veet).TypeHandle)));
					num = ((int)num2 * -618371000) ^ 0x27F6B004;
					continue;
				case 3u:
					num = ((int)num2 * -1117671404) ^ 0x4DA5FDA2;
					continue;
				case 2u:
					break;
				case 1u:
					num = ((int)num2 * -1502751361) ^ -1313323310;
					continue;
				case 0u:
					num = ((int)num2 * -340527466) ^ 0x3037BC07;
					continue;
				case 4u:
					goto IL_00b0;
				default:
					return result;
				}
				break;
			}
			goto IL_005c;
			IL_005c:
			num = -1545524958;
			goto IL_007f;
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
				int num = 711685295;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4297A55Cu) % 3u)
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
					num = ((int)num2 * -2091739727) ^ 0x3852BA8;
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
				int num = -372807375;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBBBFA1DFu) % 3u)
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
					num = (int)(num2 * 857703897) ^ -1968996038;
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
				int num = 1911087251;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE28F4CAu) % 3u)
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
					result = Veet.smethod_3(ResourceManager, "Xe", resourceCulture);
					num = (int)(num2 * 948984591) ^ -994816911;
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
				int num = -336046757;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB9286D0Fu) % 3u)
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
					num = ((int)num2 * -1612428102) ^ -503757779;
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
