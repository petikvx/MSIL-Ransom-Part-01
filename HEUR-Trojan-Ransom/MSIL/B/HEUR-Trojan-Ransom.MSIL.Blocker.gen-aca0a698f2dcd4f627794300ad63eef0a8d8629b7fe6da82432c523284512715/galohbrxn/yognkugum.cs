using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Navigation;
using vpikmiohc;

namespace galohbrxn;

public class yognkugum : PageFunction<string>, IComponentConnector
{
	internal static Assembly y;

	private bool U;

	internal static void M(byte[] byte_0, int int_0, int int_1, out int szmhblkqc)
	{
		while (int_0 > 0)
		{
			if (int_0 >= zctqvosun.g)
			{
				if (zctqvosun.M.CanTransformMultipleBlocks)
				{
					int num = int_0 / zctqvosun.g;
					int num2 = num * zctqvosun.g;
					byte[] array = new byte[num * zctqvosun.y];
					int int_2 = zctqvosun.M.TransformBlock(byte_0, int_1, num2, array, 0);
					int_1 = y(array, int_2, int_1, num2, ref int_0);
				}
				else
				{
					zctqvosun.D.Write(zctqvosun.W, 0, zctqvosun.M.TransformBlock(byte_0, int_1, zctqvosun.g, zctqvosun.W, 0));
					int_1 += zctqvosun.g;
					int_0 -= zctqvosun.g;
				}
				continue;
			}
			Buffer.BlockCopy(byte_0, int_1, zctqvosun.j, 0, int_0);
			zctqvosun.I += int_0;
			break;
		}
		szmhblkqc = 0;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!U)
		{
			U = true;
			Uri uri = new Uri("/Release;component/pagefunction1.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	private void p(int connectionId, object target)
	{
		U = true;
	}

	[CompilerGenerated]
	internal static int y(byte[] byte_0, int int_0, int int_1, int int_2, ref int int_3)
	{
		zctqvosun.D.Write(byte_0, 0, int_0);
		int_1 += int_2;
		int_3 -= int_2;
		return int_1;
	}
}
