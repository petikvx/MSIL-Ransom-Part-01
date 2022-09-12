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
			ResourceManager resourceManager = default(ResourceManager);
			ResourceManager result = default(ResourceManager);
			while (true)
			{
				int num = 1507409570;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7B44C2CBu) % 9u)
					{
					case 8u:
						num = ((int)num2 * -1953342842) ^ 0x91D9B73;
						continue;
					case 7u:
						resourceMan = resourceManager;
						num = (int)(num2 * 1919317515) ^ -1105991264;
						continue;
					case 5u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 780159781;
							num4 = 780159781;
						}
						else
						{
							num3 = 891983464;
							num4 = 891983464;
						}
						num = num3 ^ ((int)num2 * -1907066267);
						continue;
					}
					case 4u:
						num = ((int)num2 * -463165972) ^ -1010524786;
						continue;
					case 3u:
						num = ((int)num2 * -36621259) ^ 0x397ADCD7;
						continue;
					case 1u:
						result = resourceMan;
						num = 419367528;
						continue;
					case 0u:
						resourceManager = Resources.smethod_2("Cytotechnologist.Properties.Resources", Resources.smethod_1(Resources.smethod_0(typeof(Resources).TypeHandle)));
						num = (int)(num2 * 731540504) ^ -890220539;
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			CultureInfo result = resourceCulture;
			while (true)
			{
				int num = -471464933;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA09C6BEAu) % 3u)
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
					num = ((int)num2 * -773902349) ^ 0x1162E00F;
				}
			}
		}
		set
		{
			while (true)
			{
				int num = 427997989;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9C38F49u) % 3u)
					{
					case 1u:
						goto IL_0003;
					default:
						return;
					case 2u:
						break;
					case 0u:
						return;
					}
					break;
					IL_0003:
					resourceCulture = value;
					num = ((int)num2 * -1769943862) ^ 0x70510F07;
				}
			}
		}
	}

	internal static Bitmap EtwSessi
	{
		get
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected O, but got Unknown
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = 1694836016;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1A64255u) % 4u)
					{
					case 3u:
						num = ((int)num2 * -949972903) ^ 0x677E6070;
						continue;
					case 1u:
					{
						object obj = Resources.smethod_3(ResourceManager, "EtwSessi", resourceCulture);
						result = (Bitmap)obj;
						num = (int)((num2 * 2092189687) ^ 0x1B36C9A1);
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
