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
				int num = 6674153;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x46FBABAEu) % 6u)
					{
					case 5u:
						result = resourceManager_0;
						num = (int)((num2 * 1707793868) ^ 0x7FBC0C7A);
						continue;
					case 4u:
						num = 856998755;
						continue;
					case 2u:
					{
						ResourceManager resourceManager = (resourceManager_0 = Class6.smethod_3("The_Omegle_Game.Resources", Class6.smethod_2(Class6.smethod_1(typeof(Class6).TypeHandle))));
						num = ((int)num2 * -150386700) ^ -322459260;
						continue;
					}
					case 1u:
					{
						int num3;
						int num4;
						if (!Class6.smethod_0((object)resourceManager_0, (object)null))
						{
							num3 = 2128824460;
							num4 = 2128824460;
						}
						else
						{
							num3 = 36422090;
							num4 = 36422090;
						}
						num = num3 ^ (int)(num2 * 951429512);
						continue;
					}
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
				int num = 1986900501;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1D8316EDu) % 3u)
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
					num = (int)((num2 * 1788000619) ^ 0x284E0F5A);
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
				int num = 2048408089;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x535EC6EFu) % 5u)
					{
					case 4u:
						obj = Class6.smethod_5(Class6.smethod_4(ResourceManager_0, "BwnS", cultureInfo_0));
						num = (int)(num2 * 244999965) ^ -1713209936;
						continue;
					case 2u:
						num = (int)(num2 * 177234197) ^ -176455171;
						continue;
					case 0u:
						result = (Bitmap)obj;
						num = (int)(num2 * 1127509472) ^ -349332718;
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
