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
			ResourceManager resourceManager = default(ResourceManager);
			ResourceManager result = default(ResourceManager);
			while (true)
			{
				int num = -651104096;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA30A2EFCu) % 9u)
					{
					case 8u:
						num = ((int)num2 * -1352833016) ^ -469767267;
						continue;
					case 7u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -468239852;
							num4 = -468239852;
						}
						else
						{
							num3 = -1481257192;
							num4 = -1481257192;
						}
						num = num3 ^ ((int)num2 * -77927504);
						continue;
					}
					case 6u:
						resourceMan = resourceManager;
						num = (int)((num2 * 760932734) ^ 0x486032E3);
						continue;
					case 5u:
						flag = resourceMan == null;
						num = (int)(num2 * 46629639) ^ -1733784776;
						continue;
					case 4u:
						num = ((int)num2 * -510465443) ^ -72737865;
						continue;
					case 2u:
						resourceManager = Veet.smethod_2("Cytotechnologist.Veet", Veet.smethod_1(Veet.smethod_0(typeof(Veet).TypeHandle)));
						num = (int)(num2 * 1778269488) ^ -1690601422;
						continue;
					case 1u:
						result = resourceMan;
						num = -1873287089;
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			CultureInfo result = resourceCulture;
			while (true)
			{
				int num = -1287347947;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAD0CE966u) % 3u)
					{
					case 1u:
						goto IL_0008;
					case 2u:
						break;
					default:
						return result;
					}
					break;
					IL_0008:
					num = ((int)num2 * -1441466802) ^ 0x778F0425;
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
				int num = 2028851626;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x12F60953u) % 4u)
					{
					case 1u:
						result = Veet.smethod_3(ResourceManager, "Sa", resourceCulture);
						num = (int)(num2 * 627276962) ^ -702451031;
						continue;
					case 0u:
						num = ((int)num2 * -1435063984) ^ -932850687;
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

	internal static string Xe
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = -411628872;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAB0C6374u) % 3u)
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
					num = (int)((num2 * 160240080) ^ 0x3EC1D7AA);
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
				int num = -838602983;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x90DA3AA0u) % 4u)
					{
					case 3u:
						num = (int)((num2 * 277406718) ^ 0x5F9FC5C8);
						continue;
					case 1u:
						result = Veet.smethod_3(ResourceManager, "Zr", resourceCulture);
						num = (int)(num2 * 1354545678) ^ -1250341523;
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
			int num = 612960038;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x20B6647Bu) % 4u)
				{
				case 2u:
					num = ((int)num2 * -721667620) ^ 0x6F374EF8;
					continue;
				case 1u:
					num = ((int)num2 * -654999029) ^ -613552762;
					continue;
				default:
					return;
				case 0u:
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
