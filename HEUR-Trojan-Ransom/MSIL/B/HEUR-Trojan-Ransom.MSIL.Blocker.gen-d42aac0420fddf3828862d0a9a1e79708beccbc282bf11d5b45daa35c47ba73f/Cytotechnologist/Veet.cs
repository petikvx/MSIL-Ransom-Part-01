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
			bool flag = default(bool);
			ResourceManager result = default(ResourceManager);
			while (true)
			{
				int num = -1847546718;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEE733869u) % 9u)
					{
					case 8u:
						num = ((int)num2 * -25535968) ^ -1063624660;
						continue;
					case 7u:
						flag = resourceMan == null;
						num = (int)((num2 * 2056940655) ^ 0xD6C0202);
						continue;
					case 4u:
					{
						ResourceManager resourceManager = (resourceMan = Veet.smethod_2("Cytotechnologist.Veet", Veet.smethod_1(Veet.smethod_0(typeof(Veet).TypeHandle))));
						num = ((int)num2 * -1894082899) ^ -893044375;
						continue;
					}
					case 3u:
						num = (int)(num2 * 1266517832) ^ -984430129;
						continue;
					case 2u:
						num = (int)(num2 * 763775993) ^ -1706140666;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -1520190794;
							num4 = -1520190794;
						}
						else
						{
							num3 = -188251513;
							num4 = -188251513;
						}
						num = num3 ^ ((int)num2 * -522017621);
						continue;
					}
					case 0u:
						result = resourceMan;
						num = -1159036212;
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
			CultureInfo result = resourceCulture;
			while (true)
			{
				int num = 988207911;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5A1997CFu) % 3u)
					{
					case 2u:
						goto IL_0008;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0008:
					num = ((int)num2 * -1916601212) ^ 0x4F857427;
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
			string result = default(string);
			while (true)
			{
				int num = -759715999;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBE92C56Au) % 3u)
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
					num = (int)((num2 * 1902630853) ^ 0x6A71CF8F);
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
				int num = 1452137735;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3AAB5B3Au) % 4u)
					{
					case 1u:
						result = Veet.smethod_3(ResourceManager, "Zr", resourceCulture);
						num = ((int)num2 * -485062423) ^ -1293577793;
						continue;
					case 0u:
						num = (int)(num2 * 1290191438) ^ -14057500;
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
