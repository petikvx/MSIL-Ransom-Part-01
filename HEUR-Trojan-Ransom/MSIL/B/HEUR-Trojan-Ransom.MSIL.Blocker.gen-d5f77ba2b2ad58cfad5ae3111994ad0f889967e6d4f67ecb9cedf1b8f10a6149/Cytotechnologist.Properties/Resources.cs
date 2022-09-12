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
			ResourceManager resourceManager = default(ResourceManager);
			while (true)
			{
				int num = -1350632984;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC069D475u) % 9u)
					{
					case 8u:
						num = ((int)num2 * -1014944107) ^ -47392830;
						continue;
					case 7u:
						result = resourceMan;
						num = -1648539806;
						continue;
					case 6u:
						flag = resourceMan == null;
						num = ((int)num2 * -237036851) ^ 0x5DCFA1CC;
						continue;
					case 5u:
						resourceManager = Resources.smethod_2("Cytotechnologist.Properties.Resources", Resources.smethod_1(Resources.smethod_0(typeof(Resources).TypeHandle)));
						num = ((int)num2 * -930497270) ^ 0x6BB940A8;
						continue;
					case 4u:
						resourceMan = resourceManager;
						num = ((int)num2 * -1460864939) ^ -2879714;
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -1023147068;
							num4 = -1023147068;
						}
						else
						{
							num3 = -1759568765;
							num4 = -1759568765;
						}
						num = num3 ^ (int)(num2 * 30105180);
						continue;
					}
					case 1u:
						num = ((int)num2 * -1887689530) ^ 0x1B509F0A;
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
				int num = 427449843;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7457F4EEu) % 3u)
					{
					case 1u:
						goto IL_0008;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0008:
					num = (int)(num2 * 607878572) ^ -963296626;
				}
			}
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static Bitmap CompleteOnCountdownPromi
	{
		get
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected O, but got Unknown
			object obj = Resources.smethod_3(ResourceManager, "CompleteOnCountdownPromi", resourceCulture);
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = -373420294;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF10C2D09u) % 4u)
					{
					case 3u:
						result = (Bitmap)obj;
						num = (int)(num2 * 1371045677) ^ -527873133;
						continue;
					case 1u:
						num = ((int)num2 * -516800912) ^ 0x5977A66B;
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
