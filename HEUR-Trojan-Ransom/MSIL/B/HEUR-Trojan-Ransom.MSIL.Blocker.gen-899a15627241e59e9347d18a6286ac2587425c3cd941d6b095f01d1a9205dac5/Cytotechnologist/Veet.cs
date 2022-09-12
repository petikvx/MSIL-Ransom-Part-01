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
				int num = 295088930;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3FC2B0ECu) % 7u)
					{
					case 6u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -1646248887;
							num4 = -1646248887;
						}
						else
						{
							num3 = -1227037944;
							num4 = -1227037944;
						}
						num = num3 ^ ((int)num2 * -427739274);
						continue;
					}
					case 5u:
						flag = resourceMan == null;
						num = ((int)num2 * -611660263) ^ 0x7ABDDE0;
						continue;
					case 4u:
					{
						ResourceManager resourceManager = (resourceMan = Veet.smethod_2("Cytotechnologist.Veet", Veet.smethod_1(Veet.smethod_0(typeof(Veet).TypeHandle))));
						num = (int)(num2 * 1210003065) ^ -166424991;
						continue;
					}
					case 3u:
						num = ((int)num2 * -1648328695) ^ -1275720888;
						continue;
					case 1u:
						result = resourceMan;
						num = 66878521;
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
				int num = -1069396436;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x84C94C89u) % 4u)
					{
					case 1u:
						result = resourceCulture;
						num = (int)(num2 * 1525497237) ^ -1121707452;
						continue;
					case 0u:
						num = (int)(num2 * 1002817536) ^ -1822699722;
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
			while (true)
			{
				int num = 1108531195;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4DD34DDFu) % 3u)
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
					num = ((int)num2 * -1296833744) ^ 0x5574F7E9;
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
				int num = -161791292;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x95739020u) % 3u)
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
					num = ((int)num2 * -1808241094) ^ 0x7887AEFB;
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
				int num = -1397051790;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xECB59725u) % 3u)
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
					num = ((int)num2 * -1980263665) ^ -832658005;
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
				int num = -1018739796;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF04C192Du) % 3u)
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
					num = ((int)num2 * -1863402327) ^ 0x4653199D;
				}
			}
		}
	}

	internal Veet()
	{
		while (true)
		{
			int num = 513349493;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF4FB4FFu) % 3u)
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
				num = ((int)num2 * -1815475135) ^ -595651328;
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
