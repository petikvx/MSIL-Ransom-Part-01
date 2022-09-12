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
				goto IL_000a;
			}
			goto IL_0072;
			IL_0072:
			ResourceManager result = resourceMan;
			int num = 189573527;
			goto IL_004d;
			IL_004d:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x626704B1u) % 5u)
				{
				case 3u:
					break;
				case 2u:
					num = ((int)num2 * -1979237826) ^ 0x329860FD;
					continue;
				case 1u:
				{
					ResourceManager resourceManager = (resourceMan = Resources.smethod_2("Cytotechnologist.Properties.Resources", Resources.smethod_1(Resources.smethod_0(typeof(Resources).TypeHandle))));
					num = (int)(num2 * 1753200414) ^ -1313040242;
					continue;
				}
				case 0u:
					goto IL_0072;
				default:
					return result;
				}
				break;
			}
			goto IL_000a;
			IL_000a:
			num = 582506860;
			goto IL_004d;
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
				int num = -1279559795;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x81D919D0u) % 4u)
					{
					case 1u:
						result = resourceCulture;
						num = (int)(num2 * 1140951095) ^ -737798361;
						continue;
					case 0u:
						num = (int)(num2 * 331877804) ^ -1823513470;
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
		set
		{
			resourceCulture = value;
		}
	}

	internal static Bitmap TaskExceptionHold
	{
		get
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected O, but got Unknown
			object obj = Resources.smethod_3(ResourceManager, "TaskExceptionHold", resourceCulture);
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = 2015623603;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6A8C0436u) % 4u)
					{
					case 1u:
						result = (Bitmap)obj;
						num = (int)((num2 * 1489700260) ^ 0x645CFB2A);
						continue;
					case 0u:
						num = ((int)num2 * -1270319687) ^ 0x44781B14;
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
		while (true)
		{
			int num = 1582451255;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x490519D6u) % 3u)
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
				num = ((int)num2 * -1008809428) ^ 0x533618A1;
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
