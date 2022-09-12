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
			ResourceManager resourceManager = default(ResourceManager);
			bool flag = default(bool);
			ResourceManager result = default(ResourceManager);
			while (true)
			{
				int num = -739463375;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC6C3575Fu) % 9u)
					{
					case 7u:
						resourceManager = Resources.smethod_2("Cytotechnologist.Properties.Resources", Resources.smethod_1(Resources.smethod_0(typeof(Resources).TypeHandle)));
						num = (int)((num2 * 1506361538) ^ 0x67B4581E);
						continue;
					case 6u:
						num = (int)((num2 * 2130496718) ^ 0x6AA820FB);
						continue;
					case 5u:
						resourceMan = resourceManager;
						num = ((int)num2 * -2004991011) ^ 0x58993D90;
						continue;
					case 3u:
						flag = resourceMan == null;
						num = (int)(num2 * 1390729885) ^ -949380802;
						continue;
					case 2u:
						result = resourceMan;
						num = -1736538302;
						continue;
					case 1u:
						num = ((int)num2 * -1482670178) ^ -1819256333;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 552973245;
							num4 = 552973245;
						}
						else
						{
							num3 = 437738847;
							num4 = 437738847;
						}
						num = num3 ^ (int)(num2 * 867261422);
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
			return resourceCulture;
		}
		set
		{
			while (true)
			{
				int num = 810510510;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x23DBFFFBu) % 3u)
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
					num = ((int)num2 * -1849319058) ^ 0x7D6D9DDF;
				}
			}
		}
	}

	internal static Bitmap AssemblyDelaySignAttribu
	{
		get
		{
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			object obj = Resources.smethod_3(ResourceManager, "AssemblyDelaySignAttribu", resourceCulture);
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = 961720710;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5F5A0FB7u) % 4u)
					{
					case 3u:
						num = ((int)num2 * -331021170) ^ 0x40D30805;
						continue;
					case 1u:
						result = (Bitmap)obj;
						num = ((int)num2 * -1087065545) ^ 0x123BC673;
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
