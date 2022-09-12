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
			ResourceManager result = default(ResourceManager);
			ResourceManager resourceManager = default(ResourceManager);
			while (true)
			{
				int num = 2007275076;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x24570313u) % 8u)
					{
					case 7u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -1948978412;
							num4 = -1948978412;
						}
						else
						{
							num3 = -1071302400;
							num4 = -1071302400;
						}
						num = num3 ^ (int)(num2 * 702493294);
						continue;
					}
					case 6u:
						num = ((int)num2 * -521494684) ^ -2110212946;
						continue;
					case 5u:
						result = resourceMan;
						num = 705757441;
						continue;
					case 4u:
						resourceMan = resourceManager;
						num = (int)(num2 * 914731547) ^ -518311863;
						continue;
					case 2u:
						num = ((int)num2 * -258004070) ^ -1171738692;
						continue;
					case 1u:
						resourceManager = Veet.smethod_2("Cytotechnologist.Veet", Veet.smethod_1(Veet.smethod_0(typeof(Veet).TypeHandle)));
						num = ((int)num2 * -778681688) ^ -1301648497;
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			CultureInfo result = default(CultureInfo);
			while (true)
			{
				int num = 1563949706;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x17BB0F06u) % 3u)
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
					num = (int)((num2 * 1862798079) ^ 0x3C30E567);
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
				int num = 684496813;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x46D85D52u) % 3u)
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
					num = (int)((num2 * 1848486689) ^ 0x106E577E);
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
				int num = -1591581028;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCFF4496Du) % 4u)
					{
					case 3u:
						num = ((int)num2 * -1757529295) ^ -1641233020;
						continue;
					case 1u:
						result = Veet.smethod_3(ResourceManager, "Xe", resourceCulture);
						num = ((int)num2 * -1071852498) ^ -997353156;
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
				int num = 1466568608;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x48E724BEu) % 4u)
					{
					case 2u:
						result = Veet.smethod_3(ResourceManager, "Zr", resourceCulture);
						num = ((int)num2 * -1254261966) ^ 0x285D1407;
						continue;
					case 1u:
						num = ((int)num2 * -1318825466) ^ -928456729;
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
