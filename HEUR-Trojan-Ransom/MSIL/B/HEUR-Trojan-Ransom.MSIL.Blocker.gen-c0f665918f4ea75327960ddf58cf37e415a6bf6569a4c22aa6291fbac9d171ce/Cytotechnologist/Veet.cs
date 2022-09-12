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
			while (true)
			{
				int num = -1477901093;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAC3661C5u) % 7u)
					{
					case 6u:
					{
						ResourceManager resourceManager = (resourceMan = Veet.smethod_2("Cytotechnologist.Veet", Veet.smethod_1(Veet.smethod_0(typeof(Veet).TypeHandle))));
						num = (int)(num2 * 1905474747) ^ -1635139444;
						continue;
					}
					case 5u:
						num = (int)(num2 * 1533750808) ^ -1024982209;
						continue;
					case 3u:
						num = ((int)num2 * -2060773184) ^ -1985107757;
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (resourceMan == null)
						{
							num3 = 1718225506;
							num4 = 1718225506;
						}
						else
						{
							num3 = 835183460;
							num4 = 835183460;
						}
						num = num3 ^ ((int)num2 * -166165805);
						continue;
					}
					case 0u:
						result = resourceMan;
						num = -7546506;
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
			CultureInfo result = resourceCulture;
			while (true)
			{
				int num = -1760291805;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE7313F35u) % 3u)
					{
					case 1u:
						goto IL_0008;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0008:
					num = (int)((num2 * 270446671) ^ 0x74B377EC);
				}
			}
		}
		set
		{
			while (true)
			{
				int num = 1108466669;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x127D0634u) % 3u)
					{
					case 2u:
						goto IL_0003;
					default:
						return;
					case 0u:
						break;
					case 1u:
						return;
					}
					break;
					IL_0003:
					resourceCulture = value;
					num = ((int)num2 * -1531523805) ^ -405133071;
				}
			}
		}
	}

	internal static string Sa
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = 1113479752;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5CF65913u) % 3u)
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
					result = Veet.smethod_3(ResourceManager, "Sa", resourceCulture);
					num = ((int)num2 * -1362598276) ^ 0x7225FA21;
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
				int num = -923043343;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x84B87534u) % 4u)
					{
					case 1u:
						result = Veet.smethod_3(ResourceManager, "Xe", resourceCulture);
						num = ((int)num2 * -2013767561) ^ 0x88F0A6F;
						continue;
					case 0u:
						num = ((int)num2 * -76859020) ^ 0xA80E862;
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
				int num = 383012245;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x22901F4Cu) % 4u)
					{
					case 1u:
						result = Veet.smethod_3(ResourceManager, "Zr", resourceCulture);
						num = (int)((num2 * 1280612583) ^ 0x49037DE3);
						continue;
					case 0u:
						num = ((int)num2 * -1200094624) ^ 0x92A6437;
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
			int num = -250418774;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDCBC68D7u) % 4u)
				{
				case 1u:
					num = (int)(num2 * 1976640785) ^ -753011146;
					continue;
				case 0u:
					num = ((int)num2 * -2038305391) ^ -991912635;
					continue;
				default:
					return;
				case 3u:
					break;
				case 2u:
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
