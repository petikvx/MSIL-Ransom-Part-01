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
			if (Class6.smethod_0((object)resourceManager_0, (object)null))
			{
				goto IL_0021;
			}
			goto IL_00a6;
			IL_00a6:
			int num = 1321929355;
			goto IL_0079;
			IL_0079:
			ResourceManager result = default(ResourceManager);
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3BDD8A00u) % 7u)
				{
				case 6u:
					num = ((int)num2 * -391056660) ^ -1821022114;
					continue;
				case 5u:
					break;
				case 4u:
					num = ((int)num2 * -2019193362) ^ -192917471;
					continue;
				case 3u:
				{
					ResourceManager resourceManager = (resourceManager_0 = Class6.smethod_3("The_Omegle_Game.Resources", Class6.smethod_2(Class6.smethod_1(typeof(Class6).TypeHandle))));
					num = (int)(num2 * 323720718) ^ -502145433;
					continue;
				}
				case 0u:
					result = resourceManager_0;
					num = (int)((num2 * 1285428917) ^ 0x7CFB83AB);
					continue;
				case 2u:
					goto IL_00a6;
				default:
					return result;
				}
				break;
			}
			goto IL_0021;
			IL_0021:
			num = 932096165;
			goto IL_0079;
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
				int num = 817261143;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2680EE0u) % 4u)
					{
					case 3u:
						result = cultureInfo_0;
						num = (int)(num2 * 704349893) ^ -1674825111;
						continue;
					case 2u:
						num = (int)((num2 * 362129632) ^ 0x2865F871);
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
				int num = -1909140243;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8C7E31DFu) % 3u)
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
					num = (int)(num2 * 23725827) ^ -1240989422;
				}
			}
		}
	}

	internal static Bitmap Bitmap_0
	{
		get
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Expected O, but got Unknown
			Bitmap result = default(Bitmap);
			object obj = default(object);
			while (true)
			{
				int num = -573166384;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB37EDABDu) % 5u)
					{
					case 4u:
						result = (Bitmap)obj;
						num = ((int)num2 * -269060872) ^ 0x62EC35A8;
						continue;
					case 3u:
						obj = Class6.smethod_5(Class6.smethod_4(ResourceManager_0, "HnTf", cultureInfo_0));
						num = ((int)num2 * -54678040) ^ 0x72F7D677;
						continue;
					case 1u:
						num = ((int)num2 * -1147544885) ^ -1752191018;
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
