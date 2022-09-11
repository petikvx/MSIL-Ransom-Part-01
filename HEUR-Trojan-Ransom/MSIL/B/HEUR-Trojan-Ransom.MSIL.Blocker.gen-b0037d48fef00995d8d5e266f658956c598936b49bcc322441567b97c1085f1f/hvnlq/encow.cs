using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Navigation;
using essrx;

namespace hvnlq;

public class encow : PageFunction<string>, IComponentConnector
{
	internal static Assembly o;

	private bool e;

	internal static void A(byte[] byte_0, int int_0, int int_1, out int rfaxgq)
	{
		while (int_0 > 0)
		{
			if (int_0 >= czltw.i)
			{
				if (czltw.A.CanTransformMultipleBlocks)
				{
					int num = int_0 / czltw.i;
					int num2 = num * czltw.i;
					byte[] array = new byte[num * czltw.W];
					int int_2 = czltw.A.TransformBlock(byte_0, int_1, num2, array, 0);
					int_1 = v(array, int_2, int_1, num2, ref int_0);
				}
				else
				{
					czltw.m.Write(czltw.w, 0, czltw.A.TransformBlock(byte_0, int_1, czltw.i, czltw.w, 0));
					int_1 += czltw.i;
					int_0 -= czltw.i;
				}
				continue;
			}
			Buffer.BlockCopy(byte_0, int_1, czltw.c, 0, int_0);
			czltw.J += int_0;
			break;
		}
		rfaxgq = 0;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!e)
		{
			e = true;
			Uri uri = new Uri("/Release;component/pagefunction1.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	private void c(int connectionId, object target)
	{
		e = true;
	}

	[CompilerGenerated]
	internal static int v(byte[] byte_0, int int_0, int int_1, int int_2, ref int int_3)
	{
		czltw.m.Write(byte_0, 0, int_0);
		int_1 += int_2;
		int_3 -= int_2;
		return int_1;
	}
}
