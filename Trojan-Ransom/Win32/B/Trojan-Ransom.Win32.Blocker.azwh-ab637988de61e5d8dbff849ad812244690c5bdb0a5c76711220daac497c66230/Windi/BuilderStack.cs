using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Windi;

[HideModuleName]
[DebuggerNonUserCode]
[CompilerGenerated]
[StandardModule]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
internal sealed class BuilderStack
{
	private static ResourceManager logLength;

	private static CultureInfo currentNames;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (object.ReferenceEquals(logLength, null))
			{
				ResourceManager resourceManager = (logLength = new ResourceManager("Windi.Resources", typeof(BuilderStack).Assembly));
			}
			return logLength;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return currentNames;
		}
		set
		{
			currentNames = value;
		}
	}
}
