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
			ResourceManager result = default(ResourceManager);
			while (true)
			{
				int num = 909050767;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4A46F5D0u) % 8u)
					{
					case 7u:
						flag = resourceMan == null;
						num = ((int)num2 * -984909780) ^ 0x23CB542D;
						continue;
					case 6u:
					{
						ResourceManager resourceManager = (resourceMan = Resources.smethod_2("Cytotechnologist.Properties.Resources", Resources.smethod_1(Resources.smethod_0(typeof(Resources).TypeHandle))));
						num = ((int)num2 * -1977957700) ^ 0x74FABC4B;
						continue;
					}
					case 4u:
						result = resourceMan;
						num = 775159773;
						continue;
					case 3u:
						num = (int)((num2 * 1857364080) ^ 0x2E5695A4);
						continue;
					case 2u:
						num = ((int)num2 * -1049565441) ^ 0x628D9870;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -743810947;
							num4 = -743810947;
						}
						else
						{
							num3 = -164381141;
							num4 = -164381141;
						}
						num = num3 ^ (int)(num2 * 1865951815);
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
	internal static CultureInfo Culture
	{
		get
		{
			return resourceCulture;
		}
		set
		{
			while (true)
			{
				int num = 2118238012;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3B9E9798u) % 3u)
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
					num = ((int)num2 * -1070573897) ^ -1515819239;
				}
			}
		}
	}

	internal static Bitmap AssemblyBuilderDa
	{
		get
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Expected O, but got Unknown
			Bitmap result = default(Bitmap);
			object obj = default(object);
			while (true)
			{
				int num = -239581639;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8FC4D281u) % 5u)
					{
					case 3u:
						result = (Bitmap)obj;
						num = (int)(num2 * 1184808059) ^ -1083873649;
						continue;
					case 2u:
						obj = Resources.smethod_3(ResourceManager, "AssemblyBuilderDa", resourceCulture);
						num = (int)((num2 * 1507471639) ^ 0x62A5F17A);
						continue;
					case 1u:
						num = (int)(num2 * 2021923500) ^ -1800787448;
						continue;
					case 4u:
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
