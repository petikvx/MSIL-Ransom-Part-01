using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ns0;

[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[CompilerGenerated]
internal class Class1
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (resourceManager_0 == null)
			{
				ResourceManager resourceManager = (resourceManager_0 = Delegate53.smethod_0(Class4.smethod_0(2002), Delegate10.smethod_0(Delegate23.smethod_0(typeof(Class1).TypeHandle))));
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

	internal static byte[] miha
	{
		get
		{
			object obj = Delegate71.smethod_0(Delegate29.smethod_0(), Class4.smethod_0(2073), cultureInfo_0);
			return (byte[])obj;
		}
	}

	internal Class1()
	{
	}
}
