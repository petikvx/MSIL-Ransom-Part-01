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
			ResourceManager resourceManager = default(ResourceManager);
			bool flag = default(bool);
			while (true)
			{
				int num = 408569008;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6F74B84u) % 8u)
					{
					case 7u:
						result = resourceMan;
						num = 1410133410;
						continue;
					case 5u:
						resourceMan = resourceManager;
						num = ((int)num2 * -1440329450) ^ -2075996643;
						continue;
					case 4u:
						flag = resourceMan == null;
						num = ((int)num2 * -657279264) ^ 0x391EB717;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -692798263;
							num4 = -692798263;
						}
						else
						{
							num3 = -1846529642;
							num4 = -1846529642;
						}
						num = num3 ^ (int)(num2 * 540474839);
						continue;
					}
					case 1u:
						resourceManager = Veet.smethod_2("Cytotechnologist.Veet", Veet.smethod_1(Veet.smethod_0(typeof(Veet).TypeHandle)));
						num = (int)((num2 * 295173713) ^ 0x7F2598C0);
						continue;
					case 0u:
						num = ((int)num2 * -1292202608) ^ 0xBD87F0D;
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
				int num = 1681756720;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4E3DDA1u) % 4u)
					{
					case 3u:
						num = ((int)num2 * -1663640689) ^ 0x260F6234;
						continue;
					case 1u:
						result = resourceCulture;
						num = (int)(num2 * 1556201509) ^ -1818285821;
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
			string result = default(string);
			while (true)
			{
				int num = -2080995118;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB812D4E3u) % 4u)
					{
					case 2u:
						num = ((int)num2 * -1261278205) ^ -891159039;
						continue;
					case 1u:
						result = Veet.smethod_3(ResourceManager, "Sa", resourceCulture);
						num = ((int)num2 * -1262885774) ^ -1774830413;
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

	internal static string Xe => Veet.smethod_3(ResourceManager, "Xe", resourceCulture);

	internal static string Zr
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = 1005384507;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2CA58704u) % 3u)
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
					num = (int)(num2 * 1750626899) ^ -2036112319;
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
