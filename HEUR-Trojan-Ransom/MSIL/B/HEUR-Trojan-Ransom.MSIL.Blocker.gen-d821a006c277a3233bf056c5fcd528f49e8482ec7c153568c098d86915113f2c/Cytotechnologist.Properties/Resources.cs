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
			ResourceManager resourceManager = default(ResourceManager);
			while (true)
			{
				int num = -1866214181;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBE69F025u) % 8u)
					{
					case 7u:
						num = (int)((num2 * 743574971) ^ 0x55CFE59B);
						continue;
					case 6u:
						flag = resourceMan == null;
						num = (int)((num2 * 309683061) ^ 0xCBB2BAB);
						continue;
					case 5u:
						result = resourceMan;
						num = -2109204831;
						continue;
					case 3u:
						resourceManager = Resources.smethod_2("Cytotechnologist.Properties.Resources", Resources.smethod_1(Resources.smethod_0(typeof(Resources).TypeHandle)));
						num = (int)((num2 * 1410067618) ^ 0x5161025A);
						continue;
					case 1u:
						resourceMan = resourceManager;
						num = (int)(num2 * 1765992029) ^ -651941595;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 1534447682;
							num4 = 1534447682;
						}
						else
						{
							num3 = 772560376;
							num4 = 772560376;
						}
						num = num3 ^ ((int)num2 * -248566683);
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
			CultureInfo result = resourceCulture;
			while (true)
			{
				int num = -2069152653;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFACDE383u) % 3u)
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
					num = ((int)num2 * -1618912701) ^ -1959115798;
				}
			}
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static Bitmap X509Certifica
	{
		get
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected O, but got Unknown
			object obj = Resources.smethod_3(ResourceManager, "X509Certifica", resourceCulture);
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = -2005076626;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9C3447C8u) % 3u)
					{
					case 1u:
						goto IL_0017;
					case 2u:
						break;
					default:
						return result;
					}
					break;
					IL_0017:
					result = (Bitmap)obj;
					num = ((int)num2 * -1839113782) ^ 0x124F770C;
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
