using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[CompilerGenerated]
[DebuggerNonUserCode]
internal class TypeNameParserHelper
{
	private static ResourceManager HeaderOffset;

	private static CultureInfo InternalAppendAllText;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager InternalRegisteredWait
	{
		get
		{
			if (HeaderOffset == null)
			{
				ResourceManager resourceManager = (HeaderOffset = new ResourceManager("TypeNameParserHelper", typeof(TypeNameParserHelper).Assembly));
			}
			return HeaderOffset;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo InternalResolve
	{
		get
		{
			return InternalAppendAllText;
		}
		set
		{
			InternalAppendAllText = value;
		}
	}

	internal static Bitmap HasBigStrings
	{
		get
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			object @object = InternalRegisteredWait.GetObject("wl", InternalAppendAllText);
			return (Bitmap)@object;
		}
	}

	internal TypeNameParserHelper()
	{
	}
}
