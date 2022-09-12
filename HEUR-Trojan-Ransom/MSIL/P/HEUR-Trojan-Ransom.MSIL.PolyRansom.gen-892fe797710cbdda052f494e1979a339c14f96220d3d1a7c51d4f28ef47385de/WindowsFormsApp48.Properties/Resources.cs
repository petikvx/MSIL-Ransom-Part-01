using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace WindowsFormsApp48.Properties;

[DebuggerNonUserCode]
[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
internal class Resources
{
	private static ResourceManager _Event;

	private static CultureInfo _Error;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (_Event == null)
			{
				ResourceManager resourceManager = (_Event = new ResourceManager("WindowsFormsApp48.Properties.Resources", typeof(Resources).Assembly));
			}
			return _Event;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return _Error;
		}
		set
		{
			_Error = value;
		}
	}

	internal static byte[] Rihxum
	{
		get
		{
			object @object = ResourceManager.GetObject("Rihxum", _Error);
			return (byte[])@object;
		}
	}

	internal Resources()
	{
	}
}
