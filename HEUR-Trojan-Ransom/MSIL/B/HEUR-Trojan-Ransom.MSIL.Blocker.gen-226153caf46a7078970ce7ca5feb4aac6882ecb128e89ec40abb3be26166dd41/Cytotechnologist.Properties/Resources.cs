using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Cytotechnologist.Properties;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal class Resources
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			ResourceManager result = default(ResourceManager);
			while (true)
			{
				int num = -1206619191;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA47A9DBEu) % 8u)
					{
					case 7u:
					{
						int num3;
						int num4;
						if (resourceMan != null)
						{
							num3 = -571612181;
							num4 = -571612181;
						}
						else
						{
							num3 = -142674598;
							num4 = -142674598;
						}
						num = num3 ^ ((int)num2 * -1410762068);
						continue;
					}
					case 5u:
						num = (int)(num2 * 1520821136) ^ -350743857;
						continue;
					case 4u:
						num = (int)(num2 * 1236333333) ^ -811819724;
						continue;
					case 2u:
					{
						ResourceManager resourceManager = (resourceMan = Resources.smethod_2("Cytotechnologist.Properties.Resources", Resources.smethod_1(Resources.smethod_0(typeof(Resources).TypeHandle))));
						num = ((int)num2 * -1774135184) ^ 0x585B996B;
						continue;
					}
					case 1u:
						result = resourceMan;
						num = -2033159534;
						continue;
					case 0u:
						num = ((int)num2 * -137972425) ^ -1632739060;
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			CultureInfo result = default(CultureInfo);
			while (true)
			{
				int num = -469033248;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD07D97EFu) % 4u)
					{
					case 3u:
						result = resourceCulture;
						num = (int)(num2 * 776828805) ^ -431779983;
						continue;
					case 1u:
						num = (int)(num2 * 1523274152) ^ -2030172911;
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

	internal static Bitmap ConsoleCancelEventHandl
	{
		get
		{
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Expected O, but got Unknown
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = 526923416;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2DF8627u) % 4u)
					{
					case 3u:
					{
						object obj = Resources.smethod_3(ResourceManager, "ConsoleCancelEventHandl", resourceCulture);
						result = (Bitmap)obj;
						num = (int)(num2 * 690853189) ^ -1008317624;
						continue;
					}
					case 0u:
						num = ((int)num2 * -1705426075) ^ -715208582;
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

	internal Resources()
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
