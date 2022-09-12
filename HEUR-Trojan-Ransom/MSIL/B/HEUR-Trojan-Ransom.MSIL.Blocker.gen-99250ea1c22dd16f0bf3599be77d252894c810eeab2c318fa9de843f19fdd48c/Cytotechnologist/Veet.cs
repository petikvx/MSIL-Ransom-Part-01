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
				int num = -136589273;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFBE646B9u) % 7u)
					{
					case 6u:
						num = ((int)num2 * -1266939853) ^ -526921560;
						continue;
					case 5u:
						resourceManager = Veet.smethod_2("Cytotechnologist.Veet", Veet.smethod_1(Veet.smethod_0(typeof(Veet).TypeHandle)));
						num = (int)(num2 * 173424389) ^ -1113726861;
						continue;
					case 4u:
						resourceMan = resourceManager;
						num = (int)((num2 * 1354197874) ^ 0x5A3D7189);
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (resourceMan == null)
						{
							num3 = -679212770;
							num4 = -679212770;
						}
						else
						{
							num3 = -1883836362;
							num4 = -1883836362;
						}
						num = num3 ^ (int)(num2 * 1825517492);
						continue;
					}
					case 2u:
						result = resourceMan;
						num = -1871253726;
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
			CultureInfo result = default(CultureInfo);
			while (true)
			{
				int num = -159748656;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9A5FE4C2u) % 4u)
					{
					case 2u:
						result = resourceCulture;
						num = ((int)num2 * -564526168) ^ -1349186345;
						continue;
					case 1u:
						num = (int)(num2 * 1461814441) ^ -1312540040;
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

	internal static string Sa => Veet.smethod_3(ResourceManager, "Sa", resourceCulture);

	internal static string Xe
	{
		get
		{
			string result = Veet.smethod_3(ResourceManager, "Xe", resourceCulture);
			while (true)
			{
				int num = 2002192491;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2C8430BDu) % 3u)
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
					num = ((int)num2 * -365933033) ^ -1888078168;
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
				int num = 727227350;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4344A8Cu) % 3u)
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
					result = Veet.smethod_3(ResourceManager, "Zr", resourceCulture);
					num = ((int)num2 * -404617467) ^ -167527459;
				}
			}
		}
	}

	internal Veet()
	{
		while (true)
		{
			int num = -2064636062;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD33A4810u) % 3u)
				{
				case 1u:
					goto IL_0008;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0008:
				num = (int)(num2 * 1070155070) ^ -6969614;
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
