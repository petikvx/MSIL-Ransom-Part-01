using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Navigation;
using nclou;

namespace whjwk;

public class vyrbz : PageFunction<string>, IComponentConnector
{
	internal static Assembly b;

	private bool X;

	internal static void A(byte[] byte_0, int int_0, int int_1, out int oblca)
	{
		while (int_0 > 0)
		{
			if (int_0 >= wlqzy.L)
			{
				if (wlqzy.X.CanTransformMultipleBlocks)
				{
					int num = int_0 / wlqzy.L;
					int num2 = num * wlqzy.L;
					byte[] array = new byte[num * wlqzy.K];
					int int_2 = wlqzy.X.TransformBlock(byte_0, int_1, num2, array, 0);
					int_1 = D(array, int_2, int_1, num2, ref int_0);
				}
				else
				{
					wlqzy.b.Write(wlqzy.B, 0, wlqzy.X.TransformBlock(byte_0, int_1, wlqzy.L, wlqzy.B, 0));
					int_1 += wlqzy.L;
					int_0 -= wlqzy.L;
				}
				continue;
			}
			Buffer.BlockCopy(byte_0, int_1, wlqzy.X, 0, int_0);
			wlqzy.s += int_0;
			break;
		}
		oblca = 0;
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

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	private void t(int connectionId, object target)
	{
		X = true;
	}

	[CompilerGenerated]
	internal static int D(byte[] byte_0, int int_0, int int_1, int int_2, ref int int_3)
	{
		wlqzy.b.Write(byte_0, 0, int_0);
		int_1 += int_2;
		int_3 -= int_2;
		return int_1;
	}
}
