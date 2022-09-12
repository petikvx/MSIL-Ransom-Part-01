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
				int num = 652387095;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x49CD8EA7u) % 7u)
					{
					case 4u:
						num = ((int)num2 * -1553163193) ^ -739189044;
						continue;
					case 3u:
					{
						ResourceManager resourceManager = (resourceMan = Veet.smethod_2("Cytotechnologist.Veet", Veet.smethod_1(Veet.smethod_0(typeof(Veet).TypeHandle))));
						num = (int)((num2 * 859025367) ^ 0x47496DD);
						continue;
					}
					case 2u:
						result = resourceMan;
						num = 1466425123;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -1754365913;
							num4 = -1754365913;
						}
						else
						{
							num3 = -460031104;
							num4 = -460031104;
						}
						num = num3 ^ ((int)num2 * -1819697024);
						continue;
					}
					case 0u:
						num = (int)(num2 * 323218930) ^ -763565846;
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
				int num = 1179810222;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5FC64F5Eu) % 3u)
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
					result = Veet.smethod_3(ResourceManager, "Sa", resourceCulture);
					num = (int)((num2 * 410280912) ^ 0x735A9B91);
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
				int num = 1628000106;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5B189764u) % 3u)
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
					result = Veet.smethod_3(ResourceManager, "Zr", resourceCulture);
					num = (int)((num2 * 463064872) ^ 0x404006E0);
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
