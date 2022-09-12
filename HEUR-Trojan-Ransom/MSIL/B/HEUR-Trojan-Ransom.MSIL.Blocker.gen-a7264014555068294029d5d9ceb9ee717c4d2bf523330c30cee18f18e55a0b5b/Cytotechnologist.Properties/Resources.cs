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
				int num = -2002793072;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8C57CE8Cu) % 7u)
					{
					case 4u:
						num = (int)(num2 * 33650333) ^ -651887035;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 1810110933;
							num4 = 1810110933;
						}
						else
						{
							num3 = 1008392646;
							num4 = 1008392646;
						}
						num = num3 ^ ((int)num2 * -2074775557);
						continue;
					}
					case 2u:
					{
						ResourceManager resourceManager = (resourceMan = Resources.smethod_2("Cytotechnologist.Properties.Resources", Resources.smethod_1(Resources.smethod_0(typeof(Resources).TypeHandle))));
						num = ((int)num2 * -1838072570) ^ 0x7AF9C110;
						continue;
					}
					case 1u:
						num = ((int)num2 * -12372051) ^ 0x642E237E;
						continue;
					case 0u:
						result = resourceMan;
						num = -1986911811;
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
				int num = -1677163470;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA1072B95u) % 3u)
					{
					case 1u:
						goto IL_0003;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0003:
					result = resourceCulture;
					num = ((int)num2 * -1138775469) ^ -659080138;
				}
			}
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static Bitmap TaskWrapperAsyncResu
	{
		get
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected O, but got Unknown
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = 1440641575;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x37FE7569u) % 4u)
					{
					case 3u:
						num = (int)(num2 * 1736025377) ^ -511504329;
						continue;
					case 2u:
					{
						object obj = Resources.smethod_3(ResourceManager, "TaskWrapperAsyncResu", resourceCulture);
						result = (Bitmap)obj;
						num = (int)((num2 * 1998885341) ^ 0x3A4E4DE4);
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
			int num = -1472482295;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAECE4C53u) % 3u)
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
				num = (int)((num2 * 921569836) ^ 0x383DBC72);
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
