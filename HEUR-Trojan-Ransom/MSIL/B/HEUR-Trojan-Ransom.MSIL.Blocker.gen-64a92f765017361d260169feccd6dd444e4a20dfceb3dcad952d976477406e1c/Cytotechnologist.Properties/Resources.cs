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
				goto IL_003b;
			}
			goto IL_0061;
			IL_0061:
			ResourceManager result = resourceMan;
			int num = -29658394;
			goto IL_0040;
			IL_0040:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD7B241F3u) % 4u)
				{
				case 3u:
				{
					ResourceManager resourceManager = (resourceMan = Resources.smethod_2("Cytotechnologist.Properties.Resources", Resources.smethod_1(Resources.smethod_0(typeof(Resources).TypeHandle))));
					num = ((int)num2 * -1529423275) ^ 0x7B3AFC8;
					continue;
				}
				case 2u:
					break;
				case 0u:
					goto IL_0061;
				default:
					return result;
				}
				break;
			}
			goto IL_003b;
			IL_003b:
			num = -763013768;
			goto IL_0040;
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
				int num = 1164259250;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x232D2203u) % 4u)
					{
					case 1u:
						result = resourceCulture;
						num = (int)((num2 * 610538264) ^ 0x9994593);
						continue;
					case 0u:
						num = ((int)num2 * -97019602) ^ 0x1A55C091;
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

	internal static Bitmap TokenizerStringBlo
	{
		get
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Expected O, but got Unknown
			Bitmap result = default(Bitmap);
			object obj = default(object);
			while (true)
			{
				int num = -542442176;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF46EDF97u) % 5u)
					{
					case 4u:
						result = (Bitmap)obj;
						num = (int)(num2 * 956562273) ^ -1786991422;
						continue;
					case 3u:
						obj = Resources.smethod_3(ResourceManager, "TokenizerStringBlo", resourceCulture);
						num = (int)((num2 * 2092748928) ^ 0x6982A1C6);
						continue;
					case 2u:
						num = ((int)num2 * -1168490941) ^ 0x25A9A830;
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
		while (true)
		{
			int num = 1189790915;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x208FCC56u) % 4u)
				{
				case 2u:
					num = ((int)num2 * -481581404) ^ -1440032902;
					continue;
				case 1u:
					num = ((int)num2 * -813647551) ^ -1891341267;
					continue;
				default:
					return;
				case 3u:
					break;
				case 0u:
					return;
				}
				break;
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
