using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using Hk68;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace p8T6;

[StandardModule]
[HideModuleName]
internal sealed class Xa1q
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 4912)]
	private struct Xo34
	{
	}

	private static readonly object s;

	private static readonly object A;

	private static readonly Array g;

	internal static byte J/* Not supported: data(00) */;

	[HelpKeyword("My.Settings")]
	internal static Kj71 Settings => Kj71.Default;

	static Xa1q()
	{
		A = new char[2456];
		char[] array = new char[8];
		array[5] = '⦗';
		array[3] = 'Ɽ';
		array[1] = '⨿';
		array[6] = '⇽';
		array[0] = 'ڂ';
		array[4] = '☥';
		array[2] = 'ᘝ';
		array[7] = '㨂';
		g = new string[126];
		s = array;
	}
}
