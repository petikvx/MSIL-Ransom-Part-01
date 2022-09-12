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
			while (true)
			{
				int num = -414039225;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC6CF5118u) % 9u)
					{
					case 8u:
						num = (int)(num2 * 1701067440) ^ -1357155202;
						continue;
					case 7u:
						result = resourceMan;
						num = -14014234;
						continue;
					case 5u:
						num = ((int)num2 * -1248615059) ^ -567979004;
						continue;
					case 4u:
						num = ((int)num2 * -1966293440) ^ 0x5256EBAA;
						continue;
					case 3u:
						flag = resourceMan == null;
						num = ((int)num2 * -51733836) ^ -585627704;
						continue;
					case 2u:
					{
						ResourceManager resourceManager = (resourceMan = Veet.smethod_2("Cytotechnologist.Veet", Veet.smethod_1(Veet.smethod_0(typeof(Veet).TypeHandle))));
						num = ((int)num2 * -663132584) ^ 0x49A212E4;
						continue;
					}
					case 1u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 1017869776;
							num4 = 1017869776;
						}
						else
						{
							num3 = 2003723145;
							num4 = 2003723145;
						}
						num = num3 ^ ((int)num2 * -1539099226);
						continue;
					}
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
				int num = 257018806;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6489D9D0u) % 4u)
					{
					case 2u:
						result = resourceCulture;
						num = (int)((num2 * 2048853325) ^ 0x11A888E7);
						continue;
					case 1u:
						num = ((int)num2 * -1949659251) ^ -848866859;
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
				int num = -257730523;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF228D2BCu) % 4u)
					{
					case 1u:
						result = Veet.smethod_3(ResourceManager, "Sa", resourceCulture);
						num = ((int)num2 * -94926530) ^ 0x4F108C6A;
						continue;
					case 0u:
						num = ((int)num2 * -119204977) ^ -197135966;
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
			string result = Veet.smethod_3(ResourceManager, "Xe", resourceCulture);
			while (true)
			{
				int num = 487369759;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x96798A9u) % 3u)
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
					num = ((int)num2 * -1366055023) ^ 0x658CB90F;
				}
			}
		}
	}

	internal static string Zr
	{
		get
		{
			string result = Veet.smethod_3(ResourceManager, "Zr", resourceCulture);
			while (true)
			{
				int num = -910329891;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCC46C655u) % 3u)
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
					num = (int)(num2 * 926218505) ^ -316551597;
				}
			}
		}
	}

	internal Veet()
	{
		while (true)
		{
			int num = 122842322;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x31177FD1u) % 3u)
				{
				case 1u:
					goto IL_0008;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0008:
				num = (int)((num2 * 1828149777) ^ 0x6241ECFB);
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
