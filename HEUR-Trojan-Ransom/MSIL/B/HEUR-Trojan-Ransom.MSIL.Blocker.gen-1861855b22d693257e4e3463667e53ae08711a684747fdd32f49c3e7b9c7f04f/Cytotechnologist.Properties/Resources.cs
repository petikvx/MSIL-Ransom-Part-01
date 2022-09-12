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
			bool flag = resourceMan == null;
			ResourceManager result = default(ResourceManager);
			while (true)
			{
				int num = -2125007605;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF9923C52u) % 8u)
					{
					case 7u:
						result = resourceMan;
						num = -873101175;
						continue;
					case 6u:
						num = ((int)num2 * -234216689) ^ 0x30953D7;
						continue;
					case 5u:
					{
						ResourceManager resourceManager = (resourceMan = Resources.smethod_2("Cytotechnologist.Properties.Resources", Resources.smethod_1(Resources.smethod_0(typeof(Resources).TypeHandle))));
						num = (int)(num2 * 1911433013) ^ -2133131075;
						continue;
					}
					case 3u:
						num = ((int)num2 * -795614319) ^ -356930207;
						continue;
					case 2u:
						num = ((int)num2 * -1588391895) ^ 0x4AB8B515;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 364758567;
							num4 = 364758567;
						}
						else
						{
							num3 = 20319530;
							num4 = 20319530;
						}
						num = num3 ^ (int)(num2 * 1825862943);
						continue;
					}
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
				int num = -360518550;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD2742F51u) % 3u)
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
					num = (int)(num2 * 2015503661) ^ -763401608;
				}
			}
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static Bitmap StaticArrayInitTypeSize40
	{
		get
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected O, but got Unknown
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = -1762170456;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8FA02FBDu) % 4u)
					{
					case 3u:
						num = (int)(num2 * 731837801) ^ -1166249044;
						continue;
					case 1u:
					{
						object obj = Resources.smethod_3(ResourceManager, "StaticArrayInitTypeSize40", resourceCulture);
						result = (Bitmap)obj;
						num = ((int)num2 * -1384042297) ^ 0x53E4E149;
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
		while (true)
		{
			int num = -2104089933;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF1513309u) % 3u)
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
				num = ((int)num2 * -249377777) ^ 0x1F7BEA21;
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
