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
				goto IL_000a;
			}
			goto IL_0072;
			IL_0072:
			ResourceManager result = resourceMan;
			int num = 469675231;
			goto IL_004d;
			IL_004d:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7D9B66EEu) % 5u)
				{
				case 2u:
					break;
				case 1u:
				{
					ResourceManager resourceManager = (resourceMan = Veet.smethod_2("Cytotechnologist.Veet", Veet.smethod_1(Veet.smethod_0(typeof(Veet).TypeHandle))));
					num = (int)(num2 * 1709028775) ^ -1289509925;
					continue;
				}
				case 0u:
					num = (int)((num2 * 986458088) ^ 0x6362B17E);
					continue;
				case 3u:
					goto IL_0072;
				default:
					return result;
				}
				break;
			}
			goto IL_000a;
			IL_000a:
			num = 925129887;
			goto IL_004d;
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
				int num = -708431925;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB9991FE4u) % 3u)
					{
					case 1u:
						goto IL_0008;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0008:
					num = (int)((num2 * 2013234683) ^ 0x6F364AFE);
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
				int num = -518010265;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC2FF9D6Du) % 4u)
					{
					case 2u:
						result = Veet.smethod_3(ResourceManager, "Sa", resourceCulture);
						num = ((int)num2 * -875679139) ^ 0x591D959E;
						continue;
					case 1u:
						num = ((int)num2 * -1699639689) ^ 0x68E11222;
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

	internal static string Xe => Veet.smethod_3(ResourceManager, "Xe", resourceCulture);

	internal static string Zr
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = 1441858150;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x343AA40Fu) % 4u)
					{
					case 1u:
						result = Veet.smethod_3(ResourceManager, "Zr", resourceCulture);
						num = (int)((num2 * 263313723) ^ 0x71D541B0);
						continue;
					case 0u:
						num = ((int)num2 * -1306343220) ^ 0x5867090;
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

	internal Veet()
	{
		while (true)
		{
			int num = -1675057408;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA1289C92u) % 4u)
				{
				case 2u:
					num = (int)((num2 * 7624086) ^ 0x243FB3F);
					continue;
				case 1u:
					num = (int)((num2 * 932341509) ^ 0x1ED77223);
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
