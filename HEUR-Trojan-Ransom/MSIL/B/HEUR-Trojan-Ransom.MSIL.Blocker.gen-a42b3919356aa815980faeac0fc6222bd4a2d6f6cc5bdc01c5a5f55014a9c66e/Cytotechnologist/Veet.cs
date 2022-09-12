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
			ResourceManager resourceManager = default(ResourceManager);
			bool flag = default(bool);
			ResourceManager result = default(ResourceManager);
			while (true)
			{
				int num = -1985316493;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD653F289u) % 9u)
					{
					case 8u:
						resourceMan = resourceManager;
						num = ((int)num2 * -637834978) ^ 0x36158668;
						continue;
					case 7u:
						flag = resourceMan == null;
						num = (int)((num2 * 2034161573) ^ 0x6631866B);
						continue;
					case 6u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 964204021;
							num4 = 964204021;
						}
						else
						{
							num3 = 491673744;
							num4 = 491673744;
						}
						num = num3 ^ (int)(num2 * 1923567373);
						continue;
					}
					case 5u:
						num = ((int)num2 * -813899725) ^ 0x5833004;
						continue;
					case 2u:
						resourceManager = Veet.smethod_2("Cytotechnologist.Veet", Veet.smethod_1(Veet.smethod_0(typeof(Veet).TypeHandle)));
						num = ((int)num2 * -166386063) ^ -1162398364;
						continue;
					case 1u:
						result = resourceMan;
						num = -629056769;
						continue;
					case 0u:
						num = (int)(num2 * 1853094919) ^ -724838960;
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
			CultureInfo result = default(CultureInfo);
			while (true)
			{
				int num = 364277262;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x11F628C7u) % 4u)
					{
					case 3u:
						num = (int)(num2 * 1336493763) ^ -1793972918;
						continue;
					case 1u:
						result = resourceCulture;
						num = (int)(num2 * 131752576) ^ -1424685092;
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
				int num = -787461228;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB92ED1FCu) % 3u)
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
					num = ((int)num2 * -1976485805) ^ -388088365;
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
				int num = -1981985462;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x875F0BFBu) % 4u)
					{
					case 2u:
						num = ((int)num2 * -1932483352) ^ 0x2445FC98;
						continue;
					case 1u:
						result = Veet.smethod_3(ResourceManager, "Xe", resourceCulture);
						num = ((int)num2 * -2074551559) ^ 0x7500DE0;
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
			string result = Veet.smethod_3(ResourceManager, "Zr", resourceCulture);
			while (true)
			{
				int num = 1617639872;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3407E140u) % 3u)
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
					num = (int)(num2 * 515496708) ^ -434821281;
				}
			}
		}
	}

	internal Veet()
	{
		while (true)
		{
			int num = -191728745;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE22CA5D3u) % 3u)
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
				num = ((int)num2 * -1469549395) ^ 0x3FF9751B;
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
