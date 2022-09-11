using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using ns0;

namespace ns1;

[DebuggerNonUserCode]
[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
internal sealed class Resources
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			int[] int_ = Class6.int_0;
			int num = 1;
			while (true)
			{
				if (resourceManager_0 == null)
				{
					num = 2;
					while (true)
					{
						resourceManager_0 = Resources.rPvgZPrGYzWmUdNFBmqPbGaQrkwK(Resources.AhuwbfoASxbZnntCLKUBJCgYaWNh(Resources.viZJERufNudjGTgcrlxJYMtmnjfu(Resources.ugXMDCStUHlPqkaMNIGKCDCxpwtmA(Resources.TgpAJzzetvrTCcvANKwziqUPtkrK())), ".Properties.Resources"), Resources.gLDdNIJgMaCTPIUuScCaWgmjqCWZA(Resources.anNcMBucIQcUnGTAVIXBRfipndjb(typeof(Resources).TypeHandle)));
						switch (int_[289])
						{
						case 51002:
						case 51003:
							break;
						default:
							goto end_IL_000c;
						case 51000:
						case 51004:
						case 51005:
							goto end_IL_006a;
						}
						continue;
						end_IL_000c:
						break;
					}
					continue;
				}
				num = 5;
				break;
				continue;
				end_IL_006a:
				break;
			}
			return resourceManager_0;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return cultureInfo_0;
		}
		set
		{
			cultureInfo_0 = value;
		}
	}

	internal static byte[] c => (byte[])Resources.bGMOTbyFNxjgqgcaoNegojkBdEBUA(ResourceManager, "c", cultureInfo_0);

	internal Resources()
	{
	}

	static Assembly TgpAJzzetvrTCcvANKwziqUPtkrK()
	{
		return Assembly.GetCallingAssembly();
	}

	static AssemblyName ugXMDCStUHlPqkaMNIGKCDCxpwtmA(Assembly assembly_0)
	{
		return assembly_0.GetName();
	}

	static string viZJERufNudjGTgcrlxJYMtmnjfu(AssemblyName assemblyName_0)
	{
		return assemblyName_0.Name;
	}

	static string AhuwbfoASxbZnntCLKUBJCgYaWNh(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static Type anNcMBucIQcUnGTAVIXBRfipndjb(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static Assembly gLDdNIJgMaCTPIUuScCaWgmjqCWZA(Type type_0)
	{
		return type_0.Assembly;
	}

	static ResourceManager rPvgZPrGYzWmUdNFBmqPbGaQrkwK(string string_0, Assembly assembly_0)
	{
		return new ResourceManager(string_0, assembly_0);
	}

	static object bGMOTbyFNxjgqgcaoNegojkBdEBUA(ResourceManager resourceManager_1, string string_0, CultureInfo cultureInfo_1)
	{
		return resourceManager_1.GetObject(string_0, cultureInfo_1);
	}
}
