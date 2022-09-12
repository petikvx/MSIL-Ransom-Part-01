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
			if (resourceMan == null)
			{
				goto IL_003b;
			}
			goto IL_0074;
			IL_0074:
			ResourceManager result = resourceMan;
			int num = -785894235;
			goto IL_004f;
			IL_004f:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8974CF1Au) % 5u)
				{
				case 4u:
				{
					ResourceManager resourceManager = (resourceMan = Veet.smethod_2("Cytotechnologist.Veet", Veet.smethod_1(Veet.smethod_0(typeof(Veet).TypeHandle))));
					num = ((int)num2 * -979238259) ^ 0x6A1E1EA5;
					continue;
				}
				case 3u:
					break;
				case 1u:
					num = (int)((num2 * 2007074977) ^ 0x266CD1A3);
					continue;
				case 0u:
					goto IL_0074;
				default:
					return result;
				}
				break;
			}
			goto IL_003b;
			IL_003b:
			num = -1535959153;
			goto IL_004f;
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
				int num = 2070407906;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x206F06C5u) % 3u)
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
					result = resourceCulture;
					num = (int)((num2 * 338839627) ^ 0x26F9420C);
				}
			}
		}
		set
		{
			while (true)
			{
				int num = -1949702863;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD61FF987u) % 3u)
					{
					case 1u:
						goto IL_0003;
					default:
						return;
					case 2u:
						break;
					case 0u:
						return;
					}
					break;
					IL_0003:
					resourceCulture = value;
					num = (int)(num2 * 609390169) ^ -465184401;
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
				int num = 2102930240;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6DECDF6Cu) % 3u)
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
					num = (int)(num2 * 1941398588) ^ -1761331204;
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
				int num = -1808398003;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBB7842E3u) % 4u)
					{
					case 2u:
						result = Veet.smethod_3(ResourceManager, "Xe", resourceCulture);
						num = (int)(num2 * 137874828) ^ -1057497994;
						continue;
					case 1u:
						num = (int)((num2 * 1339348736) ^ 0x574D3D3);
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

	internal static string Zr
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = 404185414;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3FA2F57Du) % 4u)
					{
					case 3u:
						result = Veet.smethod_3(ResourceManager, "Zr", resourceCulture);
						num = (int)(num2 * 813729794) ^ -86415177;
						continue;
					case 0u:
						num = ((int)num2 * -1137370402) ^ -417677584;
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
			int num = 161671610;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5EDA768u) % 3u)
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
				num = ((int)num2 * -842353354) ^ 0x3945BDB8;
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
