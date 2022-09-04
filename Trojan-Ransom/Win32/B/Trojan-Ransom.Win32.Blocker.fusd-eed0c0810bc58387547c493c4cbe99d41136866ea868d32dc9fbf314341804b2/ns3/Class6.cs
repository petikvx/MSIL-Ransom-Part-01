using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns5;

namespace ns3;

[DebuggerNonUserCode]
[CompilerGenerated]
[StandardModule]
[HideModuleName]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
internal sealed class Class6
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager DBlqEw
	{
		get
		{
			if (object.ReferenceEquals(resourceManager_0, null))
			{
				ResourceManager resourceManager = (resourceManager_0 = new ResourceManager(Class9.smethod_27(), typeof(Class6).Assembly));
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

	internal static byte[] hbAIFM
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(DBlqEw.GetObject(Class9.smethod_28(), cultureInfo_0));
			return (byte[])objectValue;
		}
	}

	internal static byte[] skpWdB
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(DBlqEw.GetObject(Class9.smethod_29(), cultureInfo_0));
			return (byte[])objectValue;
		}
	}
}
