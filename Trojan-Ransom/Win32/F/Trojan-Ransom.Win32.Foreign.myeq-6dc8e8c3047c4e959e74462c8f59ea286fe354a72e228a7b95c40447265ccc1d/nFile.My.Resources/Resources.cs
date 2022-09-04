using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace nFile.My.Resources;

[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[StandardModule]
[DebuggerNonUserCode]
[HideModuleName]
internal sealed class Resources
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			XGeuA1eFWTwbQuXWD2();
			if (Ggrv6nKj68UaZ00rta() && object.ReferenceEquals(resourceMan, null))
			{
				ResourceManager resourceManager = (resourceMan = new ResourceManager("nFile.Resources", typeof(Resources).Assembly));
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

	internal static byte[] nFile
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(((ResourceManager)VROLxP6HHYNUxNabCS()).GetObject("nFile", resourceCulture));
			return (byte[])objectValue;
		}
	}

	internal static bool Ggrv6nKj68UaZ00rta()
	{
		return true;
	}

	internal static bool XGeuA1eFWTwbQuXWD2()
	{
		return false;
	}

	internal static object VROLxP6HHYNUxNabCS()
	{
		return ResourceManager;
	}
}
