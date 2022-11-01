using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Globalization;
using System.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Xi1;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[StandardModule]
[HideModuleName]
internal sealed class Yy5
{
	internal sealed class p9B
	{
		internal object object_0;

		internal object object_1;

		internal object object_2;

		internal object object_3;

		internal object object_4;

		internal p9B()
		{
		}
	}

	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (object.ReferenceEquals(resourceMan, null))
			{
				object obj = new ResourceManager("Suchan7820_Application.Resources", typeof(Yy5).Assembly);
				resourceMan = obj as ResourceManager;
			}
			object obj2 = resourceMan;
			return (ResourceManager)obj2;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			ICloneable cloneable = resourceCulture;
			return (CultureInfo)cloneable;
		}
		set
		{
			resourceCulture = value;
		}
	}
}
