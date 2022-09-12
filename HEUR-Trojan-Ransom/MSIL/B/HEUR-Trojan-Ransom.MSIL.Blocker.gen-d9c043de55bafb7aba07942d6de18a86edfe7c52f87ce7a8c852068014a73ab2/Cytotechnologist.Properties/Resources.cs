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
			ResourceManager resourceManager = default(ResourceManager);
			ResourceManager result = default(ResourceManager);
			while (true)
			{
				int num = -1126066745;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF99341EEu) % 8u)
					{
					case 7u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 182238021;
							num4 = 182238021;
						}
						else
						{
							num3 = 818894724;
							num4 = 818894724;
						}
						num = num3 ^ (int)(num2 * 1535473666);
						continue;
					}
					case 6u:
						num = (int)(num2 * 205053964) ^ -339042958;
						continue;
					case 5u:
						resourceManager = Resources.smethod_2("Cytotechnologist.Properties.Resources", Resources.smethod_1(Resources.smethod_0(typeof(Resources).TypeHandle)));
						num = (int)(num2 * 502292655) ^ -1026336834;
						continue;
					case 4u:
						result = resourceMan;
						num = -1218337228;
						continue;
					case 3u:
						resourceMan = resourceManager;
						num = (int)((num2 * 1093537836) ^ 0x4078BEA4);
						continue;
					case 1u:
						flag = resourceMan == null;
						num = ((int)num2 * -41849441) ^ -1075496970;
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
			CultureInfo result = default(CultureInfo);
			while (true)
			{
				int num = -1740615766;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFD6B0A5Bu) % 4u)
					{
					case 1u:
						result = resourceCulture;
						num = (int)(num2 * 1660217946) ^ -951045727;
						continue;
					case 0u:
						num = ((int)num2 * -2142239199) ^ -155313456;
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
		set
		{
			while (true)
			{
				int num = 529557492;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x55D6FD33u) % 3u)
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
					num = ((int)num2 * -658884743) ^ -1905774645;
				}
			}
		}
	}

	internal static Bitmap AsymmetricSignatureFormatt
	{
		get
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected O, but got Unknown
			object obj = Resources.smethod_3(ResourceManager, "AsymmetricSignatureFormatt", resourceCulture);
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = -1699026558;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9FB3998Cu) % 3u)
					{
					case 2u:
						goto IL_0017;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0017:
					result = (Bitmap)obj;
					num = ((int)num2 * -1892475633) ^ 0x8958DF5;
				}
			}
		}
	}

	internal Resources()
	{
		while (true)
		{
			int num = 2143176758;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6752FD3Bu) % 3u)
				{
				case 1u:
					goto IL_0008;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0008:
				num = ((int)num2 * -845970536) ^ 0x49A9F35A;
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
