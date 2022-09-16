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
			bool flag = resourceMan == null;
			ResourceManager result = default(ResourceManager);
			while (true)
			{
				int num = 440645521;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3F1CC658u) % 7u)
					{
					case 6u:
						num = ((int)num2 * -1818835631) ^ -1874741442;
						continue;
					case 5u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -1291798230;
							num4 = -1291798230;
						}
						else
						{
							num3 = -335331532;
							num4 = -335331532;
						}
						num = num3 ^ (int)(num2 * 1506600165);
						continue;
					}
					case 4u:
						num = (int)((num2 * 232866296) ^ 0x6F94FB97);
						continue;
					case 3u:
						result = resourceMan;
						num = 815418871;
						continue;
					case 0u:
					{
						ResourceManager resourceManager = (resourceMan = Led.smethod_2("Traffic_Simulation.Led", Led.smethod_1(Led.smethod_0(typeof(Led).TypeHandle))));
						num = ((int)num2 * -1708173915) ^ 0x66C7492F;
						continue;
					}
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
			return resourceCulture;
		}
		set
		{
			resourceCulture = value;
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
				int num = -1531965680;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDECD2D6Du) % 4u)
					{
					case 1u:
						obj = Led.smethod_3(ResourceManager, "Red1", resourceCulture);
						num = (int)(num2 * 395292676) ^ -684257295;
						continue;
					case 0u:
						result = (byte[])obj;
						num = ((int)num2 * -1884330234) ^ 0x4DC51437;
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
			int num = 1300634249;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6EDF9272u) % 3u)
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
				num = ((int)num2 * -456118245) ^ 0x37915271;
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
