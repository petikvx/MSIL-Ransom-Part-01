using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns10;

[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[DebuggerNonUserCode]
internal sealed class Class11
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 48)]
	private struct Struct0
	{
	}

	private static ResourceManager y;

	private static CultureInfo L;

	private static readonly object i;

	private static readonly object B = new char[24];

	private static readonly object J;

	internal static byte A/* Not supported: data(00) */;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager c
	{
		get
		{
			if (y == null)
			{
				y = new ResourceManager("q.h", typeof(Class11).Assembly);
			}
			return y;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo C
	{
		get
		{
			return L;
		}
		set
		{
			L = value;
		}
	}

	internal Class11()
	{
	}

	static Class11()
	{
		char[] array = new char[8];
		array[0] = 'প';
		array[7] = '⽹';
		array[2] = '㔙';
		array[3] = '⛌';
		array[6] = 'Ḑ';
		array[4] = '᮳';
		array[1] = 'ᱤ';
		array[5] = 'ᘲ';
		J = new string[2];
		i = array;
	}
}
