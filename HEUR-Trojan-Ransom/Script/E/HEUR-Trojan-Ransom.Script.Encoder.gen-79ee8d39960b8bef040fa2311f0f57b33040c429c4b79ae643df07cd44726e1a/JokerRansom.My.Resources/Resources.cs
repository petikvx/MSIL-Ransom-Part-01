using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace JokerRansom.My.Resources;

[StandardModule]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
[DebuggerNonUserCode]
[HideModuleName]
[CompilerGenerated]
internal sealed class Resources
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (object.ReferenceEquals(resourceMan, null))
			{
				ResourceManager resourceManager = (resourceMan = new ResourceManager("JokerRansom.Resources", typeof(Resources).Assembly));
			}
			return resourceMan;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return resourceCulture;
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static byte[] lockr
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("lockr", resourceCulture));
			return (byte[])objectValue;
		}
	}

	internal static byte[] MBR
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("MBR", resourceCulture));
			return (byte[])objectValue;
		}
	}

	internal static byte[] note
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("note", resourceCulture));
			return (byte[])objectValue;
		}
	}
}
