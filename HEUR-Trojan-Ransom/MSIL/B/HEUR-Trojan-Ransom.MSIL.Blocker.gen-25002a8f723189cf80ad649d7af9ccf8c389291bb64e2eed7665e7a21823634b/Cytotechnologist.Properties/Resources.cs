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
			if (resourceMan == null)
			{
				goto IL_001b;
			}
			goto IL_0074;
			IL_0074:
			ResourceManager result = resourceMan;
			int num = -1412275065;
			goto IL_004f;
			IL_004f:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE45DA9ABu) % 5u)
				{
				case 3u:
					num = (int)(num2 * 495081553) ^ -1800171538;
					continue;
				case 2u:
					break;
				case 0u:
				{
					ResourceManager resourceManager = (resourceMan = Resources.smethod_2("Cytotechnologist.Properties.Resources", Resources.smethod_1(Resources.smethod_0(typeof(Resources).TypeHandle))));
					num = (int)((num2 * 1247301860) ^ 0x1E35E151);
					continue;
				}
				case 4u:
					goto IL_0074;
				default:
					return result;
				}
				break;
			}
			goto IL_001b;
			IL_001b:
			num = -717800326;
			goto IL_004f;
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
				int num = -794308734;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEE1DE9AAu) % 3u)
					{
					case 2u:
						goto IL_0003;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0003:
					result = resourceCulture;
					num = (int)(num2 * 1686676247) ^ -1009855722;
				}
			}
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static Bitmap PM
	{
		get
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected O, but got Unknown
			object obj = Resources.smethod_3(ResourceManager, "PM", resourceCulture);
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = -147818070;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x81B100CFu) % 3u)
					{
					case 1u:
						goto IL_0017;
					case 2u:
						break;
					default:
						return result;
					}
					break;
					IL_0017:
					result = (Bitmap)obj;
					num = (int)(num2 * 1160559068) ^ -89272774;
				}
			}
		}
	}

	internal Resources()
	{
		while (true)
		{
			int num = -358682007;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBC425169u) % 3u)
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
				num = ((int)num2 * -1054573841) ^ -1912784060;
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
