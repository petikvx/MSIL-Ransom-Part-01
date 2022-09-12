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
				goto IL_007a;
			}
			goto IL_00b0;
			IL_00b0:
			ResourceManager result = resourceMan;
			int num = 448270390;
			goto IL_007f;
			IL_007f:
			ResourceManager resourceManager = default(ResourceManager);
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x37B68339u) % 8u)
				{
				case 7u:
					num = (int)((num2 * 1351461268) ^ 0x5E291EE6);
					continue;
				case 6u:
					resourceMan = resourceManager;
					num = (int)((num2 * 1468366877) ^ 0x6561ADDE);
					continue;
				case 4u:
					resourceManager = Resources.smethod_2("Cytotechnologist.Properties.Resources", Resources.smethod_1(Resources.smethod_0(typeof(Resources).TypeHandle)));
					num = ((int)num2 * -944115628) ^ 0x7B7D8847;
					continue;
				case 2u:
					num = (int)((num2 * 1255408296) ^ 0x41391CD);
					continue;
				case 1u:
					num = (int)((num2 * 2104464296) ^ 0x3A6C3D9C);
					continue;
				case 0u:
					break;
				case 5u:
					goto IL_00b0;
				default:
					return result;
				}
				break;
			}
			goto IL_007a;
			IL_007a:
			num = 354900995;
			goto IL_007f;
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
				int num = -802152642;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD4C63164u) % 4u)
					{
					case 2u:
						result = resourceCulture;
						num = ((int)num2 * -598622012) ^ -1587247307;
						continue;
					case 1u:
						num = (int)(num2 * 653195193) ^ -1468367351;
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
				int num = -1388069106;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8DA80607u) % 3u)
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
					num = (int)(num2 * 1305827526) ^ -1162048095;
				}
			}
		}
	}

	internal static Bitmap DeserializationEventHandl
	{
		get
		{
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Expected O, but got Unknown
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = 1712611498;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8DEB336u) % 3u)
					{
					case 1u:
						goto IL_0003;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0003:
					object obj = Resources.smethod_3(ResourceManager, "DeserializationEventHandl", resourceCulture);
					result = (Bitmap)obj;
					num = (int)((num2 * 178278057) ^ 0x596EA83D);
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
