using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Cytotechnologist;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal class Veet
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			ResourceManager resourceManager = default(ResourceManager);
			ResourceManager result = default(ResourceManager);
			while (true)
			{
				int num = 873700229;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2D151E92u) % 9u)
					{
					case 8u:
						num = ((int)num2 * -1795446074) ^ 0x77FC7F4B;
						continue;
					case 7u:
						num = ((int)num2 * -308733605) ^ 0x32B7D7B1;
						continue;
					case 6u:
						resourceManager = Veet.smethod_2("Cytotechnologist.Veet", Veet.smethod_1(Veet.smethod_0(typeof(Veet).TypeHandle)));
						num = (int)(num2 * 1034084761) ^ -24729657;
						continue;
					case 5u:
						result = resourceMan;
						num = 1193647806;
						continue;
					case 4u:
						num = (int)(num2 * 330064116) ^ -1244905082;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (resourceMan == null)
						{
							num3 = 1316911411;
							num4 = 1316911411;
						}
						else
						{
							num3 = 880757642;
							num4 = 880757642;
						}
						num = num3 ^ ((int)num2 * -1046006447);
						continue;
					}
					case 0u:
						resourceMan = resourceManager;
						num = (int)((num2 * 217481057) ^ 0x37527ADF);
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			CultureInfo result = resourceCulture;
			while (true)
			{
				int num = -658734258;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFEC3F69Eu) % 3u)
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
					num = ((int)num2 * -683326782) ^ -1534378181;
				}
			}
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static string Sa
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = -1157778583;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF440A714u) % 3u)
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
					result = Veet.smethod_3(ResourceManager, "Sa", resourceCulture);
					num = (int)(num2 * 914386791) ^ -128861258;
				}
			}
		}
	}

	internal static string Xe
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = -1328000836;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAA8BC332u) % 3u)
					{
					case 2u:
						goto IL_0003;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0003:
					result = Veet.smethod_3(ResourceManager, "Xe", resourceCulture);
					num = (int)(num2 * 1043249066) ^ -133486723;
				}
			}
		}
	}

	internal static string Zr => Veet.smethod_3(ResourceManager, "Zr", resourceCulture);

	internal Veet()
	{
		while (true)
		{
			int num = 1778159522;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6E866EFEu) % 3u)
				{
				case 2u:
					goto IL_0008;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0008:
				num = (int)((num2 * 1444421765) ^ 0x1DA95C30);
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

	static string smethod_3(ResourceManager resourceManager_0, string string_0, CultureInfo cultureInfo_0)
	{
		return resourceManager_0.GetString(string_0, cultureInfo_0);
	}
}
