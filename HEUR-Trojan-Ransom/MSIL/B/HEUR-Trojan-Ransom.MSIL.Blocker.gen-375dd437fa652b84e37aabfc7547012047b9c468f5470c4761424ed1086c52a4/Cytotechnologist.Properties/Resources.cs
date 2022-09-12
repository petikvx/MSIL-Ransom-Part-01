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
			goto IL_0087;
			IL_0087:
			ResourceManager result = resourceMan;
			int num = -179435068;
			goto IL_005e;
			IL_005e:
			ResourceManager resourceManager = default(ResourceManager);
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEC636B65u) % 6u)
				{
				case 5u:
					num = ((int)num2 * -743732251) ^ 0x6737AC52;
					continue;
				case 3u:
					break;
				case 2u:
					resourceManager = Resources.smethod_2("Cytotechnologist.Properties.Resources", Resources.smethod_1(Resources.smethod_0(typeof(Resources).TypeHandle)));
					num = (int)(num2 * 919280894) ^ -165147130;
					continue;
				case 1u:
					resourceMan = resourceManager;
					num = (int)(num2 * 1365016821) ^ -1578571512;
					continue;
				case 0u:
					goto IL_0087;
				default:
					return result;
				}
				break;
			}
			goto IL_001b;
			IL_001b:
			num = -1128354957;
			goto IL_005e;
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
				int num = 1337808985;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4CDD5613u) % 4u)
					{
					case 2u:
						result = resourceCulture;
						num = ((int)num2 * -1487252603) ^ 0x5C47C7E0;
						continue;
					case 1u:
						num = ((int)num2 * -967917376) ^ 0x7BA51BD8;
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
			while (true)
			{
				int num = 1134054154;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7772BBE8u) % 3u)
					{
					case 2u:
						goto IL_0003;
					default:
						return;
					case 0u:
						break;
					case 1u:
						return;
					}
					break;
					IL_0003:
					resourceCulture = value;
					num = (int)((num2 * 1730380947) ^ 0x400E0154);
				}
			}
		}
	}

	internal static Bitmap FixedSizeLi
	{
		get
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Expected O, but got Unknown
			Bitmap result = default(Bitmap);
			object obj = default(object);
			while (true)
			{
				int num = -129153723;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD77957B5u) % 5u)
					{
					case 3u:
						result = (Bitmap)obj;
						num = (int)((num2 * 2005654202) ^ 0x5FF92126);
						continue;
					case 2u:
						obj = Resources.smethod_3(ResourceManager, "FixedSizeLi", resourceCulture);
						num = (int)(num2 * 1539907516) ^ -973292981;
						continue;
					case 1u:
						num = (int)((num2 * 2014975684) ^ 0x529C968B);
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
