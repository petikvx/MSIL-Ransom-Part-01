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
			ResourceManager result = default(ResourceManager);
			ResourceManager resourceManager = default(ResourceManager);
			while (true)
			{
				int num = 502981432;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7820D09Cu) % 7u)
					{
					case 6u:
						result = resourceMan;
						num = 29873508;
						continue;
					case 5u:
						num = ((int)num2 * -1687867472) ^ 0x41CC9544;
						continue;
					case 3u:
						resourceManager = Veet.smethod_2("Cytotechnologist.Veet", Veet.smethod_1(Veet.smethod_0(typeof(Veet).TypeHandle)));
						num = (int)(num2 * 850711282) ^ -556314829;
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (resourceMan == null)
						{
							num3 = 2115877373;
							num4 = 2115877373;
						}
						else
						{
							num3 = 557251379;
							num4 = 557251379;
						}
						num = num3 ^ (int)(num2 * 1661562753);
						continue;
					}
					case 1u:
						resourceMan = resourceManager;
						num = ((int)num2 * -1362060899) ^ -1243061900;
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			CultureInfo result = resourceCulture;
			while (true)
			{
				int num = -1951997166;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAAFA7660u) % 3u)
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
					num = ((int)num2 * -1544341604) ^ 0x15E4E9D7;
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
				int num = 370796993;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x49FC1944u) % 4u)
					{
					case 1u:
						result = Veet.smethod_3(ResourceManager, "Sa", resourceCulture);
						num = ((int)num2 * -1797552466) ^ 0x52E66FCA;
						continue;
					case 0u:
						num = ((int)num2 * -795962266) ^ -1846646146;
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

	internal static string Xe
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = 693281526;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1C80A910u) % 4u)
					{
					case 3u:
						num = ((int)num2 * -465731564) ^ 0x1067B66D;
						continue;
					case 2u:
						result = Veet.smethod_3(ResourceManager, "Xe", resourceCulture);
						num = ((int)num2 * -309422521) ^ -200155;
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

	internal static string Zr
	{
		get
		{
			string result = Veet.smethod_3(ResourceManager, "Zr", resourceCulture);
			while (true)
			{
				int num = -988057207;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB7429780u) % 3u)
					{
					case 1u:
						goto IL_0017;
					case 2u:
						break;
					default:
						return result;
					}
					break;
					IL_0017:
					num = ((int)num2 * -1662575819) ^ -1645526340;
				}
			}
		}
	}

	internal Veet()
	{
		while (true)
		{
			int num = -842378611;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA14ABE30u) % 4u)
				{
				case 2u:
					num = (int)((num2 * 1959712624) ^ 0x782BB90B);
					continue;
				case 1u:
					num = (int)((num2 * 1374850040) ^ 0x76E9DB96);
					continue;
				default:
					return;
				case 0u:
					break;
				case 3u:
					return;
				}
				break;
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
