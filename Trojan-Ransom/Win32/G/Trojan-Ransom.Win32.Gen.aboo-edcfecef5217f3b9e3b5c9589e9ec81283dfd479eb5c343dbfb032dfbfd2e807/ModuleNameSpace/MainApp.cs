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
		//IL_0511: Unknown result type (might be due to invalid IL or missing references)
		//IL_0517: Invalid comparison between Unknown and I4
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
					string @string = Encoding.UTF8.GetString(Convert.FromBase64String("IyBAQXV0aG9yOglQYXRyaWNrIE1jRmFybGFuZA0KIyBARGF0ZToJMDcuMDMuMjAyMQ0KDQojIFRoaXMgc2NyaXB0IGlzIGRlc2lnbmVkIHRvIGhlbHAgcmVtb3ZlIGl0ZW1zIGZyb20gd2l0aGluIG11bHRpcGxlIHN1YmZvbGRlcnMgaW50byB0aGUgc2VsZWN0ZWQgcm9vdCBmb2xkZXIuDQoNCkFkZC1UeXBlIC1hc3NlbWJseSBTeXN0ZW0uV2luZG93cy5Gb3Jtcw0KDQojY3JlYXRlcyBuZXcgZm9ybQ0KJG1haW5fZm9ybSA9IE5ldy1PYmplY3QgU3lzdGVtLldpbmRvd3MuRm9ybXMuRm9ybQ0KDQojc2V0cyB0aGUgaW5pdGlhbCBhdHJpYnV0ZXMgb2YgdGhlIGZvcm0NCiRtYWluX2Zvcm0uVGV4dCA9J0RlLUZvbGRpbmF0b3InDQokbWFpbl9mb3JtLldpZHRoID0gNTUwDQokbWFpbl9mb3JtLkhlaWdodCA9IDMwMA0KJG1haW5fZm9ybS5BdXRvU2l6ZSA9ICR0cnVlDQoNCiNjcmVhdGluZyBhIGxhYmVsIGZvciBpbnN0cnVjdGlvbnMNCiRMYWJlbDAgPSBOZXctT2JqZWN0IFN5c3RlbS5XaW5kb3dzLkZvcm1zLkxhYmVsDQokTGFiZWwwLlRleHQgPSAiVGhpcyBzY3JpcHQgd2lsbCBleHRyYWN0IHRoZSBjb250ZW50cyBvZiBhbGwgc3ViZm9sZXJzIGludG8gdGhlIHNlbGVjdGVkIHJvb3QgZm9sZGVyIg0KJExhYmVsMC5Mb2NhdGlvbiAgPSBOZXctT2JqZWN0IFN5c3RlbS5EcmF3aW5nLlBvaW50KDcwLDEwKQ0KJExhYmVsMC5BdXRvU2l6ZSA9ICR0cnVlDQokbWFpbl9mb3JtLkNvbnRyb2xzLkFkZCgkTGFiZWwwKQ0KDQojY3JlYXRpbmcgYSBsYWJlbCBmb3IgZm9sZGVyIGNob29zZXINCiRMYWJlbCA9IE5ldy1PYmplY3QgU3lzdGVtLldpbmRvd3MuRm9ybXMuTGFiZWwNCiRMYWJlbC5UZXh0ID0gIlJvb3QgRm9sZGVyIg0KJExhYmVsLkxvY2F0aW9uICA9IE5ldy1PYmplY3QgU3lzdGVtLkRyYXdpbmcuUG9pbnQoNTUsOTApDQokTGFiZWwuQXV0b1NpemUgPSAkdHJ1ZQ0KJG1haW5fZm9ybS5Db250cm9scy5BZGQoJExhYmVsKQ0KDQojY3JlYXRpbmcgYSB0ZXh0Ym94IGZvciBjdXJyZW50IGxvY2F0aW9uDQokdGV4dEJveDEgPSBOZXctT2JqZWN0IFN5c3RlbS5XaW5kb3dzLkZvcm1zLlRleHRCb3gNCiR0ZXh0Qm94MS5Mb2NhdGlvbiA9IE5ldy1PYmplY3QgU3lzdGVtLkRyYXdpbmcuUG9pbnQoNDAsMTEwKQ0KJHRleHRCb3gxQXV0b1NpemUgPSAkdHJ1ZQ0KJHRleHRCb3gxLlRleHQgPSAiQzpcIg0KJG1haW5fZm9ybS5Db250cm9scy5BZGQoJHRleHRCb3gxKQ0KDQojcGlja2luZyB0aGUgcm9vdCBkaXJlY3RvcnkNCkZ1bmN0aW9uIEdldC1Gb2xkZXIoJGluaXRpYWxEaXJlY3Rvcnk9IiIpDQp7DQogICAgW1N5c3RlbS5SZWZsZWN0aW9uLkFzc2VtYmx5XTo6TG9hZFdpdGhQYXJ0aWFsTmFtZSgiU3lzdGVtLndpbmRvd3MuZm9ybXMiKXxPdXQtTnVsbA0KDQogICAgJGZvbGRlcm5hbWUgPSBOZXctT2JqZWN0IFN5c3RlbS5XaW5kb3dzLkZvcm1zLkZvbGRlckJyb3dzZXJEaWFsb2cNCiAgICAkZm9sZGVybmFtZS5EZXNjcmlwdGlvbiA9ICJTZWxlY3QgYSBmb2xkZXIiDQogICAgJGZvbGRlcm5hbWUucm9vdGZvbGRlciA9ICJNeUNvbXB1dGVyIg0KICAgICRmb2xkZXJuYW1lLlNlbGVjdGVkUGF0aCA9ICRpbml0aWFsRGlyZWN0b3J5DQoNCiAgICBpZigkZm9sZGVybmFtZS5TaG93RGlhbG9nKCkgLWVxICJPSyIpDQogICAgew0KICAgICAgICAkZm9sZGVyICs9ICRmb2xkZXJuYW1lLlNlbGVjdGVkUGF0aA0KICAgIH0NCiAgICByZXR1cm4gJGZvbGRlcg0KfQ0KDQojYWRkcyBidXR0b24gdG8gdHJpZ2dlciBmb2xkZXIgcGlja2VyIGRpYWxvZw0KJEJ1dHRvbiA9IE5ldy1PYmplY3QgU3lzdGVtLldpbmRvd3MuRm9ybXMuQnV0dG9uDQokQnV0dG9uLkxvY2F0aW9uID0gTmV3LU9iamVjdCBTeXN0ZW0uRHJhd2luZy5TaXplKDIxMCw2MCkNCiRCdXR0b24uU2l6ZSA9IE5ldy1PYmplY3QgU3lzdGVtLkRyYXdpbmcuU2l6ZSgxMjAsMjUpDQokQnV0dG9uLlRleHQgPSAiQ2hvb3NlIFJvb3QgRm9sZGVyIg0KJG1haW5fZm9ybS5Db250cm9scy5BZGQoJEJ1dHRvbikNCg0KJEJ1dHRvbi5BZGRfQ2xpY2soDQp7DQoJJGEgPSBHZXQtRm9sZGVyDQoJJHRleHRCb3gxLnRleHQgPSAkYQ0KfQ0KKQ0KDQojYWRkcyBidXR0b24gdG8gZXh0cmFjdCBjb250ZW50cyBvZiBzdWJmb2xkZXJzDQokQnV0dG9uMiA9IE5ldy1PYmplY3QgU3lzdGVtLldpbmRvd3MuRm9ybXMuQnV0dG9uDQokQnV0dG9uMi5Mb2NhdGlvbiA9IE5ldy1PYmplY3QgU3lzdGVtLkRyYXdpbmcuU2l6ZSgyMTAsMTYwKQ0KJEJ1dHRvbjIuU2l6ZSA9IE5ldy1PYmplY3QgU3lzdGVtLkRyYXdpbmcuU2l6ZSgxMjAsNjApDQokQnV0dG9uMi5UZXh0ID0gIkV4dHJhY3QiDQokbWFpbl9mb3JtLkNvbnRyb2xzLkFkZCgkQnV0dG9uMikNCg0KJEJ1dHRvbjIuQWRkX0NsaWNrKA0Kew0KCWNkICR0ZXh0Qm94MS50ZXh0DQoJR2V0LUNoaWxkSXRlbSAtRmlsZSAtUmVjdXJzZSB8IE1vdmUtSXRlbSAtRGVzdGluYXRpb24gLg0KCQ0KCSRwb3AgPSBuZXctb2JqZWN0IC1jb21vYmplY3Qgd3NjcmlwdC5zaGVsbA0KCSRwb3AyID0gJHBvcC5wb3B1cCgiRmlsZXMgRXh0cmFjdGVkIiwwLCJFeHRyYWN0ZWQiLDEpDQp9DQopDQoNCiNkaXNwbGF5cyB0aGUgZ3VpDQokbWFpbl9mb3JtLlNob3dEaWFsb2coKQ=="));
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
							else if (match.Groups[2].Value == "True" || match.Groups[2].Value.ToUpper() == "$TRUE")
							{
								pwsh.AddParameter(match.Groups[1].Value, (object)true);
								text4 = null;
							}
							else if (match.Groups[2].Value == "False" || match.Groups[2].Value.ToUpper() == "$FALSE")
							{
								pwsh.AddParameter(match.Groups[1].Value, (object)false);
								text4 = null;
							}
							else
							{
								pwsh.AddParameter(match.Groups[1].Value, (object)match.Groups[2].Value);
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
