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
			ResourceManager resourceManager = default(ResourceManager);
			while (true)
			{
				int num = -1971732121;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x832E7548u) % 8u)
					{
					case 7u:
					{
						int num3;
						int num4;
						if (resourceMan != null)
						{
							num3 = 2145533686;
							num4 = 2145533686;
						}
						else
						{
							num3 = 252939883;
							num4 = 252939883;
						}
						num = num3 ^ (int)(num2 * 674214136);
						continue;
					}
					case 6u:
						result = resourceMan;
						num = -1387301334;
						continue;
					case 5u:
						resourceManager = Resources.smethod_2("Cytotechnologist.Properties.Resources", Resources.smethod_1(Resources.smethod_0(typeof(Resources).TypeHandle)));
						num = ((int)num2 * -308144292) ^ -1773518451;
						continue;
					case 3u:
						num = (int)((num2 * 1393840922) ^ 0x4A622EFB);
						continue;
					case 2u:
						num = (int)(num2 * 1892123397) ^ -1081018922;
						continue;
					case 1u:
						resourceMan = resourceManager;
						num = (int)((num2 * 1287624535) ^ 0x6C574551);
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
			CultureInfo result = resourceCulture;
			while (true)
			{
				int num = -1199998097;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF53EC9C8u) % 3u)
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
					num = ((int)num2 * -1574740170) ^ -465967534;
				}
			}
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static Bitmap DateTimeKi
	{
		get
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			object obj = Resources.smethod_3(ResourceManager, "DateTimeKi", resourceCulture);
			return (Bitmap)obj;
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
