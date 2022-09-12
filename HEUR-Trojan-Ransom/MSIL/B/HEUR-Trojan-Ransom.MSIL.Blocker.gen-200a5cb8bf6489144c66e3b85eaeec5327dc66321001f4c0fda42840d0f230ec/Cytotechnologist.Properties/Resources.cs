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
			ResourceManager resourceManager = default(ResourceManager);
			while (true)
			{
				int num = -1090231420;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFF32AC10u) % 10u)
					{
					case 9u:
						result = resourceMan;
						num = -2111730454;
						continue;
					case 8u:
						flag = resourceMan == null;
						num = (int)((num2 * 360838423) ^ 0x6A8DD09D);
						continue;
					case 7u:
						num = ((int)num2 * -598901531) ^ -293637878;
						continue;
					case 6u:
						num = (int)((num2 * 1137674325) ^ 0xD035568);
						continue;
					case 5u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -1419643967;
							num4 = -1419643967;
						}
						else
						{
							num3 = -1253885916;
							num4 = -1253885916;
						}
						num = num3 ^ ((int)num2 * -321034954);
						continue;
					}
					case 4u:
						resourceManager = Resources.smethod_2("Cytotechnologist.Properties.Resources", Resources.smethod_1(Resources.smethod_0(typeof(Resources).TypeHandle)));
						num = ((int)num2 * -1381795024) ^ 0x7B8E19AB;
						continue;
					case 1u:
						resourceMan = resourceManager;
						num = ((int)num2 * -1503348985) ^ 0x152C9014;
						continue;
					case 0u:
						num = ((int)num2 * -292265808) ^ -25608738;
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
			CultureInfo result = resourceCulture;
			while (true)
			{
				int num = 1921277219;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD2FED19u) % 3u)
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
					num = ((int)num2 * -872962772) ^ -1398866791;
				}
			}
		}
		set
		{
			while (true)
			{
				int num = -1664417955;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEA58C0EFu) % 3u)
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
					num = ((int)num2 * -497222139) ^ -1203540146;
				}
			}
		}
	}

	internal static Bitmap ThreadPoolTaskSchedul
	{
		get
		{
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Expected O, but got Unknown
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = -1645867662;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB0B3485Fu) % 3u)
					{
					case 1u:
						goto IL_0003;
					case 2u:
						break;
					default:
						return result;
					}
					break;
					IL_0003:
					object obj = Resources.smethod_3(ResourceManager, "ThreadPoolTaskSchedul", resourceCulture);
					result = (Bitmap)obj;
					num = (int)((num2 * 1690598743) ^ 0x5827981C);
				}
			}
		}
	}

	internal Resources()
	{
		while (true)
		{
			int num = -274362619;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC7319895u) % 3u)
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
				num = ((int)num2 * -464832953) ^ 0x6D597E6A;
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
