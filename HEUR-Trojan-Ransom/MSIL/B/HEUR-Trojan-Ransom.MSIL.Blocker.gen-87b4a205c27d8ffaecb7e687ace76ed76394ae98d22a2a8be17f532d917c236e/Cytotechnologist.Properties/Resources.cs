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
				int num = 738299134;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x17629E88u) % 9u)
					{
					case 8u:
						num = (int)(num2 * 1353534496) ^ -1687213705;
						continue;
					case 6u:
						flag = resourceMan == null;
						num = ((int)num2 * -1395342637) ^ -1765526745;
						continue;
					case 5u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -2143834467;
							num4 = -2143834467;
						}
						else
						{
							num3 = -1342018016;
							num4 = -1342018016;
						}
						num = num3 ^ ((int)num2 * -921980922);
						continue;
					}
					case 4u:
						num = (int)(num2 * 288054653) ^ -586169856;
						continue;
					case 2u:
						resourceMan = resourceManager;
						num = ((int)num2 * -1621243361) ^ 0x6631D86F;
						continue;
					case 1u:
						result = resourceMan;
						num = 1273231159;
						continue;
					case 0u:
						resourceManager = Resources.smethod_2("Cytotechnologist.Properties.Resources", Resources.smethod_1(Resources.smethod_0(typeof(Resources).TypeHandle)));
						num = ((int)num2 * -1311491639) ^ -553599749;
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			CultureInfo result = default(CultureInfo);
			while (true)
			{
				int num = 837655241;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x69C13120u) % 3u)
					{
					case 2u:
						goto IL_0003;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0003:
					result = resourceCulture;
					num = ((int)num2 * -1010451058) ^ -1958860548;
				}
			}
		}
		set
		{
			while (true)
			{
				int num = -1061010409;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAE7706E3u) % 3u)
					{
					case 1u:
						goto IL_0003;
					default:
						return;
					case 2u:
						break;
					case 0u:
						return;
					}
					break;
					IL_0003:
					resourceCulture = value;
					num = (int)(num2 * 1626652508) ^ -1441458252;
				}
			}
		}
	}

	internal static Bitmap Sta
	{
		get
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Expected O, but got Unknown
			Bitmap result = default(Bitmap);
			object obj = default(object);
			while (true)
			{
				int num = 1826966044;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3ED06B14u) % 5u)
					{
					case 3u:
						result = (Bitmap)obj;
						num = ((int)num2 * -1742798492) ^ 0x182BE0A0;
						continue;
					case 1u:
						obj = Resources.smethod_3(ResourceManager, "Sta", resourceCulture);
						num = (int)(num2 * 2063803252) ^ -458544972;
						continue;
					case 0u:
						num = ((int)num2 * -1808415515) ^ -501617881;
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
			int num = 105706048;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x19B24A23u) % 3u)
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
				num = (int)(num2 * 1817845297) ^ -227589258;
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
