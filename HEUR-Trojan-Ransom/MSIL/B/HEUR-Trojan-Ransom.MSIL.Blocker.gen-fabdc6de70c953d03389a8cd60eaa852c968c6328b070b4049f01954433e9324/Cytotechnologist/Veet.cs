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
				int num = 698512683;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x74743A81u) % 7u)
					{
					case 6u:
					{
						int num3;
						int num4;
						if (resourceMan == null)
						{
							num3 = -1074752950;
							num4 = -1074752950;
						}
						else
						{
							num3 = -1649314386;
							num4 = -1649314386;
						}
						num = num3 ^ (int)(num2 * 1990626876);
						continue;
					}
					case 4u:
					{
						ResourceManager resourceManager = (resourceMan = Veet.smethod_2("Cytotechnologist.Veet", Veet.smethod_1(Veet.smethod_0(typeof(Veet).TypeHandle))));
						num = ((int)num2 * -1807262382) ^ 0x27D4E056;
						continue;
					}
					case 2u:
						result = resourceMan;
						num = 1218767748;
						continue;
					case 1u:
						num = ((int)num2 * -106106234) ^ -726950008;
						continue;
					case 0u:
						num = (int)(num2 * 1272738273) ^ -1510819369;
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
				int num = -1712291452;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x844AFB11u) % 4u)
					{
					case 1u:
						result = resourceCulture;
						num = ((int)num2 * -1411442642) ^ -2025748825;
						continue;
					case 0u:
						num = (int)((num2 * 1412371691) ^ 0x4A5D3ADE);
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
				int num = -2054919656;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE23E8925u) % 3u)
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
					num = ((int)num2 * -564605930) ^ 0x41EF7356;
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
				int num = -1228934773;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAD9E50D6u) % 4u)
					{
					case 3u:
						num = (int)((num2 * 1575932505) ^ 0x33F21C01);
						continue;
					case 1u:
						result = Veet.smethod_3(ResourceManager, "Xe", resourceCulture);
						num = (int)(num2 * 250467376) ^ -1287180967;
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

	internal static string Zr => Veet.smethod_3(ResourceManager, "Zr", resourceCulture);

	internal Veet()
	{
		while (true)
		{
			int num = -1511004640;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDBDD5DD1u) % 3u)
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
				num = ((int)num2 * -748743764) ^ 0x5C69CC27;
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
