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
			bool flag = default(bool);
			ResourceManager resourceManager = default(ResourceManager);
			ResourceManager result = default(ResourceManager);
			while (true)
			{
				int num = -1561567767;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA0271197u) % 9u)
					{
					case 8u:
						flag = resourceMan == null;
						num = ((int)num2 * -378962096) ^ 0x69C1D755;
						continue;
					case 7u:
						resourceManager = Resources.smethod_2("Cytotechnologist.Properties.Resources", Resources.smethod_1(Resources.smethod_0(typeof(Resources).TypeHandle)));
						num = (int)(num2 * 463393136) ^ -840578868;
						continue;
					case 4u:
						num = (int)((num2 * 1204303121) ^ 0x42725878);
						continue;
					case 3u:
						result = resourceMan;
						num = -2121597308;
						continue;
					case 2u:
						resourceMan = resourceManager;
						num = (int)(num2 * 1006635315) ^ -807379835;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -1799543553;
							num4 = -1799543553;
						}
						else
						{
							num3 = -1496769283;
							num4 = -1496769283;
						}
						num = num3 ^ (int)(num2 * 427101130);
						continue;
					}
					case 0u:
						num = ((int)num2 * -1010685546) ^ 0x469C7ED0;
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
				int num = 288366836;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5632727Fu) % 4u)
					{
					case 3u:
						result = resourceCulture;
						num = (int)(num2 * 1061364266) ^ -1769350109;
						continue;
					case 2u:
						num = (int)((num2 * 110077024) ^ 0x1A6E47E);
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

	internal static Bitmap CallConte
	{
		get
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected O, but got Unknown
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = -829153288;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF0290FE6u) % 4u)
					{
					case 3u:
						num = ((int)num2 * -99226229) ^ -133394874;
						continue;
					case 2u:
					{
						object obj = Resources.smethod_3(ResourceManager, "CallConte", resourceCulture);
						result = (Bitmap)obj;
						num = (int)(num2 * 1299957820) ^ -633988791;
						continue;
					}
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
