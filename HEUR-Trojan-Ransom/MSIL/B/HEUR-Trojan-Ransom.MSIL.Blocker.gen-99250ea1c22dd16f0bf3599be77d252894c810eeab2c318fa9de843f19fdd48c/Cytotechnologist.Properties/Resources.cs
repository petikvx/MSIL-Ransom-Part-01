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
			ResourceManager result = default(ResourceManager);
			while (true)
			{
				int num = 1529308331;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x61183113u) % 7u)
					{
					case 6u:
						num = ((int)num2 * -404856254) ^ 0x6CD1505D;
						continue;
					case 4u:
						result = resourceMan;
						num = 1872958090;
						continue;
					case 2u:
						num = (int)(num2 * 1330683060) ^ -1012763978;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (resourceMan == null)
						{
							num3 = -455930866;
							num4 = -455930866;
						}
						else
						{
							num3 = -2005813727;
							num4 = -2005813727;
						}
						num = num3 ^ (int)(num2 * 1959979340);
						continue;
					}
					case 0u:
					{
						ResourceManager resourceManager = (resourceMan = Resources.smethod_2("Cytotechnologist.Properties.Resources", Resources.smethod_1(Resources.smethod_0(typeof(Resources).TypeHandle))));
						num = (int)(num2 * 1807462019) ^ -1235548150;
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
	internal static CultureInfo Culture
	{
		get
		{
			return resourceCulture;
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static Bitmap IBindC
	{
		get
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Expected O, but got Unknown
			Bitmap result = default(Bitmap);
			object obj = default(object);
			while (true)
			{
				int num = -1890050405;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8272DEDAu) % 5u)
					{
					case 4u:
						result = (Bitmap)obj;
						num = ((int)num2 * -169409130) ^ 0x62CFF95;
						continue;
					case 2u:
						obj = Resources.smethod_3(ResourceManager, "IBindC", resourceCulture);
						num = (int)((num2 * 1610269115) ^ 0x5DE0745D);
						continue;
					case 1u:
						num = (int)((num2 * 1217527289) ^ 0xF221989);
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
