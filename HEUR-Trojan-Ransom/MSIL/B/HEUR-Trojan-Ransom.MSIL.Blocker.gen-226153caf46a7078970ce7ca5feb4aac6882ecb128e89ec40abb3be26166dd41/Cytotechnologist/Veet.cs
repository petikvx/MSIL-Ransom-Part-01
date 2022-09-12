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
			while (true)
			{
				int num = 542642182;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x442677CDu) % 8u)
					{
					case 7u:
						num = (int)((num2 * 148786262) ^ 0x4DE514D);
						continue;
					case 6u:
						num = ((int)num2 * -1130534166) ^ -2094338928;
						continue;
					case 3u:
						flag = resourceMan == null;
						num = (int)((num2 * 927257647) ^ 0x14ED7DE0);
						continue;
					case 2u:
					{
						ResourceManager resourceManager = (resourceMan = Veet.smethod_2("Cytotechnologist.Veet", Veet.smethod_1(Veet.smethod_0(typeof(Veet).TypeHandle))));
						num = (int)(num2 * 661711675) ^ -1622826779;
						continue;
					}
					case 1u:
						result = resourceMan;
						num = 160419296;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -997286500;
							num4 = -997286500;
						}
						else
						{
							num3 = -1570644638;
							num4 = -1570644638;
						}
						num = num3 ^ (int)(num2 * 811355606);
						continue;
					}
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
			return resourceCulture;
		}
		set
		{
			while (true)
			{
				int num = 1041207362;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x49A1D4DDu) % 3u)
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
					num = (int)(num2 * 559178443) ^ -106025911;
				}
			}
		}
	}

	internal static string Sa => Veet.smethod_3(ResourceManager, "Sa", resourceCulture);

	internal static string Xe
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = -795102746;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFA3F9027u) % 4u)
					{
					case 3u:
						num = ((int)num2 * -1137248721) ^ -197072820;
						continue;
					case 1u:
						result = Veet.smethod_3(ResourceManager, "Xe", resourceCulture);
						num = ((int)num2 * -1359693016) ^ 0x13A42200;
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
				int num = 586036218;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4A1E3669u) % 4u)
					{
					case 3u:
						result = Veet.smethod_3(ResourceManager, "Zr", resourceCulture);
						num = (int)((num2 * 198113858) ^ 0x14ADC375);
						continue;
					case 2u:
						num = ((int)num2 * -1441404802) ^ 0x9C98BF0;
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
