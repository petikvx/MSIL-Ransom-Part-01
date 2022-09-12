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
			bool flag = default(bool);
			while (true)
			{
				int num = -1794209551;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x85BD46F8u) % 8u)
					{
					case 7u:
						num = ((int)num2 * -1002368415) ^ -609866827;
						continue;
					case 6u:
						result = resourceMan;
						num = -169741409;
						continue;
					case 5u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -1349471139;
							num4 = -1349471139;
						}
						else
						{
							num3 = -1651808925;
							num4 = -1651808925;
						}
						num = num3 ^ ((int)num2 * -2110830359);
						continue;
					}
					case 3u:
					{
						ResourceManager resourceManager = (resourceMan = Resources.smethod_2("Cytotechnologist.Properties.Resources", Resources.smethod_1(Resources.smethod_0(typeof(Resources).TypeHandle))));
						num = (int)(num2 * 1279278008) ^ -308880882;
						continue;
					}
					case 1u:
						flag = resourceMan == null;
						num = ((int)num2 * -1553042370) ^ 0x3F25C9AB;
						continue;
					case 0u:
						num = ((int)num2 * -1276263743) ^ 0x376F412B;
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			CultureInfo result = default(CultureInfo);
			while (true)
			{
				int num = 300895145;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x471EDDE0u) % 3u)
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
					result = resourceCulture;
					num = ((int)num2 * -822425843) ^ -436334772;
				}
			}
		}
		set
		{
			while (true)
			{
				int num = 2113059235;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEB83106u) % 3u)
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
					num = (int)((num2 * 302189534) ^ 0xA751A83);
				}
			}
		}
	}

	internal static Bitmap MethodBuild
	{
		get
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			object obj = Resources.smethod_3(ResourceManager, "MethodBuild", resourceCulture);
			Bitmap result = (Bitmap)obj;
			while (true)
			{
				int num = -1664428885;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x85589AAFu) % 3u)
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
					num = ((int)num2 * -1722944126) ^ 0xFD48332;
				}
			}
		}
	}

	internal Resources()
	{
		while (true)
		{
			int num = 361304123;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC375BD7u) % 3u)
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
				num = ((int)num2 * -416213169) ^ -1141117691;
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
