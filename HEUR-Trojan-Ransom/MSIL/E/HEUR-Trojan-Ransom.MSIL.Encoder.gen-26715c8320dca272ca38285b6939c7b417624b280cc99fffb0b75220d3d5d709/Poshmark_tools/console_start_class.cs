using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace Poshmark_tools;

internal class console_start_class
{
	public static loading_form ld;

	public void main()
	{
		ServicePointManager.Expect100Continue = true;
		ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
		Thread thread = new Thread(addloadin_form);
		thread.SetApartmentState(ApartmentState.STA);
		thread.Start();
		for (int i = 0; i < 2; i++)
		{
			load_thread();
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

	public static void load_thread()
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		int workerThreads = 0;
		int completionPortThreads = 0;
		int workerThreads2 = 0;
		ThreadPool.SetMaxThreads(5, 5);
		List<string> list = new List<string>();
		list.Add("EO.Base.dll");
		list.Add("EO.WebBrowser.dll");
		list.Add("EO.WebBrowser.WinForm.dll");
		foreach (string item in list)
		{
			if (!(item == "") && !File.Exists(Directory.GetCurrentDirectory() + "\\" + item))
			{
				try
				{
					ThreadPool.QueueUserWorkItem(test_threading, item);
				}
				catch (Exception ex)
				{
					MessageBox.Show("as" + ex.ToString());
				}
			}
		}
		while (true)
		{
			ThreadPool.GetMaxThreads(out workerThreads, out completionPortThreads);
			ThreadPool.GetAvailableThreads(out workerThreads2, out completionPortThreads);
			if (workerThreads2 == workerThreads)
			{
				break;
			}
			Thread.Sleep(TimeSpan.FromMilliseconds(1000.0));
		}
		list = new List<string>();
		list.Add("EO.WebEngine.dll");
		foreach (string item2 in list)
		{
			if (!(item2 == "") && !File.Exists(Directory.GetCurrentDirectory() + "\\" + item2))
			{
				try
				{
					ThreadPool.QueueUserWorkItem(test_threading, item2);
				}
				catch (Exception ex2)
				{
					MessageBox.Show("as" + ex2.ToString());
				}
			}
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

	public static void test_threading(object data)
	{
		string text = (string)data;
		try
		{
			if (text == "EO.Base.dll" && !File.Exists(Directory.GetCurrentDirectory() + "\\EO.Base.dll"))
			{
				using WebClient webClient = new WebClient();
				webClient.DownloadFile("http://poshmarktools.com/support/mpt/EO/EO.Base.dll", Directory.GetCurrentDirectory() + "\\EO.Base.dll");
			}
			if (text == "EO.WebBrowser.dll" && !File.Exists(Directory.GetCurrentDirectory() + "\\EO.WebBrowser.dll"))
			{
				using WebClient webClient2 = new WebClient();
				webClient2.DownloadFile("http://poshmarktools.com/support/mpt/EO/EO.WebBrowser.dll", Directory.GetCurrentDirectory() + "\\EO.WebBrowser.dll");
			}
			if (text == "EO.WebBrowser.WinForm.dll" && !File.Exists(Directory.GetCurrentDirectory() + "\\EO.WebBrowser.WinForm.dll"))
			{
				using WebClient webClient3 = new WebClient();
				webClient3.DownloadFile("http://poshmarktools.com/support/mpt/EO/EO.WebBrowser.WinForm.dll", Directory.GetCurrentDirectory() + "\\EO.WebBrowser.WinForm.dll");
			}
			if (text == "EO.WebEngine.dll" && !File.Exists(Directory.GetCurrentDirectory() + "\\EO.WebEngine.dll"))
			{
				using (WebClient webClient4 = new WebClient())
				{
					webClient4.DownloadFile("http://poshmarktools.com/support/mpt/EO/EO.WebEngine.dll", Directory.GetCurrentDirectory() + "\\EO.WebEngine.dll");
					return;
				}
			}
		}
		catch (Exception)
		{
		}
	}

	private void addloadin_form()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			loading_form loading_form = new loading_form();
			((Form)loading_form).ShowDialog();
		}
		catch (Exception)
		{
		}
	}
}
