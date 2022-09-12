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
				int num = 1170112537;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9A2DC02u) % 10u)
					{
					case 9u:
						num = ((int)num2 * -1988581852) ^ -1948822517;
						continue;
					case 8u:
						num = 566211670;
						continue;
					case 6u:
						resourceManager = Class6.smethod_3("The_Omegle_Game.Resources", Class6.smethod_2(Class6.smethod_1(typeof(Class6).TypeHandle)));
						num = ((int)num2 * -131844612) ^ 0x33A9E4F8;
						continue;
					case 5u:
						num = (int)((num2 * 1736992498) ^ 0x6C65E686);
						continue;
					case 4u:
						resourceManager_0 = resourceManager;
						num = (int)(num2 * 2041208773) ^ -1050555327;
						continue;
					case 3u:
						flag = Class6.smethod_0((object)resourceManager_0, (object)null);
						num = (int)((num2 * 1558108065) ^ 0x3D46A65C);
						continue;
					case 2u:
						result = resourceManager_0;
						num = ((int)num2 * -820787723) ^ -1105402517;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -2018224318;
							num4 = -2018224318;
						}
						else
						{
							num3 = -1205095370;
							num4 = -1205095370;
						}
						num = num3 ^ (int)(num2 * 1443547850);
						continue;
					}
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
				int num = -1114674277;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEB384707u) % 3u)
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
					result = cultureInfo_0;
					num = ((int)num2 * -1603235677) ^ -2142181750;
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
			object obj = Class6.smethod_5(Class6.smethod_4(ResourceManager_0, "KFLv", cultureInfo_0));
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = 343348388;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5E375FD5u) % 4u)
					{
					case 1u:
						result = (Bitmap)obj;
						num = ((int)num2 * -1287538995) ^ 0x7232B084;
						continue;
					case 0u:
						num = ((int)num2 * -781697750) ^ -737563102;
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
