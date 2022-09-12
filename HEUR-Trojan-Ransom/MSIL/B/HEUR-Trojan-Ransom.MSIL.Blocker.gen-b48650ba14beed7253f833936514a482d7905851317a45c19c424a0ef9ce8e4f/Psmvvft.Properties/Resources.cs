using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Psmvvft.Properties;

[DebuggerNonUserCode]
[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
internal class Resources
{
	private static ResourceManager _List;

	private static CultureInfo _Code;

	internal static Resources WriteStub;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (_List == null)
			{
				ResourceManager resourceManager = (_List = new ResourceManager("Psmvvft.Properties.Resources", typeof(Resources).Assembly));
			}
			return _List;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return _Code;
		}
		set
		{
			_Code = value;
		}
	}

	internal Resources()
	{
	}

	internal static bool ChangeStub()
	{
		return WriteStub == null;
	}

	internal static Resources VerifyStub()
	{
		return WriteStub;
	}
}
