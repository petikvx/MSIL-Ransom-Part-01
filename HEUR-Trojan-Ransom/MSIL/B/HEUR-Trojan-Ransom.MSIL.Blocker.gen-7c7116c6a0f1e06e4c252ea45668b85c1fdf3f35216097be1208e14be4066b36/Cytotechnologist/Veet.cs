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
			bool flag = default(bool);
			ResourceManager resourceManager = default(ResourceManager);
			while (true)
			{
				int num = 90427611;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x379A8B4Du) % 9u)
					{
					case 8u:
						num = ((int)num2 * -1195183481) ^ 0x426704D9;
						continue;
					case 7u:
						result = resourceMan;
						num = 201175456;
						continue;
					case 5u:
						num = ((int)num2 * -2025869620) ^ -1942941868;
						continue;
					case 3u:
						flag = resourceMan == null;
						num = ((int)num2 * -696691212) ^ 0x6A60A1CE;
						continue;
					case 2u:
						resourceManager = Veet.smethod_2("Cytotechnologist.Veet", Veet.smethod_1(Veet.smethod_0(typeof(Veet).TypeHandle)));
						num = (int)((num2 * 1667481568) ^ 0x3CEF9957);
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -126132447;
							num4 = -126132447;
						}
						else
						{
							num3 = -295590886;
							num4 = -295590886;
						}
						num = num3 ^ (int)(num2 * 353201195);
						continue;
					}
					case 0u:
						resourceMan = resourceManager;
						num = ((int)num2 * -1522682841) ^ 0x595B6D16;
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
				int num = 429478124;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5D2FE17Cu) % 3u)
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
					num = (int)((num2 * 2057231323) ^ 0x5E7EE6C0);
				}
			}
		}
		set
		{
			while (true)
			{
				int num = 1491665049;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1750AE22u) % 3u)
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
					num = ((int)num2 * -1422164615) ^ -1249699577;
				}
			}
		}
	}

	internal static string Sa
	{
		get
		{
			string result = Veet.smethod_3(ResourceManager, "Sa", resourceCulture);
			while (true)
			{
				int num = 650165915;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7DF3FC48u) % 3u)
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
					num = (int)(num2 * 1466285629) ^ -488911676;
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
				int num = 276041450;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x39D5E018u) % 3u)
					{
					case 1u:
						goto IL_0017;
					case 2u:
						break;
					default:
						return result;
					}
					break;
					IL_0017:
					num = (int)(num2 * 208938042) ^ -1761108197;
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
				int num = 954701399;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7A806D48u) % 4u)
					{
					case 3u:
						result = Veet.smethod_3(ResourceManager, "Zr", resourceCulture);
						num = ((int)num2 * -270318877) ^ 0x111AA877;
						continue;
					case 2u:
						num = (int)(num2 * 1031528142) ^ -993953979;
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
			int num = -1212843679;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFBBB2E8Cu) % 4u)
				{
				case 2u:
					num = (int)((num2 * 22506098) ^ 0x1D885210);
					continue;
				case 1u:
					num = (int)(num2 * 454537436) ^ -1593012754;
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
