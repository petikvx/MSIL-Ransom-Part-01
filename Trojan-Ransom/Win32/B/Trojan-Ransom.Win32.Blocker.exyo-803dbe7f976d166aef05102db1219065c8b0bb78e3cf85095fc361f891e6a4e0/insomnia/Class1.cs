using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace insomnia;

[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[DebuggerNonUserCode]
public class Class1
{
	private static ResourceManager Field2;

	private static CultureInfo Field1;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static ResourceManager Property69
	{
		get
		{
			if (object.ReferenceEquals(Field2, null))
			{
				ResourceManager resourceManager = (Field2 = new ResourceManager("insomnia.Properties.Resources", typeof(Class1).Assembly));
			}
			return Field2;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static CultureInfo Property68
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

	internal Class1()
	{
	}
}
