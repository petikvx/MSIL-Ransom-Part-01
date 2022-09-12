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
				int num = 1177638870;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x533DB0BEu) % 9u)
					{
					case 8u:
						flag = resourceMan == null;
						num = ((int)num2 * -1072309791) ^ 0x490FBD68;
						continue;
					case 6u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 1637836159;
							num4 = 1637836159;
						}
						else
						{
							num3 = 1070144917;
							num4 = 1070144917;
						}
						num = num3 ^ (int)(num2 * 2088749666);
						continue;
					}
					case 5u:
						result = resourceMan;
						num = 1479444025;
						continue;
					case 3u:
						num = (int)((num2 * 586069726) ^ 0x37038A09);
						continue;
					case 2u:
						resourceManager = Veet.smethod_2("Cytotechnologist.Veet", Veet.smethod_1(Veet.smethod_0(typeof(Veet).TypeHandle)));
						num = (int)((num2 * 2028449309) ^ 0x55B29017);
						continue;
					case 1u:
						resourceMan = resourceManager;
						num = (int)((num2 * 267766056) ^ 0x5FF93ACE);
						continue;
					case 0u:
						num = (int)(num2 * 74685754) ^ -782654437;
						continue;
					case 7u:
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
				int num = 285027193;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7BD0CAA3u) % 4u)
					{
					case 2u:
						result = resourceCulture;
						num = ((int)num2 * -923204162) ^ 0x9CF3FAA;
						continue;
					case 1u:
						num = (int)(num2 * 1088409906) ^ -2050610727;
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
		set
		{
			while (true)
			{
				int num = 510300604;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7AA9F46Fu) % 3u)
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
					num = (int)((num2 * 738887462) ^ 0x1BA4FCB4);
				}
			}
		}
	}

	internal static string Sa
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = 1427899616;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x553999B7u) % 3u)
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
					result = Veet.smethod_3(ResourceManager, "Sa", resourceCulture);
					num = ((int)num2 * -284980034) ^ -1798623145;
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
				int num = -9214888;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9FFE5DB0u) % 3u)
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
					num = (int)((num2 * 990425905) ^ 0xD6F840E);
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
				int num = -20036856;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB55F63B5u) % 4u)
					{
					case 2u:
						num = ((int)num2 * -960542602) ^ -623926978;
						continue;
					case 1u:
						result = Veet.smethod_3(ResourceManager, "Zr", resourceCulture);
						num = (int)(num2 * 1190535636) ^ -56245409;
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
