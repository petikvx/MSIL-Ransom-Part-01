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
			bool flag = resourceMan == null;
			ResourceManager result = default(ResourceManager);
			while (true)
			{
				int num = -850628403;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFD050814u) % 6u)
					{
					case 5u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 1381950071;
							num4 = 1381950071;
						}
						else
						{
							num3 = 382418942;
							num4 = 382418942;
						}
						num = num3 ^ (int)(num2 * 1646038557);
						continue;
					}
					case 4u:
						num = ((int)num2 * -1105640326) ^ -2125225205;
						continue;
					case 1u:
						result = resourceMan;
						num = -2141827751;
						continue;
					case 0u:
					{
						ResourceManager resourceManager = (resourceMan = Resources.smethod_2("Cytotechnologist.Properties.Resources", Resources.smethod_1(Resources.smethod_0(typeof(Resources).TypeHandle))));
						num = (int)(num2 * 1662232973) ^ -245433958;
						continue;
					}
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
				int num = 657570299;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x16518A16u) % 3u)
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
					num = (int)((num2 * 138909973) ^ 0x43789B0);
				}
			}
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static Bitmap EvidenceTypeDescript
	{
		get
		{
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Expected O, but got Unknown
			object obj = default(object);
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = -1160286687;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB9C34963u) % 5u)
					{
					case 3u:
						obj = Resources.smethod_3(ResourceManager, "EvidenceTypeDescript", resourceCulture);
						num = (int)(num2 * 774910625) ^ -208504497;
						continue;
					case 2u:
						num = ((int)num2 * -213905416) ^ -317928795;
						continue;
					case 1u:
						result = (Bitmap)obj;
						num = (int)(num2 * 912503823) ^ -1525148337;
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
