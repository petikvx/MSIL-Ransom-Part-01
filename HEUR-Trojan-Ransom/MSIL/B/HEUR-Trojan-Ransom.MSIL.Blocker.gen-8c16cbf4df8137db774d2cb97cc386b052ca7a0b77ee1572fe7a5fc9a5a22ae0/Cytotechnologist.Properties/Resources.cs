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
			bool flag = default(bool);
			ResourceManager result = default(ResourceManager);
			while (true)
			{
				int num = -1133447531;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEBCD4F19u) % 8u)
					{
					case 7u:
						num = ((int)num2 * -1704943531) ^ -391680615;
						continue;
					case 5u:
						num = (int)((num2 * 1611596629) ^ 0x520E0851);
						continue;
					case 4u:
						flag = resourceMan == null;
						num = ((int)num2 * -1616182466) ^ -669791461;
						continue;
					case 3u:
					{
						ResourceManager resourceManager = (resourceMan = Resources.smethod_2("Cytotechnologist.Properties.Resources", Resources.smethod_1(Resources.smethod_0(typeof(Resources).TypeHandle))));
						num = ((int)num2 * -1039014089) ^ -143098727;
						continue;
					}
					case 2u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 1310815846;
							num4 = 1310815846;
						}
						else
						{
							num3 = 1120278416;
							num4 = 1120278416;
						}
						num = num3 ^ (int)(num2 * 1202375183);
						continue;
					}
					case 1u:
						result = resourceMan;
						num = -1362011265;
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
				int num = 1611875986;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4E13A867u) % 3u)
					{
					case 1u:
						goto IL_0008;
					case 2u:
						break;
					default:
						return result;
					}
					break;
					IL_0008:
					num = ((int)num2 * -239399224) ^ 0x10948B80;
				}
			}
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static Bitmap GetEnumeratord
	{
		get
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			object obj = Resources.smethod_3(ResourceManager, "GetEnumeratord", resourceCulture);
			return (Bitmap)obj;
		}
	}

	internal Resources()
	{
		while (true)
		{
			int num = -1108329873;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD313E249u) % 4u)
				{
				case 2u:
					num = (int)((num2 * 67973375) ^ 0x408B903A);
					continue;
				case 1u:
					num = (int)((num2 * 1854526688) ^ 0x1D3C0C3D);
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
