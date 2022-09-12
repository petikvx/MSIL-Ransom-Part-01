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
			if (resourceMan == null)
			{
				goto IL_004a;
			}
			goto IL_0087;
			IL_0087:
			ResourceManager result = resourceMan;
			int num = 1107687969;
			goto IL_005e;
			IL_005e:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4D389DB4u) % 6u)
				{
				case 5u:
					num = ((int)num2 * -1911155074) ^ -188405641;
					continue;
				case 4u:
				{
					ResourceManager resourceManager = (resourceMan = Resources.smethod_2("Cytotechnologist.Properties.Resources", Resources.smethod_1(Resources.smethod_0(typeof(Resources).TypeHandle))));
					num = ((int)num2 * -533357902) ^ -1128787807;
					continue;
				}
				case 2u:
					break;
				case 1u:
					num = (int)((num2 * 176970545) ^ 0x22F9FCDF);
					continue;
				case 3u:
					goto IL_0087;
				default:
					return result;
				}
				break;
			}
			goto IL_004a;
			IL_004a:
			num = 1724385392;
			goto IL_005e;
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

	internal static Bitmap EncoderExceptionFallba
	{
		get
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			object obj = Resources.smethod_3(ResourceManager, "EncoderExceptionFallba", resourceCulture);
			Bitmap result = (Bitmap)obj;
			while (true)
			{
				int num = 1407370082;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4A5EEBFu) % 3u)
					{
					case 1u:
						goto IL_001e;
					case 2u:
						break;
					default:
						return result;
					}
					break;
					IL_001e:
					num = (int)((num2 * 1601147417) ^ 0x529B9347);
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
