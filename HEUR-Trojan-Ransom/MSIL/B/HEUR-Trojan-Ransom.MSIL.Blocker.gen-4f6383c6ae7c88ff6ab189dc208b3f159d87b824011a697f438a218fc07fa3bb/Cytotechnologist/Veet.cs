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
			ResourceManager result = default(ResourceManager);
			while (true)
			{
				int num = 799857515;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5A1461BAu) % 7u)
					{
					case 5u:
					{
						ResourceManager resourceManager = (resourceMan = Veet.smethod_2("Cytotechnologist.Veet", Veet.smethod_1(Veet.smethod_0(typeof(Veet).TypeHandle))));
						num = ((int)num2 * -1426650037) ^ -1467702353;
						continue;
					}
					case 4u:
						result = resourceMan;
						num = 860529377;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -1988009673;
							num4 = -1988009673;
						}
						else
						{
							num3 = -2118710999;
							num4 = -2118710999;
						}
						num = num3 ^ ((int)num2 * -1752266159);
						continue;
					}
					case 2u:
						num = ((int)num2 * -1045947049) ^ 0x7E3BE219;
						continue;
					case 1u:
						num = (int)(num2 * 1878101699) ^ -677547221;
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
				int num = -192248470;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEFA2C22Fu) % 4u)
					{
					case 3u:
						num = ((int)num2 * -38838654) ^ -138103723;
						continue;
					case 1u:
						result = Veet.smethod_3(ResourceManager, "Sa", resourceCulture);
						num = ((int)num2 * -480690589) ^ -1849840137;
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
				int num = 752267887;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2C3D9473u) % 3u)
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
					result = Veet.smethod_3(ResourceManager, "Xe", resourceCulture);
					num = ((int)num2 * -1021773525) ^ -682908925;
				}
			}
		}
	}

	internal static string Zr => Veet.smethod_3(ResourceManager, "Zr", resourceCulture);

	internal Veet()
	{
		while (true)
		{
			int num = 1015684807;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5AE9B980u) % 3u)
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
				num = ((int)num2 * -113659510) ^ 0x1BF1E597;
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
