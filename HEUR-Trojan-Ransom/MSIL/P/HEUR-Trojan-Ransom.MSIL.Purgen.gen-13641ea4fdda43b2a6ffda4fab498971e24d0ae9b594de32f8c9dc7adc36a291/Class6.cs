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
				int num = -146036778;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAF384453u) % 7u)
					{
					case 6u:
						num = -850713742;
						continue;
					case 4u:
						num = ((int)num2 * -1729643716) ^ 0x5D87BF7D;
						continue;
					case 3u:
						result = resourceManager_0;
						num = ((int)num2 * -2094832220) ^ 0x32A0248;
						continue;
					case 2u:
					{
						ResourceManager resourceManager = (resourceManager_0 = Class6.smethod_3("The_Omegle_Game.Resources", Class6.smethod_2(Class6.smethod_1(typeof(Class6).TypeHandle))));
						num = ((int)num2 * -220402536) ^ -1235616362;
						continue;
					}
					case 1u:
					{
						int num3;
						int num4;
						if (Class6.smethod_0((object)resourceManager_0, (object)null))
						{
							num3 = -984532072;
							num4 = -984532072;
						}
						else
						{
							num3 = -274215875;
							num4 = -274215875;
						}
						num = num3 ^ (int)(num2 * 1902404207);
						continue;
					}
					case 5u:
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
			CultureInfo result = cultureInfo_0;
			while (true)
			{
				int num = -772525140;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB110D641u) % 3u)
					{
					case 1u:
						goto IL_0008;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0008:
					num = (int)((num2 * 1445601012) ^ 0x7CAD203E);
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
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Expected O, but got Unknown
			object obj = Class6.smethod_5(Class6.smethod_4(ResourceManager_0, "rgsN", cultureInfo_0));
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = 1645606509;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x337C926Cu) % 4u)
					{
					case 2u:
						num = (int)((num2 * 1710357060) ^ 0x6EB3A35F);
						continue;
					case 1u:
						result = (Bitmap)obj;
						num = ((int)num2 * -488650578) ^ -227503280;
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
