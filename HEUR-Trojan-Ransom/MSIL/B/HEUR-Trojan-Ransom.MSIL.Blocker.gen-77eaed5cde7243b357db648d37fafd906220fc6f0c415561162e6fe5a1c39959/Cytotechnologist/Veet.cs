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
				int num = -1859694114;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFE3EA2BFu) % 8u)
					{
					case 7u:
						num = ((int)num2 * -609336347) ^ 0x7799468E;
						continue;
					case 5u:
						num = (int)(num2 * 2125018803) ^ -1679445277;
						continue;
					case 4u:
						resourceManager = Veet.smethod_2("Cytotechnologist.Veet", Veet.smethod_1(Veet.smethod_0(typeof(Veet).TypeHandle)));
						num = (int)(num2 * 1422324277) ^ -165707029;
						continue;
					case 3u:
						result = resourceMan;
						num = -26713312;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -707222386;
							num4 = -707222386;
						}
						else
						{
							num3 = -2078184463;
							num4 = -2078184463;
						}
						num = num3 ^ (int)(num2 * 1153111210);
						continue;
					}
					case 0u:
						resourceMan = resourceManager;
						num = ((int)num2 * -18606904) ^ 0x485CCE2;
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
				int num = -2044911334;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC1AA2263u) % 4u)
					{
					case 2u:
						num = (int)((num2 * 652516826) ^ 0x692C45E0);
						continue;
					case 1u:
						result = resourceCulture;
						num = ((int)num2 * -1503460166) ^ 0x309CD653;
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
			string result = Veet.smethod_3(ResourceManager, "Sa", resourceCulture);
			while (true)
			{
				int num = 1817968444;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x57FF5108u) % 3u)
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
					num = ((int)num2 * -369966713) ^ -332857426;
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
				int num = -727508642;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF720469Bu) % 4u)
					{
					case 1u:
						result = Veet.smethod_3(ResourceManager, "Xe", resourceCulture);
						num = (int)((num2 * 1231683214) ^ 0x49043239);
						continue;
					case 0u:
						num = ((int)num2 * -1550054693) ^ -742445496;
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
			string result = default(string);
			while (true)
			{
				int num = 2145903268;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6E4E0B5Du) % 4u)
					{
					case 1u:
						result = Veet.smethod_3(ResourceManager, "Zr", resourceCulture);
						num = (int)(num2 * 313932104) ^ -1751288287;
						continue;
					case 0u:
						num = (int)(num2 * 1012305567) ^ -573379502;
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
			int num = -299267888;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD9928325u) % 4u)
				{
				case 1u:
					num = ((int)num2 * -194710166) ^ -504835237;
					continue;
				case 0u:
					num = ((int)num2 * -1536063665) ^ -107239970;
					continue;
				default:
					return;
				case 2u:
					break;
				case 3u:
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
