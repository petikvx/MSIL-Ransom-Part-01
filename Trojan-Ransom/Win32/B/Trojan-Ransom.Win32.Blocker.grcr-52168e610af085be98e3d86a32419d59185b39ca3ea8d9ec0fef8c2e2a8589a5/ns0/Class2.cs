#define DEBUG
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using YoutubeFeedUpdater.Classes;

namespace ns0;

internal class Class2 : ITask
{
	private static int int_0 = 0;

	private readonly string string_0;

	private readonly WebBrowser webBrowser_0;

	public bool bool_0;

	public Class2(string string_1, WebBrowser webBrowser_1)
	{
		string_0 = string_1;
		if (string_0.ToLower().Contains("youtube.com"))
		{
			string_0 += "&html5=1&rel=0";
		}
		webBrowser_0 = webBrowser_1;
	}

	public void Run(TaskSystem taskSystem)
	{
		taskSystem.LogCallBack($"{((Control)taskSystem.HostWebBrowser).get_Name()} - Loading {string_0}");
		try
		{
			method_0();
			while (!bool_0)
			{
				Thread.Sleep(100);
			}
			_ = 1 == 0;
		}
		catch (Exception ex)
		{
			taskSystem.LogCallBack("Error: " + ex);
		}
	}

	private void method_0()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		((Control)webBrowser_0).Invoke((Delegate)(MethodInvoker)delegate
		{
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			webBrowser_0.Navigate(string_0);
			webBrowser_0.add_DocumentCompleted(new WebBrowserDocumentCompletedEventHandler(webBrowser_0_DocumentCompleted));
		});
	}

	private void webBrowser_0_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		bool_0 = true;
		webBrowser_0.remove_DocumentCompleted(new WebBrowserDocumentCompletedEventHandler(webBrowser_0_DocumentCompleted));
	}

	public override string ToString()
	{
		return $"Loading Site - URL: {string_0}";
	}

	[CompilerGenerated]
	private void method_1()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		bool flag = false;
		if (int_0 == 0)
		{
			foreach (HtmlElement item in webBrowser_0.get_Document().get_All())
			{
				HtmlElement val = item;
				if (val.GetAttribute("href").StartsWith("http://www.googleadservices.com/pagead/aclk?"))
				{
					webBrowser_0.Navigate(val.GetAttribute("href"));
					flag = true;
					Debug.Print("Clicked ad Type3");
				}
			}
		}
		if (flag)
		{
			int_0++;
		}
		if (int_0 > 3)
		{
			int_0 = 0;
		}
	}

	[CompilerGenerated]
	private void method_2()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		webBrowser_0.Navigate(string_0);
		webBrowser_0.add_DocumentCompleted(new WebBrowserDocumentCompletedEventHandler(webBrowser_0_DocumentCompleted));
	}
}
