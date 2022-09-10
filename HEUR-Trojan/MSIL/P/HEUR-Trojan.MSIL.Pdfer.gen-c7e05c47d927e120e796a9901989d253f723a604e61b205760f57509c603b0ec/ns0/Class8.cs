using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

[HideModuleName]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[StandardModule]
internal sealed class Class8
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1414599)]
	private struct Struct1
	{
	}

	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	internal static byte byte_0/* Not supported: data(00) */;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager_0
	{
		get
		{
			if (object.ReferenceEquals(resourceManager_0, null))
			{
				ResourceManager resourceManager = (resourceManager_0 = new ResourceManager("ns0.Class8", typeof(Class8).Assembly));
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

	[SpecialName]
	internal static byte[] smethod_0()
	{
		return (byte[])RuntimeHelpers.GetObjectValue(ResourceManager_0.GetObject("gift", cultureInfo_0));
	}

	[SpecialName]
	internal static byte[] smethod_1()
	{
		return (byte[])RuntimeHelpers.GetObjectValue(ResourceManager_0.GetObject("project", cultureInfo_0));
	}
}
