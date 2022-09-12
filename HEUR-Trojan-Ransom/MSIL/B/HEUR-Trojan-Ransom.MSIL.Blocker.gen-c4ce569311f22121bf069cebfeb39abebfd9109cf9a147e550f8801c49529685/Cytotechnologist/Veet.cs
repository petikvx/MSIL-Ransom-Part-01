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
				goto IL_001e;
			}
			goto IL_009d;
			IL_009d:
			ResourceManager result = resourceMan;
			int num = -415127311;
			goto IL_0070;
			IL_0070:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9F5AF3FBu) % 7u)
				{
				case 6u:
					num = ((int)num2 * -1663231181) ^ 0x68605379;
					continue;
				case 4u:
					break;
				case 3u:
					num = ((int)num2 * -422298152) ^ -594067774;
					continue;
				case 2u:
					num = ((int)num2 * -964696188) ^ 0x5F84228C;
					continue;
				case 0u:
				{
					ResourceManager resourceManager = (resourceMan = Veet.smethod_2("Cytotechnologist.Veet", Veet.smethod_1(Veet.smethod_0(typeof(Veet).TypeHandle))));
					num = ((int)num2 * -485984420) ^ 0x7642322;
					continue;
				}
				case 5u:
					goto IL_009d;
				default:
					return result;
				}
				break;
			}
			goto IL_001e;
			IL_001e:
			num = -304939999;
			goto IL_0070;
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
				int num = -447111465;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB58D5A9Au) % 3u)
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
					num = (int)(num2 * 1792191860) ^ -918710352;
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
				int num = 2020222668;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x45406681u) % 3u)
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
					num = (int)((num2 * 422795153) ^ 0x532FB72D);
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
				int num = -1520016428;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBAF2A7DFu) % 4u)
					{
					case 3u:
						result = Veet.smethod_3(ResourceManager, "Xe", resourceCulture);
						num = ((int)num2 * -905039296) ^ -1821198367;
						continue;
					case 2u:
						num = ((int)num2 * -671629652) ^ 0x3D0CCDE2;
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
				int num = 1722664857;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x42BD8920u) % 4u)
					{
					case 2u:
						num = ((int)num2 * -1598313852) ^ 0x53EEBEC7;
						continue;
					case 1u:
						result = Veet.smethod_3(ResourceManager, "Zr", resourceCulture);
						num = ((int)num2 * -460706858) ^ 0x5647A2A0;
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
