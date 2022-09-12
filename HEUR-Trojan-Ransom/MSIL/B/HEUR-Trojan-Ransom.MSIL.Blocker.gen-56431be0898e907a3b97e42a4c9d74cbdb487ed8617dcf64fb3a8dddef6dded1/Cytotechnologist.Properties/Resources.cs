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
				goto IL_003b;
			}
			goto IL_0061;
			IL_0061:
			ResourceManager result = resourceMan;
			int num = 1183315159;
			goto IL_0040;
			IL_0040:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x54C9436Eu) % 4u)
				{
				case 3u:
				{
					ResourceManager resourceManager = (resourceMan = Resources.smethod_2("Cytotechnologist.Properties.Resources", Resources.smethod_1(Resources.smethod_0(typeof(Resources).TypeHandle))));
					num = ((int)num2 * -1812010528) ^ 0x5E5FDDE;
					continue;
				}
				case 2u:
					break;
				case 0u:
					goto IL_0061;
				default:
					return result;
				}
				break;
			}
			goto IL_003b;
			IL_003b:
			num = 660621341;
			goto IL_0040;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			CultureInfo result = default(CultureInfo);
			while (true)
			{
				int num = 419360836;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4E9A87C4u) % 3u)
					{
					case 1u:
						goto IL_0003;
					case 2u:
						break;
					default:
						return result;
					}
					break;
					IL_0003:
					result = resourceCulture;
					num = (int)((num2 * 1740993593) ^ 0x58778C3F);
				}
			}
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static Bitmap Versi
	{
		get
		{
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Expected O, but got Unknown
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = 1171089756;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x670A6ED3u) % 4u)
					{
					case 3u:
					{
						object obj = Resources.smethod_3(ResourceManager, "Versi", resourceCulture);
						result = (Bitmap)obj;
						num = ((int)num2 * -387369688) ^ 0x124C511E;
						continue;
					}
					case 1u:
						num = ((int)num2 * -220964576) ^ -1579441203;
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
		while (true)
		{
			int num = -825583324;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x847BD733u) % 3u)
				{
				case 1u:
					goto IL_0008;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0008:
				num = (int)(num2 * 1356279713) ^ -922674662;
			}
		}
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
