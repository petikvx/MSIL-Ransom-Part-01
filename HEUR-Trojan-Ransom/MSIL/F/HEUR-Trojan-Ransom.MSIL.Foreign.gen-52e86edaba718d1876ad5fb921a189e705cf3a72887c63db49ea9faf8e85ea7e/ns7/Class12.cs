using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ns7;

[DebuggerNonUserCode]
[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
internal sealed class Class12
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	[NonSerialized]
	internal static GetString getString_0;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (resourceManager_0 == null)
			{
				resourceManager_0 = new ResourceManager(getString_0(107394096), typeof(Class12).Assembly);
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

	internal static byte[] bool_roll
	{
		get
		{
			object @object = ResourceManager.GetObject(getString_0(107394091), cultureInfo_0);
			return (byte[])@object;
		}
	}

	internal Class12()
	{
	}

	static Class12()
	{
		Strings.CreateGetStringDelegate(typeof(Class12));
	}
}
