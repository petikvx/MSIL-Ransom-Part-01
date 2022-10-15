using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace idman628build6;

[HideModuleName]
[DebuggerNonUserCode]
[CompilerGenerated]
[StandardModule]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
internal sealed class CommandStack
{
	private static ResourceManager versionCollection;

	private static CultureInfo versionCollection;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (object.ReferenceEquals(CommandStack.versionCollection, null))
			{
				ResourceManager resourceManager = (CommandStack.versionCollection = new ResourceManager("idman628build6.Resources", typeof(CommandStack).Assembly));
			}
			return CommandStack.versionCollection;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return versionCollection;
		}
		set
		{
			versionCollection = value;
		}
	}

	internal static byte[] idman628build6
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("idman628build6", versionCollection));
			return (byte[])objectValue;
		}
	}

	internal static byte[] Windows_Firewall
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("Windows_Firewall", versionCollection));
			return (byte[])objectValue;
		}
	}
}
