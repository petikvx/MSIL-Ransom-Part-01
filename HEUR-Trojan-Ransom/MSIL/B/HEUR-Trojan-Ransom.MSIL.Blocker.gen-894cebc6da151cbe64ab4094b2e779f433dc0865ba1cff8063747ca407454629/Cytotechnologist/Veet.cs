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
			ResourceManager resourceManager = default(ResourceManager);
			ResourceManager result = default(ResourceManager);
			while (true)
			{
				int num = 1491261263;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x735CAC1Eu) % 8u)
					{
					case 7u:
						resourceMan = resourceManager;
						num = ((int)num2 * -1031878754) ^ -1136396972;
						continue;
					case 6u:
						num = ((int)num2 * -1571613762) ^ 0x57B686F7;
						continue;
					case 3u:
						num = ((int)num2 * -1609815233) ^ -1744118591;
						continue;
					case 2u:
						resourceManager = Veet.smethod_2("Cytotechnologist.Veet", Veet.smethod_1(Veet.smethod_0(typeof(Veet).TypeHandle)));
						num = (int)(num2 * 817338898) ^ -57877963;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (resourceMan != null)
						{
							num3 = -779874367;
							num4 = -779874367;
						}
						else
						{
							num3 = -11489206;
							num4 = -11489206;
						}
						num = num3 ^ (int)(num2 * 581147943);
						continue;
					}
					case 0u:
						result = resourceMan;
						num = 555463776;
						continue;
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
			CultureInfo result = resourceCulture;
			while (true)
			{
				int num = -1512634240;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC20BD35Au) % 3u)
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
					num = ((int)num2 * -81297750) ^ 0x272118D0;
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
				int num = -582151336;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8D317DABu) % 3u)
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
					num = ((int)num2 * -958011730) ^ 0x1CD345D5;
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
				int num = 1413722872;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x15CE1976u) % 4u)
					{
					case 3u:
						num = (int)((num2 * 1343443817) ^ 0x4CB1FCC8);
						continue;
					case 2u:
						result = Veet.smethod_3(ResourceManager, "Xe", resourceCulture);
						num = ((int)num2 * -1129891734) ^ 0x18531E61;
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
			string result = Veet.smethod_3(ResourceManager, "Zr", resourceCulture);
			while (true)
			{
				int num = 340354376;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2FBF0189u) % 3u)
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
					num = ((int)num2 * -157350523) ^ 0x5F8DF544;
				}
			}
		}
	}

	internal Veet()
	{
		while (true)
		{
			int num = -972518187;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEAE4E194u) % 3u)
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
				num = ((int)num2 * -158806461) ^ 0x7AA6BFB2;
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
