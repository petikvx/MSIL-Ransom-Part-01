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
			bool flag = default(bool);
			while (true)
			{
				int num = 370531734;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x52DC77D9u) % 9u)
					{
					case 8u:
					{
						ResourceManager resourceManager = (resourceMan = Resources.smethod_2("Cytotechnologist.Properties.Resources", Resources.smethod_1(Resources.smethod_0(typeof(Resources).TypeHandle))));
						num = ((int)num2 * -463372266) ^ 0x4D221339;
						continue;
					}
					case 6u:
						result = resourceMan;
						num = 880102416;
						continue;
					case 5u:
						num = (int)(num2 * 1267082382) ^ -224918084;
						continue;
					case 3u:
						num = (int)(num2 * 278027736) ^ -780830848;
						continue;
					case 2u:
						flag = resourceMan == null;
						num = (int)((num2 * 1836655004) ^ 0x7D0643DF);
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 834176538;
							num4 = 834176538;
						}
						else
						{
							num3 = 2055661245;
							num4 = 2055661245;
						}
						num = num3 ^ (int)(num2 * 1625125227);
						continue;
					}
					case 0u:
						num = (int)((num2 * 1834713376) ^ 0x676DC9EC);
						continue;
					case 4u:
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
				int num = -1333742108;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB7C7EBE9u) % 4u)
					{
					case 3u:
						num = ((int)num2 * -1330499909) ^ 0x3E44ECEE;
						continue;
					case 1u:
						result = resourceCulture;
						num = ((int)num2 * -1095413643) ^ 0x7AE929BB;
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
		set
		{
			resourceCulture = value;
		}
	}

	internal static Bitmap SuppressMergeCheckAttribu
	{
		get
		{
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			object obj = Resources.smethod_3(ResourceManager, "SuppressMergeCheckAttribu", resourceCulture);
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = 1236209553;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6C6C1E10u) % 4u)
					{
					case 2u:
						num = (int)((num2 * 909937172) ^ 0x3607DCDB);
						continue;
					case 1u:
						result = (Bitmap)obj;
						num = ((int)num2 * -966353041) ^ 0x1EB20459;
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
			int num = -1351813407;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD1408D83u) % 4u)
				{
				case 2u:
					num = ((int)num2 * -691719167) ^ -23072660;
					continue;
				case 1u:
					num = (int)(num2 * 175968655) ^ -2136964764;
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
