using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[DebuggerNonUserCode]
[StandardModule]
[HideModuleName]
[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
internal sealed class Class6
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager_0
	{
		get
		{
			if (object.ReferenceEquals(resourceManager_0, null))
			{
				ResourceManager resourceManager = (resourceManager_0 = new ResourceManager("stub.Resources", typeof(Class6).Assembly));
			}
			return resourceManager_0;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo CultureInfo_0
	{
		set
		{
			cultureInfo_0 = value;
		}
	}

	[SpecialName]
	internal static byte[] smethod_0()
	{
		object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager_0.GetObject("explorer", cultureInfo_0));
		return (byte[])objectValue;
	}

	[SpecialName]
	internal static byte[] smethod_1()
	{
		object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager_0.GetObject("spwak", cultureInfo_0));
		return (byte[])objectValue;
	}
}
