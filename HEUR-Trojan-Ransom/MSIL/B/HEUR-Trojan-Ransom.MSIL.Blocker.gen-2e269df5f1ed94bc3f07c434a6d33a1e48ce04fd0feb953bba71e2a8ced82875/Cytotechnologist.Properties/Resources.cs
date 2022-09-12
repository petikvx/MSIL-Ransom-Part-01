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
				int num = 1030083986;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3647E162u) % 9u)
					{
					case 8u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -1588587181;
							num4 = -1588587181;
						}
						else
						{
							num3 = -738323789;
							num4 = -738323789;
						}
						num = num3 ^ (int)(num2 * 1533103135);
						continue;
					}
					case 7u:
						resourceManager = Resources.smethod_2("Cytotechnologist.Properties.Resources", Resources.smethod_1(Resources.smethod_0(typeof(Resources).TypeHandle)));
						num = (int)(num2 * 193758938) ^ -79990314;
						continue;
					case 5u:
						result = resourceMan;
						num = 410047627;
						continue;
					case 4u:
						flag = resourceMan == null;
						num = (int)(num2 * 1598381841) ^ -14117042;
						continue;
					case 3u:
						num = ((int)num2 * -941281579) ^ -695300353;
						continue;
					case 1u:
						num = (int)(num2 * 1034637597) ^ -84337341;
						continue;
					case 0u:
						resourceMan = resourceManager;
						num = (int)(num2 * 702406270) ^ -369884017;
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
				int num = -880912380;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8FA9B1DDu) % 3u)
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
					num = ((int)num2 * -266526576) ^ 0x76FAE756;
				}
			}
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static Bitmap Bind
	{
		get
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected O, but got Unknown
			object obj = default(object);
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = -1527166282;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCD33CC10u) % 4u)
					{
					case 2u:
						obj = Resources.smethod_3(ResourceManager, "Bind", resourceCulture);
						num = ((int)num2 * -779822392) ^ -1024359775;
						continue;
					case 1u:
						result = (Bitmap)obj;
						num = ((int)num2 * -2075486316) ^ -1703022121;
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
			int num = 139926403;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x65D07205u) % 4u)
				{
				case 2u:
					num = ((int)num2 * -300429790) ^ -1253646104;
					continue;
				case 1u:
					num = (int)((num2 * 886644134) ^ 0x11B708EB);
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
