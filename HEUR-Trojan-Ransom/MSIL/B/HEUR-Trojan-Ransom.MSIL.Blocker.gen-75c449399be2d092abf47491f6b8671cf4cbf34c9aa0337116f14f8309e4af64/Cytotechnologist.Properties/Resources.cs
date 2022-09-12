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
				goto IL_0059;
			}
			goto IL_0087;
			IL_0087:
			ResourceManager result = resourceMan;
			int num = 302817110;
			goto IL_005e;
			IL_005e:
			ResourceManager resourceManager = default(ResourceManager);
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCD1BA2Du) % 6u)
				{
				case 5u:
					resourceMan = resourceManager;
					num = ((int)num2 * -1039833597) ^ 0xB356673;
					continue;
				case 4u:
					resourceManager = Resources.smethod_2("Cytotechnologist.Properties.Resources", Resources.smethod_1(Resources.smethod_0(typeof(Resources).TypeHandle)));
					num = (int)((num2 * 1553632592) ^ 0x997E93E);
					continue;
				case 2u:
					num = (int)((num2 * 376587699) ^ 0x5DD66A6D);
					continue;
				case 0u:
					break;
				case 1u:
					goto IL_0087;
				default:
					return result;
				}
				break;
			}
			goto IL_0059;
			IL_0059:
			num = 1522323289;
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
				int num = 1613206925;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x46A89AD4u) % 4u)
					{
					case 2u:
						num = (int)(num2 * 1594408152) ^ -900643564;
						continue;
					case 1u:
						result = resourceCulture;
						num = (int)((num2 * 1806086029) ^ 0x4F3DD54F);
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
			while (true)
			{
				int num = 1113478675;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3B411213u) % 3u)
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
					num = (int)(num2 * 535120652) ^ -2130131526;
				}
			}
		}
	}

	internal static Bitmap IntrospectiveSortUtiliti
	{
		get
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Expected O, but got Unknown
			Bitmap result = default(Bitmap);
			object obj = default(object);
			while (true)
			{
				int num = 905388865;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6E429EBBu) % 5u)
					{
					case 4u:
						result = (Bitmap)obj;
						num = (int)((num2 * 1315063832) ^ 0x65D0F564);
						continue;
					case 3u:
						num = (int)((num2 * 51722775) ^ 0x3D63C803);
						continue;
					case 1u:
						obj = Resources.smethod_3(ResourceManager, "IntrospectiveSortUtiliti", resourceCulture);
						num = ((int)num2 * -678067028) ^ -964219395;
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
		while (true)
		{
			int num = -1089783808;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD3F87D1Cu) % 3u)
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
				num = ((int)num2 * -2138480238) ^ -890688445;
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
