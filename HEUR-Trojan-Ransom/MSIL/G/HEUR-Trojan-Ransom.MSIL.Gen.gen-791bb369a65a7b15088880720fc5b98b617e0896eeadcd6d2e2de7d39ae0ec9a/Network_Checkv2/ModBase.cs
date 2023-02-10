using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using Network_Checkv2.My;

namespace Network_Checkv2;

[StandardModule]
internal sealed class ModBase
{
	public static string Balance = "";

	public static string upDateTime = "60";

	public static bool bolFirstPass;

	public static bool bolTimedVersion;

	public static bool bolEmail;

	public static bool bolScheduled;

	public static string[] strMessageArray = new string[21];

	public static int intTimeout;

	public static string ddns_URL;

	public static bool VPN_Running;

	public static int intRed;

	public static int intGreen;

	public static int intBlue;

	public static bool VPNDirection = false;

	[SpecialName]
	private static Random _0024STATIC_0024GetRandom_002402888_0024Generator;

	[SpecialName]
	private static StaticLocalInitFlag _0024STATIC_0024GetRandom_002402888_0024Generator_0024Init;

	public static bool Is_ProcessRunning(string _strProcname)
	{
		bool result = false;
		try
		{
			Process[] processes = Process.GetProcesses();
			Process[] array = processes;
			foreach (Process process in array)
			{
				if (Operators.CompareString(_strProcname, process.ProcessName, false) == 0)
				{
					int id = process.Id;
					result = true;
				}
			}
			return result;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Console.WriteLine(ex2.Message);
			result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static bool CheckIP_Address_IsValid2(string strAdd)
	{
		Ping ping = new Ping();
		PingReply pingReply = ping.Send(strAdd);
		if (pingReply.Status == IPStatus.Success)
		{
			return true;
		}
		return false;
	}

	public static void Write_ToFile(string strData)
	{
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string text = "C:\\Logs\\RouterLog";
			if (!Directory.Exists(text) && !Directory.Exists(""))
			{
				Directory.CreateDirectory(text);
			}
			text += "\\Info.log";
			if (!File.Exists(text))
			{
				StreamWriter streamWriter = new StreamWriter(text, append: false);
				streamWriter.Write(Conversions.ToString(DateAndTime.get_Now()) + " Created new log file C:\\Logs\\RouterLog\\Info.log  \r\n\r\n");
				streamWriter.Write(Conversions.ToString(DateAndTime.get_Now()) + " " + strData + "\r\n");
				streamWriter.Close();
			}
			else
			{
				StreamWriter streamWriter2 = new StreamWriter(text, append: true);
				streamWriter2.Write(Conversions.ToString(DateAndTime.get_Now()) + " " + strData + "\r\n");
				streamWriter2.Close();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)("Error in Module Modbase: Routine Write_ToFile  Error:- " + Information.Err().get_Description()), (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	public static string FindRunningVersion()
	{
		try
		{
			if (!((ConsoleApplicationBase)MyProject.Application).get_IsNetworkDeployed())
			{
				return "Not Deployed";
			}
			Version version = new Version();
			version = ((ConsoleApplicationBase)MyProject.Application).get_Deployment().get_CurrentVersion();
			return version.ToString();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			string result = "Error";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static int GetRandom(int Min, int Max)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if (_0024STATIC_0024GetRandom_002402888_0024Generator_0024Init == null)
		{
			Interlocked.CompareExchange(ref _0024STATIC_0024GetRandom_002402888_0024Generator_0024Init, new StaticLocalInitFlag(), null);
		}
		bool lockTaken = false;
		try
		{
			Monitor.Enter(_0024STATIC_0024GetRandom_002402888_0024Generator_0024Init, ref lockTaken);
			if (_0024STATIC_0024GetRandom_002402888_0024Generator_0024Init.State == 0)
			{
				_0024STATIC_0024GetRandom_002402888_0024Generator_0024Init.State = 2;
				_0024STATIC_0024GetRandom_002402888_0024Generator = new Random();
			}
			else if (_0024STATIC_0024GetRandom_002402888_0024Generator_0024Init.State == 2)
			{
				throw new IncompleteInitialization();
			}
		}
		finally
		{
			_0024STATIC_0024GetRandom_002402888_0024Generator_0024Init.State = 1;
			if (lockTaken)
			{
				Monitor.Exit(_0024STATIC_0024GetRandom_002402888_0024Generator_0024Init);
			}
		}
		return _0024STATIC_0024GetRandom_002402888_0024Generator.Next(Min, Max);
	}

	public static void Send_Email2(double NewBalance, double oldBalance, double difference)
	{
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		string text = strMessageArray[GetRandom(1, 20)];
		try
		{
			SmtpClient smtpClient = new SmtpClient();
			MailMessage mailMessage = new MailMessage();
			smtpClient.UseDefaultCredentials = false;
			smtpClient.Credentials = new NetworkCredential("adriankjones1@gmail.com", "44Np114rt");
			smtpClient.Port = 587;
			smtpClient.EnableSsl = true;
			smtpClient.Host = "smtp.gmail.com";
			mailMessage = new MailMessage();
			mailMessage.From = new MailAddress("adriankjones1@gmail.com", "Yorkshire Bank Alerter");
			mailMessage.To.Add("jonesadrian@btinternet.com");
			mailMessage.To.Add("andrewleonjones@gmail.com");
			mailMessage.Subject = "Yorkshire Balance Change";
			mailMessage.IsBodyHtml = false;
			mailMessage.Body = text + "\r\nBalance changed from: Old Balance £" + Conversions.ToString(oldBalance) + "  To: New Balance £" + Conversions.ToString(NewBalance) + "\r\n    A Change of £" + Conversions.ToString(difference) + "  Is this really Necessary?";
			smtpClient.Send(mailMessage);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.ToString(), (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	public static void Send_Email3(string StrValue)
	{
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			SmtpClient smtpClient = new SmtpClient();
			MailMessage mailMessage = new MailMessage();
			smtpClient.UseDefaultCredentials = false;
			smtpClient.Credentials = new NetworkCredential("adriankjones1@gmail.com", "44Np114rt");
			smtpClient.Port = 587;
			smtpClient.EnableSsl = true;
			smtpClient.Host = "smtp.gmail.com";
			mailMessage = new MailMessage();
			mailMessage.From = new MailAddress("adriankjones1@gmail.com", "Yorkshire Bank Alerter");
			mailMessage.To.Add("jonesadrian@btinternet.com");
			mailMessage.To.Add("andrewleonjones@gmail.com");
			mailMessage.Subject = "Yorkshire Bank New Message";
			mailMessage.IsBodyHtml = false;
			mailMessage.Body = StrValue;
			smtpClient.Send(mailMessage);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.ToString(), (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	public static string Read_RegKey(string locStr)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		string text = "Test";
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Yorkshire", writable: true);
			text = Conversions.ToString(registryKey.GetValue(locStr));
			return text;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)("Error in Module Modbase: Read_RegKey  Error:- " + Information.Err().get_Description() + "\r\nParameter Passed by locStr:- " + locStr + "\r\nData Returned :- " + text), (MsgBoxStyle)0, (object)null);
			string result = Information.Err().get_Description() + "  Error";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static void Write_RegKey(string locKey, string locstr)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Yorkshire", writable: true);
			registryKey.SetValue(locKey, locstr);
			registryKey.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)("Error in Module Modbase: Write_RegKey  Error:- " + Information.Err().get_Description()), (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	public static void Wait(long seconds)
	{
		DateTime t = DateTime.Now.AddSeconds(seconds);
		while (DateTime.Compare(DateTime.Now, t) < 0)
		{
			Application.DoEvents();
		}
	}
}
