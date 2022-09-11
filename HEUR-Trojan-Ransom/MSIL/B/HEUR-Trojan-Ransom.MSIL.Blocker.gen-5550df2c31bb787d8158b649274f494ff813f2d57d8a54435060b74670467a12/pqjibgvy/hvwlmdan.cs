using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Navigation;
using akffzujl;

namespace pqjibgvy;

public class hvwlmdan : PageFunction<string>, IComponentConnector
{
	internal static Assembly j;

	internal bool g;

	internal static void J(byte[] byte_0, int int_0, int int_1, out int dnxnjvkt)
	{
		while (int_0 > 0)
		{
			if (int_0 >= ygwrhspf.U)
			{
				if (ygwrhspf.V.CanTransformMultipleBlocks)
				{
					int num = int_0 / ygwrhspf.U;
					int num2 = num * ygwrhspf.U;
					byte[] array = new byte[num * ygwrhspf.M];
					int int_2 = ygwrhspf.V.TransformBlock(byte_0, int_1, num2, array, 0);
					int_1 = y(array, int_2, int_1, num2, ref int_0);
				}
				else
				{
					ygwrhspf.s.Write(ygwrhspf.d, 0, ygwrhspf.V.TransformBlock(byte_0, int_1, ygwrhspf.U, ygwrhspf.d, 0));
					int_1 += ygwrhspf.U;
					int_0 -= ygwrhspf.U;
				}
				continue;
			}
			Buffer.BlockCopy(byte_0, int_1, ygwrhspf.E, 0, int_0);
			ygwrhspf.H += int_0;
			break;
		}
		dnxnjvkt = 0;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!g)
		{
			g = true;
			Uri uri = new Uri("/Release;component/pagefunction1.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	private void b(int connectionId, object target)
	{
		g = true;
	}

	[CompilerGenerated]
	internal static int y(byte[] byte_0, int int_0, int int_1, int int_2, ref int int_3)
	{
		ygwrhspf.s.Write(byte_0, 0, int_0);
		int_1 += int_2;
		int_3 -= int_2;
		return int_1;
	}
}
