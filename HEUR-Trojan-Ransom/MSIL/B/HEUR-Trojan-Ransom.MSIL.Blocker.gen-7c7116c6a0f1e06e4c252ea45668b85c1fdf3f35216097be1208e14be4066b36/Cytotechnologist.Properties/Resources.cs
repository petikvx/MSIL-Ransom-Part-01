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
				int num = -1414709624;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA83B041Au) % 8u)
					{
					case 7u:
						num = (int)(num2 * 889769997) ^ -1391669204;
						continue;
					case 6u:
						resourceManager = Resources.smethod_2("Cytotechnologist.Properties.Resources", Resources.smethod_1(Resources.smethod_0(typeof(Resources).TypeHandle)));
						num = ((int)num2 * -2103057590) ^ -1372159718;
						continue;
					case 4u:
						resourceMan = resourceManager;
						num = (int)(num2 * 437821073) ^ -1561411545;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 511158899;
							num4 = 511158899;
						}
						else
						{
							num3 = 374752132;
							num4 = 374752132;
						}
						num = num3 ^ (int)(num2 * 103205528);
						continue;
					}
					case 2u:
						flag = resourceMan == null;
						num = ((int)num2 * -1218392500) ^ -792658687;
						continue;
					case 1u:
						result = resourceMan;
						num = -680797203;
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
			CultureInfo result = resourceCulture;
			while (true)
			{
				int num = 684233445;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7B715583u) % 3u)
					{
					case 2u:
						goto IL_0008;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0008:
					num = ((int)num2 * -1866266166) ^ -896185498;
				}
			}
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static Bitmap LIBFLA
	{
		get
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected O, but got Unknown
			object obj = default(object);
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = 698204435;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4638F842u) % 4u)
					{
					case 1u:
						obj = Resources.smethod_3(ResourceManager, "LIBFLA", resourceCulture);
						num = (int)(num2 * 478326074) ^ -1410798988;
						continue;
					case 0u:
						result = (Bitmap)obj;
						num = (int)((num2 * 563138585) ^ 0x6473E810);
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
