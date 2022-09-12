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
				int num = -1949171795;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD4FAB576u) % 8u)
					{
					case 5u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 103952543;
							num4 = 103952543;
						}
						else
						{
							num3 = 56315065;
							num4 = 56315065;
						}
						num = num3 ^ (int)(num2 * 2017390031);
						continue;
					}
					case 4u:
						result = resourceMan;
						num = -1911541906;
						continue;
					case 3u:
						flag = resourceMan == null;
						num = ((int)num2 * -1672271204) ^ 0x72DCCD57;
						continue;
					case 2u:
						num = (int)(num2 * 948074812) ^ -1230168433;
						continue;
					case 1u:
					{
						ResourceManager resourceManager = (resourceMan = Resources.smethod_2("Cytotechnologist.Properties.Resources", Resources.smethod_1(Resources.smethod_0(typeof(Resources).TypeHandle))));
						num = (int)((num2 * 134508901) ^ 0xC69A927);
						continue;
					}
					case 0u:
						num = (int)((num2 * 526498679) ^ 0x7E4DC370);
						continue;
					case 7u:
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
			CultureInfo result = resourceCulture;
			while (true)
			{
				int num = 1793142510;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x727E0885u) % 3u)
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
					num = ((int)num2 * -1983886535) ^ 0x4777C9BA;
				}
			}
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static Bitmap EnumerableToIterableAdapt
	{
		get
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected O, but got Unknown
			object obj = Resources.smethod_3(ResourceManager, "EnumerableToIterableAdapt", resourceCulture);
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = 694030165;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x591162B5u) % 3u)
					{
					case 2u:
						goto IL_0017;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0017:
					result = (Bitmap)obj;
					num = ((int)num2 * -64900932) ^ -701505571;
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
