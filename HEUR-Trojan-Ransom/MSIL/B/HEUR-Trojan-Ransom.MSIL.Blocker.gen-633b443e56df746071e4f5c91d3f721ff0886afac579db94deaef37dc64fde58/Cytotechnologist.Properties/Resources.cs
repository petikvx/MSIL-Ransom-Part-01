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
				int num = -695018930;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x86EEBA90u) % 8u)
					{
					case 7u:
						num = (int)(num2 * 1447265976) ^ -1682872535;
						continue;
					case 6u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 320900088;
							num4 = 320900088;
						}
						else
						{
							num3 = 1221873761;
							num4 = 1221873761;
						}
						num = num3 ^ ((int)num2 * -1868151041);
						continue;
					}
					case 4u:
						resourceMan = resourceManager;
						num = (int)(num2 * 456456200) ^ -1375231942;
						continue;
					case 3u:
						num = (int)((num2 * 119551610) ^ 0x1E1F74F6);
						continue;
					case 2u:
						result = resourceMan;
						num = -1715567369;
						continue;
					case 0u:
						resourceManager = Resources.smethod_2("Cytotechnologist.Properties.Resources", Resources.smethod_1(Resources.smethod_0(typeof(Resources).TypeHandle)));
						num = ((int)num2 * -1232784896) ^ -116656692;
						continue;
					case 5u:
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
				int num = 966272488;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x62CB4F5Fu) % 3u)
					{
					case 1u:
						goto IL_0003;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0003:
					result = resourceCulture;
					num = ((int)num2 * -830278181) ^ 0x337EB152;
				}
			}
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static Bitmap EmptyAsyncLocalValueM
	{
		get
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected O, but got Unknown
			object obj = Resources.smethod_3(ResourceManager, "EmptyAsyncLocalValueM", resourceCulture);
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = -1711124235;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE8DF8CC0u) % 4u)
					{
					case 1u:
						result = (Bitmap)obj;
						num = (int)(num2 * 17424104) ^ -1196092240;
						continue;
					case 0u:
						num = (int)(num2 * 1510060743) ^ -1665269878;
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
