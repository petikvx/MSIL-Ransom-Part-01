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
			ResourceManager resourceManager = default(ResourceManager);
			ResourceManager result = default(ResourceManager);
			while (true)
			{
				int num = -1731603918;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF5C3348Fu) % 9u)
					{
					case 8u:
						num = (int)(num2 * 1160836742) ^ -2099080037;
						continue;
					case 7u:
						num = ((int)num2 * -778256244) ^ -203000071;
						continue;
					case 5u:
						resourceManager = Veet.smethod_2("Cytotechnologist.Veet", Veet.smethod_1(Veet.smethod_0(typeof(Veet).TypeHandle)));
						num = (int)(num2 * 21045175) ^ -615171996;
						continue;
					case 4u:
						resourceMan = resourceManager;
						num = ((int)num2 * -1774512728) ^ -2056848453;
						continue;
					case 3u:
						num = ((int)num2 * -1170664863) ^ -2123373102;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 1582240283;
							num4 = 1582240283;
						}
						else
						{
							num3 = 1642631042;
							num4 = 1642631042;
						}
						num = num3 ^ ((int)num2 * -1968474214);
						continue;
					}
					case 0u:
						result = resourceMan;
						num = -10490471;
						continue;
					case 6u:
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
				int num = 941152010;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD570254u) % 3u)
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
					num = ((int)num2 * -608511126) ^ -460373496;
				}
			}
		}
		set
		{
			while (true)
			{
				int num = -1620115737;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF7C28AC8u) % 3u)
					{
					case 1u:
						goto IL_0003;
					default:
						return;
					case 0u:
						break;
					case 2u:
						return;
					}
					break;
					IL_0003:
					resourceCulture = value;
					num = ((int)num2 * -1285158010) ^ -1819655402;
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
				int num = -555726337;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCA7B5242u) % 3u)
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
					num = ((int)num2 * -726263967) ^ 0x700CE343;
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
				int num = 1215195904;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1B4EBFE5u) % 3u)
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
					result = Veet.smethod_3(ResourceManager, "Xe", resourceCulture);
					num = ((int)num2 * -2048372891) ^ -24008811;
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
				int num = -957188465;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBF82E0F2u) % 4u)
					{
					case 3u:
						num = (int)(num2 * 615513579) ^ -1705789161;
						continue;
					case 1u:
						result = Veet.smethod_3(ResourceManager, "Zr", resourceCulture);
						num = ((int)num2 * -743511081) ^ 0x7CE776A2;
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
