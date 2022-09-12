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
				int num = -262200457;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBDA23B4Bu) % 7u)
					{
					case 5u:
					{
						ResourceManager resourceManager = (resourceMan = Resources.smethod_2("Cytotechnologist.Properties.Resources", Resources.smethod_1(Resources.smethod_0(typeof(Resources).TypeHandle))));
						num = (int)(num2 * 578758458) ^ -1920242367;
						continue;
					}
					case 4u:
					{
						int num3;
						int num4;
						if (resourceMan != null)
						{
							num3 = -617618815;
							num4 = -617618815;
						}
						else
						{
							num3 = -953829066;
							num4 = -953829066;
						}
						num = num3 ^ ((int)num2 * -1300680521);
						continue;
					}
					case 3u:
						num = ((int)num2 * -1802233575) ^ -1188009844;
						continue;
					case 2u:
						num = (int)((num2 * 950714548) ^ 0x677A2CE5);
						continue;
					case 1u:
						result = resourceMan;
						num = -535754468;
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
				int num = 380363380;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x180850C1u) % 4u)
					{
					case 1u:
						result = resourceCulture;
						num = (int)(num2 * 294227990) ^ -1258607501;
						continue;
					case 0u:
						num = ((int)num2 * -1322478800) ^ -1245278802;
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
			resourceCulture = value;
		}
	}

	internal static Bitmap ArgumentOutOfRangeExcepti
	{
		get
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected O, but got Unknown
			object obj = Resources.smethod_3(ResourceManager, "ArgumentOutOfRangeExcepti", resourceCulture);
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = -1954756880;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD48A4265u) % 3u)
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
					num = ((int)num2 * -1906963985) ^ -223212130;
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
