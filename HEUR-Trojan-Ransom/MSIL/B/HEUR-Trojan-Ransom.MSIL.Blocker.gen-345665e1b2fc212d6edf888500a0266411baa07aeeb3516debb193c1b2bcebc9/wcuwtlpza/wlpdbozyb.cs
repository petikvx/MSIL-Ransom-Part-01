using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Navigation;
using yncsysrkx;

namespace wcuwtlpza;

public class wlpdbozyb : PageFunction<string>, IComponentConnector
{
	internal static Assembly F;

	internal bool F;

	internal static void x(byte[] byte_0, int int_0, int int_1, out int qrxpozbtd)
	{
		while (int_0 > 0)
		{
			if (int_0 >= fxnktcice.Q)
			{
				if (fxnktcice.f.CanTransformMultipleBlocks)
				{
					int num = int_0 / fxnktcice.Q;
					int num2 = num * fxnktcice.Q;
					byte[] array = new byte[num * fxnktcice.j];
					int int_2 = fxnktcice.f.TransformBlock(byte_0, int_1, num2, array, 0);
					int_1 = r(array, int_2, int_1, num2, ref int_0);
				}
				else
				{
					fxnktcice.D.Write(fxnktcice.L, 0, fxnktcice.f.TransformBlock(byte_0, int_1, fxnktcice.Q, fxnktcice.L, 0));
					int_1 += fxnktcice.Q;
					int_0 -= fxnktcice.Q;
				}
				continue;
			}
			Buffer.BlockCopy(byte_0, int_1, fxnktcice.F, 0, int_0);
			fxnktcice.v += int_0;
			break;
		}
		qrxpozbtd = 0;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!F)
		{
			F = true;
			Uri uri = new Uri("/Release;component/pagefunction1.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	private void O(int connectionId, object target)
	{
		F = true;
	}

	[CompilerGenerated]
	internal static int r(byte[] byte_0, int int_0, int int_1, int int_2, ref int int_3)
	{
		fxnktcice.D.Write(byte_0, 0, int_0);
		int_1 += int_2;
		int_3 -= int_2;
		return int_1;
	}
}
