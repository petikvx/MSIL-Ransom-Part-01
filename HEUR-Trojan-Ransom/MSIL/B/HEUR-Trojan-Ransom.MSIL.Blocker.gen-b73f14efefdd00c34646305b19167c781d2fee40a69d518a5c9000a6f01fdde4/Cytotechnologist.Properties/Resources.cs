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
				int num = 65978151;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6F4C044u) % 9u)
					{
					case 8u:
						resourceManager = Resources.smethod_2("Cytotechnologist.Properties.Resources", Resources.smethod_1(Resources.smethod_0(typeof(Resources).TypeHandle)));
						num = (int)(num2 * 1948616688) ^ -684908228;
						continue;
					case 7u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -492239638;
							num4 = -492239638;
						}
						else
						{
							num3 = -1486381766;
							num4 = -1486381766;
						}
						num = num3 ^ (int)(num2 * 337267946);
						continue;
					}
					case 5u:
						result = resourceMan;
						num = 756311921;
						continue;
					case 4u:
						num = ((int)num2 * -1598140326) ^ 0x1D822C5B;
						continue;
					case 3u:
						resourceMan = resourceManager;
						num = ((int)num2 * -972653714) ^ 0x276C5DAA;
						continue;
					case 2u:
						flag = resourceMan == null;
						num = (int)((num2 * 1070060643) ^ 0x682F2D5);
						continue;
					case 1u:
						num = (int)((num2 * 307181836) ^ 0x3FA2AC0);
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
				int num = 1235659849;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x67643EA7u) % 4u)
					{
					case 3u:
						num = (int)((num2 * 703844373) ^ 0x5E4E7311);
						continue;
					case 2u:
						result = resourceCulture;
						num = ((int)num2 * -777849512) ^ -1749241392;
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
			while (true)
			{
				int num = 1409850012;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x41BAB38Cu) % 3u)
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
					num = ((int)num2 * -1638343094) ^ -1482760781;
				}
			}
		}
	}

	internal static Bitmap CancellationCallbackCoreWorkArgumen
	{
		get
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			object obj = Resources.smethod_3(ResourceManager, "CancellationCallbackCoreWorkArgumen", resourceCulture);
			Bitmap result = (Bitmap)obj;
			while (true)
			{
				int num = -1540268964;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF4B3CE87u) % 3u)
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
					num = ((int)num2 * -1487881546) ^ 0x1FBDF1EB;
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
