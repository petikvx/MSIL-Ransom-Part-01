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
			ResourceManager resourceManager = default(ResourceManager);
			bool flag = default(bool);
			ResourceManager result = default(ResourceManager);
			while (true)
			{
				int num = 1049853876;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD269C5u) % 10u)
					{
					case 9u:
						resourceManager = Resources.smethod_2("Cytotechnologist.Properties.Resources", Resources.smethod_1(Resources.smethod_0(typeof(Resources).TypeHandle)));
						num = ((int)num2 * -573420825) ^ -1349595141;
						continue;
					case 7u:
						flag = resourceMan == null;
						num = ((int)num2 * -1215129545) ^ -1648236139;
						continue;
					case 5u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -1895338612;
							num4 = -1895338612;
						}
						else
						{
							num3 = -482222437;
							num4 = -482222437;
						}
						num = num3 ^ ((int)num2 * -1153479114);
						continue;
					}
					case 4u:
						num = (int)((num2 * 1145829353) ^ 0x70DB0613);
						continue;
					case 3u:
						resourceMan = resourceManager;
						num = (int)(num2 * 614458519) ^ -1969598690;
						continue;
					case 2u:
						result = resourceMan;
						num = 48598345;
						continue;
					case 1u:
						num = ((int)num2 * -1917796620) ^ 0x79CBC17E;
						continue;
					case 0u:
						num = (int)(num2 * 1859613168) ^ -1270516247;
						continue;
					case 8u:
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
				int num = 537318432;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7BB3D01Eu) % 4u)
					{
					case 2u:
						result = resourceCulture;
						num = (int)((num2 * 611335838) ^ 0x7FC9235B);
						continue;
					case 1u:
						num = (int)((num2 * 839803599) ^ 0x23DAE39);
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

	internal static Bitmap WinRTTypeNameConvert
	{
		get
		{
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Expected O, but got Unknown
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = 2005311424;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x12C29C01u) % 4u)
					{
					case 1u:
					{
						object obj = Resources.smethod_3(ResourceManager, "WinRTTypeNameConvert", resourceCulture);
						result = (Bitmap)obj;
						num = (int)((num2 * 1354302682) ^ 0x570A3D1F);
						continue;
					}
					case 0u:
						num = ((int)num2 * -1166703429) ^ -462906870;
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
			int num = 568274130;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6E3D39C7u) % 4u)
				{
				case 1u:
					num = (int)(num2 * 572691054) ^ -1232886651;
					continue;
				case 0u:
					num = ((int)num2 * -554229334) ^ -206703000;
					continue;
				default:
					return;
				case 2u:
					break;
				case 3u:
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
