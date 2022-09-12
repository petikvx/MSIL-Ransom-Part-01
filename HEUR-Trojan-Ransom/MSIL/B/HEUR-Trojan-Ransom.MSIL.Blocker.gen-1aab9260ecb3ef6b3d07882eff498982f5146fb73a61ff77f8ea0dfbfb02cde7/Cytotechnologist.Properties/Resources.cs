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
			ResourceManager resourceManager = default(ResourceManager);
			while (true)
			{
				int num = 569882549;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAE0D4C9u) % 8u)
					{
					case 7u:
						num = (int)(num2 * 1322271354) ^ -224854262;
						continue;
					case 6u:
						result = resourceMan;
						num = 450887942;
						continue;
					case 4u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -92534945;
							num4 = -92534945;
						}
						else
						{
							num3 = -1520955672;
							num4 = -1520955672;
						}
						num = num3 ^ ((int)num2 * -1938547034);
						continue;
					}
					case 3u:
						num = (int)((num2 * 1232909792) ^ 0x30E32697);
						continue;
					case 2u:
						resourceMan = resourceManager;
						num = ((int)num2 * -600236165) ^ -592309204;
						continue;
					case 1u:
						resourceManager = Resources.smethod_2("Cytotechnologist.Properties.Resources", Resources.smethod_1(Resources.smethod_0(typeof(Resources).TypeHandle)));
						num = ((int)num2 * -177688845) ^ -729499232;
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
				int num = 1593701043;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x48A42746u) % 4u)
					{
					case 1u:
						result = resourceCulture;
						num = ((int)num2 * -1960067295) ^ -89757545;
						continue;
					case 0u:
						num = (int)((num2 * 1848835915) ^ 0x28FA090D);
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
		set
		{
			resourceCulture = value;
		}
	}

	internal static Bitmap EastAsianLunisolarCalend
	{
		get
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected O, but got Unknown
			object obj = Resources.smethod_3(ResourceManager, "EastAsianLunisolarCalend", resourceCulture);
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = -1984902493;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x93691F75u) % 4u)
					{
					case 2u:
						result = (Bitmap)obj;
						num = (int)((num2 * 1477086073) ^ 0x6CFABA6E);
						continue;
					case 1u:
						num = ((int)num2 * -1512809508) ^ -1646324043;
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
