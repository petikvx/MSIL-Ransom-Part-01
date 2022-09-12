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
				int num = -1395939635;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAC1C97B0u) % 6u)
					{
					case 5u:
						flag = resourceMan == null;
						num = ((int)num2 * -376792342) ^ 0x7DED855;
						continue;
					case 4u:
					{
						ResourceManager resourceManager = (resourceMan = Resources.smethod_2("Cytotechnologist.Properties.Resources", Resources.smethod_1(Resources.smethod_0(typeof(Resources).TypeHandle))));
						num = ((int)num2 * -949836243) ^ 0x44547A44;
						continue;
					}
					case 3u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 919721874;
							num4 = 919721874;
						}
						else
						{
							num3 = 163671782;
							num4 = 163671782;
						}
						num = num3 ^ ((int)num2 * -961065702);
						continue;
					}
					case 2u:
						result = resourceMan;
						num = -2062898153;
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
				int num = 889084195;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x43C38816u) % 3u)
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
					num = (int)((num2 * 1460029251) ^ 0x4F1CDF87);
				}
			}
		}
		set
		{
			while (true)
			{
				int num = -2049995688;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x993B0EBAu) % 3u)
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
					num = (int)(num2 * 882496200) ^ -1482256156;
				}
			}
		}
	}

	internal static Bitmap IEnumVARIA
	{
		get
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected O, but got Unknown
			object obj = default(object);
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = -1604811466;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC1C4D427u) % 4u)
					{
					case 1u:
						obj = Resources.smethod_3(ResourceManager, "IEnumVARIA", resourceCulture);
						num = ((int)num2 * -1249616359) ^ 0x6C6B7EC2;
						continue;
					case 0u:
						result = (Bitmap)obj;
						num = ((int)num2 * -1573901443) ^ -780657915;
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
