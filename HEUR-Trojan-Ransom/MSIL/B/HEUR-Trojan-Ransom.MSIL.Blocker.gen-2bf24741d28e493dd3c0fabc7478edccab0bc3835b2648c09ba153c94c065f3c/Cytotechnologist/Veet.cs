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
				int num = -164365306;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9CDA6D9Au) % 9u)
					{
					case 8u:
						result = resourceMan;
						num = -1914461888;
						continue;
					case 7u:
						flag = resourceMan == null;
						num = (int)((num2 * 605147408) ^ 0xA1FD59E);
						continue;
					case 6u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -2047432031;
							num4 = -2047432031;
						}
						else
						{
							num3 = -1399466516;
							num4 = -1399466516;
						}
						num = num3 ^ (int)(num2 * 797846374);
						continue;
					}
					case 4u:
						num = ((int)num2 * -1732425190) ^ 0x4B3CD129;
						continue;
					case 3u:
						num = ((int)num2 * -663275651) ^ 0x25D4458C;
						continue;
					case 2u:
						resourceMan = resourceManager;
						num = (int)(num2 * 1779853868) ^ -87275341;
						continue;
					case 0u:
						resourceManager = Veet.smethod_2("Cytotechnologist.Veet", Veet.smethod_1(Veet.smethod_0(typeof(Veet).TypeHandle)));
						num = (int)(num2 * 1472431490) ^ -532826048;
						continue;
					case 5u:
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
			string result = Veet.smethod_3(ResourceManager, "Sa", resourceCulture);
			while (true)
			{
				int num = 623553234;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x480C87CDu) % 3u)
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
					num = (int)((num2 * 440708949) ^ 0x2D8309DC);
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
				int num = 1718006456;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6188C9E3u) % 4u)
					{
					case 3u:
						result = Veet.smethod_3(ResourceManager, "Xe", resourceCulture);
						num = (int)(num2 * 2141937819) ^ -1886025520;
						continue;
					case 2u:
						num = (int)((num2 * 2127330194) ^ 0x613F6EA2);
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

	internal static string Zr
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = 596083701;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2B8C577Bu) % 4u)
					{
					case 2u:
						result = Veet.smethod_3(ResourceManager, "Zr", resourceCulture);
						num = (int)(num2 * 1558218932) ^ -1946626386;
						continue;
					case 1u:
						num = (int)((num2 * 2038753222) ^ 0x749E0F01);
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
		while (true)
		{
			int num = -1171305183;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFD503D20u) % 3u)
				{
				case 2u:
					goto IL_0008;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0008:
				num = (int)((num2 * 513142122) ^ 0x54BCD9A6);
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
