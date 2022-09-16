using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Traffic_Simulation;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal class Led
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
				int num = 1668776518;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x77A5BE26u) % 7u)
					{
					case 6u:
						flag = resourceMan == null;
						num = ((int)num2 * -127882518) ^ 0x6F94B53;
						continue;
					case 4u:
						result = resourceMan;
						num = 1976057872;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 112414921;
							num4 = 112414921;
						}
						else
						{
							num3 = 1779882774;
							num4 = 1779882774;
						}
						num = num3 ^ (int)(num2 * 201792461);
						continue;
					}
					case 1u:
					{
						ResourceManager resourceManager = (resourceMan = Led.smethod_2("Traffic_Simulation.Led", Led.smethod_1(Led.smethod_0(typeof(Led).TypeHandle))));
						num = (int)(num2 * 1219067672) ^ -378981177;
						continue;
					}
					case 0u:
						num = ((int)num2 * -499024695) ^ 0x580A5BB9;
						continue;
					case 5u:
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
				int num = 65911040;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6F0961E5u) % 3u)
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
					result = resourceCulture;
					num = (int)(num2 * 1313403615) ^ -1006647406;
				}
			}
		}
		set
		{
			while (true)
			{
				int num = -705294770;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9D330EA7u) % 3u)
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
					num = ((int)num2 * -551458653) ^ -700879221;
				}
			}
		}
	}

	internal static byte[] Red1
	{
		get
		{
			object obj = default(object);
			byte[] result = default(byte[]);
			while (true)
			{
				int num = -709536479;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC24649DFu) % 4u)
					{
					case 2u:
						obj = Led.smethod_3(ResourceManager, "Red1", resourceCulture);
						num = ((int)num2 * -1748106783) ^ -382154656;
						continue;
					case 1u:
						result = (byte[])obj;
						num = (int)(num2 * 72106430) ^ -2029459363;
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

	internal Led()
	{
		while (true)
		{
			int num = 1426267137;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x372E8345u) % 3u)
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
				num = (int)((num2 * 1446305613) ^ 0x385E9295);
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

	static object smethod_3(ResourceManager resourceManager_0, string string_0, CultureInfo cultureInfo_0)
	{
		return resourceManager_0.GetObject(string_0, cultureInfo_0);
	}
}
