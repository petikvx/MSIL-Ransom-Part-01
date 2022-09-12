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
			ResourceManager resourceManager = default(ResourceManager);
			bool flag = default(bool);
			ResourceManager result = default(ResourceManager);
			while (true)
			{
				int num = -1242990174;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBC188535u) % 7u)
					{
					case 6u:
						resourceManager = Class6.smethod_3("The_Omegle_Game.Resources", Class6.smethod_2(Class6.smethod_1(typeof(Class6).TypeHandle)));
						num = (int)((num2 * 391291275) ^ 0xF36B5F8);
						continue;
					case 5u:
						flag = Class6.smethod_0((object)resourceManager_0, (object)null);
						num = (int)(num2 * 1146395029) ^ -1380137968;
						continue;
					case 4u:
						result = resourceManager_0;
						num = -1914701382;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 939102145;
							num4 = 939102145;
						}
						else
						{
							num3 = 760654681;
							num4 = 760654681;
						}
						num = num3 ^ ((int)num2 * -1311087196);
						continue;
					}
					case 2u:
						resourceManager_0 = resourceManager;
						num = (int)((num2 * 793163549) ^ 0x4CCF19D4);
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
	internal static CultureInfo CultureInfo_0
	{
		get
		{
			CultureInfo result = default(CultureInfo);
			while (true)
			{
				int num = 1540048452;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x544A3913u) % 4u)
					{
					case 3u:
						result = cultureInfo_0;
						num = (int)((num2 * 294111122) ^ 0x6F4A2668);
						continue;
					case 1u:
						num = ((int)num2 * -1407734261) ^ 0x522F09AE;
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
			cultureInfo_0 = value;
		}
	}

	internal static Bitmap Bitmap_0
	{
		get
		{
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected O, but got Unknown
			object obj = Class6.smethod_5(Class6.smethod_4(ResourceManager_0, "nTxO", cultureInfo_0));
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = -134076515;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xED4872BFu) % 3u)
					{
					case 1u:
						goto IL_001c;
					case 2u:
						break;
					default:
						return result;
					}
					break;
					IL_001c:
					result = (Bitmap)obj;
					num = ((int)num2 * -11402443) ^ -191932403;
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
