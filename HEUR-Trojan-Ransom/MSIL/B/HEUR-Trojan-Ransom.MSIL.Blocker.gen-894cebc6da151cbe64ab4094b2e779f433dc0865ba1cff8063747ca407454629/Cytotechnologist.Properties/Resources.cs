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
			bool flag = default(bool);
			while (true)
			{
				int num = 855128486;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x408D4601u) % 9u)
					{
					case 8u:
						result = resourceMan;
						num = 953425496;
						continue;
					case 7u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 1923185180;
							num4 = 1923185180;
						}
						else
						{
							num3 = 1323621438;
							num4 = 1323621438;
						}
						num = num3 ^ ((int)num2 * -1462856851);
						continue;
					}
					case 6u:
						flag = resourceMan == null;
						num = (int)((num2 * 682184268) ^ 0x3EC7EB94);
						continue;
					case 5u:
						num = (int)(num2 * 1315318350) ^ -2016112833;
						continue;
					case 3u:
						num = (int)((num2 * 973986715) ^ 0x36AE9F98);
						continue;
					case 2u:
					{
						ResourceManager resourceManager = (resourceMan = Resources.smethod_2("Cytotechnologist.Properties.Resources", Resources.smethod_1(Resources.smethod_0(typeof(Resources).TypeHandle))));
						num = (int)((num2 * 400056564) ^ 0x276BDDAE);
						continue;
					}
					case 1u:
						num = (int)(num2 * 1179397939) ^ -2073279142;
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
			CultureInfo result = default(CultureInfo);
			while (true)
			{
				int num = 934071044;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5F708D62u) % 4u)
					{
					case 3u:
						num = (int)(num2 * 492254270) ^ -1148529255;
						continue;
					case 2u:
						result = resourceCulture;
						num = (int)(num2 * 1017515914) ^ -1016171575;
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

	internal static Bitmap AggregateExcepti
	{
		get
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			object obj = Resources.smethod_3(ResourceManager, "AggregateExcepti", resourceCulture);
			Bitmap result = (Bitmap)obj;
			while (true)
			{
				int num = -241745551;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8655700Au) % 3u)
					{
					case 2u:
						goto IL_001e;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_001e:
					num = (int)(num2 * 1570822584) ^ -2100648080;
				}
			}
		}
	}

	internal Resources()
	{
		while (true)
		{
			int num = 1238259139;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x54C6AF3Du) % 4u)
				{
				case 3u:
					num = ((int)num2 * -1725940570) ^ 0x6CF9ADF6;
					continue;
				case 2u:
					num = ((int)num2 * -1783893049) ^ -923338252;
					continue;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
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
