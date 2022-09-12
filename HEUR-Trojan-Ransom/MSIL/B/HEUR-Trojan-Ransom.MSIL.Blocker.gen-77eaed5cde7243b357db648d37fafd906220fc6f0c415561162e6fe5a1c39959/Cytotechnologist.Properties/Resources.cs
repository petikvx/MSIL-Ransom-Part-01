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
			ResourceManager result = default(ResourceManager);
			while (true)
			{
				int num = 1789267200;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x68859A44u) % 6u)
					{
					case 5u:
						num = (int)((num2 * 567695178) ^ 0x5722D7A7);
						continue;
					case 4u:
					{
						int num3;
						int num4;
						if (resourceMan != null)
						{
							num3 = -218627159;
							num4 = -218627159;
						}
						else
						{
							num3 = -618362426;
							num4 = -618362426;
						}
						num = num3 ^ ((int)num2 * -1324830872);
						continue;
					}
					case 2u:
					{
						ResourceManager resourceManager = (resourceMan = Resources.smethod_2("Cytotechnologist.Properties.Resources", Resources.smethod_1(Resources.smethod_0(typeof(Resources).TypeHandle))));
						num = (int)(num2 * 1530033429) ^ -826705851;
						continue;
					}
					case 1u:
						result = resourceMan;
						num = 1843210698;
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			CultureInfo result = default(CultureInfo);
			while (true)
			{
				int num = 848202497;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x709C4709u) % 3u)
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
					num = ((int)num2 * -1086699102) ^ 0x6CBE97C7;
				}
			}
		}
		set
		{
			while (true)
			{
				int num = 930904110;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2A43628Du) % 3u)
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
					num = (int)(num2 * 93916182) ^ -1853496519;
				}
			}
		}
	}

	internal static Bitmap SetOnInvokeMr
	{
		get
		{
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			Bitmap result = default(Bitmap);
			object obj = default(object);
			while (true)
			{
				int num = 321099781;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x343E5E1Cu) % 5u)
					{
					case 3u:
						num = (int)((num2 * 536523189) ^ 0x30C22653);
						continue;
					case 2u:
						result = (Bitmap)obj;
						num = ((int)num2 * -1949926686) ^ -1868581825;
						continue;
					case 1u:
						obj = Resources.smethod_3(ResourceManager, "SetOnInvokeMr", resourceCulture);
						num = ((int)num2 * -407830160) ^ -1930338814;
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
