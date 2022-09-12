using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace m8K;

[HideModuleName]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[StandardModule]
internal sealed class Xa1
{
	private static ResourceManager Y;

	private static CultureInfo C;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager O
	{
		get
		{
			if (object.ReferenceEquals(Y, null))
			{
				object obj = new ResourceManager("WindowsApp1.Resources", typeof(Xa1).Assembly);
				Y = obj as ResourceManager;
			}
			object y = Y;
			return y as ResourceManager;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo x
	{
		get
		{
			IFormatProvider c = C;
			return c as CultureInfo;
		}
		set
		{
			C = value;
		}
	}

	internal static byte[] x
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(O.GetObject("mM", C));
			object obj = (byte[])objectValue;
			return (byte[])obj;
		}
	}
}
