using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
[HideModuleName]
internal sealed class Class6
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager_0
	{
		get
		{
			ResourceManager result = default(ResourceManager);
			while (true)
			{
				int num = -1703049106;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA909CF64u) % 6u)
					{
					case 5u:
						num = ((int)num2 * -1805814341) ^ -691864110;
						continue;
					case 4u:
					{
						ResourceManager resourceManager = (resourceManager_0 = Class6.smethod_3("The_Omegle_Game.Resources", Class6.smethod_2(Class6.smethod_1(typeof(Class6).TypeHandle))));
						num = (int)(num2 * 1583423532) ^ -1695310199;
						continue;
					}
					case 2u:
					{
						int num3;
						int num4;
						if (!Class6.smethod_0((object)resourceManager_0, (object)null))
						{
							num3 = -2000231443;
							num4 = -2000231443;
						}
						else
						{
							num3 = -1669230496;
							num4 = -1669230496;
						}
						num = num3 ^ (int)(num2 * 605098536);
						continue;
					}
					case 1u:
						result = resourceManager_0;
						num = -165613020;
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
	internal static CultureInfo CultureInfo_0
	{
		get
		{
			CultureInfo result = default(CultureInfo);
			while (true)
			{
				int num = -1983585357;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCBB4F295u) % 3u)
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
					result = cultureInfo_0;
					num = ((int)num2 * -1872444449) ^ -695773450;
				}
			}
		}
		set
		{
			while (true)
			{
				int num = -1832721733;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA04590D3u) % 3u)
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
					cultureInfo_0 = value;
					num = (int)(num2 * 313777662) ^ -1299534722;
				}
			}
		}
	}

	internal static Bitmap Bitmap_0
	{
		get
		{
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			object obj = Class6.smethod_5(Class6.smethod_4(ResourceManager_0, "pygc", cultureInfo_0));
			Bitmap result = (Bitmap)obj;
			while (true)
			{
				int num = -629512060;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x917F0294u) % 3u)
					{
					case 1u:
						goto IL_0023;
					case 2u:
						break;
					default:
						return result;
					}
					break;
					IL_0023:
					num = (int)((num2 * 1992945859) ^ 0x3C691EC7);
				}
			}
		}
	}

	static bool smethod_0(object object_0, object object_1)
	{
		return object.ReferenceEquals(object_0, object_1);
	}

	static Type smethod_1(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static Assembly smethod_2(Type type_0)
	{
		return type_0.Assembly;
	}

	static ResourceManager smethod_3(string string_0, Assembly assembly_0)
	{
		return new ResourceManager(string_0, assembly_0);
	}

	static object smethod_4(ResourceManager resourceManager_1, string string_0, CultureInfo cultureInfo_1)
	{
		return resourceManager_1.GetObject(string_0, cultureInfo_1);
	}

	static object smethod_5(object object_0)
	{
		return RuntimeHelpers.GetObjectValue(object_0);
	}
}
