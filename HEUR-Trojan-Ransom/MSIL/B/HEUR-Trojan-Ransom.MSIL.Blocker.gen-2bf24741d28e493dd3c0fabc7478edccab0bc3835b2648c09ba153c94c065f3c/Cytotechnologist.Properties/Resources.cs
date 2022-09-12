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
			ResourceManager resourceManager = default(ResourceManager);
			while (true)
			{
				int num = -1030554621;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x825A61D9u) % 7u)
					{
					case 6u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -1710099952;
							num4 = -1710099952;
						}
						else
						{
							num3 = -1532440402;
							num4 = -1532440402;
						}
						num = num3 ^ (int)(num2 * 1776261784);
						continue;
					}
					case 5u:
						result = resourceMan;
						num = -989344287;
						continue;
					case 4u:
						resourceManager = Resources.smethod_2("Cytotechnologist.Properties.Resources", Resources.smethod_1(Resources.smethod_0(typeof(Resources).TypeHandle)));
						num = (int)((num2 * 1319462102) ^ 0x2D93C753);
						continue;
					case 3u:
						resourceMan = resourceManager;
						num = ((int)num2 * -272471002) ^ -1412218584;
						continue;
					case 1u:
						flag = resourceMan == null;
						num = ((int)num2 * -1757331912) ^ -1624807916;
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
	internal static CultureInfo Culture
	{
		get
		{
			CultureInfo result = default(CultureInfo);
			while (true)
			{
				int num = -1281168036;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBFF63276u) % 3u)
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
					num = ((int)num2 * -2063073908) ^ 0x6FD110C6;
				}
			}
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static Bitmap NullTypeIn
	{
		get
		{
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Expected O, but got Unknown
			object obj = default(object);
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = -1031874164;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8F8FA481u) % 5u)
					{
					case 4u:
						num = ((int)num2 * -1846146163) ^ -554045151;
						continue;
					case 1u:
						obj = Resources.smethod_3(ResourceManager, "NullTypeIn", resourceCulture);
						num = ((int)num2 * -1169309461) ^ 0x37093C0;
						continue;
					case 0u:
						result = (Bitmap)obj;
						num = (int)((num2 * 509987140) ^ 0x4BCA0184);
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

	internal Resources()
	{
		while (true)
		{
			int num = 2017006999;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x26F9E27Bu) % 3u)
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
				num = ((int)num2 * -519974549) ^ -1200243555;
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
