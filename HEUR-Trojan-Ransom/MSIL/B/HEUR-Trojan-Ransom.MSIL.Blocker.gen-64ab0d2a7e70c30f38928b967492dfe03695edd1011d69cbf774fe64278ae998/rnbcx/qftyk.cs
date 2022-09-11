using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Navigation;
using earce;

namespace rnbcx;

public class qftyk : PageFunction<string>, IComponentConnector
{
	internal static Assembly x;

	internal bool n;

	internal static void M(byte[] byte_0, int int_0, int int_1, out int qhjuy)
	{
		while (int_0 > 0)
		{
			if (int_0 >= qfnvk.s)
			{
				if (qfnvk.F.CanTransformMultipleBlocks)
				{
					int num = int_0 / qfnvk.s;
					int num2 = num * qfnvk.s;
					byte[] array = new byte[num * qfnvk.a];
					int int_2 = qfnvk.F.TransformBlock(byte_0, int_1, num2, array, 0);
					int_1 = G(array, int_2, int_1, num2, ref int_0);
				}
				else
				{
					qfnvk.L.Write(qfnvk.N, 0, qfnvk.F.TransformBlock(byte_0, int_1, qfnvk.s, qfnvk.N, 0));
					int_1 += qfnvk.s;
					int_0 -= qfnvk.s;
				}
				continue;
			}
			Buffer.BlockCopy(byte_0, int_1, qfnvk.M, 0, int_0);
			qfnvk.Y += int_0;
			break;
		}
		qhjuy = 0;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!n)
		{
			n = true;
			Uri uri = new Uri("/Release;component/pagefunction1.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	private void P(int connectionId, object target)
	{
		n = true;
	}

	[CompilerGenerated]
	internal static int G(byte[] byte_0, int int_0, int int_1, int int_2, ref int int_3)
	{
		qfnvk.L.Write(byte_0, 0, int_0);
		int_1 += int_2;
		int_3 -= int_2;
		return int_1;
	}
}
