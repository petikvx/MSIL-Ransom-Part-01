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
			bool flag = resourceMan == null;
			ResourceManager resourceManager = default(ResourceManager);
			ResourceManager result = default(ResourceManager);
			while (true)
			{
				int num = -297932305;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xABD6D8F3u) % 8u)
					{
					case 7u:
						resourceManager = Resources.smethod_2("Cytotechnologist.Properties.Resources", Resources.smethod_1(Resources.smethod_0(typeof(Resources).TypeHandle)));
						num = ((int)num2 * -665733560) ^ 0x4EE70252;
						continue;
					case 6u:
						num = (int)((num2 * 370416102) ^ 0x622CA44);
						continue;
					case 5u:
						num = ((int)num2 * -363628738) ^ 0x2DB57FAA;
						continue;
					case 4u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -2094450270;
							num4 = -2094450270;
						}
						else
						{
							num3 = -146225633;
							num4 = -146225633;
						}
						num = num3 ^ ((int)num2 * -959428189);
						continue;
					}
					case 1u:
						resourceMan = resourceManager;
						num = (int)(num2 * 1887816074) ^ -54437967;
						continue;
					case 0u:
						result = resourceMan;
						num = -842820427;
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			CultureInfo result = resourceCulture;
			while (true)
			{
				int num = -453462660;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA0DB860Eu) % 3u)
					{
					case 1u:
						goto IL_0008;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0008:
					num = (int)(num2 * 1508616700) ^ -1110364839;
				}
			}
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static Bitmap RuntimeAssemb
	{
		get
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected O, but got Unknown
			object obj = default(object);
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = -1443355925;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA20ADA89u) % 5u)
					{
					case 4u:
						obj = Resources.smethod_3(ResourceManager, "RuntimeAssemb", resourceCulture);
						num = ((int)num2 * -1804479085) ^ -1874734948;
						continue;
					case 2u:
						result = (Bitmap)obj;
						num = ((int)num2 * -65798259) ^ -834890397;
						continue;
					case 1u:
						num = ((int)num2 * -1092360089) ^ 0x6E7D67EE;
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
			int num = -1985224910;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD2B68454u) % 3u)
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
				num = (int)(num2 * 1532171798) ^ -112050916;
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
