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
				int num = 2053763696;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2052B61Bu) % 7u)
					{
					case 6u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 1138021108;
							num4 = 1138021108;
						}
						else
						{
							num3 = 1291664369;
							num4 = 1291664369;
						}
						num = num3 ^ (int)(num2 * 370408472);
						continue;
					}
					case 5u:
						resourceManager = Veet.smethod_2("Cytotechnologist.Veet", Veet.smethod_1(Veet.smethod_0(typeof(Veet).TypeHandle)));
						num = (int)(num2 * 2057565690) ^ -1500307823;
						continue;
					case 4u:
						num = ((int)num2 * -859108930) ^ 0x76BE95D1;
						continue;
					case 3u:
						result = resourceMan;
						num = 990986193;
						continue;
					case 0u:
						resourceMan = resourceManager;
						num = ((int)num2 * -378577807) ^ -2089696413;
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			CultureInfo result = default(CultureInfo);
			while (true)
			{
				int num = -431770016;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF2578FE5u) % 4u)
					{
					case 1u:
						result = resourceCulture;
						num = (int)(num2 * 776658654) ^ -1805621453;
						continue;
					case 0u:
						num = (int)((num2 * 320350197) ^ 0x7942B766);
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
				int num = -2059290137;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF99E20BDu) % 3u)
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
					num = (int)(num2 * 2034337958) ^ -153543460;
				}
			}
		}
	}

	internal static string Xe
	{
		get
		{
			string result = Veet.smethod_3(ResourceManager, "Xe", resourceCulture);
			while (true)
			{
				int num = 1040339404;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x55E1A205u) % 3u)
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
					num = ((int)num2 * -1056173118) ^ -771904109;
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
				int num = -1412333374;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x87848DF9u) % 4u)
					{
					case 3u:
						result = Veet.smethod_3(ResourceManager, "Zr", resourceCulture);
						num = (int)((num2 * 85131279) ^ 0x33EC2F01);
						continue;
					case 1u:
						num = ((int)num2 * -1670501261) ^ 0x3C858EC8;
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

	internal Veet()
	{
		while (true)
		{
			int num = -1411015401;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBFF5B73Fu) % 3u)
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
				num = ((int)num2 * -1100234365) ^ 0x75D7EF6B;
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
