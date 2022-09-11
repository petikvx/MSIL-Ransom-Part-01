using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns8;

[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[DebuggerNonUserCode]
internal sealed class Class7
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 124)]
	private struct Struct1
	{
	}

	private static ResourceManager V;

	private static CultureInfo m_E;

	private static readonly object e;

	private static readonly object Y = new char[62];

	private static readonly object H;

	internal static byte i/* Not supported: data(00) */;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager E
	{
		get
		{
			if (V == null)
			{
				V = new ResourceManager("G.f", typeof(Class7).Assembly);
			}
			return V;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo R
	{
		get
		{
			return Class7.m_E;
		}
		set
		{
			Class7.m_E = value;
		}
	}

	internal Class7()
	{
	}

	static Class7()
	{
		char[] array = new char[8];
		array[1] = '➀';
		array[6] = '༡';
		array[7] = '\u0952';
		array[5] = 'ѽ';
		array[4] = 'ᣓ';
		array[2] = '۳';
		array[0] = '⤠';
		array[3] = 'ᤁ';
		H = new string[4];
		e = array;
	}
}
