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
			bool flag = Class6.smethod_0((object)resourceManager_0, (object)null);
			ResourceManager result = default(ResourceManager);
			while (true)
			{
				int num = 12561631;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3AF67E96u) % 7u)
					{
					case 5u:
					{
						ResourceManager resourceManager = (resourceManager_0 = Class6.smethod_3("The_Omegle_Game.Resources", Class6.smethod_2(Class6.smethod_1(typeof(Class6).TypeHandle))));
						num = ((int)num2 * -66126042) ^ 0x7D7DAC19;
						continue;
					}
					case 4u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 1552020211;
							num4 = 1552020211;
						}
						else
						{
							num3 = 1513089777;
							num4 = 1513089777;
						}
						num = num3 ^ (int)(num2 * 1506288958);
						continue;
					}
					case 3u:
						result = resourceManager_0;
						num = (int)(num2 * 1584829937) ^ -559041931;
						continue;
					case 1u:
						num = 785327766;
						continue;
					case 0u:
						num = ((int)num2 * -28636665) ^ -454469070;
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
	internal static CultureInfo CultureInfo_0
	{
		get
		{
			CultureInfo result = default(CultureInfo);
			while (true)
			{
				int num = -1583105507;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD94B8510u) % 4u)
					{
					case 2u:
						num = (int)(num2 * 451819615) ^ -895515046;
						continue;
					case 1u:
						result = cultureInfo_0;
						num = ((int)num2 * -1671191187) ^ -697282545;
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
		set
		{
			cultureInfo_0 = value;
		}
	}

	internal static Bitmap Bitmap_0
	{
		get
		{
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected O, but got Unknown
			object obj = default(object);
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = -390039313;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x89DEBC1Au) % 5u)
					{
					case 3u:
						obj = Class6.smethod_5(Class6.smethod_4(ResourceManager_0, "ZBVn", cultureInfo_0));
						num = (int)((num2 * 826246069) ^ 0x27A537DC);
						continue;
					case 2u:
						num = ((int)num2 * -1899956833) ^ 0x4215D621;
						continue;
					case 1u:
						result = (Bitmap)obj;
						num = (int)(num2 * 1815335226) ^ -1374827947;
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
