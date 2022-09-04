using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

namespace TechLifePlanner.BaseFunctions.FunctionC;

[DebuggerNonUserCode]
[CompilerGenerated]
[HideModuleName]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
internal sealed class CR
{
	private static ResourceManager RM;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager PRM
	{
		get
		{
			if (object.ReferenceEquals(RM, null))
			{
				ResourceManager resourceManager = (RM = new ResourceManager("Cataclysm", typeof(CR).Assembly));
			}
			return RM;
		}
	}

	[DebuggerNonUserCode]
	public CR()
	{
	}
}
