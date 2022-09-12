using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Controls;
using Microsoft.Win32;

namespace WindowsFormsApplication1;

internal class update_app
{
	private struct Update_details
	{
		public string version;

		public List<string> download_files;
	}

	private Form1 form;

	private string exe_name = "";

	public bool new_version_available = false;

	private DialogResult dialogResult;

	public static string folder_path = Directory.GetCurrentDirectory() + "\\help_files";

	public static string folder_path_backup = Directory.GetCurrentDirectory() + "\\help_files\\backup";

	private string cmd_file = "xcopy \".\\*\" \"...\" /e /y\r\ncd ./..\r\nstart .\"Easoty Instagram Bot.exe\"\r\ndel update.cmd\r\nRD /S /Q update";

	public void MakeRequests(Form1 fm, string normal_user)
	{
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Invalid comparison between Unknown and I4
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Invalid comparison between Unknown and I4
		try
		{
			if (!Request_poshmarktools_com(out var response))
			{
				return;
			}
			string text = ReadResponse(response);
			string strB = Assembly.GetExecutingAssembly().GetName().Version!.ToString();
			List<string> list = text.Replace("\r", "").Split(new char[1] { '\n' }).ToList();
			Update_details update_details = default(Update_details);
			update_details.download_files = new List<string>();
			foreach (string item in list)
			{
				if (item.Contains("version>"))
				{
					update_details.version = item.Replace("version>", "");
				}
				else if (item.Contains("exe>"))
				{
					exe_name = item.Replace("exe>", "");
				}
				else if (item.Contains("files>"))
				{
					update_details.download_files.Add(item.Replace("files>", ""));
				}
			}
			int num = update_details.version.CompareTo(strB);
			if (num > 0)
			{
				MetroTextBox status_textBox = Form1.mainform.status_textBox1;
				object obj = _003C_003Ec._003C_003E9__5_0;
				if (obj == null)
				{
					MethodInvoker val = delegate
					{
						((Control)Form1.mainform.update_in_app_button1).set_Visible(true);
					};
					obj = (object)val;
					_003C_003Ec._003C_003E9__5_0 = val;
				}
				((Control)status_textBox).Invoke((Delegate)obj);
				if (normal_user == "just_update_button")
				{
					return;
				}
				if (normal_user == "true")
				{
					Form val2 = new Form();
					val2.set_TopMost(true);
					dialogResult = MessageBox.Show((IWin32Window)val2, "A new version of Poshmark Tools is available, click Yes to update (This will close All Poshmark Running Apps)", "Poshmark Tools Update", (MessageBoxButtons)4, (MessageBoxIcon)48);
					if ((int)dialogResult != 6 && (int)dialogResult == 7)
					{
						return;
					}
				}
				try
				{
					int id = Process.GetCurrentProcess().Id;
					Process[] processes = Process.GetProcesses();
					Process[] array = processes;
					foreach (Process process in array)
					{
						if (process.ProcessName.ToLower().Contains("poshmark_tools") && id != process.Id)
						{
							process.Kill();
						}
					}
				}
				catch
				{
				}
				try
				{
					if (Directory.Exists(folder_path) && File.Exists(folder_path + "\\snk.pk"))
					{
						File.Delete(folder_path + "\\snk.pk");
					}
				}
				catch
				{
				}
				new_version_available = true;
				if (Directory.Exists(Directory.GetCurrentDirectory() + "\\update"))
				{
					DirectoryInfo directoryInfo = new DirectoryInfo(Directory.GetCurrentDirectory() + "\\update");
					foreach (FileInfo item2 in directoryInfo.EnumerateFiles())
					{
						item2.Delete();
					}
				}
				else
				{
					Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\update");
				}
				foreach (string download_file in update_details.download_files)
				{
					using (WebClient webClient = new WebClient())
					{
						webClient.DownloadFile("http://poshmarktools.com/support/mpt/" + download_file, Directory.GetCurrentDirectory() + "\\update\\" + download_file);
					}
					if (!File.Exists(Directory.GetCurrentDirectory() + "\\update\\" + download_file))
					{
						continue;
					}
					try
					{
						ZipFile.ExtractToDirectory(Directory.GetCurrentDirectory() + "\\update\\" + download_file, Directory.GetCurrentDirectory() + "\\update\\");
						try
						{
							File.Delete(Directory.GetCurrentDirectory() + "\\update\\" + download_file);
						}
						catch
						{
						}
					}
					catch
					{
					}
				}
				response.Close();
				EndUpdateProcess();
			}
			response.Close();
		}
		catch (Exception)
		{
		}
	}

