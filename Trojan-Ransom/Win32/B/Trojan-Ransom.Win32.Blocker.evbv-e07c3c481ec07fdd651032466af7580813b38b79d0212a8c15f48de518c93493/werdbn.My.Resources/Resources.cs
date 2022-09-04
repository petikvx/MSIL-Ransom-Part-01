using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace werdbn.My.Resources;

[HideModuleName]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[StandardModule]
[DebuggerNonUserCode]
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
			_ = 0;
			if (!GCr5Ma7Nvk2KO5KFc2() || object.ReferenceEquals(resourceMan, null))
			{
				ResourceManager resourceManager = (resourceMan = new ResourceManager("werdbn.Resources", typeof(Resources).Assembly));
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

	internal static byte[] werdbn
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(B42ytvpWG2iDjq0Gda(ResourceManager, "werdbn", resourceCulture));
			return (byte[])objectValue;
		}
	}

	internal static bool GCr5Ma7Nvk2KO5KFc2()
	{
		return true;
	}

	internal static bool MehEqfKlJyq02lCPg4()
	{
		return false;
	}

	internal static object B42ytvpWG2iDjq0Gda(object object_0, object object_1, object object_2)
	{
		return ((ResourceManager)object_0).GetObject((string)object_1, (CultureInfo?)object_2);
	}
}
