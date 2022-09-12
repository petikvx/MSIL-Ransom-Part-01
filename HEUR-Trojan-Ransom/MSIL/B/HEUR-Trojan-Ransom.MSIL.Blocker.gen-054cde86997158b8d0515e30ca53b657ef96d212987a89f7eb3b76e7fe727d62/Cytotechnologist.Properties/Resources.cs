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
				int num = 795689908;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x721B3C7Bu) % 8u)
					{
					case 7u:
						flag = resourceMan == null;
						num = ((int)num2 * -1136282267) ^ 0x6DB3B716;
						continue;
					case 6u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -531862260;
							num4 = -531862260;
						}
						else
						{
							num3 = -506980159;
							num4 = -506980159;
						}
						num = num3 ^ (int)(num2 * 1909337809);
						continue;
					}
					case 4u:
						result = resourceMan;
						num = 1048150598;
						continue;
					case 3u:
						num = ((int)num2 * -1177429987) ^ 0x6C2636E8;
						continue;
					case 1u:
						num = (int)(num2 * 1785784578) ^ -1303144159;
						continue;
					case 0u:
					{
						ResourceManager resourceManager = (resourceMan = Resources.smethod_2("Cytotechnologist.Properties.Resources", Resources.smethod_1(Resources.smethod_0(typeof(Resources).TypeHandle))));
						num = (int)(num2 * 773783164) ^ -499499328;
						continue;
					}
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return resourceCulture;
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static Bitmap StoreAssemblyEnumerati
	{
		get
		{
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Expected O, but got Unknown
			object obj = default(object);
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = -1372612300;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD125D7EFu) % 5u)
					{
					case 4u:
						obj = Resources.smethod_3(ResourceManager, "StoreAssemblyEnumerati", resourceCulture);
						num = ((int)num2 * -228792984) ^ -1419841167;
						continue;
					case 3u:
						num = ((int)num2 * -280209153) ^ 0x140B992C;
						continue;
					case 0u:
						result = (Bitmap)obj;
						num = ((int)num2 * -1237135905) ^ -1633718745;
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
			int num = 105822290;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x76A78EE3u) % 4u)
				{
				case 2u:
					num = ((int)num2 * -1401890536) ^ -765353365;
					continue;
				case 1u:
					num = (int)(num2 * 1268689495) ^ -1526169166;
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
