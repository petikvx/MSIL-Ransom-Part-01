using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace vzvmrkmzu;

[CompilerGenerated]
[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
internal sealed class ctayasgov
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 404)]
	private struct ryaphyawe
	{
	}

	private static ResourceManager c;

	private static CultureInfo A;

	private static readonly object I;

	private static readonly Array P = new char[202];

	private static readonly object L;

	internal static byte U/* Not supported: data(00) */;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager d
	{
		get
		{
			if (c == null)
			{
				c = new ResourceManager("K.R", typeof(ctayasgov).Assembly);
			}
			return c;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo o
	{
		get
		{
			return A;
		}
		set
		{
			A = value;
		}
	}

	internal ctayasgov()
	{
	}

	static ctayasgov()
	{
		char[] array = new char[8];
		array[3] = '╯';
		array[7] = '㔴';
		array[1] = 'ῦ';
		array[5] = 'ṽ';
		array[4] = 'ஸ';
		array[0] = '㗵';
		array[6] = '\u0483';
		array[2] = '\u175a';
		L = new string[11];
		I = array;
	}
}
