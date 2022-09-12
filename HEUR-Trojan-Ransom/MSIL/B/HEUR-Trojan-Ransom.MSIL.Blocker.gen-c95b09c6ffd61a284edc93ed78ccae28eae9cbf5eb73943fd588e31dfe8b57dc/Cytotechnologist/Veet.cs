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
			ResourceManager result = default(ResourceManager);
			ResourceManager resourceManager = default(ResourceManager);
			while (true)
			{
				int num = 1161881242;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x20104374u) % 10u)
					{
					case 9u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 1257965;
							num4 = 1257965;
						}
						else
						{
							num3 = 1923225141;
							num4 = 1923225141;
						}
						num = num3 ^ (int)(num2 * 1824601168);
						continue;
					}
					case 7u:
						result = resourceMan;
						num = 1101078327;
						continue;
					case 5u:
						num = (int)((num2 * 1989948727) ^ 0x6AE07006);
						continue;
					case 4u:
						flag = resourceMan == null;
						num = (int)(num2 * 1439598874) ^ -148207683;
						continue;
					case 3u:
						num = ((int)num2 * -1287930460) ^ -555066138;
						continue;
					case 2u:
						resourceMan = resourceManager;
						num = ((int)num2 * -906713168) ^ 0x2BF2F572;
						continue;
					case 1u:
						resourceManager = Veet.smethod_2("Cytotechnologist.Veet", Veet.smethod_1(Veet.smethod_0(typeof(Veet).TypeHandle)));
						num = (int)(num2 * 568933501) ^ -618059937;
						continue;
					case 0u:
						num = ((int)num2 * -734718669) ^ -1167316745;
						continue;
					case 8u:
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
				int num = 601464841;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5C369709u) % 3u)
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
					num = ((int)num2 * -1690318230) ^ 0x3C387E94;
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
				int num = -2009498679;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC091EE49u) % 3u)
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
					num = (int)(num2 * 269095496) ^ -211508761;
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
				int num = -2061189262;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC89AFCF0u) % 4u)
					{
					case 2u:
						result = Veet.smethod_3(ResourceManager, "Xe", resourceCulture);
						num = (int)((num2 * 283043058) ^ 0x6C725E39);
						continue;
					case 1u:
						num = (int)(num2 * 298869637) ^ -260962419;
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
				int num = 1143864119;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x737A63F0u) % 3u)
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
					result = Veet.smethod_3(ResourceManager, "Zr", resourceCulture);
					num = (int)((num2 * 1174279961) ^ 0x4A25AF97);
				}
			}
		}
	}

	internal Veet()
	{
		while (true)
		{
			int num = -1144686781;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9762395Bu) % 3u)
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
				num = (int)(num2 * 1362817329) ^ -1412216128;
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
