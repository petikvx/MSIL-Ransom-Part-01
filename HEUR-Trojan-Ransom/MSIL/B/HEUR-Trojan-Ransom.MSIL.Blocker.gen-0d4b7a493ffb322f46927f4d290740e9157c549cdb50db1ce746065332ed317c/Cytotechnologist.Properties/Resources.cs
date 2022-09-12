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
			goto IL_0085;
			IL_0085:
			ResourceManager result = resourceMan;
			int num = -1288464672;
			goto IL_005c;
			IL_005c:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFBF9AC0Eu) % 6u)
				{
				case 5u:
					break;
				case 4u:
					num = (int)(num2 * 1772605918) ^ -1313984375;
					continue;
				case 3u:
				{
					ResourceManager resourceManager = (resourceMan = Resources.smethod_2("Cytotechnologist.Properties.Resources", Resources.smethod_1(Resources.smethod_0(typeof(Resources).TypeHandle))));
					num = ((int)num2 * -1353128946) ^ 0x501BB566;
					continue;
				}
				case 2u:
					num = ((int)num2 * -2059443272) ^ 0x4E1A6E33;
					continue;
				case 1u:
					goto IL_0085;
				default:
					return result;
				}
				break;
			}
			goto IL_000a;
			IL_000a:
			num = -1592841976;
			goto IL_005c;
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
				int num = 1353447327;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x49F5BAA2u) % 4u)
					{
					case 3u:
						num = (int)((num2 * 1782967066) ^ 0x1C9376EC);
						continue;
					case 1u:
						result = resourceCulture;
						num = ((int)num2 * -903907179) ^ 0x7A8FE0F0;
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

	internal static Bitmap ISoapMessa
	{
		get
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			object obj = Resources.smethod_3(ResourceManager, "ISoapMessa", resourceCulture);
			return (Bitmap)obj;
		}
	}

	internal Resources()
	{
		while (true)
		{
			int num = -565273735;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFFD85DC2u) % 3u)
				{
				case 1u:
					goto IL_0008;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0008:
				num = ((int)num2 * -2034120280) ^ -1886552195;
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
