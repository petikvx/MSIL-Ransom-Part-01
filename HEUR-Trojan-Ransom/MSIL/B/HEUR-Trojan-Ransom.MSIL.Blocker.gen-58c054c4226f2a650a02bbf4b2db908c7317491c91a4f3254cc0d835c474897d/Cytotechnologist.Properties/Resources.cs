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
			int num = 1963877396;
			goto IL_0040;
			IL_0040:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x57B698FFu) % 4u)
				{
				case 2u:
				{
					ResourceManager resourceManager = (resourceMan = Resources.smethod_2("Cytotechnologist.Properties.Resources", Resources.smethod_1(Resources.smethod_0(typeof(Resources).TypeHandle))));
					num = ((int)num2 * -92222626) ^ -830114546;
					continue;
				}
				case 0u:
					break;
				case 1u:
					goto IL_0061;
				default:
					return result;
				}
				break;
			}
			goto IL_003b;
			IL_003b:
			num = 1819457933;
			goto IL_0040;
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
				int num = -1726064318;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFF8773B8u) % 3u)
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
					num = (int)((num2 * 153853860) ^ 0x4142135F);
				}
			}
		}
		set
		{
			while (true)
			{
				int num = -383869905;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA40BB774u) % 3u)
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
					num = ((int)num2 * -780649056) ^ 0x88C7D82;
				}
			}
		}
	}

	internal static Bitmap FoundDatePatte
	{
		get
		{
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Expected O, but got Unknown
			object obj = default(object);
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = -1769497635;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB4E855BFu) % 5u)
					{
					case 4u:
						obj = Resources.smethod_3(ResourceManager, "FoundDatePatte", resourceCulture);
						num = ((int)num2 * -839758739) ^ -650224541;
						continue;
					case 2u:
						num = ((int)num2 * -1308971356) ^ -1635500490;
						continue;
					case 1u:
						result = (Bitmap)obj;
						num = ((int)num2 * -127959727) ^ -1689444320;
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
