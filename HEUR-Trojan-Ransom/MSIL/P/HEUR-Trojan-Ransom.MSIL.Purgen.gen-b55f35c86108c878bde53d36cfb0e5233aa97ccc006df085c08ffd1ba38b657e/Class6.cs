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
			bool flag = default(bool);
			ResourceManager result = default(ResourceManager);
			ResourceManager resourceManager = default(ResourceManager);
			while (true)
			{
				int num = -1096094041;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD45A19F0u) % 9u)
					{
					case 8u:
						flag = Class6.smethod_0((object)resourceManager_0, (object)null);
						num = (int)((num2 * 1894066705) ^ 0x6E154B38);
						continue;
					case 7u:
						num = -893313558;
						continue;
					case 5u:
						result = resourceManager_0;
						num = (int)(num2 * 1733267040) ^ -1000985333;
						continue;
					case 4u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 196013520;
							num4 = 196013520;
						}
						else
						{
							num3 = 1914472107;
							num4 = 1914472107;
						}
						num = num3 ^ ((int)num2 * -791464177);
						continue;
					}
					case 2u:
						resourceManager_0 = resourceManager;
						num = (int)((num2 * 1501821008) ^ 0x739BFB9D);
						continue;
					case 1u:
						resourceManager = Class6.smethod_3("The_Omegle_Game.Resources", Class6.smethod_2(Class6.smethod_1(typeof(Class6).TypeHandle)));
						num = (int)(num2 * 5678150) ^ -2141216033;
						continue;
					case 0u:
						num = (int)(num2 * 685992666) ^ -1994118728;
						continue;
					case 6u:
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
				int num = 225775979;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1052B8DCu) % 4u)
					{
					case 3u:
						result = cultureInfo_0;
						num = (int)(num2 * 802887876) ^ -874536460;
						continue;
					case 0u:
						num = (int)((num2 * 1394798146) ^ 0x55ACC635);
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
			while (true)
			{
				int num = 574955979;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3B333F8Fu) % 3u)
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
					num = ((int)num2 * -1092499381) ^ -1909099078;
				}
			}
		}
	}

	internal static Bitmap Bitmap_0
	{
		get
		{
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected O, but got Unknown
			object obj = Class6.smethod_5(Class6.smethod_4(ResourceManager_0, "tbFG", cultureInfo_0));
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = -852776713;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x840DF2D9u) % 4u)
					{
					case 2u:
						result = (Bitmap)obj;
						num = ((int)num2 * -414668405) ^ 0x400A7A1A;
						continue;
					case 1u:
						num = (int)(num2 * 1474900431) ^ -1564485878;
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
