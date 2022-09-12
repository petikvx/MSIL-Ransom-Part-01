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
				int num = 1469648596;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6461E2F1u) % 8u)
					{
					case 7u:
						num = ((int)num2 * -1886229625) ^ -345059226;
						continue;
					case 5u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -1516034216;
							num4 = -1516034216;
						}
						else
						{
							num3 = -362581125;
							num4 = -362581125;
						}
						num = num3 ^ ((int)num2 * -720964825);
						continue;
					}
					case 3u:
					{
						ResourceManager resourceManager = (resourceMan = Veet.smethod_2("Cytotechnologist.Veet", Veet.smethod_1(Veet.smethod_0(typeof(Veet).TypeHandle))));
						num = (int)((num2 * 1469612009) ^ 0x36B818CA);
						continue;
					}
					case 2u:
						result = resourceMan;
						num = 1101344382;
						continue;
					case 1u:
						num = ((int)num2 * -102481421) ^ 0x301F591;
						continue;
					case 0u:
						num = (int)((num2 * 321039887) ^ 0x3C233733);
						continue;
					case 4u:
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
				int num = 7575429;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x56300CC0u) % 4u)
					{
					case 3u:
						num = (int)(num2 * 43571756) ^ -1533381850;
						continue;
					case 1u:
						result = resourceCulture;
						num = (int)((num2 * 1415450313) ^ 0x912E736);
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
			while (true)
			{
				int num = 1393410733;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x175E4C12u) % 3u)
					{
					case 1u:
						goto IL_0003;
					default:
						return;
					case 0u:
						break;
					case 2u:
						return;
					}
					break;
					IL_0003:
					resourceCulture = value;
					num = (int)(num2 * 11272008) ^ -1286166505;
				}
			}
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
				int num = -1967386653;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCE767A2Du) % 3u)
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
					num = (int)((num2 * 1419124137) ^ 0x49AEA90B);
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
				int num = 618030634;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1B34995Fu) % 3u)
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
					result = Veet.smethod_3(ResourceManager, "Zr", resourceCulture);
					num = (int)((num2 * 1740390444) ^ 0x536C111);
				}
			}
		}
	}

	internal Veet()
	{
		while (true)
		{
			int num = -666284037;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA2AB08F2u) % 4u)
				{
				case 1u:
					num = ((int)num2 * -1537344050) ^ -1015782276;
					continue;
				case 0u:
					num = (int)((num2 * 128624969) ^ 0x5209F025);
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
