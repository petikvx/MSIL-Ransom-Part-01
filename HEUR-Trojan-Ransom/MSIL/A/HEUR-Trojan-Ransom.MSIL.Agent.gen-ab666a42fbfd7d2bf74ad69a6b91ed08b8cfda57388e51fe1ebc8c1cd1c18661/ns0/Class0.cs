using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B53EE5BDF_002DC925_002D45D0_002DBB4F_002D1DE255E331E5_007D;

namespace ns0;

[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
internal class Class0
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager_0
	{
		get
		{
			if (resourceManager_0 == null)
			{
				ResourceManager resourceManager = (resourceManager_0 = new ResourceManager("ns0.Class0", typeof(Class0).Assembly));
			}
			return resourceManager_0;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo CultureInfo_0
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

	internal Class0()
	{
	}

	[SpecialName]
	internal static byte[] smethod_0()
	{
		object @object = ResourceManager_0.GetObject(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_1(), cultureInfo_0);
		return (byte[])@object;
	}

	[SpecialName]
	internal static byte[] smethod_1()
	{
		object @object = ResourceManager_0.GetObject(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_2(), cultureInfo_0);
		return (byte[])@object;
	}
}
