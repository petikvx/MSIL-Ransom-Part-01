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
				goto IL_0035;
			}
			goto IL_0087;
			IL_0087:
			ResourceManager result = resourceMan;
			int num = 1492748504;
			goto IL_005e;
			IL_005e:
			ResourceManager resourceManager = default(ResourceManager);
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3D96EB09u) % 6u)
				{
				case 4u:
					resourceManager = Veet.smethod_2("Cytotechnologist.Veet", Veet.smethod_1(Veet.smethod_0(typeof(Veet).TypeHandle)));
					num = (int)((num2 * 551275457) ^ 0x1F2508BF);
					continue;
				case 3u:
					break;
				case 2u:
					resourceMan = resourceManager;
					num = (int)((num2 * 491522861) ^ 0x71FF5C7);
					continue;
				case 1u:
					num = ((int)num2 * -1681355316) ^ -1169163652;
					continue;
				case 0u:
					goto IL_0087;
				default:
					return result;
				}
				break;
			}
			goto IL_0035;
			IL_0035:
			num = 1439350909;
			goto IL_005e;
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
				int num = -420411150;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB93B820Fu) % 4u)
					{
					case 3u:
						num = ((int)num2 * -279995) ^ 0x7AA2881E;
						continue;
					case 1u:
						result = resourceCulture;
						num = ((int)num2 * -310276341) ^ 0xBB0AE1F;
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
				int num = 1565959666;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x672FE21Au) % 3u)
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
					num = ((int)num2 * -561650202) ^ -671014696;
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
				int num = -1491942719;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB3E985D8u) % 3u)
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
					num = ((int)num2 * -256834875) ^ 0x220C8BBE;
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
				int num = -2046799135;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE879ECE7u) % 4u)
					{
					case 2u:
						result = Veet.smethod_3(ResourceManager, "Zr", resourceCulture);
						num = ((int)num2 * -504430160) ^ -571836786;
						continue;
					case 1u:
						num = ((int)num2 * -1326465815) ^ -15577619;
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
			int num = 432240686;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1F65410Fu) % 4u)
				{
				case 3u:
					num = ((int)num2 * -475096865) ^ 0x591DDDEE;
					continue;
				case 1u:
					num = (int)(num2 * 1968646966) ^ -1770797326;
					continue;
				default:
					return;
				case 2u:
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
