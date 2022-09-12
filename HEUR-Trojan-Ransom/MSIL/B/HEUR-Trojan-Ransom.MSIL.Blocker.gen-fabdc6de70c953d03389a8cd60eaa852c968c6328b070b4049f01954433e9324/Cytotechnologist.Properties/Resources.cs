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
			bool flag = default(bool);
			while (true)
			{
				int num = -728892070;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE5D3547Du) % 10u)
					{
					case 9u:
						num = (int)((num2 * 903136578) ^ 0x4A019D9F);
						continue;
					case 8u:
						result = resourceMan;
						num = -1113362661;
						continue;
					case 7u:
						resourceMan = resourceManager;
						num = ((int)num2 * -149091940) ^ -1599301638;
						continue;
					case 6u:
						num = ((int)num2 * -756623269) ^ -1133448375;
						continue;
					case 5u:
						num = (int)(num2 * 1246177072) ^ -1815071069;
						continue;
					case 2u:
						resourceManager = Resources.smethod_2("Cytotechnologist.Properties.Resources", Resources.smethod_1(Resources.smethod_0(typeof(Resources).TypeHandle)));
						num = (int)(num2 * 2129382964) ^ -418691956;
						continue;
					case 1u:
						flag = resourceMan == null;
						num = ((int)num2 * -1958923455) ^ 0x159DAC5C;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -470123917;
							num4 = -470123917;
						}
						else
						{
							num3 = -1330306058;
							num4 = -1330306058;
						}
						num = num3 ^ (int)(num2 * 461729056);
						continue;
					}
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
			return resourceCulture;
		}
		set
		{
			while (true)
			{
				int num = 360569988;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3EF2EB4Du) % 3u)
					{
					case 1u:
						goto IL_0003;
					default:
						return;
					case 0u:
						break;
					case 2u:
						return;
					}
					break;
					IL_0003:
					resourceCulture = value;
					num = ((int)num2 * -1004032121) ^ 0x4B25ABD3;
				}
			}
		}
	}

	internal static Bitmap FrameSecurityDescript
	{
		get
		{
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Expected O, but got Unknown
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = 1738984067;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x58DE7FB0u) % 4u)
					{
					case 3u:
					{
						object obj = Resources.smethod_3(ResourceManager, "FrameSecurityDescript", resourceCulture);
						result = (Bitmap)obj;
						num = (int)((num2 * 1083810771) ^ 0x52B9E599);
						continue;
					}
					case 0u:
						num = ((int)num2 * -1912542592) ^ 0x248459D1;
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
