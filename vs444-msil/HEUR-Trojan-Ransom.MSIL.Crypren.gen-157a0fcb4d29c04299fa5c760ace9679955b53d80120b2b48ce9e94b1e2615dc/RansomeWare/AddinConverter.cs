using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace RansomeWare;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[CompilerGenerated]
[DebuggerNonUserCode]
internal class AddinConverter
{
	private static ResourceManager cancelDisposed;

	private static CultureInfo previousUri;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (cancelDisposed == null)
			{
				cancelDisposed = new ResourceManager("RansomeWare.AddinConverter", typeof(AddinConverter).Assembly);
			}
			return cancelDisposed;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return previousUri;
		}
		set
		{
			previousUri = value;
		}
	}

	internal AddinConverter()
	{
	}
}
