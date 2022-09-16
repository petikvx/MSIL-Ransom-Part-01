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
			ResourceManager resourceManager = default(ResourceManager);
			while (true)
			{
				int num = -922248912;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE617BC04u) % 8u)
					{
					case 7u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 731784004;
							num4 = 731784004;
						}
						else
						{
							num3 = 526023989;
							num4 = 526023989;
						}
						num = num3 ^ (int)(num2 * 2021557509);
						continue;
					}
					case 4u:
						flag = resourceMan == null;
						num = (int)((num2 * 823861780) ^ 0x637455FB);
						continue;
					case 3u:
						result = resourceMan;
						num = -1441661340;
						continue;
					case 2u:
						resourceManager = Led.smethod_2("Traffic_Simulation.Led", Led.smethod_1(Led.smethod_0(typeof(Led).TypeHandle)));
						num = ((int)num2 * -124776484) ^ -1877511035;
						continue;
					case 1u:
						resourceMan = resourceManager;
						num = (int)(num2 * 1996927944) ^ -145441945;
						continue;
					case 0u:
						num = (int)(num2 * 132785189) ^ -1091522518;
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
				int num = 1454413541;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x31FC4A67u) % 4u)
					{
					case 3u:
						num = ((int)num2 * -213035728) ^ -1313834806;
						continue;
					case 2u:
						result = resourceCulture;
						num = (int)((num2 * 200968391) ^ 0x3D741FBA);
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
		set
		{
			resourceCulture = value;
		}
	}

	internal static byte[] Red1
	{
		get
		{
			byte[] result = default(byte[]);
			object obj = default(object);
			while (true)
			{
				int num = -1164107249;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC95600D6u) % 4u)
					{
					case 2u:
						result = (byte[])obj;
						num = (int)(num2 * 798828878) ^ -42971271;
						continue;
					case 1u:
						obj = Led.smethod_3(ResourceManager, "Red1", resourceCulture);
						num = (int)(num2 * 942464160) ^ -1558673296;
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

	internal Led()
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

	static object smethod_3(ResourceManager resourceManager_0, string string_0, CultureInfo cultureInfo_0)
	{
		return resourceManager_0.GetObject(string_0, cultureInfo_0);
	}
}
