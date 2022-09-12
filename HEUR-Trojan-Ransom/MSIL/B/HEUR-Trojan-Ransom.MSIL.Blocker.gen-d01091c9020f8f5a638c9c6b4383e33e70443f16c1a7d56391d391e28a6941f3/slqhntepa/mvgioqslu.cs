using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Navigation;
using betcmswos;

namespace slqhntepa;

public class mvgioqslu : PageFunction<string>, IComponentConnector
{
	internal static Assembly J;

	internal bool K;

	internal static void n(byte[] byte_0, int int_0, int int_1, out int urzhgigvw)
	{
		while (int_0 > 0)
		{
			if (int_0 >= ldwqswnax.K)
			{
				if (ldwqswnax.o.CanTransformMultipleBlocks)
				{
					int num = int_0 / ldwqswnax.K;
					int num2 = num * ldwqswnax.K;
					byte[] array = new byte[num * ldwqswnax.C];
					int int_2 = ldwqswnax.o.TransformBlock(byte_0, int_1, num2, array, 0);
					int_1 = G(array, int_2, int_1, num2, ref int_0);
				}
				else
				{
					ldwqswnax.B.Write(ldwqswnax.j, 0, ldwqswnax.o.TransformBlock(byte_0, int_1, ldwqswnax.K, ldwqswnax.j, 0));
					int_1 += ldwqswnax.K;
					int_0 -= ldwqswnax.K;
				}
				continue;
			}
			Buffer.BlockCopy(byte_0, int_1, ldwqswnax.w, 0, int_0);
			ldwqswnax.y += int_0;
			break;
		}
		urzhgigvw = 0;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!K)
		{
			K = true;
			Uri uri = new Uri("/Release;component/pagefunction1.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	private void f(int connectionId, object target)
	{
		K = true;
	}

	[CompilerGenerated]
	internal static int G(byte[] byte_0, int int_0, int int_1, int int_2, ref int int_3)
	{
		ldwqswnax.B.Write(byte_0, 0, int_0);
		int_1 += int_2;
		int_3 -= int_2;
		return int_1;
	}
}
