using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace yulxosjb;

[DebuggerNonUserCode]
[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
internal sealed class vsbrgmab
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 404)]
	private struct prbgnrpw
	{
	}

	private static ResourceManager e;

	private static CultureInfo J;

	private static readonly object u;

	private static readonly object h = new char[202];

	private static readonly Array f;

	internal static byte R/* Not supported: data(00) */;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager j
	{
		get
		{
			if (e == null)
			{
				e = new ResourceManager("V.H", typeof(vsbrgmab).Assembly);
			}
			return e;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo I
	{
		get
		{
			return J;
		}
		set
		{
			J = value;
		}
	}

	internal vsbrgmab()
	{
	}

	static vsbrgmab()
	{
		char[] array = new char[8];
		array[1] = '⨧';
		array[3] = 'ㅫ';
		array[2] = '㚶';
		array[0] = 'ᆱ';
		array[6] = '෴';
		array[5] = '⽤';
		array[7] = 'ሙ';
		array[4] = '⍧';
		f = new string[11];
		u = array;
	}
}
