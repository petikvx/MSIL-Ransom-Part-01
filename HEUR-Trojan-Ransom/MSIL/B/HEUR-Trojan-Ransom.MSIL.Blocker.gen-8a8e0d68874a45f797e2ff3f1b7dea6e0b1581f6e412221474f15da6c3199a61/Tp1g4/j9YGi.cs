using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Globalization;
using System.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Tp1g4;

[StandardModule]
[HideModuleName]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
internal sealed class j9YGi
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
				object obj = new ResourceManager("Hotel_management.Resources", typeof(j9YGi).Assembly);
				resourceMan = (ResourceManager)obj;
			}
			object obj2 = resourceMan;
			return obj2 as ResourceManager;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			object obj = resourceCulture;
			return obj as CultureInfo;
		}
		set
		{
			resourceCulture = value;
		}
	}
}
