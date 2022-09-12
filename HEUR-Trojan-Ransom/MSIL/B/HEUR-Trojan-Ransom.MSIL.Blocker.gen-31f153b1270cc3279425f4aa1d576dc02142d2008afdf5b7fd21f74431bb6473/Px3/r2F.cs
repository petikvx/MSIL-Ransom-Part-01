using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Mr2;

namespace Px3;

[HideModuleName]
[StandardModule]
internal sealed class r2F
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 9552)]
	private struct e5W
	{
	}

	private static readonly object O;

	private static readonly object P;

	private static readonly object u;

	internal static byte l/* Not supported: data(00) */;

	[HelpKeyword("My.Settings")]
	internal static Wg2 Settings => Wg2.Default;

	static r2F()
	{
		P = new char[4776];
		char[] array = new char[8];
		array[2] = '\u0dd6';
		array[7] = '㈥';
		array[3] = '⹀';
		array[0] = 'ᝐ';
		array[1] = 'ࣀ';
		array[6] = 'г';
		array[5] = '⭆';
		array[4] = 'Ῥ';
		u = new string[279];
		O = array;
	}
}
