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
			ResourceManager resourceManager = default(ResourceManager);
			while (true)
			{
				int num = 188444638;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x22BC9C05u) % 9u)
					{
					case 8u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -2071552156;
							num4 = -2071552156;
						}
						else
						{
							num3 = -41888912;
							num4 = -41888912;
						}
						num = num3 ^ (int)(num2 * 357859586);
						continue;
					}
					case 7u:
						num = ((int)num2 * -1038986084) ^ -402814903;
						continue;
					case 6u:
						num = (int)((num2 * 718372617) ^ 0x11F0D45D);
						continue;
					case 5u:
						result = resourceMan;
						num = 762453796;
						continue;
					case 3u:
						resourceMan = resourceManager;
						num = ((int)num2 * -44717313) ^ -859933249;
						continue;
					case 2u:
						num = ((int)num2 * -1974844091) ^ 0x1C1E3BF;
						continue;
					case 1u:
						resourceManager = Veet.smethod_2("Cytotechnologist.Veet", Veet.smethod_1(Veet.smethod_0(typeof(Veet).TypeHandle)));
						num = ((int)num2 * -1348714873) ^ 0x7A34175D;
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
				int num = 1619861163;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4A5F66A6u) % 3u)
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
					num = (int)(num2 * 336745851) ^ -889482445;
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
				int num = 192021613;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7A86A8u) % 3u)
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
					result = Veet.smethod_3(ResourceManager, "Sa", resourceCulture);
					num = (int)(num2 * 792367180) ^ -507230676;
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
				int num = -1934906362;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEDAF45A3u) % 3u)
					{
					case 1u:
						goto IL_0003;
					case 2u:
						break;
					default:
						return result;
					}
					break;
					IL_0003:
					result = Veet.smethod_3(ResourceManager, "Xe", resourceCulture);
					num = ((int)num2 * -291707935) ^ -833114261;
				}
			}
		}
	}

	internal static string Zr => Veet.smethod_3(ResourceManager, "Zr", resourceCulture);

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
