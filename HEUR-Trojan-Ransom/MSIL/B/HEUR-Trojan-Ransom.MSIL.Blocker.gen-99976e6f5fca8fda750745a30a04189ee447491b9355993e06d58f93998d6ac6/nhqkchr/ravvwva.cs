using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Navigation;
using jjnmlvx;

namespace nhqkchr;

public class ravvwva : PageFunction<string>, IComponentConnector
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 404)]
	private struct vgnxzhz
	{
	}

	internal static Assembly E;

	private bool X;

	private static readonly object d;

	private static readonly Array T = new char[202];

	private static readonly Array L;

	internal static byte H/* Not supported: data(00) */;

	internal static void M(byte[] byte_0, int int_0, int int_1, out int zialczd)
	{
		while (int_0 > 0)
		{
			if (int_0 >= dfehscp.I)
			{
				if (dfehscp.W.CanTransformMultipleBlocks)
				{
					int num = int_0 / dfehscp.I;
					int num2 = num * dfehscp.I;
					byte[] array = new byte[num * dfehscp.S];
					int int_2 = dfehscp.W.TransformBlock(byte_0, int_1, num2, array, 0);
					int_1 = E(array, int_2, int_1, num2, ref int_0);
				}
				else
				{
					dfehscp.U.Write(dfehscp.t, 0, dfehscp.W.TransformBlock(byte_0, int_1, dfehscp.I, dfehscp.t, 0));
					int_1 += dfehscp.I;
					int_0 -= dfehscp.I;
				}
				continue;
			}
			Buffer.BlockCopy(byte_0, int_1, dfehscp.K, 0, int_0);
			dfehscp.j += int_0;
			break;
		}
		zialczd = 0;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!X)
		{
			X = true;
			Uri uri = new Uri("/Release;component/pagefunction1.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	private void W(int connectionId, object target)
	{
		X = true;
	}

	[CompilerGenerated]
	internal static int E(byte[] byte_0, int int_0, int int_1, int int_2, ref int int_3)
	{
		dfehscp.U.Write(byte_0, 0, int_0);
		int_1 += int_2;
		int_3 -= int_2;
		return int_1;
	}

	static ravvwva()
	{
		char[] array = new char[8];
		array[2] = 'ਲ';
		array[4] = 'ヺ';
		array[6] = 'ჾ';
		array[5] = '•';
		array[7] = '\u197d';
		array[3] = 'ᾙ';
		array[1] = 'ⓠ';
		array[0] = '\u0891';
		L = new string[11];
		d = array;
	}
}
