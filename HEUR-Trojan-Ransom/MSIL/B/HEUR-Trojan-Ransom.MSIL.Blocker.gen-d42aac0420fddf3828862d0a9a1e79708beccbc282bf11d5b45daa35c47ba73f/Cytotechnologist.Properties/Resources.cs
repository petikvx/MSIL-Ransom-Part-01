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
				int num = 1787870731;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5AD7FDF5u) % 8u)
					{
					case 7u:
						result = resourceMan;
						num = 555877158;
						continue;
					case 6u:
						flag = resourceMan == null;
						num = (int)((num2 * 694649020) ^ 0x50184297);
						continue;
					case 4u:
					{
						ResourceManager resourceManager = (resourceMan = Resources.smethod_2("Cytotechnologist.Properties.Resources", Resources.smethod_1(Resources.smethod_0(typeof(Resources).TypeHandle))));
						num = (int)((num2 * 18587185) ^ 0x41145FA0);
						continue;
					}
					case 3u:
						num = (int)((num2 * 1069320362) ^ 0x2774FA1E);
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 1905104819;
							num4 = 1905104819;
						}
						else
						{
							num3 = 1785808136;
							num4 = 1785808136;
						}
						num = num3 ^ (int)(num2 * 1854116349);
						continue;
					}
					case 1u:
						num = ((int)num2 * -151689341) ^ 0x3E3D5079;
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
				int num = 123869258;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x55A2D48Fu) % 4u)
					{
					case 1u:
						result = resourceCulture;
						num = (int)((num2 * 2003605998) ^ 0x7F96E481);
						continue;
					case 0u:
						num = ((int)num2 * -1553537434) ^ -1830009595;
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
			while (true)
			{
				int num = 929387129;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7C2D1BE5u) % 3u)
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
					num = ((int)num2 * -1564050916) ^ 0x527D9281;
				}
			}
		}
	}

	internal static Bitmap COMServerEnt
	{
		get
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			object obj = Resources.smethod_3(ResourceManager, "COMServerEnt", resourceCulture);
			Bitmap result = (Bitmap)obj;
			while (true)
			{
				int num = -466808448;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE670FADCu) % 3u)
					{
					case 2u:
						goto IL_001e;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_001e:
					num = ((int)num2 * -1404205920) ^ 0x203B5A1;
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
