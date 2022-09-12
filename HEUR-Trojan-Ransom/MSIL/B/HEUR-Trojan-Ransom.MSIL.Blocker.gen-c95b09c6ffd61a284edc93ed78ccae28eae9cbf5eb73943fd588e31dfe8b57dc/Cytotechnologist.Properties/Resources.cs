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
				int num = 575984103;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x45396B0Du) % 9u)
					{
					case 8u:
						flag = resourceMan == null;
						num = (int)(num2 * 586434180) ^ -228620464;
						continue;
					case 7u:
						num = ((int)num2 * -2018885346) ^ 0x1B3AC8CA;
						continue;
					case 6u:
						num = ((int)num2 * -1926442183) ^ 0x74DE7424;
						continue;
					case 5u:
						resourceMan = resourceManager;
						num = ((int)num2 * -1089583963) ^ 0x71338966;
						continue;
					case 4u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -1338544352;
							num4 = -1338544352;
						}
						else
						{
							num3 = -171656168;
							num4 = -171656168;
						}
						num = num3 ^ (int)(num2 * 1881368723);
						continue;
					}
					case 2u:
						resourceManager = Resources.smethod_2("Cytotechnologist.Properties.Resources", Resources.smethod_1(Resources.smethod_0(typeof(Resources).TypeHandle)));
						num = ((int)num2 * -121367724) ^ -1001506343;
						continue;
					case 1u:
						result = resourceMan;
						num = 2094784281;
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
			return resourceCulture;
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static Bitmap OperatingSyst
	{
		get
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			object obj = Resources.smethod_3(ResourceManager, "OperatingSyst", resourceCulture);
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