	public void move_files()
	{
		check_required_apps();
		try
		{
			if (!Directory.Exists(folder_path))
			{
				Directory.CreateDirectory(folder_path);
			}
			string[] files = Directory.GetFiles(Directory.GetCurrentDirectory());
			string name = Assembly.GetExecutingAssembly().GetName().Name;
			string[] array = files;
			foreach (string text in array)
			{
				if (!text.Contains(name + ".exe") && !text.Contains(name + ".pdb"))
				{
					try
					{
						text.Substring(text.LastIndexOf("\\") + 1, text.Length - (text.LastIndexOf("\\") + 1));
					}
					catch
					{
					}
				}
			}
		}
		catch
		{
		}
	}

	private void check_required_apps()
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		string text = Get45or451FromRegistry();
		if (text != null && !text.Contains("No 4.5 or later version detected"))
		{
			flag = true;
		}
		string text2 = "";
		if (!flag || text == null || text == "")
		{
			Process.Start("https://www.microsoft.com/net/download/dotnet-framework-runtime");
			text2 = "DotNet 4.5 or above";
		}
		if (text2 != "")
		{
			MessageBox.Show("You Dont have " + text2.TrimStart(new char[0]) + " Installed, Install and Run app again");
		}
		if (!flag)
		{
			Environment.Exit(1);
		}
	}

	private static string CheckFor45DotVersion(int releaseKey)
	{
		if (releaseKey >= 393295)
		{
			return "4.6 or later";
		}
		if (releaseKey >= 379893)
		{
			return "4.5.2 or later";
		}
		if (releaseKey >= 378675)
		{
			return "4.5.1 or later";
		}
		if (releaseKey >= 378389)
		{
			return "4.5 or later";
		}
		return "No 4.5 or later version detected";
	}

	public string Get45or451FromRegistry()
	{
		using RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey("SOFTWARE\\Microsoft\\NET Framework Setup\\NDP\\v4\\Full\\");
		if (registryKey != null && registryKey.GetValue("Release") != null)
		{
			return CheckFor45DotVersion((int)registryKey.GetValue("Release"));
		}
		return null;
	}

	private void EndUpdateProcess()
	{
		try
		{
			Form1.thread2.Abort();
		}
		catch
		{
		}
		try
		{
			Form1.restart_thread.Abort();
		}
		catch
		{
		}
		cmd_file = "timeout 5\r\nxcopy \".\\*\" \".\\..\\\" /e /y\r\ncd ./..\r\nstart .\\\"" + exe_name + "\"\r\ndel update.cmd\r\nRD /S /Q update";
		File.WriteAllText(Directory.GetCurrentDirectory() + "\\update\\update.cmd", cmd_file);
		Process process = new Process
		{
			StartInfo = 
			{
				WorkingDirectory = Directory.GetCurrentDirectory() + "/update",
				FileName = Directory.GetCurrentDirectory() + "/update/update.cmd"
			}
		};
		process.Start();
		Environment.Exit(1);
	}

	private string ReadResponse(HttpWebResponse response)
	{
		using Stream stream = response.GetResponseStream();
		Stream stream2 = stream;
		if (response.ContentEncoding.ToLower().Contains("gzip"))
		{
			stream2 = new GZipStream(stream2, CompressionMode.Decompress);
		}
		else if (response.ContentEncoding.ToLower().Contains("deflate"))
		{
			stream2 = new DeflateStream(stream2, CompressionMode.Decompress);
		}
		using StreamReader streamReader = new StreamReader(stream2, Encoding.UTF8);
		return streamReader.ReadToEnd();
	}

	private bool Request_poshmarktools_com(out HttpWebResponse response)
	{
		response = null;
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://poshmarktools.com/support/mpt/update_v2.txt");
			httpWebRequest.KeepAlive = true;
			httpWebRequest.Headers.Set(HttpRequestHeader.CacheControl, "max-age=0");
			httpWebRequest.Headers.Add("Upgrade-Insecure-Requests", "1");
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/65.0.3325.181 Safari/537.36";
			httpWebRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8";
			httpWebRequest.Referer = "http://poshmarktools.com/support/mpt/";
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate");
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptLanguage, "en-US,en;q=0.9");
			httpWebRequest.Headers.Set(HttpRequestHeader.Cookie, "nc_sid=gcr1zIkiHDdPSbPqE_dN; _ga=GA1.2.1366732152.1515688091; phpbb3_49n45_u=56; phpbb3_49n45_k=933d71125e19edac; phpbb3_49n45_sid=47ef2b453c0f587d483c34746bfd356c; wplc_chat_status=5; _icl_current_language=en; _gid=GA1.2.566810469.1522846137; _gat=1; nc_status=browsing; wplc_cid=rkwTtrMsf_1522846143200");
			response = (HttpWebResponse)httpWebRequest.GetResponse();
		}
		catch (WebException ex)
		{
			if (ex.Status != WebExceptionStatus.ProtocolError)
			{
				return false;
			}
			response = (HttpWebResponse)ex.Response;
		}
		catch (Exception)
		{
			if (response != null)
			{
				response.Close();
			}
			return false;
		}
		return true;
	}
}
