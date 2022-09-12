using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace Poshmark_tools;

internal class console_start_class
{
	public void main()
	{
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			int workerThreads = 0;
			int completionPortThreads = 0;
			int workerThreads2 = 0;
			ThreadPool.SetMaxThreads(30, 30);
			List<string> list = new List<string>();
			foreach (string item in list)
			{
				ThreadPool.QueueUserWorkItem(test_threading, item);
			}
			while (true)
			{
				ThreadPool.GetMaxThreads(out workerThreads, out completionPortThreads);
				ThreadPool.GetAvailableThreads(out workerThreads2, out completionPortThreads);
				if (workerThreads2 != workerThreads)
				{
					Thread.Sleep(TimeSpan.FromMilliseconds(1000.0));
					continue;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show("as3" + ex.ToString());
		}
		try
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run((Form)(object)new windowsform());
		}
		catch
		{
		}
	}

	public static void test_threading(object data)
	{
		string text = (string)data;
		try
		{
			if (text == "MetroFramework.dll" && !File.Exists(Directory.GetCurrentDirectory() + "\\MetroFramework.dll"))
			{
				using WebClient webClient = new WebClient();
				webClient.DownloadFile("http://poshmarktools.com/support/mpt/dlls/MetroFramework.dll", Directory.GetCurrentDirectory() + "\\MetroFramework.dll");
			}
			if (text == "MetroFramework.Fonts.dll" && !File.Exists(Directory.GetCurrentDirectory() + "\\MetroFramework.Fonts.dll"))
			{
				using WebClient webClient2 = new WebClient();
				webClient2.DownloadFile("http://poshmarktools.com/support/mpt/dlls/MetroFramework.Fonts.dll", Directory.GetCurrentDirectory() + "\\MetroFramework.Fonts.dll");
			}
			if (text == "Geckofx-Core.dll" && !File.Exists(Directory.GetCurrentDirectory() + "\\Geckofx-Core.dll"))
			{
				using WebClient webClient3 = new WebClient();
				webClient3.DownloadFile("http://poshmarktools.com/support/mpt/dlls/Geckofx-Core.dll", Directory.GetCurrentDirectory() + "\\Geckofx-Core.dll");
			}
			if (text == "Geckofx-Winforms.dll" && !File.Exists(Directory.GetCurrentDirectory() + "\\Geckofx-Winforms.dll"))
			{
				using (WebClient webClient4 = new WebClient())
				{
					webClient4.DownloadFile("http://poshmarktools.com/support/mpt/dlls/Geckofx-Winforms.dll", Directory.GetCurrentDirectory() + "\\Geckofx-Winforms.dll");
					return;
				}
			}
		}
		catch
		{
		}
	}
}
