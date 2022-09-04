using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace insomnia;

[StandardModule]
[DebuggerNonUserCode]
[HideModuleName]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[CompilerGenerated]
internal sealed class Class5
{
	private static ResourceManager Field2;

	private static CultureInfo Field1;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager Property58
	{
		get
		{
			if (object.ReferenceEquals(Field2, null))
			{
				ResourceManager resourceManager = (Field2 = new ResourceManager("SQLiteHandler.Resources", typeof(Class5).Assembly));
			}
			return Field2;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Property57
	{
		get
		{
			return Field1;
		}
		set
		{
			Field1 = value;
		}
	}
}
